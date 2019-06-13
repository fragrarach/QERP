Public Class PartListingConfigForm
    Private Sub PartListingConfigForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim UserColumns As List(Of String) = FilerMethods.LoadPartIndexes()
        For i = 0 To UserColumns.Count - 1
            ColumnDisplayListView.Items(i + 8).Text = UserColumns(i)
        Next
        For i = 0 To ColumnDisplayListView.Items.Count - 1
            If PartListingConfig.ActiveColumns(i) = True Then
                ColumnDisplayListView.Items(i).Checked = True
            End If
        Next
    End Sub

    Private Sub SaveConfig()
        For i = 0 To ColumnDisplayListView.Items.Count - 1
            If ColumnDisplayListView.Items(i).Checked = True Then
                PartListingConfig.ActiveColumns(i) = True
            ElseIf ColumnDisplayListView.Items(i).Checked = False Then
                PartListingConfig.ActiveColumns(i) = False
            End If
        Next
    End Sub

    Private Sub SaveConfigButton_Click(sender As Object, e As EventArgs) Handles SaveConfigButton.Click
        SaveConfig()
        PartListingForm.LoadColumns()
        PartListingForm.LoadListingData(Me)
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