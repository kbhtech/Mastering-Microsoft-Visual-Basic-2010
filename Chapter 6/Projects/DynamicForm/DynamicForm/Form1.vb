Public Class Form1

    Private Sub TBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, TextBox).BackColor = Color.LightCoral
    End Sub

    Private Sub TBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim TB As New TextBox()
        Dim LBL As New Label()
        Dim i, TBoxes As Integer
        '   Count all TextBox controls on the Form
        For i = 0 To Me.Controls.Count - 1
            If Me.Controls(i).GetType Is GetType(System.Windows.Forms.TextBox) Then
                TBoxes = TBoxes + 1
            End If
        Next
        ' Add new controls if number of controls on the Form is less
        ' than the number specified with the NumericUpDown control
        If TBoxes < NumericUpDown1.Value Then
            TB.Left = 100
            TB.Width = 120
            TB.Text = ""
            For i = TBoxes To CInt(NumericUpDown1.Value) - 1
                TB = New TextBox()
                LBL = New Label()
                If NumericUpDown1.Value = 1 Then
                    ' the first TextBox control is added to the 
                    ' Controls collection when the form is loaded
                    TB.Top = 20
                Else
                    ' If this is the first TextBox control added to the
                    ' Controls collection by increasing the value of the 
                    ' NumericUpDown control, set its Top coordinate explicitly
                    If NumericUpDown1.Value = 2 Then
                        TB.Top = 20 + TB.Height + 5
                    Else
                        ' all other TextBox controls on the form are placed
                        ' 5 pixels below the previous TextBox control
                        TB.Top = Me.Controls(Me.Controls.Count - 2).Top + 25
                    End If
                End If
                ' Set the trivial properties of the new controls
                LBL.Left = 20
                LBL.Width = 80
                LBL.Text = "Data Point " & i
                LBL.Top = TB.Top + 3
                TB.Left = 100
                TB.Width = 120
                TB.Text = ""
                ' add controls to the form
                Me.Controls.Add(TB)
                Me.Controls.Add(LBL)
                ' and finally connect their GotFocus/LostFocus events to the appropriate handler
                AddHandler TB.Enter, New System.EventHandler(AddressOf TBox_Enter)
                AddHandler TB.Leave, New System.EventHandler(AddressOf TBox_Leave)
            Next
        Else
            For i = Me.Controls.Count - 1 To Me.Controls.Count - 2 * (TBoxes - CInt(NumericUpDown1.Value)) Step -2
                Me.Controls.Remove(Controls(i))
                Me.Controls.Remove(Controls(i - 1))
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ctrl As Object
        Dim Sum As Double = 0, points As Integer = 0
        Dim iCtrl As Integer
        For iCtrl = 0 To Me.Controls.Count - 1
            ctrl = Me.Controls(iCtrl)
            If ctrl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                If IsNumeric(CType(ctrl, TextBox).Text) Then
                    ' Take the value of the text on the control to use it in numeric calculations
                    ' Val(string) return the numeric value of the string
                    Sum = Sum + Val(CType(ctrl, TextBox).Text)
                    points = points + 1
                End If
            End If
        Next
        MsgBox("The sum of the " & points.ToString & _
                     " data points is " & Sum.ToString)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim TB As Control
        Dim Sum As Double = 0, points As Integer = 0
        For Each TB In Me.Controls
            If TB.GetType Is GetType(Windows.Forms.TextBox) Then
                If IsNumeric(CType(TB, TextBox).Text) Then
                    ' Take the value of the text on the control to use it in numeric calculations
                    Sum = Sum + Val(CType(TB, TextBox).Text)
                    points = points + 1
                End If
            End If
        Next
        MsgBox("The sum of the " & points.ToString & _
             " data points is " & Sum.ToString)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll
        Panel1.Top = Panel1.Top + (e.NewValue - e.OldValue)
    End Sub
End Class
