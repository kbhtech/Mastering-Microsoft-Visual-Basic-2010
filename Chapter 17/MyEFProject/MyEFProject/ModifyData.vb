Imports System.Transactions

Public Class ModifyData

    Private Sub InsertNewLanguage_Click(ByVal sender As System.Object,
                                    ByVal e As System.EventArgs) Handles
                                    InsertNewLanguage.Click
        Dim context As New BooksAndAuthorsContainer
        Dim arabic As New Language
        arabic.Name = "Arabic"
        context.Languages.AddObject(arabic)
        context.SaveChanges()
    End Sub

    Private Sub DeleteLanguage_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles
                                     DeleteLanguage.Click
        Dim context As New BooksAndAuthorsContainer
        Dim arabic As Language = (From language In context.Languages
                                 Where language.Name = "Arabic").
                                 FirstOrDefault()
        context.DeleteObject(arabic)
        context.SaveChanges()
    End Sub

    Private Sub UpdateLanguage_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles
                                     UpdateLanguage.Click
        Dim context As New BooksAndAuthorsContainer
        Dim arabic As Language = (From language In context.Languages
                                 Where language.Name = "Arabic").
                                 FirstOrDefault()
        arabic.Name = "Arabic Language"
        context.SaveChanges()
    End Sub

    Private Sub InsertsInTransaction_Click(ByVal sender As System.Object,
                                           ByVal e As System.EventArgs) Handles
                                           InsertsInTransaction.Click
        Dim context As New BooksAndAuthorsContainer

        Dim book As New Book With {.ISBN = "9780470179796",
                    .Title = "Professional Refactoring in Visual Basic",
                    .PageCount = "517", .PublishingDate = "April 7, 2008"}

        Dim author As New Author With {.SSN = "423235332",
                    .FirstName = "Danijel",
                    .LastName = "Arsenovski",
                    .Phone = New PhoneNumber With {.CountryCode = "56",
                        .AreaCode = "2", .Number = "8588656", .Extension = " "},
                    .Signed = "January 1, 2007"}

        context.Persons.AddObject(author)
        context.Books.AddObject(book)
        author.Books.Add(book)
        context.SaveChanges()
    End Sub

    Private Sub ExternalOperationTransaction_Click(ByVal sender As System.Object,
                                                   ByVal e As System.EventArgs) Handles
                                                   ExternalOperationTransaction.Click

        Dim context As New BooksAndAuthorsContainer

        Dim book As New Book With {.ISBN = "9780470179796",
                    .Title = "Professional Refactoring in Visual Basic",
                    .PageCount = "517", .PublishingDate = "April 7, 2008"}

        Dim author As New Author With {.SSN = "423235332",
                    .FirstName = "Danijel",
                    .LastName = "Arsenovski",
                    .Phone = New PhoneNumber With {.CountryCode = "56",
                        .AreaCode = "2", .Number = "8588656", .Extension = " "},
                    .Signed = "January 1, 2007"}

        Using transaction As New TransactionScope()
            context.Persons.AddObject(author)
            context.Books.AddObject(book)
            author.Books.Add(book)
            context.SaveChanges()
            'Do some external operation that can be enroled inside the transaction
            transaction.Complete()
        End Using
    End Sub
End Class

