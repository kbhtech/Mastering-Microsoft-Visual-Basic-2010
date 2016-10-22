Public Class frmFlexCombo


    Private Sub frmFlexCombo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType Is GetType(TextBox) Or Me.ActiveControl.GetType Is GetType(ComboBox)) Then
            Me.ProcessTabKey(True)
        End If
    End Sub


    Private Sub frmFlexCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbCity.SelectedIndex = -1
        cbCountry.SelectedIndex = -1
    End Sub

    Private Sub ClearFields()
        txtAddress.Clear()
        txtName.Clear()
        txtPostalCode.Clear()
        cbCity.SelectedIndex = -1
        cbCountry.SelectedIndex = -1
    End Sub

    Sub AddElement(ByRef control As ComboBox, ByVal newItem As String)
        Dim idx As Integer
        If control.FindString(newItem) >= 0 Then
            idx = control.FindString(newItem)
        Else
            idx = control.Items.Add(newItem)
        End If
        control.SelectedIndex = idx
    End Sub

    Private Sub vcbCity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCity.LostFocus
        Dim newItem As String = cbCity.Text.Trim
        If newItem <> "" Then AddElement(sender, newItem)
    End Sub

    Private Sub cbCountry_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCountry.LostFocus
        Dim newItem As String = cbCountry.Text.Trim
        If newItem <> "" Then AddElement(sender, newItem)
    End Sub

    Private Sub bttnLocateCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLocateCity.Click
        Dim itm As String
        itm = InputBox("Enter a city name", "New City")
        If itm <> "" Then
            AddElement(cbCity, itm)
        End If
    End Sub

    Private Sub bttnLocateCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLocateCountry.Click
        Dim itm As String
        itm = InputBox("Enter a country name", "New Country")
        If itm <> "" Then
            AddElement(cbCountry, itm)
        End If
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Dim msg As String
        msg = "NAME " & vbTab & vbTab & txtName.Text & vbCrLf
        msg &= "ADDRESS " & vbTab & vbTab & txtAddress.Text & vbCrLf
        msg &= "CITY " & vbTab & vbTab & cbCity.Text & vbCrLf
        msg &= "COUNTRY " & vbTab & cbCountry.Text & vbCrLf
        msg &= "P. CODE " & vbTab & vbTab & txtPostalCode.Text & vbCrLf
        MsgBox(msg, MsgBoxStyle.OkOnly, "You supplied the following data")
        ClearFields()
        txtName.Focus()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        ClearFields()
        txtName.Focus()
    End Sub
End Class
