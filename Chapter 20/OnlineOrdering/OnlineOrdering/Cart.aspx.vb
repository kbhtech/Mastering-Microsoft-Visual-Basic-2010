Imports OnlineOrdering.Northwind.OrdersRow
Imports OnlineOrdering.Northwind.Order_DetailsRow

Partial Public Class Cart
    Inherits System.Web.UI.Page

    Dim queryResult As EnumerableRowCollection
    Dim total As Decimal
    Private Const DiscountIndex = 0.98

    Protected Sub Page_Load(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles Me.Load
        'Set to real user Id after implementing Login functionality
        Session("userId") = "ALFKI"
        'Add "Online Employee" to database and set employeeId accordingly
        Session("employeeId") = 10
        GenerateOrder()
        lblTotal.Text = total.ToString()
        gwCart.DataSource = queryResult
        gwCart.DataBind()
    End Sub

    Private Sub GenerateOrder()
        Dim adapter As New NorthwindTableAdapters.ProductsTableAdapter
        Dim table As Northwind.ProductsDataTable
        Dim productQuantities As Dictionary(Of Integer, Integer)

        productQuantities = Session("productQuantities")
        If IsNothing(productQuantities) Then
            Response.Redirect("Products.aspx")
        End If

        table = adapter.GetData

        queryResult = From p In table
                Where productQuantities.Keys.Contains(p.ProductID)
                Select New With {
                 p.ProductID,
                 p.ProductName,
                 .Quantity = productQuantities.Item(p.ProductID),
                 p.UnitPrice,
                 .Discount = 0.02,
                 .DiscountedUnitPrice = p.UnitPrice * DiscountIndex,
                 .ProductTotal = p.UnitPrice * DiscountIndex *
                                productQuantities.Item(p.ProductID),
                 .Edit = "Quantity.aspx?productId=" &
                 p.ProductID.ToString & "&productName=" & p.ProductName
                 }

        total = (From p In table
                     Where productQuantities.Keys.Contains(p.ProductID)).
                    Sum(Function(p) p.UnitPrice * DiscountIndex *
                    productQuantities.Item(p.ProductID))
    End Sub


    Protected Sub bttnAddMore_Click(ByVal sender As Object,
                                    ByVal e As EventArgs) Handles bttnAddMore.Click
        Response.Redirect("Products.aspx")
    End Sub

    Protected Sub bttnCheckOut_Click(ByVal sender As Object,
                                     ByVal e As EventArgs) Handles bttnCheckOut.Click
        Dim productsAdapter As New NorthwindTableAdapters.ProductsTableAdapter
        Dim products As Northwind.ProductsDataTable = productsAdapter.GetData

        Dim ordersAdapter As New NorthwindTableAdapters.OrdersTableAdapter
        Dim orders = ordersAdapter.GetData

        Dim orderDetailsAdapter As New NorthwindTableAdapters.Order_DetailsTableAdapter
        Dim orderDetails = orderDetailsAdapter.GetData

        Dim order = orders.AddOrdersRow(Session("userId"), CInt(Session("employeeId")),
                                        Date.Now.Date, Date.Now.AddDays(7).Date,
                                        Date.MinValue, 1,
                                        Nothing, Nothing, Nothing, Nothing,
                                        Nothing, Nothing, Nothing)
        order.SetShippedDateNull()
        ordersAdapter.Update(orders)
        orders.AcceptChanges()
        For Each orderDetail In queryResult
            Dim product = products.FindByProductID(orderDetail.ProductID)
            orderDetails.AddOrder_DetailsRow(order, product, orderDetail.UnitPrice,
                                             orderDetail.Quantity, orderDetail.Discount)
        Next
        orderDetailsAdapter.Update(orderDetails)
        orderDetails.AcceptChanges()
        Response.Redirect("Confirmation.aspx")

    End Sub

    Protected Sub bttnEmpty_Click(ByVal sender As Object, 
                                  ByVal e As EventArgs) Handles bttnEmpty.Click
        Dim productQuantities As Dictionary(Of Integer, Integer) =
            Session("productQuantities")
        productQuantities.Clear()
        Response.Redirect("Products.aspx")
    End Sub
End Class