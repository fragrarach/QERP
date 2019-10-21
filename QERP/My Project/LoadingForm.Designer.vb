<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoadingTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LoadingTextBox
        '
        Me.LoadingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.LoadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoadingTextBox.Enabled = False
        Me.LoadingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoadingTextBox.HideSelection = False
        Me.LoadingTextBox.Location = New System.Drawing.Point(4, 4)
        Me.LoadingTextBox.Name = "LoadingTextBox"
        Me.LoadingTextBox.Size = New System.Drawing.Size(276, 13)
        Me.LoadingTextBox.TabIndex = 1
        Me.LoadingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 21)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoadingTextBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
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

    Public WithEvents LoadingTextBox As TextBox
End Class
