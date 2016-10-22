<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyData
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
        Me.InsertNewLanguage = New System.Windows.Forms.Button()
        Me.DeleteLanguage = New System.Windows.Forms.Button()
        Me.UpdateLanguage = New System.Windows.Forms.Button()
        Me.InsertsInTransaction = New System.Windows.Forms.Button()
        Me.ExternalOperationTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InsertNewLanguage
        '
        Me.InsertNewLanguage.Location = New System.Drawing.Point(12, 12)
        Me.InsertNewLanguage.Name = "InsertNewLanguage"
        Me.InsertNewLanguage.Size = New System.Drawing.Size(268, 43)
        Me.InsertNewLanguage.TabIndex = 2
        Me.InsertNewLanguage.Text = "Insert New Language"
        Me.InsertNewLanguage.UseVisualStyleBackColor = True
        '
        'DeleteLanguage
        '
        Me.DeleteLanguage.Location = New System.Drawing.Point(12, 63)
        Me.DeleteLanguage.Name = "DeleteLanguage"
        Me.DeleteLanguage.Size = New System.Drawing.Size(268, 43)
        Me.DeleteLanguage.TabIndex = 3
        Me.DeleteLanguage.Text = "Delete Language"
        Me.DeleteLanguage.UseVisualStyleBackColor = True
        '
        'UpdateLanguage
        '
        Me.UpdateLanguage.Location = New System.Drawing.Point(12, 114)
        Me.UpdateLanguage.Name = "UpdateLanguage"
        Me.UpdateLanguage.Size = New System.Drawing.Size(268, 43)
        Me.UpdateLanguage.TabIndex = 4
        Me.UpdateLanguage.Text = "Update Language"
        Me.UpdateLanguage.UseVisualStyleBackColor = True
        '
        'InsertsInTransaction
        '
        Me.InsertsInTransaction.Location = New System.Drawing.Point(12, 165)
        Me.InsertsInTransaction.Name = "InsertsInTransaction"
        Me.InsertsInTransaction.Size = New System.Drawing.Size(268, 43)
        Me.InsertsInTransaction.TabIndex = 5
        Me.InsertsInTransaction.Text = "Multiple Inserts in Transaction"
        Me.InsertsInTransaction.UseVisualStyleBackColor = True
        '
        'ExternalOperationTransaction
        '
        Me.ExternalOperationTransaction.Location = New System.Drawing.Point(12, 217)
        Me.ExternalOperationTransaction.Name = "ExternalOperationTransaction"
        Me.ExternalOperationTransaction.Size = New System.Drawing.Size(268, 43)
        Me.ExternalOperationTransaction.TabIndex = 6
        Me.ExternalOperationTransaction.Text = "External Operations in Transaction"
        Me.ExternalOperationTransaction.UseVisualStyleBackColor = True
        '
        'ModifyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.ExternalOperationTransaction)
        Me.Controls.Add(Me.InsertsInTransaction)
        Me.Controls.Add(Me.UpdateLanguage)
        Me.Controls.Add(Me.DeleteLanguage)
        Me.Controls.Add(Me.InsertNewLanguage)
        Me.Name = "ModifyData"
        Me.Text = "Modifying the Data"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InsertNewLanguage As System.Windows.Forms.Button
    Friend WithEvents DeleteLanguage As System.Windows.Forms.Button
    Friend WithEvents UpdateLanguage As System.Windows.Forms.Button
    Friend WithEvents InsertsInTransaction As System.Windows.Forms.Button
    Friend WithEvents ExternalOperationTransaction As System.Windows.Forms.Button
End Class
