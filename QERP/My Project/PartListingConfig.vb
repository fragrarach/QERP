Module PartListingConfig
    Public ActiveColumns(0 To 25) As Boolean
    Public Sub PartListingConfigInit()
        For i = 0 To UBound(ActiveColumns, 1)
            ActiveColumns(i) = True
        Next
    End Sub
End Module
