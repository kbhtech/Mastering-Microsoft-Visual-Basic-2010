Public Class EnglishUnits
    Private _Feet As Integer
    Private _Inches As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal feet As Integer, ByVal inches As Integer)
        Me.feet = feet
        Me.inches = inches
    End Sub

    Public Property Feet() As Integer
        Get
            Return _Feet
        End Get
        Set(ByVal Value As Integer)
            _Feet = Value
        End Set
    End Property

    Public Property Inches() As Integer
        Get
            Return _Inches
        End Get
        Set(ByVal Value As Integer)
            If Value > 12 Then
                _Feet += Convert.ToInt32(Math.Floor(Value / 12))
                _Inches = (Value Mod 12)
            Else
                _Inches = Value
            End If
        End Set
    End Property

    Public Overloads Function Tostring() As String
        Return Me.Feet & "' " & Me.Inches & """"

    End Function

    Public Shared Operator +(ByVal length1 As EnglishUnits, _
                         ByVal length2 As EnglishUnits) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Feet = length1.Feet * 100 + length1.Inches + length2.Feet * 100 + length2.Inches
        Return result
    End Operator

    Public Shared Operator -(ByVal length1 As EnglishUnits, _
                             ByVal length2 As EnglishUnits) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Inches = length1.Feet * 12 + length1.Inches - length2.Feet * 12 - length2.Inches
        Return result
    End Operator

    Public Overloads Shared Operator *(ByVal length1 As EnglishUnits, _
                     ByVal multiplier As Double) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Inches = Convert.ToInt32((length1.Feet * 12 + length1.Inches) / multiplier)
        Return result
    End Operator

    Public Overloads Shared Operator *(ByVal length1 As EnglishUnits, _
                     ByVal multiplier As Integer) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Inches = Convert.ToInt32((length1.Feet * 12 + length1.Inches) / multiplier)
        Return result
    End Operator

    Public Overloads Shared Operator /(ByVal length1 As EnglishUnits, _
                         ByVal divider As Double) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Inches = Convert.ToInt32((length1.Feet * 12 + length1.Inches) / divider)
        Return result
    End Operator

    Public Overloads Shared Operator /(ByVal length1 As EnglishUnits, _
                     ByVal divider As Integer) As EnglishUnits
        Dim result As New EnglishUnits
        result.Feet = 0
        result.Inches = Convert.ToInt32((length1.Feet * 12 + length1.Inches) / divider)
        Return result
    End Operator

    Public Overloads Shared Operator -(ByVal length1 As EnglishUnits) _
                          As MetricUnits
        Dim result As New MetricUnits
        result.Meters = -length1.Feet
        result.Centimeters = -length1.Inches
        Return result
    End Operator

    Public Overloads Shared Widening Operator _
                 CType(ByVal EU As EnglishUnits) As MetricUnits
        Dim MU As New MetricUnits
        MU.Centimeters = Convert.ToInt32( _
                    (EU.Feet * 12 + EU.Inches) * 2.54)
        Return MU
    End Operator
End Class
