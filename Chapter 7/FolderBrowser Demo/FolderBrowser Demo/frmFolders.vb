Public Class frmFolders
    Private Sub bttnSelectFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSelectFiles.Click
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowNewFolderButton = False
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Clear()
            Me.Cursor = Cursors.WaitCursor
            Application.DoEvents()
            ' Retrieve initial folder
            Dim InitialFolder As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            ' and print its name (no indentation for top item)
            PrintFolderName(InitialFolder, "")
            ' and then print the files in the top folder
            If InitialFolder.GetFiles("*.*").Length = 0 Then
                SwitchToItalics()
                RichTextBox1.AppendText("folder contains no files" & vbCrLf)
                SwitchToRegular()
            Else
                PrintFileNames(InitialFolder, "")
            End If
            Dim DI As IO.DirectoryInfo
            ' Iterate through every subfolder and print it
            For Each DI In InitialFolder.GetDirectories
                PrintDirectory(DI)
            Next
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintDirectory(ByVal CurrentDir As IO.DirectoryInfo)
        Static IndentationLevel As Integer = 0
        IndentationLevel += 1
        ' Build the indentation string for current level
        Dim indentationString As String = ""
        indentationString = New String(Convert.ToChar(vbTab), IndentationLevel)
        ' Print the current folder's name
        PrintFolderName(CurrentDir, indentationString)
        ' Then iterate through the files in the current folder
        ' and print their names. File names are indented as much
        ' as their parent folder name
        If CurrentDir.GetFiles("*.*").Length = 0 Then
            SwitchToItalics()
            RichTextBox1.AppendText(indentationString & "folder contains no files" & vbCrLf)
            SwitchToRegular()
        Else
            PrintFileNames(CurrentDir, indentationString)
        End If
        ' Now iterate through the current folder's subfolders
        ' and print them
        Dim folder As IO.DirectoryInfo
        For Each folder In CurrentDir.GetDirectories
            PrintDirectory(folder)
        Next
        ' we're about to exit current folder, so decrease the
        ' current indentation by one level
        IndentationLevel -= 1
    End Sub

    Private Sub PrintFolderName(ByVal folder As IO.DirectoryInfo, ByVal Indentation As String)
        SwitchToBold()
        RichTextBox1.AppendText(Indentation)
        RichTextBox1.AppendText(folder.Name & vbCrLf)
        SwitchToRegular()
    End Sub

    Private Sub PrintFileNames(ByVal folder As IO.DirectoryInfo, ByVal indentation As String)
        Dim file As IO.FileInfo
        For Each file In folder.GetFiles("*.*")
            RichTextBox1.AppendText(indentation & file.Name & vbCrLf)
        Next
    End Sub

    Private Sub SwitchToItalics()
        RichTextBox1.SelectionFont = New Font( _
                    RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, FontStyle.Italic)
    End Sub
    Private Sub SwitchToRegular()
        RichTextBox1.SelectionFont = New Font( _
                    RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, FontStyle.Regular)
    End Sub
    Private Sub SwitchToBold()
        RichTextBox1.SelectionFont = New Font( _
                    RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, FontStyle.Bold)
    End Sub
End Class
