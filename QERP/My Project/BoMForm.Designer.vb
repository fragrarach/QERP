<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BomForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BomForm))
        Me.BomTreeView = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollapseAllButton = New System.Windows.Forms.Button()
        Me.ExpandAllButton = New System.Windows.Forms.Button()
        Me.ActivePartLabel = New System.Windows.Forms.Label()
        Me.PartGridButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectedPartTextBox = New System.Windows.Forms.TextBox()
        Me.PartSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AncestorDataGridView = New System.Windows.Forms.DataGridView()
        Me.AncestorLabel = New System.Windows.Forms.Label()
        Me.SelectedChildLabel = New System.Windows.Forms.Label()
        Me.SelectedPartDataGridView = New System.Windows.Forms.DataGridView()
        Me.SelectedChildDataGridView = New System.Windows.Forms.DataGridView()
        Me.SelectedParentLabel = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AncestorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedPartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedChildDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BomTreeView
        '
        Me.BomTreeView.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BomTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BomTreeView.Location = New System.Drawing.Point(3, 3)
        Me.BomTreeView.Name = "BomTreeView"
        Me.TableLayoutPanel1.SetRowSpan(Me.BomTreeView, 4)
        Me.BomTreeView.Size = New System.Drawing.Size(294, 365)
        Me.BomTreeView.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(0, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(785, 2)
        Me.Label2.TabIndex = 5
        '
        'CollapseAllButton
        '
        Me.CollapseAllButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CollapseAllButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.CollapseAllButton.FlatAppearance.BorderSize = 0
        Me.CollapseAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.CollapseAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.CollapseAllButton.Image = CType(resources.GetObject("CollapseAllButton.Image"), System.Drawing.Image)
        Me.CollapseAllButton.Location = New System.Drawing.Point(29, 4)
        Me.CollapseAllButton.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.CollapseAllButton.Name = "CollapseAllButton"
        Me.CollapseAllButton.Size = New System.Drawing.Size(25, 25)
        Me.CollapseAllButton.TabIndex = 6
        Me.CollapseAllButton.UseVisualStyleBackColor = False
        '
        'ExpandAllButton
        '
        Me.ExpandAllButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExpandAllButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.ExpandAllButton.FlatAppearance.BorderSize = 0
        Me.ExpandAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.ExpandAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.ExpandAllButton.Image = Global.QERP.My.Resources.Resources.EXPAND_ALL_ICON
        Me.ExpandAllButton.Location = New System.Drawing.Point(4, 4)
        Me.ExpandAllButton.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.ExpandAllButton.Name = "ExpandAllButton"
        Me.ExpandAllButton.Size = New System.Drawing.Size(25, 25)
        Me.ExpandAllButton.TabIndex = 7
        Me.ExpandAllButton.UseVisualStyleBackColor = False
        '
        'ActivePartLabel
        '
        Me.ActivePartLabel.AutoSize = True
        Me.ActivePartLabel.ForeColor = System.Drawing.Color.Black
        Me.ActivePartLabel.Location = New System.Drawing.Point(311, 44)
        Me.ActivePartLabel.Name = "ActivePartLabel"
        Me.ActivePartLabel.Size = New System.Drawing.Size(70, 13)
        Me.ActivePartLabel.TabIndex = 12
        Me.ActivePartLabel.Text = "Active Status"
        '
        'PartGridButton
        '
        Me.PartGridButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PartGridButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PartGridButton.FlatAppearance.BorderSize = 0
        Me.PartGridButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.PartGridButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.PartGridButton.Image = CType(resources.GetObject("PartGridButton.Image"), System.Drawing.Image)
        Me.PartGridButton.Location = New System.Drawing.Point(181, 42)
        Me.PartGridButton.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.PartGridButton.Name = "PartGridButton"
        Me.PartGridButton.Size = New System.Drawing.Size(16, 16)
        Me.PartGridButton.TabIndex = 11
        Me.PartGridButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Part :"
        '
        'SelectedPartTextBox
        '
        Me.SelectedPartTextBox.Location = New System.Drawing.Point(205, 40)
        Me.SelectedPartTextBox.MaxLength = 15
        Me.SelectedPartTextBox.Name = "SelectedPartTextBox"
        Me.SelectedPartTextBox.ReadOnly = True
        Me.SelectedPartTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SelectedPartTextBox.TabIndex = 8
        '
        'PartSearchTextBox
        '
        Me.PartSearchTextBox.Location = New System.Drawing.Point(49, 40)
        Me.PartSearchTextBox.MaxLength = 15
        Me.PartSearchTextBox.Name = "PartSearchTextBox"
        Me.PartSearchTextBox.Size = New System.Drawing.Size(150, 20)
        Me.PartSearchTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(780, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AncestorDataGridView, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AncestorLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectedChildLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectedPartDataGridView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectedChildDataGridView, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BomTreeView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectedParentLabel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 66)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 371)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'AncestorDataGridView
        '
        Me.AncestorDataGridView.AllowUserToAddRows = False
        Me.AncestorDataGridView.AllowUserToDeleteRows = False
        Me.AncestorDataGridView.AllowUserToResizeColumns = False
        Me.AncestorDataGridView.AllowUserToResizeRows = False
        Me.AncestorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AncestorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AncestorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AncestorDataGridView.Location = New System.Drawing.Point(541, 23)
        Me.AncestorDataGridView.Name = "AncestorDataGridView"
        Me.AncestorDataGridView.Size = New System.Drawing.Size(232, 159)
        Me.AncestorDataGridView.TabIndex = 14
        '
        'AncestorLabel
        '
        Me.AncestorLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AncestorLabel.AutoSize = True
        Me.AncestorLabel.Location = New System.Drawing.Point(590, 3)
        Me.AncestorLabel.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.AncestorLabel.Name = "AncestorLabel"
        Me.AncestorLabel.Size = New System.Drawing.Size(127, 13)
        Me.AncestorLabel.TabIndex = 13
        Me.AncestorLabel.Text = "Ancestor Bills of Materials"
        '
        'SelectedChildLabel
        '
        Me.SelectedChildLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SelectedChildLabel.AutoSize = True
        Me.SelectedChildLabel.Location = New System.Drawing.Point(602, 188)
        Me.SelectedChildLabel.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.SelectedChildLabel.Name = "SelectedChildLabel"
        Me.SelectedChildLabel.Size = New System.Drawing.Size(103, 13)
        Me.SelectedChildLabel.TabIndex = 12
        Me.SelectedChildLabel.Text = "Child Bill of Materials"
        '
        'SelectedPartDataGridView
        '
        Me.SelectedPartDataGridView.AllowUserToAddRows = False
        Me.SelectedPartDataGridView.AllowUserToDeleteRows = False
        Me.SelectedPartDataGridView.AllowUserToResizeColumns = False
        Me.SelectedPartDataGridView.AllowUserToResizeRows = False
        Me.SelectedPartDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectedPartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SelectedPartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectedPartDataGridView.Location = New System.Drawing.Point(303, 23)
        Me.SelectedPartDataGridView.Name = "SelectedPartDataGridView"
        Me.SelectedPartDataGridView.RowHeadersWidth = 40
        Me.SelectedPartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TableLayoutPanel1.SetRowSpan(Me.SelectedPartDataGridView, 3)
        Me.SelectedPartDataGridView.Size = New System.Drawing.Size(232, 345)
        Me.SelectedPartDataGridView.TabIndex = 0
        '
        'SelectedChildDataGridView
        '
        Me.SelectedChildDataGridView.AllowUserToAddRows = False
        Me.SelectedChildDataGridView.AllowUserToDeleteRows = False
        Me.SelectedChildDataGridView.AllowUserToResizeColumns = False
        Me.SelectedChildDataGridView.AllowUserToResizeRows = False
        Me.SelectedChildDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectedChildDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SelectedChildDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectedChildDataGridView.Location = New System.Drawing.Point(541, 208)
        Me.SelectedChildDataGridView.Name = "SelectedChildDataGridView"
        Me.SelectedChildDataGridView.Size = New System.Drawing.Size(232, 160)
        Me.SelectedChildDataGridView.TabIndex = 1
        '
        'SelectedParentLabel
        '
        Me.SelectedParentLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SelectedParentLabel.AutoSize = True
        Me.SelectedParentLabel.Location = New System.Drawing.Point(360, 3)
        Me.SelectedParentLabel.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.SelectedParentLabel.Name = "SelectedParentLabel"
        Me.SelectedParentLabel.Size = New System.Drawing.Size(111, 13)
        Me.SelectedParentLabel.TabIndex = 11
        Me.SelectedParentLabel.Text = "Parent Bill of Materials"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'BomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ActivePartLabel)
        Me.Controls.Add(Me.PartGridButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectedPartTextBox)
        Me.Controls.Add(Me.PartSearchTextBox)
        Me.Controls.Add(Me.ExpandAllButton)
        Me.Controls.Add(Me.CollapseAllButton)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 480)
        Me.Name = "BomForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Bill of Materials"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AncestorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedPartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedChildDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BomTreeView As TreeView
    Friend WithEvents Label2 As Label
    Friend WithEvents CollapseAllButton As Button
    Friend WithEvents ExpandAllButton As Button
    Friend WithEvents ActivePartLabel As Label
    Friend WithEvents PartGridButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PartSearchTextBox As TextBox
    Public WithEvents SelectedPartTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SelectedPartDataGridView As DataGridView
    Friend WithEvents SelectedChildDataGridView As DataGridView
    Friend WithEvents SelectedParentLabel As Label
    Friend WithEvents SelectedChildLabel As Label
    Friend WithEvents AncestorLabel As Label
    Friend WithEvents AncestorDataGridView As DataGridView
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
