Public Class mainForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PasswordForm.ShowDialog() = DialogResult.OK Then
            If PasswordForm.txtUserID.Text = "" Or PasswordForm.txtPassword.Text = "" Then
                MsgBox("Please specify a user ID and a password to connect")
                Exit Sub
            End If
            MsgBox("You were connected as " & PasswordForm.txtUserID.Text)
        Else
            MsgBox("Connection failed for user " & PasswordForm.txtPassword.Text)
        End If
    End Sub
End Class
