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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FixedMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunTimeMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FixedMenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.bttnRemoveItem = New System.Windows.Forms.Button
        Me.bttnAddItem = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FixedMenuToolStripMenuItem, Me.RunTimeMenuToolStripMenuItem, Me.FixedMenuToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FixedMenuToolStripMenuItem
        '
        Me.FixedMenuToolStripMenuItem.Name = "FixedMenuToolStripMenuItem"
        Me.FixedMenuToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FixedMenuToolStripMenuItem.Text = "Fixed Menu"
        '
        'RunTimeMenuToolStripMenuItem
        '
        Me.RunTimeMenuToolStripMenuItem.Name = "RunTimeMenuToolStripMenuItem"
        Me.RunTimeMenuToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.RunTimeMenuToolStripMenuItem.Text = "Run Time Menu"
        '
        'FixedMenuToolStripMenuItem1
        '
        Me.FixedMenuToolStripMenuItem1.Name = "FixedMenuToolStripMenuItem1"
        Me.FixedMenuToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.FixedMenuToolStripMenuItem1.Text = "Fixed Menu"
        '
        'bttnRemoveItem
        '
        Me.bttnRemoveItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRemoveItem.Location = New System.Drawing.Point(294, 86)
        Me.bttnRemoveItem.Name = "bttnRemoveItem"
        Me.bttnRemoveItem.Size = New System.Drawing.Size(168, 32)
        Me.bttnRemoveItem.TabIndex = 6
        Me.bttnRemoveItem.Text = "Remove Menu Item"
        '
        'bttnAddItem
        '
        Me.bttnAddItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddItem.Location = New System.Drawing.Point(294, 38)
        Me.bttnAddItem.Name = "bttnAddItem"
        Me.bttnAddItem.Size = New System.Drawing.Size(168, 32)
        Me.bttnAddItem.TabIndex = 5
        Me.bttnAddItem.Text = "Add Menu Item"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 264)
        Me.Controls.Add(Me.bttnRemoveItem)
        Me.Controls.Add(Me.bttnAddItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Run Time Dynamic Menus"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FixedMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunTimeMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixedMenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bttnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents bttnAddItem As System.Windows.Forms.Button

End Class
