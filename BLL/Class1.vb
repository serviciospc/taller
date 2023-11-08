Imports dall.DataSetClienteTableAdapters
Imports dall.DataSetRecepcionCuerpoTableAdapters
Imports dall.DataSetRecividoTableAdapters
Imports dall.DataSetTecnicoTableAdapters


Public Class Class1


#Region "atributo"
    Private _cliente As ClienteTableAdapter
    Private _cuerpo As recepcion_cuerpoTableAdapter
    Private _listaRecivido As DataTable1TableAdapter
    Private _listaEsperando As DataTable1TableAdapter
    Private _listaTerminado As DataTable1TableAdapter
    Private _listaEntregado As DataTable1TableAdapter
    Private _listaTecnico As usuarioTableAdapter
    Private _listaTecnicoC As usuario1TableAdapter
    Private _brecividoT As DataTable1TableAdapter
    Private _buscaRXfecha As DataTable1TableAdapter
    Private _entregaXFecha As DataTable1TableAdapter
    Private _estadoXTF As DataTable1TableAdapter
#End Region


#Region "propiedad"
    Private ReadOnly Property entregaXFecha As DataTable1TableAdapter
        Get
            If _entregaXFecha Is Nothing Then
                _entregaXFecha = New DataTable1TableAdapter()
            End If
            Return _entregaXFecha

        End Get
    End Property


    Private ReadOnly Property estadoXTF As DataTable1TableAdapter
        Get
            If _estadoXTF Is Nothing Then
                _estadoXTF = New DataTable1TableAdapter()
            End If
            Return _estadoXTF

        End Get
    End Property

    Private ReadOnly Property buscaRXfecha As DataTable1TableAdapter
        Get
            If _buscaRXfecha Is Nothing Then
                _buscaRXfecha = New DataTable1TableAdapter()
            End If
            Return _buscaRXfecha

        End Get
    End Property




    Private ReadOnly Property brecividoT As DataTable1TableAdapter
        Get
            If _brecividoT Is Nothing Then
                _brecividoT = New DataTable1TableAdapter
            End If
            Return _brecividoT

        End Get
    End Property

    Private ReadOnly Property LTecnico As usuarioTableAdapter
        Get
            If _listaTecnico Is Nothing Then
                _listaTecnico = New usuarioTableAdapter
            End If
            Return _listaTecnico

        End Get
    End Property

    Private ReadOnly Property LtecnicoC As usuario1TableAdapter
        Get
            If _listaTecnicoC Is Nothing Then
                _listaTecnicoC = New usuario1TableAdapter
            End If
            Return _listaTecnicoC
        End Get
    End Property


    Private ReadOnly Property ListaEntregado As DataTable1TableAdapter
        Get
            If _listaEntregado Is Nothing Then
                _listaEntregado = New DataTable1TableAdapter
            End If
            Return _listaEntregado

        End Get
    End Property
    Private ReadOnly Property Listaterminado As DataTable1TableAdapter
        Get
            If _listaTerminado Is Nothing Then
                _listaTerminado = New DataTable1TableAdapter
            End If
            Return _listaTerminado

        End Get
    End Property

    Private ReadOnly Property Listaesperando As DataTable1TableAdapter
        Get
            If _listaEsperando Is Nothing Then
                _listaEsperando = New DataTable1TableAdapter
            End If
            Return _listaEsperando

        End Get
    End Property

    Private ReadOnly Property ListaRecivido As DataTable1TableAdapter
        Get
            If _listaRecivido Is Nothing Then
                _listaRecivido = New DataTable1TableAdapter
            End If
            Return _listaRecivido

        End Get
    End Property




    Private ReadOnly Property cuerpo As recepcion_cuerpoTableAdapter
        Get
            If _cuerpo Is Nothing Then
                _cuerpo = New recepcion_cuerpoTableAdapter

            End If
            Return _cuerpo

        End Get
    End Property

    Private ReadOnly Property cliente As ClienteTableAdapter
        Get
            If _cliente Is Nothing Then
                _cliente = New ClienteTableAdapter

            End If
            Return _cliente
        End Get
    End Property
#End Region

