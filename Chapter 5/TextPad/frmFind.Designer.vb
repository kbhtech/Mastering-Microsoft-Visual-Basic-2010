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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.replaceWord = New System.Windows.Forms.TextBox
        Me.chkCase = New System.Windows.Forms.CheckBox
        Me.bttnReplaceAll = New System.Windows.Forms.Button
        Me.bttnReplace = New System.Windows.Forms.Button
        Me.bttnFindNext = New System.Windows.Forms.Button
        Me.bttnFind = New System.Windows.Forms.Button
        Me.searchWord = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Replace With"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search For"
        '
        'replaceWord
        '
        Me.replaceWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.replaceWord.Location = New System.Drawing.Point(6, 80)
        Me.replaceWord.Name = "replaceWord"
        Me.replaceWord.Size = New System.Drawing.Size(240, 22)
        Me.replaceWord.TabIndex = 30
        '
        'chkCase
        '
        Me.chkCase.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkCase.Location = New System.Drawing.Point(6, 102)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(160, 16)
        Me.chkCase.TabIndex = 31
        Me.chkCase.Text = "Case Sensitive"
        '
        'bttnReplaceAll
        '
        Me.bttnReplaceAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnReplaceAll.Location = New System.Drawing.Point(356, 74)
        Me.bttnReplaceAll.Name = "bttnReplaceAll"
        Me.bttnReplaceAll.Size = New System.Drawing.Size(96, 32)
        Me.bttnReplaceAll.TabIndex = 35
        Me.bttnReplaceAll.Text = "Replace All"
        '
        'bttnReplace
        '
        Me.bttnReplace.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnReplace.Location = New System.Drawing.Point(252, 74)
        Me.bttnReplace.Name = "bttnReplace"
        Me.bttnReplace.Size = New System.Drawing.Size(96, 32)
        Me.bttnReplace.TabIndex = 34
        Me.bttnReplace.Text = "Replace"
        '
        'bttnFindNext
        '
        Me.bttnFindNext.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnFindNext.Location = New System.Drawing.Point(355, 21)
        Me.bttnFindNext.Name = "bttnFindNext"
        Me.bttnFindNext.Size = New System.Drawing.Size(96, 32)
        Me.bttnFindNext.TabIndex = 33
        Me.bttnFindNext.Text = "Find Next"
        '
        'bttnFind
        '
        Me.bttnFind.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnFind.Location = New System.Drawing.Point(251, 21)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(96, 32)
        Me.bttnFind.TabIndex = 32
        Me.bttnFind.Text = "Find"
        '
        'searchWord
        '
        Me.searchWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.searchWord.Location = New System.Drawing.Point(5, 27)
        Me.searchWord.Name = "searchWord"
        Me.searchWord.Size = New System.Drawing.Size(240, 22)
        Me.searchWord.TabIndex = 28
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 122)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.replaceWord)
        Me.Controls.Add(Me.chkCase)
        Me.Controls.Add(Me.bttnReplaceAll)
        Me.Controls.Add(Me.bttnReplace)
        Me.Controls.Add(Me.bttnFindNext)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.searchWord)
        Me.Name = "frmFind"
        Me.Text = "frmFind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents replaceWord As System.Windows.Forms.TextBox
    Private WithEvents chkCase As System.Windows.Forms.CheckBox
    Private WithEvents bttnReplaceAll As System.Windows.Forms.Button
    Private WithEvents bttnReplace As System.Windows.Forms.Button
    Private WithEvents bttnFindNext As System.Windows.Forms.Button
    Private WithEvents bttnFind As System.Windows.Forms.Button
    Public WithEvents searchWord As System.Windows.Forms.TextBox
End Class
