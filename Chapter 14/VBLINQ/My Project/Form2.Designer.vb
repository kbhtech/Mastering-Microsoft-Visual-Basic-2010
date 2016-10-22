<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPackage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSupplier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvProducts
        '
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colPackage, Me.colCategory, Me.colPrice, Me.colSupplier})
        Me.lvProducts.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.Location = New System.Drawing.Point(1, 20)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(811, 213)
        Me.lvProducts.TabIndex = 2
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colID.Width = 30
        '
        'colName
        '
        Me.colName.Text = "Product"
        Me.colName.Width = 211
        '
        'colPackage
        '
        Me.colPackage.Text = "Packaging"
        Me.colPackage.Width = 176
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        Me.colCategory.Width = 153
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPrice.Width = 68
        '
        'colSupplier
        '
        Me.colSupplier.Text = "Supplier"
        Me.colSupplier.Width = 140
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(408, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Another Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(613, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add New Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Reload All Products"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 278)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvProducts)
        Me.Name = "Form2"
        Me.Text = "Northwind Products"
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents lvProducts As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPackage As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader


    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents colSupplier As System.Windows.Forms.ColumnHeader
End Class
