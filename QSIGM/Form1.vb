Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Part.part' table. You can move, or remove it, as needed.
        Me.PartTableAdapter.Fill(Me.Part.part)
    End Sub

    Private Sub PartBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PartBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Part)

    End Sub

End Class
