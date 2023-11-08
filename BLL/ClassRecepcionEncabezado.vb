Imports dall.DataSetfacturaTableAdapters
Imports dall.DataSetClienteTableAdapters
Imports System.Transactions

Public Class ClassRecepcionEncabezado


#Region "atributos"
    Private adaptadorRE As recepcion_encabezadoTableAdapter
    Private adaptadorRC As recepcion_cuerpoTableAdapter
    Private adaptadorRAE As recepcion_encabezadoTableAdapter
    Private adaptadorRAC As recepcion_cuerpoTableAdapter
    Private maxcliente As ClienteTableAdapter
#End Region

#Region "propiedad"

    Private ReadOnly Property _maxcliente As ClienteTableAdapter
        Get
            If maxcliente Is Nothing Then
                maxcliente = New ClienteTableAdapter()
            End If
            Return maxcliente
        End Get
    End Property



    Private ReadOnly Property ADAPTADOR_RaC As recepcion_cuerpoTableAdapter
        Get
            If adaptadorRAC Is Nothing Then
                adaptadorRAC = New recepcion_cuerpoTableAdapter()
            End If
            Return adaptadorRAC
        End Get

    End Property

    Private ReadOnly Property ADAPTADOR_RaE As recepcion_encabezadoTableAdapter
        Get
            If adaptadorRAE Is Nothing Then
                adaptadorRAE = New recepcion_encabezadoTableAdapter
            End If
            Return adaptadorRAE
        End Get
    End Property

    Private ReadOnly Property ADAPTADOR_RE As recepcion_encabezadoTableAdapter
        Get
            If adaptadorRE Is Nothing Then
                adaptadorRE = New recepcion_encabezadoTableAdapter
            End If
            Return adaptadorRE
        End Get
    End Property

    Private ReadOnly Property ADAPTADOR_RC As recepcion_cuerpoTableAdapter
        Get
            If adaptadorRC Is Nothing Then
                adaptadorRC = New recepcion_cuerpoTableAdapter()
            End If
            Return adaptadorRC
        End Get

    End Property

#End Region


#Region "metodos"


    Public Function SiguienteCliente() As Integer
        Dim sigui As Integer
        sigui = 0
        Try
            sigui = _maxcliente.ScalarQueryMAXcliente() + 1

        Catch ex As Exception
            sigui = 1
        End Try
        Return sigui


    End Function

    Public Function calculasiguientecaso() As Integer
        Dim siguiente As Integer
        siguiente = 0
        Try
            siguiente = ADAPTADOR_RE.ScalarQueryMaximoNumeroE() + 1

        Catch ex As Exception
            siguiente = 1
        End Try
        Return siguiente
    End Function

    Public Function actualizaFactura(ByVal no_caso As String, ByVal id_usuario As String, ByVal no_cliente As String, ByVal detalle As List(Of ClassRecepcionCuerpo_)) As String
        Dim resp, x As Integer
        ' sigu = calculasiguientecaso()
        Dim trans As New TransactionScope()
        Using (trans)
            Try
                '        If (sigu > 0) Then
                resp = ADAPTADOR_RE.UpdateQueryEncabezadoFactura(Val(id_usuario), Val(no_cliente), no_caso)
                x = 0
                If resp <> 0 Then
                    While (detalle.Count > x)


                        Actulizadetalle(detalle(x).id_recepcion, detalle(x).id_estado, detalle(x).id_equipo, detalle(x).caracteristicas, detalle(x).accesorio, detalle(x).accesorio1, detalle(x).problema_tecnico, detalle(x).trabajo_realizar, detalle(x).tota, detalle(x).anticipo, detalle(x).fecha)
                        'Actulizadetalle(detalle(x).id_estado, detalle(x).id_equipo, detalle(x).caracteristicas, detalle(x).accesorio, detalle(x).accesorio1, detalle(x).problema_tecnico, detalle(x).trabajo_realizar, detalle(x).tota, detalle(x).anticipo)
                        x = x + 1
                    End While
                End If

            Catch ex As Exception
                Return "Error no fue posible Actualizar la Aplicacion"
            End Try
            trans.Complete()
        End Using

        Return "Se ha Actualizado con éxito la La Aplicacion"

    End Function
    Public Function grabafactura(ByVal id_usuario As String, ByVal no_cliente As String, ByVal detalle As List(Of ClassRecepcionCuerpo_)) As String
        Dim sigu, resp, x As Integer
        sigu = calculasiguientecaso()
        Dim trans As New TransactionScope()
        Using (trans)
            Try
                If (sigu > 0) Then
                    resp = ADAPTADOR_RE.InsertQueryEncabezadoFactura(sigu, Val(id_usuario), Val(no_cliente))
                    x = 0
                    If resp <> 0 Then
                        While (detalle.Count > x)
                            grabadetalle(sigu, detalle(x).id_estado, detalle(x).id_equipo, detalle(x).caracteristicas, detalle(x).accesorio, detalle(x).accesorio1, detalle(x).problema_tecnico, detalle(x).trabajo_realizar, detalle(x).tota, detalle(x).anticipo)
                            x = x + 1
                        End While
                    End If
                End If
            Catch ex As Exception
                Return "Error no fue posible grabar la factura"
            End Try
            trans.Complete()
        End Using

        Return "Se ha grabado con éxito la factura"

    End Function
    Private Function grabadetalle(ByVal id_recepcion As Integer, ByVal id_estado As Integer, ByVal id_equipo As Integer, ByVal caracteristicas As String, ByVal accesorio As String, ByVal accesorio1 As String, ByVal problema_tecnico As String, ByVal trabajo_realizar As String, ByVal total As String, ByVal anticipo As String)
        Dim r As Integer
        r = 0
        r = ADAPTADOR_RC.InsertQueryRecepcionCuerpo(id_recepcion, id_estado, id_equipo, caracteristicas, accesorio, accesorio1, problema_tecnico, trabajo_realizar, total, anticipo, DateTime.Now)
        Return r
    End Function


    Private Function Actulizadetalle(ByVal id_recepcion As Integer, ByVal id_estado As Integer, ByVal id_equipo As Integer, ByVal caracteristicas As String, ByVal accesorio As String, ByVal accesorio1 As String, ByVal problema_tecnico As String, ByVal trabajo_realizar As String, ByVal total As String, ByVal anticipo As String, ByVal fecha As String)
        Dim a As Integer
        a = 0
        a = ADAPTADOR_RaC.UpdateQueryCuerpo(id_estado, id_equipo, caracteristicas, accesorio, accesorio1, problema_tecnico, trabajo_realizar, total, anticipo, DateTime.Now, id_recepcion)
        Return a
    End Function




#End Region



















End Class
