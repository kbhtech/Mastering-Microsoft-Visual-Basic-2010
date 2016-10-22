Public Class Product
    Public Description As String
    Public ProductID As String
    Public ProductBarCode As String
    Public ListPrice As Decimal
End Class

Public Class Book
    Inherits Product
    Private _Subtitle As String
    Private _ISBN As String
    Private _pages As Integer
    Private _PublisherID As Long
    Private _Authors() As Author

    Public Property SubTitle() As String
        Get
            Return _Subtitle
        End Get
        Set(ByVal value As String)
            _Subtitle = value
        End Set
    End Property
    Public Property ISBN() As String
        Get
            Return _ISBN
        End Get
        Set(ByVal value As String)
            _ISBN = value
        End Set
    End Property
    Public Property pages() As Integer
        Get
            Return _pages
        End Get
        Set(ByVal value As Integer)
            _pages = value
        End Set
    End Property
    Public Property PublisherID() As Long
        Get
            Return _PublisherID
        End Get
        Set(ByVal value As Long)
            _PublisherID = value
        End Set
    End Property
    Public Property Authors() As Author()
        Get
            Return _Authors
        End Get
        Set(ByVal value As Author())
            _Authors = value
        End Set
    End Property

    Public Class Author
        Public AuthorID As Long
        Public AuthorLast As String
        Public AuthorFirst As String
    End Class

    Public Class Publisher
        Public PublisherID As Long
        Public PublisherName As String
        Public PublisherPhone As String
    End Class
End Class

Public Class Supply
    Inherits Product
    Public LongDescription As String
    Public ManufacturerCode As String
    Public ManufacturerID As Long

    Public Class Manufacturer
        Public ManufacturerID As Long
        Public ManufacturerName As String
    End Class
End Class

Public Class Class1
    Inherits Product




End Class
