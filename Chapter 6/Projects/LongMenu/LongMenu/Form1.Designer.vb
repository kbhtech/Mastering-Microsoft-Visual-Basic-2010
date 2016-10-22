<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBold = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuItalic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRegular = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUnderline = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuStrike = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSmallCaps = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAllCaps = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSize = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ClearTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MainMenu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(273, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFont, Me.mnuBold, Me.mnuItalic, Me.mnuRegular, Me.mnuUnderline, Me.mnuStrike, Me.mnuSmallCaps, Me.mnuAllCaps, Me.ToolStripMenuItem2, Me.mnuSize})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'mnuFont
        '
        Me.mnuFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(136, 22)
        Me.mnuFont.Text = "Font"
        '
        'mnuBold
        '
        Me.mnuBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuBold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuBold.Name = "mnuBold"
        Me.mnuBold.Size = New System.Drawing.Size(136, 22)
        Me.mnuBold.Text = "Bold"
        '
        'mnuItalic
        '
        Me.mnuItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuItalic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.mnuItalic.Name = "mnuItalic"
        Me.mnuItalic.Size = New System.Drawing.Size(136, 22)
        Me.mnuItalic.Text = "Italic"
        '
        'mnuRegular
        '
        Me.mnuRegular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuRegular.Name = "mnuRegular"
        Me.mnuRegular.Size = New System.Drawing.Size(136, 22)
        Me.mnuRegular.Text = "Regular"
        '
        'mnuUnderline
        '
        Me.mnuUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuUnderline.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.mnuUnderline.Name = "mnuUnderline"
        Me.mnuUnderline.Size = New System.Drawing.Size(136, 22)
        Me.mnuUnderline.Text = "Underline"
        '
        'mnuStrike
        '
        Me.mnuStrike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuStrike.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Strikeout)
        Me.mnuStrike.Name = "mnuStrike"
        Me.mnuStrike.Size = New System.Drawing.Size(136, 22)
        Me.mnuStrike.Text = "Strike"
        '
        'mnuSmallCaps
        '
        Me.mnuSmallCaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSmallCaps.Name = "mnuSmallCaps"
        Me.mnuSmallCaps.Size = New System.Drawing.Size(136, 22)
        Me.mnuSmallCaps.Text = "Small Caps"
        '
        'mnuAllCaps
        '
        Me.mnuAllCaps.AutoSize = False
        Me.mnuAllCaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuAllCaps.Name = "mnuAllCaps"
        Me.mnuAllCaps.Size = New System.Drawing.Size(152, 22)
        Me.mnuAllCaps.Text = "ALL CAPS"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'mnuSize
        '
        Me.mnuSize.AutoSize = False
        Me.mnuSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSize.Name = "mnuSize"
        Me.mnuSize.Size = New System.Drawing.Size(152, 22)
        Me.mnuSize.Text = "Short Menu"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem3, Me.ClearTextToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 120)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(123, 6)
        '
        'ClearTextToolStripMenuItem
        '
        Me.ClearTextToolStripMenuItem.Name = "ClearTextToolStripMenuItem"
        Me.ClearTextToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ClearTextToolStripMenuItem.Text = "Clear Text"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 236)
        Me.TextBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 264)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.TextBox1)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "Form1"
        Me.Text = "Simple Editor"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItalic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUnderline As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStrike As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSmallCaps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAllCaps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
