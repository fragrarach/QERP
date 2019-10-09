<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeViewForm))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollapseAllButton = New System.Windows.Forms.Button()
        Me.ExpandAllButton = New System.Windows.Forms.Button()
        Me.ActivePartLabel = New System.Windows.Forms.Label()
        Me.PartGridButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectedPartTextBox = New System.Windows.Forms.TextBox()
        Me.PartSearchTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(4, 66)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(616, 371)
        Me.TreeView1.TabIndex = 0
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
        'TreeViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.ActivePartLabel)
        Me.Controls.Add(Me.PartGridButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectedPartTextBox)
        Me.Controls.Add(Me.PartSearchTextBox)
        Me.Controls.Add(Me.ExpandAllButton)
        Me.Controls.Add(Me.CollapseAllButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TreeViewForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Tree View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label2 As Label
    Friend WithEvents CollapseAllButton As Button
    Friend WithEvents ExpandAllButton As Button
    Friend WithEvents ActivePartLabel As Label
    Friend WithEvents PartGridButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PartSearchTextBox As TextBox
    Public WithEvents SelectedPartTextBox As TextBox
End Class
