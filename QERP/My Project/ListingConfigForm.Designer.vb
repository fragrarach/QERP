<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListingConfigForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListingConfigForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnDisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.ColumnDisplayListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SaveConfigButton = New System.Windows.Forms.Button()
        Me.CheckBoxOffButton = New System.Windows.Forms.Button()
        Me.CheckBoxOnButton = New System.Windows.Forms.Button()
        Me.ColumnDisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(1, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 2)
        Me.Label2.TabIndex = 7
        '
        'ColumnDisplayGroupBox
        '
        Me.ColumnDisplayGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColumnDisplayGroupBox.Controls.Add(Me.ColumnDisplayListView)
        Me.ColumnDisplayGroupBox.Location = New System.Drawing.Point(5, 42)
        Me.ColumnDisplayGroupBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ColumnDisplayGroupBox.Name = "ColumnDisplayGroupBox"
        Me.ColumnDisplayGroupBox.Size = New System.Drawing.Size(462, 475)
        Me.ColumnDisplayGroupBox.TabIndex = 8
        Me.ColumnDisplayGroupBox.TabStop = False
        Me.ColumnDisplayGroupBox.Text = "Select Columns to be Displayed"
        '
        'ColumnDisplayListView
        '
        Me.ColumnDisplayListView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ColumnDisplayListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColumnDisplayListView.CheckBoxes = True
        Me.ColumnDisplayListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ColumnDisplayListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ColumnDisplayListView.Location = New System.Drawing.Point(6, 19)
        Me.ColumnDisplayListView.Name = "ColumnDisplayListView"
        Me.ColumnDisplayListView.Size = New System.Drawing.Size(450, 450)
        Me.ColumnDisplayListView.TabIndex = 0
        Me.ColumnDisplayListView.UseCompatibleStateImageBehavior = False
        Me.ColumnDisplayListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 400
        '
        'SaveConfigButton
        '
        Me.SaveConfigButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveConfigButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SaveConfigButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.SaveConfigButton.FlatAppearance.BorderSize = 0
        Me.SaveConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.SaveConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.SaveConfigButton.Image = CType(resources.GetObject("SaveConfigButton.Image"), System.Drawing.Image)
        Me.SaveConfigButton.Location = New System.Drawing.Point(376, 5)
        Me.SaveConfigButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveConfigButton.Name = "SaveConfigButton"
        Me.SaveConfigButton.Size = New System.Drawing.Size(90, 25)
        Me.SaveConfigButton.TabIndex = 6
        Me.SaveConfigButton.Text = "  Apply"
        Me.SaveConfigButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveConfigButton.UseVisualStyleBackColor = False
        '
        'CheckBoxOffButton
        '
        Me.CheckBoxOffButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBoxOffButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOffButton.FlatAppearance.BorderSize = 0
        Me.CheckBoxOffButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOffButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOffButton.Image = Global.QERP.My.Resources.Resources.CHECK_BOX_OFF_ICON
        Me.CheckBoxOffButton.Location = New System.Drawing.Point(30, 5)
        Me.CheckBoxOffButton.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.CheckBoxOffButton.Name = "CheckBoxOffButton"
        Me.CheckBoxOffButton.Size = New System.Drawing.Size(25, 25)
        Me.CheckBoxOffButton.TabIndex = 6
        Me.CheckBoxOffButton.UseVisualStyleBackColor = False
        '
        'CheckBoxOnButton
        '
        Me.CheckBoxOnButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBoxOnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOnButton.FlatAppearance.BorderSize = 0
        Me.CheckBoxOnButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOnButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxOnButton.Image = Global.QERP.My.Resources.Resources.CHECK_BOX_ON_ICON
        Me.CheckBoxOnButton.Location = New System.Drawing.Point(5, 5)
        Me.CheckBoxOnButton.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CheckBoxOnButton.Name = "CheckBoxOnButton"
        Me.CheckBoxOnButton.Size = New System.Drawing.Size(25, 25)
        Me.CheckBoxOnButton.TabIndex = 6
        Me.CheckBoxOnButton.UseVisualStyleBackColor = False
        '
        'ListingConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 521)
        Me.Controls.Add(Me.ColumnDisplayGroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveConfigButton)
        Me.Controls.Add(Me.CheckBoxOffButton)
        Me.Controls.Add(Me.CheckBoxOnButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListingConfigForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Listing Configuration"
        Me.ColumnDisplayGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckBoxOnButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnDisplayGroupBox As GroupBox
    Friend WithEvents ColumnDisplayListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents SaveConfigButton As Button
    Friend WithEvents CheckBoxOffButton As Button
End Class
