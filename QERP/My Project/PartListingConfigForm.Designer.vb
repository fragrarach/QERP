<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartListingConfigForm
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
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("FRENCH DESCRIPTION")
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ENGLISH DESCRIPTION")
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("INTERNAL DESCRIPTION")
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SORT KEY")
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("PART TYPE")
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("GROUP #")
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("UPC #")
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("LOCATION")
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem45 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem46 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem47 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem48 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem49 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem50 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("DETAILED PART #")
        Dim ListViewItem51 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("QUANTITY ON DEMONSTRATION")
        Dim ListViewItem52 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("QUANTITY UNDERGOING REPAIR")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartListingConfigForm))
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
        ListViewItem27.StateImageIndex = 0
        ListViewItem28.StateImageIndex = 0
        ListViewItem29.StateImageIndex = 0
        ListViewItem30.StateImageIndex = 0
        ListViewItem31.StateImageIndex = 0
        ListViewItem32.StateImageIndex = 0
        ListViewItem33.StateImageIndex = 0
        ListViewItem34.StateImageIndex = 0
        ListViewItem35.StateImageIndex = 0
        ListViewItem36.StateImageIndex = 0
        ListViewItem37.StateImageIndex = 0
        ListViewItem38.StateImageIndex = 0
        ListViewItem39.StateImageIndex = 0
        ListViewItem40.StateImageIndex = 0
        ListViewItem41.StateImageIndex = 0
        ListViewItem42.StateImageIndex = 0
        ListViewItem43.StateImageIndex = 0
        ListViewItem44.StateImageIndex = 0
        ListViewItem45.StateImageIndex = 0
        ListViewItem46.StateImageIndex = 0
        ListViewItem47.StateImageIndex = 0
        ListViewItem48.StateImageIndex = 0
        ListViewItem49.StateImageIndex = 0
        ListViewItem50.StateImageIndex = 0
        ListViewItem51.StateImageIndex = 0
        ListViewItem52.StateImageIndex = 0
        Me.ColumnDisplayListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44, ListViewItem45, ListViewItem46, ListViewItem47, ListViewItem48, ListViewItem49, ListViewItem50, ListViewItem51, ListViewItem52})
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
        'PartListingConfigForm
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
        Me.Name = "PartListingConfigForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Part Listing Configuration"
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
