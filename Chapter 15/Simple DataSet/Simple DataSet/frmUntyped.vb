Imports System.Data.SqlClient

Public Class frmUntyped
    Dim DS As New DataSet
    Dim DACategories As New SqlClient.SqlDataAdapter
    Dim DAProducts As New SqlClient.SqlDataAdapter
    Dim regularFont, boldFont As Font

    Private Sub bttnCreateDataSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCreateDataSet.Click
        DS.Clear()
        DACategories.Fill(DS, "Categories")
        DAProducts.Fill(DS, "Products")
        DS.Relations.Clear()
        DS.Relations.Add(New Data.DataRelation("CategoriesProducts", _
                                        DS.Tables("Categories").Columns("CategoryID"), _
                                        DS.Tables("Products").Columns("CategoryID")))
        RichTextBox1.Clear()
        Dim category As DataRow
        For Each category In DS.Tables("Categories").Rows
            RichTextBox1.SelectionFont = boldFont
            RichTextBox1.AppendText(category.Item("CategoryName") & vbCrLf)
            RichTextBox1.SelectionFont = regularFont
            Dim product As DataRow
            For Each product In category.GetChildRows("CategoriesProducts")
                RichTextBox1.AppendText(product.Item("ProductID") & vbTab & _
                            product.Item("ProductName") & vbTab)
                If IsDBNull(product.Item("UnitPrice")) Then
                    RichTextBox1.AppendText("***" & vbCrLf)
                Else
                    RichTextBox1.AppendText(Convert.ToDecimal(product.Item("UnitPrice")).ToString("#.00") & vbCrLf)
                End If
            Next
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boldFont = New Font(RichTextBox1.Font.Name, RichTextBox1.Font.Size, FontStyle.Bold)
        regularFont = New Font(RichTextBox1.Font.Name, RichTextBox1.Font.Size, FontStyle.Regular)

        Dim CN As New SqlClient.SqlConnection("data source=localhost;initial catalog=northwind;Integrated Security=True")

        DACategories.SelectCommand = New SqlClient.SqlCommand("SELECT CategoryID, CategoryName, Description FROM Categories")
        DACategories.SelectCommand.Connection = CN
        Dim CategoriesCB As SqlCommandBuilder = New SqlCommandBuilder(DACategories)
        CategoriesCB.ConflictOption = ConflictOption.CompareAllSearchableValues

        DAProducts.SelectCommand = New SqlClient.SqlCommand("SELECT ProductID, ProductName, CategoryID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products ")
        DAProducts.SelectCommand.Connection = CN
        DAProducts.ContinueUpdateOnError = True
        Dim ProductsCB As SqlCommandBuilder = New SqlCommandBuilder(DAProducts)
        ProductsCB.ConflictOption = ConflictOption.CompareAllSearchableValues

        RichTextBox1.SelectionFont = boldFont
        RichTextBox1.AppendText("Command for the Categories Table" & vbCrLf)
        RichTextBox1.SelectionFont = regularFont
        RichTextBox1.AppendText(vbTab & "UPDATE COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & CategoriesCB.GetUpdateCommand.CommandText & vbCrLf)
        RichTextBox1.AppendText("INSERT COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & CategoriesCB.GetInsertCommand.CommandText & vbCrLf)
        RichTextBox1.AppendText("DELETE COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & CategoriesCB.GetDeleteCommand.CommandText & vbCrLf)

        RichTextBox1.SelectionFont = boldFont
        RichTextBox1.AppendText("Products Table" & vbCrLf)
        RichTextBox1.SelectionFont = regularFont
        RichTextBox1.AppendText("UPDATE COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & ProductsCB.GetUpdateCommand.CommandText & vbCrLf)
        RichTextBox1.AppendText("INSERT COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & ProductsCB.GetInsertCommand.CommandText & vbCrLf)
        RichTextBox1.AppendText("DELETE COMMAND " & vbCrLf)
        RichTextBox1.AppendText(vbTab & ProductsCB.GetDeleteCommand.CommandText & vbCrLf)
        Dim tabs() As Integer = {80, 300}
        RichTextBox1.SelectionTabs = tabs
    End Sub

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        Dim RND As New Random
        Try
            DS.Tables("Products").Rows(RND.Next(1, 78)).Item("ProductName") &= " - NEW"
        Catch ex As Exception
        End Try
        DS.Tables("Products").Rows(RND.Next(1, 78)).Delete()
        Dim values() As Object = {-1, "New Product", RND.Next(1, 6), RND.Next(-100, 400) / 10, 1, 10}
        DS.Tables("Products").Rows.Add(values)
        Try
            DS.Tables("Categories").Rows(RND.Next(1, 7)).Item("CategoryName") &= " - NEW"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bttnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubmit.Click
        Try
            DAProducts.Update(DS.Tables("Products"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If DS.Tables("Products").HasErrors Then
            Dim row As DataRow
            Dim msg As String = ""
            For Each row In DS.Tables("Products").GetErrors
                If row.HasErrors Then
                    Select Case row.RowState
                        Case DataRowState.Added
                            msg &= "FAILED TO ADD PRODUCT WITH ID = " & Convert.ToString(row.Item("ProductID") & vbCrLf & _
                                                            row.RowError & vbCrLf)
                        Case DataRowState.Modified
                            msg &= "FAILED TO MODIFY PRODUCT WITH ID = " & Convert.ToString(row.Item("ProductID") & vbCrLf & _
                                                            row.RowError & vbCrLf)
                        Case DataRowState.Deleted
                            msg &= "FAILED TO DELETE PRODUCT WITH ID = " & Convert.ToString(row.Item("ProductID", DataRowVersion.Original) & vbCrLf & _
                                                            row.RowError)
                    End Select
                    msg &= vbCrLf
                End If
            Next
            MsgBox(msg)
        End If

        If DS.Tables("Categories").HasErrors Then
            Dim row As DataRow
            Dim msg As String = ""
            For Each row In DS.Tables("Categories").GetErrors
                If row.HasErrors Then
                    Select Case row.RowState
                        Case DataRowState.Added
                            msg &= "FAILED TO ADD CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID") & vbCrLf & _
                                                            row.RowError & vbCrLf)
                        Case DataRowState.Modified
                            msg &= "FAILED TO MODIFY CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID") & vbCrLf & _
                                                            row.RowError & vbCrLf)
                        Case DataRowState.Deleted
                            msg &= "FAILED TO DELETE CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID", DataRowVersion.Original) & vbCrLf & _
                                                            row.RowError)
                    End Select
                    msg &= vbCrLf
                End If
            Next
            MsgBox(msg)
        End If

    End Sub

    Private Sub bttnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShow.Click
        Dim product As DataRow
        Dim msg As String = ""
        For Each product In DS.Tables("Products").Rows
            If product.RowState = DataRowState.Added Then
                msg &= "ADDED PRODUCT: " & product.Item("ProductName") & vbTab & product.Item("UnitPrice").ToString & vbCrLf
            End If
            If product.RowState = DataRowState.Modified Then
                msg &= "MODIFIED PRODUCT: " & product.Item("ProductName") & vbTab & product.Item("UnitPrice").ToString & vbCrLf
            End If
            If product.RowState = DataRowState.Deleted Then
                msg &= "DELETED PRODUCT: " & product.Item("ProductName", DataRowVersion.Original) & vbTab & product.Item("UnitPrice", DataRowVersion.Original).ToString & vbCrLf
            End If
        Next
        Dim category As DataRow
        For Each category In DS.Tables("Categories").Rows
            If category.RowState = DataRowState.Added Then
                msg &= "ADDED CATEGORY: " & category.Item("CategoryName") & vbCrLf
            End If
            If category.RowState = DataRowState.Modified Then
                msg &= "MODIFIED PRODUCT: " & category.Item("CategoryName") & vbCrLf
            End If
            If category.RowState = DataRowState.Deleted Then
                msg &= "DELETED PRODUCT: " & category.Item("CategoryID", DataRowVersion.Original) & vbCrLf
            End If
        Next
        If msg.Length > 0 Then
            MsgBox(msg)
        Else
            MsgBox("There are no changes in the dataset")
        End If
    End Sub

    Private Sub bttnRejectChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRejectChanges.Click
        DS.RejectChanges()
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        DS.WriteXml("DataSet.xml")
    End Sub

    Private Sub bttnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLoad.Click
        DS.ReadXml("DataSet.xml")
    End Sub
End Class
