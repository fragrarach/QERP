Public Class PartListingForm

    Friend WithEvents ActivePartsCheckBox As New CheckBox With {
            .Text = "Show Inactive",
            .Checked = True
        }

    Friend WithEvents KeepOpenCheckBox As New CheckBox With {
            .Text = "Keep Open",
            .Checked = True
        }

    Shadows ParentForm
    Shadows FormInitialized As Boolean

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg)
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

    Public Overrides Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (FormInitialized) Then
            FormInitialized = True

            If ParentForm IsNot Nothing Then
                Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
            Else
                Me.CenterToScreen()
            End If

            Dim ActivePartsHost As New ToolStripControlHost(ActivePartsCheckBox)
            ListingToolStrip.Items.Add(ActivePartsHost)

            Dim ToolStripSeparator2 As New ToolStripSeparator
            ListingToolStrip.Items.Add(ToolStripSeparator2)

            Dim KeepOpenHost As New ToolStripControlHost(KeepOpenCheckBox)
            ListingToolStrip.Items.Add(KeepOpenHost)

            Dim RecordBinding As BindingSource = LoadListingData(Me)

            LoadColumns(RecordBinding)

            LoadCount()

            If Not IsNothing(ParentForm) Then
                If ParentForm.GetType() Is GetType(PartForm) Or ParentForm.GetType() Is GetType(TreeViewForm) Then
                    If ParentForm.SelectedPartTextBox.Text IsNot Nothing Then
                        Search(ParentForm.SelectedPartTextBox, True)
                    End If
                End If
            End If
        End If
    End Sub

    Public Overrides Sub LoadColumns(Optional RecordBinding As BindingSource = Nothing)
        Dim ColumnIndex As Int16 = 0

        If Not IsNothing(RecordBinding) Then
            Me.DataGridView.DataSource = RecordBinding
        End If

        Me.DataGridView.RowHeadersWidth = 20

        For i = 0 To Me.DataGridView.Columns.Count - 1
            Me.DataGridView.Columns(i).ReadOnly = True
        Next

        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If PartListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 100
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        Dim UserColumns As List(Of String) = FilerMethods.LoadPartIndexes()
        For i = 0 To UserColumns.Count - 1
            ColumnIndex += 1
            If PartListingConfig.ActiveColumns(8 + i) = True Then
                Me.DataGridView.Columns(ColumnIndex).Visible = True
                Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
                Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
                Me.DataGridView.Columns(ColumnIndex).Width = 120
            Else
                Me.DataGridView.Columns(ColumnIndex).Visible = False
            End If
        Next

        ColumnIndex += 1
        Me.DataGridView.Columns(ColumnIndex).Visible = False

    End Sub

    Public Overrides Function ListingQueryBuilder() As Object
        Dim Query As String

        Query = "SELECT * FROM part_listing_form "

        Dim WhereCheck As Boolean = False
        If ActivePartsCheckBox.Checked = False Then
            Query += "WHERE prt_active = TRUE "
            WhereCheck = True
        End If

        If Me.SearchWord.Variable <> "" Then
            If WhereCheck = False Then
                Query += "WHERE prt_no ILIKE '%" & Me.SearchWord.Variable & "%' "
                WhereCheck = True
            Else
                Query += "AND prt_no ILIKE '%" & Me.SearchWord.Variable & "%' "
            End If

            Query += "OR prt_desc1 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_desc2 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_desc3 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_sort ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_type ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR pgr_no ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_upc ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_location ILIKE '%" & Me.SearchWord.Variable & "%' "
        End If

        Query += "ORDER BY prt_no"

        Return Query
    End Function

    Public Overrides Sub DataGridView_CellStateChanged(sender As Object, e As DataGridViewCellEventArgs)
        If Not IsNothing(ParentForm) Then
            If ParentForm.GetType() Is GetType(PartForm) Or ParentForm.GetType() Is GetType(TreeViewForm) Then
                If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
                    ParentForm.SelectedPartTextBox.Text = Me.DataGridView.Item(0, e.RowIndex).Value
                    If KeepOpenCheckBox.Checked = False Then
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)
        Dim MyConfig As New PartListingConfigForm(Me)
        MyConfig.ShowDialog()
    End Sub

    Private Sub ActivePartsCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ActivePartsCheckBox.CheckStateChanged
        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)
        LoadCount()
    End Sub
End Class