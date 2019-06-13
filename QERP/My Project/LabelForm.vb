Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class LabelForm
    Sub Test()
        Dim myReport As New ReportDocument()
        Dim reportPath As String = "C:\Users\janz\Desktop\PLETI001 - PLANNING LOT LABELS (CONTROL PANELS).rpt"
        myReport.Load(reportPath)

        Dim plq_id As String = Me.SelectedPLQTextBox.Text
        Dim LabelQuantity As Nullable(Of Int16)
        If Me.LabelQuantityTextBox.Text <> "" Then
            LabelQuantity = Me.LabelQuantityTextBox.Text
        End If

        If plq_id <> "" And LabelQuantity IsNot Nothing Then
            myReport.SetParameterValue("plq_id", plq_id)
            myReport.PrintToPrinter(LabelQuantity, True, 0, 0)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Test()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Title = "Please select a Crystal Report"
        OpenFileDialog1.InitialDirectory = "K:\SIGMWIN.DTA\QuatroAir\FormatsRpt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Crystal Report|*.rpt"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub PLQGridButton_Click(sender As Object, e As EventArgs) Handles PLQGridButton.Click
        PLQListingForm.Location = PositioningMethods.CenterToCenter(PLQListingForm, Me)
        PLQListingForm.Show()
    End Sub

End Class