Public Class AuxiliaryForm
    Event strPropertyChanged(ByVal oldValue As String, ByVal newValue As String)

    Private Sub bttnReadShared_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReadShared.Click
        MsgBox(MainForm.strProperty, MsgBoxStyle.OKOnly, "Public Variable Value")
        ' IF YOU WANT TO ACCESS THE TEXTBOX CONTROL ON THE MAIN FORM 
        ' THROUGH THE TBOX SHARED VARIABLE, COMMENT OUT THE FIRST LINE
        ' IN THIS SUBROUTINE AND UNCOMMENT THE FOLLOWING TWO LINES
        'Dim Main As MainForm
        'MsgBox(Main.TBox.Text)
    End Sub

    Private Sub bttnSetShared_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSetShared.Click
        Dim str As String
        str = InputBox("Enter a new value for strProperty")
        Dim oldValue As String = MainForm.strProperty
        MainForm.strProperty = str
        RaiseEvent strPropertyChanged(oldValue, str)
    End Sub

    Private Sub AuxiliaryForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True
    End Sub
End Class