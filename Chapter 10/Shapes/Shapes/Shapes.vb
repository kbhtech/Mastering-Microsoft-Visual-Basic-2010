Option Strict On
Public Class Triangle
    Inherits Shape
    Private _side1, _side2, _side3 As Double

    Sub New(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double)
        MyBase.New()
        _side1 = side1
        _side2 = side2
        _side3 = side3
    End Sub

    Sub New()

    End Sub

    Property Side1() As Double
        Get
            Return _side1
        End Get
        Set(ByVal Value As Double)
            _side1 = Value
        End Set
    End Property

    Property Side2() As Double
        Get
            Return _side2
        End Get
        Set(ByVal Value As Double)
            _side2 = Value
        End Set
    End Property

    Public Property Side3() As Double
        Get
            Return _side3
        End Get
        Set(ByVal Value As Double)
            _side3 = Value
        End Set
    End Property

    Public Overrides Function Area() As Double
        Dim Perim As Double
        Perim = Perimeter()
        Return (Math.Sqrt((Perim - _side1) * (Perim - _side2) * (Perim - _side3)))
    End Function

    Public Overrides Function Perimeter() As Double
        Return (_side1 + _side2 + _side3)
    End Function

End Class

Public Class Circle
    Inherits Shape
    Private _Radius As Double

    Sub New(ByVal radius As Double)
        MyBase.New()
        _Radius = radius
    End Sub

    Sub New()

    End Sub

    Public Property Radius() As Double
        Get
            Radius = _Radius
        End Get
        Set(ByVal Value As Double)
            _Radius = Value
        End Set
    End Property

    Public Overrides Function Area() As Double
        Return (Math.PI * _Radius ^ 2)
    End Function

    Public Overrides Function Perimeter() As Double
        Return (2 * Math.PI * _Radius)
    End Function
End Class

Public Class Square
    Inherits Shape
    Private _Side As Double

    Sub New(ByVal Side As Double)
        MyBase.New()
        _Side = Side
    End Sub

    Sub New()

    End Sub

    Public Property Side() As Double
        Get
            Side = _Side
        End Get
        Set(ByVal Value As Double)
            _Side = Value
        End Set
    End Property

    Public Overrides Function Area() As Double
        Area = _Side * _Side
    End Function

    Public Overrides Function Perimeter() As Double
        Return (4 * _Side)
    End Function
End Class
