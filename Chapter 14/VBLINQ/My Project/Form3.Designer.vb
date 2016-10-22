<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategories = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSuppliers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtyUnits = New System.Windows.Forms.TextBox()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnCreate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Product Category"
        '
        'cbCategories
        '
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.Location = New System.Drawing.Point(159, 83)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.Size = New System.Drawing.Size(274, 25)
        Me.cbCategories.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Product Supplier"
        '
        'cbSuppliers
        '
        Me.cbSuppliers.FormattingEnabled = True
        Me.cbSuppliers.Location = New System.Drawing.Point(159, 123)
        Me.cbSuppliers.Name = "cbSuppliers"
        Me.cbSuppliers.Size = New System.Drawing.Size(274, 25)
        Me.cbSuppliers.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Name"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(130, 7)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(271, 23)
        Me.txtProduct.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(476, 7)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(63, 23)
        Me.txtPrice.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity per Units"
        '
        'txtQtyUnits
        '
        Me.txtQtyUnits.Location = New System.Drawing.Point(130, 40)
        Me.txtQtyUnits.Name = "txtQtyUnits"
        Me.txtQtyUnits.Size = New System.Drawing.Size(409, 23)
        Me.txtQtyUnits.TabIndex = 9
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(350, 223)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(189, 35)
        Me.bttnCancel.TabIndex = 11
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnCreate
        '
        Me.bttnCreate.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCreate.Location = New System.Drawing.Point(4, 223)
        Me.bttnCreate.Name = "bttnCreate"
        Me.bttnCreate.Size = New System.Drawing.Size(189, 35)
        Me.bttnCreate.TabIndex = 12
        Me.bttnCreate.Text = "Create New Product"
        Me.bttnCreate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(444, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Create New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Create New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 260)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bttnCreate)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.txtQtyUnits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSuppliers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCategories)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form3"
        Me.Text = "New Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbSuppliers As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQtyUnits As System.Windows.Forms.TextBox

    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnCreate As System.Windows.Forms.Button

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
