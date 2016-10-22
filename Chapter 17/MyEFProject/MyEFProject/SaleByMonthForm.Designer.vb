<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleByMonthForm
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
        Me.gridResult = New System.Windows.Forms.DataGridView()
        Me.colISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopiesSold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Display = New System.Windows.Forms.Button()
        CType(Me.gridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridResult
        '
        Me.gridResult.AllowUserToOrderColumns = True
        Me.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colISBN, Me.colTitle, Me.colMonth, Me.colCopiesSold})
        Me.gridResult.Location = New System.Drawing.Point(12, 21)
        Me.gridResult.Name = "gridResult"
        Me.gridResult.Size = New System.Drawing.Size(553, 208)
        Me.gridResult.TabIndex = 13
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
        'colMonth
        '
        Me.colMonth.HeaderText = "Month"
        Me.colMonth.Name = "colMonth"
        '
        'colCopiesSold
        '
        Me.colCopiesSold.HeaderText = "Copies Sold"
        Me.colCopiesSold.Name = "colCopiesSold"
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(12, 245)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(163, 40)
        Me.Display.TabIndex = 14
        Me.Display.Text = "Display"
        Me.Display.UseVisualStyleBackColor = True
        '
        'SaleByMonthForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 300)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.gridResult)
        Me.Name = "SaleByMonthForm"
        Me.Text = "Monthly Sales"
        CType(Me.gridResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridResult As System.Windows.Forms.DataGridView
    Friend WithEvents colISBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCopiesSold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Display As System.Windows.Forms.Button



End Class
