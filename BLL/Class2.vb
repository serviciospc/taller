
Imports dall.DataSettecnico1TableAdapters


Public Class Class2

#Region "atributo"

    Private _tecnico1 As usuarioTableAdapter


#End Region



#Region "propiedad"


    Private ReadOnly Property tecnico2 As usuarioTableAdapter

        Get

            If _tecnico1 Is Nothing Then
                _tecnico1 = New usuarioTableAdapter()
            End If
            Return _tecnico1

        End Get

    End Property

#End Region

#Region "metodo"


    Public Function LLC() As DataTable
        Dim resultado As New DataTable
        resultado = tecnico2.GetDataTecnico1
        Return resultado

    End Function




#End Region




End Class
