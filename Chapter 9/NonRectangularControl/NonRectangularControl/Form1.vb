Public Class Form1

    Private Sub bttnplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnPlay.Click
        If bttnPlay.Caption = "Play" Then
            Label1.Text = "Playing..."
            bttnPlay.Caption = "STOP"
            bttnPlay.Color = Color.Red
            bttnRecord.Enabled = False
            bttnClose.Enabled = False
        Else
            Label1.Text = "Stoped Playing"
            bttnPlay.Caption = "Play"
            bttnPlay.Color = Color.Yellow
            bttnRecord.Enabled = True
            bttnClose.Enabled = True
        End If
    End Sub



    Private Sub bttnRecord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnRecord.Click
        If bttnRecord.Caption = "Record" Then
            Label1.Text = "Recording..."
            bttnRecord.Caption = "STOP"
            bttnRecord.Color = Color.Red
            bttnPlay.Enabled = False
            bttnClose.Enabled = False
        Else
            Label1.Text = "Stoped Recording"
            bttnRecord.Caption = "Record"
            bttnRecord.Color = Color.Yellow
            bttnPlay.Enabled = True
            bttnClose.Enabled = True
        End If
    End Sub

    Private Sub bttnRecord_MouseInsideButton(ByVal sender As System.Object) Handles bttnRecord.MouseInsideButton
        Label1.Text = "Focus on RECORD button"
    End Sub

    Private Sub bttnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Dim reply As MsgBoxResult
        reply = MsgBox("Are you sure you want to close the application", MsgBoxStyle.YesNo)
        If reply = MsgBoxResult.Yes Then Application.Exit()
    End Sub

    Private Sub bttnclose_MouseInsideButton(ByVal sender As System.Object) Handles bttnClose.MouseInsideButton
        Label1.Text = "Focus on CLOSE button"
    End Sub

    Private Sub bttnClose_MouseOusideButton() Handles bttnClose.MouseOusideButton
        Label1.Text = ""
    End Sub

    Private Sub bttnPlay_MouseInsideButton(ByVal sender As Object) Handles bttnPlay.MouseInsideButton
        Label1.Text = "Focus on PLAY button"
    End Sub

    Private Sub LedBttnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LedBttnPlay.Click
        If LedBttnPlay.ButtonState = RoundControl.LEDButton.LEDState.Pressed Then
            Label2.Text = "Playing...  Click again to stop payback."
            LedBttnRecord.Enabled = False
        Else
            Label2.Text = ""
            LedBttnRecord.Enabled = True
        End If
    End Sub

    Private Sub LedBttnRecord_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedBttnRecord.Click
        If LedBttnRecord.ButtonState = RoundControl.LEDButton.LEDState.Pressed Then
            Label2.Text = "Recording... Click again to stop recording."
            LedBttnPlay.Enabled = False
        Else
            Label2.Text = ""
            LedBttnPlay.Enabled = True
        End If
    End Sub

    Private Sub LedBttnRecord_MouseInsideButton(ByVal sender As Object) Handles LedBttnRecord.MouseInsideButton
        If LedBttnRecord.ButtonState <> RoundControl.LEDButton.LEDState.Pressed Then Label2.Text = "Click to record!"
    End Sub

    Private Sub LedBttnRecord_MouseOusideButton() Handles LedBttnRecord.MouseOusideButton
        If LedBttnRecord.ButtonState <> RoundControl.LEDButton.LEDState.Pressed Then Label2.Text = ""
    End Sub

    Private Sub LedBttnPlay_MouseInsideButton(ByVal sender As Object) Handles LedBttnPlay.MouseInsideButton
        If LedBttnPlay.ButtonState <> RoundControl.LEDButton.LEDState.Pressed Then Label2.Text = "Click to play!"
    End Sub

    Private Sub LedBttnPlay_MouseOusideButton() Handles LedBttnPlay.MouseOusideButton
        If LedBttnPlay.ButtonState <> RoundControl.LEDButton.LEDState.Pressed Then Label2.Text = ""
    End Sub


End Class
