<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoan
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
        Me.bttnExit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPayment = New System.Windows.Forms.TextBox
        Me.bttnPayment = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkPayEarly = New System.Windows.Forms.CheckBox
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bttnExit
        '
        Me.bttnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnExit.Location = New System.Drawing.Point(152, 214)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(105, 49)
        Me.bttnExit.TabIndex = 23
        Me.bttnExit.Text = "Exit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Monthly Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(179, 159)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.Size = New System.Drawing.Size(78, 20)
        Me.txtPayment.TabIndex = 21
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bttnPayment
        '
        Me.bttnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPayment.Location = New System.Drawing.Point(6, 214)
        Me.bttnPayment.Name = "bttnPayment"
        Me.bttnPayment.Size = New System.Drawing.Size(105, 49)
        Me.bttnPayment.TabIndex = 20
        Me.bttnPayment.Text = "Monthly Payment"
        Me.bttnPayment.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Loan Calculator"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkPayEarly
        '
        Me.chkPayEarly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPayEarly.Location = New System.Drawing.Point(12, 127)
        Me.chkPayEarly.Name = "chkPayEarly"
        Me.chkPayEarly.Size = New System.Drawing.Size(245, 26)
        Me.chkPayEarly.TabIndex = 18
        Me.chkPayEarly.Text = "Early Payment"
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(212, 96)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(45, 20)
        Me.txtDuration.TabIndex = 17
        Me.txtDuration.Text = "48"
        Me.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Interest Rate"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(199, 65)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(58, 20)
        Me.txtRate.TabIndex = 14
        Me.txtRate.Text = "14.5"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(173, 34)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(84, 20)
        Me.txtAmount.TabIndex = 13
        Me.txtAmount.Text = "25000"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Amount"
        '
        'frmLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 268)
        Me.Controls.Add(Me.bttnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.bttnPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkPayEarly)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoan"
        Me.Text = "Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents bttnPayment As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkPayEarly As System.Windows.Forms.CheckBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
