Public Class frmTreeView
    Private Sub bttnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCategories.Click
        TreeView1.Nodes.Add("Shapes")
        TreeView1.Nodes.Add("Solids")
        TreeView1.Nodes.Add("Colors")
        EnableButtons()
    End Sub

    Private Sub bttnColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnColors.Click
        Dim cnode As TreeNode
        cnode = TreeView1.Nodes(2)
        cnode.Nodes.Add("Pink")
        cnode.Nodes.Add("Maroon")
        cnode.Nodes.Add("Teal")
        cnode.Expand()
    End Sub

    Private Sub bttnShapes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShapes.Click
        Dim cnode As TreeNode
        cnode = TreeView1.Nodes(0)
        cnode.Nodes.Add("Square")
        cnode.Nodes.Add("Triangle")
        cnode.Nodes.Add("Circle")
    End Sub

    Private Sub bttnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPopulate.Click
        Dim cnode As TreeNode

        cnode = TreeView1.Nodes.Add("Shapes")
        cnode.Nodes.Add("Square")
        cnode.Nodes.Add("Triangle")
        cnode.Nodes.Add("Circle")

        cnode = TreeView1.Nodes.Add("Solids")
        cnode = TreeView1.Nodes.Add("Colors")
        cnode.Nodes.Add("Pink")
        cnode.Nodes.Add("Maroon")
        cnode.Nodes.Add("Teal")
        cnode.Expand()

        bttnMoveTree.Enabled = True
    End Sub

    Private Sub bttnPopulateSorted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPopulateSorted.Click
        TreeView1.Sorted = True
        bttnPopulate_Click(sender, e)
        bttnMoveTree.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TreeView1.Sorted = True
    End Sub

    Private Sub brrnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brrnClear.Click
        TreeView1.Nodes.Clear()
        DisableButtons()
    End Sub

    Sub EnableButtons()
        bttnColors.Enabled = True
        bttnShapes.Enabled = True
        bttnMoveTree.Enabled = False
    End Sub

    Sub DisableButtons()
        bttnColors.Enabled = False
        bttnShapes.Enabled = False
    End Sub


    ' Notice that you can't move the entire tree under the same root twice.
    ' If you click this button for a second time, a run-time error will occur
    Private Sub bttnMoveTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMoveTree.Click
        Dim colorNode, shapeNode, solidNode As TreeNode
        colorNode = TreeView1.Nodes(0)
        shapeNode = TreeView1.Nodes(1)
        solidNode = TreeView1.Nodes(2)
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("Items")
        TreeView1.Nodes(0).Nodes.Add(colorNode)
        TreeView1.Nodes(0).Nodes.Add(shapeNode)
        TreeView1.Nodes(0).Nodes.Add(solidNode)
        bttnMoveTree.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TreeView1.ShowLines = True
        Else
            TreeView1.ShowLines = False
        End If
        TreeView1.Refresh()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TreeView1.ShowRootLines = True
        Else
            TreeView1.ShowRootLines = False
        End If
        TreeView1.Refresh()
    End Sub
End Class
