<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 28)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(246, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'YesButton
        '
        Me.YesButton.Location = New System.Drawing.Point(12, 68)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(110, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "OK"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Text to search :"
        '
        'NoButton
        '
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NoButton.Location = New System.Drawing.Point(148, 68)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(110, 23)
        Me.NoButton.TabIndex = 3
        Me.NoButton.Text = "Cancel"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'SearchForm
        '
        Me.AcceptButton = Me.YesButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(270, 103)
        Me.ControlBox = False
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchForm"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Advanced Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents YesButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NoButton As Button
End Class
