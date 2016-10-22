Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Url = New Uri(
            My.Application.Info.DirectoryPath.ToString() &
            "\quotes.html")
    End Sub
End Class