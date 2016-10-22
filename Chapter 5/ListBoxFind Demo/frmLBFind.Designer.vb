<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLBFind
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.bttnPopulate = New System.Windows.Forms.Button
        Me.bttnFind = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 13
        '
        'bttnPopulate
        '
        Me.bttnPopulate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPopulate.Location = New System.Drawing.Point(205, 4)
        Me.bttnPopulate.Name = "bttnPopulate"
        Me.bttnPopulate.Size = New System.Drawing.Size(152, 32)
        Me.bttnPopulate.TabIndex = 12
        Me.bttnPopulate.Text = "Populate List"
        '
        'bttnFind
        '
        Me.bttnFind.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnFind.Location = New System.Drawing.Point(205, 44)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(152, 32)
        Me.bttnFind.TabIndex = 11
        Me.bttnFind.Text = "Find Item"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(1, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 256)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 295)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bttnPopulate)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "ListBoxFindDemo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents bttnPopulate As System.Windows.Forms.Button
    Private WithEvents bttnFind As System.Windows.Forms.Button
    Private WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
