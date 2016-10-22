Public Class frmSQL

    Dim CN As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")

    Private Sub AddProductRow()
        Dim LI As New ListViewItem
        LI.Text = txtID.Text
        LI.SubItems.Add(txtProduct.Text)
        LI.SubItems.Add(txtPrice.Text)
        LI.SubItems.Add(txtQty.Text)
        LI.SubItems.Add(txtSubtotal.Text)
        ListView1.Items.Add(LI)
        UpdateTotals()
    End Sub

    Private Sub UpdateTotals()
        Dim items As Integer
        Dim total As Decimal
        For Each LI As ListViewItem In ListView1.Items
            items += Integer.Parse(LI.SubItems(3).Text)
            total += Decimal.Parse(LI.SubItems(4).Text)
        Next
        txtItems.Text = items.ToString
        txtTotal.Text = total.ToString("#,###.00")
    End Sub

    Private Sub ClearTextBoxes()
        txtID.Text = ""
        txtProduct.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtSubtotal.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbEmployees.DisplayMember = "EmployeeName"
        cbEmployees.ValueMember = "EmployeeID"
        For Each emp As NWEmployee In NWEmployee.GetAllEmployees
            cbEmployees.Items.Add(emp)
        Next

        cbCustomers.DisplayMember = "CompanyName"
        cbCustomers.ValueMember = "CustomerID"
        For Each cust As NWCustomer In NWCustomer.GetAllCustomers
            cbCustomers.Items.Add(cust)
        Next
    End Sub

    Private Sub ListView1_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles ListView1.ColumnWidthChanged
        txtItems.Left = ListView1.Left + ListView1.Columns(0).Width + ListView1.Columns(1).Width + ListView1.Columns(2).Width
        txtItems.Width = ListView1.Columns(3).Width
        txtTotal.Left = txtItems.Left + txtItems.Width
        txtTotal.Width = ListView1.Columns(4).Width
    End Sub

    Private Sub ListView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyUp
        If e.KeyCode = Keys.Delete And ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).Remove()
            UpdateTotals()
        End If
        If e.KeyCode = Keys.Escape Then
            ClearTextBoxes()
            txtID.Focus()
        End If
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ShowDetail()
    End Sub

    Private Sub ShowDetail()
        If ListView1.SelectedItems.Count > 0 Then
            txtID.Text = ListView1.SelectedItems(0).Text
            txtProduct.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtPrice.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtQty.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtSubtotal.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtID.Text.Length > 0 Then
                Dim P As NWProduct
                Dim allProducts As List(Of NWProduct) = NWProduct.GetProductByID(txtID.Text.Trim)
                If allProducts.Count = 1 Then
                    txtProduct.Text = allProducts(0).ProductName
                    txtPrice.Text = allProducts(0).ProductPrice.ToString("#.00")
                    txtQty.Focus()
                Else
                    ListView2.Items.Clear()
                    For Each P In allProducts
                        Dim LI As New ListViewItem
                        LI.Text = P.ProductID
                        LI.SubItems.Add(P.ProductName)
                        LI.SubItems.Add(P.ProductPrice.ToString("#,###.00"))
                        ListView2.Items.Add(LI)
                    Next
                    If ListView2.Items.Count > 0 Then
                        ListView2.Visible = True
                        ListView2.Items(0).Selected = True
                        ListView2.Capture = True
                        ListView2.Focus()
                    Else
                        txtID.Clear()
                        txtID.Focus()
                    End If

                End If
            End If
            End If
            If e.KeyData = Keys.Down Then
                If ListView1.Items.Count > 0 Then
                    ClearTextBoxes()
                    ListView1.Items(0).Selected = True
                    ListView1.Focus()
                End If
            End If
    End Sub

    Private Sub txtQty_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp
        If txtProduct.Text.Trim = "" Then
            MsgBox("Please specify a product by its ID or name!")
            Exit Sub
        End If
        If e.KeyData = Keys.Enter Then
            Dim qty As Integer
            Integer.TryParse(txtQty.Text, qty)
            If qty > 0 Then
                txtSubtotal.Text = (Decimal.Parse(txtPrice.Text) * qty).ToString("#,###.00")
                AddProductRow()
                ClearTextBoxes()
                txtID.Focus()
            Else
                txtQty.Text = ""
            End If
        End If
        If e.KeyData = Keys.Escape Then
            ClearTextBoxes()
            txtID.Focus()
        End If
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        Dim newOrder As New NWOrder
        newOrder.OrderDate = Today
        newOrder.CustomerID = CType(cbCustomers.SelectedItem, NWCustomer).CustomerID
        newOrder.EmployeeID = CType(cbEmployees.SelectedItem, NWEmployee).EmployeeID
        For Each LI As ListViewItem In ListView1.Items
            Dim newDetail As New NWOrder.NWOrderDetail
            newDetail.ProductID = LI.Text
            newDetail.ProductPrice = System.Convert.ToDecimal(LI.SubItems(2).Text)
            newDetail.ProductQuantity = System.Convert.ToInt32(LI.SubItems(3).Text)
            newOrder.Details.Add(newDetail)
        Next
        Dim orderID As Integer
        Try
            orderID = NWOrder.SaveOrder(newOrder)
        Catch ex As Exception
            MsgBox("Failed to submit order to database" & vbCrLf & ex.Message)
            Exit Sub
        End Try
        MsgBox("Order " & orderID & " committed successfuly")
    End Sub

    Private Sub bttnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNew.Click
        ClearTextBoxes()
        txtID.Focus()
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub ListView2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView2.KeyUp
        If ListView2.Visible And ListView2.SelectedItems.Count = 1 Then
            If e.KeyCode = Keys.Enter Then
                txtID.Text = ListView2.SelectedItems(0).Text
                txtProduct.Text = ListView2.SelectedItems(0).SubItems(1).Text
                txtPrice.Text = System.Convert.ToDecimal(ListView2.SelectedItems(0).SubItems(2).Text).ToString("#,###.00")
                ListView2.Visible = False
                txtQty.Focus()
            End If
        End If
    End Sub

    Private Sub ListView2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.LostFocus
        ListView2.Visible = False
        If ListView2.Visible = True Then
            txtID.Focus()
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class


