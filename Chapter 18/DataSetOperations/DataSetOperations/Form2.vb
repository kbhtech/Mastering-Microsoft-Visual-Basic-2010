Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object,
                           ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. 
        'You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
    End Sub

    Private Sub bttnSubmit_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnSubmit.Click
        If NorthwindDataSet.HasChanges Then
            Dim DT As NorthwindDataSet.ProductsDataTable = NorthwindDataSet.Products.GetChanges
            If DT IsNot Nothing Then
                Try
                    ProductsTableAdapter.Update(DT)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                MsgBox(DT.Rows.Count.ToString & " rows updated successfully.")
            End If
        End If
    End Sub

    Private Sub bttnFirst_Click(ByVal sender As System.Object,
                                ByVal e As System.EventArgs) Handles bttnFirst.Click
        ProductsBindingSource.MoveFirst()
    End Sub

    Private Sub bttnPrevious_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles bttnPrevious.Click
        ProductsBindingSource.MovePrevious()
    End Sub

    Private Sub bttnNext_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles bttnNext.Click
        ProductsBindingSource.MoveNext()
    End Sub

    Private Sub bttnLast_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles bttnLast.Click
        ProductsBindingSource.MoveLast()
    End Sub

    Private Sub bttnFilter_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnFilter.Click
        Dim filter As String
        filter = InputBox("Enter product name, or part of it")
        ProductsBindingSource.Filter = "ProductName LIKE '%" & filter.Trim & "%'"
    End Sub

    Private Sub bttnFind_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles bttnFind.Click
        Dim search As String
        search = InputBox("Enter exact product name")
        Dim idx As Integer = ProductsBindingSource.Find("ProductName", search)
        ProductsBindingSource.Position = idx
    End Sub
End Class