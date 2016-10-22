Option Strict On
Imports System.IO
Imports System.IO.Directory

Public Class DirectoryScanner
    Public Event ScanProgress(ByVal foldersScanned As Integer)
    Private totalSize As Long
    Private nFolders As Integer

    Public Function ScanFolder(ByVal folder As String) As Long
        Dim file As String = ""
        Dim dir As String = ""
        Dim FI As FileInfo
        Try
            For Each file In Directory.GetFiles(folder)
                FI = New FileInfo(file)
                totalSize = totalSize + FI.Length
            Next
            For Each dir In Directory.GetDirectories(folder)
                nFolders = nFolders + 1
                RaiseEvent ScanProgress(nFolders)
                ScanFolder(dir)
            Next
        Catch ex As Exception
            Debug.WriteLine("Error in processing folder " & dir & vbCrLf & _
                    ex.Message)
        End Try
        Return totalSize
    End Function

    Public Event ScanTimerProgress(ByVal foldersScanned As Integer, _
           ByRef cancel As Boolean)
    Dim start As Double

    Public Function ScanTimerFolder(ByVal folder As String) As Long
        Dim file, dir As String
        Dim FI As FileInfo
        Dim interval As Double
        interval = 3000
        If start = 0 Then start = Now.TimeOfDay.TotalMilliseconds
        Dim cancel As Boolean
        For Each file In Directory.GetFiles(folder)
            FI = New FileInfo(file)
            totalSize = totalSize + FI.Length
        Next
        For Each dir In Directory.GetDirectories(folder)
            If Now.TimeOfDay.TotalMilliseconds > (start + interval) Then
                RaiseEvent ScanTimerProgress(nFolders, cancel)
                If cancel Then Exit Function
                start = Now.TimeOfDay.TotalMilliseconds
            End If
            nFolders = nFolders + 1
            ScanTimerFolder(dir)
        Next
        Return totalSize
    End Function

End Class

