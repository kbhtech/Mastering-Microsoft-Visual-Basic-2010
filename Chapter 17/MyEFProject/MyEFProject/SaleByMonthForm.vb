Public Class SaleByMonthForm

    Private Sub Display_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles
                              Display.Click
        Dim context As New BooksAndAuthorsContainer
        Dim books = context.Books.Include("Sales")
        For Each book As Book In books
            For Each saleByMonth In book.Sales
                gridResult.Rows.Add(New String() {
                    book.ISBN, book.Title,
                    saleByMonth.Month.ToString & saleByMonth.Year.ToString(),
                    saleByMonth.CopiesSold.ToString()})
            Next
        Next
    End Sub
End Class