Public Class Form3

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles
                ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.ProductsTableAdapter.
           Adapter.ContinueUpdateOnError = True
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. 
        'You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)

    End Sub

    Private Sub bttnFilter_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles bttnFilter.Click
        Dim filter = InputBox("Enter product name, or part of it")
        ProductsBindingSource.Filter = "ProductName LIKE '%" & filter.Trim & "%'"
    End Sub

    Private Sub bttnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFind.Click
        Dim search = InputBox("Enter exact product name")
        Dim idx As Integer = ProductsBindingSource.Find("ProductName", search)
        ProductsBindingSource.Position = idx
    End Sub

    Private Sub bttnRefreshData_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles bttnRefreshData.Click
        If NorthwindDataSet.HasChanges Then
            Dim reply As MsgBoxResult =
                 MsgBox("The DataSet contains changes." &
                 vbCrLf & "Reload data anyway?",
                 MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation)
            If reply = MsgBoxResult.No Then Exit Sub
        End If
        Me.ProductsTableAdapter.Fill(
                    Me.NorthwindDataSet.Products)

    End Sub
End Class