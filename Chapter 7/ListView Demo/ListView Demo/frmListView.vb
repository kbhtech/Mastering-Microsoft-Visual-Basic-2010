Public Class frmListView

    Private Sub rdTile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTile.CheckedChanged
        If rdTile.Checked Then ListView1.View = View.Tile
    End Sub

    Private Sub rdDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDetails.CheckedChanged
        If rdDetails.Checked Then ListView1.View = View.Details
    End Sub

    Private Sub rdList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdList.CheckedChanged
        If rdList.Checked Then ListView1.View = View.List
    End Sub

    Private Sub rdSmallIcons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSmallIcons.CheckedChanged
        If rdSmallIcons.Checked Then ListView1.View = View.SmallIcon
    End Sub

    Private Sub rdIcons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdIcons.CheckedChanged
        ListView1.View = View.LargeIcon
    End Sub

    Private Sub bttnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPopulate.Click
        ListView1.Items.Clear()
        Dim LItem As New ListViewItem
        LItem.Text = "Alfreds Futterkiste"
        LItem.SubItems.Add("Anders Maria")
        LItem.SubItems.Add("030-0074321")
        LItem.SubItems.Add("030-0076545")
        LItem.ImageIndex = 0
        LItem.UseItemStyleForSubItems = True
        LItem.Group = ListView1.Groups(0)
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Around the Horn"
        LItem.SubItems.Add("Hardy Thomas")
        LItem.SubItems.Add("(171) 555-7788")
        LItem.SubItems.Add("(171) 555-6750")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
        LItem.Group = ListView1.Groups(0)

        LItem = New ListViewItem
        LItem.Text = "Princesa Isabel Vinhos"
        LItem.SubItems.Add("de Castro Isabel")
        LItem.SubItems.Add("(1) 356-5634")
        LItem.SubItems.Add("")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
        LItem.Group = ListView1.Groups(1)

        LItem = New ListViewItem
        LItem.Text = "Furia Bacalhau e Frutos do Mar"
        LItem.SubItems.Add("Rodriguez Lino")
        LItem.SubItems.Add("(1) 354-2534")
        LItem.SubItems.Add("(1) 354-2535")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
        LItem.Group = ListView1.Groups(1)

        LItem = New ListViewItem
        LItem.Text = "Alfreds Futterkiste"
        LItem.SubItems.Add("Anders Maria")
        LItem.SubItems.Add("030-0074321")
        LItem.SubItems.Add("030-0076545")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
        LItem.Group = ListView1.Groups(0)

        LItem = New ListViewItem
        LItem.Text = "Around the Horn"
        LItem.SubItems.Add("Hardy Thomas")
        LItem.SubItems.Add("(171) 555-7788")
        LItem.SubItems.Add("(171) 555-6750")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
        LItem.Group = ListView1.Groups(1)

        LItem = New ListViewItem
        LItem.Text = "Bottom-Dollar Markets"
        LItem.SubItems.Add("Lincoln Elizabeth")
        LItem.SubItems.Add("(604) 555-4729")
        LItem.SubItems.Add("(604) 555-3745")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Cactus Comidas para llevar"
        LItem.SubItems.Add("SimpsonPatricio")
        LItem.SubItems.Add("(1)135-5555")
        LItem.SubItems.Add("(1)135-4892")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Eastern Connection"
        LItem.SubItems.Add("Devon Ann")
        LItem.SubItems.Add("(171) 555-0297")
        LItem.SubItems.Add("(171) 555-3373")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Galera del gastr�nomo"
        LItem.SubItems.Add("Saavedra Eduardo")
        LItem.SubItems.Add("(93) 203 4560")
        LItem.SubItems.Add("(93) 203 4561")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Godos Cocina T�pica"
        LItem.SubItems.Add("Freyre Jos� Pedro")
        LItem.SubItems.Add("(95) 555 82 82")
        LItem.SubItems.Add("(93) 203 4561")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Island Trading"
        LItem.SubItems.Add("Bennett Helen")
        LItem.SubItems.Add("(198) 555-8888")
        LItem.SubItems.Add("(93) 203 4561")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "La maison d'Asie"
        LItem.SubItems.Add("Roulet Annette")
        LItem.SubItems.Add("61.77.61.10")
        LItem.SubItems.Add("61.77.61.11")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Rattlesnake Canyon Grocery"
        LItem.SubItems.Add("Wilson Paula")
        LItem.SubItems.Add("(505) 555-5939")
        LItem.SubItems.Add("(505) 555-3620")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "The Big Cheese"
        LItem.SubItems.Add("Nixon Liz")
        LItem.SubItems.Add("(503) 555-3612")
        LItem.SubItems.Add("")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Victuailles en stock"
        LItem.SubItems.Add("SaveleyMary")
        LItem.SubItems.Add("78.32.54.86")
        LItem.SubItems.Add("78.32.54.87")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Wartian Herkku"
        LItem.SubItems.Add("Koskitalo Pirkko")
        LItem.SubItems.Add("981-443655")
        LItem.SubItems.Add("981-443655")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)

        LItem = New ListViewItem
        LItem.Text = "Wellington Importadora"
        LItem.SubItems.Add("Parente Paula")
        LItem.SubItems.Add("(14) 555-8122")
        LItem.SubItems.Add("")
        LItem.ImageIndex = 0
        ListView1.Items.Add(LItem)
    End Sub

    Private Sub rdDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDefault.CheckedChanged
        ListView1.ArrangeIcons(ListViewAlignment.Default)
    End Sub

    Private Sub rdLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLeft.CheckedChanged
        ListView1.ArrangeIcons(ListViewAlignment.Left)
    End Sub

    Private Sub rdTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTop.CheckedChanged
        ListView1.ArrangeIcons(ListViewAlignment.Top)
    End Sub

    Private Sub bttnEnumerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEnumerate.Click
        Dim i, j As Integer
        Dim LItem As ListViewItem

        For i = 0 To ListView1.Items.Count - 1
            LItem = ListView1.Items(i)
            Debug.WriteLine(LItem.Text)
            For j = 0 To LItem.SubItems.Count - 1
                Debug.WriteLine("   " & ListView1.Columns(j).Text & "  " & LItem.SubItems(j).Text)
            Next
        Next
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Select Case e.Column
            Case 0
                ListView1.ListViewItemSorter = New ListCompanySorter
                ListView1.Sorting = SortOrder.Ascending
            Case 1
                ListView1.ListViewItemSorter = New ListContactSorter
                ListView1.Sorting = SortOrder.Ascending
        End Select
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Dim LItem As ListViewItem
        Dim LItems As ListView.SelectedListViewItemCollection
        LItems = ListView1.SelectedItems
        For Each LItem In LItems
            Debug.Write(LItem.Text & vbTab)
            Debug.Write(LItem.SubItems(0).ToString & vbTab)
            Debug.Write(LItem.SubItems(1).ToString & vbTab)
            Debug.WriteLine(LItem.SubItems(2).ToString & vbTab)
        Next
    End Sub

    Private Sub bttnIterate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnIterate.Click
        Dim LItem As ListViewItem
        Dim LItems As ListView.SelectedListViewItemCollection
        LItems = ListView1.SelectedItems
        For Each LItem In LItems
            Debug.Write(LItem.Text & vbTab)
            Debug.Write(LItem.SubItems(0).ToString & vbTab)
            Debug.Write(LItem.SubItems(1).ToString & vbTab)
            Debug.WriteLine(LItem.SubItems(2).ToString & vbTab)
        Next
    End Sub

End Class

' The ListCompanySorter contains the CompareTo method, which enables
' the control to sort its item by company name
' The Company field is the ListItem's Text property
Class ListCompanySorter
    Implements IComparer
    Public Function CompareTo(ByVal o1 As Object, ByVal o2 As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(o1, ListViewItem)
        item2 = CType(o2, ListViewItem)
        If item1.ToString.ToUpper > item2.ToString.ToUpper Then
            Return 1
        Else
            If item1.ToString.ToUpper < item2.ToString.ToUpper Then
                Return -1
            Else
                Return 0
            End If
        End If
    End Function
End Class

' The ListCompanySorter contains the CompareTo method, which enables
' the control to sort its item by contact name
' The ContactName field is the first subitem of each ListItem
Class ListContactSorter
    Implements IComparer
    Public Function CompareTo(ByVal o1 As Object, ByVal o2 As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(o1, ListViewItem)
        item2 = CType(o2, ListViewItem)
        If item1.SubItems(1).ToString.ToUpper > item2.SubItems(1).ToString.ToUpper Then
            Return 1
        Else
            If item1.SubItems(1).ToString.ToUpper < item2.SubItems(1).ToString.ToUpper Then
                Return -1
            Else
                Return 0
            End If
        End If
    End Function
End Class

