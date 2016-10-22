<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextPad
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
        Me.ProcessLower = New System.Windows.Forms.ToolStripMenuItem
        Me.txtEditor = New System.Windows.Forms.TextBox
        Me.menuProcess = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessUpper = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ProcessNumberLines = New System.Windows.Forms.ToolStripMenuItem
        Me.EditSelectAllItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditFindItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.FormatWrap = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatPageColor = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.menuFormat = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatFont = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatTextColor = New System.Windows.Forms.ToolStripMenuItem
        Me.EditPasteItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCutItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.EditCopyItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileOpenItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileSaveItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.FileNewItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.EditUndoItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessLower
        '
        Me.ProcessLower.Name = "ProcessLower"
        Me.ProcessLower.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ProcessLower.Size = New System.Drawing.Size(230, 22)
        Me.ProcessLower.Text = "Convert to Lower"
        '
        'txtEditor
        '
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditor.HideSelection = False
        Me.txtEditor.Location = New System.Drawing.Point(0, 24)
        Me.txtEditor.MaxLength = 0
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditor.Size = New System.Drawing.Size(488, 321)
        Me.txtEditor.TabIndex = 2
        '
        'menuProcess
        '
        Me.menuProcess.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessLower, Me.ProcessUpper, Me.ToolStripSeparator5, Me.ProcessNumberLines})
        Me.menuProcess.Name = "menuProcess"
        Me.menuProcess.Size = New System.Drawing.Size(68, 20)
        Me.menuProcess.Text = "Process"
        '
        'ProcessUpper
        '
        Me.ProcessUpper.Name = "ProcessUpper"
        Me.ProcessUpper.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ProcessUpper.Size = New System.Drawing.Size(230, 22)
        Me.ProcessUpper.Text = "Convert to Upper"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(227, 6)
        '
        'ProcessNumberLines
        '
        Me.ProcessNumberLines.Name = "ProcessNumberLines"
        Me.ProcessNumberLines.Size = New System.Drawing.Size(230, 22)
        Me.ProcessNumberLines.Text = "Number Lines"
        '
        'EditSelectAllItem
        '
        Me.EditSelectAllItem.Name = "EditSelectAllItem"
        Me.EditSelectAllItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.EditSelectAllItem.Size = New System.Drawing.Size(211, 22)
        Me.EditSelectAllItem.Text = "Select All"
        '
        'EditFindItem
        '
        Me.EditFindItem.Name = "EditFindItem"
        Me.EditFindItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.EditFindItem.Size = New System.Drawing.Size(211, 22)
        Me.EditFindItem.Text = "Find && Replace"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(208, 6)
        '
        'FormatWrap
        '
        Me.FormatWrap.Checked = True
        Me.FormatWrap.CheckOnClick = True
        Me.FormatWrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FormatWrap.Name = "FormatWrap"
        Me.FormatWrap.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FormatWrap.Size = New System.Drawing.Size(190, 22)
        Me.FormatWrap.Text = "Wrap Text"
        Me.FormatWrap.ToolTipText = "Wraps words that exceed the width of the window at word boundaries"
        '
        'FormatPageColor
        '
        Me.FormatPageColor.Name = "FormatPageColor"
        Me.FormatPageColor.Size = New System.Drawing.Size(190, 22)
        Me.FormatPageColor.Text = "Pa&ge Color"
        '
        'menuFormat
        '
        Me.menuFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormatFont, Me.FormatTextColor, Me.FormatPageColor, Me.FormatWrap})
        Me.menuFormat.Name = "menuFormat"
        Me.menuFormat.Size = New System.Drawing.Size(63, 20)
        Me.menuFormat.Text = "Format"
        '
        'FormatFont
        '
        Me.FormatFont.Name = "FormatFont"
        Me.FormatFont.Size = New System.Drawing.Size(190, 22)
        Me.FormatFont.Text = "&Font"
        '
        'FormatTextColor
        '
        Me.FormatTextColor.Name = "FormatTextColor"
        Me.FormatTextColor.Size = New System.Drawing.Size(190, 22)
        Me.FormatTextColor.Text = "&Text Color"
        '
        'EditPasteItem
        '
        Me.EditPasteItem.Name = "EditPasteItem"
        Me.EditPasteItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EditPasteItem.Size = New System.Drawing.Size(211, 22)
        Me.EditPasteItem.Text = "Paste"
        '
        'EditCutItem
        '
        Me.EditCutItem.Name = "EditCutItem"
        Me.EditCutItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EditCutItem.Size = New System.Drawing.Size(211, 22)
        Me.EditCutItem.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'EditCopyItem
        '
        Me.EditCopyItem.Name = "EditCopyItem"
        Me.EditCopyItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.EditCopyItem.Size = New System.Drawing.Size(211, 22)
        Me.EditCopyItem.Text = "Copy"
        '
        'FileOpenItem
        '
        Me.FileOpenItem.Name = "FileOpenItem"
        Me.FileOpenItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FileOpenItem.Size = New System.Drawing.Size(156, 22)
        Me.FileOpenItem.Text = "Open"
        '
        'FileSaveItem
        '
        Me.FileSaveItem.Name = "FileSaveItem"
        Me.FileSaveItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.FileSaveItem.Size = New System.Drawing.Size(156, 22)
        Me.FileSaveItem.Text = "Save"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuEdit, Me.menuProcess, Me.menuFormat})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(488, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewItem, Me.FileOpenItem, Me.ToolStripSeparator1, Me.FileSaveItem})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(40, 20)
        Me.menuFile.Text = "File"
        '
        'FileNewItem
        '
        Me.FileNewItem.Name = "FileNewItem"
        Me.FileNewItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.FileNewItem.Size = New System.Drawing.Size(156, 22)
        Me.FileNewItem.Text = "New"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditUndoItem, Me.ToolStripSeparator2, Me.EditCopyItem, Me.EditCutItem, Me.EditPasteItem, Me.EditSelectAllItem, Me.ToolStripSeparator4, Me.EditFindItem})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(43, 20)
        Me.menuEdit.Text = "Edit"
        '
        'EditUndoItem
        '
        Me.EditUndoItem.Name = "EditUndoItem"
        Me.EditUndoItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.EditUndoItem.Size = New System.Drawing.Size(211, 22)
        Me.EditUndoItem.Text = "Undo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        'frmTextPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 345)
        Me.Controls.Add(Me.txtEditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmTextPad"
        Me.Text = "TextPad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProcessLower As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEditor As System.Windows.Forms.TextBox
    Friend WithEvents menuProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessUpper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProcessNumberLines As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditSelectAllItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditFindItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatWrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatPageColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents menuFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatTextColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPasteItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCutItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditCopyItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileOpenItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileSaveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents EditUndoItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileNewItem As System.Windows.Forms.ToolStripMenuItem

End Class
