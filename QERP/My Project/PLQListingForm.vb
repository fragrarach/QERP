Public Class PLQListingForm

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

            Dim KeepOpenHost As New ToolStripControlHost(KeepOpenCheckBox)
            ListingToolStrip.Items.Add(KeepOpenHost)

            LoadCount()

            Dim RecordBinding As BindingSource = LoadListingData(Me)

            LoadColumns(RecordBinding)

            If Not IsNothing(ParentForm) Then
                If ParentForm.GetType() Is GetType(LabelForm) Then
                    If ParentForm.SelectedPLQTextBox.Text IsNot Nothing Then
                        Search(LabelForm.SelectedPLQTextBox, True)
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
        Me.DataGridView.Columns(ColumnIndex).HeaderText = PLQListingConfig.ColumnNames(ColumnIndex)
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        If PLQListingConfig.ActiveColumns(0) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PLQListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(1) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Status"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(2) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Number"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(3) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Line Number"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(4) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Line Required Date"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(5) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Part Number"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(6) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Part Description"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(7) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Required Quantity"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(8) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Transferred Quantity"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(9) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Quantity to Produce"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(10) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Production Date"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(11) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Produced Quantity"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(12) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = "Note"
            Me.DataGridView.Columns(ColumnIndex).Width = 112
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PLQListingConfig.ActiveColumns(13) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.RemoveAt(ColumnIndex)
            Dim ComboBoxColumn1 As New DataGridViewComboBoxColumn With {
                .Name = ColumnIndex,
                .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
                .HeaderText = "Builder",
                .ReadOnly = False
            }
            ComboBoxColumn1.DataPropertyName = ColumnIndex
            Dim Query As String = "SELECT emp_name FROM employee"
            Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
            If Record IsNot Nothing Then
                For RowIndex = 0 To UBound(Record, 2)
                    ComboBoxColumn1.Items.Add(Trim(Record(0, RowIndex)))
                Next
            End If
            Me.DataGridView.Columns.Insert(ColumnIndex, ComboBoxColumn1)
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        Me.DataGridView.Columns(ColumnIndex).Visible = False

    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM order_header "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim Count As String = Record(0, 0)
        Return Count
    End Function

    Public Overrides Function ListingQueryBuilder() As Object
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

    Public Overrides Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)
        Dim MyConfig As New PLQListingConfigForm(Me)
        MyConfig.ShowDialog()
    End Sub
End Class