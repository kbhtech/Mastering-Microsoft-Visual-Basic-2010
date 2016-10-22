Public Class frmLBFind
    Private Sub bttnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPopulate.Click
        Dim wordLen As Integer
        Dim Nwords As Integer = 99999    ' change this value to generate a longer or shorter list

        Dim rnd As System.Random
        rnd = New System.Random
        Dim rndChar As Char
        Dim thisWord As String
        Dim i, j As Integer
        ' Disable redrawing while loading items
        ListBox1.BeginUpdate()
        ' populate the ListBox with Nwords random words
        For i = 0 To Nwords
            ' select a random length for the word (from 1 to 25 characters)
            wordLen = CInt(rnd.NextDouble * 20 + 1)
            thisWord = ""
            For j = 0 To wordLen
                ' and build the word by appending random characters 
                ' to the thisWord variable
                rndChar = Chr(65 + CInt(rnd.Next(0, 25)))
                thisWord = thisWord & rndChar
            Next
            ' add word to control's Items collection
            ListBox1.Items.Add(thisWord)
        Next
        ' we're done, refresh the ListBox control
        ListBox1.EndUpdate()
    End Sub

    Private Sub bttnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnFind.Click
        Dim srchWord As String
        Dim wordIndex As Integer
        srchWord = InputBox("Enter word to search for")
        ' Attempt to find an exact match with the FindExact method
        wordIndex = ListBox1.FindStringExact(srchWord)
        ' If an exact match was found, display the word's index in the Items collection
        If wordIndex >= 0 Then
            ListBox1.TopIndex = wordIndex
            ListBox1.SelectedIndex = wordIndex
            MsgBox("INDEX = " & wordIndex.ToString & vbCrLf & _
                   "MATCH = " & ListBox1.Items(wordIndex).ToString, , "EXACT MATCH")
        Else
            ' Otherwise go for a near match with the FindString method
            wordIndex = ListBox1.FindString(srchWord)
            If wordIndex >= 0 Then
                ListBox1.TopIndex = wordIndex
                ListBox1.SelectedIndex = wordIndex
                MsgBox("INDEX = " & wordIndex.ToString & vbCrLf & _
                       "MATCH = " & ListBox1.Items(wordIndex).ToString, , "NEAR MATCH")
            Else
                ' we should never reach this statement, because there will always 
                ' be a near match, unless the list is empty!
                MsgBox("Item " & srchWord & " is not in the list")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim srchWord As String = TextBox1.Text.Trim
        If srchWord.Length = 0 Then Exit Sub
        Dim wordIndex As Integer

        ' Attempt to find an exact match with the FindExact method
        wordIndex = ListBox1.FindStringExact(srchWord)
        ' If an exact match was found, display the word's index in the Items collection
        If wordIndex >= 0 Then
            ListBox1.TopIndex = wordIndex
            ListBox1.SelectedIndex = wordIndex
            Debug.WriteLine("EXACT MATCH AT INDEX = " & wordIndex.ToString & vbCrLf & _
                   "MATCH = " & ListBox1.Items(wordIndex).ToString)
        Else
            ' Otherwise go for a near match with the FindString method
            wordIndex = ListBox1.FindString(srchWord)
            If wordIndex >= 0 Then
                ListBox1.TopIndex = wordIndex
                ListBox1.SelectedIndex = wordIndex
                Debug.WriteLine("NEAR MATCH AT INDEX = " & wordIndex.ToString & vbCrLf & _
                       "MATCH = " & ListBox1.Items(wordIndex).ToString)
            Else
                ' we should never reach this statement, because there will always 
                ' be a near match, unless the list is empty!
                Debug.WriteLine("Item " & srchWord & " is not in the list")
            End If
        End If
    End Sub
End Class
