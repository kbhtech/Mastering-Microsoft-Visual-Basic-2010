Imports System.IO

Public Class frmCustomExplorer
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Nd As New TreeNode
        ' change the name of the folder to be scanned in the following statement
        Dim initFolder As String = "C:\Program Files"
        Nd = TreeView1.Nodes.Add(initFolder)
        ' Only the statement that calls the ScanFolder() subroutine is required to populate the TreeView control
        ' Because quite a bit of code is executed from within the application's Load event handler,
        ' it will take a while before the form is displayed.
        ' Instead of waiting to populate the control before showing the form, you can call the Show
        ' method to show the form. In the ScanFolder() subroutine you must call the form's Refresh method 
        ' every now and then to update the form.
        Me.Show()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        ScanFolder(Nd)
        Me.Cursor = Cursors.Default
    End Sub

    Sub ScanFolder(ByRef currentNode As TreeNode)
        Dim folderSpec = currentNode.FullPath
        Dim thisFolder As String
        Dim allFolders As System.Collections.ObjectModel.
            ReadOnlyCollection(Of String)
        Try
            allFolders = My.Computer.FileSystem.
                GetDirectories(folderSpec)
        Catch ex As System.UnauthorizedAccessException
            currentNode.Text = currentNode.Text & "***"
            Exit Sub
        End Try
        currentNode.Nodes.Clear()
        For Each thisFolder In allFolders
            Dim Nd As TreeNode
            Nd = New TreeNode(My.Computer.FileSystem.
                              GetDirectoryInfo(thisFolder).Name)
            For Each childFolder In My.Computer.FileSystem.
                GetDirectories(thisFolder)
                Dim childNode As TreeNode
                childNode = New TreeNode(My.Computer.FileSystem.
                                         GetDirectoryInfo(childFolder).Name)
                Nd.Nodes.Add(childNode)
            Next
            currentNode.Nodes.Add(Nd)
            ' Call the Refresh method to update the display.
            Me.Text = "Scanning " & folderSpec
            TreeView1.Refresh()
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        ShowFiles(e.Node.FullPath)
    End Sub

    Sub ShowFiles(ByVal selFolder As String)
        ListView1.Items.Clear()
        Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim file As String
        files = My.Computer.FileSystem.GetFiles(selFolder)
        Dim TotalSize As Long
        For Each file In files
            Dim LItem As New ListViewItem
            Dim FInfo As FileInfo = My.Computer.FileSystem.
                GetFileInfo(file)
            LItem.Text = FInfo.Name
            LItem.SubItems.Add(FInfo.Length.ToString("#,###"))
            LItem.SubItems.Add(FormatDateTime(
                               FInfo.CreationTime, DateFormat.ShortDate))
            LItem.SubItems.Add(FormatDateTime(
                               FInfo.LastAccessTime, DateFormat.ShortDate))
            ListView1.Items.Add(LItem)
            TotalSize += file.Length
        Next
        Me.Text = Me.Text & " [" & TotalSize.ToString("#,###") & " bytes]"
        ListView1.Refresh()
    End Sub

    Private Sub TreeView1_AfterExpand(ByVal sender As System.Object,
    ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles
    TreeView1.AfterExpand
        ScanFolder(e.Node)
    End Sub
End Class
