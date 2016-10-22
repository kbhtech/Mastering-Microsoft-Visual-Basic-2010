Public Class Form2

    Public ctx As NWindDataContext

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SW As New Stopwatch
        SW.Start()

        Dim RND As New Random
        ' select a customer at random
        ' even though we select a single item with the Take(1) method, we must
        ' still call the First method, as the Take method returns a collection, 
        ' even if it contains a single element. 
        Dim cust = CType(ctx.Customers.Skip(RND.Next(1, 50)).Take(1).First, Customer)
        ' select an employee at random
        Dim emp = CType(ctx.Employees.Skip(RND.Next(1, 10)).Take(1).First, Employee)
        ' and create order's header
        Dim order As New Order
        Order.OrderDate = Now
        order.Customer = cust
        order.Employee = emp
        ' select a random freight for the order in the range from $3 to $75
        order.Freight = RND.Next(300, 7500) / 100
        Dim discount As Decimal
        ' select a random discount value for the order
        discount = RND.Next(0, 45) / 100
        Dim prod As Product
        ' create a random number of detail lines in the range from 10 to 50
        For i As Integer = 1 To RND.Next(10, 50)
            prod = CType((From p As Product In ctx.Products Where p.ProductID = RND.Next(1, 50) Select p).Single, Product)
            ' add product to order only if it doesn't exist already
            ' because the Order Details table has a unique costraint
            ' on fields OrerID + ProductID (a product can't appear twice in the same order)
            If order.Order_Details.Where(Function(d) d.ProductID = prod.ProductID).Count = 0 Then
                order.Order_Details.Add(New Order_Detail With {.ProductID = prod.ProductID, .Quantity = RND.Next(5, 15), .UnitPrice = prod.UnitPrice, .Discount = discount})
            End If
        Next
        ' and now submit the order to the database
        ctx.Orders.InsertOnSubmit(order)
        ctx.SubmitChanges()
        SW.Stop()
        MsgBox("Order " & order.OrderID & " with " & order.Order_Details.Count.ToString &
               " lines was committed successfully in " & SW.ElapsedMilliseconds.ToString & " milliseconds")
        ' set up the controls on frmOrder and show the newly created order's details
        frmOrder.txtOrderID.Text = order.OrderID.ToString
        frmOrder.txtOrderDate.Text = order.OrderDate.Value.ToShortDateString
        frmOrder.txtOrderCustomer.Text = order.Customer.CompanyName & " / " & order.Customer.ContactName
        frmOrder.txtEmployee.Text = order.Employee.LastName & ", " & order.Employee.FirstName
        For Each dtl In order.Order_Details
            Dim LI As New ListViewItem
            LI.Text = dtl.ProductID.ToString
            LI.SubItems.Add(dtl.Product.ProductName)
            LI.SubItems.Add(dtl.UnitPrice.ToString("#0.00"))
            LI.SubItems.Add(dtl.Quantity.ToString)
            LI.SubItems.Add(100 * dtl.Discount.ToString("#.00"))
            frmOrder.lvOrderDetails.Items.Add(LI)
        Next
        frmOrder.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadCategoriesSuppliers()
        Form3.bttnCreate.Text = "Add Product"
        If Form3.ShowDialog = Windows.Forms.DialogResult.OK Then
            ctx = New NWindDataContext
            Dim P As New Product
            Dim productName As String = Form3.txtProduct.Text
            If productName.Trim.Length = 0 Then
                MsgBox("You can't create a new product without a name!")
                Exit Sub
            End If
            Dim productPrice? As Decimal
            Try
                productPrice = Decimal.Parse(Form3.txtPrice.Text)
            Catch ex As Exception
                productPrice = Nothing
            End Try

            Dim productCategoryID? As Integer
            If Form3.cbCategories.SelectedIndex > -1 Then
                productCategoryID = CType(Form3.cbCategories.SelectedItem, Category).CategoryID
            Else
                productCategoryID = Nothing
            End If

            Dim productSupplierID? As Integer
            If Form3.cbSuppliers.SelectedIndex > -1 Then
                productSupplierID = CType(Form3.cbSuppliers.SelectedItem, Supplier).SupplierID
            Else
                productSupplierID = Nothing
            End If

            Dim Packaging As String
            If Form3.txtQtyUnits.Text.Trim.Length > 0 Then
                Packaging = Form3.txtQtyUnits.Text.Trim
            Else
                Packaging = Nothing
            End If

            P.ProductName = productName
            P.UnitPrice = productPrice
            P.QuantityPerUnit = Packaging
            P.CategoryID = productCategoryID
            P.SupplierID = productSupplierID
            ctx.Products.InsertOnSubmit(P)
            Try
                ctx.SubmitChanges()
            Catch ex As Exception
                MsgBox("Failed to insert new product to database" & vbCrLf & ex.Message)
            End Try
            MsgBox("Product " & productName & " submitted successfully")
            Dim LI As New ListViewItem
            LI.Text = P.ProductID.ToString
            LI.SubItems.Add(P.ProductName)
            LI.SubItems.Add(P.QuantityPerUnit)
            LI.SubItems.Add(P.Category.CategoryName)
            LI.SubItems.Add(Convert.ToDecimal(P.UnitPrice).ToString("#.00"))
            LI.SubItems.Add(P.Supplier.CompanyName)
            lvProducts.Items.Add(LI)

        End If
    End Sub


    Private Sub LoadCategoriesSuppliers()
        Dim categories = From cat In ctx.Categories
                 Select cat
        With Form3
            .cbCategories.Items.Clear()
            .cbCategories.DisplayMember = "Category"
            .cbCategories.ValueMember = "CategoryID"
            For Each cat In categories
                .cbCategories.Items.Add(cat)
            Next

            Dim suppliers = From sup In ctx.Suppliers
                     Select sup

            .cbSuppliers.Items.Clear()
            .cbSuppliers.DisplayMember = "CompanyName"
            .cbSuppliers.ValueMember = "SupplierID"
            For Each sup In suppliers
                .cbSuppliers.Items.Add(sup)
            Next
        End With
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ctx = New NWindDataContext
        Dim categories = From c In ctx.Categories
                         Select New With {.id = c.CategoryID, .category = c.CategoryName}

        Dim suppliers = From s In ctx.Suppliers
                        Select New With {.id = s.SupplierID, .company = s.CompanyName}


    End Sub

    'Private Sub ShowProducts(ByRef products As IEnumerable(Of Product))
    '    lvProducts.Items.Clear()
    '    For Each prod In products
    '        Dim LI As New ListViewItem
    '        LI.Text = prod.ProductName
    '        LI.SubItems.Add(prod.QuantityPerUnit)
    '        LI.SubItems.Add(prod.UnitPrice.ToString)
    '        lvProducts.Items.Add(LI)
    '    Next
    'End Sub

    Private Sub lbCategories_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If lbCategories.SelectedItem Is Nothing Then Exit Sub
        'Dim categoryID = CType(lbCategories.SelectedItem, Category).CategoryID
        'Dim productsInCategory = (From prod In ctx.Products
        '                         Where prod.CategoryID = categoryID
        '                         Select prod).ToList
        'ShowProducts(productsInCategory)
    End Sub

    Private Sub lbSuppliers_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If lbSuppliers.SelectedItem Is Nothing Then Exit Sub
        'Dim supplierID = CType(lbSuppliers.SelectedItem, Supplier).SupplierID
        'Dim productsBySupplier = (From prod In ctx.Products
        '                         Where prod.SupplierID = supplierID
        '                         Select prod).ToList
        'ShowProducts(productsBySupplier)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim products = ctx.Products
        lvProducts.Items.Clear()
        For Each product In products
            Dim LI As New ListViewItem
            LI.Text = product.ProductID.ToString
            LI.SubItems.Add(product.ProductName)
            If product.QuantityPerUnit IsNot Nothing Then
                LI.SubItems.Add(product.QuantityPerUnit)
            Else
                LI.SubItems.Add("")
            End If
            If product.Category IsNot Nothing Then
                LI.SubItems.Add(product.Category.CategoryName)
            Else
                LI.SubItems.Add("")
            End If
            If product.UnitPrice IsNot Nothing Then
                LI.SubItems.Add(Convert.ToDecimal(product.UnitPrice).ToString("#,###.00"))
            Else
                LI.SubItems.Add("")
            End If
            If product.Supplier IsNot Nothing Then
                LI.SubItems.Add(product.Supplier.CompanyName)
            Else
                LI.SubItems.Add("")
            End If
            lvProducts.Items.Add(LI)
        Next
    End Sub

    Private Sub lvProducts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvProducts.DoubleClick
        If lvProducts.SelectedItems.Count = 0 Then Exit Sub
        LoadCategoriesSuppliers()
        Dim product = (From p In ctx.Products
                              Where p.ProductID = lvProducts.SelectedItems(0).Text
                              Select p).First

        Form3.txtProduct.Text = product.ProductName
        Form3.txtPrice.Text = (Convert.ToDecimal(product.UnitPrice)).ToString("#,###.00")
        Form3.txtQtyUnits.Text = product.QuantityPerUnit
        Form3.cbSuppliers.Text = ""
        If product.Supplier IsNot Nothing Then Form3.cbSuppliers.SelectedItem = product.Supplier
        Form3.cbCategories.Text = ""
        If product.Category IsNot Nothing Then Form3.cbCategories.SelectedItem = product.Category
        Form3.bttnCreate.Text = "Submit changes"
        If Form3.ShowDialog = Windows.Forms.DialogResult.OK Then
            product.Category = Form3.cbCategories.SelectedItem
            product.Supplier = Form3.cbSuppliers.SelectedItem
            product.ProductName = Form3.txtProduct.Text
            product.QuantityPerUnit = Form3.txtQtyUnits.Text
            product.UnitPrice = Form3.txtPrice.Text
            ctx.SubmitChanges()
        End If
        lvProducts.SelectedItems(0).SubItems(0).Text = product.ProductID
        lvProducts.SelectedItems(0).SubItems(1).Text = product.ProductName
        lvProducts.SelectedItems(0).SubItems(2).Text = product.QuantityPerUnit
        lvProducts.SelectedItems(0).SubItems(3).Text = product.Category.CategoryName
        lvProducts.SelectedItems(0).SubItems(4).Text = Convert.ToDecimal(product.UnitPrice).ToString("#.00")
        lvProducts.SelectedItems(0).SubItems(5).Text = product.Supplier.CompanyName
    End Sub

End Class