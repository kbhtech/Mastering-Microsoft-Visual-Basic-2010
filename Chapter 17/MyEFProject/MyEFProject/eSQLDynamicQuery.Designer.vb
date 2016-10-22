<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eSQLDynamicQuery
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gridResult = New System.Windows.Forms.DataGridView()
        Me.colISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDatePublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtAfter = New System.Windows.Forms.MaskedTextBox()
        Me.txtBefore = New System.Windows.Forms.MaskedTextBox()
        CType(Me.gridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(40, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ISBN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(40, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(40, 102)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(200, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(40, 56)
        Me.txtISBN.Mask = "0000000000000"
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(200, 20)
        Me.txtISBN.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(40, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Published Before:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(40, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Published After:"
        '
        'gridResult
        '
        Me.gridResult.AllowUserToOrderColumns = True
        Me.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colISBN, Me.colTitle, Me.colDatePublished})
        Me.gridResult.Location = New System.Drawing.Point(43, 258)
        Me.gridResult.Name = "gridResult"
        Me.gridResult.Size = New System.Drawing.Size(425, 208)
        Me.gridResult.TabIndex = 12
        '
        'colISBN
        '
        Me.colISBN.FillWeight = 80.0!
        Me.colISBN.HeaderText = "ISBN"
        Me.colISBN.Name = "colISBN"
        '
        'colTitle
        '
        Me.colTitle.HeaderText = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Width = 200
        '
        'colDatePublished
        '
        Me.colDatePublished.HeaderText = "Date Published"
        Me.colDatePublished.Name = "colDatePublished"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(40, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Books Found:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(40, 482)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(200, 31)
        Me.btnFind.TabIndex = 14
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtAfter
        '
        Me.txtAfter.Location = New System.Drawing.Point(40, 154)
        Me.txtAfter.Mask = "00/00/0000"
        Me.txtAfter.Name = "txtAfter"
        Me.txtAfter.Size = New System.Drawing.Size(200, 20)
        Me.txtAfter.TabIndex = 16
        Me.txtAfter.ValidatingType = GetType(Date)
        '
        'txtBefore
        '
        Me.txtBefore.Location = New System.Drawing.Point(40, 205)
        Me.txtBefore.Mask = "00/00/0000"
        Me.txtBefore.Name = "txtBefore"
        Me.txtBefore.Size = New System.Drawing.Size(200, 20)
        Me.txtBefore.TabIndex = 17
        Me.txtBefore.ValidatingType = GetType(Date)
        '
        'eSQLDynamicQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 530)
        Me.Controls.Add(Me.txtBefore)
        Me.Controls.Add(Me.txtAfter)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gridResult)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "eSQLDynamicQuery"
        Me.Text = "eSQL Dynamic Query"
        CType(Me.gridResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.MaskedTextBox

    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label



    Friend WithEvents gridResult As System.Windows.Forms.DataGridView



    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtAfter As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBefore As System.Windows.Forms.MaskedTextBox
    Friend WithEvents colISBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDatePublished As System.Windows.Forms.DataGridViewTextBoxColumn









End Class
