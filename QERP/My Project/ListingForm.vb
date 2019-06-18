Public Class ListingForm

    Protected Shadows ParentForm As PartForm
    Protected Shadows Table As String

    Public Overridable Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If

        LoadCount()

        Dim RecordBinding As BindingSource = LoadListingData(Me)

        LoadColumns(RecordBinding)

    End Sub

    Public Overridable Sub LoadColumns(RecordBinding As BindingSource)

    End Sub

    Public Overridable Function CountQueryBuilder()

    End Function

    Public Overridable Function ListingQueryBuilder()

    End Function

    Public Function LoadListingData(ByRef ParentForm As Form)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable
        Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
        }


        If Record IsNot Nothing Then
            'DataGridView.Rows.Clear()
            DataGridView.Columns.Clear()

            Dim Max As Int32 = (UBound(Record, 2) + 1)
            'Change reference
            Dim LoadingText As String = "Loading - "
            LoadingForm.LoadingBarInit(Max, LoadingText, ParentForm)

            For ColumnIndex = 0 To UBound(Record, 1)
                RecordTable.Columns.Add(ColumnIndex)
            Next

            For RowIndex = 0 To UBound(Record, 2)
                Dim RecordRow As DataRow = RecordTable.NewRow
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        RecordRow(ColumnIndex) = Trim(Record(ColumnIndex, RowIndex))
                    ElseIf TypeOf Record(ColumnIndex, RowIndex) Is DateTime Then
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex).ToShortDateString()
                    Else
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex)
                    End If
                Next
                RecordTable.Rows.Add(RecordRow)
                LoadingForm.LoadingBarIncrement()
            Next


            LoadingForm.Close()
        End If

        ExtensionMethods.DoubleBuffered(Me.DataGridView, True)
        Console.WriteLine("LOAD FINISH " + TimeString)

        Return RecordBinding
    End Function

    Public Overridable Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick

    End Sub

    Private Sub DataGridView_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles DataGridView.SortCompare
        If IsDBNull(e.CellValue1) Then e.SortResult += 1 : e.Handled = True
        If IsDBNull(e.CellValue2) Then e.SortResult -= 1 : e.Handled = True
        If e.Column.DataGridView.SortOrder = SortOrder.Descending Then e.SortResult = -e.SortResult
        If e.Column.DataGridView.SortOrder = SortOrder.Ascending Then e.SortResult = -e.SortResult
    End Sub

    Private Sub SearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search(SearchTextBox)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DataGridView_Sorted(sender As Object, e As EventArgs) Handles DataGridView.Sorted
        SearchFieldGroupBox.Text = "Search Field : " & DataGridView.SortedColumn.HeaderText
    End Sub

    Public Sub LoadCount()
        Dim Count As String = CountQueryBuilder()
        CountToolStripTextBox.Text = Count + " Records"
    End Sub

    Public Sub Search(ByRef TextBoxRef As TextBox, Optional ExactMatch As Boolean = False)

        If TextBoxRef.Text IsNot Nothing Then

            Dim SearchTerm As String
            If ExactMatch = False Then
                SearchTerm = "*" & UCase(TextBoxRef.Text) & "*"
            Else
                SearchTerm = TextBoxRef.Text
            End If

            Dim ColumnIndex As Int16
            If DataGridView.SortedColumn Is Nothing Then
                ColumnIndex = 0
            Else
                ColumnIndex = DataGridView.SortedColumn.Index
            End If

            While 1
                For RowIndex = DataGridView.CurrentRow.Index + 1 To DataGridView.RowCount - 1
                    If DataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        DataGridView.ClearSelection()
                        DataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                For RowIndex = 0 To DataGridView.CurrentRow.Index - 1
                    If DataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        DataGridView.ClearSelection()
                        DataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                Exit While
            End While

        End If
    End Sub

    Public Overridable Sub ColumnConfigButton_Click(sender As Object, e As EventArgs) Handles ColumnConfigButton.Click

    End Sub

    Private Sub ListingForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class