Public Class frmSales

    Private ctx As NWindDataContext

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ctx = New NWindDataContext
        ctx.Log = Console.Out
        Dim countries = From cust In ctx.Customers
                                Select cust.Country Distinct

        For Each country As String In countries
            cbCountries.Items.Add(country)
        Next

    End Sub

    Private Sub cbCountries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCountries.SelectedIndexChanged
        If cbCountries.SelectedItem Is Nothing Then Exit Sub
        Dim country = cbCountries.SelectedItem.ToString
        ctx.Log = Console.Out
        Dim selCustomers = From cust In ctx.Customers
                           Where cust.Country = country
                           Select cust

        For Each cust In selCustomers
            ListBox1.Items.Add(cust.CustomerID & vbTab & cust.CompanyName)
        Next
        If selCustomers.Count = 0 Then
            TextBox1.Text = "There are no customers in " & country
        Else
            TextBox1.Text = "There are " & selCustomers.Count.ToString & " customers in " & country
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ctx.Log = Console.Out
        If ListBox1.SelectedItem Is Nothing Then Exit Sub
        Dim custID As String = ListBox1.SelectedItem.ToString.Substring(0, 5)
        Dim custName As String = ListBox1.SelectedItem.ToString.Substring(5).Trim
        Dim customerOrders = From ord In ctx.Orders
                     Where ord.CustomerID = custID
                     Select New With {.order = ord, .details = ord.Order_Details}

        Dim orderCount = customerOrders.Count
        If orderCount > 0 Then
            Dim tot = From o In customerOrders
                      Select Aggregate det In o.details Into Sum(det.UnitPrice * det.Quantity * (1 - det.Discount))


            TextBox1.Text = "Customer " & custName & " has placed " & orderCount.ToString & " orders totalling $" & tot.Sum.ToString
        Else
            TextBox1.Text = "There are no order for customer " & custName
        End If

        lvOrders.Items.Clear()
        For Each ord In customerOrders
            Dim LI As New ListViewItem
            LI.Text = ord.order.OrderID.ToString
            LI.SubItems.Add(ord.order.OrderDate.Value.ToShortDateString)
            LI.SubItems.Add((Aggregate dtl In ord.details Into Sum(dtl.UnitPrice * dtl.Quantity * (1 - dtl.Discount))).ToString)
            LI.SubItems.Add(Aggregate dtl In ord.details Into Sum(dtl.Quantity))
            LI.SubItems.Add(ord.order.Freight.ToString)
            lvOrders.Items.Add(LI)
        Next
    End Sub

    Private Sub lvOrders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvOrders.SelectedIndexChanged
        If lvOrders.SelectedItems.Count = 0 Then Exit Sub

        Dim OrderID As Integer = Convert.ToInt32(lvOrders.SelectedItems(0).Text)
        Dim selectedDetails = From det In ctx.Order_Details, prod In ctx.Products
                            Where prod.ProductID = det.ProductID And
                            det.OrderID = OrderID
                            Select New With {.details = det}
        lvOrderDetails.Items.Clear()
        Dim orderTotal As Decimal = 0.0
        Dim orderLines As Integer = 0
        Dim totalItems As Integer = 0
        For Each det In selectedDetails
            Dim LI As New ListViewItem
            LI.Text = det.details.ProductID.ToString
            LI.SubItems.Add(det.details.Product.ProductName)
            LI.SubItems.Add(det.details.UnitPrice.ToString("###.00"))
            LI.SubItems.Add(det.details.Quantity.ToString)
            LI.SubItems.Add(det.details.Discount.ToString("###.00"))
            LI.SubItems.Add((det.details.UnitPrice * det.details.Quantity * (1 - det.details.Discount)).ToString("#,###.00"))
            lvOrderDetails.Items.Add(LI)
            orderTotal += det.details.UnitPrice * det.details.Quantity * (1 - det.details.Discount)
            orderLines += 1
            totalItems += det.details.Quantity
        Next
        Dim totalLI As New ListViewItem
        totalLI.Text = ""
        totalLI.SubItems.Add("TOTALS")
        totalLI.SubItems.Add("")
        totalLI.SubItems.Add(totalItems.ToString)
        totalLI.SubItems.Add("")
        totalLI.SubItems.Add(orderTotal.ToString("#,###.00"))
        totalLI.UseItemStyleForSubItems = True
        totalLI.Font = New Font(lvOrderDetails.Font.Name, lvOrderDetails.Font.Size, FontStyle.Bold)
        lvOrderDetails.Items.Add(totalLI)
        TextBox1.Text = "Order " & OrderID & " contains " & orderLines.ToString & " items and its total is " & orderTotal.ToString("#,###.00")
    End Sub

End Class
