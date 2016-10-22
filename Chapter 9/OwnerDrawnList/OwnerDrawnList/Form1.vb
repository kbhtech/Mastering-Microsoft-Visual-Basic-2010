Public Class Form1

    '    Dim items As New ArrayList
    Dim fnt As Font

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        MsgBox("Item at location " & ListBox1.SelectedIndex & " is " & vbCrLf & ListBox1.SelectedItem)
    End Sub

    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        If e.Index = -1 Then Exit Sub
        Dim txtBrush As SolidBrush
        Dim bgBrush As SolidBrush
        Dim txtfnt As Font
        If e.Index / 2 = CInt(e.Index / 2) Then
            ' color even numbered items
            txtBrush = New SolidBrush(Color.Blue)
            bgBrush = New SolidBrush(Color.LightYellow)
        Else
            ' color odd numbered items
            txtBrush = New SolidBrush(Color.Blue)
            bgBrush = New SolidBrush(Color.Cyan)
        End If
        If e.State And DrawItemState.Selected Then
            ' use red color and bold for the selected item 
            txtBrush = New SolidBrush(Color.Red)
            txtfnt = New Font(fnt.Name, fnt.Size, FontStyle.Bold)
        Else
            txtfnt = fnt
        End If
        e.Graphics.FillRectangle(bgBrush, e.Bounds)
        e.Graphics.DrawRectangle(Pens.Black, e.Bounds)
        Dim R As New RectangleF(e.Bounds.X, e.Bounds.Y, _
                                e.Bounds.Width, e.Bounds.Height)
        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString, txtfnt, txtBrush, R)
        e.DrawFocusRectangle()
    End Sub

    Private Sub ListBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyUp
        If e.KeyCode = Keys.Delete Then
            If ListBox1.SelectedIndex > -1 Then
                Dim currentIndex As Integer = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                If currentIndex < ListBox1.Items.Count Then
                    ListBox1.SelectedIndex = currentIndex
                ElseIf ListBox1.Items.Count = 1 Then
                    ListBox1.SelectedIndex = 0
                End If
                ListBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ListBox1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ListBox1.MeasureItem
        Dim itmSize As SizeF
        Dim S As New SizeF(ListBox1.Width, 200)
        itmSize = e.Graphics.MeasureString(ListBox1.Items(e.Index).ToString, fnt, S)
        e.ItemHeight = itmSize.Height
        e.ItemWidth = itmSize.Width
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newItem As String
        newItem = InputBox("Enter item to add to the list")
        ListBox1.Items.Add(newItem)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fnt = ListBox1.Font
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add("First Item")
        ListBox1.Items.Add("Second Item")
        ListBox1.Items.Add("This is a fairly lengthy item")
        ListBox1.Items.Add("This item is just too long to be displayed on a single line")
        ListBox1.Items.Add("and this is the last item")
        'ListBox1.Items.Clear()
        'Dim i As Integer
        'For i = 0 To 4
        'ListBox1.Items.Add(ListBox1.Items(i).ToString)
        'Next
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ListBox1.Refresh()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
