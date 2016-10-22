Public Class Form1

    Private Sub bttnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEvaluate.Click
        Dim language As String
        language = ComboBox1.Text
        If language = "Visual Basic" Then
            MsgBox("We have a winner!")
        Else
            MsgBox(language & " is not a bad language.")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 2
    End Sub
End Class
