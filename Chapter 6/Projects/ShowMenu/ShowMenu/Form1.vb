Public Class Form1

    Private Sub bttnMapManu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMapManu.Click
        Dim itm As ToolStripMenuItem
        For Each itm In Me.MenuStrip1.Items
            TextBox1.AppendText(itm.Text & vbCrLf)
            PrintSubMenu(itm)
        Next
    End Sub

    Sub PrintSubMenu(ByVal MItem As ToolStripMenuItem)
        Dim itm As New ToolStripMenuItem
        Static level As Integer
        level = level + 1
        Dim i As Integer
        For i = 0 To MItem.DropDownItems.Count - 1
            If MItem.DropDownItems(i).GetType Is _
                         GetType(ToolStripMenuItem) Then
                itm = CType(MItem.DropDownItems(i), ToolStripMenuItem)
                TextBox1.AppendText(Space(level * 5) & itm.Text & vbCrLf)
                If itm.DropDownItems.Count > 0 Then PrintSubMenu(itm)
            End If
        Next
        level = level - 1
    End Sub

    Private Sub FileToolStripMenuItem_DropDownOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.DropDownOpened
        FileToolStripMenuItem.DropDownItems.Add("NEW")
    End Sub
End Class
