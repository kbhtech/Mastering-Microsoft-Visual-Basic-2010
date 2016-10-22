Imports System.Speech.Synthesis

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sentence As String = "Isn't learning VB fun?"
        sentence.Speak()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Age As Nullable(Of Integer)
        Dim D As Nullable(Of Date)
        Dim I As Integer = Nothing
        Dim S As String = Nothing
        Debug.WriteLine(D.HasValue)
        MsgBox(Age.ToString)
        Dim showAge As String = IIf(Age Is Nothing, "unknown", Age)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer = 13
        i.Increase(5)
        i.Decrease(9)
        Dim integers() = {1, 84, 12, 27, 3, 19, 73, 9, 16, 41, 53, 57, 13}
        Dim sum = integers.Sum
        TextBox1.AppendText("sum of elements: " & sum.ToString & vbCrLf)
        Dim minValue = integers.Min
        TextBox1.AppendText("min value in array: " & minValue.ToString & vbCrLf)
        Dim maxValue = integers.Max
        TextBox1.AppendText("max value in array: " & maxValue.ToString & vbCrLf)
        Dim sqSum = integers.Sum(Function(k As Integer) k ^ 2)
        TextBox1.AppendText("sum of squares: " & sqSum.ToString & vbCrLf)
        Dim smallCount = integers.Where(Function(k) k < 50).Count
        TextBox1.AppendText("there are " & smallCount.ToString & " elements with a value < 50" & vbCrLf)
        Dim smalIntegers = integers.Where(Function(k) k < 50).OrderBy(Function(k) k)
        TextBox1.AppendText("the elements with a value < 50" & vbCrLf)
        For Each k In smalIntegers
            TextBox1.AppendText(k.ToString & vbTab)
        Next
        TextBox1.AppendText(vbCrLf)
        Dim smallSum = integers.Where(Function(k) k < 50).Sum
        TextBox1.AppendText("sum of elements with a value < 50 : " & smallSum.ToString & vbCrLf)
    End Sub
End Class
