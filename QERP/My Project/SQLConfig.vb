Module SQLConfig
    Public Sub SQLConfigInit()
        Dim ResourceSet As Object = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, False, True)
        Dim Resource As DictionaryEntry
        For Each Resource In ResourceSet
            If Resource.Value.GetType Is GetType(String) Then
                If Resource.Value.ToString.Substring(0, 5) = "--SQL" Then
                    Try
                        PostgresMethods.PostgresStatement(Resource.Value, PostgresMethods.ProdConnectionString)
                    Catch ex As Exception

                    End Try
                End If
            End If
        Next
    End Sub
End Module
