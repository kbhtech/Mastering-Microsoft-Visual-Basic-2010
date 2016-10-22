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
        Me.bttnSearch = New System.Windows.Forms.Button
        Me.bttnPopulate = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(209, 58)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(120, 40)
        Me.bttnSearch.TabIndex = 5
        Me.bttnSearch.Text = "Search Array"
        '
        'bttnPopulate
        '
        Me.bttnPopulate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnPopulate.Location = New System.Drawing.Point(209, 2)
        Me.bttnPopulate.Name = "bttnPopulate"
        Me.bttnPopulate.Size = New System.Drawing.Size(120, 40)
        Me.bttnPopulate.TabIndex = 4
        Me.bttnPopulate.Text = "Populate Array"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(1, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 312)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 316)
        Me.Controls.Add(Me.bttnSearch)
        Me.Controls.Add(Me.bttnPopulate)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Array Search"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnSearch As System.Windows.Forms.Button
    Friend WithEvents bttnPopulate As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
