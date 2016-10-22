<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreeView
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
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.bttnMoveTree = New System.Windows.Forms.Button
        Me.brrnClear = New System.Windows.Forms.Button
        Me.bttnPopulateSorted = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.bttnPopulate = New System.Windows.Forms.Button
        Me.bttnShapes = New System.Windows.Forms.Button
        Me.bttnColors = New System.Windows.Forms.Button
        Me.bttnCategories = New System.Windows.Forms.Button
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(1, 230)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(189, 20)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "ShowRootLines"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(1, 211)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(189, 20)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "ShowLines"
        '
        'bttnMoveTree
        '
        Me.bttnMoveTree.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnMoveTree.Location = New System.Drawing.Point(246, 211)
        Me.bttnMoveTree.Name = "bttnMoveTree"
        Me.bttnMoveTree.Size = New System.Drawing.Size(136, 30)
        Me.bttnMoveTree.TabIndex = 27
        Me.bttnMoveTree.Text = "Move Tree"
        '
        'brrnClear
        '
        Me.brrnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.brrnClear.Location = New System.Drawing.Point(246, 181)
        Me.brrnClear.Name = "brrnClear"
        Me.brrnClear.Size = New System.Drawing.Size(136, 30)
        Me.brrnClear.TabIndex = 25
        Me.brrnClear.Text = "Clear Control"
        '
        'bttnPopulateSorted
        '
        Me.bttnPopulateSorted.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnPopulateSorted.Location = New System.Drawing.Point(246, 151)
        Me.bttnPopulateSorted.Name = "bttnPopulateSorted"
        Me.bttnPopulateSorted.Size = New System.Drawing.Size(136, 30)
        Me.bttnPopulateSorted.TabIndex = 26
        Me.bttnPopulateSorted.Text = "Populate Sorted"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button5.Location = New System.Drawing.Point(246, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 30)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Sort Items"
        '
        'bttnPopulate
        '
        Me.bttnPopulate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnPopulate.Location = New System.Drawing.Point(246, 91)
        Me.bttnPopulate.Name = "bttnPopulate"
        Me.bttnPopulate.Size = New System.Drawing.Size(136, 30)
        Me.bttnPopulate.TabIndex = 23
        Me.bttnPopulate.Text = "Populate"
        '
        'bttnShapes
        '
        Me.bttnShapes.Enabled = False
        Me.bttnShapes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnShapes.Location = New System.Drawing.Point(246, 61)
        Me.bttnShapes.Name = "bttnShapes"
        Me.bttnShapes.Size = New System.Drawing.Size(136, 30)
        Me.bttnShapes.TabIndex = 22
        Me.bttnShapes.Text = "Add Shapes"
        '
        'bttnColors
        '
        Me.bttnColors.Enabled = False
        Me.bttnColors.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnColors.Location = New System.Drawing.Point(246, 31)
        Me.bttnColors.Name = "bttnColors"
        Me.bttnColors.Size = New System.Drawing.Size(136, 30)
        Me.bttnColors.TabIndex = 21
        Me.bttnColors.Text = "Add Colors"
        '
        'bttnCategories
        '
        Me.bttnCategories.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnCategories.Location = New System.Drawing.Point(246, 1)
        Me.bttnCategories.Name = "bttnCategories"
        Me.bttnCategories.Size = New System.Drawing.Size(136, 30)
        Me.bttnCategories.TabIndex = 20
        Me.bttnCategories.Text = "Add Categories"
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(1, 1)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(240, 208)
        Me.TreeView1.TabIndex = 19
        '
        'frmTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 248)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.bttnMoveTree)
        Me.Controls.Add(Me.brrnClear)
        Me.Controls.Add(Me.bttnPopulateSorted)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.bttnPopulate)
        Me.Controls.Add(Me.bttnShapes)
        Me.Controls.Add(Me.bttnColors)
        Me.Controls.Add(Me.bttnCategories)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmTreeView"
        Me.Text = "TreeView Demo"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Private WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Private WithEvents bttnMoveTree As System.Windows.Forms.Button
    Private WithEvents brrnClear As System.Windows.Forms.Button
    Private WithEvents bttnPopulateSorted As System.Windows.Forms.Button
    Private WithEvents Button5 As System.Windows.Forms.Button
    Private WithEvents bttnPopulate As System.Windows.Forms.Button
    Private WithEvents bttnShapes As System.Windows.Forms.Button
    Private WithEvents bttnColors As System.Windows.Forms.Button
    Private WithEvents bttnCategories As System.Windows.Forms.Button
    Private WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
