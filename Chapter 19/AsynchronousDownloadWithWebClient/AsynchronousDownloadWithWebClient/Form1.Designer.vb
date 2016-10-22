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
        Me.bttnDownload = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnDownload
        '
        Me.bttnDownload.Location = New System.Drawing.Point(37, 49)
        Me.bttnDownload.Name = "bttnDownload"
        Me.bttnDownload.Size = New System.Drawing.Size(221, 39)
        Me.bttnDownload.TabIndex = 0
        Me.bttnDownload.Text = "Download Resource Asynchronously"
        Me.bttnDownload.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(37, 117)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(221, 39)
        Me.bttnCancel.TabIndex = 1
        Me.bttnCancel.Text = "Cancel Download"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 207)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnDownload)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnDownload As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button

End Class
