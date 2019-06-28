Imports System.ComponentModel
Imports System.Reflection

Public Class PartForm

    Shadows ParentForm

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        FormatLoadPriceDataGridViewHeaders()
    End Sub

    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Private Sub LoadData()
        SetActiveLabel()
        If TabControl1.SelectedTab Is TabPage1 Then
            LoadInformation1Tab()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            LoadInformation2Tab()
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            LoadPriceTab()
        ElseIf TabControl1.SelectedTab Is TabPage4 Then
            LoadReferencesTab()
        End If
    End Sub

    Private Sub SetActiveLabel()
        Dim Query As String = "SELECT prt_active FROM part WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            If Record(0, 0) = True Then
                ActivePartLabel.Text = "Active"
                ActivePartLabel.ForeColor = Color.Green
            Else
                ActivePartLabel.Text = "Inactive"
                ActivePartLabel.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Sub LoadInformation1Tab()
        Dim Query As String = "SELECT * FROM part_form_information_1 WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            DescFrenchTextBox.Text = Trim(Record(1, 0))
            DescEnglishTextBox.Text = Trim(Record(2, 0))
            DescInternalTextBox.Text = Trim(Record(3, 0))
            GroupTextBox.Text = Trim(Record(4, 0))
            GroupDescTextBox.Text = Trim(Record(5, 0))
            SupplierTextBox.Text = Trim(Record(6, 0))
            SupplierDescTextBox.Text = Trim(Record(7, 0))
            SortKeyTextBox.Text = Trim(Record(8, 0))
            PartTypeTextBox.Text = Trim(Record(9, 0))
            DirectedToTextBox.Text = Trim(Record(10, 0))
            FinishedPartTextBox.Text = Trim(Record(11, 0))
            LocationTextBox.Text = Trim(Record(12, 0))
            TaxableTextBox.Text = Trim(Record(13, 0))
            DemoQtyTextBox.Text = Trim(Record(14, 0))
            RepairQtyTextBox.Text = Trim(Record(15, 0))
        End If
    End Sub

    Private Sub LoadInformation2Tab()
        Dim Query As String = "SELECT * FROM part_form_information_2 WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            ProjectCategoryTextBox.Text = Trim(Record(1, 0))
            DetailedPartNumberTextBox.Text = Trim(Record(2, 0))
            SupplierPartNumberTextBox.Text = Trim(Record(3, 0))
            ProductionDelayTextBox.Text = Trim(Record(4, 0))
            UPCNumberTextBox.Text = Trim(Record(5, 0))
            DesignNumberTextBox.Text = Trim(Record(6, 0))
            DesignReleaseTextBox.Text = Trim(Record(7, 0))
            DepartmentTextBox.Text = Trim(Record(8, 0))
            SequenceTextBox.Text = Trim(Record(9, 0))
            LabelsPerPartTextBox.Text = Trim(Record(10, 0))
            PartsPerPackageTextBox.Text = Trim(Record(11, 0))
            InvoicePackagesCheckBox.Checked = Trim(Record(12, 0))
            CreationDateTextBox.Text = Trim(Record(13, 0))
            MinimumProfitTextBox.Text = Trim(Record(14, 0))
            GTINPartNumberTextBox.Text = Trim(Record(15, 0))
            PartUnitTextBox.Text = Trim(Record(16, 0))
            PartWeightTextBox.Text = Trim(Record(17, 0))
            CalculatedWeightTextBox.Text = Trim(Record(18, 0))
            PartVolumeTextBox.Text = Trim(Record(19, 0))
            PartSurfaceTextBox.Text = Trim(Record(20, 0))
            PartAxis1TextBox.Text = Trim(Record(21, 0))
            PartAxis2TextBox.Text = Trim(Record(22, 0))
            WasteTextBox.Text = Trim(Record(23, 0))
            GeneratedPartCheckBox.Checked = Trim(Record(24, 0))
            ActivePartCheckBox.Checked = Trim(Record(25, 0))
            BOAllowedCheckBox.Checked = Trim(Record(26, 0))
            PrintStatisticsCheckBox.Checked = Trim(Record(27, 0))
            ManageLotsCheckBox.Checked = Trim(Record(28, 0))

        End If
    End Sub

    Private Sub LoadPriceTab()
        LoadPriceDataGridView()
    End Sub

    Private Sub LoadPriceDataGridView()
        Dim Query As String = "SELECT * FROM part_form_prices WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        PriceDataGridView.Rows.Clear()
        For RowIndex = 0 To 4
            PriceDataGridView.Rows.Add()
            For ColumnIndex = 0 To 14
                If Record IsNot Nothing Then
                    PriceDataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex + 1, RowIndex)
                End If
            Next
        Next
        FormatLoadPriceDataGridViewRows()
    End Sub

    Private Sub FormatLoadPriceDataGridViewHeaders()
        For ColumnIndex = 4 To 6
            PriceDataGridView.Columns(ColumnIndex).HeaderCell.Style.BackColor = Color.FromArgb(216, 216, 178)
        Next
        For ColumnIndex = 7 To 8
            PriceDataGridView.Columns(ColumnIndex).HeaderCell.Style.BackColor = Color.FromArgb(180, 180, 180)
        Next
    End Sub

    Private Sub FormatLoadPriceDataGridViewRows()
        For RowIndex = 0 To 4
            For ColumnIndex = 0 To 14
                PriceDataGridView.Item(ColumnIndex, RowIndex).Style.BackColor = SystemColors.Control
            Next
        Next
    End Sub

    Private Sub LoadReferencesTab()
        LoadIndexTabs()
        LoadComments()
    End Sub

    Private Sub LoadIndexTabs()
        If TabControl2.SelectedTab Is TabPage5 Then
            LoadIndex1Tab()
        ElseIf TabControl2.SelectedTab Is TabPage6 Then
            LoadIndex2Tab()
        ElseIf TabControl2.SelectedTab Is TabPage7 Then
            LoadIndex3Tab()
        End If
    End Sub

    Private Sub LoadIndex1Tab()
        Dim PartList As List(Of String) = FilerMethods.LoadPartIndexes

        Index1DataGridView.Rows.Clear()
        Index1DataGridView.Rows.Add(PartList(0))
        Index1DataGridView.Rows.Add(PartList(1))
        Index1DataGridView.Rows.Add(PartList(2))
        Index1DataGridView.Rows.Add(PartList(3))
        Index1DataGridView.Rows.Add(PartList(4))

        Dim Query As String = "SELECT prt_idx1_1, prt_idx1_2, prt_idx1_3, prt_idx1_4, prt_idx1_5 FROM part WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            Index1DataGridView.Item(1, 0).Value = Trim(Record(0, 0))
            Index1DataGridView.Item(1, 1).Value = Trim(Record(1, 0))
            Index1DataGridView.Item(1, 2).Value = Trim(Record(2, 0))
            Index1DataGridView.Item(1, 3).Value = Trim(Record(3, 0))
            Index1DataGridView.Item(1, 4).Value = Trim(Record(4, 0))
        End If
    End Sub

    Private Sub LoadIndex2Tab()
        Dim PartList As List(Of String) = FilerMethods.LoadPartIndexes

        Index2DataGridView.Rows.Clear()
        Index2DataGridView.Rows.Add(PartList(5))
        Index2DataGridView.Rows.Add(PartList(6))
        Index2DataGridView.Rows.Add(PartList(7))
        Index2DataGridView.Rows.Add(PartList(8))
        Index2DataGridView.Rows.Add(PartList(9))

        Dim Query As String = "SELECT prt_idx2_1, prt_idx2_2, prt_idx2_3, prt_idx2_4, prt_idx2_5 FROM part WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            Index2DataGridView.Item(1, 0).Value = Trim(Record(0, 0))
            Index2DataGridView.Item(1, 1).Value = Trim(Record(1, 0))
            Index2DataGridView.Item(1, 2).Value = Trim(Record(2, 0))
            Index2DataGridView.Item(1, 3).Value = Trim(Record(3, 0))
            Index2DataGridView.Item(1, 4).Value = Trim(Record(4, 0))
        End If
    End Sub

    Private Sub LoadIndex3Tab()
        Dim PartList As List(Of String) = FilerMethods.LoadPartIndexes

        Index3DataGridView.Rows.Clear()
        Index3DataGridView.Rows.Add(PartList(10))
        Index3DataGridView.Rows.Add(PartList(11))
        Index3DataGridView.Rows.Add(PartList(12))
        Index3DataGridView.Rows.Add(PartList(13))
        Index3DataGridView.Rows.Add(PartList(14))

        Dim Query As String = "SELECT prt_idx3_1, prt_idx3_2, prt_idx3_3, prt_idx3_4, prt_idx3_5 FROM part WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            Index3DataGridView.Item(1, 0).Value = Trim(Record(0, 0))
            Index3DataGridView.Item(1, 1).Value = Trim(Record(1, 0))
            Index3DataGridView.Item(1, 2).Value = Trim(Record(2, 0))
            Index3DataGridView.Item(1, 3).Value = Trim(Record(3, 0))
            Index3DataGridView.Item(1, 4).Value = Trim(Record(4, 0))
        End If
    End Sub

    Private Sub LoadComments()
        Dim Query As String = "SELECT prt_note, prt_note_display, prt_add_note FROM part WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            CommentsTextBox.Text = Trim(Record(0, 0))
            DisplayCommentCheckBox.Checked = Trim(Record(1, 0))
            AddCommentCheckBox.Checked = Trim(Record(2, 0))
        End If

    End Sub

    Private Sub PartNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartSearchTextBox.KeyDown
        If e.KeyValue = 13 And PartSearchTextBox.Text <> "" Then
            PartSearch()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PartSearch()
        Dim PartSearch As String = Trim(PartSearchTextBox.Text.ToUpper)
        Dim Query As String = "SELECT prt_no FROM part WHERE prt_no ='" & PartSearch & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            SelectedPartTextBox.Text = PartSearch
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub SelectedPartTextBox_TextChanged(sender As Object, e As EventArgs) Handles SelectedPartTextBox.TextChanged
        LoadData()
    End Sub

    Private Sub FirstPartButton_Click(sender As Object, e As EventArgs) Handles FirstPartButton.Click
        Dim Query As String = "SELECT DISTINCT FIRST_VALUE(prt_no) OVER (ORDER BY prt_no ASC) FROM part WHERE prt_active = TRUE"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim FirstPart As String = Record(0, 0)
        SelectedPartTextBox.Text = FirstPart
    End Sub

    Private Sub PreviousPartButton_Click(sender As Object, e As EventArgs) Handles PreviousPartButton.Click
        Dim Query As String = "SELECT prev_prt_no FROM part_form_prev_next WHERE prt_no = '" + SelectedPartTextBox.Text + "' AND prev_prt_no IS NOT NULL"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            Dim PreviousPart As String = Record(0, 0)
            SelectedPartTextBox.Text = PreviousPart
        End If
    End Sub

    Private Sub NextPartButton_Click(sender As Object, e As EventArgs) Handles NextPartButton.Click
        Dim Query As String = "SELECT next_prt_no FROM part_form_prev_next WHERE prt_no = '" + SelectedPartTextBox.Text + "' AND next_prt_no IS NOT NULL"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            Dim NextPart As String = Record(0, 0)
            SelectedPartTextBox.Text = NextPart
        End If
    End Sub

    Private Sub LastPartButton_Click(sender As Object, e As EventArgs) Handles LastPartButton.Click
        Dim Query As String = "SELECT DISTINCT FIRST_VALUE(prt_no) OVER (ORDER BY prt_no DESC) FROM part WHERE prt_active = TRUE"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim LastPart As String = Record(0, 0)
        SelectedPartTextBox.Text = LastPart
    End Sub

    Private Sub PartGridButton_Click(sender As Object, e As EventArgs) Handles PartGridButton.Click
        Dim PartListingFormInstance
        If ParentForm IsNot Nothing Then
            PartListingFormInstance = New PartListingForm(Me, ParentForm)
        Else
            PartListingFormInstance = New PartListingForm(Me)
        End If
        PartListingFormInstance.Location = PositioningMethods.CenterToCenter(PartListingFormInstance, Me)
        PartListingFormInstance.Show()
    End Sub

    Private Sub PartForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.MdiCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If
    End Sub

    Private Sub PartForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        LoadIndexTabs()
    End Sub
End Class