Public Class Form4

    Dim ctx As New NWindDataContext

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = ctx.Products
    End Sub
End Class