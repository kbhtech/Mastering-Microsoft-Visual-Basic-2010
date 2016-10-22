Public Class frmPrintout

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Failed to print document." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Turn on antialias for text
        e.Graphics.TextRenderingHint = _
                         Drawing.Text.TextRenderingHint.AntiAlias
        ' Print a string at the origin
        Dim pFont As Font
        pFont = New Font("Comic Sans MS", 20)
        e.Graphics.DrawString("ORIGIN", pFont, Brushes.Black, 0, 0)

        ' Read margins into local variables
        Dim Lmargin, Rmargin, Tmargin, BMargin As Integer
        With PrintDocument1.DefaultPageSettings.Margins
            Lmargin = .Left
            Rmargin = .Right
            Tmargin = .Top
            BMargin = .Bottom
        End With

        ' Calculate the dimensions of the printable area
        Dim PrintWidth, PrintHeight As Integer
        With PrintDocument1.DefaultPageSettings.PaperSize
            PrintWidth = .Width - Lmargin - Rmargin
            PrintHeight = .Height - Tmargin - BMargin
        End With

        ' Now print the rectangle
        Dim R As Rectangle
        R = New Rectangle(Lmargin, Tmargin, PrintWidth, PrintHeight)
        e.Graphics.DrawRectangle(Pens.Black, R)
    End Sub
End Class
