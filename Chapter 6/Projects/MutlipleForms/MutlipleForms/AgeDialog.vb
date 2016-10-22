Public Class AgeDialog

    Private Sub AgeDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim year As Integer
        For year = 1900 To 2010
            cmbYear.Items.Add(year)
        Next
        Dim month As Integer
        For month = 1 To 12
            cmbMonth.Items.Add(MonthName(month))
        Next
        Dim day As Integer
        For day = 1 To 31
            cmbDay.Items.Add(day)
        Next
    End Sub

    Private Sub bttnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class