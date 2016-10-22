Public Class frmLoan

    Private Sub bttnShowPayment_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles bttnPayment.Click
        Dim Payment As Double
        Dim LoanIRate As Double
        Dim LoanDuration As Integer
        Dim LoanAmount As Integer

        ' Validate amount
        If IsNumeric(txtAmount.Text) Then
            LoanAmount = Convert.ToInt32(txtAmount.Text)
        Else
            MsgBox("Please enter a valid amount")
            Exit Sub
        End If
        ' Validate interest rate
        If IsNumeric(txtRate.Text) Then
            LoanIRate = 0.01 * Convert.ToDouble(txtRate.Text) / 12
        Else
            MsgBox("Invalid interest rate, please re-enter")
            Exit Sub
        End If
        ' Validate loan's duration
        If IsNumeric(txtDuration.Text) Then
            LoanDuration = Convert.ToInt32(txtDuration.Text)
        Else
            MsgBox("Please specify the loan's duration as a number of months")
            Exit Sub
        End If
        ' If all data were validated, proceed with calculations
        Dim payEarly As DueDate
        If chkPayEarly.Checked Then
            payEarly = DueDate.BegOfPeriod
        Else
            payEarly = DueDate.EndOfPeriod
        End If
        Payment = Pmt(LoanIRate, LoanDuration, -LoanAmount, 0, payEarly)
        txtPayment.Text = Payment.ToString("#.00")
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles txtAmount.TextChanged,
        txtDuration.TextChanged, txtRate.TextChanged
        txtPayment.Clear()
    End Sub
End Class
