<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.LoadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LoadingTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LoadingProgressBar
        '
        Me.LoadingProgressBar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LoadingProgressBar.Location = New System.Drawing.Point(4, 4)
        Me.LoadingProgressBar.Name = "LoadingProgressBar"
        Me.LoadingProgressBar.Size = New System.Drawing.Size(276, 28)
        Me.LoadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingProgressBar.TabIndex = 0
        '
        'LoadingTextBox
        '
        Me.LoadingTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.LoadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoadingTextBox.Enabled = False
        Me.LoadingTextBox.HideSelection = False
        Me.LoadingTextBox.Location = New System.Drawing.Point(4, 36)
        Me.LoadingTextBox.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.LoadingTextBox.Name = "LoadingTextBox"
        Me.LoadingTextBox.Size = New System.Drawing.Size(276, 13)
        Me.LoadingTextBox.TabIndex = 1
        Me.LoadingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 53)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoadingTextBox)
        Me.Controls.Add(Me.LoadingProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingProgressBar As ProgressBar
    Public WithEvents LoadingTextBox As TextBox
End Class
