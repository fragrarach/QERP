Module WeightsDimsListingConfig
    Public ActiveColumns(0 To 9) As Boolean
    Public ColumnNames(0 To 10) As String
    Public Sub WeightsDimsListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next

        ColumnNames(0) = "Part Number"
        ColumnNames(1) = "Description"
        ColumnNames(2) = "Group"
        ColumnNames(3) = "SIGM Length"
        ColumnNames(4) = "SIGM Width"
        ColumnNames(5) = "SIGM Height"
        ColumnNames(6) = "SIGM Weight"

        ColumnNames(7) = "Corrected Length"
        ColumnNames(8) = "Corrected Width"
        ColumnNames(9) = "Corrected Height"
        ColumnNames(10) = "Corrected Weight"
    End Sub
End Module
