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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode5, TreeNode6, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node19")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node20")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node23")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node21", New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node24")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node25")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node22", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node26")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node27")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node28")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node29")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode26, TreeNode29})
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item 1", "Item 1-1", "Item 1-2", "Item 1-3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item 3", "Item 3-1", "Item 3-2", "Item 3-3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item 2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item 4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item 5", "Item 5-1", "Item 5-2", "Item 5-3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "Node3"
        TreeNode2.Name = "Node4"
        TreeNode2.Text = "Node4"
        TreeNode3.Name = "Node13"
        TreeNode3.Text = "Node13"
        TreeNode4.Name = "Node14"
        TreeNode4.Text = "Node14"
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Node5"
        TreeNode6.Name = "Node11"
        TreeNode6.Text = "Node11"
        TreeNode7.Name = "Node15"
        TreeNode7.Text = "Node15"
        TreeNode8.Name = "Node16"
        TreeNode8.Text = "Node16"
        TreeNode9.Name = "Node12"
        TreeNode9.Text = "Node12"
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "Node0"
        TreeNode11.Name = "Node17"
        TreeNode11.Text = "Node17"
        TreeNode12.Name = "Node18"
        TreeNode12.Text = "Node18"
        TreeNode13.Name = "Node6"
        TreeNode13.Text = "Node6"
        TreeNode14.Name = "Node19"
        TreeNode14.Text = "Node19"
        TreeNode15.Name = "Node20"
        TreeNode15.Text = "Node20"
        TreeNode16.Name = "Node7"
        TreeNode16.Text = "Node7"
        TreeNode17.Name = "Node1"
        TreeNode17.Text = "Node1"
        TreeNode18.Name = "Node23"
        TreeNode18.Text = "Node23"
        TreeNode19.Name = "Node21"
        TreeNode19.Text = "Node21"
        TreeNode20.Name = "Node24"
        TreeNode20.Text = "Node24"
        TreeNode21.Name = "Node25"
        TreeNode21.Text = "Node25"
        TreeNode22.Name = "Node22"
        TreeNode22.Text = "Node22"
        TreeNode23.Name = "Node8"
        TreeNode23.Text = "Node8"
        TreeNode24.Name = "Node26"
        TreeNode24.Text = "Node26"
        TreeNode25.Name = "Node27"
        TreeNode25.Text = "Node27"
        TreeNode26.Name = "Node9"
        TreeNode26.Text = "Node9"
        TreeNode27.Name = "Node28"
        TreeNode27.Text = "Node28"
        TreeNode28.Name = "Node29"
        TreeNode28.Text = "Node29"
        TreeNode29.Name = "Node10"
        TreeNode29.Text = "Node10"
        TreeNode30.Name = "Node2"
        TreeNode30.Text = "Node2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode17, TreeNode30})
        Me.TreeView1.Size = New System.Drawing.Size(157, 266)
        Me.TreeView1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView1.Location = New System.Drawing.Point(157, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(303, 266)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Column1"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Column2"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Column3"
        Me.ColumnHeader3.Width = 68
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Column4"
        Me.ColumnHeader4.Width = 69
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 266)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form1"
        Me.Text = "Docking Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
