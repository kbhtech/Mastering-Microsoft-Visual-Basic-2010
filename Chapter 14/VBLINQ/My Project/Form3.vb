Imports System.Data.Linq

Public Class Form3

    Dim ctx As New NWindDataContext

    Private Sub bttnChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bttnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCreate.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class
