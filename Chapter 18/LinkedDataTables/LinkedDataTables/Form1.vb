Public Class Form1

    Dim ProductsDS As New DS
    Dim categoriesBS As New BindingSource
    Dim productsBS As New BindingSource

    Private Sub CategoriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs)
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.CategoriesTableAdapter.Adapter.ContinueUpdateOnError = True
        Me.TableAdapterManager.ProductsTableAdapter.Adapter.ContinueUpdateOnError = True
        Me.TableAdapterManager.UpdateAll(Me.DS)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuppliersTableAdapter.Fill(Me.DS.Suppliers)
        Me.CategoriesTableAdapter.Fill(Me.DS.Categories)
        Me.ProductsTableAdapter.Fill(Me.DS.Products)
    End Sub

    Private Sub bttnSubmit_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles bttnSubmit.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.CategoriesTableAdapter.Adapter.ContinueUpdateOnError = True
        Me.TableAdapterManager.ProductsTableAdapter.Adapter.ContinueUpdateOnError = True

        TableAdapterManager.UpdateAll(DS)
        Dim msg As String = ""
        If DS.Products.HasErrors Then
            Dim row As DS.ProductsRow

            For Each row In DS.Products.GetErrors
                If row.HasErrors Then
                    Select Case row.RowState
                        Case DataRowState.Added
                            msg &= "FAILED TO ADD PRODUCT WITH ID = " &
                                Convert.ToString(row.ProductID & vbCrLf &
                                row.RowError & vbCrLf)
                        Case DataRowState.Modified
                            msg &= "FAILED TO MODIFY PRODUCT WITH ID = " &
                                Convert.ToString(row.ProductID & vbCrLf &
                                row.RowError & vbCrLf)
                        Case DataRowState.Deleted
                            msg &= "FAILED TO DELETE PRODUCT WITH ID = " &
                                Convert.ToString(row.Item("ProductID", DataRowVersion.Original) & vbCrLf &
                                row.RowError)
                    End Select
                    msg &= vbCrLf
                End If
            Next
        End If

        If DS.Tables("Categories").HasErrors Then
            Dim row As DS.ProductsRow
            For Each row In DS.Categories.GetErrors
                If row.HasErrors Then
                    Select Case row.RowState
                        Case DataRowState.Added
                            msg &= "FAILED TO ADD CATEGORY WITH ID = " &
                                Convert.ToString(row.CategoryID & vbCrLf &
                                row.RowError & vbCrLf)
                        Case DataRowState.Modified
                            msg &= "FAILED TO MODIFY CATEGORY WITH ID = " &
                                Convert.ToString(row.CategoryID & vbCrLf &
                                row.RowError & vbCrLf)
                        Case DataRowState.Deleted
                            msg &= "FAILED TO DELETE CATEGORY WITH ID = " &
                                Convert.ToString(row.Item("CategoryID", DataRowVersion.Original) & vbCrLf &
                                row.RowError)
                    End Select
                    msg &= vbCrLf
                End If
            Next
        End If
        MsgBox(msg)
    End Sub

    Private Sub CategoriesDataGridView_DataError(ByVal sender As Object,
                ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CategoriesDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub ProductsDataGridView_DataError(ByVal sender As Object,
                ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub ProductsDataGridView_RowPostPaint(ByVal sender As Object,
                ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles ProductsDataGridView.RowPostPaint
        Dim row As DS.ProductsRow
        Try
            row = CType(ProductsDataGridView.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            If row.RowState = DataRowState.Modified Then
                ProductsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
            End If
            If row.RowState = DataRowState.Added Then
                ProductsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
            End If
        Catch
        End Try
    End Sub

    Private Sub ProductsDataGridView_RowValidating(ByVal sender As Object,
                ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ProductsDataGridView.RowValidating
        Dim colIndex As Integer = ProductsDataGridView.Columns("DataGridViewTextBoxColumn9").Index
        Dim cellValue As String = ProductsDataGridView.Rows(e.RowIndex).Cells(colIndex).Value
        If Convert.ToDecimal(cellValue) < 0 Then
            CType(CType(ProductsBindingSource.Current, DataRowView).Row, DS.ProductsRow).RowError = "Price can't be negative"
        End If
    End Sub

    Private Sub ProductsDataGridView_RowValidated(ByVal sender As Object,
                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductsDataGridView.RowValidated
        Dim row As DS.ProductsRow
        row = CType(CType(ProductsBindingSource.Current, DataRowView).Row, DS.ProductsRow)
        ProductsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        If row.RowState = DataRowState.Modified Then
            ProductsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
        End If
        If row.RowState = DataRowState.Added Then
            ProductsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DS.WriteXml("tmpData.#@#", XmlWriteMode.DiffGram)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ProductsBindingSource.SuspendBinding()
        DS.ReadXml("tmpData.#@#", XmlReadMode.DiffGram)
        ProductsBindingSource.ResumeBinding()
    End Sub

End Class
