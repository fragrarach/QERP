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
End Class