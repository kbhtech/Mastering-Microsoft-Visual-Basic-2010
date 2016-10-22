Public Class Form1
    Dim words() As String

    Private Sub bttnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPopulate.Click
        Dim wordLen As Integer
        ' number of words to place on the list
        Dim Nwords As Integer = 9999
        ' The words array holds the random words
        ReDim words(Nwords)

        Dim rnd As System.Random
        rnd = New System.Random()
        Dim rndChar As Char
        Dim thisWord As String
        Dim word, chr As Integer
        Dim T1, T2 As System.DateTime
        T1 = Now
        ' Generate random words and populate list
        For word = 0 To Nwords
            wordLen = CInt(rnd.Next(3, 15))
            thisWord = ""
            For chr = 0 To wordLen
                rndChar = ChrW(65 + rnd.Next(0, 25))
                thisWord = thisWord & rndChar
            Next
            words(word) = thisWord
        Next
        ' show how long it took to generate words
        T2 = Now
        MsgBox("It took " & ((T2.Ticks - T1.Ticks) / 10000).ToString & " msecs to create an array of " & Nwords.ToString & " random words")
        ' now sort the list
        T1 = Now
        ListBox1.Items.Clear()
        System.Array.Sort(words)
        ' show how long it took to sort the array with the words
        T2 = Now
        MsgBox("It took " & ((T2.Ticks - T1.Ticks) / 10000).ToString & " msecs to sort the array")
        T1 = Now
        ' now add the words to the ListBox control
        '' Comment out the calls to the BeginUpdate/EndUpdate methods
        '' to see how much faster the loading of the control takes
        '' place with these two statements. It's at least 10 times faster.
        ListBox1.BeginUpdate()
        For word = 0 To Nwords
            ListBox1.Items.Add(words(word))
        Next
        ListBox1.EndUpdate()
        ' and show how long it took to populate the control
        T2 = Now
        MsgBox("It took " & ((T2.Ticks - T1.Ticks) / 10000).ToString & " msecs to load the List Box")
    End Sub

    Private Sub bttnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearch.Click
        Dim srchWord As String      ' the word to search for
        Dim wordIndex As Integer    ' the index of the word in the list (if found)
        srchWord = InputBox("Enter word to search for").ToUpper
        ' perform a binary search to locate the word, because the list is sorted
        wordIndex = System.Array.BinarySearch(words, srchWord)
        Console.WriteLine(wordIndex)

        If wordIndex >= 0 Then  ' Zero or positive value indicates an exact match
            ListBox1.TopIndex = wordIndex
            ListBox1.SelectedIndex = wordIndex
            MsgBox("An exact match was found for the word [" & words(wordIndex) & "] at index " & wordIndex.ToString, , "EXACT MATCH")
        Else
            ' a negative value indicates a near match (the first item after the location
            ' of the item we search for, if it were in the list
            ListBox1.TopIndex = -wordIndex - 1
            ListBox1.SelectedIndex = -wordIndex - 1
            MsgBox("The nearest match is the word [" & words(-wordIndex - 1) & "] at index " & (-wordIndex - 1).ToString, , "NEAR MATCH")
        End If
    End Sub
End Class
