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
        Me.bttnPopulate = New System.Windows.Forms.Button
        Me.bttnReadProducts = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.bttnSuppliersProducts = New System.Windows.Forms.Button
        Me.bttnUpdate = New System.Windows.Forms.Button
        Me.bttnView = New System.Windows.Forms.Button
        Me.bttnSubmit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bttnPopulate
        '
        Me.bttnPopulate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPopulate.Location = New System.Drawing.Point(1, 7)
        Me.bttnPopulate.Name = "bttnPopulate"
        Me.bttnPopulate.Size = New System.Drawing.Size(431, 38)
        Me.bttnPopulate.TabIndex = 0
        Me.bttnPopulate.Text = "Populate Tables"
        Me.bttnPopulate.UseVisualStyleBackColor = True
        '
        'bttnReadProducts
        '
        Me.bttnReadProducts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReadProducts.Location = New System.Drawing.Point(1, 51)
        Me.bttnReadProducts.Name = "bttnReadProducts"
        Me.bttnReadProducts.Size = New System.Drawing.Size(431, 40)
        Me.bttnReadProducts.TabIndex = 1
        Me.bttnReadProducts.Text = "Read Products and Categories"
        Me.bttnReadProducts.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 192)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(431, 268)
        Me.TextBox1.TabIndex = 2
        '
        'bttnSuppliersProducts
        '
        Me.bttnSuppliersProducts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuppliersProducts.Location = New System.Drawing.Point(1, 97)
        Me.bttnSuppliersProducts.Name = "bttnSuppliersProducts"
        Me.bttnSuppliersProducts.Size = New System.Drawing.Size(431, 39)
        Me.bttnSuppliersProducts.TabIndex = 3
        Me.bttnSuppliersProducts.Text = "Read Products by Supplier"
        Me.bttnSuppliersProducts.UseVisualStyleBackColor = True
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdate.Location = New System.Drawing.Point(2, 147)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(135, 39)
        Me.bttnUpdate.TabIndex = 4
        Me.bttnUpdate.Text = "Update Products"
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'bttnView
        '
        Me.bttnView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnView.Location = New System.Drawing.Point(151, 147)
        Me.bttnView.Name = "bttnView"
        Me.bttnView.Size = New System.Drawing.Size(133, 39)
        Me.bttnView.TabIndex = 5
        Me.bttnView.Text = "View Edits"
        Me.bttnView.UseVisualStyleBackColor = True
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubmit.Location = New System.Drawing.Point(298, 147)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(133, 39)
        Me.bttnSubmit.TabIndex = 6
        Me.bttnSubmit.Text = "Submit Edits"
        Me.bttnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 464)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.bttnView)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.bttnSuppliersProducts)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bttnReadProducts)
        Me.Controls.Add(Me.bttnPopulate)
        Me.Name = "Form1"
        Me.Text = "Typed DataSet Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnPopulate As System.Windows.Forms.Button
    Friend WithEvents bttnReadProducts As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bttnSuppliersProducts As System.Windows.Forms.Button
    Friend WithEvents bttnUpdate As System.Windows.Forms.Button
    Friend WithEvents bttnView As System.Windows.Forms.Button
    Friend WithEvents bttnSubmit As System.Windows.Forms.Button

End Class
