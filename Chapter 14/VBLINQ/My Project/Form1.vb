Public Class Form1

    Private ctx As NWindDataContext

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ctx = New NWindDataContext

        'Dim q = From c In ctx.Customers
        '        From o In c.Orders
        '        From od In o.Order_Details
        '        From p In ctx.Products
        '        Where p.CategoryID = 3 And p.ProductID = od.ProductID
        '        Group By c.CompanyName Into custGroup = Group,
        '        orderCount = Count(), items = Sum(od.Quantity),
        '        ordersTotal = Sum(od.UnitPrice * od.Quantity * (1 - od.Discount))



        'Dim q1 = From c In ctx.Customers
        '        From o In c.Orders
        '        From od In o.Order_Details
        '        From p In ctx.Products
        '        Where p.ProductID = od.ProductID
        '        Group By c.CompanyName, p.Category.CategoryID Into custGroup = Group,
        '        orderCount = Count(), items = Sum(od.Quantity),
        '        ordersTotal = Sum(od.UnitPrice * od.Quantity * (1 - od.Discount))

        'Dim q2 = From itm In q1
        '         Group By itm.CategoryID Into categoryGroup = Group,
        '         orderCount = Count(), items = Sum(itm.items),
        '         ordersTotal = Sum(itm.ordersTotal)





        ctx.Log = Console.Out

        'Dim productsInCategory = From p In ctx.Products
        '         Where p.CategoryID = 3
        '         Select New With {.ID = p.ProductID, .product = p.ProductName, p.Category.CategoryName}

        'Debug.WriteLine("The products")

        'For Each p In productsInCategory
        '    Debug.WriteLine(p.product)
        'Next


        'Dim qp = From od In ctx.Order_Details, p In productsInCategory
        '         Where od.ProductID = p.ID
        '         Group By od.Order.CustomerID Into cGrp = Group
        '         Select New With {.pp = cGrp, .q = cGrp.Sum(Function(l) l.od.Quantity)}

        'Stop
        'Dim ordersOfProductsInCategory = From o In ctx.Orders
        '         From od In o.Order_Details
        '         Where o.OrderID = od.OrderID
        '         Select New With {.order = o, .detail = od}

        'Debug.WriteLine("The orders")
        'For Each o In ordersOfProductsInCategory
        '    Debug.WriteLine(o.order.OrderID & vbTab & o.detail.Product.ProductName & " X " & o.detail.Quantity)
        'Next

        'Dim customersWithOrders = From c In ctx.Customers, o In ordersOfProductsInCategory, p In productsInCategory
        '        Where c.CustomerID = o.order.CustomerID And o.detail.ProductID = p.ID
        '        Select New With {.Customer = c, .product = p.product, .items = o.detail.Quantity}

        'Debug.WriteLine("The customers with orders")
        'For Each c In customersWithOrders.Distinct
        '    Debug.WriteLine(c.Customer.CompanyName, c.product, c.items)
        'Next

        'Dim customerTotals = From o In ordersOfProductsInCategory, c In customersWithOrders
        '         Where o.order.CustomerID = c.Customer.CustomerID
        '         Group By o.order.Customer.CompanyName Into custGroup = Group
        '         Select custGroup


        'For Each itm In customerTotals
        '    '' Debug.WriteLine(itm)
        '    ' Debug.WriteLine(itm.customer.Customer.CompanyName & "ordered " & itm.itemsOrdered.ToString & " items")
        'Next


        'Stop


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

        'MsgBox(selCustomers.ToList(0).Orders.ToList(0).OrderDate)
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
