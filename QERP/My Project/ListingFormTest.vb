Public Class ListingFormTest

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

        LoadListingData(Me)

        LoadColumns()

    End Sub

    Public Overridable Sub LoadColumns()
        Dim ColumnIndex As Int16 = 0

        DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Line Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        ColumnIndex += 1
        DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Part Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        'Me.DataGridView.Columns.Add("Column3", "Part Description")
        'Me.DataGridView.Columns("Column3").Width = 112

        'Me.DataGridView.Columns.Add("Column4", "Slip #")
        'Me.DataGridView.Columns("Column4").Width = 112

        'Me.DataGridView.Columns.Add("Column5", "Required Date")
        'Me.DataGridView.Columns("Column5").Width = 112
        'Me.DataGridView.Columns("Column5").DefaultCellStyle.Format = "d"

        'Me.DataGridView.Columns.Add("Column6", "Quantity")
        'Me.DataGridView.Columns("Column6").Width = 112

        'Me.DataGridView.Columns.Add("Column7", "Price")
        'Me.DataGridView.Columns("Column7").Width = 112
        'Me.DataGridView.Columns("Column7").DefaultCellStyle.Format = "c"

        'Me.DataGridView.Columns.Add("Column8", "Discount")
        'Me.DataGridView.Columns("Column8").Width = 112
        'Me.DataGridView.Columns("Column8").DefaultCellStyle.Format = "p"

        'Me.DataGridView.Columns.Add("Column9", "Reserved")
        'Me.DataGridView.Columns("Column9").Width = 112

        'Me.DataGridView.Columns.Add("Column10", "Shipped")
        'Me.DataGridView.Columns("Column10").Width = 112

        'Me.DataGridView.Columns.Add("Column11", "Ready")
        'Me.DataGridView.Columns("Column11").Width = 112

        'Me.DataGridView.Columns.Add("Column12", "Prepared")
        'Me.DataGridView.Columns("Column12").Width = 112
    End Sub

    Public Overridable Function CountQueryBuilder()
        Dim Query As String = "SELECT COUNT(*) FROM order_line "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim PartCount As String = Record(0, 0)
        Return PartCount
    End Function

    Public Overridable Function ListingQueryBuilder()
        Dim Query As String = "SELECT ol.orl_sort_idx "

        Query += ", ol.prt_no "

        Query += ", ol.prt_desc "

        Query += ", CASE WHEN ol.inv_pckslp_no = 0 THEN NULL ELSE ol.inv_pckslp_no END AS inv_pckslp_no "

        Query += ", ol.orl_req_dt "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_quantity END AS orl_quantity "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_price END AS orl_price "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.prt_dscnt / 100 END AS prt_dscnt "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_reserved_qty END AS orl_reserved_qty "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_ship_qty END AS orl_ship_qty "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_qty_ready END AS orl_qty_ready "

        Query += ", CASE WHEN ol.prt_no = '' THEN NULL ELSE ol.orl_qty_ready_adj END AS orl_qty_ready_adj "

        Query += "FROM order_line ol "

        Query += "WHERE ol.ord_no = 66075 "

        Query += "ORDER BY ol.orl_sort_idx "

        Return Query
    End Function

    Public Sub LoadListingData(ByRef ParentForm As Form)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable

        If Record IsNot Nothing Then
            DataGridView.Rows.Clear()

            Dim Max As Int32 = (UBound(Record, 2) + 1)
            'Change reference
            Dim LoadingText As String = "Loading - "
            LoadingForm.LoadingBarInit(Max, LoadingText, ParentForm)

            For ColumnIndex = 0 To UBound(Record, 1)
                RecordTable.Columns.Add(ColumnIndex)
            Next

            For RowIndex = 0 To UBound(Record, 2)
                Dim RecordRow As DataRow = RecordTable.NewRow
                'DataGridView.Rows.Add()
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        'DataGridView.Item(ColumnIndex, RowIndex).Value = Trim(Record(ColumnIndex, RowIndex))
                        RecordRow(ColumnIndex) = Trim(Record(ColumnIndex, RowIndex))
                    Else
                        'DataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex, RowIndex)
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex)
                    End If
                Next
                RecordTable.Rows.Add(RecordRow)
                LoadingForm.LoadingBarIncrement()
            Next
            LoadingForm.Close()

            Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
            }
            DataGridView.DataSource = RecordBinding

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