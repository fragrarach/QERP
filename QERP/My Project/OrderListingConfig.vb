Module OrderListingConfig
    Public ActiveColumns(0 To 20) As Boolean
    Public ColumnNames(0 To 21) As String

    Public Sub OrderListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next

        ColumnNames(0) = "Order Number"
        ColumnNames(1) = "Client Number"
        ColumnNames(2) = "Client Order Number"
        ColumnNames(3) = "Order Date"
        ColumnNames(4) = "Order Status"
        ColumnNames(5) = "Packing Slips"
        ColumnNames(6) = "Invoices"
        ColumnNames(7) = "Note 1"
        ColumnNames(8) = "Note 2"
        ColumnNames(9) = "Note 3"
        ColumnNames(10) = "Note 4"
        ColumnNames(11) = "Required Date"
        ColumnNames(12) = "Name - Ship To"
        ColumnNames(13) = "City - Ship To"
        ColumnNames(14) = "Name - Invoice To"
        ColumnNames(15) = "City - Invoice To"
        ColumnNames(16) = "Allow BO"
        ColumnNames(17) = "Carrier"
        ColumnNames(18) = "Authorized"
        ColumnNames(19) = "Order Type"
        ColumnNames(20) = "Order Printed"
        ColumnNames(21) = "Packing Slip Printed"
    End Sub
End Module
