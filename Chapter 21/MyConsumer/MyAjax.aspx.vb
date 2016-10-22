
Partial Class MyAjax
    Inherits System.Web.UI.Page
    Dim MyWebService As New localhost.Service

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblServerTime.Text = MyWebService.ServerTime
    End Sub
End Class
