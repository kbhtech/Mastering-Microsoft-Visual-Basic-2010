<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FrmatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Editor = New System.Windows.Forms.RichTextBox
        Me.TrackBar2 = New System.Windows.Forms.TrackBar
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowApply = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FrmatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(828, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.PreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator3, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator4, Me.FindToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FrmatToolStripMenuItem
        '
        Me.FrmatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlignToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FrmatToolStripMenuItem.Name = "FrmatToolStripMenuItem"
        Me.FrmatToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.FrmatToolStripMenuItem.Text = "Format"
        '
        'AlignToolStripMenuItem
        '
        Me.AlignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftToolStripMenuItem, Me.RightToolStripMenuItem, Me.CenterToolStripMenuItem})
        Me.AlignToolStripMenuItem.Name = "AlignToolStripMenuItem"
        Me.AlignToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlignToolStripMenuItem.Text = "Align"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'Editor
        '
        Me.Editor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Editor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editor.HideSelection = False
        Me.Editor.Location = New System.Drawing.Point(12, 75)
        Me.Editor.Name = "Editor"
        Me.Editor.RightMargin = 700
        Me.Editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.Editor.Size = New System.Drawing.Size(810, 459)
        Me.Editor.TabIndex = 5
        Me.Editor.Text = ""
        '
        'TrackBar2
        '
        Me.TrackBar2.LargeChange = 2
        Me.TrackBar2.Location = New System.Drawing.Point(0, 46)
        Me.TrackBar2.Maximum = 16
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(816, 45)
        Me.TrackBar2.TabIndex = 4
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(0, 24)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.TrackBar1.Maximum = 16
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(816, 45)
        Me.TrackBar1.TabIndex = 3
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PreviewToolStripMenuItem
        '
        Me.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem"
        Me.PreviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreviewToolStripMenuItem.Text = "PrintPreview"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 538)
        Me.Controls.Add(Me.Editor)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximumSize = New System.Drawing.Size(844, 574)
        Me.MinimumSize = New System.Drawing.Size(844, 574)
        Me.Name = "frmEditor"
        Me.Text = "RTFPad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents Editor As System.Windows.Forms.RichTextBox
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
