Public Class frmTest
    Dim WithEvents objDirScanner As DirectoryScanner

    Private Sub objDirScanner_ScanProgress(ByVal foldersScanned As Integer) Handles objDirScanner.ScanProgress
        Label1.Text = "Scanned " & foldersScanned.ToString & " folders so far"
        Application.DoEvents()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim folder As String
        objDirScanner = New DirectoryScanner()
        folder = "c:\Program Files"
        TextBox1.AppendText("The files in " & folder & " occupy " & objDirScanner.ScanFolder(folder).ToString("#,###") & " bytes on the drive")
    End Sub

    Private Sub objDirScanner_ScanTimerProgress(ByVal foldersScanned As Integer, ByRef cancel As Boolean) Handles objDirScanner.ScanTimerProgress
        Label1.Text = "Scanned " & foldersScanned.ToString & " folders so far"
        Application.DoEvents()
        If foldersScanned > 1000 Then
            Beep()
            cancel = True
        End If
    End Sub
End Class
