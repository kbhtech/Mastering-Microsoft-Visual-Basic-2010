Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShapes.Click

        Dim shape1 As New Triangle()
        Dim shape2 As New Circle(4)
        Dim shape3 As New Square(10.01)

        ' SET UP TRIANGLE
        shape1.Side1 = 3
        shape1.Side2 = 3.2
        shape1.Side3 = 0.94

        Dim msg As String
        msg = "The triangle’s area is " & shape1.Area
        msg = msg & vbCrLf & "The circle’s area is " & shape2.Area
        msg = msg & vbCrLf & "The square’s area is " & shape3.Area
        MsgBox(msg)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnArrayShapes.Click
        Dim aList As New ArrayList()
        aList.Add(New Triangle(3, 3.2, 0.94))
        aList.Add(New Square(10.01))
        aList.Add(New Circle(4))
        Dim shapeEnum As IEnumerator
        Dim totalArea As Double
        shapeEnum = aList.GetEnumerator
        While shapeEnum.MoveNext
            ' If OPTION STRICT = OFF, then the following statement can be written
            ' without explicit casting:
            '        totalArea = totalArea + shapeEnum.Current.Area
            totalArea = totalArea + CType(shapeEnum.Current, Shape).Area
        End While
        MsgBox("The total area of the three shapes is " & totalArea)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShapes1.Click
        Dim triangle As Shape
        triangle = New Triangle(3, 3.2, 0.94)

        Dim circle As New Shape
        circle = New Circle(4)

        Dim square As New Shape
        square = New Square(10.01)

        Dim msg As String = "Shape areas"
        msg &= triangle.GetType.ToString & vbCrLf
        msg &= triangle.Area & vbCrLf
        msg &= circle.GetType.ToString & vbCrLf
        msg &= circle.Area & vbCrLf
        msg &= square.GetType.ToString & vbCrLf
        msg &= square.Area & vbCrLf
        MsgBox(msg)
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim shape1 As New Triangle()
        Dim shape2 As New Circle()
        Dim shape3 As New Square()
        ' Set up a triangle
        shape1.Side1 = 3
        shape1.Side2 = 3.2
        shape1.Side3 = 0.94
        Console.WriteLine("The triangle's area is " & shape1.Area.ToString)
        ' Set up a circle
        shape2.Radius = 4
        Console.WriteLine("The circle's area is " & shape2.Area.ToString)
        ' Set up a square
        shape3.Side = 10.01
        Console.WriteLine("The square's area is " & shape3.Area.ToString)
        Dim shapes(2) As Shape
        shapes(0) = shape1
        shapes(1) = shape2
        shapes(2) = shape3
        Dim shapeEnum As IEnumerator
        Dim totalArea As Double
        shapeEnum = shapes.GetEnumerator
        While shapeEnum.MoveNext
            totalArea = totalArea + CType(shapeEnum.Current, Shape).Area
        End While
        Console.WriteLine("The total area of your shapes is " & _
                           totalArea.ToString)

    End Sub
End Class
