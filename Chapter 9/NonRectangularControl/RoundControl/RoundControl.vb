Imports System.Drawing.Drawing2D

Public Class RoundControl
    
    Public Event MouseInsideButton(ByVal sender As Object)
    Public Event MouseOusideButton(ByVal sender As Object)

    Public Enum State
        Inactive
        Active
    End Enum

    Private currentFont As Font = New Font("Verdana", 12, FontStyle.Regular)
    Private currentCaption As String = Me.Name
    Private currentCaptionColor As Color = Color.Yellow
    Private currentState As State = State.Inactive

    Public Sub New()
        InitializeComponent()
        MyBase.Font = currentFont
    End Sub

    Public ReadOnly Property ButtonState() As State
        Get
            ButtonState = currentState
        End Get
    End Property

    Public Property Caption() As String
        Get
            Return currentCaption
        End Get
        Set(ByVal value As String)
            currentCaption = value
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

    Public Shadows Property Color() As Color
        Get
            Return currentCaptionColor
        End Get
        Set(ByVal value As Color)
            currentCaptionColor = value
            Me.Refresh()
        End Set
    End Property

    Protected Sub PaintControl(ByVal sender As Object, ByVal pe As PaintEventArgs) Handles Me.Paint
        pe.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim roundPath As New GraphicsPath()
        Dim R As New Rectangle(0, 0, Me.Width, Me.Height)
        roundPath.AddEllipse(R)
        Me.Region = New Region(roundPath)

        Dim Path As New GraphicsPath
        Path.AddEllipse(R)
        Dim grBrush As LinearGradientBrush
        If currentState = State.Active Then
            grBrush = New LinearGradientBrush(New Point(0, 0), _
                                               New Point(R.Width, R.Height), Color.DarkGray, Color.White)
        Else
            grBrush = New LinearGradientBrush(New Point(R.Width, R.Height), _
                                              New Point(0, 0), Color.DarkGray, Color.White)
        End If
        pe.Graphics.FillPath(grBrush, Path)
        Dim X As Integer = (Me.Width - pe.Graphics.MeasureString( _
                            currentCaption, currentFont).Width) / 2

        Dim Y As Integer = (Me.Height - pe.Graphics.MeasureString( _
                            currentCaption, currentFont).Height) / 2
        If currentState = State.Active Then
            pe.Graphics.DrawString(currentCaption, currentFont, Brushes.Black, X, Y)
            pe.Graphics.DrawString(currentCaption, currentFont, _
                                   New SolidBrush(currentCaptionColor), X - 1, Y - 1)
        Else
            pe.Graphics.DrawString(currentCaption, currentFont, _
                                   New SolidBrush(currentCaptionColor), X, Y)
        End If
    End Sub

    Private Sub RoundButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        currentState = State.Active
        Me.Refresh()
        RaiseEvent MouseInsideButton(Me)
    End Sub

    Private Sub RoundButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        currentState = State.Inactive
        Me.Refresh()
        RaiseEvent MouseOusideButton(Me)
    End Sub

End Class
