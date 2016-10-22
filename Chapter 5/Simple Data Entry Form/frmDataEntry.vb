Public Class frmDataEntry
    Private Sub frmDataEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' If user pressed the Enter key
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            e.SuppressKeyPress = True
            ' Make sure that the active control is a TextBox control
            ' Do not use the Enter key as tab when a button has the focus!
            If Me.ActiveControl.GetType Is GetType(TextBox) Or _
                    Me.ActiveControl.GetType Is GetType(CheckBox) Or _
                    Me.ActiveControl.GetType Is GetType(DateTimePicker) Then
                ' Use Shift + Enter to move backwords through the tab order
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Dim msg As String = ""
        msg = "Data Item 1: " & TextBox1.Text.Trim & vbCrLf & _
                    "Data Item 2: " & TextBox2.Text & vbCrLf & _
                    "Data Item 3: " & TextBox3.Text & vbCrLf & _
                    "Data Item 4: " & TextBox4.Text & vbCrLf
        msg &= "Selected date: " & DateTimePicker1.Value.ToShortDateString & vbCrLf
        msg &= "Option 1: " & CheckBox1.Checked.ToString & vbCrLf
        msg &= "Option 2: " & CheckBox2.Checked.ToString & vbCrLf
        MsgBox(msg)
        ClearFields()
        TextBox1.Focus()
    End Sub

    Private Sub ClearFields()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        DateTimePicker1.Value = Now.ToShortDateString
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        ClearFields()
        TextBox1.Focus()
    End Sub
End Class