#Region "Metodo"


    Public Function insertaCliente(ByVal _nombre As String, ByVal _apellido As String, ByVal _tel1 As String, ByVal _tel2 As String, ByVal _tel3 As String, ByVal _tel4 As String) As String

        Dim respuesta As String

        If (_nombre <> "" And _apellido <> "" And _tel1 <> "" And _tel2 <> "" And _tel3 <> "" And _tel4 <> "") Then

            Try
                cliente.InsertQuerycliente(_nombre, _apellido, _tel1, _tel2, _tel3, _tel4)
                respuesta = " Se grabo Exitosamente"
            Catch ex As Exception
                respuesta = "Error Revice" & ex.Message
            End Try
        Else
            respuesta = "Error: informacion vacia, se requiere algun dato "
        End If
        Return respuesta
    End Function

    Public Function ListaTecnico() As DataTable
        Dim resultado As New DataTable
        resultado = LTecnico.GetDataBy
        Return resultado
    End Function

    Public Function listaTecnicoC() As DataTable

        Dim resultado1 As New DataTable
        resultado1 = LtecnicoC.GetDataByusuarioc
        Return resultado1

    End Function



    Public Function listarcliente() As DataTable
        Dim resultado As New DataTable
        resultado = cliente.GetDataByListaCliente
        Return resultado
    End Function


    Public Function Recivido() As DataTable
        Dim resultado As New DataTable
        resultado = ListaRecivido.GetDataByRecivido
        Return resultado
    End Function

    Public Function Esperando() As DataTable
        Dim resultado As New DataTable
        resultado = Listaesperando.GetDataByEsperando
        Return resultado
    End Function

    Public Function Terminado() As DataTable
        Dim resultado As New DataTable
        resultado = Listaterminado.GetDataByTerminado
        Return resultado
    End Function

    Public Function entregado() As DataTable
        Dim resultado As New DataTable
        resultado = ListaEntregado.GetDataByEntregado
        Return resultado
    End Function
    'por fecha
    Public Function RecividoXF(ByVal _fecha_i As String, ByVal _fecha_f As String) As DataTable
        Dim tabla As New DataTable
        If (_fecha_i <> "" And _fecha_f <> "") Then

            tabla = buscaRXfecha.GetDataByRecividoFecha(_fecha_i, _fecha_f)
        Else
            tabla = Nothing
        End If
        Return tabla



    End Function


    'Entregado por fecha
    Public Function EntregadoXFECHA(ByVal _fecha_i As String, ByVal _fecha_f As String, ByVal _Tecnico As String) As DataTable
        Dim tabla As New DataTable
        If (_fecha_i <> "" And _fecha_f <> "" And _Tecnico <> "") Then

            tabla = entregaXFecha.GetDataByentregadoXF(_fecha_i, _fecha_f, _Tecnico)
        Else
            tabla = Nothing
        End If
        Return tabla
    End Function

    'busqueda Estado x Tecnico y fecha
    Public Function EstadooxTecnicoXfecha(ByVal _idestado As String, ByVal _fecha_i As String, ByVal _fecha_f As String, ByVal _Tecnico As String) As DataTable
        Dim tabla As New DataTable
        If (_idestado <> "" And _fecha_i <> "" And _fecha_f <> "" And _Tecnico <> "") Then
            tabla = estadoXTF.GetDataByEstadoTecnicoFecha(_idestado, _fecha_i, _fecha_f, _Tecnico)
            ' tabla = estadoXtecnicoXfecha.GetDataByEstadoTecnicoFecha(_idestado, _fecha_i, _fecha_f, _Tecnico)

        Else
            tabla = Nothing
        End If
        Return tabla



    End Function







    Public Function buscaRXT(ByVal _no_usuario As String) As DataTable
        Dim tabla As DataTable
        If (_no_usuario <> "") Then
            tabla = brecividoT.GetDataByRecividoT(_no_usuario)
        Else
            tabla = Nothing

        End If
        Return tabla
    End Function




    Public Function buscaclienteno(ByVal _no_cliente As String) As DataTable
        Dim tabla As DataTable
        If (_no_cliente <> "") Then
            tabla = cliente.GetDataByBClienteNo(_no_cliente)
        Else
            tabla = Nothing

        End If
        Return tabla
    End Function





    Public Function ClienteNombre(ByVal _nombre As String) As DataTable

        Dim tabla As DataTable
        If (_nombre <> "") Then

            tabla = cliente.GetDataByBclienteNombre(_nombre)
        Else
            tabla = Nothing
        End If
        Return tabla

    End Function

    Public Function actualizaC(ByVal _no_cliente As String, ByVal _nombre As String, ByVal _apellido As String, ByVal _tel_1 As String, ByVal _tel_2 As String, ByVal _tel_3 As String, ByVal _tel_4 As String) As String
        Dim res As String
        If (_no_cliente <> "" And _nombre <> "" And _apellido <> "" And _tel_1 <> "" And _tel_2 <> "" And _tel_3 <> "" And _tel_4 <> "") Then
            Try
                cliente.UpdateQueryCliente(_nombre, _apellido, _tel_1, _tel_2, _tel_3, _tel_4, _no_cliente)
                res = "se actualizo cliente"
            Catch ex As Exception

                res = " Error: Revice! " + ex.Message

            End Try
        Else
            res = "eror: existe inf vacia, "

        End If
        Return res
    End Function

    Public Function actualizaEstado(ByVal _id_recepcion As String, ByVal _id_estado As String) As String
        Dim resp As String
        If (_id_recepcion <> "" And _id_estado <> "") Then
            Try
                cuerpo.UpdateQueryEstadoRC(_id_estado, _id_recepcion)
                resp = "se actualizo Estado"


            Catch ex As Exception
                resp = "Error: Revice! " + ex.Message

            End Try
        Else
            resp = "Error: existe inf vacia, "
        End If
        Return resp




    End Function










#End Region

End Class
