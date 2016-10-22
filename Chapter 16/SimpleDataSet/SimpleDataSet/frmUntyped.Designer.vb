<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUntyped
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
        Me.bttnCreateDataSet = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.bttnEdit = New System.Windows.Forms.Button
        Me.bttnSubmit = New System.Windows.Forms.Button
        Me.bttnShow = New System.Windows.Forms.Button
        Me.bttnRejectChanges = New System.Windows.Forms.Button
        Me.bttnSave = New System.Windows.Forms.Button
        Me.bttnLoad = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bttnCreateDataSet
        '
        Me.bttnCreateDataSet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCreateDataSet.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCreateDataSet.Location = New System.Drawing.Point(1, 2)
        Me.bttnCreateDataSet.Name = "bttnCreateDataSet"
        Me.bttnCreateDataSet.Size = New System.Drawing.Size(519, 41)
        Me.bttnCreateDataSet.TabIndex = 1
        Me.bttnCreateDataSet.Text = "Read Products and Related Tables"
        Me.bttnCreateDataSet.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 83)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(519, 270)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'bttnEdit
        '
        Me.bttnEdit.Enabled = False
        Me.bttnEdit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEdit.Location = New System.Drawing.Point(1, 45)
        Me.bttnEdit.Name = "bttnEdit"
        Me.bttnEdit.Size = New System.Drawing.Size(125, 32)
        Me.bttnEdit.TabIndex = 3
        Me.bttnEdit.Text = "Edit DataSet"
        Me.bttnEdit.UseVisualStyleBackColor = True
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSubmit.Enabled = False
        Me.bttnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubmit.Location = New System.Drawing.Point(392, 45)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(128, 32)
        Me.bttnSubmit.TabIndex = 6
        Me.bttnSubmit.Text = "Submit Edits"
        Me.bttnSubmit.UseVisualStyleBackColor = True
        '
        'bttnShow
        '
        Me.bttnShow.Enabled = False
        Me.bttnShow.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnShow.Location = New System.Drawing.Point(132, 45)
        Me.bttnShow.Name = "bttnShow"
        Me.bttnShow.Size = New System.Drawing.Size(125, 32)
        Me.bttnShow.TabIndex = 7
        Me.bttnShow.Text = "Show Edits"
        Me.bttnShow.UseVisualStyleBackColor = True
        '
        'bttnRejectChanges
        '
        Me.bttnRejectChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnRejectChanges.Enabled = False
        Me.bttnRejectChanges.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRejectChanges.Location = New System.Drawing.Point(1, 356)
        Me.bttnRejectChanges.Name = "bttnRejectChanges"
        Me.bttnRejectChanges.Size = New System.Drawing.Size(125, 32)
        Me.bttnRejectChanges.TabIndex = 8
        Me.bttnRejectChanges.Text = "Reject Changes"
        Me.bttnRejectChanges.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSave.Enabled = False
        Me.bttnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSave.Location = New System.Drawing.Point(264, 356)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(125, 32)
        Me.bttnSave.TabIndex = 9
        Me.bttnSave.Text = "Save DataSet"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnLoad
        '
        Me.bttnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnLoad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLoad.Location = New System.Drawing.Point(395, 356)
        Me.bttnLoad.Name = "bttnLoad"
        Me.bttnLoad.Size = New System.Drawing.Size(125, 32)
        Me.bttnLoad.TabIndex = 10
        Me.bttnLoad.Text = "Load DataSet"
        Me.bttnLoad.UseVisualStyleBackColor = True
        '
        'frmUntyped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 389)
        Me.Controls.Add(Me.bttnLoad)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.bttnRejectChanges)
        Me.Controls.Add(Me.bttnShow)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.bttnEdit)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.bttnCreateDataSet)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUntyped"
        Me.Text = "DataSet Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnCreateDataSet As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents bttnEdit As System.Windows.Forms.Button
    Friend WithEvents bttnSubmit As System.Windows.Forms.Button
    Friend WithEvents bttnShow As System.Windows.Forms.Button
    Friend WithEvents bttnRejectChanges As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents bttnLoad As System.Windows.Forms.Button

End Class
