Imports System.Data.Objects
Imports System.Data.EntityClient

Public Class eSQLDynamicQuery

    Dim command As EntityCommand
    Dim eSqlSelect = "SELECT book.ISBN, book.Title, book.PublishingDate " &
                    "from BooksAndAuthorsContainer.Books as book"
    Dim eSqlWhere As String

    Private Sub btnFind_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnFind.Click
        gridResult.Rows.Clear()
        Using connection As New EntityConnection("Name=BooksAndAuthorsContainer")
            connection.Open()
            command = connection.CreateCommand()
            AddISBNCondition()
            AddTitleCondition()
            AddPublishedBeforeCondition()
            AddPublishedAfterCondition()
            command.CommandText = eSqlSelect & eSqlWhere
            Dim reader = command.ExecuteReader(CommandBehavior.SequentialAccess)
            While (reader.Read())
                gridResult.Rows.Add(New String() {reader("ISBN"), reader("Title"),
                    reader("PublishingDate")})
            End While
        End Using
    End Sub

    Private Sub AddISBNCondition()
        If String.IsNullOrEmpty(txtISBN.Text) Then Exit Sub
        ConcatenateAndOrWhere()
        eSqlWhere = eSqlWhere & "book.ISBN LIKE @isbn"
        command.Parameters.AddWithValue("isbn", "%" + txtISBN.Text + "%")
    End Sub

    Private Sub AddTitleCondition()
        If String.IsNullOrEmpty(txtTitle.Text) Then Exit Sub
        ConcatenateAndOrWhere()
        eSqlWhere = eSqlWhere & "book.Title LIKE @title"
        command.Parameters.AddWithValue("title", "%" + txtTitle.Text + "%")
    End Sub

    Private Sub AddPublishedAfterCondition()
        If txtAfter.Text.Equals("  /  /") Then Exit Sub
        ConcatenateAndOrWhere()
        eSqlWhere = eSqlWhere & "book.PublishingDate > @after"
        command.Parameters.AddWithValue("after", CDate(txtAfter.Text))
    End Sub

    Private Sub AddPublishedBeforeCondition()
        If txtBefore.Text.Equals("  /  /") Then Exit Sub
        ConcatenateAndOrWhere()
        eSqlWhere = eSqlWhere & "book.PublishingDate < @before"
        command.Parameters.AddWithValue("before", CDate(txtBefore.Text))
    End Sub

    Private Sub ConcatenateAndOrWhere()
        If Not (String.IsNullOrEmpty(eSqlWhere)) Then
            eSqlWhere = eSqlWhere & " AND "
        Else
            eSqlSelect = eSqlSelect & " WHERE "
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles Button2.Click
        gridResult.Rows.Clear()
    End Sub
End Class