Public Class OrderListingForm

    Shadows ParentForm

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
        Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.RemoveAt(ColumnIndex)
            Dim CheckBoxColumn1 As New DataGridViewCheckBoxColumn With {
                .Name = ColumnIndex,
                .Width = 112,
                .DataPropertyName = ColumnIndex,
                .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
                .HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            }
            Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn1)
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.RemoveAt(ColumnIndex)
            Dim CheckBoxColumn2 As New DataGridViewCheckBoxColumn With {
                .Name = ColumnIndex,
                .Width = 112,
                .DataPropertyName = ColumnIndex,
                .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
                .HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            }
            Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn2)
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 112
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.RemoveAt(ColumnIndex)
            Dim CheckBoxColumn3 As New DataGridViewCheckBoxColumn With {
                .Name = ColumnIndex,
                .Width = 112,
                .DataPropertyName = ColumnIndex,
                .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
                .HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            }
            Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn3)
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        ColumnIndex += 1
        If OrderListingConfig.ActiveColumns(ColumnIndex - 1) = True Then
            Me.DataGridView.Columns(ColumnIndex).Visible = True
            Me.DataGridView.Columns.RemoveAt(ColumnIndex)
            Dim CheckBoxColumn4 As New DataGridViewCheckBoxColumn With {
                .Name = ColumnIndex,
                .Width = 112,
                .DataPropertyName = ColumnIndex,
                .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
                .HeaderText = OrderListingConfig.ColumnNames(ColumnIndex)
            }
            Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn4)
        Else
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

    End Sub

    Public Overrides Function ListingQueryBuilder() As Object
        Dim Query As String = "SELECT o.ord_no "

        Query += ", c.cli_no "

        Query += ", o.ord_cli_ord_no "

        Query += ", o.ord_date "

        Query += ", os.ord_status "

        Query += ", string_agg(DISTINCT il.inv_pckslp_no::text, '-') as inv_no "

        Query += ", string_agg(DISTINCT il.inv_no::text, '-') as inv_no "

        Query += ", o.ord_note1 "

        Query += ", o.ord_note2 "

        Query += ", o.ord_note3 "

        Query += ", o.ord_note4 "

        Query += ", o.ord_req_dt "

        Query += ", o.cli_del_name1 "

        Query += ", o.cli_del_city "

        Query += ", o.inv_name1 "

        Query += ", o.inv_city "

        Query += ", CASE WHEN o.ord_bo_accptd IS TRUE THEN 'TRUE' ELSE 'FALSE' END AS ord_bo_accptd "

        Query += ", o.car_name "

        Query += ", CASE WHEN o.ord_sb_authorized IS TRUE THEN 'TRUE' ELSE 'FALSE' END AS ord_sb_authorized "

        Query += ", ot.ord_type "

        Query += ", CASE WHEN o.ord_printed IS TRUE THEN 'TRUE' ELSE 'FALSE' END AS ord_printed "

        Query += ", CASE WHEN o.ord_pkl_printed IS TRUE THEN 'TRUE' ELSE 'FALSE' END AS ord_pkl_printed "

        Query += "FROM order_header o "
        Query += "JOIN client c USING(cli_id) "
        Query += "LEFT JOIN client ic ON o.inv_cli_id = ic.cli_id "
        Query += "JOIN ord_status os ON o.ord_status = os.ord_status_idx "
        Query += "JOIN orc_type ot ON o.ord_type = ot.orc_type_idx "
        Query += "LEFT JOIN invoicing i USING(ord_no) "
        Query += "LEFT JOIN invoicing_line il USING(inv_id)"

        If Me.SearchWord.Variable <> "" Then
            Query += "WHERE o.ord_no::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR c.cli_no ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_date::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR os.ord_status ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR il.inv_pckslp_no::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR il.inv_no::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_note1 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_note2 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_note3 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_note4 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_req_dt::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_req_dt::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.cli_del_name1 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.cli_del_city ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.inv_name1 ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.inv_city ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_bo_accptd::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_sb_authorized::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_type::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_printed::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
            Query += "OR o.ord_pkl_printed::TEXT ILIKE '%" & Me.SearchWord.Variable & "%' "
        End If

        Query += "GROUP BY "
        Query += "o.ord_no"

        Query += ", c.cli_no"
        Query += ", o.ord_cli_ord_no"
        Query += ", o.ord_date"
        Query += ", os.ord_status"
        Query += ", o.ord_note1"
        Query += ", o.ord_note2"
        Query += ", o.ord_note3"
        Query += ", o.ord_note4"
        Query += ", o.ord_req_dt "
        Query += ", o.cli_del_name1 "
        Query += ", o.cli_del_city "
        Query += ", o.inv_name1 "
        Query += ", o.inv_city "
        Query += ", o.ord_bo_accptd "
        Query += ", o.car_name "
        Query += ", o.ord_sb_authorized "
        Query += ", ot.ord_type "
        Query += ", o.ord_printed "
        Query += ", o.ord_pkl_printed "

        Return Query
    End Function

    Public Overrides Sub DataGridView_CellStateChanged(sender As Object, e As DataGridViewCellEventArgs)
        Dim OrderNumber As Int32 = Me.DataGridView.Item(0, e.RowIndex).Value
        Dim OrderLineListingFormInstance As New OrderLineListingForm(Me, OrderNumber) With {
            .Owner = Me.Owner,
            .MdiParent = Me.MdiParent
        }
        OrderLineListingFormInstance.Show()
    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)
        Dim MyConfig As New OrderListingConfigForm(Me)
        MyConfig.ShowDialog()
    End Sub
End Class