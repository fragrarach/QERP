<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PartListingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartListingForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PartListingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PartCountToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchFieldGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PartListSearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PartListDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnConfigButton = New System.Windows.Forms.Button()
        Me.PartListingToolStrip.SuspendLayout()
        Me.SearchFieldGroupBox.SuspendLayout()
        CType(Me.PartListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(4, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(0, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 2)
        Me.Label2.TabIndex = 4
        '
        'PartListingToolStrip
        '
        Me.PartListingToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PartListingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartCountToolStripTextBox, Me.ToolStripSeparator1})
        Me.PartListingToolStrip.Location = New System.Drawing.Point(1, 415)
        Me.PartListingToolStrip.Name = "PartListingToolStrip"
        Me.PartListingToolStrip.Size = New System.Drawing.Size(622, 25)
        Me.PartListingToolStrip.TabIndex = 6
        Me.PartListingToolStrip.Text = "ToolStrip1"
        '
        'PartCountToolStripTextBox
        '
        Me.PartCountToolStripTextBox.Name = "PartCountToolStripTextBox"
        Me.PartCountToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SearchFieldGroupBox
        '
        Me.SearchFieldGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchFieldGroupBox.Controls.Add(Me.Button2)
        Me.SearchFieldGroupBox.Controls.Add(Me.PartListSearchTextBox)
        Me.SearchFieldGroupBox.Location = New System.Drawing.Point(4, 364)
        Me.SearchFieldGroupBox.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.SearchFieldGroupBox.Name = "SearchFieldGroupBox"
        Me.SearchFieldGroupBox.Size = New System.Drawing.Size(414, 48)
        Me.SearchFieldGroupBox.TabIndex = 7
        Me.SearchFieldGroupBox.TabStop = False
        Me.SearchFieldGroupBox.Text = "Search Field : Part Number"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(380, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 6, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PartListSearchTextBox
        '
        Me.PartListSearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartListSearchTextBox.Location = New System.Drawing.Point(9, 17)
        Me.PartListSearchTextBox.Margin = New System.Windows.Forms.Padding(6, 1, 4, 4)
        Me.PartListSearchTextBox.Name = "PartListSearchTextBox"
        Me.PartListSearchTextBox.Size = New System.Drawing.Size(363, 20)
        Me.PartListSearchTextBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 364)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Page X of X"
        '
        'PartListDataGridView
        '
        Me.PartListDataGridView.AllowUserToAddRows = False
        Me.PartListDataGridView.AllowUserToDeleteRows = False
        Me.PartListDataGridView.AllowUserToResizeRows = False
        Me.PartListDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PartListDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PartListDataGridView.Location = New System.Drawing.Point(5, 41)
        Me.PartListDataGridView.MultiSelect = False
        Me.PartListDataGridView.Name = "PartListDataGridView"
        Me.PartListDataGridView.ReadOnly = True
        Me.PartListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.PartListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PartListDataGridView.Size = New System.Drawing.Size(615, 317)
        Me.PartListDataGridView.TabIndex = 9
        '
        'ColumnConfigButton
        '
        Me.ColumnConfigButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColumnConfigButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.FlatAppearance.BorderSize = 0
        Me.ColumnConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.Image = CType(resources.GetObject("ColumnConfigButton.Image"), System.Drawing.Image)
        Me.ColumnConfigButton.Location = New System.Drawing.Point(37, 4)
        Me.ColumnConfigButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ColumnConfigButton.Name = "ColumnConfigButton"
        Me.ColumnConfigButton.Size = New System.Drawing.Size(25, 25)
        Me.ColumnConfigButton.TabIndex = 5
        Me.ColumnConfigButton.UseVisualStyleBackColor = False
        '
        'PartListingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.PartListDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SearchFieldGroupBox)
        Me.Controls.Add(Me.PartListingToolStrip)
        Me.Controls.Add(Me.ColumnConfigButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 240)
        Me.Name = "PartListingForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Part Listing"
        Me.PartListingToolStrip.ResumeLayout(False)
        Me.PartListingToolStrip.PerformLayout()
        Me.SearchFieldGroupBox.ResumeLayout(False)
        Me.SearchFieldGroupBox.PerformLayout()
        CType(Me.PartListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PartListingToolStrip As ToolStrip
    Friend WithEvents PartCountToolStripTextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SearchFieldGroupBox As GroupBox
    Friend WithEvents PartListSearchTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PartListDataGridView As DataGridView
    Friend WithEvents ColumnConfigButton As Button
    Friend WithEvents Button2 As Button
End Class
