Public Class Form1

    Dim regularfont, boldfont As Font

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim service As New NorthwindModel.NorthwindEntities(New Uri("http://localhost:51000/NWWebDataService.svc"))

        ' loop through the Orders table
        'For Each c In service.Orders
        '   Debug.WriteLine(c.OrderID)
        'Next

        ' loop through products
        'For Each p In service.Products
        '    Debug.WriteLine(p.ProductName)
        'Next

        RichTextBox1.Clear()
        ' print categories and products in each category
        RichTextBox1.SelectionFont = boldfont
        RichTextBox1.AppendText("Categories and Products" & vbCrLf)
        RichTextBox1.SelectionFont = regularfont
        For Each c In service.Categories
            RichTextBox1.SelectionFont = boldfont
            RichTextBox1.AppendText(c.CategoryName & vbCrLf)
            RichTextBox1.SelectionFont = regularfont
            service.LoadProperty(c, "Products")
            For Each p In c.Products
                RichTextBox1.AppendText(vbTab & p.ProductName & vbTab & p.UnitPrice.ToString & vbCrLf)
            Next
        Next

        ' load categories and product in a single trip to the database
        'For Each c In service.Categories.Expand("Products")
        '    RichTextBox1.SelectionFont = boldfont
        '    RichTextBox1.AppendText(c.CategoryName & vbCrLf)
        '    RichTextBox1.SelectionFont = regularfont
        '    For Each p In c.Products
        '        RichTextBox1.AppendText(c.CategoryName & vbTab & p.ProductName & vbTab & p.UnitPrice.ToString & vbCrLf)
        '    Next
        'Next

        ' print Customers/Companies
        RichTextBox1.SelectionFont = boldfont
        RichTextBox1.AppendText("Customers" & vbCrLf)
        RichTextBox1.SelectionFont = regularfont
        For Each c In service.Customers.AsEnumerable
            RichTextBox1.AppendText(c.CompanyName & vbCrLf)
        Next

        ' customers from Germany
        RichTextBox1.SelectionFont = boldfont
        RichTextBox1.AppendText("Orders from Germany" & vbCrLf)
        RichTextBox1.SelectionFont = regularfont
        For Each c In service.Customers.Where(Function(cust) cust.Country = "Germany")
            Dim selOrders = service.CreateQuery(Of NorthwindModel.Order)("Orders").Where( _
                Function(o) Year(o.OrderDate) = 1998 And o.Customer.CustomerID = c.CustomerID)
            RichTextBox1.AppendText(c.CompanyName & vbCrLf)
            RichTextBox1.AppendText("ORDERS" & vbCrLf)
            For Each o In selOrders
                RichTextBox1.AppendText(vbTab & o.OrderID & vbTab & o.OrderDate & vbCrLf)
            Next
        Next

        ' An alternate method to iterate through the orders of customers in Germany
        RichTextBox1.AppendText(vbCrLf)
        RichTextBox1.AppendText(vbCrLf)
        RichTextBox1.SelectionFont = boldfont
        RichTextBox1.AppendText("Orders from Germany (alternate)" & vbCrLf)
        RichTextBox1.SelectionFont = regularfont
        For Each c In service.Customers.Where(Function(cust) cust.Country = "Germany")
            service.LoadProperty(c, "Orders")
            RichTextBox1.AppendText(c.CompanyName & vbCrLf)
            For Each o In c.Orders
                service.LoadProperty(o, "Order_Details")
                Dim orderTotal = Aggregate dtl In o.Order_Details
                                  Into Sum(dtl.Quantity * dtl.UnitPrice * (1 - dtl.Discount))
                RichTextBox1.AppendText(vbTab & o.OrderID & vbTab & o.OrderDate & vbTab & orderTotal.ToString & vbCrLf)
            Next
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regularfont = RichTextBox1.Font
        boldfont = New Font(RichTextBox1.Font.Name, RichTextBox1.Font.Size, FontStyle.Bold)
        RichTextBox1.SelectionTabs = {120, 380, 460, 540}
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
        Dim service As New NorthwindModel.NorthwindEntities(New Uri("http://localhost:51000/NWWebDataService.svc"))
        Dim prod As New NorthwindModel.Product
        Dim cat = service.Categories.Where(Function(c) c.CategoryID = 4).First
        service.AddObject("Products", prod)
        prod.Category = cat
        service.SetLink(prod, "Category", cat)
        prod.ProductName = "NEW PRODUCT NAME"
        prod.UnitPrice = 11.2
        prod.UnitsInStock = 1
        prod.UnitsOnOrder = 12
        prod.QuantityPerUnit = "packaging info"
        prod.Discontinued = False
        Dim supplier As New NorthwindModel.Supplier
        supplier.CompanyName = "New Supplier"
        supplier.ContactName = "Contact name"
        supplier.ContactTitle = "Contact title"
        supplier.Address = "Supplier address"
        supplier.City = "City"
        supplier.Country = "Country"
        service.AddToSuppliers(supplier)
        service.SetLink(prod, "Supplier", supplier)
        Try
            service.SaveChanges()
            RichTextBox1.AppendText("New product inserted successfully with ID = " & prod.ProductID.ToString & vbCrLf)
        Catch ex As Exception
            MsgBox("FAILED TO INSERT NEW PRODUCT!")
            RichTextBox1.Text = "Operation failed"
        End Try

        ' now update the new product
        prod.UnitPrice += 2
        service.MergeOption = Services.Client.MergeOption.PreserveChanges
        Try
            service.SaveChanges()
            RichTextBox1.AppendText("New product's price updated succesfully" & vbCrLf)
        Catch ex As Exception
            MsgBox("FAILED TO UPDATE PRODUCT WITH ID = " & prod.ProductID.ToString)
        End Try
        service.DeleteObject(prod)
        Try
            service.SaveChanges()
            RichTextBox1.AppendText("Product with ID = " & prod.ProductID.ToString & " deleted" & vbCrLf)
        Catch ex As Exception
            MsgBox("FAILED TO DELETE PRODUCT WITH ID = " & prod.ProductID.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim service As New NorthwindModel.NorthwindEntities(New Uri("http://localhost:51000/NWWebDataService.svc"))
        RichTextBox1.Clear()
        ' now submit a new order
        ' create a new disconnected Order object
        Dim newOrder As New NorthwindModel.Order
        ' and add it to the Orders table
        service.AddToOrders(newOrder)
        ' now create a customer object that represents the customer
        ' that placed the order. 
        ' You can't set the newOrder.CustomerID property. 
        ' The newOrder object has a Customer object and there's a relationship
        ' between the Orders and Customers tables. To associate a customer with
        ' the new order, we must set the order's Customer property to a Customer
        ' object and then establish a relationship between the two
        ' First, create a new Customer object by selecting a customer from
        ' the Customers table by the customer's ID field. 
        Dim cust = service.Customers.Where(Function(p) p.CustomerID = "ANTON").First()
        ' Then set the order's Customer property to the newly created customer object
        newOrder.Customer = cust
        ' and finally create a link between the order and the customer.
        ' Although the relationship exists between the two tables, we must also
        ' add a link between the newOrer and cust objects, because they live at
        ' the client and they're not associated automatically.
        service.SetLink(newOrder, "Customer", cust)
        ' Do the same for the employee.
        ' Create a new Employee object
        Dim emp = service.Employees.Where(Function(p) p.EmployeeID = 3).First
        ' Set the order's Employee property to the emp object
        newOrder.Employee = emp
        ' and associate the order with the employee
        service.SetLink(newOrder, "Employee", emp)
        ' now set the remaining (scalar) properties of the order
        ' the order date
        newOrder.OrderDate = Now
        newOrder.ShipAddress = cust.Address
        newOrder.ShipCity = cust.City

        ' Now create the order's details.
        ' Each detail is a Detail object, which will be added the Order_Details property
        ' of the newOrder object. The Order_Details property is a collection and
        ' as such it provides an Add method.
        ' Create a dtl object
        Dim dtl As New NorthwindModel.Order_Detail
        ' Set its Product property to a Product object
        Dim dtlProd = service.Products.Where(Function(p) p.ProductID = 31).First
        ' and then set its Order property to the newOrder object
        ' to associate the new detail line with the newOrder order.
        dtl.Order = newOrder
        ' Set the detail line's Product property to a Product object
        dtl.Product = dtlProd
        ' and then the remaining (scalar) fields
        dtl.UnitPrice = 11.2
        dtl.Quantity = 9
        ' and finally add the newly created detail line to the Order_Details entity
        service.AddToOrder_Details(dtl)
        ' as well as the to the Order_Details cllection of the newOrder object
        newOrder.Order_Details.Add(dtl)
        ' As usual, establish a relationship between the detail line and the Product entity
        service.SetLink(dtl, "Product", dtlProd)
        ' as well as between the detail line and the Order entity
        service.SetLink(dtl, "Order", newOrder)

        ' add a second detail line following similar steps
        dtl = New NorthwindModel.Order_Detail
        dtlProd = New NorthwindModel.Product
        dtlProd = service.Products.Where(Function(p) p.ProductID = 56).First()
        dtl.Order = newOrder
        dtl.Product = dtlProd
        ' this time include a discount
        dtl.UnitPrice = dtlProd.UnitPrice * 0.9
        dtl.Discount = 0.1
        dtl.Quantity = -5
        service.AddToOrder_Details(dtl)
        newOrder.Order_Details.Add(dtl)
        service.SetLink(dtl, "Product", dtlProd)
        service.SetLink(dtl, "Order", newOrder)
        ' Prepare to commit the new order.
        ' First set the SaveChangesDefaultOptions to Batch,
        ' so that all updates will be performed in a batch manner
        ' This is equivalent to an ADO transaction. If a row fails to insert
        ' the entire process will be aborted
        service.SaveChangesDefaultOptions = Services.Client.SaveChangesOptions.Batch
        ' and then call the service.SaveChanges method to submit all pending rows to the database
        Try
            service.SaveChanges()
            RichTextBox1.AppendText("Order " & newOrder.OrderID.ToString & " committed successfully!")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText("ORDER ID: " & newOrder.OrderID.ToString & vbTab & newOrder.OrderDate.ToString & vbCrLf)
            RichTextBox1.AppendText(vbTab & "Customer: " & newOrder.Customer.CompanyName & vbCrLf)
            RichTextBox1.AppendText(vbTab & "Employee: " & newOrder.Employee.FirstName & " " & newOrder.Employee.LastName & vbCrLf)
            RichTextBox1.AppendText("ITEMS PURCHASED" & vbCrLf)
            For Each dtl In newOrder.Order_Details
                RichTextBox1.AppendText("Product: " & dtl.Product.ProductName & vbTab & dtl.UnitPrice.ToString & vbTab & dtl.Quantity.ToString & vbTab & dtl.Discount.ToString & vbCrLf)
            Next
        Catch ex As Exception
            MsgBox("FAILED TO COMMIT NEW ORDER")
        End Try
    End Sub
End Class
