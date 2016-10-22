Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim testString As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim obj As New SharedMembersClass(testString)
        TextBox1.Text = "INSTANCE METHOD" & vbCrLf
        TextBox1.AppendText(obj.IReverseString)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim testString As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        TextBox1.Text = "SHARED METHOD" & vbCrLf
        TextBox1.AppendText(SharedMembersClass.SReverseString(testString))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim obj1 As New SharedMembersClass
        obj1.Connect()
        TextBox1.Clear()
        TextBox1.AppendText(obj1.Users & vbCrLf)
        obj1.Connect()
        TextBox1.AppendText(obj1.Users & vbCrLf)
        Dim obj2 As New SharedMembersClass
        obj2.Connect()
        TextBox1.AppendText(obj1.Users & vbCrLf)
        TextBox1.AppendText(obj2.Users & vbCrLf)
        obj2.Disconnect()
        TextBox1.AppendText(obj2.Users & vbCrLf)
    End Sub

End Class
