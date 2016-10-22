Public Class UserControl1

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll, HScrollBar3.Scroll
        ComboBox1.SelectedItem = "Unknown"
        ShowColor()
    End Sub

    Sub ShowColor()
        Label1.BackColor = Color.FromArgb(255, HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
    End Sub

    Private Sub ctrlColorEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddNamedColors()
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Property SelectedColor() As Color
        Get
            SelectedColor = Label1.BackColor
        End Get
        Set(ByVal Value As Color)
            HScrollBar1.Value = Value.R
            HScrollBar2.Value = Value.G
            HScrollBar3.Value = Value.B
            ShowColor()
        End Set
    End Property

    ReadOnly Property NamedColor() As String
        Get
            NamedColor = ComboBox1.SelectedItem
        End Get
    End Property

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim namedColor As Color
        Dim colorName As String
        colorName = ComboBox1.SelectedItem
        If colorName <> "Unknown" Then
            namedColor = Color.FromName(colorName)
            HScrollBar1.Value = namedColor.R
            HScrollBar2.Value = namedColor.G
            HScrollBar3.Value = namedColor.B
            ShowColor()
        End If
    End Sub


    Private Sub AddNamedColors()
        With ComboBox1.Items
            .Add("AliceBlue")
            .Add("AntiqueWhite")
            .Add("Aqua")
            .Add("Aquamarine")
            .Add("Azure")
            .Add("Beige")
            .Add("Bisque")
            .Add("Black")
            .Add("BlanchedAlmond")
            .Add("Blue")
            .Add("BlueViolet")
            .Add("Brown")
            .Add("BurlyWood")
            .Add("CadetBlue")
            .Add("Chartreuse")
            .Add("Chocolate")
            .Add("Coral")
            .Add("Cornflower")
            .Add("Cornsilk")
            .Add("Crimson")
            .Add("Cyan")
            .Add("DarkBlue")
            .Add("DarkCyan")
            .Add("DarkGoldenrod")
            .Add("DarkGray")
            .Add("DarkGreen")
            .Add("DarkKhaki")
            .Add("DarkMagenta")
            .Add("DarkOliveGreen")
            .Add("DarkOrange")
            .Add("DarkOrchid")
            .Add("DarkRed")
            .Add("DarkSalmon")
            .Add("DarkSeaGreen")
            .Add("DarkSlateBlue")
            .Add("DarkSlateGray")
            .Add("DarkTurquoise")
            .Add("DarkViolet")
            .Add("DeepPink")
            .Add("DeepSkyBlue")
            .Add("DimGray")
            .Add("DodgerBlue")
            .Add("Firebrick")
            .Add("FloralWhite")
            .Add("ForestGreen")
            .Add("Fuchsia")
            .Add("Gainsboro")
            .Add("GhostWhite")
            .Add("Gold")
            .Add("Goldenrod")
            .Add("Gray")
            .Add("Green")
            .Add("GreenYellow")
            .Add("Honeydew")
            .Add("HotPink")
            .Add("IndianRed")
            .Add("Indigo")
            .Add("Ivory")
            .Add("Khaki")
            .Add("Lavender")
            .Add("LavenderBlush")
            .Add("LawnGreen")
            .Add("LemonChiffon")
            .Add("LightBlue")
            .Add("LightCoral")
            .Add("LightCyan")
            .Add("LightGoldenrodYellow")
            .Add("LightGray")
            .Add("LightGreen")
            .Add("LightPink")
            .Add("LightSalmon")
            .Add("LightSeaGreen")
            .Add("LightSkyBlue")
            .Add("LightSlateGray")
            .Add("LightSteelBlue")
            .Add("LightYellow")
            .Add("Lime")
            .Add("LimeGreen")
            .Add("Linen")
            .Add("Magenta")
            .Add("Maroon")
            .Add("MediumAquamarine")
            .Add("MediumBlue")
            .Add("MediumOrchid")
            .Add("MediumPurple")
            .Add("MediumSeaGreen")
            .Add("MediumSlateBlue")
            .Add("MediumSpringGreen")
            .Add("MediumTurquoise")
            .Add("MediumVioletRed")
            .Add("MidnightBlue")
            .Add("MintCream")
            .Add("MistyRose")
            .Add("Moccasin")
            .Add("NavajoWhite")
            .Add("Navy")
            .Add("OldLace")
            .Add("Olive")
            .Add("OliveDrab")
            .Add("Orange")
            .Add("OrangeRed")
            .Add("Orchid")
            .Add("PaleGoldenrod")
            .Add("PaleGreen")
            .Add("PaleTurquoise")
            .Add("PaleVioletRed")
            .Add("PapayaWhip")
            .Add("PeachPuff")
            .Add("Peru")
            .Add("Pink")
            .Add("Plum")
            .Add("PowderBlue")
            .Add("Purple")
            .Add("Red")
            .Add("RosyBrown")
            .Add("RoyalBlue")
            .Add("SaddleBrown")
            .Add("Salmon")
            .Add("SandyBrown")
            .Add("SeaGreen")
            .Add("SeaShell")
            .Add("Sienna")
            .Add("Silver")
            .Add("SkyBlue")
            .Add("SlateBlue")
            .Add("SlateGray")
            .Add("Snow")
            .Add("SpringGreen")
            .Add("SteelBlue")
            .Add("Tan")
            .Add("Teal")
            .Add("Thistle")
            .Add("Tomato")
            .Add("Transparent")
            .Add("Turquoise")
            .Add("Violet")
            .Add("Wheat")
            .Add("White")
            .Add("WhiteSmoke")
            .Add("Yellow")
            .Add("YellowGreen")
            .Add("Unknown")
        End With
        ComboBox1.SelectedItem = "Black"
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawRectangle(New Pen(Color.Silver, 2), 0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
    End Sub


    Public Event ColorClick(ByVal sender As Object, ByVal e As ColorEvent)

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim ev As New ColorEvent
        ' set the color property of the EventArgs argument
        ev.color = Label1.BackColor
        ' and then raise the event ColorClick
        RaiseEvent ColorClick(Me, ev)
    End Sub

End Class

' create a new type of argument that exposes the color property
Public Class ColorEvent
    Inherits EventArgs
    Public color As Color
End Class
