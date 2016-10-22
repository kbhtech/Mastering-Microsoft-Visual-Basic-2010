<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.lvOrderDetails = New System.Windows.Forms.ListView()
        Me.colDetailProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailProduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailDiscount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvOrderDetails
        '
        Me.lvOrderDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOrderDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDetailProductID, Me.colDetailProduct, Me.colDetailPrice, Me.colDetailQuantity, Me.colDetailDiscount, Me.colDetailSubtotal})
        Me.lvOrderDetails.FullRowSelect = True
        Me.lvOrderDetails.Location = New System.Drawing.Point(1, 98)
        Me.lvOrderDetails.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvOrderDetails.Name = "lvOrderDetails"
        Me.lvOrderDetails.Size = New System.Drawing.Size(550, 233)
        Me.lvOrderDetails.TabIndex = 28
        Me.lvOrderDetails.UseCompatibleStateImageBehavior = False
        Me.lvOrderDetails.View = System.Windows.Forms.View.Details
        '
        'colDetailProductID
        '
        Me.colDetailProductID.Text = "Prod ID"
        Me.colDetailProductID.Width = 70
        '
        'colDetailProduct
        '
        Me.colDetailProduct.Text = "Product"
        Me.colDetailProduct.Width = 194
        '
        'colDetailPrice
        '
        Me.colDetailPrice.Text = "Price"
        Me.colDetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colDetailQuantity
        '
        Me.colDetailQuantity.Text = "Qty"
        Me.colDetailQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colDetailQuantity.Width = 50
        '
        'colDetailDiscount
        '
        Me.colDetailDiscount.Text = "Disc."
        Me.colDetailDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colDetailDiscount.Width = 58
        '
        'colDetailSubtotal
        '
        Me.colDetailSubtotal.Text = "SubTotal"
        Me.colDetailSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colDetailSubtotal.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "OrderID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(92, 6)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderID.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Customer"
        '
        'txtOrderCustomer
        '
        Me.txtOrderCustomer.Location = New System.Drawing.Point(92, 39)
        Me.txtOrderCustomer.Name = "txtOrderCustomer"
        Me.txtOrderCustomer.ReadOnly = True
        Me.txtOrderCustomer.Size = New System.Drawing.Size(343, 22)
        Me.txtOrderCustomer.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Order Date"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(335, 6)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderDate.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Employee"
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(92, 70)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(343, 22)
        Me.txtEmployee.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(360, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 31)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Close Order Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 367)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOrderCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvOrderDetails)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmOrder"
        Me.Text = "New Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvOrderDetails As System.Windows.Forms.ListView
    Friend WithEvents colDetailProductID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailProduct As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailDiscount As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailSubtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrderCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
