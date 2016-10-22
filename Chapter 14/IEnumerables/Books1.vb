Public Class Books1
    Public Class Book
        Public Property ISBN As String
        Public Property Title As String
        Public Property Publisher As String
        Public Property Authors As New List(Of Books1.Author)
        Public Property Price As Prices
        Public Property Stock As Stock
        Public Property PublicationDate As Date
    End Class

    Public Class Prices
        Private _RetailPrice? As Decimal
        Private _StorePrice? As Decimal
        Private _OnlinePrice? As Decimal

        Public Property RetailPrice As Decimal
            Set(ByVal value As Decimal)
                If value > 0 And value < 1000.0 Then
                    If _StorePrice.HasValue AndAlso value < _StorePrice Then
                        Throw New Exception("Store price can't exceed retail price!")
                    End If
                    _RetailPrice = value
                Else
                    Throw New Exception("Price must be positive and less than $1,000")
                End If
            End Set
            Get
                Return _RetailPrice
            End Get
        End Property

        Public Property StorePrice As Decimal
            Set(ByVal value As Decimal)
                If value > 0 And value < 1000.0 Then
                    If _RetailPrice.HasValue AndAlso value < _RetailPrice Then
                        Throw New Exception("Store price can't exceed retail price!")
                    End If
                    _StorePrice = value
                Else
                    Throw New Exception("Price must be positive and less than $1,000")
                End If
            End Set
            Get
                Return _StorePrice
            End Get
        End Property

        Public Property OnlinePrice As Decimal
            Set(ByVal value As Decimal)
                If value > 0 And value < 1000.0 Then

                    _OnlinePrice = value
                Else
                    Throw New Exception("Price must be positive and less than $1,000")
                End If
            End Set
            Get
                Return _OnlinePrice
            End Get
        End Property

    End Class

    Public Class Stock
        Private _OnOrder? As Integer
        Public Property InStock As Integer

        Public Property OnOrder As Integer
            Set(ByVal value As Integer)
                If value > 0 Then
                    _OnOrder = value
                Else
                    Throw New Exception("The OnOrder property can't be negative")
                End If
            End Set
            Get
                Return _OnOrder
            End Get
        End Property
    End Class

    Public Class Author
        Public Property FirstName As String
        Public Property LastName As String
    End Class
End Class

