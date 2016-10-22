<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlexCombo
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
        Me.bttnLocateCountry = New System.Windows.Forms.Button
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.bttnCancel = New System.Windows.Forms.Button
        Me.bttnOK = New System.Windows.Forms.Button
        Me.cbCountry = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.bttnLocateCity = New System.Windows.Forms.Button
        Me.cbCity = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'bttnLocateCountry
        '
        Me.bttnLocateCountry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLocateCountry.Location = New System.Drawing.Point(469, 84)
        Me.bttnLocateCountry.Name = "bttnLocateCountry"
        Me.bttnLocateCountry.Size = New System.Drawing.Size(32, 21)
        Me.bttnLocateCountry.TabIndex = 53
        Me.bttnLocateCountry.Text = "..."
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(65, 123)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(80, 22)
        Me.txtPostalCode.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 32)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Postal Code"
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(397, 167)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(104, 32)
        Me.bttnCancel.TabIndex = 52
        Me.bttnCancel.Text = "Cancel"
        '
        'bttnOK
        '
        Me.bttnOK.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOK.Location = New System.Drawing.Point(6, 167)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(104, 32)
        Me.bttnOK.TabIndex = 51
        Me.bttnOK.Text = "OK"
        '
        'cbCountry
        '
        Me.cbCountry.DropDownWidth = 56
        Me.cbCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCountry.FormattingEnabled = True
        Me.cbCountry.Items.AddRange(New Object() {"USA", "ITALY", "SPAIN", "GREECE", "FRANCE", "GERMANY", "DENMARK"})
        Me.cbCountry.Location = New System.Drawing.Point(327, 83)
        Me.cbCountry.Name = "cbCountry"
        Me.cbCountry.Size = New System.Drawing.Size(136, 22)
        Me.cbCountry.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Country"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(65, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(432, 22)
        Me.txtName.TabIndex = 41
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(65, 43)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(432, 22)
        Me.txtAddress.TabIndex = 43
        '
        'bttnLocateCity
        '
        Me.bttnLocateCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLocateCity.Location = New System.Drawing.Point(213, 83)
        Me.bttnLocateCity.Name = "bttnLocateCity"
        Me.bttnLocateCity.Size = New System.Drawing.Size(32, 21)
        Me.bttnLocateCity.TabIndex = 46
        Me.bttnLocateCity.Text = "..."
        '
        'cbCity
        '
        Me.cbCity.DropDownWidth = 200
        Me.cbCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCity.FormattingEnabled = True
        Me.cbCity.Items.AddRange(New Object() {"Athens", "Barcelona", "Berlin", "Frankfurt", "Lyon", "Milan", "Paris", "Rome"})
        Me.cbCity.Location = New System.Drawing.Point(63, 81)
        Me.cbCity.Name = "cbCity"
        Me.cbCity.Size = New System.Drawing.Size(144, 22)
        Me.cbCity.Sorted = True
        Me.cbCity.TabIndex = 45
        '
        'frmFlexCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 204)
        Me.Controls.Add(Me.bttnLocateCountry)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.cbCountry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.bttnLocateCity)
        Me.Controls.Add(Me.cbCity)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFlexCombo"
        Me.Text = "FlexComboBox Demo Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bttnLocateCountry As System.Windows.Forms.Button
    Private WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents bttnCancel As System.Windows.Forms.Button
    Private WithEvents bttnOK As System.Windows.Forms.Button
    Private WithEvents cbCountry As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents bttnLocateCity As System.Windows.Forms.Button
    Private WithEvents cbCity As System.Windows.Forms.ComboBox

End Class
