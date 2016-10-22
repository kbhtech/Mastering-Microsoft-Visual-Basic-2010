Public Class frmTextPad

    Private Sub fileNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileNewItem.Click
        txtEditor.Clear()
    End Sub

    Private Sub EditCutItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditCutItem.Click
        Clipboard.SetText(txtEditor.SelectedText)
        txtEditor.SelectedText = ""
    End Sub

    Private Sub EditPasteItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditPasteItem.Click
        If Clipboard.ContainsText Then
            txtEditor.SelectedText = Clipboard.GetText
        End If
    End Sub

    Private Sub EditFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFindItem.Click
        frmFind.Show()
    End Sub

    Private Sub EditCopyItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCopyItem.Click
        If txtEditor.SelectionLength > 0 Then
            Clipboard.SetText(txtEditor.SelectedText)
        End If
    End Sub

    Private Sub ProcessNumberLinesItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessNumberLines.Click
        Dim iLine As Integer
        Dim newText As New System.Text.StringBuilder()
        For iLine = 0 To txtEditor.Lines.Length - 1
            newText.Append((iLine + 1).ToString & vbTab & _
                           txtEditor.Lines(iLine) & vbCrLf)
        Next
        txtEditor.SelectAll()
        Clipboard.SetText(newText.ToString)
        txtEditor.Paste()
    End Sub

    Private Sub ProcessLowerItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessLower.Click
        txtEditor.SelectedText = txtEditor.SelectedText.ToLower
    End Sub

    Private Sub ProcessUpperItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessUpper.Click
        txtEditor.SelectedText = txtEditor.SelectedText.ToUpper
    End Sub

    Private Sub EditUndoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUndoItem.Click
        If EditUndoItem.Text = "Undo" Then
            If txtEditor.CanUndo Then
                txtEditor.Undo()
                EditUndoItem.Text = "Redo"
            End If
        Else
            If txtEditor.CanUndo Then
                txtEditor.Undo()
                EditUndoItem.Text = "Undo"
            End If
        End If
    End Sub

    Private Sub txtEditor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEditor.KeyPress
        Dim ch As Char
        If System.Char.IsControl(e.KeyChar) Then Exit Sub
        ch = Char.ToUpper(e.KeyChar)
        Select Case ch.ToString
            Case "@"
                txtEditor.SelectedText = "AT"
            Case "#"
                txtEditor.SelectedText = "BPT"
            Case "$"
                txtEditor.SelectedText = "DLR"
            Case "%"
                txtEditor.SelectedText = "O/O"
            Case "&"
                txtEditor.SelectedText = "AND"
            Case Else
                txtEditor.SelectedText = ch
        End Select
        e.Handled = True
    End Sub

    Private Sub txtEditor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditor.KeyUp
        Select Case e.KeyCode
            Case Keys.F5 : txtEditor.SelectedText = Now().ToLongDateString
            Case Keys.F6 : txtEditor.SelectedText = Now().ToLongTimeString
            Case Keys.F7 : txtEditor.SelectedText = "MicroWeb Designs, Inc."
            Case Keys.F8 : txtEditor.SelectedText = "Another user-supplied string"
        End Select
    End Sub

    Private Sub txtEditor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEditor.TextChanged
        EditUndoItem.Text = "Undo"
    End Sub

    Private Sub FormatWrap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormatWrap.CheckedChanged
        txtEditor.WordWrap = FormatWrap.Checked
    End Sub

    Private Sub FormatFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatFont.Click
        FontDialog1.ShowApply = True
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEditor.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub FormatTextColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatTextColor.Click
        ColorDialog1.Color = txtEditor.ForeColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEditor.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FormatPageColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatPageColor.Click
        ColorDialog1.Color = txtEditor.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEditor.ForeColor = ColorDialog1.Color
        End If
    End Sub


    Private Sub FontDialog1_Apply(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        txtEditor.Font = FontDialog1.Font
    End Sub
End Class
