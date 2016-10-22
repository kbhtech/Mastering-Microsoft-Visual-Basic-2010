Public Class Form1

    ' Can't change the Visible property from within a menu item's
    ' Click event handller, because at that point the item is visible.
    ' Use the DropDownItemClicked event instead. If this isn't a bug,
    ' it's a very odd behavior.

    Private Sub FormatToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles FormatToolStripMenuItem.DropDownItemClicked
        If mnuSize.Text = "Short Menu" Then
            mnuSize.Text = "Long Menu"
        Else
            mnuSize.Text = "Short Menu"
        End If
        mnuUnderline.Visible = Not mnuUnderline.Visible
        mnuStrike.Visible = Not mnuStrike.Visible
        mnuSmallCaps.Visible = Not mnuSmallCaps.Visible
        mnuAllCaps.Visible = Not mnuAllCaps.Visible
    End Sub
End Class
