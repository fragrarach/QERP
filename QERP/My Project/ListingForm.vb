Public Class ListingForm

    Protected Shadows ParentForm
    Protected Shadows Table As String
    Public WithEvents SearchWord As New SearchWord

    Public Overridable Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If

        Dim RecordBinding As BindingSource = LoadListingData(Me)

        LoadColumns(RecordBinding)

        LoadCount()

    End Sub

    Public Overridable Sub LoadColumns(Optional RecordBinding As BindingSource = Nothing)

    End Sub

    Public Overridable Function CountQueryBuilder()
        Dim Count As String = Me.DataGridView.RowCount
        Return Count
    End Function

    Public Overridable Function ListingQueryBuilder()

    End Function

    Public Function LoadListingData(ByRef Optional ParentForm As Form = Nothing)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable
        Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
        }

        If Record IsNot Nothing Then
            DataGridView.Columns.Clear()

            Dim Max As Int32 = (UBound(Record, 2) + 1)
            Dim LoadingText As String = "Loading - "
            If Not IsNothing(ParentForm) Then
                LoadingBarForm.LoadingBarInit(Max, LoadingText, ParentForm)
            Else
                LoadingBarForm.LoadingBarInit(Max, LoadingText)
            End If

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
                LoadingBarForm.LoadingBarIncrement()
            Next
            LoadingBarForm.Close()
        End If

        ExtensionMethods.DoubleBuffered(Me.DataGridView, True)
        Console.WriteLine("LOAD FINISH " + TimeString)

        Return RecordBinding
    End Function

    Public Overridable Sub DataGridView_CellStateChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick

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
        CountToolStripLabel.Text = Count + " Records"
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

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim MySearch As New SearchForm(Me) With {
            .Owner = Me.Owner,
            .MdiParent = Me.MdiParent
        }
        MySearch.Show()
    End Sub

    Private Sub SearchWordChanged(ByVal NewWord As String) Handles SearchWord.SearchWordChanged

        ListingToolStrip.Items.Remove(ListingToolStrip.Items("SearchWordToolStripSeparator"))
        ListingToolStrip.Items.Remove(ListingToolStrip.Items("SearchWordToolStripLabel"))

        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)

        LoadCount()

        If NewWord <> "" Then
            Dim SearchWordToolStripSeparator As New ToolStripSeparator With {
                .Name = "SearchWordToolStripSeparator"
            }
            ListingToolStrip.Items.Add(SearchWordToolStripSeparator)

            Dim SearchWordToolStripLabel As New ToolStripLabel With {
                .Text = "Search Keyword : " & NewWord,
                .Name = "SearchWordToolStripLabel"
            }
            ListingToolStrip.Items.Add(SearchWordToolStripLabel)
        End If

    End Sub

    Private Sub DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting
        If SearchWord.Variable <> "" And e.RowIndex >= 0 Then

            Dim BoldFont As New Font(Me.DataGridView.DefaultCellStyle.Font, FontStyle.Bold)
            Dim Cell As DataGridViewCell = Me.DataGridView.Item(e.ColumnIndex, e.RowIndex)
            Dim CellValue As String = Cell.Value.ToString.ToUpper

            If CellValue.IndexOf(SearchWord.Variable.ToUpper) <> -1 Then
                Cell.Style.Font = BoldFont
            End If

        End If
    End Sub

    Public Overridable Sub DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellValueChanged

    End Sub
End Class