Public Class NWEmployee
    Public EmployeeID As Integer
    Public EmployeeName As String
    Public Overrides Function ToString() As String
        Return EmployeeName
    End Function

    Public Shared Function GetAllEmployees() As List(Of NWEmployee)
        Dim CMD As New SqlClient.SqlCommand
        Dim Employees As New List(Of NWEmployee)
        CMD.CommandText = "SELECT * FROM Employees"
        CMD.CommandType = CommandType.Text
        Dim CN As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        CMD.Connection = CN
        CN.Open()
        Dim RDR As SqlClient.SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            Dim Emp As New NWEmployee
            Emp.EmployeeID = RDR.GetInt32(RDR.GetOrdinal("EmployeeID"))
            Emp.EmployeeName = RDR.GetString(RDR.GetOrdinal("LastName")) & " " & RDR.GetString(RDR.GetOrdinal("FirstName"))
            Employees.Add(Emp)
        End While
        RDR.Close()
        Return Employees
    End Function

End Class

Public Class NWCustomer
    Public CustomerID As String
    Public CustomerName As String
    Public Overrides Function ToString() As String
        Return CustomerName
    End Function

    Public Shared Function GetAllCustomers() As List(Of NWCustomer)
        Dim CMD As New SqlClient.SqlCommand
        Dim Customers As New List(Of NWCustomer)
        CMD.CommandText = "SELECT * FROM Customers"
        CMD.CommandType = CommandType.Text
        Dim CN As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        CMD.Connection = CN
        CN.Open()
        Dim RDR As SqlClient.SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            Dim Cust As New NWCustomer
            Cust.CustomerID = RDR.GetString(RDR.GetOrdinal("CustomerID"))
            Cust.CustomerName = RDR.GetString(RDR.GetOrdinal("CompanyName"))
            Customers.Add(Cust)
        End While
        RDR.Close()
        Return Customers
    End Function
