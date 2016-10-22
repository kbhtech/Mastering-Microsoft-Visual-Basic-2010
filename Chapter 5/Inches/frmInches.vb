Public Class frmInches
    Private Sub Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                       Handles Label1.Click, Label2.Click, _
                       Label3.Click, Label4.Click, Label5.Click, Label6.Click, _
                       Label7.Click, Label8.Click, Label9.Click, Label10.Click, Label11.Click
        TrackBar1.Value = CInt(CType(sender, Label).Text) * 5
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        lblInches.Text = "Length in inches = " & _
              Format(TrackBar1.Value / 5, "#.00")
    End Sub
End Class
