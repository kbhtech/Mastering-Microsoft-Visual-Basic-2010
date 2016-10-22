Public Class SharedMembersClass
    Private _strProperty As String

    Sub New(ByVal str As String)
        _strProperty = str
    End Sub

    Sub New()
    End Sub

    Public Property strProperty As String
        Get
            Return (_strProperty)
        End Get
        Set(ByVal value As String)
            _strProperty = value
        End Set
    End Property

    Public Function IReverseString() As String
        Return (StrReverse(strProperty))
    End Function

    Public Shared Function SReverseString(ByVal str As String) As String
        Return (StrReverse(str))
    End Function

    Shared LoggedUsers As Integer
    ReadOnly Property Users() As Integer
        Get
            Users = LoggedUsers
        End Get
    End Property

    Public Function Connect() As Integer
        LoggedUsers = LoggedUsers + 1
        ' { your own code here}
    End Function

    Public Function Disconnect() As Integer
        If LoggedUsers > 1 Then
            LoggedUsers = LoggedUsers - 1
        End If
        ' { your own code here}
    End Function

End Class


