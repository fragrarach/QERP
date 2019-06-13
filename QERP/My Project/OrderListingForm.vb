Public Class OrderListingForm
    Public Overrides Sub LoadColumns()
        Me.DataGridView.Columns.Clear()

        Me.DataGridView.RowHeadersWidth = 20

        Me.DataGridView.Columns.Add("Column1", "Order Number")
        Me.DataGridView.Columns("Column1").Width = 112
        Me.DataGridView.Columns("Column1").Frozen = True

        Me.DataGridView.Columns.Add("Column2", "Client Number")
        Me.DataGridView.Columns("Column2").Width = 112

        Me.DataGridView.Columns.Add("Column3", "Client Order Number")
        Me.DataGridView.Columns("Column3").Width = 112

        Me.DataGridView.Columns.Add("Column4", "Order Date")
        Me.DataGridView.Columns("Column4").Width = 112
        Me.DataGridView.Columns("Column4").DefaultCellStyle.Format = "d"

        Me.DataGridView.Columns.Add("Column5", "Order Status")
        Me.DataGridView.Columns("Column5").Width = 112

        Me.DataGridView.Columns.Add("Column6", "Packing Slips")
        Me.DataGridView.Columns("Column6").Width = 112

        Me.DataGridView.Columns.Add("Column7", "Invoices")
        Me.DataGridView.Columns("Column7").Width = 112

        Me.DataGridView.Columns.Add("Column8", "Note 1")
        Me.DataGridView.Columns("Column8").Width = 112

        Me.DataGridView.Columns.Add("Column9", "Note 2")
        Me.DataGridView.Columns("Column9").Width = 112

        Me.DataGridView.Columns.Add("Column10", "Note 3")
        Me.DataGridView.Columns("Column10").Width = 112

        Me.DataGridView.Columns.Add("Column11", "Note 4")
        Me.DataGridView.Columns("Column11").Width = 112

        Me.DataGridView.Columns.Add("Column12", "Required Date")
        Me.DataGridView.Columns("Column12").Width = 112
        Me.DataGridView.Columns("Column12").DefaultCellStyle.Format = "d"

        Me.DataGridView.Columns.Add("Column13", "Name - Ship To")
        Me.DataGridView.Columns("Column13").Width = 112

        Me.DataGridView.Columns.Add("Column14", "City - Ship To")
        Me.DataGridView.Columns("Column14").Width = 112

        Me.DataGridView.Columns.Add("Column15", "Name - Invoice To")
        Me.DataGridView.Columns("Column15").Width = 112

        Me.DataGridView.Columns.Add("Column16", "City - Invoice To")
        Me.DataGridView.Columns("Column16").Width = 112

        Dim CheckBoxColumn1 As New DataGridViewCheckBoxColumn With {
            .Name = "Column17",
            .HeaderText = "Allow BO",
            .Width = 112
        }
        Me.DataGridView.Columns.Add(CheckBoxColumn1)
        Me.DataGridView.Columns("Column17").SortMode = DataGridViewColumnSortMode.Automatic

        Me.DataGridView.Columns.Add("Column18", "Carrier")
        Me.DataGridView.Columns("Column18").Width = 112

        Dim CheckBoxColumn2 As New DataGridViewCheckBoxColumn With {
            .Name = "Column19",
            .HeaderText = "Authorized",
            .Width = 112
        }
        Me.DataGridView.Columns.Add(CheckBoxColumn2)
        Me.DataGridView.Columns("Column19").SortMode = DataGridViewColumnSortMode.Automatic

        Me.DataGridView.Columns.Add("Column20", "Order Type")
        Me.DataGridView.Columns("Column20").Width = 112

        Dim CheckBoxColumn3 As New DataGridViewCheckBoxColumn With {
            .Name = "Column21",
            .HeaderText = "Order Printed",
            .Width = 112
        }
        Me.DataGridView.Columns.Add(CheckBoxColumn3)
        Me.DataGridView.Columns("Column21").SortMode = DataGridViewColumnSortMode.Automatic

        Dim CheckBoxColumn4 As New DataGridViewCheckBoxColumn With {
            .Name = "Column22",
            .HeaderText = "Packing Slip Printed",
            .Width = 112
        }
        Me.DataGridView.Columns.Add(CheckBoxColumn4)
        Me.DataGridView.Columns("Column22").SortMode = DataGridViewColumnSortMode.Automatic

    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM order_header "

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim PartCount As String = Record(0, 0)
        Return PartCount
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