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
        Me.UserControl11 = New ColorEdit.UserControl1
        Me.SuspendLayout()
        '
        'UserControl11
        '
        Me.UserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl11.Location = New System.Drawing.Point(0, 0)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl11.Size = New System.Drawing.Size(383, 151)
        Me.UserControl11.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 151)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "ColorEdit Test Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserControl11 As ColorEdit.UserControl1

End Class
