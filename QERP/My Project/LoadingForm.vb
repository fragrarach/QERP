﻿Public Class LoadingForm
    Dim LoadingText As String
    Shadows ParentForm
    Public Sub LoadingFormInit(ByVal Text As String, ByRef Optional ParentFormArg As Form = Nothing)

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
        Me.LoadingTextBox.Text = Text
        Me.LoadingTextBox.Refresh()
    End Sub
End Class