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
        If TabControl1.SelectedTab Is TabPage1 Then
            LoadInformation1Tab()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            LoadInformation2Tab()
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            LoadPriceDataGridView()
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
            InvoicePackagesCheckBox.Text = Trim(Record(12, 0))
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

    Private Sub LoadPriceDataGridView()
        Dim Query As String = "SELECT * FROM part_form_prices WHERE prt_no ='" & SelectedPartTextBox.Text & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            PriceDataGridView.Rows.Clear()
            For RowIndex = 0 To 4
                PriceDataGridView.Rows.Add()
                For ColumnIndex = 0 To 14
                    PriceDataGridView.Item(ColumnIndex, RowIndex).Value = Record(ColumnIndex + 1, RowIndex)
                Next
            Next
            FormatLoadPriceDataGridViewRows()
        End If
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

    Private Sub PartNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartSearchTextBox.KeyDown
        If e.KeyValue = 13 And PartSearchTextBox.Text <> "" Then
            PartSearch()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PartSearch()
        Dim PartSearch As String = PartSearchTextBox.Text.ToUpper
        Dim Query As String = "SELECT prt_no FROM part WHERE prt_active = TRUE AND prt_no ='" & PartSearch & "'"
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
End Class