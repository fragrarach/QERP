Public Class PLQListingForm

    Friend WithEvents KeepOpenCheckBox As New CheckBox With {
            .Text = "Keep Open",
            .Checked = True
        }

    Shadows ParentForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.KeyPreview = True

    End Sub

    Public Sub New(ByRef ParentFormArg As Form)

        ' This call is required by the designer.
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg

    End Sub

    Private Sub PLQGridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.MdiCenter(Me, ParentForm)
        End If

        Dim KeepOpenHost As New ToolStripControlHost(KeepOpenCheckBox)
        PLQListingToolStrip.Items.Add(KeepOpenHost)

        LoadPLQCount()

        LoadColumns()

        LoadListingData(Me)

        If ParentForm.GetType() Is GetType(LabelForm) Then
            If ParentForm.SelectedPLQTextBox.Text IsNot Nothing Then
                PLQSearch(LabelForm.SelectedPLQTextBox, True)
            End If
        End If



    End Sub

    Public Sub LoadColumns()

        PLQListDataGridView.Columns.Clear()

        PLQListDataGridView.RowHeadersWidth = 20

        PLQListDataGridView.Columns.Add("Column1", "Planning Lot Number")
        PLQListDataGridView.Columns("Column1").Width = 112
        PLQListDataGridView.Columns("Column1").Frozen = True

        'TODO : COLUMN NAMES, WIDTHS, CONFIG
        PLQListDataGridView.Columns.Add("Column2", "Created")
        PLQListDataGridView.Columns.Add("Column3", "Status")
        PLQListDataGridView.Columns.Add("Column4", "Order Number")
        PLQListDataGridView.Columns.Add("Column5", "Order Line Number")
        PLQListDataGridView.Columns.Add("Column6", "Order Line Required Date")
        PLQListDataGridView.Columns("Column6").DefaultCellStyle.Format = "d"
        PLQListDataGridView.Columns.Add("Column7", "Part Number")
        PLQListDataGridView.Columns.Add("Column8", "Part Description")
        PLQListDataGridView.Columns.Add("Column9", "Required Quantity")
        PLQListDataGridView.Columns.Add("Column10", "Transferred Quantity")
        PLQListDataGridView.Columns.Add("Column11", "Quantity to Produce")
        PLQListDataGridView.Columns.Add("Column12", "Production Date")
        PLQListDataGridView.Columns.Add("Column13", "Produced Quantity")
        PLQListDataGridView.Columns.Add("Column14", "Note")


        Dim cbColumn As New DataGridViewComboBoxColumn With {
            .Name = "Column15",
            .HeaderText = "Builder"
        }

        Dim Query As String = "SELECT emp_name FROM employee"
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        If Record IsNot Nothing Then
            For RowIndex = 0 To UBound(Record, 2)
                cbColumn.Items.Add(Trim(Record(0, RowIndex)))
            Next
        End If
        PLQListDataGridView.Columns.Add(cbColumn)

        For i = 0 To PLQListDataGridView.ColumnCount - 2
            PLQListDataGridView.Columns(i).ReadOnly = True
        Next
        PLQListDataGridView.Columns("Column15").ReadOnly = False
        PLQListDataGridView.Columns("Column15").SortMode = DataGridViewColumnSortMode.Automatic
        PLQListDataGridView.Columns.Add("Column16", "plq_id")
        PLQListDataGridView.Columns(15).Visible = False
    End Sub

    Private Function CountQueryBuilder()
        Dim Query As String = "SELECT COUNT(*) FROM planning_lot_quantity "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim PartCount As String = Record(0, 0)
        Return PartCount
    End Function

    Private Function ListingQueryBuilder()
        Dim Query As String = "SELECT plq_lot_no"

        Query += ", (plq_creation_dt + plq_creation_tm)"
        Query += ", CASE
                        WHEN
                            plq.plq_adj_flag = TRUE
                        THEN
                            'ADJUSTED'
                        WHEN
                            plq.plq_adj_flag = FALSE
                            AND plq.plq_qty_changed = TRUE
                        THEN
                            'TO BE CALCULATED'
                        WHEN
                            plq.plq_adj_flag = FALSE
                        THEN
                            'CALCULATED'
                    END AS test"
        Query += ", ord_no"
        Query += ", (SELECT orl_sort_idx FROM order_line WHERE orl_id = plq.orl_id)"
        Query += ", (SELECT orl_req_dt FROM order_line WHERE orl_id = plq.orl_id)"
        Query += ", prt_no"
        Query += ", (SELECT prt_desc2 FROM part WHERE prt_id = plq.prt_id)"
        Query += ", (SELECT orl_quantity - orl_reserved_qty - orl_ship_qty FROM order_line WHERE orl_id = plq.orl_id)"
        Query += ", (SELECT orl_trs_to_plq_tqty FROM order_line WHERE orl_id = plq.orl_id)"
        Query += ", plq_qty_per"
        Query += ", plq_prod_dt"
        Query += ", (SELECT pld_adj_qty_per FROM planning_lot_detailed WHERE plq_id = plq.plq_id AND pld_lvl = 0)"
        Query += ", plq_note"
        Query += ", CASE WHEN EXISTS (SELECT emp_name FROM plq_ext WHERE plq.plq_id = plq_id) THEN (SELECT emp_name FROM plq_ext WHERE plq.plq_id = plq_id) ELSE '' END AS emp_name"
        Query += ", plq_id"

        Query += " FROM planning_lot_quantity plq"

        Return Query

    End Function

    Public Sub LoadListingData(ByRef ParentForm As Form)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            PLQListDataGridView.Rows.Clear()

            Dim Max As Int16 = (UBound(Record, 2) + 1)
            Dim LoadingText As String = "Loading Planning Lots - "
            LoadingForm.LoadingBarInit(Max, LoadingText, ParentForm)

            For RowIndex = 0 To UBound(Record, 2)
                PLQListDataGridView.Rows.Add()
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        PLQListDataGridView.Item(ColumnIndex, RowIndex).Value = Trim(Record(ColumnIndex, RowIndex))
                    Else
                        PLQListDataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex, RowIndex)
                    End If
                Next
                LoadingForm.LoadingBarIncrement()
            Next
            LoadingForm.Close()

        End If

        ExtensionMethods.DoubleBuffered(Me.PLQListDataGridView, True)
        Console.WriteLine("LOAD FINISH " + TimeString)
    End Sub

    'Private Sub PLQListDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PLQListDataGridView.CellDoubleClick
    '    If e.ColumnIndex = 0 Then
    '        LabelForm.SelectedPLQTextBox.Text = PLQListDataGridView.Item(0, e.RowIndex).Value
    '        If KeepOpenCheckBox.Checked = False Then
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

    Private Sub PLQListSearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PLQListSearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PLQSearch(PLQListSearchTextBox)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PLQListDataGridView_Sorted(sender As Object, e As EventArgs) Handles PLQListDataGridView.Sorted
        SearchFieldGroupBox.Text = "Search Field : " & PLQListDataGridView.SortedColumn.HeaderText
    End Sub

    Private Sub PLQListDataGridView_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles PLQListDataGridView.SortCompare
        If IsDBNull(e.CellValue1) Then e.SortResult += 1 : e.Handled = True
        If IsDBNull(e.CellValue2) Then e.SortResult -= 1 : e.Handled = True
        If e.Column.DataGridView.SortOrder = SortOrder.Descending Then e.SortResult = -e.SortResult
        If e.Column.DataGridView.SortOrder = SortOrder.Ascending Then e.SortResult = -e.SortResult
    End Sub

    Private Sub LoadPLQCount()
        Dim PLQCount As String = CountQueryBuilder()
        PLQCountToolStripTextBox.Text = PLQCount + " Records"
    End Sub

    Private Sub PLQSearch(ByRef TextBoxRef As TextBox, Optional ExactMatch As Boolean = False)

        If TextBoxRef.Text IsNot Nothing Then

            Dim SearchTerm As String
            If ExactMatch = False Then
                SearchTerm = "*" & UCase(TextBoxRef.Text) & "*"
            Else
                SearchTerm = TextBoxRef.Text
            End If

            Dim ColumnIndex As Int16
            If PLQListDataGridView.SortedColumn Is Nothing Then
                ColumnIndex = 0
            Else
                ColumnIndex = PLQListDataGridView.SortedColumn.Index
            End If

            While 1
                For RowIndex = PLQListDataGridView.CurrentRow.Index + 1 To PLQListDataGridView.RowCount - 1
                    If PLQListDataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        PLQListDataGridView.ClearSelection()
                        PLQListDataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        PLQListDataGridView.FirstDisplayedScrollingRowIndex = PLQListDataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                For RowIndex = 0 To PLQListDataGridView.CurrentRow.Index - 1
                    If PLQListDataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        PLQListDataGridView.ClearSelection()
                        PLQListDataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        PLQListDataGridView.FirstDisplayedScrollingRowIndex = PLQListDataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                Exit While
            End While

        End If
    End Sub

    Private Sub ColumnConfigButton_Click(sender As Object, e As EventArgs) Handles ColumnConfigButton.Click
        'TODO: PLQ column config
        'PartListingConfigForm.ShowDialog()
    End Sub

    Private Sub PLQListDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PLQListDataGridView.CellValueChanged
        If e.ColumnIndex = 14 Then
            'TODO : Pull plq_id from DB
            If Not IsDBNull(PLQListDataGridView.Item(e.ColumnIndex, e.RowIndex).Value) And Not IsNothing(PLQListDataGridView.Item(15, e.RowIndex).Value) Then
                Dim EmpName As String = PLQListDataGridView.Item(e.ColumnIndex, e.RowIndex).Value
                Dim PlqId As String = PLQListDataGridView.Item(15, e.RowIndex).Value
                Dim Statement As String = "SELECT plq_ext_upsert(" + PlqId + ", '" + EmpName + "')"
                PostgresMethods.PostgresStatement(Statement, LogConnectionString)
            End If
        End If
    End Sub

    Private Sub PLQListingForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class