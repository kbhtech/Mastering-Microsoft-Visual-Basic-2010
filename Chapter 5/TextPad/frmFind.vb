Public Class frmFind
    ' the Replace All button performs case-sensitive searches
    ' If you want it work regardless of case, you should
    ' search for each instance of the search word with the 
    ' IndexOf method (or the InStr() function) and replace it from within your code,
    ' instead of using the Replace method of the String class.
    Private Sub bttnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReplaceAll.Click
        Dim curPos, curSel As Integer
        ' Keep track of the current selection and
        ' restore it after the replacement operation.
        curPos = frmTextPad.txtEditor.SelectionStart
        curSel = frmTextPad.txtEditor.SelectionLength
        frmTextPad.txtEditor.Text = _
                frmTextPad.txtEditor.Text.Replace(searchWord.Text.Trim, replaceWord.Text.Trim)
        ' Replace the original selection
        frmTextPad.txtEditor.SelectionStart = curPos
        frmTextPad.txtEditor.SelectionLength = curSel
    End Sub

    Private Sub bttnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFind.Click
        Dim selStart As Integer
        If chkCase.Checked = True Then
            selStart = frmTextPad.txtEditor.Text.IndexOf(searchWord.Text, StringComparison.Ordinal)
        Else
            selStart = frmTextPad.txtEditor.Text.IndexOf(searchWord.Text, StringComparison.OrdinalIgnoreCase)
        End If
        If selStart = -1 Then
            MsgBox("Can't find word")
            Exit Sub
        End If
        frmTextPad.txtEditor.Select(selStart, searchWord.Text.Length)
        ' if a match was found, enable the Find Next, Replace and Replace All buttons
        bttnFindNext.Enabled = True
        bttnReplace.Enabled = True
        bttnReplaceAll.Enabled = True
        ' make sure that the selected text is visible!
        frmTextPad.txtEditor.ScrollToCaret()
    End Sub

    Private Sub searchWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchWord.TextChanged
        If searchWord.Text.Length > 0 Then
            bttnFind.Enabled = True
            bttnFindNext.Enabled = True
        Else
            bttnFind.Enabled = False
            bttnFindNext.Enabled = False
        End If
        If replaceWord.Text.Length > 0 Then
            bttnReplace.Enabled = True
            bttnReplaceAll.Enabled = True
        Else
            bttnReplace.Enabled = False
            bttnReplaceAll.Enabled = False
        End If

    End Sub

    Private Sub bttnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFindNext.Click
        Dim selStart As Integer
        Dim srchMode As Microsoft.VisualBasic.CompareMethod
        If chkCase.Checked = True Then
            srchMode = Microsoft.VisualBasic.CompareMethod.Binary
        Else
            srchMode = Microsoft.VisualBasic.CompareMethod.Text
        End If
        ' Start searching after the current selection
        ' we're assuming that the current selection is the previously
        ' located word.
        If chkCase.Checked = True Then
            selStart = frmTextPad.txtEditor.Text.IndexOf(searchWord.Text, frmTextPad.txtEditor.SelectionStart + 1, StringComparison.Ordinal)
        Else
            selStart = frmTextPad.txtEditor.Text.IndexOf(searchWord.Text, frmTextPad.txtEditor.SelectionStart + 1, StringComparison.OrdinalIgnoreCase)
        End If
        If selStart = -1 Then
            MsgBox("No more matches")
            Exit Sub
        End If
        frmTextPad.txtEditor.Select(selStart, searchWord.Text.Length)
        frmTextPad.txtEditor.ScrollToCaret()
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' make sure that the buttons are initially disabled
        searchWord_TextChanged(sender, e)
    End Sub

    Private Sub bttnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReplace.Click
        ' replace current selection
        If frmTextPad.txtEditor.SelectedText <> "" Then
            frmTextPad.txtEditor.SelectedText = replaceWord.Text
        End If
        ' and then locate the next instance of the searchword
        bttnFindNext_Click(sender, e)
    End Sub

    Private Sub replaceWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles replaceWord.TextChanged
        If replaceWord.Text.Length > 0 Then
            bttnReplace.Enabled = True
            bttnReplaceAll.Enabled = True
        Else
            bttnReplace.Enabled = False
            bttnReplaceAll.Enabled = False
        End If
    End Sub
End Class