Public Class SearchWord
    Private SearchWord As String
    Public Event SearchWordChanged(ByVal SearchWord As String)

    Public Property Variable() As String
        Get
            Variable = SearchWord
        End Get
        Set(ByVal value As String)
            SearchWord = value
            RaiseEvent SearchWordChanged(SearchWord)
        End Set
    End Property
End Class
