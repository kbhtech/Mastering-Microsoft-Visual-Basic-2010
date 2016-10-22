Public Class frmLBDemo

    ' THIS PROJECT DEMONSTRATES HOW TO MANIPULATE THE CONTENTS OF A LISTBOX CONTROL
    ' AT RUN-TIME:
    '   1. How to add items at run-time
    '   2. How to remove the selected items at run-time
    '   3. How to move items between two lists
    '   4. How to change the selection mode of a ListBox control at run-time

    Private Sub btttnDestinationAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btttnDestinationAdd.Click
        Dim ListItem As String
        ListItem = InputBox("Enter new item's name")
        If ListItem.Trim <> "" Then
            destinationList.Items.Add(ListItem)
        End If
    End Sub

    Private Sub bttnSourceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSourceAdd.Click
        Dim ListItem As String
        ListItem = InputBox("Enter new item's name")
        If ListItem.Trim <> "" Then
            sourceList.Items.Add(ListItem)
        End If
    End Sub

    Private Sub bttnDestinationRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDestinationRemove.Click
        destinationList.Items.Remove(destinationList.SelectedItem)
    End Sub

    Private Sub bttnSourceRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSourceRemove.Click
        Dim i As Integer
        For i = 0 To sourceList.SelectedIndices.Count - 1
            ' always remove the first selected selected item!
            ' Do not use the index i to select the item to be removed:
            ' THE STATEMENT:
            ' sourceList.Items.RemoveAt(sourceList.SelectedIndices(i))
            ' WILL NOT REMOVE THE CORRECT ITEMS, BECAUSE THE COLLECTION
            ' SELECTEDINDICES CHANGES EVERY TIME YOU REMOVE AN ITEM!
            ' This loop keeps removing the top selected item, 
            ' as long as there are selected items.
            sourceList.Items.RemoveAt(sourceList.SelectedIndices(0))
        Next
    End Sub

    Private Sub bttnDestinationMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDestinationMove.Click
        If destinationList.SelectedItems.Count > 0 Then
            destinationList.Items.Add(destinationList.SelectedItem)
            destinationList.Items.RemoveAt(destinationList.SelectedIndex)
        End If
    End Sub

    Private Sub bttnSourceMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSourceMoveAll.Click
        While sourceList.Items.Count > 0
            ' Keep adding to the destination list the top item
            ' in the source list.
            ' This loop is similar to the one we use to remove
            ' multiple selected items from the source list
            destinationList.Items.Add(sourceList.Items(0))
            sourceList.Items.RemoveAt(0)
        End While
    End Sub

    Private Sub bttnSourceMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSourceMove.Click
        While sourceList.SelectedIndices.Count > 0
            ' Keep adding to the destination list the top selected item
            ' in the source list.
            ' This loop is similar to the one we use to remove
            ' multiple selected items from the source list
            destinationList.Items.Add(sourceList.Items(sourceList.SelectedIndices(0)))
            sourceList.Items.Remove(sourceList.Items(sourceList.SelectedIndices(0)))
        End While
    End Sub

    Private Sub bttnSourceClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSourceClear.Click
        sourceList.Items.Clear()
    End Sub

    Private Sub bttnDestinationClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDestinationClear.Click
        destinationList.Items.Clear()
    End Sub

    Private Sub bttnDestinationMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDestinationMoveAll.Click
        While destinationList.Items.Count > 0
            sourceList.Items.Add(destinationList.Items(0))
            destinationList.Items.RemoveAt(0)
        End While
    End Sub


    Private Sub rbSelectSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSelectSimple.CheckedChanged, rbSelectExtended.CheckedChanged
        ' Set the SelectionMode property of the sourceList control
        ' according to the checked radio button
        If rbSelectSimple.Checked Then
            sourceList.SelectionMode = SelectionMode.MultiSimple
        Else
            sourceList.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub

End Class
