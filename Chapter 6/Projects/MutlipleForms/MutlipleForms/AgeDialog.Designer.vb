<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgeDialog
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.cmbDay = New System.Windows.Forms.ComboBox
        Me.bttnCancel = New System.Windows.Forms.Button
        Me.bttnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Year"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Month"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Day"
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.Location = New System.Drawing.Point(236, 24)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(81, 22)
        Me.cmbYear.TabIndex = 16
        Me.cmbYear.Text = "ComboBox3"
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.Location = New System.Drawing.Point(119, 24)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(94, 22)
        Me.cmbMonth.TabIndex = 15
        Me.cmbMonth.Text = "ComboBox2"
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.Location = New System.Drawing.Point(34, 24)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(51, 22)
        Me.cmbDay.TabIndex = 14
        Me.cmbDay.Text = "ComboBox1"
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(10, 70)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(75, 23)
        Me.bttnCancel.TabIndex = 12
        Me.bttnCancel.Text = "Cancel"
        '
        'bttnOK
        '
        Me.bttnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnOK.Location = New System.Drawing.Point(242, 70)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnOK.TabIndex = 13
        Me.bttnOK.Text = "OK"
        '
        'AgeDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 98)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnOK)
        Me.Name = "AgeDialogBox"
        Me.Text = "AgeDialogBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnOK As System.Windows.Forms.Button
End Class
