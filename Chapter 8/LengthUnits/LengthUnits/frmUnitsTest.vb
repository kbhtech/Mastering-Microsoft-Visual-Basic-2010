Public Class frmUnitsTest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Dim MU1 As New MetricUnits
        MU1.Centimeters = 194
        TextBox1.AppendText("194 centimeters is " & MU1.Tostring & " meters" & vbCrLf)
        Dim MU2 As New MetricUnits
        MU2.Meters = 1
        MU2.Centimeters = 189
        TextBox1.AppendText("1 meter and 189 centimeters is " & MU2.Tostring & " meters " & vbCrLf)
        TextBox1.AppendText("194 + 289 centimeters is " & (MU1 + MU2).Tostring & " meters" & vbCrLf)
        TextBox1.AppendText("194 - 289 centimeters is " & (MU1 - MU2).Tostring & " meters" & vbCrLf)
        TextBox1.AppendText("MU1 = " & MU1.Tostring & vbCrLf)
        TextBox1.AppendText("MU2 = " & MU2.Tostring & vbCrLf)
        If MU1 = MU2 Then
            TextBox1.AppendText("MU1 is equal to MU2" & vbCrLf)
        Else
            TextBox1.AppendText("MU1 and MU2 are not equal" & vbCrLf)
        End If
        MU2 = -MU1
        TextBox1.AppendText("MU1 = " & MU1.Tostring & vbCrLf)
        TextBox1.AppendText("MU2 = " & MU2.Tostring & vbCrLf)
        If MU1 = -MU2 Then
            TextBox1.AppendText("MU1 is equal to the negative of MU2" & vbCrLf)
        Else
            TextBox1.AppendText("MU1 is not equal to the negative of MU2" & vbCrLf)
        End If
        TextBox1.AppendText("The negative of " & MU1.Tostring & " is " & MU2.Tostring & vbCrLf)
        MU1.Meters = 4
        MU1.Centimeters = 63
        Dim EU1 As EnglishUnits = CType(MU1, EnglishUnits)
        TextBox1.AppendText("4.62 meters are " & EU1.Tostring & vbCrLf)
        MU1 = CType(EU1, MetricUnits)
        TextBox1.AppendText(EU1.Tostring & " are " & MU1.Tostring & " meters" & vbCrLf)
        If MU1 <> EU1 Then
            TextBox1.AppendText("MU1 is not equal to EU1" & vbCrLf)
        Else
            TextBox1.AppendText("EU1 is equal to ME1" & vbCrLf)
        End If
        Try
            If MU1 = 462 Then
                TextBox1.AppendText("MU1 is equal to 4.62" & vbCrLf)
            Else
                TextBox1.AppendText("EU1 is not equal to 4.62" & vbCrLf)
            End If
        Catch ex As Exception
            TextBox1.AppendText(ex.Message & vbCrLf)
        End Try
    End Sub
End Class
