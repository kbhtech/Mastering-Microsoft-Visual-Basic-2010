<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColors
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
        Me.lblBlue = New System.Windows.Forms.Label
        Me.lblGreen = New System.Windows.Forms.Label
        Me.lblRed = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.blueBar = New System.Windows.Forms.HScrollBar
        Me.greenBar = New System.Windows.Forms.HScrollBar
        Me.redBar = New System.Windows.Forms.HScrollBar
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBlue
        '
        Me.lblBlue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.ForeColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(2, 219)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(47, 16)
        Me.lblBlue.TabIndex = 22
        Me.lblBlue.Text = "BLUE"
        '
        'lblGreen
        '
        Me.lblGreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.ForeColor = System.Drawing.Color.Green
        Me.lblGreen.Location = New System.Drawing.Point(2, 179)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(61, 16)
        Me.lblGreen.TabIndex = 21
        Me.lblGreen.Text = "GREEN"
        '
        'lblRed
        '
        Me.lblRed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(2, 137)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(40, 16)
        Me.lblRed.TabIndex = 20
        Me.lblRed.Text = "RED"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(209, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(201, 129)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 129)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'blueBar
        '
        Me.blueBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.blueBar.Location = New System.Drawing.Point(2, 235)
        Me.blueBar.Maximum = 255
        Me.blueBar.Name = "blueBar"
        Me.blueBar.Size = New System.Drawing.Size(408, 21)
        Me.blueBar.TabIndex = 17
        Me.blueBar.Value = 128
        '
        'greenBar
        '
        Me.greenBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.greenBar.Location = New System.Drawing.Point(2, 194)
        Me.greenBar.Maximum = 255
        Me.greenBar.Name = "greenBar"
        Me.greenBar.Size = New System.Drawing.Size(408, 21)
        Me.greenBar.TabIndex = 16
        Me.greenBar.Value = 128
        '
        'redBar
        '
        Me.redBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redBar.Location = New System.Drawing.Point(2, 153)
        Me.redBar.Maximum = 255
        Me.redBar.Name = "redBar"
        Me.redBar.Size = New System.Drawing.Size(408, 21)
        Me.redBar.TabIndex = 15
        Me.redBar.Value = 128
        '
        'frmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 265)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.blueBar)
        Me.Controls.Add(Me.greenBar)
        Me.Controls.Add(Me.redBar)
        Me.Name = "frmColors"
        Me.Text = "Colors"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents blueBar As System.Windows.Forms.HScrollBar
    Friend WithEvents greenBar As System.Windows.Forms.HScrollBar
    Friend WithEvents redBar As System.Windows.Forms.HScrollBar

End Class
