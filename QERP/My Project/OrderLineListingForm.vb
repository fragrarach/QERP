Public Class OrderLineListingForm
    Public Overrides Sub LoadColumns(RecordBinding As BindingSource)
        Dim ColumnIndex As Int16 = 0

        Me.DataGridView.DataSource = RecordBinding

        Me.DataGridView.RowHeadersWidth = 20

        For i = 0 To Me.DataGridView.Columns.Count - 1
            Me.DataGridView.Columns(i).ReadOnly = True
        Next

        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Order Line Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Part Number"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Part Description"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Slip #"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Required Date"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Quantity"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim CurrencyColumn As New DataGridViewTextBoxColumn With {
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Price",
            .Width = 112
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, CurrencyColumn)
        For i = 0 To RecordBinding.Count - 1
            If Not IsDBNull(RecordBinding.Item(i).row(ColumnIndex)) Then
                RecordBinding.Item(i).row(ColumnIndex) = FormatCurrency(RecordBinding.Item(i).row(ColumnIndex))
            End If
        Next
        CurrencyColumn.DataPropertyName = ColumnIndex

        ColumnIndex += 1
        Me.DataGridView.Columns.RemoveAt(ColumnIndex)
        Dim PercentageColumn As New DataGridViewTextBoxColumn With {
            .HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell,
            .HeaderText = "Discount",
            .Width = 112
        }
        Me.DataGridView.Columns.Insert(ColumnIndex, PercentageColumn)
        For i = 0 To RecordBinding.Count - 1
            If Not IsDBNull(RecordBinding.Item(i).row(ColumnIndex)) Then
                RecordBinding.Item(i).row(ColumnIndex) = FormatPercent(RecordBinding.Item(i).row(ColumnIndex))
            End If
        Next
        PercentageColumn.DataPropertyName = ColumnIndex

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Reserved"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Shipped"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Ready"
        Me.DataGridView.Columns(ColumnIndex).Width = 112

        ColumnIndex += 1
        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = "Prepared"
        Me.DataGridView.Columns(ColumnIndex).Width = 112
    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM order_line "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim Count As String = Record(0, 0)
        Return Count
    End Function

    Public Overrides Function ListingQueryBuilder() As Object
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

    Public Overrides Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class