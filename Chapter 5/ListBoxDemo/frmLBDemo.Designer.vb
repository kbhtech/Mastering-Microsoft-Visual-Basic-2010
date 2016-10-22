<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLBDemo
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbSelectExtended = New System.Windows.Forms.RadioButton
        Me.rbSelectSimple = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttnDestinationRemove = New System.Windows.Forms.Button
        Me.bttnSourceRemove = New System.Windows.Forms.Button
        Me.bttnDestinationClear = New System.Windows.Forms.Button
        Me.bttnSourceClear = New System.Windows.Forms.Button
        Me.btttnDestinationAdd = New System.Windows.Forms.Button
        Me.bttnSourceAdd = New System.Windows.Forms.Button
        Me.bttnDestinationMoveAll = New System.Windows.Forms.Button
        Me.bttnDestinationMove = New System.Windows.Forms.Button
        Me.bttnSourceMove = New System.Windows.Forms.Button
        Me.bttnSourceMoveAll = New System.Windows.Forms.Button
        Me.destinationList = New System.Windows.Forms.ListBox
        Me.sourceList = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 14)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Selection Mode"
        '
        'rbSelectExtended
        '
        Me.rbSelectExtended.AutoSize = True
        Me.rbSelectExtended.Location = New System.Drawing.Point(148, 363)
        Me.rbSelectExtended.Name = "rbSelectExtended"
        Me.rbSelectExtended.Size = New System.Drawing.Size(114, 18)
        Me.rbSelectExtended.TabIndex = 51
        Me.rbSelectExtended.TabStop = True
        Me.rbSelectExtended.Text = "MultiExtended"
        Me.rbSelectExtended.UseVisualStyleBackColor = True
        '
        'rbSelectSimple
        '
        Me.rbSelectSimple.AutoSize = True
        Me.rbSelectSimple.Checked = True
        Me.rbSelectSimple.Location = New System.Drawing.Point(36, 363)
        Me.rbSelectSimple.Name = "rbSelectSimple"
        Me.rbSelectSimple.Size = New System.Drawing.Size(95, 18)
        Me.rbSelectSimple.TabIndex = 50
        Me.rbSelectSimple.TabStop = True
        Me.rbSelectSimple.Text = "MultiSimple"
        Me.rbSelectSimple.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 34)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Sorted, Single-Selection List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 34)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Unsorted, Multi-Selection  List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttnDestinationRemove
        '
        Me.bttnDestinationRemove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDestinationRemove.Location = New System.Drawing.Point(238, 263)
        Me.bttnDestinationRemove.Name = "bttnDestinationRemove"
        Me.bttnDestinationRemove.Size = New System.Drawing.Size(177, 32)
        Me.bttnDestinationRemove.TabIndex = 44
        Me.bttnDestinationRemove.Text = "Remove Selected Item"
        '
        'bttnSourceRemove
        '
        Me.bttnSourceRemove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSourceRemove.Location = New System.Drawing.Point(3, 263)
        Me.bttnSourceRemove.Name = "bttnSourceRemove"
        Me.bttnSourceRemove.Size = New System.Drawing.Size(176, 32)
        Me.bttnSourceRemove.TabIndex = 43
        Me.bttnSourceRemove.Text = "Remove Selected Items"
        '
        'bttnDestinationClear
        '
        Me.bttnDestinationClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDestinationClear.Location = New System.Drawing.Point(238, 295)
        Me.bttnDestinationClear.Name = "bttnDestinationClear"
        Me.bttnDestinationClear.Size = New System.Drawing.Size(177, 32)
        Me.bttnDestinationClear.TabIndex = 45
        Me.bttnDestinationClear.Text = "Clear"
        '
        'bttnSourceClear
        '
        Me.bttnSourceClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSourceClear.Location = New System.Drawing.Point(3, 295)
        Me.bttnSourceClear.Name = "bttnSourceClear"
        Me.bttnSourceClear.Size = New System.Drawing.Size(176, 32)
        Me.bttnSourceClear.TabIndex = 47
        Me.bttnSourceClear.Text = "Clear"
        '
        'btttnDestinationAdd
        '
        Me.btttnDestinationAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btttnDestinationAdd.Location = New System.Drawing.Point(238, 231)
        Me.btttnDestinationAdd.Name = "btttnDestinationAdd"
        Me.btttnDestinationAdd.Size = New System.Drawing.Size(177, 32)
        Me.btttnDestinationAdd.TabIndex = 46
        Me.btttnDestinationAdd.Text = "Add Item"
        '
        'bttnSourceAdd
        '
        Me.bttnSourceAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSourceAdd.Location = New System.Drawing.Point(3, 231)
        Me.bttnSourceAdd.Name = "bttnSourceAdd"
        Me.bttnSourceAdd.Size = New System.Drawing.Size(176, 32)
        Me.bttnSourceAdd.TabIndex = 42
        Me.bttnSourceAdd.Text = "Add Item"
        '
        'bttnDestinationMoveAll
        '
        Me.bttnDestinationMoveAll.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDestinationMoveAll.Location = New System.Drawing.Point(188, 177)
        Me.bttnDestinationMoveAll.Name = "bttnDestinationMoveAll"
        Me.bttnDestinationMoveAll.Size = New System.Drawing.Size(40, 32)
        Me.bttnDestinationMoveAll.TabIndex = 39
        Me.bttnDestinationMoveAll.Text = "<<"
        '
        'bttnDestinationMove
        '
        Me.bttnDestinationMove.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDestinationMove.Location = New System.Drawing.Point(188, 129)
        Me.bttnDestinationMove.Name = "bttnDestinationMove"
        Me.bttnDestinationMove.Size = New System.Drawing.Size(40, 32)
        Me.bttnDestinationMove.TabIndex = 38
        Me.bttnDestinationMove.Text = "<"
        '
        'bttnSourceMove
        '
        Me.bttnSourceMove.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSourceMove.Location = New System.Drawing.Point(188, 89)
        Me.bttnSourceMove.Name = "bttnSourceMove"
        Me.bttnSourceMove.Size = New System.Drawing.Size(40, 32)
        Me.bttnSourceMove.TabIndex = 41
        Me.bttnSourceMove.Text = ">"
        '
        'bttnSourceMoveAll
        '
        Me.bttnSourceMoveAll.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSourceMoveAll.Location = New System.Drawing.Point(188, 49)
        Me.bttnSourceMoveAll.Name = "bttnSourceMoveAll"
        Me.bttnSourceMoveAll.Size = New System.Drawing.Size(40, 32)
        Me.bttnSourceMoveAll.TabIndex = 40
        Me.bttnSourceMoveAll.Text = ">>"
        '
        'destinationList
        '
        Me.destinationList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destinationList.ItemHeight = 14
        Me.destinationList.Location = New System.Drawing.Point(240, 41)
        Me.destinationList.Name = "destinationList"
        Me.destinationList.Size = New System.Drawing.Size(177, 186)
        Me.destinationList.Sorted = True
        Me.destinationList.TabIndex = 37
        '
        'sourceList
        '
        Me.sourceList.DisplayMember = "G"
        Me.sourceList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceList.ItemHeight = 14
        Me.sourceList.Location = New System.Drawing.Point(3, 41)
        Me.sourceList.Name = "sourceList"
        Me.sourceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.sourceList.Size = New System.Drawing.Size(176, 186)
        Me.sourceList.TabIndex = 36
        Me.sourceList.ValueMember = "G"
        '
        'frmLBDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 399)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbSelectExtended)
        Me.Controls.Add(Me.rbSelectSimple)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnDestinationRemove)
        Me.Controls.Add(Me.bttnSourceRemove)
        Me.Controls.Add(Me.bttnDestinationClear)
        Me.Controls.Add(Me.bttnSourceClear)
        Me.Controls.Add(Me.btttnDestinationAdd)
        Me.Controls.Add(Me.bttnSourceAdd)
        Me.Controls.Add(Me.bttnDestinationMoveAll)
        Me.Controls.Add(Me.bttnDestinationMove)
        Me.Controls.Add(Me.bttnSourceMove)
        Me.Controls.Add(Me.bttnSourceMoveAll)
        Me.Controls.Add(Me.destinationList)
        Me.Controls.Add(Me.sourceList)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmLBDemo"
        Me.Text = "ListBox Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbSelectExtended As System.Windows.Forms.RadioButton
    Friend WithEvents rbSelectSimple As System.Windows.Forms.RadioButton
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents bttnDestinationRemove As System.Windows.Forms.Button
    Private WithEvents bttnSourceRemove As System.Windows.Forms.Button
    Private WithEvents bttnDestinationClear As System.Windows.Forms.Button
    Private WithEvents bttnSourceClear As System.Windows.Forms.Button
    Private WithEvents btttnDestinationAdd As System.Windows.Forms.Button
    Private WithEvents bttnSourceAdd As System.Windows.Forms.Button
    Private WithEvents bttnDestinationMoveAll As System.Windows.Forms.Button
    Private WithEvents bttnDestinationMove As System.Windows.Forms.Button
    Private WithEvents bttnSourceMove As System.Windows.Forms.Button
    Private WithEvents bttnSourceMoveAll As System.Windows.Forms.Button
    Private WithEvents destinationList As System.Windows.Forms.ListBox
    Private WithEvents sourceList As System.Windows.Forms.ListBox

End Class
