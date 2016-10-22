Public Class MetricUnits
    Private _Meters As Integer
    Private _Centimeters As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal meters As Integer, ByVal centimeters As Integer)
        Me.Meters = meters
        Me.Centimeters = centimeters
    End Sub

    Public Property Meters() As Integer
        Get
            Return _Meters
        End Get
        Set(ByVal Value As Integer)
            _Meters = Value
        End Set
    End Property

    Public Property Centimeters() As Integer
        Get
            Return _Centimeters
        End Get
        Set(ByVal Value As Integer)
            If Value > 100 Then
                _Meters = _Meters + Convert.ToInt32(Math.Floor(Value / 100))
                _Centimeters = (Value Mod 100)
            ElseIf Value < -100 Then
                _Meters = _Meters + Convert.ToInt32(Math.Ceiling(Value / 100))
                _Centimeters = (Value Mod 100)
            Else
                _Centimeters = Value
            End If
        End Set
    End Property

    Public Overloads Function Tostring() As String
        Dim str As String = Math.Abs(_Meters).ToString & "." & Math.Abs(_Centimeters).ToString
        If _Meters < 0 Or (_Meters = 0 And _Centimeters < 0) Then
            str = "-" & str
        End If
        Return str
    End Function

    Public Shared Operator +(ByVal length1 As MetricUnits, _
                         ByVal length2 As MetricUnits) As MetricUnits
        Dim result As New metricUnits
        result.Meters = 0
        result.Centimeters = length1.Meters * 100 + length1.Centimeters + length2.Meters * 100 + length2.Centimeters
        Return result
    End Operator

    Public Shared Operator -(ByVal length1 As MetricUnits, _
                             ByVal length2 As MetricUnits) As MetricUnits
        Dim result As New MetricUnits
        result.Meters = 0
        result.Centimeters = length1.Meters * 100 + length1.Centimeters - length2.Meters * 100 - length2.Centimeters
        Return result
    End Operator

    Public Overloads Shared Operator *(ByVal length1 As MetricUnits, _
                     ByVal multiplier As Double) As MetricUnits
        Dim result As New MetricUnits
        result.Meters = 0
        result.Centimeters = Convert.ToInt32((length1.Meters * 100 + length1.Centimeters) / multiplier)
        Return result
    End Operator

    Public Overloads Shared Operator *(ByVal length1 As MetricUnits, _
                     ByVal multiplier As Integer) As MetricUnits
        Dim result As New MetricUnits
        result.Meters = 0
        result.Centimeters = Convert.ToInt32((length1.Meters * 100 + length1.Centimeters) / multiplier)
        Return result
    End Operator

    Public Overloads Shared Operator /(ByVal length1 As MetricUnits, _
                         ByVal divider As Double) As MetricUnits
        Dim result As New MetricUnits
        result.Meters = 0
        result.Centimeters = Convert.ToInt32((length1.Meters * 100 + length1.Centimeters) / divider)
        Return result
    End Operator

    Public Overloads Shared Operator /(ByVal length1 As MetricUnits, _
                     ByVal divider As Integer) As MetricUnits
        Dim result As New MetricUnits
        result.Meters = 0
        result.Centimeters = Convert.ToInt32((length1.Meters * 100 + length1.Centimeters) / divider)
        Return result
    End Operator

    Public Overloads Shared Operator -(ByVal length1 As MetricUnits) _
                          As MetricUnits
        Dim result As New MetricUnits
        result.Meters = -length1.Meters
        result.Centimeters = -length1.Centimeters
        Return result
    End Operator

    Public Overloads Shared Operator >(ByVal length1 As MetricUnits, ByVal length2 As MetricUnits) _
                      As Boolean
        If length1.Meters * 100 + length1.Centimeters > length2.Meters * 100 + length2.Centimeters Then
            Return True
        Else
            Return False
        End If
    End Operator

    Public Overloads Shared Operator >(ByVal length1 As MetricUnits, ByVal length2 As Double) _
                  As Boolean
        If length1.Meters * 100 + length1.Centimeters > length2 Then
            Return True
        Else
            Return False
        End If
    End Operator

    Public Overloads Shared Operator <(ByVal length1 As MetricUnits, ByVal length2 As MetricUnits) _
                  As Boolean
        If length1.Meters * 100 + length1.Centimeters < length2.Meters * 100 + length2.Centimeters Then
            Return True
        Else
            Return False
        End If
    End Operator


    Public Overloads Shared Operator <(ByVal length1 As MetricUnits, ByVal length2 As Double) _
              As Boolean
        If length1.Meters * 100 + length1.Centimeters < length2 Then
            Return True
        Else
            Return False
        End If
    End Operator
    Public Overloads Shared Operator =(ByVal length1 As MetricUnits, ByVal length2 As Object) _
              As Boolean
        If length2.GetType Is GetType(MetricUnits) Then
            Dim L2 As MetricUnits = DirectCast(length2, MetricUnits)
            If length1.Meters * 100 + length1.Centimeters = L2.Meters * 100 + L2.Centimeters Then
                Return True
            Else
                Return False
            End If
        ElseIf length2.GetType Is GetType(EnglishUnits) Then
            Dim L2 As EnglishUnits = DirectCast(length2, EnglishUnits)
            If length1.Meters * 100 + length1.Centimeters = (L2.Feet * 12 + L2.Inches) * 2.54 Then
                Return True
            Else
                Return False
            End If
        ElseIf length2.GetType Is GetType(Double) Or _
                length2.GetType Is GetType(Single) Or _
                length2.GetType Is GetType(Decimal) Then
            If length1.Meters * 100 + length1.Centimeters = CType(length2, Double) Then
                Return True
            Else
                Return False
            End If
        ElseIf length2.GetType Is GetType(Integer) Then
            If length1.Meters * 100 + length1.Centimeters = CType(length2, Integer) Then
                Return True
            Else
                Return False
            End If
        Else
                Throw New ArgumentException
            End If
    End Operator

    Public Overloads Shared Operator <>(ByVal length1 As MetricUnits, ByVal length2 As Object) _
              As Boolean
        If length2.GetType Is GetType(MetricUnits) Then
            Dim L2 As MetricUnits = DirectCast(length2, MetricUnits)
            If length1.Meters * 100 + length1.Centimeters <> L2.Meters * 100 + L2.Centimeters Then
                Return True
            Else
                Return False
            End If
        ElseIf length2.GetType Is GetType(EnglishUnits) Then
            Dim L2 As EnglishUnits = DirectCast(length2, EnglishUnits)
            If length1.Meters * 100 + length1.Centimeters <> Convert.ToInt32((L2.Feet * 12 + L2.Inches) * 2.54) Then
                Return True
            Else
                Return False
            End If
        ElseIf length2.GetType Is GetType(Double) Or _
            length2.GetType Is GetType(Single) Or _
            length2.GetType Is GetType(Integer) Or _
            length2.GetType Is GetType(Decimal) Then
            If length1.Meters * 100 + length1.Centimeters <> CType(length2, Double) Then
                Return True
            Else
                Return False
            End If
        Else
            Throw New InvalidCastException
        End If
    End Operator

    Public Overloads Shared Widening Operator _
             CType(ByVal MU As MetricUnits) As EnglishUnits
        Dim EU As New EnglishUnits
        EU.Inches = Convert.ToInt32( _
                    (MU.Meters * 100 + MU.Centimeters) / 2.54)
        Return EU
    End Operator

End Class
