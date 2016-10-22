Public Class frmLINQ

    Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtID.Text.Length > 0 Then
                Dim P As Product = (New NWData).GetProductByID(txtID.Text.Trim)
                If P IsNot Nothing Then
                    txtProduct.Text = P.ProductName
                    txtPrice.Text = P.UnitPrice.ToString
                    txtQty.Focus()
                Else
                    txtID.Clear()
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
        cbEmployees.ValueMember = "EmployeeID"
        cbEmployees.DisplayMember = "LastName"
        Dim Data As New NWData
        For Each emp In Data.GetEmployees
            cbEmployees.Items.Add(emp)
        Next

        cbCustomers.ValueMember = "CustomerID"
        cbCustomers.DisplayMember = "CompanyName"
        For Each cust In Data.GetCustomers
            cbCustomers.Items.Add(cust)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("Please add one or more items to the invoice")
            Exit Sub
        End If

        If cbCustomers.SelectedIndex = -1 Then
            MsgBox("Please select a customer name")
            Exit Sub
        End If

        If cbEmployees.SelectedIndex = -1 Then
            MsgBox("Please select an employee name")
            Exit Sub
        End If

        Dim newOrder As New Order
        newOrder.CustomerID = CType(cbCustomers.SelectedItem, Customer).CustomerID
        newOrder.EmployeeID = CType(cbEmployees.SelectedItem, Employee).EmployeeID
        newOrder.OrderDate = Today
        For Each LI As ListViewItem In ListView1.Items
            Dim newDetail As New Order_Detail
            newDetail.ProductID = LI.Text
            newDetail.UnitPrice = Decimal.Parse(LI.SubItems(2).Text)
            newDetail.Quantity = Integer.Parse(LI.SubItems(3).Text)
            newDetail.Discount = 0D
            newOrder.Order_Details.Add(newDetail)
        Next

        Dim ID As Integer
        ID = NWData.SaveOrder(newOrder)
        If ID > 0 Then
            MsgBox("Order " & newOrder.OrderID.ToString & " submitted successfully")
        Else
            MsgBox("Failed to insert new order to database")
        End If
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

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub
End Class

Public Class NWData
    Public Function GetProductByID(ByVal productID As Integer) As Product
        Dim ctx As New NWDataContext
        Dim prod = (From p In ctx.Products
                      Where p.ProductID = productID
                      Select p).FirstOrDefault
        Return prod
    End Function

    Public Function GetEmployees() As List(Of Employee)
        Dim ctx As New NWDataContext
        Dim emps = (From emp In ctx.Employees
                      Select emp).ToList
        Return emps
    End Function

    Public Function GetCustomers() As List(Of Customer)
        Dim ctx As New NWDataContext
        Dim customers = (From cust In ctx.Customers
                      Select cust).ToList
        Return customers
    End Function

    Public Shared Function SaveOrder(ByVal newOrder As Order) As Integer
        Dim ctx As New NWDataContext

        Using TR As New System.Transactions.TransactionScope
            ctx.Orders.InsertOnSubmit(newOrder)
            Try
                ctx.SubmitChanges()
                TR.Complete()
            Catch ex As Exception
                Return (-1)
            End Try
        End Using
        Return newOrder.OrderID
    End Function
End Class
