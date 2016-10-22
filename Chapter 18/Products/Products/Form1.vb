Public Class Form1

    Dim queryResult As EnumerableRowCollection(Of NorthwindDataSet.ProductsRow)

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
    End Sub


    Private Sub ProductsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuppliersTableAdapter.Fill(Me.NorthwindDataSet.Suppliers)
        Me.CategoriesTableAdapter.Fill(Me.NorthwindDataSet.Categories)
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
        cboCategoryFilter.DisplayMember = "CategoryName"
        cboCategoryFilter.ValueMember = "CategoryID"
        cboCategoryFilter.Items.Insert(0, "All")
        For Each category In NorthwindDataSet.Categories
            cboCategoryFilter.Items.Insert(category.CategoryID, category)
        Next
        cboCategoryFilter.SelectedIndex = 0
    End Sub


    Private Sub ProductsBindingSource_CurrentItemChanged(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles
                ProductsBindingSource.CurrentItemChanged
        If Not IsNothing(queryResult) AndAlso queryResult.Count < 1 Then Exit Sub
        ErrorProvider1.Clear()
        Dim product As NorthwindDataSet.ProductsRow
        product = CType(CType(
                  ProductsBindingSource.Current, 
                  DataRowView).Row, NorthwindDataSet.ProductsRow)
        If Not product.IsUnitPriceNull AndAlso
             Convert.ToDecimal(product.UnitPrice) < 0 Then
            ErrorProvider1.SetError(UnitPriceTextBox,
                      "PRICE CAN'T BE NEGATIVE!")
        End If
        If ProductNameTextBox.Text.Trim.Length = 0 Then
            If CType(ProductsBindingSource.Current, 
               DataRowView).Row.RowState <>
               DataRowState.Detached Then
                ErrorProvider1.SetError(
                     ProductNameTextBox,
                     "PRODUCT NAME CAN'T BE BLANK!")
            End If
        End If
    End Sub

    Private Sub bttnShowDeleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShowDeleted.Click
        Form2.CheckedListBox1.Items.Clear()
        For Each row As DataRow In NorthwindDataSet.Products.Rows
            If row.RowState = DataRowState.Deleted Then
                Form2.CheckedListBox1.Items.Add(
                row.Item("ProductID",
                DataRowVersion.Original) & " " &
                row.Item("ProductName",
                DataRowVersion.Original))
            End If
        Next
        Form2.ShowDialog()
        Dim SelectedIDs As New ArrayList
        For Each itm As String In Form2.CheckedListBox1.CheckedItems
            SelectedIDs.Add(Convert.ToInt32(
               itm.Substring(0, itm.IndexOf(" ") + 1)))
        Next
        Dim cust As NorthwindDataSet.ProductsRow
        For Each cust In NorthwindDataSet.Products
            If cust.RowState = DataRowState.Deleted _
                AndAlso SelectedIDs.Contains(cust.Item(
                "ProductID", DataRowVersion.Original)) Then
                cust.RejectChanges()
            End If
        Next
    End Sub

    Private Sub bttnFilter_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnFilter.Click
        Dim categoryId As Integer
        If Not cboCategoryFilter.Text = "All" Then
            categoryId = CType(cboCategoryFilter.SelectedItem, 
                    NorthwindDataSet.CategoriesRow).CategoryID
        End If

        queryResult = From product In NorthwindDataSet.Products
                      Where ((cboCategoryFilter.Text = "All" OrElse
                            product.CategoryID = categoryId) And
                            (String.IsNullOrEmpty(txtUnitsOnOrderFilter.Text) OrElse
                            product.UnitsOnOrder > CInt(txtUnitsOnOrderFilter.Text)) And
                            (String.IsNullOrEmpty(txtUnitsInStockFilter.Text) OrElse
                            product.UnitsInStock < CInt(txtUnitsInStockFilter.Text)))
                            Select product

        ProductsBindingSource.DataSource = queryResult.AsDataView()

    End Sub
End Class