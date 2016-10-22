Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

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
        If SaveContact() Then
            ListBox1.Enabled = True
            ShowButtons()
        End If
    End Sub

    ' The code of the Delete button has been revised slightly after the book's revision.
    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click
        Dim prevIndex As Integer = ListBox1.SelectedIndex
        If currentContact > -1 Then
            ListBox1.Items.RemoveAt(currentContact)
            If ListBox1.Items.Count = 0 Then
                currentContact = -1
            Else
                currentContact = Math.Min(prevIndex, ListBox1.Items.Count - 1)
            End If
            If currentContact = -1 Then
                ClearFields()
                MsgBox("There are no more contacts")
            Else
                ShowContact()
                ListBox1.SelectedIndex = currentContact
                ListBox1.Focus()
            End If
        Else
            MsgBox("Please select a contacts to delete")
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
            contact.CompanyName = txtCompany.Text
            contact.ContactName = txtContact.Text
            contact.Address1 = txtAddress1.Text
            contact.Address2 = txtAddress2.Text
            contact.City = txtCity.Text
            contact.State = txtState.Text
            contact.ZIP = txtZIP.Text
            contact.tel = txtTel.Text
            contact.EMail = txtEMail.Text
            contact.URL = txtURL.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            ListBox1.Items.Add(contact)
        Else
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
        currentContact = ListBox1.SelectedIndex
        ShowContact()
    End Sub

    ' Helper routines
    Sub LockControls()
        txtCompany.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress1.ReadOnly = True
        txtAddress2.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        txtZIP.ReadOnly = True
        txtTel.ReadOnly = True
        txtEMail.ReadOnly = True
        txtURL.ReadOnly = True
    End Sub

    Sub UnlockControls()
        txtCompany.ReadOnly = False
        txtContact.ReadOnly = False
        txtAddress1.ReadOnly = False
        txtAddress2.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZIP.ReadOnly = False
        txtTel.ReadOnly = False
        txtEMail.ReadOnly = False
        txtURL.ReadOnly = False
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
        txtCompany.Text = ""
        txtContact.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtZIP.Text = ""
        txtState.Text = ""
        txtTel.Text = ""
        txtEMail.Text = ""
        txtURL.Text = ""
    End Sub

    Sub ShowContact()
        If ListBox1.Items.Count = 0 Or currentContact < 0 Then Exit Sub
        Dim contact As New Contact
        contact = CType(ListBox1.Items.Item(currentContact), Contact)
        txtCompany.Text = contact.CompanyName
        txtContact.Text = contact.ContactName
        txtAddress1.Text = contact.Address1
        txtAddress2.Text = contact.Address2
        txtCity.Text = contact.City
        txtState.Text = contact.State
        txtZIP.Text = contact.ZIP
        txtTel.Text = contact.tel
        txtEMail.Text = contact.EMail
        txtURL.Text = contact.URL
    End Sub

    Sub HideButtons()
        UnlockControls()
        bttnAdd.Visible = False
        bttnDelete.Visible = False
        bttnEdit.Visible = False
        bttnOK.Visible = True
        bttnCancel.Visible = True
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFile As FileStream
        saveFile = File.Create("CONTACTS.BIN")
        saveFile.Seek(0, SeekOrigin.End)
        Dim Formatter As BinaryFormatter = New BinaryFormatter
        Dim AL As New ArrayList
        Dim itm As Object
        For Each itm In ListBox1.Items
            AL.Add(itm)
        Next
        Formatter.Serialize(saveFile, AL)
        saveFile.Close()
        Formatter = Nothing
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim readFile As FileStream
        Try
            readFile = File.OpenRead("CONTACTS.BIN")
        Catch ex As Exception
            MsgBox("File CONTACTS.BIN not found in application's folder!")
            Exit Sub
        End Try
        Dim Formatter As New BinaryFormatter
        Dim AL As New ArrayList
        readFile.Seek(0, SeekOrigin.Begin)
        AL = CType(Formatter.Deserialize(readFile), ArrayList)
        ListBox1.Items.Clear()
        Dim itm As Object
        For Each itm In AL
            ListBox1.Items.Add(itm)
        Next
        readFile.Close()
        Formatter = Nothing
        currentContact = 0
        ShowContact()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
