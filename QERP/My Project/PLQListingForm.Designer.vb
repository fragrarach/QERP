﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PLQListingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLQListingForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PLQListingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PLQCountToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchFieldGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PLQListSearchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PLQListDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnConfigButton = New System.Windows.Forms.Button()
        Me.PLQListingToolStrip.SuspendLayout()
        Me.SearchFieldGroupBox.SuspendLayout()
        CType(Me.PLQListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PLQListingToolStrip
        '
        Me.PLQListingToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PLQListingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLQCountToolStripTextBox, Me.ToolStripSeparator1})
        Me.PLQListingToolStrip.Location = New System.Drawing.Point(1, 415)
        Me.PLQListingToolStrip.Name = "PLQListingToolStrip"
        Me.PLQListingToolStrip.Size = New System.Drawing.Size(622, 25)
        Me.PLQListingToolStrip.TabIndex = 6
        Me.PLQListingToolStrip.Text = "ToolStrip1"
        '
        'PLQCountToolStripTextBox
        '
        Me.PLQCountToolStripTextBox.Name = "PLQCountToolStripTextBox"
        Me.PLQCountToolStripTextBox.Size = New System.Drawing.Size(100, 25)
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
        Me.SearchFieldGroupBox.Controls.Add(Me.PLQListSearchTextBox)
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
        'PLQListSearchTextBox
        '
        Me.PLQListSearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PLQListSearchTextBox.Location = New System.Drawing.Point(9, 17)
        Me.PLQListSearchTextBox.Margin = New System.Windows.Forms.Padding(6, 1, 4, 4)
        Me.PLQListSearchTextBox.Name = "PLQListSearchTextBox"
        Me.PLQListSearchTextBox.Size = New System.Drawing.Size(363, 20)
        Me.PLQListSearchTextBox.TabIndex = 0
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
        'PLQListDataGridView
        '
        Me.PLQListDataGridView.AllowUserToAddRows = False
        Me.PLQListDataGridView.AllowUserToDeleteRows = False
        Me.PLQListDataGridView.AllowUserToResizeRows = False
        Me.PLQListDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PLQListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PLQListDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PLQListDataGridView.Location = New System.Drawing.Point(5, 41)
        Me.PLQListDataGridView.MultiSelect = False
        Me.PLQListDataGridView.Name = "PLQListDataGridView"
        Me.PLQListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.PLQListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PLQListDataGridView.Size = New System.Drawing.Size(615, 317)
        Me.PLQListDataGridView.TabIndex = 9
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
        'PLQListingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.PLQListDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SearchFieldGroupBox)
        Me.Controls.Add(Me.PLQListingToolStrip)
        Me.Controls.Add(Me.ColumnConfigButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 240)
        Me.Name = "PLQListingForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Planning Book"
        Me.PLQListingToolStrip.ResumeLayout(False)
        Me.PLQListingToolStrip.PerformLayout()
        Me.SearchFieldGroupBox.ResumeLayout(False)
        Me.SearchFieldGroupBox.PerformLayout()
        CType(Me.PLQListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PLQListingToolStrip As ToolStrip
    Friend WithEvents PLQCountToolStripTextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SearchFieldGroupBox As GroupBox
    Friend WithEvents PLQListSearchTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PLQListDataGridView As DataGridView
    Friend WithEvents ColumnConfigButton As Button
    Friend WithEvents Button2 As Button
End Class
