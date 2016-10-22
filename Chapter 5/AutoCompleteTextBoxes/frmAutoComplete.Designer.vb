<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoComplete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoComplete))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbFileSystem = New System.Windows.Forms.RadioButton
        Me.rbRecentList = New System.Windows.Forms.RadioButton
        Me.rbAllURL = New System.Windows.Forms.RadioButton
        Me.rbHistoryList = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbNone = New System.Windows.Forms.RadioButton
        Me.rbSuggestAppend = New System.Windows.Forms.RadioButton
        Me.rbAppend = New System.Windows.Forms.RadioButton
        Me.rbSuggest = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(2, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 50)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFileSystem)
        Me.GroupBox2.Controls.Add(Me.rbRecentList)
        Me.GroupBox2.Controls.Add(Me.rbAllURL)
        Me.GroupBox2.Controls.Add(Me.rbHistoryList)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(245, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 75)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AutoComplete Source"
        '
        'rbFileSystem
        '
        Me.rbFileSystem.AutoSize = True
        Me.rbFileSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFileSystem.Location = New System.Drawing.Point(7, 21)
        Me.rbFileSystem.Name = "rbFileSystem"
        Me.rbFileSystem.Size = New System.Drawing.Size(93, 20)
        Me.rbFileSystem.TabIndex = 18
        Me.rbFileSystem.Text = "FileSystem"
        Me.rbFileSystem.UseVisualStyleBackColor = True
        '
        'rbRecentList
        '
        Me.rbRecentList.AutoSize = True
        Me.rbRecentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecentList.Location = New System.Drawing.Point(115, 47)
        Me.rbRecentList.Name = "rbRecentList"
        Me.rbRecentList.Size = New System.Drawing.Size(92, 20)
        Me.rbRecentList.TabIndex = 17
        Me.rbRecentList.Text = "Recent List"
        Me.rbRecentList.UseVisualStyleBackColor = True
        '
        'rbAllURL
        '
        Me.rbAllURL.AutoSize = True
        Me.rbAllURL.Checked = True
        Me.rbAllURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAllURL.Location = New System.Drawing.Point(7, 47)
        Me.rbAllURL.Name = "rbAllURL"
        Me.rbAllURL.Size = New System.Drawing.Size(71, 20)
        Me.rbAllURL.TabIndex = 16
        Me.rbAllURL.TabStop = True
        Me.rbAllURL.Text = "All URL"
        Me.rbAllURL.UseVisualStyleBackColor = True
        '
        'rbHistoryList
        '
        Me.rbHistoryList.AutoSize = True
        Me.rbHistoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHistoryList.Location = New System.Drawing.Point(115, 21)
        Me.rbHistoryList.Name = "rbHistoryList"
        Me.rbHistoryList.Size = New System.Drawing.Size(88, 20)
        Me.rbHistoryList.TabIndex = 15
        Me.rbHistoryList.Text = "HistoryList"
        Me.rbHistoryList.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNone)
        Me.GroupBox1.Controls.Add(Me.rbSuggestAppend)
        Me.GroupBox1.Controls.Add(Me.rbAppend)
        Me.GroupBox1.Controls.Add(Me.rbSuggest)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 75)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AutoComplete Mode"
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNone.Location = New System.Drawing.Point(7, 21)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(59, 20)
        Me.rbNone.TabIndex = 18
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'rbSuggestAppend
        '
        Me.rbSuggestAppend.AutoSize = True
        Me.rbSuggestAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSuggestAppend.Location = New System.Drawing.Point(98, 47)
        Me.rbSuggestAppend.Name = "rbSuggestAppend"
        Me.rbSuggestAppend.Size = New System.Drawing.Size(124, 20)
        Me.rbSuggestAppend.TabIndex = 17
        Me.rbSuggestAppend.Text = "SuggestAppend"
        Me.rbSuggestAppend.UseVisualStyleBackColor = True
        '
        'rbAppend
        '
        Me.rbAppend.AutoSize = True
        Me.rbAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAppend.Location = New System.Drawing.Point(7, 47)
        Me.rbAppend.Name = "rbAppend"
        Me.rbAppend.Size = New System.Drawing.Size(74, 20)
        Me.rbAppend.TabIndex = 16
        Me.rbAppend.Text = "Append"
        Me.rbAppend.UseVisualStyleBackColor = True
        '
        'rbSuggest
        '
        Me.rbSuggest.AutoSize = True
        Me.rbSuggest.Checked = True
        Me.rbSuggest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSuggest.Location = New System.Drawing.Point(98, 21)
        Me.rbSuggest.Name = "rbSuggest"
        Me.rbSuggest.Size = New System.Drawing.Size(76, 20)
        Me.rbSuggest.TabIndex = 15
        Me.rbSuggest.TabStop = True
        Me.rbSuggest.Text = "Suggest"
        Me.rbSuggest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Select a URL or file name"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(5, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(468, 22)
        Me.TextBox2.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter a language name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 22)
        Me.TextBox1.TabIndex = 18
        '
        'frmAutoComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 274)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmAutoComplete"
        Me.Text = "AutoComplete TextBoxes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFileSystem As System.Windows.Forms.RadioButton
    Friend WithEvents rbRecentList As System.Windows.Forms.RadioButton
    Friend WithEvents rbAllURL As System.Windows.Forms.RadioButton
    Friend WithEvents rbHistoryList As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNone As System.Windows.Forms.RadioButton
    Friend WithEvents rbSuggestAppend As System.Windows.Forms.RadioButton
    Friend WithEvents rbAppend As System.Windows.Forms.RadioButton
    Friend WithEvents rbSuggest As System.Windows.Forms.RadioButton
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
