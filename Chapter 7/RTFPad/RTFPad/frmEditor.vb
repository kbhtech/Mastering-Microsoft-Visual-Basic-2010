Public Class frmEditor

    Dim fName As String

    Private Sub Editor_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles Editor.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub Editor_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editor.SelectionChanged
        If Editor.SelectionIndent = Nothing Then
            TrackBar1.Value = TrackBar1.Minimum
            TrackBar2.Value = TrackBar2.Minimum
        Else
            TrackBar1.Value = Convert.ToInt32(Editor.SelectionIndent * TrackBar1.Maximum / Editor.Width)
            TrackBar2.Value = Convert.ToInt32((Editor.SelectionHangingIndent / Editor.Width) * TrackBar2.Maximum + TrackBar1.Value)
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Editor.SelectionIndent = Convert.ToInt32(Editor.Width * (TrackBar1.Value / TrackBar1.Maximum))
        Editor.SelectionHangingIndent = Convert.ToInt32(Editor.Width * (TrackBar2.Value / TrackBar2.Maximum) - Editor.SelectionIndent)
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        Editor.SelectionHangingIndent = Convert.ToInt32(Editor.Width * (TrackBar2.Value / TrackBar2.Maximum) - Editor.SelectionIndent)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If DiscardChanges() Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Function DiscardChanges() As Boolean
        If Editor.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("Text hasn't been saved. Discard changes?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.No Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function


    Private Sub FontDialog1_Apply(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        Editor.SelectionFont = FontDialog1.Font
        Editor.SelectionColor = FontDialog1.Color
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If DiscardChanges() Then Editor.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If DiscardChanges() Then
            OpenFileDialog1.Filter = "RTF Files|*.RTF|DOC Files|*.DOC|Text Files|*.TXT|All Files|*.*"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                fName = OpenFileDialog1.FileName
                Editor.LoadFile(fName)
                Editor.Modified = False
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If fName <> "" Then
            Editor.SaveFile(fName)
            Editor.Modified = False
        Else
            SaveAsToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "RTF Files|*.RTF|DOC Files|*.DOC|Text Files|*.TXT|All Files|*.*"
        SaveFileDialog1.DefaultExt = "RTF"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            fName = SaveFileDialog1.FileName
            Editor.SaveFile(fName)
            Editor.Modified = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If DiscardChanges() Then End
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        If Editor.CanRedo Then Editor().Redo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        If Editor.CanUndo Then Editor.Undo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Editor.SelectAll()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Editor.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            Editor.Paste()
        Catch exc As Exception
            MsgBox("Can't paste current clipboard's contents")
        End Try
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If Not Editor.SelectionFont Is Nothing Then
            FontDialog1.Font = Editor.SelectionFont
        Else
            FontDialog1.Font = Nothing
        End If
        FontDialog1.ShowApply = True
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Editor.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        Editor.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        Editor.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        Editor.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        frmFind.Show()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Editor.Copy()
    End Sub

    Private Sub EditToolStripMenuItem_DropDownOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.DropDownOpened
        If Editor.CanUndo Then
            UndoToolStripMenuItem.Text = "Undo " & Editor.UndoActionName
            UndoToolStripMenuItem.Enabled = True
        Else
            UndoToolStripMenuItem.Text = "Undo"
            UndoToolStripMenuItem.Enabled = False
        End If
        If Editor.CanRedo Then
            RedoToolStripMenuItem.Text = "Redo " & Editor.RedoActionName
            RedoToolStripMenuItem.Enabled = True
        Else
            RedoToolStripMenuItem.Text = "Redo"
            RedoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub frmEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TitleFont As New Font("Lucida Sans", 12, FontStyle.Bold)
        Dim ItemFont As New Font("Lucida Sans", 10, FontStyle.Bold)
        Dim textFont As New Font("Lucida Sans", 9, FontStyle.Regular)
        Editor.SelectionFont = TitleFont
        Editor.AppendText("Document's Title" & vbCrLf)
        Editor.SelectionFont = ItemFont
        Editor.SelectionIndent = 20
        Editor.AppendText("Item 1" & vbCrLf)
        Editor.SelectionFont = textFont
        Editor.SelectionIndent = 40
        Editor.AppendText("Description for item 1" & vbCrLf)
        Editor.SelectionFont = ItemFont
        Editor.SelectionIndent = 20
        Editor.AppendText("Item 2" & vbCrLf)
        Editor.SelectionFont = textFont
        Editor.SelectionIndent = 40
        Editor.AppendText("Description for item 2" & vbCrLf)
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub
End Class

