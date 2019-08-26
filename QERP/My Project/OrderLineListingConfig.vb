Module OrderLineListingConfig
    Public ActiveColumns(0 To 10) As Boolean
    Public ColumnNames(0 To 11) As String

    Public Sub OrderListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next

        ColumnNames(0) = "Order Line Number"
        ColumnNames(1) = "Part Number"
        ColumnNames(2) = "Part Description"
        ColumnNames(3) = "Slip #"
        ColumnNames(4) = "Required Date"
        ColumnNames(5) = "Quantity"
        ColumnNames(6) = "Price"
        ColumnNames(7) = "Discount"
        ColumnNames(8) = "Reserved"
        ColumnNames(9) = "Shipped"
        ColumnNames(10) = "Ready"
        ColumnNames(11) = "Prepared"
    End Sub
End Module
