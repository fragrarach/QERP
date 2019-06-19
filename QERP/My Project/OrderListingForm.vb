Public Class OrderListingFormNew
    Public Overrides Sub LoadColumns(RecordBinding As BindingSource)
        Dim ColumnIndex As Int16 = 0

        Me.DataGridView.DataSource = RecordBinding

        Me.DataGridView.RowHeadersWidth = 20

        For i = 0 To Me.DataGridView.Columns.Count - 1
            Me.DataGridView.Columns(i).ReadOnly = True
        Next

        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Client Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Client Order Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Date"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Status"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Packing Slips"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Invoices"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Note 1"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Note 2"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Note 3"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Note 4"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Required Date"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Name - Ship To"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "City - Ship To"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Name - Invoice To"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "City - Invoice To"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim CheckBoxColumn1 As New DataGridViewCheckBoxColumn With {
            .Name = ColumnIndex,
            .Width = 112,
            .DataPropertyName = ColumnIndex,
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Allow BO"
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn1)

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Carrier"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim CheckBoxColumn2 As New DataGridViewCheckBoxColumn With {
            .Name = ColumnIndex,
            .Width = 112,
            .DataPropertyName = ColumnIndex,
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Authorized"
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn2)

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Type"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim CheckBoxColumn3 As New DataGridViewCheckBoxColumn With {
            .Name = ColumnIndex,
            .Width = 112,
            .DataPropertyName = ColumnIndex,
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Order Printed"
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn3)

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim CheckBoxColumn4 As New DataGridViewCheckBoxColumn With {
            .Name = ColumnIndex,
            .Width = 112,
            .DataPropertyName = ColumnIndex,
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Packing Slip Printed"
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, CheckBoxColumn4)

    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM order_header "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim Count As String = Record(0, 0)
        Return Count
    End Function

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

    Public Overrides Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class