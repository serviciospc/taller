Imports dall.DataSetRecepcionTableAdapters
Imports dall.datasetTodoTableAdapters
Public Class ClassBrecepcion

#Region "atributo"
    Private _a As RecepcionTableAdapter

#End Region

#Region "propiedad"
    Private ReadOnly Property busquedar As RecepcionTableAdapter

        Get
            If _a Is Nothing Then
                _a = New RecepcionTableAdapter
            End If
            Return _a
        End Get
    End Property
#End Region

#Region "metodo"

    Public Function bRecepcion(ByVal _id_recepcion As String) As DataTable
        Dim tabla As DataTable
        If (_id_recepcion <> "") Then
            tabla = busquedar.GetDataBCN(_id_recepcion)
        Else
            tabla = Nothing
        End If
        Return tabla
    End Function



#End Region


End Class
