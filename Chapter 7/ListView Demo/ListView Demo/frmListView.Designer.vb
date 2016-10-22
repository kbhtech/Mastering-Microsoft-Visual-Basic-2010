<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListView
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup1", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup2", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup3", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaaaaaaa"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbbbbbbb"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("cccccccc")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("cccccccc2222")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("dddddddddddddd222222")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListView))
        Me.ColumnHeaderTel = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdTop = New System.Windows.Forms.RadioButton
        Me.rdLeft = New System.Windows.Forms.RadioButton
        Me.rdDefault = New System.Windows.Forms.RadioButton
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeaderCompany = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderContact = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderFAX = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bttnIterate = New System.Windows.Forms.Button
        Me.rdTile = New System.Windows.Forms.RadioButton
        Me.rdDetails = New System.Windows.Forms.RadioButton
        Me.rdList = New System.Windows.Forms.RadioButton
        Me.rdSmallIcons = New System.Windows.Forms.RadioButton
        Me.bttnEnumerate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdIcons = New System.Windows.Forms.RadioButton
        Me.bttnPopulate = New System.Windows.Forms.Button
        Me.bttnSave = New System.Windows.Forms.Button
        Me.bttnLoad = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeaderTel
        '
        Me.ColumnHeaderTel.Text = "Telephone"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rdTop)
        Me.GroupBox2.Controls.Add(Me.rdLeft)
        Me.GroupBox2.Controls.Add(Me.rdDefault)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(423, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 106)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Icon Placement"
        '
        'rdTop
        '
        Me.rdTop.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdTop.Location = New System.Drawing.Point(16, 78)
        Me.rdTop.Name = "rdTop"
        Me.rdTop.Size = New System.Drawing.Size(80, 22)
        Me.rdTop.TabIndex = 2
        Me.rdTop.Text = "Top"
        '
        'rdLeft
        '
        Me.rdLeft.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdLeft.Location = New System.Drawing.Point(16, 55)
        Me.rdLeft.Name = "rdLeft"
        Me.rdLeft.Size = New System.Drawing.Size(80, 22)
        Me.rdLeft.TabIndex = 1
        Me.rdLeft.Text = "Left"
        '
        'rdDefault
        '
        Me.rdDefault.Checked = True
        Me.rdDefault.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdDefault.Location = New System.Drawing.Point(16, 32)
        Me.rdDefault.Name = "rdDefault"
        Me.rdDefault.Size = New System.Drawing.Size(80, 22)
        Me.rdDefault.TabIndex = 0
        Me.rdDefault.TabStop = True
        Me.rdDefault.Text = "Default"
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderCompany, Me.ColumnHeaderContact, Me.ColumnHeaderTel, Me.ColumnHeaderFAX})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        ListViewGroup1.Header = "ListViewGroup1"
        ListViewGroup1.Name = "11111"
        ListViewGroup2.Header = "ListViewGroup2"
        ListViewGroup2.Name = "22222"
        ListViewGroup3.Header = "ListViewGroup3"
        ListViewGroup3.Name = "333333"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView1.HideSelection = False
        Me.ListView1.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup2
        ListViewItem4.Group = ListViewGroup2
        ListViewItem5.Group = ListViewGroup3
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(1, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(416, 342)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.StateImageList = Me.ImageList1
        Me.ListView1.TabIndex = 10
        Me.ListView1.TileSize = New System.Drawing.Size(200, 20)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeaderCompany
        '
        Me.ColumnHeaderCompany.Text = "Company"
        Me.ColumnHeaderCompany.Width = 120
        '
        'ColumnHeaderContact
        '
        Me.ColumnHeaderContact.Text = "Contact"
        Me.ColumnHeaderContact.Width = 100
        '
        'ColumnHeaderFAX
        '
        Me.ColumnHeaderFAX.Text = "FAX"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "CRDFLE08.ICO")
        Me.ImageList1.Images.SetKeyName(1, "CRDFLE06.ICO")
        '
        'bttnIterate
        '
        Me.bttnIterate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnIterate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnIterate.Location = New System.Drawing.Point(423, 352)
        Me.bttnIterate.Name = "bttnIterate"
        Me.bttnIterate.Size = New System.Drawing.Size(128, 32)
        Me.bttnIterate.TabIndex = 13
        Me.bttnIterate.Text = "Selected Items"
        '
        'rdTile
        '
        Me.rdTile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdTile.Location = New System.Drawing.Point(16, 120)
        Me.rdTile.Name = "rdTile"
        Me.rdTile.Size = New System.Drawing.Size(96, 24)
        Me.rdTile.TabIndex = 4
        Me.rdTile.Text = "Tile"
        '
        'rdDetails
        '
        Me.rdDetails.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdDetails.Location = New System.Drawing.Point(16, 96)
        Me.rdDetails.Name = "rdDetails"
        Me.rdDetails.Size = New System.Drawing.Size(96, 24)
        Me.rdDetails.TabIndex = 3
        Me.rdDetails.Text = "Details"
        '
        'rdList
        '
        Me.rdList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdList.Location = New System.Drawing.Point(16, 72)
        Me.rdList.Name = "rdList"
        Me.rdList.Size = New System.Drawing.Size(96, 24)
        Me.rdList.TabIndex = 2
        Me.rdList.Text = "List"
        '
        'rdSmallIcons
        '
        Me.rdSmallIcons.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdSmallIcons.Location = New System.Drawing.Point(16, 48)
        Me.rdSmallIcons.Name = "rdSmallIcons"
        Me.rdSmallIcons.Size = New System.Drawing.Size(96, 24)
        Me.rdSmallIcons.TabIndex = 1
        Me.rdSmallIcons.Text = "Small Icons"
        '
        'bttnEnumerate
        '
        Me.bttnEnumerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnEnumerate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnEnumerate.Location = New System.Drawing.Point(423, 312)
        Me.bttnEnumerate.Name = "bttnEnumerate"
        Me.bttnEnumerate.Size = New System.Drawing.Size(128, 32)
        Me.bttnEnumerate.TabIndex = 14
        Me.bttnEnumerate.Text = "Enumerate List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rdTile)
        Me.GroupBox1.Controls.Add(Me.rdDetails)
        Me.GroupBox1.Controls.Add(Me.rdList)
        Me.GroupBox1.Controls.Add(Me.rdSmallIcons)
        Me.GroupBox1.Controls.Add(Me.rdIcons)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(423, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 152)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Style"
        '
        'rdIcons
        '
        Me.rdIcons.Checked = True
        Me.rdIcons.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.rdIcons.Location = New System.Drawing.Point(16, 24)
        Me.rdIcons.Name = "rdIcons"
        Me.rdIcons.Size = New System.Drawing.Size(96, 24)
        Me.rdIcons.TabIndex = 0
        Me.rdIcons.TabStop = True
        Me.rdIcons.Text = "Icons"
        '
        'bttnPopulate
        '
        Me.bttnPopulate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnPopulate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnPopulate.Location = New System.Drawing.Point(423, 272)
        Me.bttnPopulate.Name = "bttnPopulate"
        Me.bttnPopulate.Size = New System.Drawing.Size(128, 32)
        Me.bttnPopulate.TabIndex = 15
        Me.bttnPopulate.Text = "Populate List"
        '
        'bttnSave
        '
        Me.bttnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnSave.Location = New System.Drawing.Point(1, 350)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(128, 32)
        Me.bttnSave.TabIndex = 16
        Me.bttnSave.Text = "Save List"
        '
        'bttnLoad
        '
        Me.bttnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnLoad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnLoad.Location = New System.Drawing.Point(289, 352)
        Me.bttnLoad.Name = "bttnLoad"
        Me.bttnLoad.Size = New System.Drawing.Size(128, 32)
        Me.bttnLoad.TabIndex = 17
        Me.bttnLoad.Text = "Load List"
        '
        'frmListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 388)
        Me.Controls.Add(Me.bttnLoad)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bttnIterate)
        Me.Controls.Add(Me.bttnEnumerate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttnPopulate)
        Me.Name = "frmListView"
        Me.Text = "ListView Demo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeaderTel As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdTop As System.Windows.Forms.RadioButton
    Friend WithEvents rdLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rdDefault As System.Windows.Forms.RadioButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderCompany As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderContact As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderFAX As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bttnIterate As System.Windows.Forms.Button
    Friend WithEvents rdTile As System.Windows.Forms.RadioButton
    Friend WithEvents rdDetails As System.Windows.Forms.RadioButton
    Friend WithEvents rdList As System.Windows.Forms.RadioButton
    Friend WithEvents rdSmallIcons As System.Windows.Forms.RadioButton
    Friend WithEvents bttnEnumerate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdIcons As System.Windows.Forms.RadioButton
    Friend WithEvents bttnPopulate As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents bttnLoad As System.Windows.Forms.Button

End Class
