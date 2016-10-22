
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim MyWebService As New localhost.Service

    Protected Sub bttnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnCalculate.Click
        Dim myValue As Integer = CInt(tbMyValue.Text)
        Dim myTotal As Integer = CInt(tbMyTotal.Text)
        lblPercentage.Visible = True
        lblPercentage.Text = MyWebService.CalculatePercentage(myTotal, myValue) & "%"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblServerTime.Text = MyWebService.ServerTime
    End Sub
End Class
