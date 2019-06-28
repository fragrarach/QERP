Public Class SearchForm

    Shadows ParentForm

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.MdiCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If
    End Sub

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim SearchWord As String = Me.SearchTextBox.Text
        Me.Close()
        If Not (ParentForm.SearchWord.Variable = SearchWord) Then
            ParentForm.SearchWord.Variable = SearchWord
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class