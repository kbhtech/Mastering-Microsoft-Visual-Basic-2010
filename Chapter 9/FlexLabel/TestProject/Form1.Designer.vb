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
        Me.Label3D1 = New FlexLabel.Label3D()
        Me.SuspendLayout()
        '
        'Label3D1
        '
        Me.Label3D1.Alignment = FlexLabel.Label3D.Align.CenterMiddle
        Me.Label3D1.Caption = "Label 3D"
        Me.Label3D1.Effect = FlexLabel.Label3D.Effect3D.Raised
        Me.Label3D1.Font = New System.Drawing.Font("MingLiU", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3D1.Location = New System.Drawing.Point(26, 16)
        Me.Label3D1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Label3D1.Name = "Label3D1"
        Me.Label3D1.Size = New System.Drawing.Size(232, 159)
        Me.Label3D1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.Label3D1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3D1 As FlexLabel.Label3D

End Class
