
Public Class ClassRecepcionCuerpo_
#Region "atributos"
    Private _id_estado As Integer
    Private _id_equipo As Integer
    Private _caracteristicas As String
    Private _accesorio As String
    Private _accesorio1 As String
    Private _problema_tecnico As String
    Private _trabajo_realizar As String
    Private _tota As Decimal
    Private _anticipo As Decimal
    Private _fecha As Date
    Private _fechaf As Date
    Private _id_recepcion As Integer

#End Region


#Region "Propiedades"

    Public Property id_recepcion() As Integer
        Get
            Return _id_recepcion
        End Get
        Set(ByVal value As Integer)
            _id_recepcion = value
        End Set
    End Property

    Public Property id_estado() As Integer
        Get
            Return _id_estado

        End Get
        Set(ByVal value As Integer)
            _id_estado = value
        End Set
    End Property

    Public Property id_equipo() As Integer
        Get
            Return _id_equipo
        End Get
        Set(ByVal value As Integer)
            _id_equipo = value
        End Set
    End Property



    Public Property caracteristicas() As String
        Get
            Return _caracteristicas
        End Get
        Set(ByVal value As String)
            _caracteristicas = value
        End Set
    End Property



    Public Property accesorio() As String
        Get
            Return _accesorio
        End Get
        Set(ByVal value As String)
            _accesorio = value
        End Set
    End Property

    Public Property accesorio1 As String
        Get
            Return _accesorio1
        End Get
        Set(ByVal value As String)
            _accesorio1 = value
        End Set
    End Property

    Public Property problema_tecnico() As String
        Get
            Return _problema_tecnico
        End Get
        Set(ByVal value As String)
            _problema_tecnico = value
        End Set
    End Property

    Public Property trabajo_realizar() As String
        Get
            Return _trabajo_realizar
        End Get
        Set(ByVal value As String)
            _trabajo_realizar = value
        End Set
    End Property



    Public Property tota() As Decimal
        Get
            Return _tota
        End Get
        Set(ByVal value As Decimal)
            _tota = value
        End Set
    End Property


    Public Property anticipo() As Decimal
        Get
            Return _anticipo
        End Get
        Set(ByVal value As Decimal)
            _anticipo = value
        End Set
    End Property


    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property fechaf() As Date
        Get
            Return _fechaf
        End Get
        Set(ByVal value As Date)
            _fechaf = value
        End Set
    End Property

#End Region







End Class
