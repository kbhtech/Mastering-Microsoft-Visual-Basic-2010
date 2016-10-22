<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWords
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
        Me.bttnSort = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.bttnCount = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.bttnRead = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FrequencyTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveBinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadBinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnSort
        '
        Me.bttnSort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSort.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnSort.Location = New System.Drawing.Point(3, 383)
        Me.bttnSort.Name = "bttnSort"
        Me.bttnSort.Size = New System.Drawing.Size(312, 31)
        Me.bttnSort.TabIndex = 11
        Me.bttnSort.Text = "Sort Words by Frequency"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'bttnCount
        '
        Me.bttnCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnCount.Location = New System.Drawing.Point(3, 351)
        Me.bttnCount.Name = "bttnCount"
        Me.bttnCount.Size = New System.Drawing.Size(312, 31)
        Me.bttnCount.TabIndex = 10
        Me.bttnCount.Text = "Show Word Count"
        '
        'bttnRead
        '
        Me.bttnRead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnRead.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnRead.Location = New System.Drawing.Point(3, 319)
        Me.bttnRead.Name = "bttnRead"
        Me.bttnRead.Size = New System.Drawing.Size(312, 31)
        Me.bttnRead.TabIndex = 9
        Me.bttnRead.Text = "Read Text File"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(312, 284)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrequencyTableToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(320, 25)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FrequencyTableToolStripMenuItem
        '
        Me.FrequencyTableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBinaryToolStripMenuItem, Me.SaveXMLToolStripMenuItem, Me.LoadBinaryToolStripMenuItem, Me.LoadXMLToolStripMenuItem})
        Me.FrequencyTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrequencyTableToolStripMenuItem.Name = "FrequencyTableToolStripMenuItem"
        Me.FrequencyTableToolStripMenuItem.Size = New System.Drawing.Size(115, 21)
        Me.FrequencyTableToolStripMenuItem.Text = "Frequency Table"
        '
        'SaveBinaryToolStripMenuItem
        '
        Me.SaveBinaryToolStripMenuItem.Name = "SaveBinaryToolStripMenuItem"
        Me.SaveBinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveBinaryToolStripMenuItem.Text = "Save Binary"
        '
        'SaveXMLToolStripMenuItem
        '
        Me.SaveXMLToolStripMenuItem.Name = "SaveXMLToolStripMenuItem"
        Me.SaveXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveXMLToolStripMenuItem.Text = "Save XML"
        '
        'LoadBinaryToolStripMenuItem
        '
        Me.LoadBinaryToolStripMenuItem.Name = "LoadBinaryToolStripMenuItem"
        Me.LoadBinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadBinaryToolStripMenuItem.Text = "Load Binary"
        '
        'LoadXMLToolStripMenuItem
        '
        Me.LoadXMLToolStripMenuItem.Name = "LoadXMLToolStripMenuItem"
        Me.LoadXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadXMLToolStripMenuItem.Text = "LoadXML"
        '
        'frmWords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 420)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.bttnSort)
        Me.Controls.Add(Me.bttnCount)
        Me.Controls.Add(Me.bttnRead)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWords"
        Me.Text = "Word Frequencies"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bttnSort As System.Windows.Forms.Button
    Private WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents bttnCount As System.Windows.Forms.Button
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents bttnRead As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FrequencyTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveBinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadBinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
