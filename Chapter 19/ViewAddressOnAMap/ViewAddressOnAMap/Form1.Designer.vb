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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtObservations = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.Label()
        Me.txtSecondLine = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.mapBrowser = New System.Windows.Forms.WebBrowser()
        Me.bttnShow = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtObservations)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.City)
        Me.GroupBox1.Controls.Add(Me.txtSecondLine)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtStreet)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(70, 186)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(40, 20)
        Me.txtZip.TabIndex = 11
        Me.txtZip.Text = "60641"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Observations:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(10, 184)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(27, 20)
        Me.txtState.TabIndex = 9
        Me.txtState.Text = "IL"
        '
        'txtObservations
        '
        Me.txtObservations.Location = New System.Drawing.Point(10, 237)
        Me.txtObservations.Multiline = True
        Me.txtObservations.Name = "txtObservations"
        Me.txtObservations.Size = New System.Drawing.Size(205, 100)
        Me.txtObservations.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "State:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(10, 134)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 7
        Me.txtCity.Text = "Chicago"
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(10, 117)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(27, 13)
        Me.City.TabIndex = 6
        Me.City.Text = "City:"
        '
        'txtSecondLine
        '
        Me.txtSecondLine.Location = New System.Drawing.Point(10, 86)
        Me.txtSecondLine.Name = "txtSecondLine"
        Me.txtSecondLine.Size = New System.Drawing.Size(205, 20)
        Me.txtSecondLine.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Second Line:"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(10, 39)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(205, 20)
        Me.txtStreet.TabIndex = 1
        Me.txtStreet.Text = "4211 North Kedvale Av."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Street:"
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(7, 382)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(94, 24)
        Me.bttnSave.TabIndex = 1
        Me.bttnSave.Text = "Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'mapBrowser
        '
        Me.mapBrowser.Location = New System.Drawing.Point(240, 12)
        Me.mapBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mapBrowser.Name = "mapBrowser"
        Me.mapBrowser.ScrollBarsEnabled = False
        Me.mapBrowser.Size = New System.Drawing.Size(534, 394)
        Me.mapBrowser.TabIndex = 2
        '
        'bttnShow
        '
        Me.bttnShow.Location = New System.Drawing.Point(134, 382)
        Me.bttnShow.Name = "bttnShow"
        Me.bttnShow.Size = New System.Drawing.Size(95, 24)
        Me.bttnShow.TabIndex = 3
        Me.bttnShow.Text = "Show"
        Me.bttnShow.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(7, 415)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 462)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.bttnShow)
        Me.Controls.Add(Me.mapBrowser)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Client Address"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents City As System.Windows.Forms.Label
    Friend WithEvents txtSecondLine As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label


    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtObservations As System.Windows.Forms.TextBox
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents mapBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents bttnShow As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
