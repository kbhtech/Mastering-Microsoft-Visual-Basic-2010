<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolders
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
        Me.bttnSelectFiles = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'bttnSelectFiles
        '
        Me.bttnSelectFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSelectFiles.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnSelectFiles.Location = New System.Drawing.Point(2, 3)
        Me.bttnSelectFiles.Name = "bttnSelectFiles"
        Me.bttnSelectFiles.Size = New System.Drawing.Size(406, 52)
        Me.bttnSelectFiles.TabIndex = 2
        Me.bttnSelectFiles.Text = "Show Files in Folder"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.SeaShell
        Me.RichTextBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 60)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(406, 263)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmFolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 326)
        Me.Controls.Add(Me.bttnSelectFiles)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "frmFolders"
        Me.Text = "Folder Browsing Demo"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents bttnSelectFiles As System.Windows.Forms.Button
    Private WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
