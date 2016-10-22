Public Class MainForm

    Public Shared strProperty As String = "Mastering VB.NET"

    Dim WithEvents FRM As New AuxiliaryForm()

    Private Sub bttnAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAge.Click
        AgeDialog.cmbDay.Text = "4"
        AgeDialog.cmbMonth.Text = "November"
        AgeDialog.cmbYear.Text = "1980"

        AgeDialog.ShowDialog()
        If AgeDialog.DialogResult = Windows.Forms.DialogResult.OK Then
            MsgBox(AgeDialog.cmbMonth.Text & " " & AgeDialog.cmbDay.Text & ", " & AgeDialog.cmbYear.Text)
        Else
            MsgBox("OK, we'll protect your vital personal data")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = strProperty
        ' if you want to access the TextBox control on the main form
        ' through the TBox variable, uncomment the following line
        'TBox = TextBox1
    End Sub

    Private Sub bttnAuxiliary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAuxiliary.Click
        FRM.Show()
    End Sub

    Private Sub FRM_strPropertyChanged(ByVal oldValue As String, ByVal newValue As String) Handles FRM.strPropertyChanged
        TextBox1.Text = strProperty
        Beep()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        strProperty = TextBox1.Text
    End Sub

End Class
