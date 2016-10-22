Public Class Form1

    Private Sub Label3D1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3D1.Click
        MsgBox("My properties are " & vbCrLf &
             "Caption = " & Label3D1.Caption.ToString & vbCrLf &
             "Alignment = " & Label3D1.Alignment.ToString & vbCrLf &
             "Effect = " & Label3D1.Effect.ToString)
    End Sub

End Class
