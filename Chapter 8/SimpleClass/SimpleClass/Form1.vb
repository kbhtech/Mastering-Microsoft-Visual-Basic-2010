Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As Minimal
        obj = New Minimal()

        Try
            obj.BDate = InputBox("Please Enter your birthdate")
        Catch ex As ArgumentException
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Debug.WriteLine(obj.Age)
        Dim discount As Single
        Dim grp As Minimal.AgeGroup = obj.GetAgeGroup
        Select Case grp
            Case Minimal.AgeGroup.Infant, Minimal.AgeGroup.Child
                discount = 0.4
            Case Minimal.AgeGroup.Teenager
                discount = 0.5
            Case Minimal.AgeGroup.Senior
                discount = 0.2
            Case Else
        End Select
        MsgBox("You age is " & obj.Age.ToString & " and belong to the " &
           obj.GetAgeGroup.ToString & " group" & vbCrLf & "Your discount is " &
           Format(discount, "Percent"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj As New Minimal
        Dim userAge As Integer
        userAge = InputBox("Please enter your age")
        ' The code assumes that user has entered a numeric value.
        ' To handle all types of user errors, call the IsNumeric() function:
        '   Integer.TryParse(InputBox("Please enter your age"), userAge)
        '   If userAge > 0  then ...
        obj.Age = userAge
        Try
            obj.Age = userAge
        Catch exc As ArgumentException
            MsgBox("Can't accept your value, " & userAge.ToString & vbCrLf & _
                   "Will continue with default value of 30")
            obj.Age = 30
        End Try
    End Sub
End Class
