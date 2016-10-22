<Serializable()> Public Class Contact
    Private _customerID As String
    Private _companyName As String
    Private _contactName As String
    Private _address1 As String
    Private _address2 As String
    Private _city As String
    Private _state As String
    Private _zip As String
    Private _country As String
    Private _tel As String
    Private _fax As String

    Property CustomerID As String
        Get
            Return _customerID
        End Get
        Set(ByVal value As String)
            _customerID = value
        End Set
    End Property


    Property CompanyName() As String
        Get
            CompanyName = _companyName
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Company Name field can’t be empty")
                Exit Property
            End If
            _companyName = value
        End Set
    End Property

    Property ContactName() As String
        Get
            ContactName = _contactName
        End Get
        Set(ByVal value As String)
            _contactName = value
        End Set
    End Property

    Property Address1() As String
        Get
            Address1 = _address1
        End Get
        Set(ByVal value As String)
            _address1 = value
        End Set
    End Property

    Property Address2() As String
        Get
            Address2 = _address2
        End Get
        Set(ByVal value As String)
            _address2 = value
        End Set
    End Property

    Property City() As String
        Get
            City = _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Property State() As String
        Get
            State = _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Property ZIP() As String
        Get
            ZIP = _zip
        End Get
        Set(ByVal value As String)
            _zip = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Property tel() As String
        Get
            tel = _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

    Property FAX() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _customerID & "   " & _companyName
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal CompanyName As String, _
                   ByVal LastName As String, ByVal FirstName As String)
        MyBase.New()
        Me.ContactName = LastName & ", " & FirstName
        Me.CompanyName = CompanyName
    End Sub

    Public Sub New(ByVal CompanyName As String)
        MyBase.New()
        Me.CompanyName = CompanyName
    End Sub
End Class
