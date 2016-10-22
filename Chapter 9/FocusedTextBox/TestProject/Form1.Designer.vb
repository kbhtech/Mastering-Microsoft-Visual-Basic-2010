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
        Me.FocusedTextBox1 = New FocusedTextBox.FocusedTextBox()
        Me.FocusedTextBox2 = New FocusedTextBox.FocusedTextBox()
        Me.FocusedTextBox3 = New FocusedTextBox.FocusedTextBox()
        Me.SuspendLayout()
        '
        'FocusedTextBox1
        '
        Me.FocusedTextBox1.EnterFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FocusedTextBox1.Location = New System.Drawing.Point(21, 54)
        Me.FocusedTextBox1.Mandatory = True
        Me.FocusedTextBox1.MandatoryColor = System.Drawing.Color.Empty
        Me.FocusedTextBox1.Name = "FocusedTextBox1"
        Me.FocusedTextBox1.Size = New System.Drawing.Size(251, 20)
        Me.FocusedTextBox1.TabIndex = 0
        '
        'FocusedTextBox2
        '
        Me.FocusedTextBox2.EnterFocusColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FocusedTextBox2.Location = New System.Drawing.Point(21, 90)
        Me.FocusedTextBox2.Mandatory = False
        Me.FocusedTextBox2.MandatoryColor = System.Drawing.Color.Empty
        Me.FocusedTextBox2.Name = "FocusedTextBox2"
        Me.FocusedTextBox2.Size = New System.Drawing.Size(251, 20)
        Me.FocusedTextBox2.TabIndex = 1
        '
        'FocusedTextBox3
        '
        Me.FocusedTextBox3.EnterFocusColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FocusedTextBox3.Location = New System.Drawing.Point(21, 128)
        Me.FocusedTextBox3.Mandatory = False
        Me.FocusedTextBox3.MandatoryColor = System.Drawing.Color.Empty
        Me.FocusedTextBox3.Name = "FocusedTextBox3"
        Me.FocusedTextBox3.Size = New System.Drawing.Size(251, 20)
        Me.FocusedTextBox3.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.FocusedTextBox3)
        Me.Controls.Add(Me.FocusedTextBox2)
        Me.Controls.Add(Me.FocusedTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FocusedTextBox1 As FocusedTextBox.FocusedTextBox
    Friend WithEvents FocusedTextBox2 As FocusedTextBox.FocusedTextBox
    Friend WithEvents FocusedTextBox3 As FocusedTextBox.FocusedTextBox




End Class
