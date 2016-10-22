Public Class Form1

    Structure Customer
        Dim Company As String
        Dim Manager As String
        Dim Address As String
        Dim City As String
        Dim Country As String
        Dim CustomerSince As Date
        Dim Balance As Decimal
    End Structure

    Private Customers(8) As Customer
    Private cust As Customer
    Private currentIndex As Integer

    Private Sub bttnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNext.Click
        If currentIndex = CountCustomers() - 1 Then currentIndex = 0
        Dim aCustomer As Customer
        aCustomer = GetCustomer(currentIndex)
        ShowCustomer(currentIndex)
        currentIndex = currentIndex + 1
    End Sub

    Private Sub bttnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPrevious.Click
        If currentIndex = 0 Then currentIndex = CountCustomers() - 1

        Dim aCustomer As Customer
        aCustomer = GetCustomer(currentIndex)
        ShowCustomer(currentIndex)
        currentIndex = currentIndex - 1
    End Sub


    Function CountCustomers() As Integer
        Return (Customers.Length)
    End Function

    Function GetCustomer(ByVal idx As Integer) As Customer
        Return (Customers(idx))
    End Function

    Sub ShowCustomer(ByVal idx As Integer)
        Dim aCustomer As Customer
        aCustomer = GetCustomer(idx)
        lblCompany.Text = aCustomer.Company
        lblSince.Text = aCustomer.CustomerSince.ToShortDateString
        lblAddress.Text = aCustomer.Address
        lblCity.Text = aCustomer.City
        lblCountry.Text = aCustomer.Country
        lblBalance.Text = aCustomer.Balance.ToString("#,###.00")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cust As Customer
        cust.Company = "Bottom-Dollar Markets"
        cust.Manager = "Elizabeth Lincoln"
        cust.Address = "23 Tsawassen Blvd."
        cust.City = "Tsawassen"
        cust.Country = "Canada"
        cust.CustomerSince = #10/20/1996#
        cust.Balance = 33500
        Customers(0) = cust

        cust = New Customer()
        cust.Company = "Drachenblut Delikatessen"
        cust.Manager = "Sven Ottlieb"
        cust.Address = "Walserweg 21"
        cust.City = "Aachen"
        cust.Country = "Germany"
        cust.CustomerSince = #1/2/1994#
        cust.Balance = 2400
        Customers(1) = cust

        cust = New Customer()
        cust.Company = "Furia Bacalhau e Frutos do Mar"
        cust.Manager = "Lino Rodriguez "
        cust.Address = "Jardim das rosas n. 32"
        cust.City = "Lisboa"
        cust.Country = "Portugal"
        cust.CustomerSince = #12/22/1998#
        cust.Balance = 300
        Customers(2) = cust

        cust = New Customer()
        cust.Company = "Great Lakes Food Market"
        cust.Manager = "Howard Snyder"
        cust.Address = "2732 Baker Blvd."
        cust.City = "Eugene, OR"
        cust.Country = "USA"
        cust.CustomerSince = #1/3/1998#
        cust.Balance = 6500
        Customers(3) = cust

        cust = New Customer()
        cust.Company = "QUICK-Stop"
        cust.Manager = "Horst Kloss"
        cust.Address = "Taucherstraﬂe 10"
        cust.City = "Cunewalde"
        cust.Country = "Germany"
        cust.CustomerSince = #1/1/1989#
        cust.Balance = 23400
        Customers(4) = cust

        cust = New Customer()
        cust.Company = "The Cracker Box"
        cust.Manager = "Liu Wong"
        cust.Address = "55 Grizzly Peak Rd."
        cust.City = "Butte"
        cust.Country = "USA"
        cust.CustomerSince = #1/1/1999#
        cust.Balance = 23400
        Customers(5) = cust

        cust = New Customer()
        cust.Company = "White Clover Markets"
        cust.Manager = "Karl Jablonski"
        cust.Address = "305 - 14th Ave. S."
        cust.City = "Seattle, WA"
        cust.Country = "USA"
        cust.CustomerSince = #5/11/1994#
        cust.Balance = 12000
        Customers(6) = cust

        cust = New Customer()
        cust.Company = "Wilman Kala"
        cust.Manager = "Matti Karttunen"
        cust.Address = "Keskuskatu 45"
        cust.City = "Helsinki"
        cust.Country = "Finland"
        cust.CustomerSince = #1/3/2000#
        cust.Balance = 2500
        Customers(7) = cust

        bttnNext.PerformClick()
    End Sub

End Class
