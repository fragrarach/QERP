Public Class WeightsDimsListingForm

    Friend WithEvents ShowCorrectedCheckBox As New CheckBox With {
            .Text = "Show Corrected",
            .Checked = True
    }

    Friend WithEvents ShowImportedCheckBox As New CheckBox With {
            .Text = "Show Imported",
            .Checked = True
    }

    Friend WithEvents ShowChangedCheckBox As New CheckBox With {
            .Text = "Show Changed",
            .Checked = True
    }

    Shadows ParentForm
    Shadows FormInitialized As Boolean

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Public Overrides Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (FormInitialized) Then
            FormInitialized = True
            If ParentForm IsNot Nothing Then
                Me.Location = PositioningMethods.MdiCenter(Me, ParentForm)
            Else
                Me.CenterToScreen()
            End If

            Dim ShowCorrectedHost As New ToolStripControlHost(ShowCorrectedCheckBox)
            ListingToolStrip.Items.Add(ShowCorrectedHost)

            Dim ToolStripSeparator2 As New ToolStripSeparator
            ListingToolStrip.Items.Add(ToolStripSeparator2)

            Dim ShowImportedHost As New ToolStripControlHost(ShowImportedCheckBox)
            ListingToolStrip.Items.Add(ShowImportedHost)

            Dim ToolStripSeparator3 As New ToolStripSeparator
            ListingToolStrip.Items.Add(ToolStripSeparator3)

            Dim ShowChangedHost As New ToolStripControlHost(ShowChangedCheckBox)
            ListingToolStrip.Items.Add(ShowChangedHost)

            LoadCount()

            Dim RecordBinding As BindingSource = LoadListingData(Me)

            LoadColumns(RecordBinding)

            'If Not IsNothing(ParentForm) Then
            '    If ParentForm.GetType() Is GetType(LabelForm) Then
            '        If ParentForm.SelectedPLQTextBox.Text IsNot Nothing Then
            '            Search(LabelForm.SelectedPLQTextBox, True)
            '        End If
            '    End If
            'End If
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
        Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        If WeightsDimsListingConfig.ActiveColumns(0) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(1) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(2) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(3) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(4) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(5) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        'CORRECTED COLUMNS

        If WeightsDimsListingConfig.ActiveColumns(6) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            Me.DataGridView.Columns(ColumnIndex).ReadOnly = False
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(7) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            Me.DataGridView.Columns(ColumnIndex).ReadOnly = False
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(8) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            Me.DataGridView.Columns(ColumnIndex).ReadOnly = False
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If WeightsDimsListingConfig.ActiveColumns(9) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = WeightsDimsListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            Me.DataGridView.Columns(ColumnIndex).ReadOnly = False
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM weights_and_dims "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim Count As String = Record(0, 0)
        Return Count
    End Function

    Public Overrides Function ListingQueryBuilder() As Object
        Dim WhereCheck As Boolean = False
        Dim Query As String = "SELECT prt_no, "

        Query += "prt_desc2, "
        Query += "pgr_desc, "
        Query += "prt_usr_float1, "
        Query += "prt_usr_float2, "
        Query += "prt_usr_float3, "
        Query += "prt_weight, "
        Query += "ext_length, "
        Query += "ext_width, "
        Query += "ext_height, "
        Query += "ext_weight "

        Query += "FROM weights_and_dims "

        If ShowCorrectedCheckBox.Checked = False Then
            If WhereCheck = False Then
                Query += "WHERE "
                WhereCheck = True
            Else
                Query += "AND "
            End If
            Query += "NOT (
                (ext_length <> 0 AND ext_width <> 0 AND ext_height <> 0 AND ext_weight <> 0)
                AND (prt_usr_float1 = 0 AND prt_usr_float2 = 0 AND prt_usr_float3 = 0 AND prt_weight = 0)
            ) "
        End If

        If ShowImportedCheckBox.Checked = False Then
            If WhereCheck = False Then
                Query += "WHERE "
                WhereCheck = True
            Else
                Query += "AND "
            End If
            Query += "NOT (
                (prt_usr_float1 <> 0 AND prt_usr_float2 <> 0 AND prt_usr_float3 <> 0 AND prt_weight <> 0) 
                AND (ext_length = 0 AND ext_width = 0 AND ext_height = 0 AND ext_weight = 0)
            ) "
            WhereCheck = True
        End If

        If ShowChangedCheckBox.Checked = False Then
            If WhereCheck = False Then
                Query += "WHERE "
                WhereCheck = True
            Else
                Query += "AND "
            End If
            Query += "NOT (
                (prt_usr_float1 <> 0 AND prt_usr_float2 <> 0 AND prt_usr_float3 <> 0 AND prt_weight <> 0)
                AND (ext_length <> 0 OR ext_width <> 0 OR ext_height <> 0 OR ext_weight <> 0)
            ) "
            WhereCheck = True
        End If

        If Me.SearchWord.Variable <> "" Then
            If WhereCheck = False Then
                Query += "WHERE "
                WhereCheck = True
            Else
                Query += "AND "
            End If
            Query += "prt_no ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR prt_desc2 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR pgr_desc ILIKE '%" & Me.SearchWord.Variable & "%' "
        End If

        Return Query
    End Function

    Public Overrides Sub DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex <> -1 Then
            If IsDBNull(Me.DataGridView.Rows(e.RowIndex).Cells(7).Value) Then
                Me.DataGridView.Rows(e.RowIndex).Cells(7).Value = 0
            End If
            If IsDBNull(Me.DataGridView.Rows(e.RowIndex).Cells(8).Value) Then
                Me.DataGridView.Rows(e.RowIndex).Cells(8).Value = 0
            End If
            If IsDBNull(Me.DataGridView.Rows(e.RowIndex).Cells(9).Value) Then
                Me.DataGridView.Rows(e.RowIndex).Cells(9).Value = 0
            End If
            If IsDBNull(Me.DataGridView.Rows(e.RowIndex).Cells(10).Value) Then
                Me.DataGridView.Rows(e.RowIndex).Cells(10).Value = 0
            End If
            Dim partNumber As String = Me.DataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim correctedLength As Int16 = Me.DataGridView.Rows(e.RowIndex).Cells(7).Value
            Dim correctedWidth As Int16 = Me.DataGridView.Rows(e.RowIndex).Cells(8).Value
            Dim correctedHeight As Int16 = Me.DataGridView.Rows(e.RowIndex).Cells(9).Value
            Dim correctedWeight As Int16 = Me.DataGridView.Rows(e.RowIndex).Cells(10).Value

            Dim Query As String = "SELECT weights_and_dims_ext_upsert('" + partNumber + "', " + CStr(correctedLength) + ", " + CStr(correctedWidth) + ", " + CStr(correctedHeight) + ", " + CStr(correctedWeight) + ")"
            Dim Record As Object = PostgresMethods.PostgresQuery(Query, LogConnectionString)
        End If
    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)
        'Dim MyConfig As New PLQListingConfigForm(Me)
        'MyConfig.ShowDialog()
    End Sub

    Private Sub dgvLegends_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView.CellPainting

        Dim Brush As New SolidBrush(Me.DataGridView.ColumnHeadersDefaultCellStyle.BackColor)
        e.Graphics.FillRectangle(Brush, e.CellBounds)
        Brush.Dispose()
        e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)


        If e.ColumnIndex = 6 Then
            ControlPaint.DrawBorder(
                e.Graphics,
                e.CellBounds,
                Me.DataGridView.GridColor, 0, ButtonBorderStyle.Solid,
                Me.DataGridView.GridColor, 0, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Me.DataGridView.GridColor, 0, ButtonBorderStyle.Solid
            )
        End If

        'e.Handled = True
    End Sub

    Private Sub CorrectedFormat(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting
        If e.RowIndex <> -1 Then
            Dim Row = Me.DataGridView.Rows(e.RowIndex)

            Dim ProdLength = Me.DataGridView.Item(3, e.RowIndex).Value
            Dim ProdWidth = Me.DataGridView.Item(4, e.RowIndex).Value
            Dim ProdHeight = Me.DataGridView.Item(5, e.RowIndex).Value
            Dim ProdWeight = Me.DataGridView.Item(6, e.RowIndex).Value

            Dim CorrectedLength = Me.DataGridView.Item(7, e.RowIndex).Value
            Dim CorrectedWidth = Me.DataGridView.Item(8, e.RowIndex).Value
            Dim CorrectedHeight = Me.DataGridView.Item(9, e.RowIndex).Value
            Dim CorrectedWeight = Me.DataGridView.Item(10, e.RowIndex).Value

            If CorrectedLength <> 0 And CorrectedWidth <> 0 And CorrectedHeight <> 0 And CorrectedWeight <> 0 Then
                Row.DefaultCellStyle.BackColor = Color.LightBlue
            End If

            If ProdLength <> 0 And ProdWidth <> 0 And ProdHeight <> 0 And ProdWeight <> 0 Then
                Row.DefaultCellStyle.BackColor = Color.LightGreen
            End If

            If (CorrectedLength <> 0 Or CorrectedWidth <> 0 Or CorrectedHeight <> 0 Or CorrectedWeight <> 0) _
            And ProdLength <> 0 And ProdWidth <> 0 And ProdHeight <> 0 And ProdWeight <> 0 Then
                Row.DefaultCellStyle.BackColor = Color.LightSalmon
            End If
        End If

    End Sub

    Private Sub ShowCorrectedCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowCorrectedCheckBox.CheckStateChanged
        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)
        LoadCount()
    End Sub

    Private Sub ShowImportedCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowImportedCheckBox.CheckStateChanged
        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)
        LoadCount()
    End Sub

    Private Sub ShowChangedCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowChangedCheckBox.CheckStateChanged
        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)
        LoadCount()
    End Sub
End Class