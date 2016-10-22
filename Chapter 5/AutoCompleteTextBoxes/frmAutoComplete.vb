Public Class frmAutoComplete
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set up Autocomplete properties for the top TextBox
        Dim knownWords As New AutoCompleteStringCollection
        knownWords.Add("Visual Basic 2010")
        knownWords.Add("Visual Basic 2008")
        knownWords.Add("Visual Basic .NET")
        knownWords.Add("Visual Basic 6")
        knownWords.Add("Visual Basic 3")
        knownWords.Add("Framework")
        TextBox1.AutoCompleteCustomSource = knownWords
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ' Set up Autocomplete properties for the bottom TextBox
        TextBox2.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList
        TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub rbFileSystem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFileSystem.CheckedChanged, rbAllURL.CheckedChanged, rbHistoryList.CheckedChanged, rbRecentList.CheckedChanged
        If rbAllURL.Checked Then TextBox2.AutoCompleteSource = AutoCompleteSource.AllUrl
        If rbFileSystem.Checked Then TextBox2.AutoCompleteSource = AutoCompleteSource.FileSystem
        If rbHistoryList.Checked Then TextBox2.AutoCompleteSource = AutoCompleteSource.HistoryList
        If rbRecentList.Checked Then TextBox2.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList
    End Sub

    Private Sub rbNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbNone.Checked Then
            TextBox1.AutoCompleteMode = AutoCompleteMode.None
            TextBox2.AutoCompleteMode = AutoCompleteMode.None
        End If
    End Sub

    Private Sub rbSuggest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSuggest.CheckedChanged
        If rbSuggest.Checked Then
            TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
            TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub rbAppend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAppend.CheckedChanged
        If rbAppend.Checked Then
            TextBox1.AutoCompleteMode = AutoCompleteMode.Append
            TextBox2.AutoCompleteMode = AutoCompleteMode.Append
        End If
    End Sub

    Private Sub rbSuggestAppend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSuggestAppend.CheckedChanged
        If rbSuggestAppend.Checked Then
            TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            TextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End If
    End Sub
End Class
