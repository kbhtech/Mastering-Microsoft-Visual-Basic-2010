<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryEDM
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
        Me.LongestBook = New System.Windows.Forms.Button()
        Me.ListAllBooks = New System.Windows.Forms.Button()
        Me.FetchTranslators = New System.Windows.Forms.Button()
        Me.FindBookByISBN = New System.Windows.Forms.Button()
        Me.launchFinder = New System.Windows.Forms.Button()
        Me.QueryBuilder = New System.Windows.Forms.Button()
        Me.DefferedLoading = New System.Windows.Forms.Button()
        Me.ModificationForm = New System.Windows.Forms.Button()
        Me.SalesByMonth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LongestBook
        '
        Me.LongestBook.Location = New System.Drawing.Point(12, 67)
        Me.LongestBook.Name = "LongestBook"
        Me.LongestBook.Size = New System.Drawing.Size(268, 43)
        Me.LongestBook.TabIndex = 0
        Me.LongestBook.Text = "LINQ to Entities: Find the Longest Book"
        Me.LongestBook.UseVisualStyleBackColor = True
        '
        'ListAllBooks
        '
        Me.ListAllBooks.Location = New System.Drawing.Point(12, 12)
        Me.ListAllBooks.Name = "ListAllBooks"
        Me.ListAllBooks.Size = New System.Drawing.Size(268, 43)
        Me.ListAllBooks.TabIndex = 1
        Me.ListAllBooks.Text = "ObjectContext: List all Books"
        Me.ListAllBooks.UseVisualStyleBackColor = True
        '
        'FetchTranslators
        '
        Me.FetchTranslators.Location = New System.Drawing.Point(12, 123)
        Me.FetchTranslators.Name = "FetchTranslators"
        Me.FetchTranslators.Size = New System.Drawing.Size(268, 43)
        Me.FetchTranslators.TabIndex = 2
        Me.FetchTranslators.Text = "LINQ to Entities: Fetch Translators"
        Me.FetchTranslators.UseVisualStyleBackColor = True
        '
        'FindBookByISBN
        '
        Me.FindBookByISBN.Location = New System.Drawing.Point(12, 176)
        Me.FindBookByISBN.Name = "FindBookByISBN"
        Me.FindBookByISBN.Size = New System.Drawing.Size(268, 43)
        Me.FindBookByISBN.TabIndex = 3
        Me.FindBookByISBN.Text = "eSQL: Find book  by ISBN"
        Me.FindBookByISBN.UseVisualStyleBackColor = True
        '
        'launchFinder
        '
        Me.launchFinder.Location = New System.Drawing.Point(12, 235)
        Me.launchFinder.Name = "launchFinder"
        Me.launchFinder.Size = New System.Drawing.Size(268, 43)
        Me.launchFinder.TabIndex = 4
        Me.launchFinder.Text = "eSQL: Launch Dynamic Query Finder"
        Me.launchFinder.UseVisualStyleBackColor = True
        '
        'QueryBuilder
        '
        Me.QueryBuilder.Location = New System.Drawing.Point(12, 292)
        Me.QueryBuilder.Name = "QueryBuilder"
        Me.QueryBuilder.Size = New System.Drawing.Size(268, 43)
        Me.QueryBuilder.TabIndex = 5
        Me.QueryBuilder.Text = "Query Builder: Find Books by Date"
        Me.QueryBuilder.UseVisualStyleBackColor = True
        '
        'DefferedLoading
        '
        Me.DefferedLoading.Location = New System.Drawing.Point(12, 348)
        Me.DefferedLoading.Name = "DefferedLoading"
        Me.DefferedLoading.Size = New System.Drawing.Size(268, 43)
        Me.DefferedLoading.TabIndex = 6
        Me.DefferedLoading.Text = "Deffered Loading"
        Me.DefferedLoading.UseVisualStyleBackColor = True
        '
        'ModificationForm
        '
        Me.ModificationForm.Location = New System.Drawing.Point(12, 407)
        Me.ModificationForm.Name = "ModificationForm"
        Me.ModificationForm.Size = New System.Drawing.Size(268, 43)
        Me.ModificationForm.TabIndex = 7
        Me.ModificationForm.Text = "Launch Modification Form"
        Me.ModificationForm.UseVisualStyleBackColor = True
        '
        'SalesByMonth
        '
        Me.SalesByMonth.Location = New System.Drawing.Point(12, 466)
        Me.SalesByMonth.Name = "SalesByMonth"
        Me.SalesByMonth.Size = New System.Drawing.Size(268, 40)
        Me.SalesByMonth.TabIndex = 8
        Me.SalesByMonth.Text = "Launch Sales By Month Form"
        Me.SalesByMonth.UseVisualStyleBackColor = True
        '
        'QueryEDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 521)
        Me.Controls.Add(Me.SalesByMonth)
        Me.Controls.Add(Me.ModificationForm)
        Me.Controls.Add(Me.DefferedLoading)
        Me.Controls.Add(Me.QueryBuilder)
        Me.Controls.Add(Me.launchFinder)
        Me.Controls.Add(Me.FindBookByISBN)
        Me.Controls.Add(Me.FetchTranslators)
        Me.Controls.Add(Me.ListAllBooks)
        Me.Controls.Add(Me.LongestBook)
        Me.Name = "QueryEDM"
        Me.Text = "Query Entity Data Model"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LongestBook As System.Windows.Forms.Button
    Friend WithEvents ListAllBooks As System.Windows.Forms.Button
    Friend WithEvents FetchTranslators As System.Windows.Forms.Button
    Friend WithEvents FindBookByISBN As System.Windows.Forms.Button
    Friend WithEvents launchFinder As System.Windows.Forms.Button
    Friend WithEvents QueryBuilder As System.Windows.Forms.Button
    Friend WithEvents DefferedLoading As System.Windows.Forms.Button
    Friend WithEvents ModificationForm As System.Windows.Forms.Button
    Friend WithEvents SalesByMonth As System.Windows.Forms.Button

End Class
