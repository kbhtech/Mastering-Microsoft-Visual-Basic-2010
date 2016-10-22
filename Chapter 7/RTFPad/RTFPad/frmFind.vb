Public Class frmFind
    Private Sub txtSearchWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchWord.TextChanged
        If txtSearchWord.Text.Length > 0 Then
            bttnFind.Enabled = True
            bttnFindNext.Enabled = True
        Else
            bttnFind.Enabled = False
            bttnFindNext.Enabled = False
        End If
        If txtReplaceWord.Text.Length > 0 Then
            bttnReplace.Enabled = True
            bttnReplaceAll.Enabled = True
        Else
            bttnReplace.Enabled = False
            bttnReplaceAll.Enabled = False
        End If
    End Sub

    Private Sub bttnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFind.Click
        Dim wordAt As Integer
        Dim srchMode As RichTextBoxFinds
        srchMode = SetSearchMode()
        wordAt = frmEditor.Editor.Find(txtSearchWord.Text, 0, srchMode)
        If wordAt = -1 Then
            MsgBox("Can't find word")
            Exit Sub
        End If
        frmEditor.Editor.Select(wordAt, txtSearchWord.Text.Length)
        bttnFindNext.Enabled = True
        bttnReplace.Enabled = True
        bttnReplaceAll.Enabled = True
        frmEditor.Editor.ScrollToCaret()
    End Sub

    Private Sub bttnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFindNext.Click
        Dim selStart As Integer
        Dim srchMode As RichTextBoxFinds
        srchMode = SetSearchMode()
        selStart = frmEditor.Editor.Find(txtSearchWord.Text, frmEditor.Editor.SelectionStart + 2, srchMode)
        If selStart = -1 Then
            MsgBox("No more matches")
            Exit Sub
        End If
        frmEditor.Editor.Select(selStart, txtSearchWord.Text.Length)
        frmEditor.Editor.ScrollToCaret()
    End Sub

    Private Sub bttnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReplaceAll.Click
        Dim curPos, curSel As Integer
        curPos = frmEditor.Editor.SelectionStart
        curSel = frmEditor.Editor.SelectionLength
        frmEditor.Editor.Text = Replace(frmEditor.Editor.Text, Trim(txtSearchWord.Text), Trim(txtReplaceWord.Text))
        frmEditor.Editor.SelectionStart = curPos
        frmEditor.Editor.SelectionLength = curSel
    End Sub

    Private Sub bttnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReplace.Click
        If frmEditor.Editor.SelectedText <> "" Then
            frmEditor.Editor.SelectedText = txtReplaceWord.Text
        End If
        bttnFindNext_Click(sender, e)
    End Sub

    Function SetSearchMode() As RichTextBoxFinds
        Dim mode As RichTextBoxFinds = RichTextBoxFinds.None
        If chkCase.Checked = True Then
            mode = mode Or RichTextBoxFinds.MatchCase
        End If
        If chkWord.Checked = True Then
            mode = mode Or RichTextBoxFinds.WholeWord
        End If
        Return mode
    End Function
End Class