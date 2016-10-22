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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbCountries = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvOrders = New System.Windows.Forms.ListView()
        Me.colOrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrderDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrderTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrderItems = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrderFreight = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvOrderDetails = New System.Windows.Forms.ListView()
        Me.colDetailProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailProduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailDiscount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetailSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(767, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load Countries and Customers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbCountries
        '
        Me.cbCountries.FormattingEnabled = True
        Me.cbCountries.Location = New System.Drawing.Point(126, 54)
        Me.cbCountries.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbCountries.Name = "cbCountries"
        Me.cbCountries.Size = New System.Drawing.Size(235, 22)
        Me.cbCountries.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(369, 54)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 47)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Country"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 107)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(767, 273)
        Me.SplitContainer1.SplitterDistance = 209
        Me.SplitContainer1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Customer"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(0, 25)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(205, 242)
        Me.ListBox1.TabIndex = 12
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvOrders)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvOrderDetails)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Size = New System.Drawing.Size(554, 273)
        Me.SplitContainer2.SplitterDistance = 151
        Me.SplitContainer2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Customer Orders"
        '
        'lvOrders
        '
        Me.lvOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colOrderID, Me.colOrderDate, Me.colOrderTotal, Me.colOrderItems, Me.colOrderFreight})
        Me.lvOrders.FullRowSelect = True
        Me.lvOrders.Location = New System.Drawing.Point(3, 25)
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(548, 124)
        Me.lvOrders.TabIndex = 24
        Me.lvOrders.UseCompatibleStateImageBehavior = False
        Me.lvOrders.View = System.Windows.Forms.View.Details
        '
        'colOrderID
        '
        Me.colOrderID.Text = "OrderID"
        Me.colOrderID.Width = 90
        '
        'colOrderDate
        '
        Me.colOrderDate.Text = "Placed On"
        Me.colOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colOrderDate.Width = 120
        '
        'colOrderTotal
        '
        Me.colOrderTotal.Text = "OrderTotal"
        Me.colOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colOrderTotal.Width = 120
        '
        'colOrderItems
        '
        Me.colOrderItems.Text = "Items"
        Me.colOrderItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colOrderItems.Width = 90
        '
        'colOrderFreight
        '
        Me.colOrderFreight.Text = "Freight"
        Me.colOrderFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colOrderFreight.Width = 70
        '
        'lvOrderDetails
        '
        Me.lvOrderDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOrderDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDetailProductID, Me.colDetailProduct, Me.colDetailPrice, Me.colDetailuantity, Me.colDetailDiscount, Me.colDetailSubtotal})
        Me.lvOrderDetails.FullRowSelect = True
        Me.lvOrderDetails.Location = New System.Drawing.Point(3, 22)
        Me.lvOrderDetails.Name = "lvOrderDetails"
        Me.lvOrderDetails.Size = New System.Drawing.Size(548, 90)
        Me.lvOrderDetails.TabIndex = 27
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
        Me.colDetailProduct.Width = 160
        '
        'colDetailPrice
        '
        Me.colDetailPrice.Text = "Price"
        Me.colDetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colDetailuantity
        '
        Me.colDetailuantity.Text = "Qty"
        Me.colDetailuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colDetailuantity.Width = 50
        '
        'colDetailDiscount
        '
        Me.colDetailDiscount.Text = "Dicount"
        Me.colDetailDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colDetailSubtotal
        '
        Me.colDetailSubtotal.Text = "SubTotal"
        Me.colDetailSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colDetailSubtotal.Width = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Order Details"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 383)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbCountries)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "LINQ 2 SQL Demo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbCountries As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox



    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvOrders As System.Windows.Forms.ListView
    Friend WithEvents colOrderID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrderDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrderTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrderItems As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrderFreight As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvOrderDetails As System.Windows.Forms.ListView
    Friend WithEvents colDetailProductID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailProduct As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailDiscount As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetailSubtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label

















End Class
