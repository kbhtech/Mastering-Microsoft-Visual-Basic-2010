Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles
        MyBase.Load

        WebBrowser1.DocumentText =
            "<html><body>Search in Google:<br/>" &
            "<form method='get' action='http://www.google.com/search'>" &
            "<input type='text' name='as_q'/><br/>" &
            "<input type='submit' value='Search'/>" &
            "</form></body></html>"
    End Sub

    Private Sub webBrowser1_Navigating(ByVal sender As Object,
        ByVal e As WebBrowserNavigatingEventArgs) Handles
        WebBrowser1.Navigating

        Dim document = WebBrowser1.Document
        If document IsNot Nothing And
            document.All("as_q") IsNot Nothing And
            String.IsNullOrEmpty( _
            document.All("as_q").GetAttribute("value")) Then
            e.Cancel = True
            MsgBox("Please enter a search term.")
        End If
    End Sub
End Class
