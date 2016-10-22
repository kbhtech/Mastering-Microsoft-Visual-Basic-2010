Public Partial Class Products
    Inherits System.Web.UI.Page

    Protected Sub gwProducts_SelectedIndexChanged(ByVal sender As Object,
                    ByVal e As System.EventArgs) Handles
                     gwProducts.SelectedIndexChanged
        Dim quantityUrl = "Quantity.aspx?productId=" &
            gwProducts.DataKeys.
            Item(gwProducts.SelectedIndex).Values("ProductID").ToString &
            "&productName=" &
            gwProducts.DataKeys.
            Item(gwProducts.SelectedIndex).Values("ProductName").ToString
        Response.Redirect(quantityUrl)
    End Sub

End Class

