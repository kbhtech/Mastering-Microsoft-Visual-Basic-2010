Public Class PasswordForm

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class