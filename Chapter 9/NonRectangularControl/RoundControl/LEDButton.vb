Imports System.Drawing.Drawing2D

Public Class LEDButton
    Public Event MouseInsideButton(ByVal sender As Object)
    Public Event MouseOusideButton(ByVal sender As Object)

    Public Enum LEDState
        Pressed
        Released
        Active
    End Enum

    Private currentFont As Font = New Font("Verdana", 12, FontStyle.Regular)
    Private currentCaption As String = Me.Name
    Private currentPressedCaption As String = Me.Name
    Private currentState As LEDState = LEDState.Released

    Private LEDButtonSize As Integer = 14


    Public Sub New()
        InitializeComponent()
        MyBase.Font = currentFont
    End Sub

    Public Property Caption() As String
        Get
            Return currentCaption
        End Get
        Set(ByVal value As String)
            currentCaption = value
            Me.Refresh()
        End Set
    End Property

    Public Property PressedCaption() As String
        Get
            Return currentPressedCaption
        End Get
        Set(ByVal value As String)
            currentPressedCaption = value
            Me.Refresh()
        End Set
    End Property

    Public Shadows Property Font() As Font
        Get
            Return currentFont
        End Get
        Set(ByVal value As Font)
            currentFont = value
            Me.Refresh()
        End Set
    End Property

    'Public Shadows Property Color() As Color
    '    Get
    '        Return currentCaptionColor
    '    End Get
    '    Set(ByVal value As Color)
    '        currentCaptionColor = value
    '        Me.Refresh()
    '    End Set
    'End Property

    Public Property ButtonState() As LEDState
        Get
            Return currentState
        End Get
        Set(ByVal value As LEDState)
            currentState = value
        End Set
    End Property

    Protected Sub PaintControl(ByVal sender As Object, ByVal pe As PaintEventArgs) Handles Me.Paint
        pe.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim bgBrush As New LinearGradientBrush(New PointF(0, 0), New PointF(Me.Width, 0), Color.Gray, Color.Gainsboro)
        pe.Graphics.FillRectangle(bgBrush, Me.ClientRectangle)

        Dim grBrush As SolidBrush
        If currentState = LEDState.Active Then
            grBrush = New SolidBrush(Color.LightGreen)
        ElseIf currentState = LEDState.Released Then
            grBrush = New SolidBrush(Color.Green)
        Else
            grBrush = New SolidBrush(Color.Red)
        End If
        Dim X As Integer = (Me.Width - pe.Graphics.MeasureString( _
                            currentCaption, currentFont).Width + LEDButtonSize) / 2
        Dim Y As Integer = (Me.Height - pe.Graphics.MeasureString( _
                            currentCaption, currentFont).Height) / 2
        If currentState = LEDState.Pressed Then
            pe.Graphics.DrawRectangle(Pens.Black, New Rectangle(Me.ClientRectangle.X, Me.ClientRectangle.Y, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1))
            pe.Graphics.DrawRectangle(Pens.Gainsboro, New Rectangle(Me.ClientRectangle.X + 1, Me.ClientRectangle.Y + 1, Me.ClientRectangle.Width - 3, Me.ClientRectangle.Height - 3))

            pe.Graphics.DrawString(currentPressedCaption, currentFont, Brushes.Black, X, Y)
            pe.Graphics.DrawString(currentPressedCaption, currentFont, _
                                   grBrush, X - 1, Y - 1)
        Else
            pe.Graphics.DrawRectangle(Pens.Gainsboro, New Rectangle(Me.ClientRectangle.X, Me.ClientRectangle.Y, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
            pe.Graphics.DrawRectangle(Pens.Black, New Rectangle(Me.ClientRectangle.X + 1, Me.ClientRectangle.Y + 1, Me.ClientRectangle.Width - 2, Me.ClientRectangle.Height - 2))

            pe.Graphics.DrawString(currentCaption, currentFont, Brushes.Black, X, Y)
            pe.Graphics.DrawString(currentCaption, currentFont, _
                                   grBrush, X - 1, Y - 1)
        End If
        pe.Graphics.FillEllipse(New SolidBrush(Color.Black), New RectangleF(3, (Me.Height - LEDButtonSize) / 2 + 1, LEDButtonSize, LEDButtonSize))
        pe.Graphics.FillEllipse(grBrush, New RectangleF(2, (Me.Height - LEDButtonSize) / 2, LEDButtonSize, LEDButtonSize))
    End Sub

    Private Sub RoundButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        If currentState <> LEDState.Pressed Then
            currentState = LEDState.Active
            Me.Refresh()
        End If
        RaiseEvent MouseInsideButton(Me)
    End Sub

    Private Sub RoundButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        If currentState <> LEDState.Pressed Then
            currentState = LEDState.Released
            Me.Refresh()
        End If
        RaiseEvent MouseOusideButton(Me)
    End Sub

    Private Sub RoundButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If currentState = LEDState.Pressed Then
            currentState = LEDState.Active
        Else
            currentState = LEDState.Pressed
        End If
        Me.Refresh()
    End Sub
End Class
