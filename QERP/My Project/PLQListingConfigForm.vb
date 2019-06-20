Public Class PLQListingConfigForm

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Shadows FormInitialized As Boolean

    Public Overrides Sub ListingConfigForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not (FormInitialized) Then
            FormInitialized = True

            If Not IsNothing(ParentForm) Then
                For ColumnIndex = 1 To PLQListingConfig.ColumnNames.Count - 1
                    Me.ColumnDisplayListView.Items.Add(PLQListingConfig.ColumnNames(ColumnIndex))
                Next
            End If

            For i = 0 To Me.ColumnDisplayListView.Items.Count - 1
                If PLQListingConfig.ActiveColumns(i) = True Then
                    Me.ColumnDisplayListView.Items(i).Checked = True
                End If
            Next
        End If
    End Sub

    Public Overrides Sub SaveConfig()
        For i = 0 To ColumnDisplayListView.Items.Count - 1
            If Me.ColumnDisplayListView.Items(i).Checked = True Then
                PLQListingConfig.ActiveColumns(i) = True
            ElseIf Me.ColumnDisplayListView.Items(i).Checked = False Then
                PLQListingConfig.ActiveColumns(i) = False
            End If
        Next
    End Sub

End Class