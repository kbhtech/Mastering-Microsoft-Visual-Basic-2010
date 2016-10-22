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
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtZIP = New System.Windows.Forms.TextBox()
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bttnEdit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(656, 25)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.Location = New System.Drawing.Point(570, 198)
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
        Me.txtZIP.Location = New System.Drawing.Point(572, 216)
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
        Me.bttnOK.Location = New System.Drawing.Point(506, 350)
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
        Me.ListBox1.Location = New System.Drawing.Point(12, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(280, 354)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 107
        '
        'bttnEdit
        '
        Me.bttnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnEdit.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnEdit.Location = New System.Drawing.Point(430, 350)
        Me.bttnEdit.Name = "bttnEdit"
        Me.bttnEdit.Size = New System.Drawing.Size(96, 32)
        Me.bttnEdit.TabIndex = 105
        Me.bttnEdit.Text = "Edit"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(482, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "&State"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 298)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "&URL"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(466, 250)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "&EMail"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 250)
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
        Me.Label5.Location = New System.Drawing.Point(306, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cit&y"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Address &2"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Address &1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 74)
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
        Me.Label1.Location = New System.Drawing.Point(305, 26)
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
        Me.bttnCancel.Location = New System.Drawing.Point(348, 350)
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
        Me.bttnAdd.Location = New System.Drawing.Point(306, 350)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(96, 32)
        Me.bttnAdd.TabIndex = 104
        Me.bttnAdd.Text = "Add"
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtURL.Location = New System.Drawing.Point(308, 316)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.ReadOnly = True
        Me.txtURL.Size = New System.Drawing.Size(328, 22)
        Me.txtURL.TabIndex = 103
        '
        'txtEMail
        '
        Me.txtEMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEMail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtEMail.Location = New System.Drawing.Point(468, 268)
        Me.txtEMail.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.ReadOnly = True
        Me.txtEMail.Size = New System.Drawing.Size(184, 22)
        Me.txtEMail.TabIndex = 101
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTel.Location = New System.Drawing.Point(308, 268)
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
        Me.txtState.Location = New System.Drawing.Point(484, 220)
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
        Me.txtCity.Location = New System.Drawing.Point(308, 220)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(100, 22)
        Me.txtCity.TabIndex = 95
        '
        'txtAddress2
        '
        Me.txtAddress2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(308, 172)
        Me.txtAddress2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New System.Drawing.Size(344, 22)
        Me.txtAddress2.TabIndex = 93
        '
        'txtAddress1
        '
        Me.txtAddress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(308, 132)
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
        Me.txtContact.Location = New System.Drawing.Point(308, 92)
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
        Me.txtCompany.Location = New System.Drawing.Point(308, 45)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(320, 22)
        Me.txtCompany.TabIndex = 87
        '
        'bttnDelete
        '
        Me.bttnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnDelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(548, 350)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(96, 32)
        Me.bttnDelete.TabIndex = 111
        Me.bttnDelete.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 385)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.bttnEdit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
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
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents txtZIP As System.Windows.Forms.TextBox
    Friend WithEvents bttnOK As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bttnEdit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnAdd As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Private WithEvents bttnDelete As System.Windows.Forms.Button

End Class
