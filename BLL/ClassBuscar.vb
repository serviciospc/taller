Imports dall.datasetTodoTableAdapters


Public Class ClassBuscar
#Region "atributo"
    Private _Bus As DataTable1TableAdapter
    Private _buscliente As DataTable2TableAdapter
    Private _buscaTec As DataTable3TableAdapter
    Private _buscaCasoNcompleto As DataTable1TableAdapter

#End Region


#Region "propiedad"
    Private ReadOnly Property buscacasoNcompleto As DataTable1TableAdapter
        Get
            If _buscaCasoNcompleto Is Nothing Then
                _buscaCasoNcompleto = New DataTable1TableAdapter()
            End If
            Return _buscaCasoNcompleto
        End Get
    End Property

    Private ReadOnly Property bus As DataTable1TableAdapter
        Get
            If _Bus Is Nothing Then
                _Bus = New DataTable1TableAdapter()
            End If
            Return _Bus
        End Get
    End Property


    Private ReadOnly Property buscliente As DataTable2TableAdapter
        Get
            If _buscliente Is Nothing Then
                _buscliente = New DataTable2TableAdapter()

            End If
            Return _buscliente
        End Get


    End Property




    Private ReadOnly Property buscaT As DataTable3TableAdapter
        Get
            If _buscaTec Is Nothing Then
                _buscaTec = New DataTable3TableAdapter()
            End If
            Return _buscaTec
        End Get
    End Property

#End Region






#Region "metodo"
    Public Function buscaTe(ByVal _id_recepcion As String) As DataTable
        Dim tabla As DataTable
        If (_id_recepcion <> "") Then
            tabla = buscaT.GetDataTecnico(_id_recepcion)
        Else
            tabla = Nothing
        End If

        Return tabla



    End Function
    Public Function buscaCasoNo(ByVal _id_recepcion As String) As DataTable

        Dim tabla As DataTable
        If (_id_recepcion <> "") Then
            tabla = bus.GetDataBuscaCasnoNo(_id_recepcion)
        Else
            tabla = Nothing
        End If

        Return tabla
    End Function



    Public Function buscacasoNcompletoo(ByVal _id_recepcion As String) As DataTable
        Dim tabla1 As DataTable
        If (_id_recepcion <> "") Then
            tabla1 = buscacasoNcompleto.GetDataByCompleto(_id_recepcion)
        Else
            tabla1 = Nothing
        End If
        Return tabla1


    End Function

    Public Function buscaxnombre(ByVal _id_recepcion As String) As DataTable

        Dim tabla As DataTable
        If (_id_recepcion <> "") Then
            tabla = buscliente.GetDataBuscaXcaso(_id_recepcion)
        Else
            tabla = Nothing
        End If
        Return tabla
    End Function

#End Region

End Class
