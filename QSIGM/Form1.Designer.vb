<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Prt_noLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Part = New QSIGM.part()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartTableAdapter = New QSIGM.partTableAdapters.partTableAdapter()
        Me.TableAdapterManager = New QSIGM.partTableAdapters.TableAdapterManager()
        Me.PartBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PartBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Prt_noTextBox = New System.Windows.Forms.TextBox()
        Prt_noLabel = New System.Windows.Forms.Label()
        CType(Me.Part, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PartBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Prt_noLabel
        '
        Prt_noLabel.AutoSize = True
        Prt_noLabel.Location = New System.Drawing.Point(10, 31)
        Prt_noLabel.Name = "Prt_noLabel"
        Prt_noLabel.Size = New System.Drawing.Size(37, 13)
        Prt_noLabel.TabIndex = 1
        Prt_noLabel.Text = "prt no:"
        '
        'Part
        '
        Me.Part.DataSetName = "part"
        Me.Part.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataMember = "part"
        Me.PartBindingSource.DataSource = Me.Part
        '
        'PartTableAdapter
        '
        Me.PartTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.partTableAdapter = Me.PartTableAdapter
        Me.TableAdapterManager.UpdateOrder = QSIGM.partTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PartBindingNavigator
        '
        Me.PartBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PartBindingNavigator.BindingSource = Me.PartBindingSource
        Me.PartBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PartBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PartBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PartBindingNavigatorSaveItem})
        Me.PartBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PartBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PartBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PartBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PartBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PartBindingNavigator.Name = "PartBindingNavigator"
        Me.PartBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PartBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PartBindingNavigator.TabIndex = 0
        Me.PartBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PartBindingNavigatorSaveItem
        '
        Me.PartBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PartBindingNavigatorSaveItem.Image = CType(resources.GetObject("PartBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PartBindingNavigatorSaveItem.Name = "PartBindingNavigatorSaveItem"
        Me.PartBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PartBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Prt_noTextBox
        '
        Me.Prt_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartBindingSource, "prt_no", True))
        Me.Prt_noTextBox.Location = New System.Drawing.Point(53, 28)
        Me.Prt_noTextBox.Name = "Prt_noTextBox"
        Me.Prt_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Prt_noTextBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Prt_noLabel)
        Me.Controls.Add(Me.Prt_noTextBox)
        Me.Controls.Add(Me.PartBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Part, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PartBindingNavigator.ResumeLayout(False)
        Me.PartBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Part As part
    Friend WithEvents PartBindingSource As BindingSource
    Friend WithEvents PartTableAdapter As partTableAdapters.partTableAdapter
    Friend WithEvents TableAdapterManager As partTableAdapters.TableAdapterManager
    Friend WithEvents PartBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PartBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Prt_noTextBox As TextBox
End Class
