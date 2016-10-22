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
        Me.components = New System.ComponentModel.Container()
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim QuantityPerUnitLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UnitsInStockLabel As System.Windows.Forms.Label
        Dim UnitsOnOrderLabel As System.Windows.Forms.Label
        Dim DiscontinuedLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NorthwindDataSet = New Products.NorthwindDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New Products.NorthwindDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New Products.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.bttnShowDeleted = New System.Windows.Forms.ToolStripButton()
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsInStockTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsOnOrderTextBox = New System.Windows.Forms.TextBox()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.cbCategoryName = New System.Windows.Forms.ComboBox()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbCompanyName = New System.Windows.Forms.ComboBox()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoriesTableAdapter = New Products.NorthwindDataSetTableAdapters.CategoriesTableAdapter()
        Me.SuppliersTableAdapter = New Products.NorthwindDataSetTableAdapters.SuppliersTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bttnFilter = New System.Windows.Forms.Button()
        Me.txtUnitsInStockFilter = New System.Windows.Forms.TextBox()
        Me.txtUnitsOnOrderFilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCategoryFilter = New System.Windows.Forms.ComboBox()
        ProductNameLabel = New System.Windows.Forms.Label()
        QuantityPerUnitLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        UnitsInStockLabel = New System.Windows.Forms.Label()
        UnitsOnOrderLabel = New System.Windows.Forms.Label()
        DiscontinuedLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsBindingNavigator.SuspendLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(341, 38)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 2
        ProductNameLabel.Text = "Product Name:"
        '
        'QuantityPerUnitLabel
        '
        QuantityPerUnitLabel.AutoSize = True
        QuantityPerUnitLabel.Location = New System.Drawing.Point(341, 172)
        QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        QuantityPerUnitLabel.Size = New System.Drawing.Size(90, 13)
        QuantityPerUnitLabel.TabIndex = 6
        QuantityPerUnitLabel.Text = "Quantity Per Unit:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(341, 211)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 8
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitsInStockLabel
        '
        UnitsInStockLabel.AutoSize = True
        UnitsInStockLabel.Location = New System.Drawing.Point(341, 250)
        UnitsInStockLabel.Name = "UnitsInStockLabel"
        UnitsInStockLabel.Size = New System.Drawing.Size(77, 13)
        UnitsInStockLabel.TabIndex = 10
        UnitsInStockLabel.Text = "Units In Stock:"
        '
        'UnitsOnOrderLabel
        '
        UnitsOnOrderLabel.AutoSize = True
        UnitsOnOrderLabel.Location = New System.Drawing.Point(341, 289)
        UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        UnitsOnOrderLabel.Size = New System.Drawing.Size(80, 13)
        UnitsOnOrderLabel.TabIndex = 12
        UnitsOnOrderLabel.Text = "Units On Order:"
        '
        'DiscontinuedLabel
        '
        DiscontinuedLabel.AutoSize = True
        DiscontinuedLabel.Location = New System.Drawing.Point(341, 67)
        DiscontinuedLabel.Name = "DiscontinuedLabel"
        DiscontinuedLabel.Size = New System.Drawing.Size(72, 13)
        DiscontinuedLabel.TabIndex = 13
        DiscontinuedLabel.Text = "Discontinued:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(330, 25)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(89, 13)
        Label4.TabIndex = 20
        Label4.Text = "Units On Order >:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(202, 26)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 13)
        Label5.TabIndex = 22
        Label5.Text = "Units In Stock <:"
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.Namespace = "http://tempuri.org/NorthwindDataSet.xsd"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Products.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsBindingNavigator
        '
        Me.ProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductsBindingNavigator.BindingSource = Me.ProductsBindingSource
        Me.ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductsBindingNavigatorSaveItem, Me.bttnShowDeleted})
        Me.ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductsBindingNavigator.Name = "ProductsBindingNavigator"
        Me.ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductsBindingNavigator.Size = New System.Drawing.Size(604, 25)
        Me.ProductsBindingNavigator.TabIndex = 0
        Me.ProductsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductsBindingNavigatorSaveItem
        '
        Me.ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductsBindingNavigatorSaveItem.Name = "ProductsBindingNavigatorSaveItem"
        Me.ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'bttnShowDeleted
        '
        Me.bttnShowDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.bttnShowDeleted.Image = CType(resources.GetObject("bttnShowDeleted.Image"), System.Drawing.Image)
        Me.bttnShowDeleted.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnShowDeleted.Name = "bttnShowDeleted"
        Me.bttnShowDeleted.Size = New System.Drawing.Size(77, 22)
        Me.bttnShowDeleted.Text = "Show Deleted"
        '
        'ProductsListBox
        '
        Me.ProductsListBox.DataSource = Me.ProductsBindingSource
        Me.ProductsListBox.DisplayMember = "ProductName"
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(12, 29)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(300, 290)
        Me.ProductsListBox.TabIndex = 1
        Me.ProductsListBox.ValueMember = "ProductID"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(442, 35)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "QuantityPerUnit", True))
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(442, 169)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(150, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 7
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(442, 208)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(150, 20)
        Me.UnitPriceTextBox.TabIndex = 9
        '
        'UnitsInStockTextBox
        '
        Me.UnitsInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsInStock", True))
        Me.UnitsInStockTextBox.Location = New System.Drawing.Point(442, 247)
        Me.UnitsInStockTextBox.Name = "UnitsInStockTextBox"
        Me.UnitsInStockTextBox.Size = New System.Drawing.Size(150, 20)
        Me.UnitsInStockTextBox.TabIndex = 11
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsOnOrder", True))
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(442, 286)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(150, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 13
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductsBindingSource, "Discontinued", True))
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(442, 62)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DiscontinuedCheckBox.TabIndex = 14
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'cbCategoryName
        '
        Me.cbCategoryName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "CategoryID", True))
        Me.cbCategoryName.DataSource = Me.CategoriesBindingSource
        Me.cbCategoryName.DisplayMember = "CategoryName"
        Me.cbCategoryName.FormattingEnabled = True
        Me.cbCategoryName.Location = New System.Drawing.Point(442, 92)
        Me.cbCategoryName.Name = "cbCategoryName"
        Me.cbCategoryName.Size = New System.Drawing.Size(150, 21)
        Me.cbCategoryName.TabIndex = 15
        Me.cbCategoryName.ValueMember = "CategoryID"
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.NorthwindDataSet
        '
        'cbCompanyName
        '
        Me.cbCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "SupplierID", True))
        Me.cbCompanyName.DataSource = Me.SuppliersBindingSource
        Me.cbCompanyName.DisplayMember = "CompanyName"
        Me.cbCompanyName.FormattingEnabled = True
        Me.cbCompanyName.Location = New System.Drawing.Point(442, 131)
        Me.cbCompanyName.Name = "cbCompanyName"
        Me.cbCompanyName.Size = New System.Drawing.Size(150, 21)
        Me.cbCompanyName.TabIndex = 16
        Me.cbCompanyName.ValueMember = "SupplierID"
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.NorthwindDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Category Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Company Name:"
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bttnFilter)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.txtUnitsInStockFilter)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.txtUnitsOnOrderFilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboCategoryFilter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 86)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Products"
        '
        'bttnFilter
        '
        Me.bttnFilter.Location = New System.Drawing.Point(482, 26)
        Me.bttnFilter.Name = "bttnFilter"
        Me.bttnFilter.Size = New System.Drawing.Size(75, 40)
        Me.bttnFilter.TabIndex = 23
        Me.bttnFilter.Text = "Filter"
        Me.bttnFilter.UseVisualStyleBackColor = True
        '
        'txtUnitsInStockFilter
        '
        Me.txtUnitsInStockFilter.Location = New System.Drawing.Point(205, 46)
        Me.txtUnitsInStockFilter.Name = "txtUnitsInStockFilter"
        Me.txtUnitsInStockFilter.Size = New System.Drawing.Size(83, 20)
        Me.txtUnitsInStockFilter.TabIndex = 21
        '
        'txtUnitsOnOrderFilter
        '
        Me.txtUnitsOnOrderFilter.Location = New System.Drawing.Point(333, 46)
        Me.txtUnitsOnOrderFilter.Name = "txtUnitsOnOrderFilter"
        Me.txtUnitsOnOrderFilter.Size = New System.Drawing.Size(83, 20)
        Me.txtUnitsOnOrderFilter.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Category:"
        '
        'cboCategoryFilter
        '
        Me.cboCategoryFilter.FormattingEnabled = True
        Me.cboCategoryFilter.Location = New System.Drawing.Point(16, 45)
        Me.cboCategoryFilter.Name = "cboCategoryFilter"
        Me.cboCategoryFilter.Size = New System.Drawing.Size(150, 21)
        Me.cboCategoryFilter.TabIndex = 16
        Me.cboCategoryFilter.Tag = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCompanyName)
        Me.Controls.Add(Me.cbCategoryName)
        Me.Controls.Add(DiscontinuedLabel)
        Me.Controls.Add(Me.DiscontinuedCheckBox)
        Me.Controls.Add(UnitsOnOrderLabel)
        Me.Controls.Add(Me.UnitsOnOrderTextBox)
        Me.Controls.Add(UnitsInStockLabel)
        Me.Controls.Add(Me.UnitsInStockTextBox)
        Me.Controls.Add(UnitPriceLabel)
        Me.Controls.Add(Me.UnitPriceTextBox)
        Me.Controls.Add(QuantityPerUnitLabel)
        Me.Controls.Add(Me.QuantityPerUnitTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.ProductsListBox)
        Me.Controls.Add(Me.ProductsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsBindingNavigator.ResumeLayout(False)
        Me.ProductsBindingNavigator.PerformLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As Products.NorthwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Products.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As Products.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox

    Friend WithEvents QuantityPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsInStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsOnOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscontinuedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cbCategoryName As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As Products.NorthwindDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As Products.NorthwindDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents bttnShowDeleted As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCategoryFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitsInStockFilter As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsOnOrderFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttnFilter As System.Windows.Forms.Button






























End Class
