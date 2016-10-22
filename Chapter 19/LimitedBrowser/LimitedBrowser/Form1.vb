Public Class Form1

    Private Sub cboUrls_SelectedIndexChanged(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles cboUrls.SelectedIndexChanged

        WebBrowser1.Navigate(cboUrls.Text)
    End Sub
End Class
