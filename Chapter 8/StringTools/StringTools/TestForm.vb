Public Class TestForm
    Private Sub bttnAmount2String_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAmount2String.Click
        TextBox1.Text = Convert.ToDecimal(TextBox1.Text).ToString("#,###.00")
        Dim objStrTools As New StringTools()
        objStrTools.Case = StringTools.CaseEnum.CaseCaps
        objStrTools.Delimiter = StringTools.DelimitEnum.DelimiterNone
        objStrTools.Padding = StringTools.PaddingEnum.PaddingCommas
        TextBox2.Text = objStrTools.Num2String(CDec(TextBox1.Text))
    End Sub

    Private Sub bttnParsePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnParsePath.Click
        Dim objStrTools As New StringTools()
        OpenFileDialog1.ShowDialog()
        TextBox3.Clear()
        TextBox3.AppendText("FILE PATH: " & objStrTools.ExtractPathName(OpenFileDialog1.FileName) & vbCrLf)
        TextBox3.AppendText("FILE NAME: " & objStrTools.ExtractFileName(OpenFileDialog1.FileName))
    End Sub
End Class