End Class

Public Class NWProduct
    Public ProductID As Integer
    Public ProductName As String
    Public ProductPrice As Decimal

    Public Shared Function GetProductByID(ByVal productID As String) As List(Of NWProduct)
        Dim products As New List(Of NWProduct)
        Dim CN As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        Dim CMD As New SqlClient.SqlCommand
        Dim RDR As SqlClient.SqlDataReader
        If IsNumeric(productID) Then
            CMD.CommandText = "SELECT * FROM Products WHERE ProductID=@ProductID"
            CMD.CommandType = CommandType.Text
            CMD.Parameters.AddWithValue("@ProductID", productID)
            CMD.Connection = CN
            CN.Open()
            RDR = CMD.ExecuteReader
            Dim prod As NWProduct = Nothing
            If RDR.Read Then
                prod = New NWProduct
                prod.ProductID = RDR.GetInt32(RDR.GetOrdinal("ProductID"))
                prod.ProductName = RDR.GetString(RDR.GetOrdinal("ProductName"))
                prod.ProductPrice = RDR.GetDecimal(RDR.GetOrdinal("UnitPrice"))
                products.Add(prod)
            End If
        Else
            CMD.CommandText = "SELECT * FROM Products WHERE ProductName LIKE '%' + @ProductID + '%'"
            CMD.CommandType = CommandType.Text
            CMD.Parameters.AddWithValue("@ProductID", productID)
            CMD.Connection = CN
            CN.Open()
            RDR = CMD.ExecuteReader
            While RDR.Read
                Dim prod As New NWProduct
                prod.ProductID = RDR.GetInt32(RDR.GetOrdinal("ProductID"))
                prod.ProductName = RDR.GetString(RDR.GetOrdinal("ProductName"))
                prod.ProductPrice = RDR.GetDecimal(RDR.GetOrdinal("UnitPrice"))
                products.Add(prod)
            End While
        End If
        CN.Close()
        Return products
    End Function
End Class


Public Class NWOrder
    Public Class NWOrderDetail
        Public ProductID As Integer
        Public ProductPrice As Decimal
        Public ProductQuantity As Integer
        Public ProductDiscount As Decimal
    End Class

    Public OrderDate As Date
    Public EmployeeID As Integer
    Public CustomerID As String
    Public Details As New List(Of NWOrderDetail)

    Public Shared Function SaveOrder(ByVal newOrder As NWOrder) As Integer
        Dim CN As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        Dim CMD As New SqlClient.SqlCommand
        CN.Open()
        CMD.Connection = CN
        Dim TR As SqlClient.SqlTransaction = CN.BeginTransaction
        CMD.Transaction = TR
        CMD.CommandText = "INSERT Orders (OrderDate, EmployeeID, CustomerID) VALUES (@orderDate, @employeeID, @customerID);SELECT Scope_Identity()"
        CMD.Parameters.AddWithValue("@orderDate", Today)
        CMD.Parameters.AddWithValue("@employeeID", newOrder.EmployeeID)
        CMD.Parameters.AddWithValue("@customerID", newOrder.CustomerID)
        Dim OrderID As Int32
        Try
            OrderID = System.Convert.ToInt32(CMD.ExecuteScalar)
        Catch ex As Exception
            TR.Rollback()
            CN.Close()
            Throw ex
        End Try
        For Each det As NWOrderDetail In newOrder.Details
            CMD.CommandText = "INSERT [Order Details] (OrderID, ProductID, UnitPrice, Quantity) VALUES(@OrderID, @productID, @price, @quantity)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@orderID", OrderID)
            CMD.Parameters.AddWithValue("@productID", det.ProductID)
            CMD.Parameters.AddWithValue("@price", det.ProductPrice)
            CMD.Parameters.AddWithValue("@quantity", det.ProductQuantity)
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                TR.Rollback()
                CN.Close()
                Throw ex
            End Try
        Next
        TR.Commit()
        CN.Close()
        Return OrderID
    End Function
End Class
