Public Class ListingForm

    Protected Shadows ParentForm As PartForm
    Protected Shadows Table As String

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Public Sub New(ByRef ParentFormArg As Form, ByRef MdiFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        Me.Owner = MdiFormArg
        Me.MdiParent = MdiFormArg
        ParentForm = ParentFormArg
    End Sub

    Private Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If

        LoadCount()

        LoadColumns()

        LoadListingData(Me)

    End Sub

    Public Overridable Sub LoadColumns()

    End Sub

    Public Overridable Function CountQueryBuilder()

    End Function

    Public Overridable Function ListingQueryBuilder()

    End Function

    Public Sub LoadListingData(ByRef ParentForm As Form)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            DataGridView.Rows.Clear()

            Dim Max As Int32 = (UBound(Record, 2) + 1)
            'Change reference
            Dim LoadingText As String = "Loading - "
            LoadingForm.LoadingBarInit(Max, LoadingText, ParentForm)

            For RowIndex = 0 To UBound(Record, 2)
                DataGridView.Rows.Add()
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        DataGridView.Item(ColumnIndex, RowIndex).Value = Trim(Record(ColumnIndex, RowIndex))
                    Else
                        DataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex, RowIndex)
                    End If
                Next
                LoadingForm.LoadingBarIncrement()
            Next
            LoadingForm.Close()

        End If

        ExtensionMethods.DoubleBuffered(Me.DataGridView, True)
        Console.WriteLine("LOAD FINISH " + TimeString)
    End Sub

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

    Private Sub LoadCount()
        Dim Count As String = CountQueryBuilder()
        CountToolStripTextBox.Text = Count + " Records"
    End Sub

    Private Sub Search(ByRef TextBoxRef As TextBox, Optional ExactMatch As Boolean = False)

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