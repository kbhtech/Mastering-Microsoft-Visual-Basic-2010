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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtZIP = New System.Windows.Forms.TextBox()
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bttnEdit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 25)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LoadToolStripMenuItem.Text = "Load Customers"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.Location = New System.Drawing.Point(548, 171)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "&ZIP"
        '
        'txtZIP
        '
        Me.txtZIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtZIP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtZIP.Location = New System.Drawing.Point(550, 189)
        Me.txtZIP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.ReadOnly = True
        Me.txtZIP.Size = New System.Drawing.Size(56, 22)
        Me.txtZIP.TabIndex = 110
        '
        'bttnOK
        '
        Me.bttnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnOK.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnOK.Location = New System.Drawing.Point(484, 364)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(96, 32)
        Me.bttnOK.TabIndex = 108
        Me.bttnOK.Text = "OK"
        Me.bttnOK.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(0, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(277, 368)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 107
        '
        'bttnEdit
        '
        Me.bttnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnEdit.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnEdit.Location = New System.Drawing.Point(408, 364)
        Me.bttnEdit.Name = "bttnEdit"
        Me.bttnEdit.Size = New System.Drawing.Size(96, 32)
        Me.bttnEdit.TabIndex = 105
        Me.bttnEdit.Text = "Edit"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 175)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "&State"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(444, 221)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "&Fax"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "&Telephone"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cit&y"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "&Address"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Contact"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "&Company"
        '
        'bttnCancel
        '
        Me.bttnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCancel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(326, 364)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(96, 32)
        Me.bttnCancel.TabIndex = 106
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.Visible = False
        '
        'bttnAdd
        '
        Me.bttnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnAdd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(284, 364)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(96, 32)
        Me.bttnAdd.TabIndex = 104
        Me.bttnAdd.Text = "Add"
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtFax.Location = New System.Drawing.Point(446, 239)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(184, 22)
        Me.txtFax.TabIndex = 101
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTel.Location = New System.Drawing.Point(286, 239)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(120, 22)
        Me.txtTel.TabIndex = 99
        '
        'txtState
        '
        Me.txtState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtState.Location = New System.Drawing.Point(462, 193)
        Me.txtState.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(40, 22)
        Me.txtState.TabIndex = 97
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCity.Location = New System.Drawing.Point(286, 193)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(146, 22)
        Me.txtCity.TabIndex = 95
        '
        'txtAddress1
        '
        Me.txtAddress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(286, 143)
        Me.txtAddress1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New System.Drawing.Size(344, 22)
        Me.txtAddress1.TabIndex = 91
        '
        'txtContact
        '
        Me.txtContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContact.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtContact.Location = New System.Drawing.Point(286, 103)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(264, 22)
        Me.txtContact.TabIndex = 89
        '
        'txtCompany
        '
        Me.txtCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompany.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(362, 57)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(268, 22)
        Me.txtCompany.TabIndex = 87
        '
        'bttnDelete
        '
        Me.bttnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnDelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(526, 364)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(96, 32)
        Me.bttnDelete.TabIndex = 111
        Me.bttnDelete.Text = "Delete"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 267)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(287, 290)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(160, 22)
        Me.txtCountry.TabIndex = 113
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(284, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtID.Location = New System.Drawing.Point(287, 57)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(69, 22)
        Me.txtID.TabIndex = 115
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 397)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.bttnEdit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Contacts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents txtZIP As System.Windows.Forms.TextBox
    Friend WithEvents bttnOK As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bttnEdit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnAdd As System.Windows.Forms.Button
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox

    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Private WithEvents bttnDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox

End Class
