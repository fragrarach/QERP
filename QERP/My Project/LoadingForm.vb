Public Class LoadingForm
    Dim LoadingText As String
    Shadows ParentForm
    Public Sub LoadingBarInit(ByVal Max As Int32, ByVal Text As String, ByRef Optional ParentFormArg As Form = Nothing)
        Me.LoadingProgressBar.Value = 0
        Me.LoadingProgressBar.Maximum = Max
        Me.LoadingText = Text

        If Not IsNothing(ParentFormArg) Then
            ParentForm = ParentFormArg
            If ParentForm.Mdiparent IsNot Nothing Then
                Me.Owner = ParentForm.Mdiparent
                Me.MdiParent = ParentForm.Mdiparent
                Me.Location = PositioningMethods.MdiCenter(Me, ParentForm.Mdiparent)
            Else
                Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
            End If
        Else
            CenterToScreen()
        End If



        Me.TopMost = True

        Me.Show()
    End Sub
    Public Sub LoadingBarIncrement()
        Me.LoadingProgressBar.Value += 1
        Dim LoadingPercent As Int16 = (Me.LoadingProgressBar.Value / Me.LoadingProgressBar.Maximum) * 100
        Me.LoadingTextBox.Text = LoadingText & LoadingPercent & "%"
        Me.LoadingTextBox.Refresh()
    End Sub
End Class