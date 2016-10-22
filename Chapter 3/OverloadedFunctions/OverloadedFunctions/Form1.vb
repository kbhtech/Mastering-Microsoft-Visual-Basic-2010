Public Class Form1
    Dim folderName As String = "C:\Windows"

    ''' <summary>
    '''  
    ''' </summary>
    ''' <param name="minSize">The minimum file size of the files to be included in the search</param>
    ''' <param name="maxSize">The minimum file size of the files to be included in the search</param>
    ''' <returns>The number of files with size between minSize and maxSize</returns>
    ''' <remarks></remarks>
    Overloads Function CountFiles(ByVal minSize As Integer, _
                              ByVal maxSize As Integer) As Integer
        Debug.WriteLine("You’ve requested the files between " & minSize & _
                          " and " & maxSize & " bytes")
        Dim files() As String
        files = System.IO.Directory.GetFiles(folderName)
        Dim i, fileCount As Integer
        For i = 0 To files.GetUpperBound(0)
            Dim FI As New System.IO.FileInfo(files(i))
            If FI.Length >= minSize And FI.Length <= maxSize Then
                fileCount = fileCount + 1
            End If
        Next
        Return (fileCount)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fromDate">The earliest creation date for the the files to be included in the search</param>
    ''' <param name="toDate">The latest creation date for the the files to be included in the search</param>
    ''' <returns>The number of files created between the two dates</returns>
    ''' <remarks></remarks>
    Overloads Function CountFiles(ByVal fromDate As Date, _
                                  ByVal toDate As Date) As Integer
        Debug.WriteLine("You’ve requested the count of files created from " & _
                          fromDate & " to " & toDate)
        Dim files() As String
        files = System.IO.Directory.GetFiles(folderName)
        Dim i, fileCount As Integer
        For i = 0 To files.GetUpperBound(0)
            Dim FI As New System.IO.FileInfo(files(i))
            If FI.CreationTime.Date >= fromDate And _
                  FI.CreationTime.Date <= toDate Then
                fileCount = fileCount + 1
            End If
        Next
        Return (fileCount)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="type">The type of the files to search for</param>
    ''' <returns>The number of files of the specified type</returns>
    ''' <remarks></remarks>
    Overloads Function CountFiles(ByVal type As String) As Integer
        Debug.WriteLine("You’ve requested the " & type & " files")
        Dim files() As String
        files = System.IO.Directory.GetFiles(folderName)
        Dim i, fileCount As Integer
        For i = 0 To files.GetUpperBound(0)
            Dim FI As New System.IO.FileInfo(files(i))
            If FI.Extension = type Then
                fileCount = fileCount + 1
            End If
        Next
        Return (fileCount)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="minSize">The minimum size of the file to be included in the search</param>
    ''' <param name="maxSize">The maximum size of the file to be included in the search</param>
    ''' <param name="type">The number of files of the specified type</param>
    ''' <returns>The number of files with a size in a range and of a specific type</returns>
    ''' <remarks></remarks>
    Overloads Function CountFiles(ByVal minSize As Integer, _
            ByVal maxSize As Integer, ByVal type As String) As Integer
        Debug.WriteLine("You’ve requested the " & type & _
                        " files between " & minSize & " and " & _
                        maxSize & " bytes")
        Dim files() As String
        files = System.IO.Directory.GetFiles(folderName)
        Dim i, fileCount As Integer
        For i = 0 To files.GetUpperBound(0)
            Dim FI As New System.IO.FileInfo(files(i))
            If FI.Length >= minSize And _
                  FI.Length <= maxSize And _
                  FI.Extension = type Then
                fileCount = fileCount + 1
            End If
        Next
        Return (fileCount)
    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fromDate">The earliest creation date for the the files to be included in the search</param>
    ''' <param name="toDate">The latest creation date for the the files to be included in the search</param>
    ''' <param name="type">The type of the files to be included in the search</param>
    ''' <returns>The number of files that were created in a range of dates and belong to a specific type</returns>
    ''' <remarks></remarks>
    Overloads Function CountFiles(ByVal fromDate As Date, _
                         ByVal toDate As Date, ByVal type As String) As Integer
        Debug.WriteLine("You’ve requested the " & type & _
                        " files created from " & fromDate & " to " & toDate)
        Dim files() As String
        files = System.IO.Directory.GetFiles(folderName)
        Dim i, fileCount As Integer
        For i = 0 To files.GetUpperBound(0)
            Dim FI As New System.IO.FileInfo(files(i))
            If FI.CreationTime.Date >= fromDate And _
                  FI.CreationTime.Date <= toDate And FI.Extension = type Then
                fileCount = fileCount + 1
            End If
        Next
        Return (fileCount)
    End Function

    Private Sub bttnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCount.Click

        TextBox1.AppendText(CountFiles(1000, 100000) & _
                             " file(s) with size between 1KB and 100KB" & vbCrLf)
        TextBox1.AppendText(CountFiles(#1/1/2006#, #12/31/2006#) & _
                     " file(s) created in 2006" & vbCrLf)
        TextBox1.AppendText(CountFiles(".LOG") & " LOG files" & vbCrLf)
        TextBox1.AppendText(CountFiles(1000, 1000000, ".EXE") & _
                     " EXE file(s) between 1 and 100 KB" & vbCrLf)
        TextBox1.AppendText(CountFiles(#1/1/2007#, #12/31/2009#, ".EXE") & _
                     " EXE file(s) created from 2007 to 2009")

    End Sub
End Class
