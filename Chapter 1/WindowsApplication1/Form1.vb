Public Class Form1

    Private Sub bttnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEvaluate.Click
        If TextBox1.Text = "Visual Basic" Then
            MsgBox("We have a winner!")
        Else
            MsgBox(TextBox1.Text & " is not a bad language.")
        End If

    End Sub

End Class
