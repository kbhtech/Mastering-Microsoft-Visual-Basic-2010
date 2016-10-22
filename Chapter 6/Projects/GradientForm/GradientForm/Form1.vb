Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        RepaintForm()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        RepaintForm()
    End Sub

    Sub RepaintForm()
        Dim grbrush As System.Drawing.Drawing2D.LinearGradientBrush
        grbrush = New System.Drawing.Drawing2D.LinearGradientBrush(New  _
                          Point(0, 0), New Point(Me.Width, Me.Height), _
                          Color.Red, Color.Yellow)
        Me.CreateGraphics.FillRectangle(grbrush, New Rectangle(0, 0, _
                           Me.Width, Me.Height))
    End Sub

    ' IF YOU SET THE FORM'S STYLE TO RESIZEREDRAW (REMOVE THE COMMENT SYMBOL IN FRONT OF STATEMENT)
    ' YOU CAN CALL THE REPAINTFORM SUB FROM WITHIN THE ONPAINT METHOD
    ' UNCOMMENT THE TWO STATEMENTS BELOW AND COMMENT OUT THE EVENT HANDLERS PAINT AND RESIZE
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        RepaintForm()
    End Sub
End Class
