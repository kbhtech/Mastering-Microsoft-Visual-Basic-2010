Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim minValue As Double = Min(3.0001, 3.000099)
    End Sub

    Overloads Function Min(ByVal a As Date, ByVal b As Date) As Date
        Min = Convert.ToDateTime(IIf(a < b, a, b))
    End Function

    Overloads Function Min(ByVal a As Double, ByVal b As Double) As Double
        Min = Convert.ToDouble(IIf(a < b, a, b))
    End Function

    Overloads Function Min(ByVal a As String, ByVal b As String) As String
        Min = Convert.ToString(IIf(a < b, a, b))
    End Function

End Class