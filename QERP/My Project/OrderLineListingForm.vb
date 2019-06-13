Public Class OrderLineListingForm
    Public Overrides Sub LoadColumns()

        Me.DataGridView.Columns.Add("Column1", "Order Line Number")
        Me.DataGridView.Columns("Column1").Width = 112
        Me.DataGridView.Columns("Column1").Frozen = True

        Me.DataGridView.Columns.Add("Column2", "Part Number")
        Me.DataGridView.Columns("Column2").Width = 112

        Me.DataGridView.Columns.Add("Column3", "Part Description")
        Me.DataGridView.Columns("Column3").Width = 112

        Me.DataGridView.Columns.Add("Column4", "Slip #")
        Me.DataGridView.Columns("Column4").Width = 112

        Me.DataGridView.Columns.Add("Column5", "Required Date")
        Me.DataGridView.Columns("Column5").Width = 112
        Me.DataGridView.Columns("Column5").DefaultCellStyle.Format = "d"

        Me.DataGridView.Columns.Add("Column6", "Quantity")
        Me.DataGridView.Columns("Column6").Width = 112

        Me.DataGridView.Columns.Add("Column7", "Price")
        Me.DataGridView.Columns("Column7").Width = 112
        Me.DataGridView.Columns("Column7").DefaultCellStyle.Format = "c"

        Me.DataGridView.Columns.Add("Column8", "Discount")
        Me.DataGridView.Columns("Column8").Width = 112
        Me.DataGridView.Columns("Column8").DefaultCellStyle.Format = "p"

        Me.DataGridView.Columns.Add("Column9", "Reserved")
        Me.DataGridView.Columns("Column9").Width = 112

        Me.DataGridView.Columns.Add("Column10", "Shipped")
        Me.DataGridView.Columns("Column10").Width = 112

        Me.DataGridView.Columns.Add("Column11", "Ready")
        Me.DataGridView.Columns("Column11").Width = 112

        Me.DataGridView.Columns.Add("Column12", "Prepared")
        Me.DataGridView.Columns("Column12").Width = 112

    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM order_line "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim PartCount As String = Record(0, 0)
        Return PartCount
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