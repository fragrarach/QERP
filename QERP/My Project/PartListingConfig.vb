Module PartListingConfig
    Public ActiveColumns(0 To 23) As Boolean
    Public ColumnNames(0 To 23) As String

    Public Sub PartListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next

        ColumnNames(0) = "Part Number"
        ColumnNames(1) = "French Description"
        ColumnNames(2) = "English Description"
        ColumnNames(3) = "Internal Description"
        ColumnNames(4) = "Sort Key"
        ColumnNames(5) = "Part Type"
        ColumnNames(6) = "Group #"
        ColumnNames(7) = "UPC #"
        ColumnNames(8) = "Location"
        Dim UserColumns As List(Of String) = FilerMethods.LoadPartIndexes()
        For i = 0 To UserColumns.Count - 1
            ColumnNames(9 + i) = UserColumns(i)
        Next
    End Sub
End Module
