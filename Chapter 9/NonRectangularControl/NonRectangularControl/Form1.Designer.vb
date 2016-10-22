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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.bttnClose = New RoundControl.RoundControl
        Me.bttnRecord = New RoundControl.RoundControl
        Me.bttnPlay = New RoundControl.RoundControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.LedBttnRecord = New RoundControl.LEDButton
        Me.LedBttnPlay = New RoundControl.LEDButton
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 75)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.bttnClose)
        Me.Panel6.Controls.Add(Me.bttnRecord)
        Me.Panel6.Controls.Add(Me.bttnPlay)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(649, 71)
        Me.Panel6.TabIndex = 0
        '
        'bttnClose
        '
        Me.bttnClose.Caption = "Close"
        Me.bttnClose.Color = System.Drawing.Color.Red
        Me.bttnClose.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.bttnClose.Location = New System.Drawing.Point(574, 8)
        Me.bttnClose.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(67, 50)
        Me.bttnClose.TabIndex = 6
        '
        'bttnRecord
        '
        Me.bttnRecord.Caption = "Record"
        Me.bttnRecord.Color = System.Drawing.Color.Yellow
        Me.bttnRecord.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.bttnRecord.Location = New System.Drawing.Point(172, 8)
        Me.bttnRecord.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.bttnRecord.Name = "bttnRecord"
        Me.bttnRecord.Size = New System.Drawing.Size(129, 50)
        Me.bttnRecord.TabIndex = 5
        '
        'bttnPlay
        '
        Me.bttnPlay.Caption = "Play"
        Me.bttnPlay.Color = System.Drawing.Color.Yellow
        Me.bttnPlay.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.bttnPlay.Location = New System.Drawing.Point(2, 8)
        Me.bttnPlay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.bttnPlay.Name = "bttnPlay"
        Me.bttnPlay.Size = New System.Drawing.Size(129, 50)
        Me.bttnPlay.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(102, 194)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 98)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(486, 94)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(476, 84)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.LedBttnRecord)
        Me.Panel5.Controls.Add(Me.LedBttnPlay)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(472, 80)
        Me.Panel5.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LedBttnRecord
        '
        Me.LedBttnRecord.BackColor = System.Drawing.Color.Silver
        Me.LedBttnRecord.ButtonState = RoundControl.LEDButton.LEDState.Released
        Me.LedBttnRecord.Caption = "Press to Record"
        Me.LedBttnRecord.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LedBttnRecord.Location = New System.Drawing.Point(242, 4)
        Me.LedBttnRecord.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LedBttnRecord.Name = "LedBttnRecord"
        Me.LedBttnRecord.PressedCaption = "Now Recording..."
        Me.LedBttnRecord.Size = New System.Drawing.Size(217, 36)
        Me.LedBttnRecord.TabIndex = 6
        '
        'LedBttnPlay
        '
        Me.LedBttnPlay.BackColor = System.Drawing.Color.Silver
        Me.LedBttnPlay.ButtonState = RoundControl.LEDButton.LEDState.Released
        Me.LedBttnPlay.Caption = "Press to Play"
        Me.LedBttnPlay.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LedBttnPlay.Location = New System.Drawing.Point(5, 4)
        Me.LedBttnPlay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LedBttnPlay.Name = "LedBttnPlay"
        Me.LedBttnPlay.PressedCaption = "Now Playing..."
        Me.LedBttnPlay.Size = New System.Drawing.Size(217, 36)
        Me.LedBttnPlay.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 315)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Round Button Test Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LedBttnRecord As RoundControl.LEDButton
    Friend WithEvents LedBttnPlay As RoundControl.LEDButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents bttnClose As RoundControl.RoundControl
    Friend WithEvents bttnRecord As RoundControl.RoundControl
    Friend WithEvents bttnPlay As RoundControl.RoundControl

End Class
