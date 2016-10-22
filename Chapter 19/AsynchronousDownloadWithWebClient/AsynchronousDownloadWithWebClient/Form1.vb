Imports System.Net
Imports System.ComponentModel

Public Class Form1

    Dim webClient As New WebClient()

    Private Sub Form1_Load(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler webClient.DownloadStringCompleted,
            AddressOf webClient_DownloadStringCompleted
    End Sub

    Private Sub webClient_DownloadStringCompleted(ByVal sender As Object,
            ByVal e As DownloadStringCompletedEventArgs)
        Dim asyncCompletedParam As AsyncCompletedEventArgs =
            TryCast(e, AsyncCompletedEventArgs)
        If Not asyncCompletedParam.Cancelled = True Then
            Console.WriteLine(CStr(e.Result))
        Else
            Console.WriteLine("Asynchronous download canceled by user!")
        End If
    End Sub

    Private Sub bttnDownload_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles bttnDownload.Click

        webClient.DownloadStringAsync(New Uri("http://www.google.com"))
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles bttnCancel.Click

        webClient.CancelAsync()
    End Sub
End Class
