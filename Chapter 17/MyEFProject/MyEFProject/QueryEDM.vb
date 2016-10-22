Imports System.Data.Objects
Imports System.Data.EntityClient


Public Class QueryEDM

    Private Sub LongestBook_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles LongestBook.Click
        Dim context As New BooksAndAuthorsContainer
        Dim books = context.Books
        Dim longestBook As Book = (From book In books
                        Order By book.PageCount).First
        Console.WriteLine("The longest book is: " +
        longestBook.ISBN + " " + longestBook.Title)
    End Sub

    Private Sub ListAllBooks_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles ListAllBooks.Click
        Dim context As New BooksAndAuthorsContainer
        For Each book In context.Books
            Console.WriteLine("Title: " & book.Title)
        Next
    End Sub

    Private Sub FetchTranslators_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles FetchTranslators.Click
        Dim context As New BooksAndAuthorsContainer
        Dim translators = context.Persons.OfType(Of Translator)()
        For Each Translator In translators
            Console.WriteLine("Translator: " & Translator.FirstName &
                              " " & Translator.LastName)
        Next
    End Sub

    Private Sub FindBookByISBN_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles FindBookByISBN.Click
        Using connection As New EntityConnection("Name=BooksAndAuthorsContainer")
            connection.Open()
            Dim command = connection.CreateCommand()
            command.CommandText = "SELECT VALUE book FROM BooksAndAuthorsContainer.Books " &
                                    "As book WHERE book.ISBN = @isbn"
            command.Parameters.AddWithValue("isbn", "9780470187425")
            Dim reader = command.ExecuteReader(CommandBehavior.SequentialAccess)
            reader.Read()
            Console.WriteLine("Book title is: " & reader("Title"))
        End Using
    End Sub

    Private Sub launchFinder_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles launchFinder.Click
        eSQLDynamicQuery.Show()
    End Sub

    Private Sub QueryBuilder_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles QueryBuilder.Click
        Dim context As New BooksAndAuthorsContainer
        Dim query As ObjectQuery(Of Book)
        query = context.Books.
            Where("it.PublishingDate > DATETIME'1999-01-01 00:00'").
            OrderBy("it.PublishingDate").
            Top(10)
        Console.WriteLine(query.ToTraceString())
        For Each book As Book In query.ToList()
            Console.WriteLine(book.Title)
        Next
    End Sub

    Private Sub DefferedLoading_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles
                                      DefferedLoading.Click
        Dim context As New BooksAndAuthorsContainer
        context.ContextOptions.DeferredLoadingEnabled = True
        Dim author = context.Persons.OfType(Of Author).First()
        For Each book As Book In author.Books
            Console.WriteLine(book.Title)
        Next
    End Sub

    Private Sub ModificationForm_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles
                                       ModificationForm.Click
        ModifyData.Show()
    End Sub

    Private Sub SalesByMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesByMonth.Click
        SaleByMonthForm.Show()
    End Sub
End Class