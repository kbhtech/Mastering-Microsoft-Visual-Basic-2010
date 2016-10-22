Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
' Must add the following reference to the project:
'    System.Runtime.Serialization.Formatters.Soap
Imports System.Runtime.Serialization.Formatters

Public Class frmWords
    Dim WordFrequencies As New Hashtable

    Private Sub bttnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRead.Click
        ' prompt for text file
        OpenFileDialog1.DefaultExt = "TXT"
        OpenFileDialog1.Filter = "Text|*.TXT|All Files|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim str As StreamReader
            ' establish a StreamReader object to the file
            str = File.OpenText(OpenFileDialog1.FileName)

            Dim txtLine As String
            Dim Words() As String
            ' these are the common word delimiters
            Dim Delimiters() As Char = {CType(" ", Char), CType(".", Char), _
                                CType(",", Char), CType("?", Char), _
                                CType("!", Char), CType(";", Char), _
                                CType(":", Char), Chr(10), Chr(13), vbTab}
            Me.Text = "Calculating word count..."
            Me.Cursor = Cursors.WaitCursor
            ' read text and store into txtLine variable
            txtLine = str.ReadToEnd
            ' break text into individual words and store them into the Words array
            Words = txtLine.Split(Delimiters)
            Dim uniqueWords As Integer
            Dim iword As Integer, word As String
            ' iterate through all the words and add the unique ones to the SortedList
            ' Each word is a key for the word's count
            For iword = 0 To Words.GetUpperBound(0)
                word = Words(iword).ToUpper
                If IsValidWord(word) Then
                    ' if word is in the list already, increase its count by 1
                    ' if not, add the word and set its count to 1
                    If Not WordFrequencies.ContainsKey(word) Then
                        WordFrequencies.Add(word, 1)
                        uniqueWords += 1
                    Else
                        WordFrequencies(word) = CType(WordFrequencies(word), Integer) + 1
                    End If
                End If
            Next
            Me.Text = "Word Frequencies"
            Me.Cursor = Cursors.Default
            MsgBox("Read " & Words.Length & " words and found " & _
                        uniqueWords & " unique words")
            RichTextBox1.Clear()
        End If
    End Sub

    ' This function returns False is the word passed as argument is invalid
    ' Valid words are made up of letters ("alter-ego" is not a valid word, for example)
    Protected Function IsValidWord(ByVal word As String) As Boolean
        If Trim(word).Length = 0 Then
            Return (False)
        End If
        Dim ch As Char
        Dim iChar As Integer
        For iChar = 0 To Len(word) - 1
            ch = word.Chars(iChar)
            If Not System.Char.IsLetter(ch) Then
                Return (False)
            End If
        Next
        Return (True)
    End Function

    Private Sub bttnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCount.Click
        Dim wEnum As IDictionaryEnumerator
        Dim allWords As New System.Text.StringBuilder
        ' iterate through the list and display words and their count
        wEnum = WordFrequencies.GetEnumerator
        While wEnum.MoveNext
            allWords.Append(wEnum.Key.ToString & vbTab & "-->" & vbTab & wEnum.Value.ToString & vbCrLf)
        End While
        RichTextBox1.Text = allWords.ToString
    End Sub

    Private Sub bttnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSort.Click
        Dim wEnum As IDictionaryEnumerator
        Dim Words(WordFrequencies.Count) As String
        Dim Frequencies(WordFrequencies.Count) As Double
        Dim allWords As New System.Text.StringBuilder
        Dim i, totCount As Integer
        ' iterate through the list and calculateword frequencies
        wEnum = WordFrequencies.GetEnumerator
        While wEnum.MoveNext
            Words(i) = CType(wEnum.Key, String)
            Frequencies(i) = CType(wEnum.Value, Integer)
            totCount = totCount + Convert.ToInt32(Frequencies(i))
            i = i + 1
        End While
        ' display words and their frequencies
        For i = 0 To Words.GetUpperBound(0)
            Frequencies(i) = Frequencies(i) / totCount
        Next
        Array.Sort(Frequencies, Words)
        RichTextBox1.Clear()
        For i = Words.GetUpperBound(0) To 0 Step -1
            allWords.Append(Words(i) & vbTab & "-->" & vbTab & Format(100 * Frequencies(i), "#.000") & vbCrLf)
        Next
        RichTextBox1.Text = allWords.ToString
    End Sub

    Private Sub SaveText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveXMLToolStripMenuItem.Click
        If RichTextBox1.Text.Trim.Length = 0 Then
            MsgBox("There's nothing to save!")
            Exit Sub
        End If
        Dim saveFile As FileStream
        SaveFileDialog1.DefaultExt = "XML"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            saveFile = File.OpenWrite(SaveFileDialog1.FileName)
            saveFile.Seek(0, SeekOrigin.End)
            Dim Formatter As Soap.SoapFormatter = New Soap.SoapFormatter
            Formatter.Serialize(saveFile, WordFrequencies)
            saveFile.Close()
            MsgBox("File saved")
        End If
    End Sub

    Private Sub LoadBinary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBinaryToolStripMenuItem.Click
        Dim readFile As FileStream
        OpenFileDialog1.DefaultExt = "BIN"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            readFile = File.OpenRead(OpenFileDialog1.FileName)
            Dim BFormatter As BinaryFormatter
            BFormatter = New BinaryFormatter
            WordFrequencies = CType(BFormatter.Deserialize(readFile), Hashtable)
            readFile.Close()
            MsgBox("Read " & WordFrequencies.Count & " words and their counts ")
        End If
    End Sub

    Private Sub SaveBin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBinaryToolStripMenuItem.Click
        If RichTextBox1.Text.Trim.Length = 0 Then
            MsgBox("There's nothing to save!")
            Exit Sub
        End If
        Dim saveFile As FileStream
        SaveFileDialog1.DefaultExt = "BIN"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            saveFile = File.OpenWrite(SaveFileDialog1.FileName)
            saveFile.Seek(0, SeekOrigin.End)
            Dim Formatter As BinaryFormatter = New BinaryFormatter
            Formatter.Serialize(saveFile, WordFrequencies)
            saveFile.Close()
            MsgBox("File saved")
        End If
    End Sub

    Private Sub LoadText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadXMLToolStripMenuItem.Click
        Dim readFile As FileStream
        OpenFileDialog1.DefaultExt = "XML"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            readFile = File.OpenRead(OpenFileDialog1.FileName)
            Dim Formatter As Soap.SoapFormatter
            Formatter = New Soap.SoapFormatter
            WordFrequencies = CType(Formatter.Deserialize(readFile), Hashtable)
            readFile.Close()
            MsgBox("Read " & WordFrequencies.Count & " words and their counts ")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabs() As Integer = {120, 180, 200}
        RichTextBox1.SelectionTabs = Tabs
    End Sub
End Class
