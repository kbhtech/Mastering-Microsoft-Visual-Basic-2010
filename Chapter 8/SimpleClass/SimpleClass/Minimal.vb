Public Class Minimal

    Public Enum AgeGroup
        Infant
        Child
        Teenager
        Adult
        Senior
        Overaged
    End Enum


    Public strProperty As String, dblProperty As Double
    Public Function ReverseString() As String
        Return (StrReverse(strProperty))
    End Function
    Public Function NegateNumber() As Double
        Return (-dblProperty)
    End Function

    Private m_Age As Integer
    Property Age() As Integer
        Set(ByVal value As Integer)
            If value > 100 Then
                Dim AgeException As New ArgumentException
                Throw AgeException
            Else
                m_Age = value
            End If
        End Set
        Get
            Age = Convert.ToInt32(DateDiff(DateInterval.Year, m_BDate, Now()))
        End Get
    End Property

    Private m_BDate As DateTime

    'Property Age() As Integer
    '    Get
    '        Age = m_Age
    '    End Get
    '    Set(ByVal value As Integer)
    '        If value < 0 Or value >= 100 Then
    '            Dim AgeException As New ArgumentException()
    '            Throw AgeException
    '        Else
    '            m_Age = value
    '        End If
    '    End Set
    'End Property

    Property BDate() As DateTime
        Get
            BDate = m_BDate
        End Get
        Set(ByVal value As Date)
            If value > Now() Or _
                    DateDiff(DateInterval.Year, value, Now()) >= 100 Then
                Dim AgeException As New ArgumentException
                ' Exception ("Can't accept the birth date you specified")
                Throw AgeException
            Else
                m_BDate = value
                m_Age = DateDiff(DateInterval.Year, value, Now())
            End If
        End Set
    End Property

    Public Function GetAgeGroup() As AgeGroup
        Select Case m_Age
            Case Is < 3 : Return (AgeGroup.Infant)
            Case Is < 10 : Return (AgeGroup.Child)
            Case Is < 21 : Return (AgeGroup.Teenager)
            Case Is < 65 : Return (AgeGroup.Adult)
            Case Is < 100 : Return (AgeGroup.Senior)
            Case Else : Return (AgeGroup.Overaged)
        End Select
    End Function


End Class

