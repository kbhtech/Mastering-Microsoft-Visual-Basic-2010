Public Class frmColors
    Private Sub redBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles redBar.Scroll
        If e.Type = ScrollEventType.EndScroll Then ColorBox1()
        lblRed.Text = "RED " & redBar.Value.ToString("###")
    End Sub

    Private Sub greenBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles greenBar.Scroll
        If e.Type = ScrollEventType.EndScroll Then ColorBox1()
        lblGreen.Text = "GREEN " & greenBar.Value.ToString("###")
    End Sub

    Private Sub blueBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles blueBar.Scroll
        If e.Type = ScrollEventType.EndScroll Then ColorBox1()
        lblBlue.Text = "BLUE " & blueBar.Value.ToString("###")
    End Sub

    Private Sub redBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles redBar.ValueChanged
        ColorBox2()
    End Sub

    Private Sub greenBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles greenBar.ValueChanged
        ColorBox2()
    End Sub

    Private Sub blueBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles blueBar.ValueChanged
        ColorBox2()
    End Sub

    Sub ColorBox1()
        Dim clr As Color
        clr = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value)
        PictureBox1.BackColor = clr
    End Sub

    Sub ColorBox2()
        Dim clr As Color
        clr = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value)
        PictureBox2.BackColor = clr
    End Sub

End Class
