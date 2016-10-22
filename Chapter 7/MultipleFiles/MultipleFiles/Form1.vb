Public Class Form1

    Private Sub bttnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFile.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()
        Dim filesEnum As IEnumerator
        ListBox1.Items.Clear()
        filesEnum = OpenFileDialog1.FileNames.GetEnumerator()
        While filesEnum.MoveNext
            ListBox1.Items.Add(filesEnum.Current)
        End While
    End Sub

End Class
