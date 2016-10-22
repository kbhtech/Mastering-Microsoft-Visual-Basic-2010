Public Class Form1

    Dim DS As New NorthwindDataSet
    Dim CategoriesTA As New NorthwindDataSetTableAdapters.CategoriesTableAdapter
    Dim SuppliersTA As New NorthwindDataSetTableAdapters.SuppliersTableAdapter
    Dim ProductsTA As New NorthwindDataSetTableAdapters.ProductsTableAdapter

    Private Sub bttnPopulate_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles bttnPopulate.Click
        Dim categories As Integer = CategoriesTA.Fill(DS.Categories)
        Dim suppliers As Integer = SuppliersTA.Fill(DS.Suppliers)
        Dim products As Integer = ProductsTA.Fill(DS.Products)

        TextBox1.Clear()
        TextBox1.AppendText("DataSet filled with " & vbCrLf & _
                vbTab & categories.ToString & " categories" & vbCrLf & _
                vbTab & suppliers.ToString & " suppluers" & vbCrLf & _
                vbTab & products.ToString & " products")
    End Sub

    Private Sub bttnReadProducts_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles bttnReadProducts.Click
        TextBox1.Clear()
        Dim prod As NorthwindDataSet.ProductsRow
        TextBox1.AppendText("PRODUCTS" & vbCrLf)
        For Each prod In DS.Products.Rows
            TextBox1.AppendText(prod.ProductName & vbTab)

            TextBox1.AppendText(
                    IIf(prod.IsUnitPriceNull,
                    "Not for sale!",
                    prod.UnitPrice.ToString("#,###.00")))

            TextBox1.AppendText(vbCrLf)
        Next
        TextBox1.AppendText("CATEGORIES" & vbCrLf)
        Dim cat As NorthwindDataSet.CategoriesRow
        For Each cat In DS.Categories.Rows
            TextBox1.AppendText(cat.CategoryName & vbCrLf)
        Next
    End Sub

    Private Sub bttnSuppliersProducts_Click(ByVal sender As System.Object,
                                            ByVal e As System.EventArgs) Handles bttnSuppliersProducts.Click
        TextBox1.Clear()
        Dim supp As NorthwindDataSet.SuppliersRow
        For Each supp In DS.Suppliers.Rows
            TextBox1.AppendText(supp.CompanyName & vbCrLf)
            Dim prod As NorthwindDataSet.ProductsRow
            For Each prod In supp.GetProductsRows
                TextBox1.AppendText(vbTab & prod.ProductName & vbTab)
                If prod.IsUnitPriceNull Then
                    TextBox1.AppendText("Not for sale!")
                Else
                    TextBox1.AppendText(prod.UnitPrice.ToString("#,###.00") & vbCrLf)
                End If
            Next
        Next
    End Sub

    Private Sub bttnUpdate_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnUpdate.Click
        Dim selProduct As NorthwindDataSet.ProductsRow
        Dim RND As New System.Random
        selProduct = DS.Products.FindByProductID(RND.Next(1, 70))
        Dim newPrice As Decimal
        Try
            newPrice = Convert.ToDecimal(InputBox("Enter product's new price",
                                                  selProduct.ProductName,
                                                  selProduct.UnitPrice.ToString("#,###.00")))
        Catch
            Exit Sub
        End Try
        selProduct.UnitPrice = newPrice
    End Sub

    Private Sub bttnSubmit_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnSubmit.Click
        If DS.HasChanges Then
            Dim DT As NorthwindDataSet.ProductsDataTable =
                DS.Products.GetChanges
            If DT IsNot Nothing Then
                Try
                    ProductsTA.Update(DT)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                MsgBox(DT.Rows.Count.ToString &
                       " rows updated successfully.")
            End If
        End If
    End Sub

    Private Sub bttnView_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles bttnView.Click
        If DS.HasChanges Then
            Dim DT As NorthwindDataSet.ProductsDataTable = DS.Products.GetChanges
            If DT Is Nothing Then
                MsgBox("The DataSet contains no changes")
            Else
                Dim prod As NorthwindDataSet.ProductsRow
                TextBox1.Clear()
                For Each prod In DT.Rows
                    TextBox1.AppendText(prod.ProductName & vbTab & _
                            "OLD PRICE " & vbTab & prod.Item("UnitPrice", DataRowVersion.Original) & _
                            "NEW PRICE " & vbTab & prod.Item("UnitPrice", DataRowVersion.Current) & vbCrLf)
                Next
            End If
        End If
    End Sub

End Class
