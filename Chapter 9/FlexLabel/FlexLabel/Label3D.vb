Public Class Label3D
    Public Enum Align
        TopLeft
        TopMiddle
        TopRight
        CenterLeft
        CenterMiddle
        CenterRight
        BottomLeft
        BottomMiddle
        BottomRight
    End Enum

    Public Enum Effect3D
        None
        Raised
        RaisedHeavy
        Carved
        CarvedHeavy
    End Enum

    Private Shared mAlignment As Align
    Private Shared mEffect As Effect3D
    Private mCaption As String

    Public Property Alignment() As Align
        Get
            Alignment = mAlignment
        End Get
        Set(ByVal Value As Align)
            mAlignment = Value
            Invalidate()
        End Set
    End Property

    Public Property Effect() As Effect3D
        Get
            Effect = mEffect
        End Get
        Set(ByVal Value As Effect3D)
            mEffect = Value
            Invalidate()
        End Set
    End Property

    Property Caption() As String
        Get
            Caption = mCaption
        End Get
        Set(ByVal Value As String)
            mCaption = Value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint( _
         ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim lblFont As Font = Me.Font
        Dim lblBrush As New SolidBrush(Color.Red)
        Dim X, Y As Integer
        Dim textSize As SizeF = _
               e.Graphics.MeasureString(mCaption, lblFont)
        Select Case mAlignment
            Case Align.BottomLeft
                X = 2
                Y = Convert.ToInt32(Me.Height - textSize.Height)
            Case Align.BottomMiddle
                X = CInt((Me.Width - textSize.Width) / 2)
                Y = Convert.ToInt32(Me.Height - textSize.Height)
            Case Align.BottomRight
                X = Convert.ToInt32(Me.Width - textSize.Width - 2)
                Y = Convert.ToInt32(Me.Height - textSize.Height)
            Case Align.CenterLeft
                X = 2
                Y = Convert.ToInt32((Me.Height - textSize.Height) / 2)
            Case Align.CenterMiddle
                X = Convert.ToInt32((Me.Width - textSize.Width) / 2)
                Y = Convert.ToInt32((Me.Height - textSize.Height) / 2)
            Case Align.CenterRight
                X = Convert.ToInt32(Me.Width - textSize.Width - 2)
                Y = Convert.ToInt32((Me.Height - textSize.Height) / 2)
            Case Align.TopLeft
                X = 2
                Y = 2
            Case Align.TopMiddle
                X = Convert.ToInt32((Me.Width - textSize.Width) / 2)
                Y = 2
            Case Align.TopRight
                X = Convert.ToInt32(Me.Width - textSize.Width - 2)
                Y = 2
        End Select
        Dim dispX, dispY As Integer
        Select Case mEffect
            Case Effect3D.None : dispX = 0 : dispY = 0
            Case Effect3D.Raised : dispX = 1 : dispY = 1
            Case Effect3D.RaisedHeavy : dispX = 2 : dispY = 2
            Case Effect3D.Carved : dispX = -1 : dispY = -1
            Case Effect3D.CarvedHeavy : dispX = -2 : dispY = -2
        End Select
        lblBrush.Color = Color.White
        e.Graphics.DrawString(mCaption, lblFont, lblBrush, X, Y)
        lblBrush.Color = Me.ForeColor
        e.Graphics.DrawString(mCaption, lblFont, lblBrush, X + dispX, Y + dispY)
    End Sub


End Class
