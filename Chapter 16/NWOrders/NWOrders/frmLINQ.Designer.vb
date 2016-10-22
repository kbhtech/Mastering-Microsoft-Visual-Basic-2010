<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLINQ
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCustomers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbEmployees = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnNew = New System.Windows.Forms.Button()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(1, 65)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(609, 220)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product"
        Me.ColumnHeader2.Width = 342
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SubTotal"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        '
        'cbCustomers
        '
        Me.cbCustomers.FormattingEnabled = True
        Me.cbCustomers.Location = New System.Drawing.Point(64, 9)
        Me.cbCustomers.Name = "cbCustomers"
        Me.cbCustomers.Size = New System.Drawing.Size(241, 22)
        Me.cbCustomers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee"
        '
        'cbEmployees
        '
        Me.cbEmployees.FormattingEnabled = True
        Me.cbEmployees.Location = New System.Drawing.Point(390, 9)
        Me.cbEmployees.Name = "cbEmployees"
        Me.cbEmployees.Size = New System.Drawing.Size(220, 22)
        Me.cbEmployees.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(1, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(42, 22)
        Me.txtID.TabIndex = 4
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(49, 39)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.ReadOnly = True
        Me.txtProduct.Size = New System.Drawing.Size(335, 22)
        Me.txtProduct.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(390, 39)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(51, 22)
        Me.txtPrice.TabIndex = 6
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(447, 39)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(39, 22)
        Me.txtQty.TabIndex = 7
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(492, 39)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(91, 22)
        Me.txtSubtotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Totals"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(492, 291)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(91, 22)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bttnSave
        '
        Me.bttnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSave.Location = New System.Drawing.Point(462, 345)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(148, 34)
        Me.bttnSave.TabIndex = 15
        Me.bttnSave.Text = "Save Order"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnNew
        '
        Me.bttnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnNew.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnNew.Location = New System.Drawing.Point(462, 385)
        Me.bttnNew.Name = "bttnNew"
        Me.bttnNew.Size = New System.Drawing.Size(148, 34)
        Me.bttnNew.TabIndex = 16
        Me.bttnNew.Text = "New Order"
        Me.bttnNew.UseVisualStyleBackColor = True
        '
        'txtItems
        '
        Me.txtItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtItems.Location = New System.Drawing.Point(447, 291)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.ReadOnly = True
        Me.txtItems.Size = New System.Drawing.Size(39, 22)
        Me.txtItems.TabIndex = 12
        Me.txtItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ship To:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtRegion)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 96)
        Me.Panel1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Region"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "City"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(285, 67)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(117, 22)
        Me.txtRegion.TabIndex = 7
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(62, 67)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(136, 22)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(62, 39)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(340, 22)
        Me.txtAddress.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(62, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(211, 22)
        Me.txtName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.bttnNew)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cbEmployees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Northwind Orders (LINQ to SQL)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents bttnNew As System.Windows.Forms.Button
    Friend WithEvents txtItems As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
