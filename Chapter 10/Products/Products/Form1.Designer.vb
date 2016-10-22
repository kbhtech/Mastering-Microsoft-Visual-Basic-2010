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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colBookISBN = New System.Windows.Forms.ColumnHeader
        Me.colBookTitle = New System.Windows.Forms.ColumnHeader
        Me.colBookSubtitle = New System.Windows.Forms.ColumnHeader
        Me.colPrice = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.colBookID = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(499, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Populate Products List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(499, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Show All Products"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBookID, Me.colBookISBN, Me.colBookTitle, Me.colBookSubtitle, Me.colPrice})
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(3, 118)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 114)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colBookISBN
        '
        Me.colBookISBN.Text = "ISBN"
        Me.colBookISBN.Width = 90
        '
        'colBookTitle
        '
        Me.colBookTitle.Text = "Title"
        Me.colBookTitle.Width = 100
        '
        'colBookSubtitle
        '
        Me.colBookSubtitle.Text = "Subtitle"
        Me.colBookSubtitle.Width = 140
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPrice.Width = 70
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.Location = New System.Drawing.Point(3, 256)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(499, 164)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Product ID"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Product"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Product Description"
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 80
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(499, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Show Price List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Supplies"
        '
        'colBookID
        '
        Me.colBookID.Text = "Product ID"
        Me.colBookID.Width = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Products Class - Test Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colBookISBN As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBookTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBookSubtitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colBookID As System.Windows.Forms.ColumnHeader

End Class
