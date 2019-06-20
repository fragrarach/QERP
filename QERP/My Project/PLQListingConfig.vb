Module PLQListingConfig
    Public ActiveColumns(0 To 13) As Boolean
    Public ColumnNames(0 To 14) As String
    Public Sub PLQListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next

        ColumnNames(0) = "Planning Lot Number"
        ColumnNames(1) = "Created"
        ColumnNames(2) = "Status"
        ColumnNames(3) = "Order Number"
        ColumnNames(4) = "Order Line Number"
        ColumnNames(5) = "Order Line Required Date"
        ColumnNames(6) = "Part Number"
        ColumnNames(7) = "Part Description"
        ColumnNames(8) = "Required Quantity"
        ColumnNames(9) = "Transferred Quantity"
        ColumnNames(10) = "Quantity to Produce"
        ColumnNames(11) = "Production Date"
        ColumnNames(12) = "Produced Quantity"
        ColumnNames(13) = "Note"
        ColumnNames(14) = "Builder"
    End Sub
End Module
