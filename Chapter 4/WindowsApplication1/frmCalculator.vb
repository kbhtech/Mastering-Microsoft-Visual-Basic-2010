Public Class frmCalculator

    Dim clearDisplay As Boolean
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim MathOperator As String

    Private Sub DigitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn0.Click, bttn1.Click, bttn2.Click, bttn3.Click, bttn4.Click, bttn5.Click, bttn6.Click, bttn7.Click, bttn8.Click, bttn9.Click
        If clearDisplay Then
            lblDisplay.Text = ""
            clearDisplay = False
        End If
        lblDisplay.Text = lblDisplay.Text + CType(sender, Button).Text
        bttnEquals.Focus()
    End Sub


    Private Sub bttnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClear.Click
        lblDisplay.Text = ""
        bttnEquals.Focus()
    End Sub

    Private Sub bttnPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPeriod.Click
        If lblDisplay.Text.IndexOf(".") > 0 Then
            bttnEquals.Focus()
            Exit Sub
        Else
            lblDisplay.Text = lblDisplay.Text & "."
            bttnEquals.Focus()
        End If
    End Sub

    Private Sub bttnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPlus.Click
        Operand1 = Convert.ToDouble(lblDisplay.Text)
        MathOperator = "+"
        clearDisplay = True
        bttnEquals.Focus()
    End Sub

    Private Sub bttnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEquals.Click
        Dim result As Double
        Operand2 = Convert.ToDouble(lblDisplay.Text)
        Try
            Select Case MathOperator
                Case "+"
                    result = Operand1 + Operand2
                Case "-"
                    result = Operand1 - Operand2
                    Debug.WriteLine("DD")
                Case "*"
                    result = Operand1 * Operand2
                Case "/"
                    If Operand2 <> "0" Then result = Operand1 / Operand2
            End Select
            lblDisplay.Text = result.ToString
            clearDisplay = True
        Catch exc As Exception
            Debug.WriteLine(exc.Message)
            result = "ERROR"
        End Try
    End Sub

    Private Sub bttnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMinus.Click
        Operand1 = Convert.ToDouble(lblDisplay.Text)
        MathOperator = "-"
        clearDisplay = True
        bttnEquals.Focus()
    End Sub

    Private Sub bttnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMultiply.Click
        Operand1 = Convert.ToDouble(lblDisplay.Text)
        MathOperator = "*"
        clearDisplay = True
        bttnEquals.Focus()
    End Sub

    Private Sub bttnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDivide.Click
        Operand1 = Convert.ToDouble(lblDisplay.Text)
        MathOperator = "/"
        clearDisplay = True
        bttnEquals.Focus()
    End Sub

    Private Sub bttnNegate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNegate.Click
        lblDisplay.Text = -Convert.ToDouble(lblDisplay.Text).ToString
        clearDisplay = True
        bttnEquals.Focus()
    End Sub

    Private Sub bttnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReverse.Click
        If Convert.ToDouble(lblDisplay.Text) <> 0 Then
            lblDisplay.Text = (1 / Convert.ToDouble(lblDisplay.Text)).ToString
            clearDisplay = True
        End If
        bttnEquals.Focus()
    End Sub


    Private Sub CalculatorForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "1" : bttn1.PerformClick()
            Case "2" : bttn2.PerformClick()
            Case "3" : bttn3.PerformClick()
            Case "4" : bttn4.PerformClick()
            Case "5" : bttn5.PerformClick()
            Case "6" : bttn6.PerformClick()
            Case "7" : bttn7.PerformClick()
            Case "8" : bttn8.PerformClick()
            Case "9" : bttn9.PerformClick()
            Case "0" : bttn0.PerformClick()
            Case "." : bttnPeriod.PerformClick()
            Case "C", "c" : bttnClear.PerformClick()
            Case "+" : bttnPlus.PerformClick()
            Case "-" : bttnMinus.PerformClick()
            Case "*" : bttnMultiply.PerformClick()
            Case "/" : bttnDivide.PerformClick()
            Case "=" : bttnEquals.PerformClick()
        End Select
    End Sub

    Private Sub CalculatorForm_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            bttnEquals.PerformClick()
            e.Handled = True
        End If
    End Sub


End Class
