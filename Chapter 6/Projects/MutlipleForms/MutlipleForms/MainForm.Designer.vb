<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.bttnAuxiliary = New System.Windows.Forms.Button
        Me.bttnAge = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(16, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 27)
        Me.TextBox1.TabIndex = 5
        '
        'bttnAuxiliary
        '
        Me.bttnAuxiliary.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAuxiliary.Location = New System.Drawing.Point(16, 174)
        Me.bttnAuxiliary.Name = "bttnAuxiliary"
        Me.bttnAuxiliary.Size = New System.Drawing.Size(253, 77)
        Me.bttnAuxiliary.TabIndex = 4
        Me.bttnAuxiliary.Text = "Show Auxiliary Form"
        '
        'bttnAge
        '
        Me.bttnAge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAge.Location = New System.Drawing.Point(16, 78)
        Me.bttnAge.Name = "bttnAge"
        Me.bttnAge.Size = New System.Drawing.Size(253, 77)
        Me.bttnAge.TabIndex = 3
        Me.bttnAge.Text = "Show Dialog Box"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bttnAuxiliary)
        Me.Controls.Add(Me.bttnAge)
        Me.Name = "Form1"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bttnAuxiliary As System.Windows.Forms.Button
    Friend WithEvents bttnAge As System.Windows.Forms.Button

End Class
