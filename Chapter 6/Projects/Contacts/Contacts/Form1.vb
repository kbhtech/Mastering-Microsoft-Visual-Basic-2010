Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    <Serializable()> Structure Contact
        Dim Company As String
        Dim Name As String
        Dim Address1 As String
        Dim Address2 As String
        Dim City As String
        Dim State As String
        Dim ZIP As String
        Dim Country As String
        Dim Tel As String
        Dim EMail As String
        Dim URL As String
    End Structure

    Dim MyContacts As New ArrayList()
    Dim currentContact As Integer = -1
    Dim adding As Boolean
    Dim modified As Boolean = False

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        ShowContact()
        ShowButtons()
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Dim contact As New Contact()
        SaveContact()
        ShowButtons()
        modified = True
    End Sub

    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click
        If currentContact > -1 Then
            MyContacts.RemoveAt(currentContact)
            modified = True
            If currentContact = MyContacts.Count Then currentContact = MyContacts.Count - 1
            If currentContact = -1 Then
                ClearFields()
                MsgBox("There are no more contacts")
            Else
                ShowContact()
            End If
        Else
            MsgBox("No selected contact to delete")
        End If
    End Sub

    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnAdd.Click
        adding = True
        ClearFields()
        HideButtons()
        txtCompany.Focus()
    End Sub

    Private Sub bttnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFirst.Click
        currentContact = 0
        ShowContact()
    End Sub

    Private Sub bttnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLast.Click
        currentContact = MyContacts.Count - 1
        ShowContact()
    End Sub

    Private Sub bttnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPrevious.Click
        If currentContact > 0 Then
            currentContact -= 1
        End If
        ShowContact()
    End Sub

    Private Sub bttnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNext.Click
        If currentContact < MyContacts.Count - 1 Then
            currentContact += 1
        End If
        ShowContact()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If modified Then
            Dim reply As MsgBoxResult = MsgBox("There are unsaved data. Are you sure you want to quit?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.No Then Exit Sub
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' F10 displays the number of contacts
        If e.KeyCode = Keys.F10 Then
            MsgBox("There are " & MyContacts.Count.ToString & _
                      " contacts in the database")
            e.Handled = True
        End If
        ' ALT+ takes you to next contact, ALT- takes you to previous contact
        If e.KeyCode = Keys.Subtract And e.Modifiers = Keys.Alt Then
            bttnPrevious_Click(sender, e)
        End If
        If e.KeyCode = Keys.Add And e.Modifiers = Keys.Alt Then
            bttnNext_Click(sender, e)
        End If
        ' If Enter was pressed and the active control is a textbox, move the focus as with the tab key
        If e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.GetType Is GetType(TextBox) Then
                e.SuppressKeyPress = True
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Not bttnOK.Visible Then
            e.Handled = True
        End If
    End Sub

    Private Sub FileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSave.Click
        Dim saveFile As FileStream
        saveFile = File.Create("..\..\..\CONTACTS.BIN")
        saveFile.Seek(0, SeekOrigin.End)
        Dim Formatter As BinaryFormatter = New BinaryFormatter()
        Formatter.Serialize(saveFile, MyContacts)
        saveFile.Close()
        Formatter = Nothing
        modified = False
    End Sub

    Private Sub FileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileOpen.Click
        Dim readFile As FileStream
        readFile = File.OpenRead("..\..\..\CONTACTS.BIN")
        Dim Formatter As New BinaryFormatter()
        MyContacts = CType(Formatter.Deserialize(readFile), ArrayList)
        readFile.Close()
        Formatter = Nothing
        currentContact = 0
        ShowContact()
    End Sub

    Private Sub FileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileNew.Click
        MyContacts.Clear()
    End Sub

    Private Sub FileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExit.Click
        End
    End Sub

    Sub SaveContact()
        Dim contact As New Contact
        contact.Company = txtCompany.Text
        contact.Name = txtContact.Text
        contact.Address1 = txtAddress1.Text
        contact.Address2 = txtAddress2.Text
        contact.City = txtCity.Text
        contact.State = txtState.Text
        contact.ZIP = txtZIP.Text
        contact.Tel = txtTel.Text
        contact.EMail = txtEMail.Text
        contact.URL = txtURL.Text
        If adding Then
            currentContact = MyContacts.Add(contact)
        Else
            MyContacts.Item(currentContact) = contact
        End If
    End Sub

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        If currentContact < 0 Then
            MsgBox("Please select a contact to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtCompany.Focus()
    End Sub

    ' Helper routines to show contact, show/hide editing buttons 
    Sub ShowContact()
        Dim contact As New Contact()
        If currentContact = -1 Then Exit Sub
        contact = CType(MyContacts(currentContact), Contact)
        txtCompany.Text = contact.Company
        txtContact.Text = contact.Name
        txtAddress1.Text = contact.Address1
        txtAddress2.Text = contact.Address2
        txtCity.Text = contact.City
        txtState.Text = contact.State
        txtZIP.Text = contact.ZIP
        txtTel.Text = contact.Tel
        txtEMail.Text = contact.EMail
        txtURL.Text = contact.URL
    End Sub

    Sub HideButtons()
        UnlockControls()
        bttnAdd.Visible = False
        bttnDelete.Visible = False
        bttnEdit.Visible = False
        bttnFirst.Visible = False
        bttnLast.Visible = False
        bttnPrevious.Visible = False
        bttnNext.Visible = False
        bttnOK.Visible = True
        bttnCancel.Visible = True
    End Sub

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
        bttnFirst.Visible = True
        bttnLast.Visible = True
        bttnPrevious.Visible = True
        bttnNext.Visible = True
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


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
