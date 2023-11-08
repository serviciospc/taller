Imports dall.DataSetEstadpTableAdapters

Public Class ClassEstado
#Region "atributo"
    Private _estado As estado_equipoTableAdapter
    Private _equipo As equipoTableAdapter
    Private _bestado As equipoTableAdapter
#End Region


#Region "propiedad"
    Private ReadOnly Property bestado As equipoTableAdapter
        Get
            If _bestado Is Nothing Then
                _bestado = New equipoTableAdapter
            End If
            Return _bestado

        End Get
    End Property

    Private ReadOnly Property estado As estado_equipoTableAdapter

        Get
            If _estado Is Nothing Then
                _estado = New estado_equipoTableAdapter
            End If
            Return _estado

        End Get
    End Property
#End Region

    Private ReadOnly Property equipo As equipoTableAdapter
        Get
            If _equipo Is Nothing Then
                _equipo = New equipoTableAdapter
            End If
            Return _equipo
        End Get
    End Property

#Region "metodo"
    Public Function ListaEstadoF(ByVal _id_recepcion) As DataTable
        Dim tabla As DataTable
        If (_id_recepcion <> "") Then
            tabla = bestado.GetDataBy(_id_recepcion)
        Else
            tabla = Nothing

        End If
        Return tabla
    End Function

    Public Function listarEstado() As DataTable
        Dim resultado = New DataTable
        resultado = estado.GetDataByEstado
        Return resultado

    End Function




    Public Function listaEquipo() As DataTable
        Dim resul = New DataTable
        resul = equipo.GetDataByEquipo
        Return resul
    End Function

#End Region





End Class
