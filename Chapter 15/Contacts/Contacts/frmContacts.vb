Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Form1

    Dim currentContact As Integer
    Dim adding As Boolean

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentContact = ListBox1.SelectedIndex
            If currentContact < 0 Then currentContact = 0
            ShowContact()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Try
            SaveContact()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(txtID.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click
        If ListBox1.SelectedIndex > -1 Then
            Try
                RemoveContact(CType(ListBox1.SelectedItem, Contact).CustomerID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentContact = ListBox1.Items.Count Then currentContact = ListBox1.Items.Count - 1
            If currentContact = -1 Then
                ClearFields()
                MsgBox("There are no more contacts")
            Else
                ShowContact()
            End If
        End If
    End Sub

    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnAdd.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & ListBox1.Items.Count.ToString & _
                      " contacts in the database")
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        ' If we're not in EDIT mode, reject keystrokes
        If Not bttnOK.Visible Then
            e.Handled = True
        End If
    End Sub

    Private Function SaveContact() As Boolean
        Dim contact As New Contact
        Try
            contact.CustomerID = txtID.Text
            contact.CompanyName = txtCompany.Text
            contact.ContactName = txtContact.Text
            contact.Address1 = txtAddress1.Text
            contact.City = txtCity.Text
            contact.State = txtState.Text
            contact.ZIP = txtZIP.Text
            contact.Country = txtCountry.Text
            contact.tel = txtTel.Text
            contact.FAX = txtFax.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            submitcontact(contact)
            ListBox1.Items.Add(contact)
        Else
            UpdateContact(contact)
            ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        currentContact = ListBox1.SelectedIndex
        If currentContact <= 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentContact = ListBox1.SelectedIndex
            ShowContact()
        End If
    End Sub

    ' Helper routines
    Sub LockControls()
        txtID.ReadOnly = True
        txtCompany.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress1.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        txtZIP.ReadOnly = True
        txtCountry.ReadOnly = True
        txtTel.ReadOnly = True
        txtFax.ReadOnly = True
    End Sub

    Sub UnlockControls()
        txtID.ReadOnly = False
        txtCompany.ReadOnly = False
        txtContact.ReadOnly = False
        txtAddress1.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZIP.ReadOnly = False
        txtCountry.ReadOnly = False
        txtTel.ReadOnly = False
        txtFax.ReadOnly = False
    End Sub

    Sub ShowButtons()
        LockControls()
        bttnAdd.Visible = True
        bttnDelete.Visible = True
        bttnEdit.Visible = True
        bttnOK.Visible = False
        bttnCancel.Visible = False
    End Sub

    Sub ClearFields()
        txtID.Text = ""
        txtCompany.Text = ""
        txtContact.Text = ""
        txtAddress1.Text = ""
        txtCity.Text = ""
        txtZIP.Text = ""
        txtState.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtCountry.Text = ""
    End Sub

    Sub ShowContact()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New Contact
        contact = CType(ListBox1.Items.Item(currentContact), Contact)
        txtID.Text = contact.CustomerID
        txtCompany.Text = contact.CompanyName
        txtContact.Text = contact.ContactName
        txtAddress1.Text = contact.Address1
        txtCity.Text = contact.City
        txtState.Text = contact.State
        txtZIP.Text = contact.ZIP
        txtCountry.Text = contact.Country
        txtTel.Text = contact.tel
        txtFax.Text = contact.FAX

    End Sub

    Sub HideButtons()
        UnlockControls()
        bttnAdd.Visible = False
        bttnDelete.Visible = False
        bttnEdit.Visible = False
        bttnOK.Visible = True
        bttnCancel.Visible = True
    End Sub


    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        CMD.CommandText = "SELECT * FROM Customers"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New Contact
            C.CustomerID = RDR.Item("CustomerID")
            C.CompanyName = RDR.Item("CompanyName")
            C.ContactName = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("ContactName")), "", RDR.Item("ContactName")))
            C.Address1 = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Address")), "", RDR.Item("Address")))
            C.City = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("City")), "", RDR.Item("City")))
            C.State = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Region")), "", RDR.Item("Region")))
            C.ZIP = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("PostalCode")), "", RDR.Item("PostalCode")))
            C.Country = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Country")), "", RDR.Item("Country")))
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentContact = 0
        ShowContact()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=localhost;integrated security=true;initial catalog=Northwind")
        CMD = New SqlCommand
        CMD.Connection = CN
    End Sub

    Private Sub SubmitContact(ByVal C As Contact)
        CMD.CommandText = "INSERT Customers (CustomerID, CompanyName, ContactName, Address, City, Region, PostalCode, Country) " & _
            "VALUES (@CustomerID, @CompanyName, @ContactName, @Address, @City, @Region, @PostalCode, @Country) "
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@CustomerID", C.CustomerID)
        CMD.Parameters.AddWithValue("@CompanyName", C.CompanyName)
        CMD.Parameters.AddWithValue("@ContactName", C.ContactName)
        CMD.Parameters.AddWithValue("@Address", C.Address1)
        CMD.Parameters.AddWithValue("@City", C.City)
        CMD.Parameters.AddWithValue("@Region", C.State)
        CMD.Parameters.AddWithValue("@PostalCode", C.ZIP)
        CMD.Parameters.AddWithValue("@Country", C.ZIP)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub


    Private Sub UpdateContact(ByVal C As Contact)
        CMD.CommandText = "UPDATE Customers " & _
            "SET CompanyName = @CompanyName, " & _
            "    ContactName = @ContactName, " & _
            "    Address = @Address, " & _
            "    City = @City, " & _
            "    Region = @Region, " & _
            "    PostalCode = PostalCode, " & _
            "    Country = @Country " & _
            "WHERE CustomerID = @CustomerID"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@CustomerID", C.CustomerID)
        CMD.Parameters.AddWithValue("@CompanyName", C.CompanyName)
        CMD.Parameters.AddWithValue("@ContactName", C.ContactName)
        CMD.Parameters.AddWithValue("@Address", C.Address1)
        CMD.Parameters.AddWithValue("@City", C.City)
        CMD.Parameters.AddWithValue("@Region", C.State)
        CMD.Parameters.AddWithValue("@PostalCode", C.ZIP)
        CMD.Parameters.AddWithValue("@Country", C.Country)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveContact(ByVal ContactID As String)
        CMD.CommandText = "DELETE Customers WHERE CustomerID=@contactID "
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@contactID", ContactID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
End Class
