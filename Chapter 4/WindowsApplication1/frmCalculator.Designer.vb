<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.bttnEquals = New System.Windows.Forms.Button
        Me.bttnNegate = New System.Windows.Forms.Button
        Me.bttnReverse = New System.Windows.Forms.Button
        Me.bttnDivide = New System.Windows.Forms.Button
        Me.bttnMultiply = New System.Windows.Forms.Button
        Me.bttnMinus = New System.Windows.Forms.Button
        Me.bttnPlus = New System.Windows.Forms.Button
        Me.bttnClear = New System.Windows.Forms.Button
        Me.bttnPeriod = New System.Windows.Forms.Button
        Me.bttn0 = New System.Windows.Forms.Button
        Me.bttn9 = New System.Windows.Forms.Button
        Me.bttn8 = New System.Windows.Forms.Button
        Me.bttn7 = New System.Windows.Forms.Button
        Me.bttn6 = New System.Windows.Forms.Button
        Me.bttn5 = New System.Windows.Forms.Button
        Me.bttn4 = New System.Windows.Forms.Button
        Me.bttn3 = New System.Windows.Forms.Button
        Me.bttn2 = New System.Windows.Forms.Button
        Me.bttn1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Green
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(6, 8)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(205, 22)
        Me.lblDisplay.TabIndex = 40
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttnEquals
        '
        Me.bttnEquals.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEquals.Location = New System.Drawing.Point(125, 139)
        Me.bttnEquals.Name = "bttnEquals"
        Me.bttnEquals.Size = New System.Drawing.Size(86, 29)
        Me.bttnEquals.TabIndex = 39
        Me.bttnEquals.Text = "="
        '
        'bttnNegate
        '
        Me.bttnNegate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnNegate.Location = New System.Drawing.Point(171, 105)
        Me.bttnNegate.Name = "bttnNegate"
        Me.bttnNegate.Size = New System.Drawing.Size(40, 29)
        Me.bttnNegate.TabIndex = 38
        Me.bttnNegate.Text = "+-"
        '
        'bttnReverse
        '
        Me.bttnReverse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReverse.Location = New System.Drawing.Point(125, 105)
        Me.bttnReverse.Name = "bttnReverse"
        Me.bttnReverse.Size = New System.Drawing.Size(40, 29)
        Me.bttnReverse.TabIndex = 37
        Me.bttnReverse.Text = "1/x"
        Me.bttnReverse.UseCompatibleTextRendering = True
        '
        'bttnDivide
        '
        Me.bttnDivide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDivide.Location = New System.Drawing.Point(171, 71)
        Me.bttnDivide.Name = "bttnDivide"
        Me.bttnDivide.Size = New System.Drawing.Size(40, 29)
        Me.bttnDivide.TabIndex = 36
        Me.bttnDivide.Text = "/"
        '
        'bttnMultiply
        '
        Me.bttnMultiply.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMultiply.Location = New System.Drawing.Point(125, 71)
        Me.bttnMultiply.Name = "bttnMultiply"
        Me.bttnMultiply.Size = New System.Drawing.Size(40, 29)
        Me.bttnMultiply.TabIndex = 35
        Me.bttnMultiply.Text = "*"
        '
        'bttnMinus
        '
        Me.bttnMinus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMinus.Location = New System.Drawing.Point(171, 37)
        Me.bttnMinus.Name = "bttnMinus"
        Me.bttnMinus.Size = New System.Drawing.Size(40, 29)
        Me.bttnMinus.TabIndex = 34
        Me.bttnMinus.Text = "-"
        '
        'bttnPlus
        '
        Me.bttnPlus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPlus.Location = New System.Drawing.Point(125, 37)
        Me.bttnPlus.Name = "bttnPlus"
        Me.bttnPlus.Size = New System.Drawing.Size(40, 29)
        Me.bttnPlus.TabIndex = 33
        Me.bttnPlus.Text = "+"
        '
        'bttnClear
        '
        Me.bttnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(82, 139)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(31, 29)
        Me.bttnClear.TabIndex = 32
        Me.bttnClear.Text = "C"
        '
        'bttnPeriod
        '
        Me.bttnPeriod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPeriod.Location = New System.Drawing.Point(8, 139)
        Me.bttnPeriod.Name = "bttnPeriod"
        Me.bttnPeriod.Size = New System.Drawing.Size(31, 29)
        Me.bttnPeriod.TabIndex = 31
        Me.bttnPeriod.Text = "."
        '
        'bttn0
        '
        Me.bttn0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn0.Location = New System.Drawing.Point(45, 139)
        Me.bttn0.Name = "bttn0"
        Me.bttn0.Size = New System.Drawing.Size(31, 29)
        Me.bttn0.TabIndex = 30
        Me.bttn0.Text = "0"
        '
        'bttn9
        '
        Me.bttn9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn9.Location = New System.Drawing.Point(82, 105)
        Me.bttn9.Name = "bttn9"
        Me.bttn9.Size = New System.Drawing.Size(31, 29)
        Me.bttn9.TabIndex = 29
        Me.bttn9.Text = "9"
        '
        'bttn8
        '
        Me.bttn8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn8.Location = New System.Drawing.Point(45, 105)
        Me.bttn8.Name = "bttn8"
        Me.bttn8.Size = New System.Drawing.Size(31, 29)
        Me.bttn8.TabIndex = 28
        Me.bttn8.Text = "8"
        '
        'bttn7
        '
        Me.bttn7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn7.Location = New System.Drawing.Point(8, 105)
        Me.bttn7.Name = "bttn7"
        Me.bttn7.Size = New System.Drawing.Size(31, 29)
        Me.bttn7.TabIndex = 27
        Me.bttn7.Text = "7"
        '
        'bttn6
        '
        Me.bttn6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn6.Location = New System.Drawing.Point(82, 71)
        Me.bttn6.Name = "bttn6"
        Me.bttn6.Size = New System.Drawing.Size(31, 29)
        Me.bttn6.TabIndex = 26
        Me.bttn6.Text = "6"
        '
        'bttn5
        '
        Me.bttn5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn5.Location = New System.Drawing.Point(45, 71)
        Me.bttn5.Name = "bttn5"
        Me.bttn5.Size = New System.Drawing.Size(31, 29)
        Me.bttn5.TabIndex = 25
        Me.bttn5.Text = "5"
        '
        'bttn4
        '
        Me.bttn4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn4.Location = New System.Drawing.Point(8, 71)
        Me.bttn4.Name = "bttn4"
        Me.bttn4.Size = New System.Drawing.Size(31, 29)
        Me.bttn4.TabIndex = 24
        Me.bttn4.Text = "4"
        '
        'bttn3
        '
        Me.bttn3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn3.Location = New System.Drawing.Point(82, 37)
        Me.bttn3.Name = "bttn3"
        Me.bttn3.Size = New System.Drawing.Size(31, 29)
        Me.bttn3.TabIndex = 23
        Me.bttn3.Text = "3"
        '
        'bttn2
        '
        Me.bttn2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn2.Location = New System.Drawing.Point(45, 37)
        Me.bttn2.Name = "bttn2"
        Me.bttn2.Size = New System.Drawing.Size(31, 29)
        Me.bttn2.TabIndex = 22
        Me.bttn2.Text = "2"
        '
        'bttn1
        '
        Me.bttn1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn1.Location = New System.Drawing.Point(8, 37)
        Me.bttn1.Name = "bttn1"
        Me.bttn1.Size = New System.Drawing.Size(31, 29)
        Me.bttn1.TabIndex = 21
        Me.bttn1.Text = "1"
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 177)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.bttnEquals)
        Me.Controls.Add(Me.bttnNegate)
        Me.Controls.Add(Me.bttnReverse)
        Me.Controls.Add(Me.bttnDivide)
        Me.Controls.Add(Me.bttnMultiply)
        Me.Controls.Add(Me.bttnMinus)
        Me.Controls.Add(Me.bttnPlus)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.bttnPeriod)
        Me.Controls.Add(Me.bttn0)
        Me.Controls.Add(Me.bttn9)
        Me.Controls.Add(Me.bttn8)
        Me.Controls.Add(Me.bttn7)
        Me.Controls.Add(Me.bttn6)
        Me.Controls.Add(Me.bttn5)
        Me.Controls.Add(Me.bttn4)
        Me.Controls.Add(Me.bttn3)
        Me.Controls.Add(Me.bttn2)
        Me.Controls.Add(Me.bttn1)
        Me.KeyPreview = True
        Me.Name = "frmCalculator"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents bttnEquals As System.Windows.Forms.Button
    Friend WithEvents bttnNegate As System.Windows.Forms.Button
    Friend WithEvents bttnReverse As System.Windows.Forms.Button
    Friend WithEvents bttnDivide As System.Windows.Forms.Button
    Friend WithEvents bttnMultiply As System.Windows.Forms.Button
    Friend WithEvents bttnMinus As System.Windows.Forms.Button
    Friend WithEvents bttnPlus As System.Windows.Forms.Button
    Friend WithEvents bttnClear As System.Windows.Forms.Button
    Friend WithEvents bttnPeriod As System.Windows.Forms.Button
    Friend WithEvents bttn0 As System.Windows.Forms.Button
    Friend WithEvents bttn9 As System.Windows.Forms.Button
    Friend WithEvents bttn8 As System.Windows.Forms.Button
    Friend WithEvents bttn7 As System.Windows.Forms.Button
    Friend WithEvents bttn6 As System.Windows.Forms.Button
    Friend WithEvents bttn5 As System.Windows.Forms.Button
    Friend WithEvents bttn4 As System.Windows.Forms.Button
    Friend WithEvents bttn3 As System.Windows.Forms.Button
    Friend WithEvents bttn2 As System.Windows.Forms.Button
    Friend WithEvents bttn1 As System.Windows.Forms.Button

End Class
