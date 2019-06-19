Public Class ListingConfigForm

    Protected Shadows ParentForm
    Protected Shadows Config

    Public Overridable Sub ListingConfigForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Overridable Sub SaveConfig()

    End Sub

    Private Sub SaveConfigButton_Click(sender As Object, e As EventArgs) Handles SaveConfigButton.Click
        SaveConfig()
        Dim RecordBinding As BindingSource = ParentForm.LoadListingData(Me)
        ParentForm.LoadColumns(RecordBinding)
        Me.Close()
    End Sub

    Private Sub CheckBoxOnButton_Click(sender As Object, e As EventArgs) Handles CheckBoxOnButton.Click
        For i = 0 To ColumnDisplayListView.Items.Count - 1
            ColumnDisplayListView.Items(i).Checked = True
        Next
    End Sub

    Private Sub CheckBoxOffButton_Click(sender As Object, e As EventArgs) Handles CheckBoxOffButton.Click
        For i = 0 To ColumnDisplayListView.Items.Count - 1
            ColumnDisplayListView.Items(i).Checked = False
        Next
    End Sub
End Class