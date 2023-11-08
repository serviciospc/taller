Imports dall.DataSetClienteEquipoTableAdapters
Public Class Classclienteyequipo
#Region "atributo"
    Private _buscaCasoyCliente As DataTable1TableAdapter
#End Region



#Region "propiedad"


    Private ReadOnly Property buscaCasoyCliente As DataTable1TableAdapter
        Get
            If _buscaCasoyCliente Is Nothing Then
                _buscaCasoyCliente = New DataTable1TableAdapter()
            End If
            Return _buscaCasoyCliente
        End Get
    End Property

#End Region




    Public Function buscacasyClienteNcompletoo(ByVal _id_caso As String) As DataTable
        Dim tabla1 As DataTable
        If (_id_caso <> "") Then
            tabla1 = buscaCasoyCliente.GetDataClienteyEquipos(_id_caso)
        Else
            tabla1 = Nothing
        End If
        Return tabla1


    End Function








#Region "metodo"
















#End Region



End Class
