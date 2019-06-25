<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListingForm))
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchFieldGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnConfigButton = New System.Windows.Forms.Button()
        Me.ListingToolStrip.SuspendLayout()
        Me.SearchFieldGroupBox.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.SearchButton.Image = Global.QERP.My.Resources.Resources.SEARCH_ICON
        Me.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchButton.Location = New System.Drawing.Point(4, 4)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchButton.TabIndex = 5
        Me.SearchButton.UseVisualStyleBackColor = False
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
        'ListingToolStrip
        '
        Me.ListingToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountToolStripLabel, Me.ToolStripSeparator1})
        Me.ListingToolStrip.Location = New System.Drawing.Point(1, 415)
        Me.ListingToolStrip.Name = "ListingToolStrip"
        Me.ListingToolStrip.Size = New System.Drawing.Size(622, 25)
        Me.ListingToolStrip.TabIndex = 6
        Me.ListingToolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CountToolStripLabel
        '
        Me.CountToolStripLabel.Name = "CountToolStripLabel"
        Me.CountToolStripLabel.Size = New System.Drawing.Size(0, 22)
        '
        'SearchFieldGroupBox
        '
        Me.SearchFieldGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchFieldGroupBox.Controls.Add(Me.Button2)
        Me.SearchFieldGroupBox.Controls.Add(Me.SearchTextBox)
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
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(9, 17)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(6, 1, 4, 4)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(363, 20)
        Me.SearchTextBox.TabIndex = 0
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
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView.Location = New System.Drawing.Point(5, 41)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(615, 317)
        Me.DataGridView.TabIndex = 9
        '
        'ColumnConfigButton
        '
        Me.ColumnConfigButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColumnConfigButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.FlatAppearance.BorderSize = 0
        Me.ColumnConfigButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.ColumnConfigButton.Image = Global.QERP.My.Resources.Resources.CONFIGURE_ICON
        Me.ColumnConfigButton.Location = New System.Drawing.Point(36, 4)
        Me.ColumnConfigButton.Name = "ColumnConfigButton"
        Me.ColumnConfigButton.Size = New System.Drawing.Size(25, 25)
        Me.ColumnConfigButton.TabIndex = 10
        Me.ColumnConfigButton.UseVisualStyleBackColor = False
        '
        'ListingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SearchFieldGroupBox)
        Me.Controls.Add(Me.ListingToolStrip)
        Me.Controls.Add(Me.ColumnConfigButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 240)
        Me.Name = "ListingForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Part Listing"
        Me.ListingToolStrip.ResumeLayout(False)
        Me.ListingToolStrip.PerformLayout()
        Me.SearchFieldGroupBox.ResumeLayout(False)
        Me.SearchFieldGroupBox.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListingToolStrip As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SearchFieldGroupBox As GroupBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColumnConfigButton As Button
    Friend WithEvents Button2 As Button
    Public WithEvents DataGridView As DataGridView
    Friend WithEvents CountToolStripLabel As ToolStripLabel
End Class
