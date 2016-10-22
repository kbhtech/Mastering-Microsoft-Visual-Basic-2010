Public Class Form1

    Dim Products As New Hashtable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Products.Clear()
        Dim P1 As New Book
        P1.ListPrice = 13.24D
        P1.Description = "Book Title 1"
        P1.ProductID = "EN0101"
        P1.ISBN = "0172833223"
        P1.SubTitle = "Book Title 1 Subtitle"
        Products.Add(P1.ProductID, P1)

        P1 = New Book
        P1.ListPrice = 25.99D
        P1.Description = "Book Title 2"
        P1.ProductID = "CS09212"
        P1.ISBN = "0175388015"
        P1.SubTitle = "Book Title 2 Subtitle"
        Products.Add(P1.ProductID, P1)

        Dim P2 As New Supply
        P2.Description = "Supply 1"
        P2.ListPrice = 2.25D
        P2.LongDescription = "Long description of item 1"
        P2.ProductID = "S0001-1"
        Products.Add(P2.ProductID, P2)

        P2 = New Supply
        P2.Description = "Supply 2"
        P2.ListPrice = 0.55D
        P2.LongDescription = "Long description of item 2"
        P2.ProductID = "S0011-2"
        Products.Add(P2.ProductID, P2)

        P2 = New Supply
        P2.Description = "Supply 3"
        P2.ListPrice = 15.99D
        P2.LongDescription = "Long description of item 3"
        P2.ProductID = "S0011-3"
        Products.Add(P2.ProductID, P2)

        P2 = New Supply
        P2.Description = "Supply 4"
        P2.ListPrice = 1.25D
        P2.LongDescription = "Long description of item 4"
        P2.ProductID = "S0011-4"
        Products.Add(P2.ProductID, P2)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim key As String
        Dim LI As ListViewItem
        For Each key In Products.Keys
            LI = New ListViewItem
            Dim bookItem As Book, supplyItem As Supply
            If TypeOf Products.Item(key) Is Book Then
                bookItem = CType(Products.Item(key), Book)
                LI.Text = bookItem.ProductID
                LI.SubItems.Add(bookItem.ISBN)
                LI.SubItems.Add(bookItem.Description)
                LI.SubItems.Add(bookItem.Subtitle)
                LI.SubItems.Add(bookItem.ListPrice.ToString("#,##0.00"))
                ListView1.Items.Add(LI)
            End If
            If TypeOf Products.Item(key) Is Supply Then
                supplyItem = CType(Products.Item(key), Supply)
                LI.Text = supplyItem.ProductID
                LI.SubItems.Add(supplyItem.Description)
                LI.SubItems.Add(supplyItem.LongDescription)
                LI.SubItems.Add(supplyItem.ListPrice.ToString("#,##0.00"))
                ListView2.Items.Add(LI)
            End If
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim id As String
        id = InputBox("ID")
        Dim selProduct As Product = CType(Products.Item(id.ToUpper), Product)
        If selProduct Is Nothing Then
            MsgBox("No such product was found")
        Else
            MsgBox("The price of " & selProduct.Description & _
                            " is " & selProduct.ListPrice)
        End If
    End Sub
End Class
