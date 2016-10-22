Public Partial Class Quantity
    Inherits System.Web.UI.Page

    Dim productId As Integer

    Protected Sub Page_Load(ByVal sender As Object,
                ByVal e As System.EventArgs) Handles Me.Load
        ValidateProduct()
        lblProductName.Text = Request.QueryString("productName")
        productId = CInt(Request.QueryString("productId"))
    End Sub

    Private Sub ValidateProduct()
        If String.IsNullOrEmpty(Request.QueryString("productId")) Then
            Response.Redirect("Products.aspx")
        End If
        If Not IsNumeric(Request.QueryString("productId")) Then
            Response.Redirect("Products.aspx")
        End If
        If String.IsNullOrEmpty(Request.QueryString("productName")) Then
            Response.Redirect("Products.aspx")
        End If
    End Sub

    Protected Sub bttnCancel_Click(ByVal sender As Object,
                ByVal e As EventArgs) Handles bttnCancel.Click
        Response.Redirect("Products.aspx")
    End Sub

    Protected Sub bttnAdd_Click(ByVal sender As Object,
                ByVal e As EventArgs) Handles bttnAdd.Click
        Dim productQuantities As Dictionary(Of Integer, Integer)
        productQuantities = Session("productQuantities")
        If IsNothing(productQuantities) Then
            productQuantities = New Dictionary(Of Integer, Integer)
            Session("productQuantities") = productQuantities
        End If
        Dim quantity As Integer = CInt(txtQuantity.Text)
        If quantity = 0 Then
            productQuantities.Remove(productId)
            Response.Redirect("Cart.aspx")
        End If
        If productQuantities.ContainsKey(productId) Then
            productQuantities.Remove(productId)
        End If
        productQuantities.Add(productId, quantity)
        Response.Redirect("Cart.aspx")
    End Sub
End Class

