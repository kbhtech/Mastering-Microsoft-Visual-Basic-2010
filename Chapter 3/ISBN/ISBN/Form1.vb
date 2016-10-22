Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("The check digit is " & ISBNCheckDigit(TextBox1.Text))
    End Sub

    Function ISBNCheckDigit(ByVal ISBN As String) As String
        Dim i As Integer, chksum As Integer = 0
        Dim factor As Integer = 3
        For i = 0 To 11
            factor = 4 - factor
            chksum += factor * Convert.ToInt16(ISBN.Substring(i, 1))
        Next
        Return (((10 - (chksum Mod 10)) Mod 10)).ToString

    End Function
End Class
