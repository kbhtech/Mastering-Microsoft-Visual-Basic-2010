<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliaryForm
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
        Me.bttnSetShared = New System.Windows.Forms.Button
        Me.bttnReadShared = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bttnSetShared
        '
        Me.bttnSetShared.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnSetShared.Location = New System.Drawing.Point(46, 175)
        Me.bttnSetShared.Name = "bttnSetShared"
        Me.bttnSetShared.Size = New System.Drawing.Size(192, 56)
        Me.bttnSetShared.TabIndex = 2
        Me.bttnSetShared.Text = "Set Shared Variable in Main Form"
        '
        'bttnReadShared
        '
        Me.bttnReadShared.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnReadShared.Location = New System.Drawing.Point(46, 103)
        Me.bttnReadShared.Name = "bttnReadShared"
        Me.bttnReadShared.Size = New System.Drawing.Size(192, 56)
        Me.bttnReadShared.TabIndex = 1
        Me.bttnReadShared.Text = "Read Shared Variable in Main Form"
        '
        'AuxiliaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.bttnSetShared)
        Me.Controls.Add(Me.bttnReadShared)
        Me.Name = "AuxiliaryForm"
        Me.Text = "AuxiliaryForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnSetShared As System.Windows.Forms.Button
    Friend WithEvents bttnReadShared As System.Windows.Forms.Button
End Class
