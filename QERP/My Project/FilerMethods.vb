Module FilerMethods
    Public Function LoadPartIndexes()
        Dim FileReader As String = My.Computer.FileSystem.ReadAllText("K:\SIGMWIN.DTA\QuatroAir\INVINFG.FDW", System.Text.Encoding.Default)

        Dim StringStart As Int32 = 461
        Dim SubStringStart As Int32
        Dim StringLength As Int32
        Dim SubString As String = Nothing
        Dim SubStringList As New List(Of String)

        For i = 0 To 14
            SubStringStart = StringStart + i * 21
            StringLength = Asc(FileReader(SubStringStart))
            For j = 1 To StringLength
                SubString += FileReader(SubStringStart + j)
            Next
            SubStringList.Add(SubString)
            SubString = Nothing
        Next

        Return SubStringList

    End Function
End Module
