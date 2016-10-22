Public Class Form1

    Structure CustBalance
        Dim SavingsBalance As Decimal
        Dim CheckingBalance As Decimal
    End Structure

    Function GetCustBalance(ByVal ID As Long) As CustBalance
        Dim tBalance As CustBalance
        tBalance.CheckingBalance = CDec(1000 + 4000 * rnd())
        tBalance.SavingsBalance = CDec(1000 + 15000 * rnd())
        Return (tBalance)
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim balance As CustBalance
        balance = GetCustBalance(1)
        MsgBox("The customer's checking balance is " & _
                balance.CheckingBalance.ToString("#,###.00") & vbCrLf & _
                "and his savings balance is " & balance.SavingsBalance.ToString("#,###.00"))
    End Sub
End Class
