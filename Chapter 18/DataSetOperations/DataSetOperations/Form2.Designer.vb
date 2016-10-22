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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NorthwindDataSet = New DataSetOperations.NorthwindDataSet
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New DataSetOperations.NorthwindDataSetTableAdapters.ProductsTableAdapter
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantityPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiscontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.bttnSubmit = New System.Windows.Forms.Button
        Me.bttnFirst = New System.Windows.Forms.Button
        Me.bttnPrevious = New System.Windows.Forms.Button
        Me.bttnNext = New System.Windows.Forms.Button
        Me.bttnLast = New System.Windows.Forms.Button
        Me.bttnFilter = New System.Windows.Forms.Button
        Me.bttnFind = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.CategoryIDDataGridViewTextBoxColumn, Me.QuantityPerUnitDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.UnitsInStockDataGridViewTextBoxColumn, Me.UnitsOnOrderDataGridViewTextBoxColumn, Me.ReorderLevelDataGridViewTextBoxColumn, Me.DiscontinuedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(612, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NorthwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        '
        'QuantityPerUnitDataGridViewTextBoxColumn
        '
        Me.QuantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit"
        Me.QuantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit"
        Me.QuantityPerUnitDataGridViewTextBoxColumn.Name = "QuantityPerUnitDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'UnitsInStockDataGridViewTextBoxColumn
        '
        Me.UnitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.Name = "UnitsInStockDataGridViewTextBoxColumn"
        '
        'UnitsOnOrderDataGridViewTextBoxColumn
        '
        Me.UnitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder"
        Me.UnitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder"
        Me.UnitsOnOrderDataGridViewTextBoxColumn.Name = "UnitsOnOrderDataGridViewTextBoxColumn"
        '
        'ReorderLevelDataGridViewTextBoxColumn
        '
        Me.ReorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel"
        Me.ReorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel"
        Me.ReorderLevelDataGridViewTextBoxColumn.Name = "ReorderLevelDataGridViewTextBoxColumn"
        '
        'DiscontinuedDataGridViewCheckBoxColumn
        '
        Me.DiscontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued"
        Me.DiscontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued"
        Me.DiscontinuedDataGridViewCheckBoxColumn.Name = "DiscontinuedDataGridViewCheckBoxColumn"
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubmit.Location = New System.Drawing.Point(480, 331)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(133, 39)
        Me.bttnSubmit.TabIndex = 7
        Me.bttnSubmit.Text = "Submit Edits"
        Me.bttnSubmit.UseVisualStyleBackColor = True
        '
        'bttnFirst
        '
        Me.bttnFirst.Location = New System.Drawing.Point(1, 339)
        Me.bttnFirst.Name = "bttnFirst"
        Me.bttnFirst.Size = New System.Drawing.Size(40, 23)
        Me.bttnFirst.TabIndex = 8
        Me.bttnFirst.Text = "<<"
        Me.bttnFirst.UseVisualStyleBackColor = True
        '
        'bttnPrevious
        '
        Me.bttnPrevious.Location = New System.Drawing.Point(47, 339)
        Me.bttnPrevious.Name = "bttnPrevious"
        Me.bttnPrevious.Size = New System.Drawing.Size(40, 23)
        Me.bttnPrevious.TabIndex = 9
        Me.bttnPrevious.Text = "<"
        Me.bttnPrevious.UseVisualStyleBackColor = True
        '
        'bttnNext
        '
        Me.bttnNext.Location = New System.Drawing.Point(93, 339)
        Me.bttnNext.Name = "bttnNext"
        Me.bttnNext.Size = New System.Drawing.Size(40, 23)
        Me.bttnNext.TabIndex = 10
        Me.bttnNext.Text = ">"
        Me.bttnNext.UseVisualStyleBackColor = True
        '
        'bttnLast
        '
        Me.bttnLast.Location = New System.Drawing.Point(139, 339)
        Me.bttnLast.Name = "bttnLast"
        Me.bttnLast.Size = New System.Drawing.Size(40, 23)
        Me.bttnLast.TabIndex = 11
        Me.bttnLast.Text = ">>"
        Me.bttnLast.UseVisualStyleBackColor = True
        '
        'bttnFilter
        '
        Me.bttnFilter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnFilter.Location = New System.Drawing.Point(1, 368)
        Me.bttnFilter.Name = "bttnFilter"
        Me.bttnFilter.Size = New System.Drawing.Size(86, 23)
        Me.bttnFilter.TabIndex = 12
        Me.bttnFilter.Text = "Filter"
        Me.bttnFilter.UseVisualStyleBackColor = True
        '
        'bttnFind
        '
        Me.bttnFind.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnFind.Location = New System.Drawing.Point(93, 368)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(86, 23)
        Me.bttnFind.TabIndex = 13
        Me.bttnFind.Text = "Find"
        Me.bttnFind.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 400)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.bttnFilter)
        Me.Controls.Add(Me.bttnLast)
        Me.Controls.Add(Me.bttnNext)
        Me.Controls.Add(Me.bttnPrevious)
        Me.Controls.Add(Me.bttnFirst)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NorthwindDataSet As DataSetOperations.NorthwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As DataSetOperations.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityPerUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitsOnOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bttnSubmit As System.Windows.Forms.Button
    Friend WithEvents bttnFirst As System.Windows.Forms.Button
    Friend WithEvents bttnPrevious As System.Windows.Forms.Button
    Friend WithEvents bttnNext As System.Windows.Forms.Button
    Friend WithEvents bttnLast As System.Windows.Forms.Button
    Friend WithEvents bttnFilter As System.Windows.Forms.Button
    Friend WithEvents bttnFind As System.Windows.Forms.Button
End Class
