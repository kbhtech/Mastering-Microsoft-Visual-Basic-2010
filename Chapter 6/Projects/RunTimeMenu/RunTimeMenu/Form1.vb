Public Class Form1

    Private Sub OptionClick(ByVal sender As Object, _
                    ByVal e As EventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        MsgBox("You have selected the item " & _
                           itemClicked.Text)
    End Sub

    Private Sub bttnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddItem.Click
        Dim Item As New ToolStripMenuItem
        Item.Text = "Run Time Option" & RunTimeMenuToolStripMenuItem.DropDownItems.Count.ToString
        RunTimeMenuToolStripMenuItem.DropDownItems.Add(Item)
        AddHandler Item.Click, New System.EventHandler(AddressOf OptionClick)
    End Sub

    Private Sub bttnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRemoveItem.Click
        If RunTimeMenuToolStripMenuItem.DropDownItems.Count > 0 Then
            Dim mItem As ToolStripItem
            Dim items As Integer = RunTimeMenuToolStripMenuItem.DropDownItems.Count
            mItem = RunTimeMenuToolStripMenuItem.DropDownItems(items - 1)
            RunTimeMenuToolStripMenuItem.DropDownItems.Remove(mItem)
            ' TO REMOVE A MENU ITEM OTHER THAN THE LAST ONE,
            ' USE THE FOLLOWING STATEMENT:
            '
            ' RunTimeMenuToolStripMenuItem.DropDownItems.RemoveAt(position)
            '
            ' WHERE position IS THE INDEX OF THE ITEM TO BE
            ' REMOVED IN THE DROP DOWN MENU
        End If
    End Sub

    Private Sub RunTimeMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunTimeMenuToolStripMenuItem.Click

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
