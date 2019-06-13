<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LabelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabelForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PLQSearchTextBox = New System.Windows.Forms.TextBox()
        Me.PLQGridButton = New System.Windows.Forms.Button()
        Me.SelectedPLQTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(721, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse Labels"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PLQSearchTextBox
        '
        Me.PLQSearchTextBox.Location = New System.Drawing.Point(85, 6)
        Me.PLQSearchTextBox.MaxLength = 15
        Me.PLQSearchTextBox.Name = "PLQSearchTextBox"
        Me.PLQSearchTextBox.Size = New System.Drawing.Size(150, 20)
        Me.PLQSearchTextBox.TabIndex = 7
        '
        'PLQGridButton
        '
        Me.PLQGridButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PLQGridButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PLQGridButton.FlatAppearance.BorderSize = 0
        Me.PLQGridButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.PLQGridButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.PLQGridButton.Image = CType(resources.GetObject("PLQGridButton.Image"), System.Drawing.Image)
        Me.PLQGridButton.Location = New System.Drawing.Point(217, 8)
        Me.PLQGridButton.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.PLQGridButton.Name = "PLQGridButton"
        Me.PLQGridButton.Size = New System.Drawing.Size(16, 16)
        Me.PLQGridButton.TabIndex = 8
        Me.PLQGridButton.UseVisualStyleBackColor = False
        '
        'SelectedPLQTextBox
        '
        Me.SelectedPLQTextBox.Location = New System.Drawing.Point(241, 6)
        Me.SelectedPLQTextBox.MaxLength = 15
        Me.SelectedPLQTextBox.Name = "SelectedPLQTextBox"
        Me.SelectedPLQTextBox.ReadOnly = True
        Me.SelectedPLQTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SelectedPLQTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Planning Lot : "
        '
        'LabelQuantityTextBox
        '
        Me.LabelQuantityTextBox.Location = New System.Drawing.Point(94, 4)
        Me.LabelQuantityTextBox.MaxLength = 15
        Me.LabelQuantityTextBox.Name = "LabelQuantityTextBox"
        Me.LabelQuantityTextBox.Size = New System.Drawing.Size(150, 20)
        Me.LabelQuantityTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label Quantity : "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 57)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 388)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PLQGridButton)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.SelectedPLQTextBox)
        Me.TabPage1.Controls.Add(Me.PLQSearchTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(782, 362)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Planning Lots"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.OrderDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(782, 362)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Orders"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Location = New System.Drawing.Point(6, 32)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.Size = New System.Drawing.Size(770, 324)
        Me.OrderDataGridView.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(340, 4)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label File : "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(226, 8)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(16, 16)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Order Number : "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(250, 6)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 6)
        Me.TextBox3.MaxLength = 15
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 20)
        Me.TextBox3.TabIndex = 11
        '
        'LabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelQuantityTextBox)
        Me.Name = "LabelForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents PLQGridButton As Button
    Friend WithEvents PLQSearchTextBox As TextBox
    Friend WithEvents SelectedPLQTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelQuantityTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderDataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
