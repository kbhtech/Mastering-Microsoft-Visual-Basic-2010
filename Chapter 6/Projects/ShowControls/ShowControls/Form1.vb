Public Class Form1

    Private Sub bttnShowControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShowControls.Click
        Dim i As Integer
        For i = 0 To Me.Controls.Count - 1
            auxForm.RichTextBox1.AppendText(Me.Controls(i).Name & ":  " & Me.Controls(i).ToString & vbCrLf)
            If Me.Controls(i).GetType Is GetType(System.Windows.Forms.Panel) Then
                Dim j As Integer
                For j = 0 To Me.Controls(i).Controls.Count - 1
                    '' Debug.WriteLine("    " & Me.Controls(i).Controls(j).Name & ":  " & Me.Controls(i).Controls(j).ToString)
                    auxForm.RichTextBox1.AppendText("    " & Me.Controls(i).Controls(j).Name & ":  " & Me.Controls(i).Controls(j).ToString & vbCrLf)
                Next
            End If
        Next
        auxForm.ShowDialog()
    End Sub
End Class
