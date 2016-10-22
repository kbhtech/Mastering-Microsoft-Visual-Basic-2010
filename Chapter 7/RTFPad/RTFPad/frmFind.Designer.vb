<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.chkWord = New System.Windows.Forms.CheckBox
        Me.chkCase = New System.Windows.Forms.CheckBox
        Me.bttnReplaceAll = New System.Windows.Forms.Button
        Me.bttnReplace = New System.Windows.Forms.Button
        Me.bttnFindNext = New System.Windows.Forms.Button
        Me.bttnFind = New System.Windows.Forms.Button
        Me.txtReplaceWord = New System.Windows.Forms.TextBox
        Me.txtSearchWord = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'chkWord
        '
        Me.chkWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWord.Location = New System.Drawing.Point(2, 90)
        Me.chkWord.Name = "chkWord"
        Me.chkWord.Size = New System.Drawing.Size(152, 24)
        Me.chkWord.TabIndex = 15
        Me.chkWord.Text = "Whole Word Only"
        '
        'chkCase
        '
        Me.chkCase.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCase.Location = New System.Drawing.Point(2, 66)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(152, 24)
        Me.chkCase.TabIndex = 14
        Me.chkCase.Text = "Case Sensitive"
        '
        'bttnReplaceAll
        '
        Me.bttnReplaceAll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReplaceAll.Location = New System.Drawing.Point(330, 34)
        Me.bttnReplaceAll.Name = "bttnReplaceAll"
        Me.bttnReplaceAll.Size = New System.Drawing.Size(96, 23)
        Me.bttnReplaceAll.TabIndex = 13
        Me.bttnReplaceAll.Text = "Replace All"
        '
        'bttnReplace
        '
        Me.bttnReplace.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReplace.Location = New System.Drawing.Point(218, 34)
        Me.bttnReplace.Name = "bttnReplace"
        Me.bttnReplace.Size = New System.Drawing.Size(96, 23)
        Me.bttnReplace.TabIndex = 12
        Me.bttnReplace.Text = "Replace"
        '
        'bttnFindNext
        '
        Me.bttnFindNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnFindNext.Location = New System.Drawing.Point(330, 2)
        Me.bttnFindNext.Name = "bttnFindNext"
        Me.bttnFindNext.Size = New System.Drawing.Size(96, 23)
        Me.bttnFindNext.TabIndex = 11
        Me.bttnFindNext.Text = "Find Next"
        '
        'bttnFind
        '
        Me.bttnFind.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnFind.Location = New System.Drawing.Point(218, 2)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(96, 23)
        Me.bttnFind.TabIndex = 10
        Me.bttnFind.Text = "Find"
        '
        'txtReplaceWord
        '
        Me.txtReplaceWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplaceWord.Location = New System.Drawing.Point(2, 34)
        Me.txtReplaceWord.Name = "txtReplaceWord"
        Me.txtReplaceWord.Size = New System.Drawing.Size(200, 22)
        Me.txtReplaceWord.TabIndex = 9
        '
        'txtSearchWord
        '
        Me.txtSearchWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchWord.Location = New System.Drawing.Point(2, 2)
        Me.txtSearchWord.Name = "txtSearchWord"
        Me.txtSearchWord.Size = New System.Drawing.Size(200, 22)
        Me.txtSearchWord.TabIndex = 8
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 115)
        Me.Controls.Add(Me.chkWord)
        Me.Controls.Add(Me.chkCase)
        Me.Controls.Add(Me.bttnReplaceAll)
        Me.Controls.Add(Me.bttnReplace)
        Me.Controls.Add(Me.bttnFindNext)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.txtReplaceWord)
        Me.Controls.Add(Me.txtSearchWord)
        Me.Name = "frmFind"
        Me.Text = "Search & Replace"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkWord As System.Windows.Forms.CheckBox
    Friend WithEvents chkCase As System.Windows.Forms.CheckBox
    Friend WithEvents bttnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents bttnReplace As System.Windows.Forms.Button
    Friend WithEvents bttnFindNext As System.Windows.Forms.Button
    Friend WithEvents bttnFind As System.Windows.Forms.Button
    Friend WithEvents txtReplaceWord As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchWord As System.Windows.Forms.TextBox
End Class
