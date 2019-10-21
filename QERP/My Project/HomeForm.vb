Public Class HomeForm
    Private Sub PartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsToolStripMenuItem.Click
        Dim PartFormInstance As New PartForm(Me) With {
            .Owner = Me,
            .MdiParent = Me
        }
        PartFormInstance.Show()
    End Sub

    Private Sub PlanningBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanningBookToolStripMenuItem.Click
        Dim PLQListingFormInstance As New PLQListingForm(Me) With {
            .Owner = Me,
            .MdiParent = Me
        }
        PLQListingFormInstance.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim OrderListingFormInstance As New OrderListingForm(Me) With {
            .Owner = Me,
            .MdiParent = Me
        }
        OrderListingFormInstance.Show()
    End Sub

    Private Sub WeightsDimsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeightsDimsToolStripMenuItem.Click
        Dim PLQListingFormInstance As New WeightsDimsListingForm(Me) With {
            .Owner = Me,
            .MdiParent = Me
        }
        PLQListingFormInstance.Show()
    End Sub

    Private Sub BillOfMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillOfMaterialsToolStripMenuItem.Click
        Dim BomFormInstance As New BomForm(Me) With {
            .Owner = Me,
            .MdiParent = Me
        }
        BomFormInstance.Show()
    End Sub
End Class