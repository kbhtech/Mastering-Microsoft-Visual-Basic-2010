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
        Me.bttnArrayShapes = New System.Windows.Forms.Button()
        Me.bttnShapes = New System.Windows.Forms.Button()
        Me.bttnShapes1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnArrayShapes
        '
        Me.bttnArrayShapes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnArrayShapes.Location = New System.Drawing.Point(14, 50)
        Me.bttnArrayShapes.Name = "bttnArrayShapes"
        Me.bttnArrayShapes.Size = New System.Drawing.Size(232, 32)
        Me.bttnArrayShapes.TabIndex = 6
        Me.bttnArrayShapes.Text = "Set up Array of Shapes"
        '
        'bttnShapes
        '
        Me.bttnShapes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnShapes.Location = New System.Drawing.Point(14, 12)
        Me.bttnShapes.Name = "bttnShapes"
        Me.bttnShapes.Size = New System.Drawing.Size(232, 32)
        Me.bttnShapes.TabIndex = 5
        Me.bttnShapes.Text = "Set up Individual Shapes"
        '
        'bttnShapes1
        '
        Me.bttnShapes1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnShapes1.Location = New System.Drawing.Point(14, 88)
        Me.bttnShapes1.Name = "bttnShapes1"
        Me.bttnShapes1.Size = New System.Drawing.Size(232, 32)
        Me.bttnShapes1.TabIndex = 7
        Me.bttnShapes1.Text = "Set up Shape objects"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 132)
        Me.Controls.Add(Me.bttnShapes1)
        Me.Controls.Add(Me.bttnArrayShapes)
        Me.Controls.Add(Me.bttnShapes)
        Me.Name = "Form1"
        Me.Text = "Shapes Class Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnArrayShapes As System.Windows.Forms.Button
    Friend WithEvents bttnShapes As System.Windows.Forms.Button
    Friend WithEvents bttnShapes1 As System.Windows.Forms.Button


End Class
