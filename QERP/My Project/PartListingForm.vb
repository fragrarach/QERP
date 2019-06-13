Public Class PartListingForm

    Friend WithEvents ActivePartsCheckBox As New CheckBox With {
            .Text = "Show Inactive",
            .Checked = True
        }

    Friend WithEvents KeepOpenCheckBox As New CheckBox With {
            .Text = "Keep Open",
            .Checked = True
        }

    Shadows ParentForm As PartForm

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

    Private Sub PartListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        End If

        Dim ActivePartsHost As New ToolStripControlHost(ActivePartsCheckBox)
        PartListingToolStrip.Items.Add(ActivePartsHost)

        Dim ToolStripSeparator2 As New ToolStripSeparator
        PartListingToolStrip.Items.Add(ToolStripSeparator2)

        Dim KeepOpenHost As New ToolStripControlHost(KeepOpenCheckBox)
        PartListingToolStrip.Items.Add(KeepOpenHost)

        LoadPartCount()

        LoadColumns()

        LoadListingData(Me)

        If ParentForm.GetType() Is GetType(PartForm) Then
            If ParentForm.SelectedPartTextBox.Text IsNot Nothing Then
                PartSearch(ParentForm.SelectedPartTextBox, True)
            End If
        End If

    End Sub

    Public Sub LoadColumns()

        PartListDataGridView.Columns.Clear()

        PartListDataGridView.RowHeadersWidth = 20

        PartListDataGridView.Columns.Add("Column1", "Part Number")
        PartListDataGridView.Columns("Column1").Width = 112
        PartListDataGridView.Columns("Column1").Frozen = True

        If PartListingConfig.ActiveColumns(0) = True Then
            PartListDataGridView.Columns.Add("Column2", "French Description")
            PartListDataGridView.Columns("Column2").Width = 365
        End If
        If PartListingConfig.ActiveColumns(1) = True Then
            PartListDataGridView.Columns.Add("Column3", "English Description")
            PartListDataGridView.Columns("Column3").Width = 365
        End If
        If PartListingConfig.ActiveColumns(2) = True Then
            PartListDataGridView.Columns.Add("Column4", "Internal Description")
            PartListDataGridView.Columns("Column4").Width = 365
        End If
        If PartListingConfig.ActiveColumns(3) = True Then
            PartListDataGridView.Columns.Add("Column5", "Sort Key")
            PartListDataGridView.Columns("Column5").Width = 75
        End If
        If PartListingConfig.ActiveColumns(4) = True Then
            PartListDataGridView.Columns.Add("Column6", "Part Type")
            PartListDataGridView.Columns("Column6").Width = 75
        End If
        If PartListingConfig.ActiveColumns(5) = True Then
            PartListDataGridView.Columns.Add("Column7", "Group #")
            PartListDataGridView.Columns("Column7").Width = 75
        End If
        If PartListingConfig.ActiveColumns(6) = True Then
            PartListDataGridView.Columns.Add("Column8", "UPC #")
            PartListDataGridView.Columns("Column8").Width = 75
        End If
        If PartListingConfig.ActiveColumns(7) = True Then
            PartListDataGridView.Columns.Add("Column9", "Location")
            PartListDataGridView.Columns("Column9").Width = 100
        End If

        Dim UserColumns As List(Of String) = FilerMethods.LoadPartIndexes()
        For i = 0 To UserColumns.Count - 1
            If PartListingConfig.ActiveColumns(9 + i) = True Then
                PartListDataGridView.Columns.Add("Column" & (9 + i), UserColumns(i))
                PartListDataGridView.Columns("Column" & (9 + i)).Width = 120
            End If
        Next

    End Sub

    Private Function CountQueryBuilder()
        Dim Query As String = "SELECT COUNT(*) FROM part "

        If ActivePartsCheckBox.Checked = False Then
            Query += "WHERE prt_active = TRUE "
        End If

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim PartCount As String = Record(0, 0)
        Return PartCount
    End Function

    Private Function ListingQueryBuilder()
        Dim Query As String = "SELECT p.prt_no"

        If PartListingConfig.ActiveColumns(0) = True Then
            Query += ", p.prt_desc1"
        End If
        If PartListingConfig.ActiveColumns(1) = True Then
            Query += ", p.prt_desc2"
        End If
        If PartListingConfig.ActiveColumns(2) = True Then
            Query += ", p.prt_desc3"
        End If
        If PartListingConfig.ActiveColumns(3) = True Then
            Query += ", p.prt_sort"
        End If
        If PartListingConfig.ActiveColumns(4) = True Then
            Query += ", p.prt_type"
        End If
        If PartListingConfig.ActiveColumns(5) = True Then
            Query += ", pg.pgr_no"
        End If
        If PartListingConfig.ActiveColumns(6) = True Then
            Query += ", p.prt_upc"
        End If
        If PartListingConfig.ActiveColumns(7) = True Then
            Query += ", p.prt_location"
        End If

        Dim k As Int16 = 1
        For i = 1 To 3
            For j = 1 To 5
                If PartListingConfig.ActiveColumns(8 + k) = True Then
                    Query += ", p.prt_idx" & i & "_" & j
                End If
                k += 1
            Next
        Next

        Query += " FROM part p JOIN part_group pg ON p.pgr_id = pg.pgr_id "

        If ActivePartsCheckBox.Checked = False Then
            Query += "WHERE prt_active = TRUE "
        End If

        Query += "ORDER BY p.prt_no"

        Return Query

    End Function

    Public Sub LoadListingData(ByRef ParentForm As Form)
        Console.WriteLine("LOAD START " + TimeString)
        Dim Query As String = ListingQueryBuilder()
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            PartListDataGridView.Rows.Clear()

            Dim Max As Int16 = (UBound(Record, 2) + 1)
            Dim LoadingText As String = "Loading Parts - "
            LoadingForm.LoadingBarInit(Max, LoadingText, ParentForm)

            For RowIndex = 0 To UBound(Record, 2)
                PartListDataGridView.Rows.Add()
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        PartListDataGridView.Item(ColumnIndex, RowIndex).Value = Trim(Record(ColumnIndex, RowIndex))
                    Else
                        PartListDataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex, RowIndex)
                    End If
                Next
                LoadingForm.LoadingBarIncrement()
            Next
            LoadingForm.Close()

        End If

        ExtensionMethods.DoubleBuffered(Me.PartListDataGridView, True)
        Console.WriteLine("LOAD FINISH " + TimeString)
    End Sub

    Private Sub PartListDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PartListDataGridView.CellDoubleClick
        If ParentForm.GetType() Is GetType(PartForm) Then
            If e.ColumnIndex = 0 Then
                ParentForm.SelectedPartTextBox.Text = PartListDataGridView.Item(0, e.RowIndex).Value
                If KeepOpenCheckBox.Checked = False Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub PartListSearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartListSearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PartSearch(PartListSearchTextBox)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PartListDataGridView_Sorted(sender As Object, e As EventArgs) Handles PartListDataGridView.Sorted
        SearchFieldGroupBox.Text = "Search Field : " & PartListDataGridView.SortedColumn.HeaderText
    End Sub

    Private Sub LoadPartCount()
        Dim PartCount As String = CountQueryBuilder()
        PartCountToolStripTextBox.Text = PartCount + " Records"
    End Sub

    Private Sub ActivePartsCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ActivePartsCheckBox.CheckStateChanged
        LoadListingData(Me)
        LoadPartCount()
    End Sub

    Private Sub PartSearch(ByRef TextBoxRef As TextBox, Optional ExactMatch As Boolean = False)

        If TextBoxRef.Text IsNot Nothing Then

            Dim SearchTerm As String
            If ExactMatch = False Then
                SearchTerm = "*" & UCase(TextBoxRef.Text) & "*"
            Else
                SearchTerm = TextBoxRef.Text
            End If

            Dim ColumnIndex As Int16
            If PartListDataGridView.SortedColumn Is Nothing Then
                ColumnIndex = 0
            Else
                ColumnIndex = PartListDataGridView.SortedColumn.Index
            End If

            While 1
                For RowIndex = PartListDataGridView.CurrentRow.Index + 1 To PartListDataGridView.RowCount - 1
                    If PartListDataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        PartListDataGridView.ClearSelection()
                        PartListDataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        PartListDataGridView.FirstDisplayedScrollingRowIndex = PartListDataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                For RowIndex = 0 To PartListDataGridView.CurrentRow.Index - 1
                    If PartListDataGridView.Item(ColumnIndex, RowIndex).Value Like SearchTerm Then
                        PartListDataGridView.ClearSelection()
                        PartListDataGridView.Item(ColumnIndex, RowIndex).Selected = True
                        PartListDataGridView.FirstDisplayedScrollingRowIndex = PartListDataGridView.CurrentRow.Index
                        Exit While
                    End If
                Next
                Exit While
            End While

        End If
    End Sub

    Private Sub ColumnConfigButton_Click(sender As Object, e As EventArgs) Handles ColumnConfigButton.Click
        PartListingConfigForm.ShowDialog()
    End Sub

    Private Sub PartListingForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class