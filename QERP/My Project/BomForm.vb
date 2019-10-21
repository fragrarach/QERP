Public Class BomForm

    Shadows ParentForm

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub
    Public Sub TreeViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SelectedPart As String = SelectedPartTextBox.Text
        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If
        LoadData()
    End Sub
    Public Sub LoadData()
        Dim SelectedPart As String = SelectedPartTextBox.Text

        LoadingForm.LoadingFormInit("Loading bill of materials for " + SelectedPart, Me)
        Me.BomTreeView.Nodes.Clear()
        Me.BomTreeView.Refresh()

        ResetParentLabel()
        Me.SelectedPartDataGridView.Columns.Clear()
        Me.SelectedPartDataGridView.Refresh()

        ResetAncestorLabel()
        Me.AncestorDataGridView.Columns.Clear()
        Me.AncestorDataGridView.Refresh()

        ResetChildLabel()
        Me.SelectedChildDataGridView.Columns.Clear()
        Me.SelectedChildDataGridView.Refresh()

        LoadTreeNodes()

        Dim RecordBinding As BindingSource = LoadSelectedPartData()
        LoadSelectedPartColumns(RecordBinding)
        LoadParentLabel()

        LoadingForm.Close()
    End Sub
    Public Sub LoadTreeNodes()
        Dim Query As String
        Dim DirectChildPartNumber As String
        Dim SortNumber As String
        Dim RootPart As String = SelectedPartTextBox.Text
        Dim OldSelectedPart As String

        If Me.BomTreeView.Nodes.Count > 0 Then
            OldSelectedPart = Me.BomTreeView.Nodes(0).Text
        Else
            OldSelectedPart = ""
        End If
        If RootPart <> OldSelectedPart Then
            Query = "SELECT DISTINCT target_no FROM descendents WHERE target_no = '" + RootPart + "'"
            Dim ParentRecord As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
            If ParentRecord IsNot Nothing Then

                Dim TreeRoot = New TreeNode(RootPart)
                Me.BomTreeView.Nodes.Add(TreeRoot)

                Query = "SELECT des_no, bma_sort FROM descendents WHERE target_no = '" + RootPart + "' AND direct_parent_no = '" + RootPart + "'"
                Dim DirectChildrenRecord As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

                For RowIndex = 0 To UBound(DirectChildrenRecord, 2)
                    DirectChildPartNumber = Trim(DirectChildrenRecord(0, RowIndex))
                    SortNumber = DirectChildrenRecord(1, RowIndex)
                    Dim TreeNode = New TreeNode(DirectChildPartNumber) With {
                    .Tag = SortNumber
                }
                    TreeRoot.Nodes.Add(TreeNode)
                Next

                Query = "SELECT DISTINCT des_no, direct_parent_no, bma_sort, child_sort FROM descendents WHERE target_no = '" + RootPart + "' ORDER BY bma_sort, child_sort"
                Dim RootRecord As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

                RecurseNodes(Me.BomTreeView.Nodes, RootRecord)

                Me.BomTreeView.ExpandAll()
                Me.BomTreeView.SelectedNode = TreeRoot

            Else
                MessageBox.Show("No bill of materials exists for selected part number")
                SelectedPartTextBox.Text = OldSelectedPart
            End If
        End If
    End Sub
    Private Sub RecurseNodes(ByVal RootNode As TreeNodeCollection, ByVal RootRecord As Array)
        Dim NodePartNumber As String
        Dim RecordPartNumber As String
        Dim SortNumber As String
        Dim ChildPartNumber As String

        For Each Node As TreeNode In RootNode

            NodePartNumber = Node.Text

            For RowIndex = 0 To UBound(RootRecord, 2)

                ChildPartNumber = Trim(RootRecord(0, RowIndex))
                RecordPartNumber = Trim(RootRecord(1, RowIndex))
                SortNumber = Trim(Str(RootRecord(2, RowIndex)))

                If RecordPartNumber = NodePartNumber And Node.Tag = SortNumber Then
                    Dim TreeNode = New TreeNode(ChildPartNumber) With {
                        .Tag = SortNumber
                    }
                    Node.Nodes.Add(TreeNode)
                End If
            Next

            RecurseNodes(Node.Nodes, RootRecord)

        Next
    End Sub
    Private Function LoadSelectedPartData()
        Dim SelectedPart As String = SelectedPartTextBox.Text
        Dim Query As String = "SELECT prt_no, prt_desc, bma_budg_qty 
                                FROM bill_of_materials_mat 
                                WHERE prt_no <> '' 
                                AND prt_master_id = (SELECT prt_id FROM part WHERE prt_no = '" + SelectedPart + "')
                                ORDER BY bma_sort"
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable
        Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
        }

        If Record IsNot Nothing Then
            Me.SelectedPartDataGridView.Columns.Clear()

            For ColumnIndex = 0 To UBound(Record, 1)
                RecordTable.Columns.Add(ColumnIndex)
            Next

            For RowIndex = 0 To UBound(Record, 2)
                Dim RecordRow As DataRow = RecordTable.NewRow
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        RecordRow(ColumnIndex) = Trim(Record(ColumnIndex, RowIndex))
                    ElseIf TypeOf Record(ColumnIndex, RowIndex) Is DateTime Then
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex).ToShortDateString()
                    Else
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex)
                    End If
                Next
                RecordTable.Rows.Add(RecordRow)
            Next
        End If

        ExtensionMethods.DoubleBuffered(Me.SelectedPartDataGridView, True)
        Return RecordBinding
    End Function

    Private Sub LoadSelectedPartColumns(Optional RecordBinding As BindingSource = Nothing)

        If Not IsNothing(RecordBinding) Then
            Me.SelectedPartDataGridView.DataSource = RecordBinding
        End If

        Me.SelectedPartDataGridView.RowHeadersWidth = 21

        For i = 0 To Me.SelectedPartDataGridView.Columns.Count - 1
            Me.SelectedPartDataGridView.Columns(i).ReadOnly = True
        Next

        If Me.SelectedPartDataGridView.Rows.Count > 0 Then
            Me.SelectedPartDataGridView.Columns(0).HeaderText = "Part #"
            Me.SelectedPartDataGridView.Columns(1).HeaderText = "Description"
            Me.SelectedPartDataGridView.Columns(2).HeaderText = "Quantity"
        End If

        For Each column As DataGridViewColumn In Me.SelectedPartDataGridView.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.SelectedPartDataGridView.ClearSelection()

    End Sub
    Private Function LoadSelectedChildData()
        Dim SelectedPart As String = Me.BomTreeView.SelectedNode.Text
        Dim Query As String = "SELECT prt_no, prt_desc, bma_budg_qty 
                                FROM bill_of_materials_mat 
                                WHERE prt_no <> '' 
                                AND prt_master_id = (SELECT prt_id FROM part WHERE prt_no = '" + SelectedPart + "')
                                ORDER BY bma_sort"
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable
        Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
        }

        If Record IsNot Nothing Then
            Me.SelectedChildDataGridView.Columns.Clear()

            For ColumnIndex = 0 To UBound(Record, 1)
                RecordTable.Columns.Add(ColumnIndex)
            Next

            For RowIndex = 0 To UBound(Record, 2)
                Dim RecordRow As DataRow = RecordTable.NewRow
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        RecordRow(ColumnIndex) = Trim(Record(ColumnIndex, RowIndex))
                    ElseIf TypeOf Record(ColumnIndex, RowIndex) Is DateTime Then
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex).ToShortDateString()
                    Else
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex)
                    End If
                Next
                RecordTable.Rows.Add(RecordRow)
            Next
        End If

        ExtensionMethods.DoubleBuffered(Me.SelectedChildDataGridView, True)
        Return RecordBinding
    End Function
    Private Sub LoadSelectedChildColumns(Optional RecordBinding As BindingSource = Nothing)
        Dim ColumnIndex As Int16 = 0

        If Not IsNothing(RecordBinding) Then
            Me.SelectedChildDataGridView.DataSource = RecordBinding
        End If

        Me.SelectedChildDataGridView.RowHeadersWidth = 21

        For i = 0 To Me.SelectedChildDataGridView.Columns.Count - 1
            Me.SelectedChildDataGridView.Columns(i).ReadOnly = True
        Next

        If Me.SelectedChildDataGridView.Rows.Count > 0 Then
            Me.SelectedChildDataGridView.Columns(0).HeaderText = "Part #"
            Me.SelectedChildDataGridView.Columns(1).HeaderText = "Description"
            Me.SelectedChildDataGridView.Columns(2).HeaderText = "Quantity"
        End If

        For Each column As DataGridViewColumn In Me.SelectedChildDataGridView.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.SelectedChildDataGridView.ClearSelection()
    End Sub
    Private Function LoadAncestorData()
        Dim SelectedPart As String = Me.BomTreeView.SelectedNode.Text
        Dim Query As String = "SELECT DISTINCT target_no FROM descendents WHERE des_no = '" + SelectedPart + "'"
        Dim Record As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim RecordTable As New DataTable
        Dim RecordBinding As New BindingSource With {
                .DataSource = RecordTable
        }

        If Record IsNot Nothing Then
            Me.AncestorDataGridView.Columns.Clear()

            For ColumnIndex = 0 To UBound(Record, 1)
                RecordTable.Columns.Add(ColumnIndex)
            Next

            For RowIndex = 0 To UBound(Record, 2)
                Dim RecordRow As DataRow = RecordTable.NewRow
                For ColumnIndex = 0 To UBound(Record, 1)
                    If TypeOf Record(ColumnIndex, RowIndex) Is String Then
                        RecordRow(ColumnIndex) = Trim(Record(ColumnIndex, RowIndex))
                    ElseIf TypeOf Record(ColumnIndex, RowIndex) Is DateTime Then
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex).ToShortDateString()
                    Else
                        RecordRow(ColumnIndex) = Record(ColumnIndex, RowIndex)
                    End If
                Next
                RecordTable.Rows.Add(RecordRow)
            Next
        End If

        ExtensionMethods.DoubleBuffered(Me.AncestorDataGridView, True)
        Return RecordBinding
    End Function
    Private Sub LoadAncestorColumns(Optional RecordBinding As BindingSource = Nothing)
        Dim ColumnIndex As Int16 = 0

        If Not IsNothing(RecordBinding) Then
            Me.AncestorDataGridView.DataSource = RecordBinding
        End If

        Me.AncestorDataGridView.RowHeadersWidth = 21

        For i = 0 To Me.AncestorDataGridView.Columns.Count - 1
            Me.AncestorDataGridView.Columns(i).ReadOnly = True
        Next

        If Me.AncestorDataGridView.Rows.Count > 0 Then
            Me.AncestorDataGridView.Columns(0).HeaderText = "Part #"
        End If

        For Each column As DataGridViewColumn In Me.AncestorDataGridView.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.AncestorDataGridView.ClearSelection()
    End Sub
    Private Sub LoadSelectedNodeData()

    End Sub
    Private Sub LoadParentLabel()
        Dim SelectedPart As String = SelectedPartTextBox.Text
        If SelectedPart <> "" Then
            Me.SelectedParentLabel.Text = "Parent Bill of Materials (" + SelectedPart + ")"
        Else
            Me.SelectedParentLabel.Text = "Parent Bill of Materials"
        End If
    End Sub
    Private Sub ResetParentLabel()
        Me.SelectedParentLabel.Text = "Parent Bill of Materials"
        Me.SelectedParentLabel.Refresh()
    End Sub
    Private Sub LoadChildLabel()
        Dim SelectedChild As String = Me.BomTreeView.SelectedNode.Text
        Me.SelectedChildLabel.Text = "Child Bill of Materials (" + SelectedChild + ")"
    End Sub
    Private Sub ResetChildLabel()
        Me.SelectedChildLabel.Text = "Child Bill of Materials"
        Me.SelectedChildLabel.Refresh()
    End Sub
    Private Sub LoadAncestorLabel()
        Dim SelectedPart As String = Me.BomTreeView.SelectedNode.Text
        If SelectedPart <> "" Then
            Me.AncestorLabel.Text = "Ancestor Bills of Materials (" + SelectedPart + ")"
        Else
            Me.AncestorLabel.Text = "Ancestor Bills of Materials"
        End If
    End Sub
    Private Sub ResetAncestorLabel()
        Me.AncestorLabel.Text = "Ancestor Bills of Materials"
        Me.AncestorLabel.Refresh()
    End Sub
    Private Sub CollapseAllButton_Click(sender As Object, e As EventArgs) Handles CollapseAllButton.Click
        Me.BomTreeView.CollapseAll()
    End Sub

    Private Sub ExpandAllButton_Click(sender As Object, e As EventArgs) Handles ExpandAllButton.Click
        If Me.BomTreeView.Nodes.Count > 0 Then
            Me.BomTreeView.ExpandAll()
            Me.BomTreeView.SelectedNode = Me.BomTreeView.Nodes(0)
        End If
    End Sub
    Private Sub PartSearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartSearchTextBox.KeyDown
        If e.KeyValue = 13 And PartSearchTextBox.Text <> "" Then
            PartSearch()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PartSearch()
        Dim PartSearch As String = Trim(PartSearchTextBox.Text.ToUpper)
        Dim Query As String = "SELECT target_no FROM descendents WHERE target_no ='" & PartSearch & "'"
        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)

        If Record IsNot Nothing Then
            SelectedPartTextBox.Text = PartSearch
        End If
    End Sub
    Private Sub SelectedPartTextBox_TextChanged(sender As Object, e As EventArgs) Handles SelectedPartTextBox.TextChanged
        LoadData()
    End Sub
    Private Sub PartGridButton_Click(sender As Object, e As EventArgs) Handles PartGridButton.Click
        Dim PartListingFormInstance
        If ParentForm IsNot Nothing Then
            PartListingFormInstance = New PartListingForm(Me, ParentForm)
        Else
            PartListingFormInstance = New PartListingForm(Me)
        End If
        PartListingFormInstance.Location = PositioningMethods.CenterToCenter(PartListingFormInstance, Me)
        PartListingFormInstance.Show()
    End Sub

    Private Sub BomTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles BomTreeView.AfterSelect
        Dim SelectedPart As String = Me.PartSearchTextBox.Text
        Dim SelectedNode As String = Me.BomTreeView.SelectedNode.Text
        Dim RecordBinding As BindingSource

        LoadingForm.LoadingFormInit("Loading reference information for " + SelectedNode, Me)

        ResetChildLabel()
        Me.SelectedChildDataGridView.Columns.Clear()
        Me.SelectedChildDataGridView.Refresh()
        ResetAncestorLabel()
        Me.AncestorDataGridView.Columns.Clear()
        Me.AncestorDataGridView.Refresh()

        If SelectedNode <> SelectedPart Then
            RecordBinding = LoadSelectedChildData()
            If RecordBinding.Count > 0 Then
                LoadChildLabel()
            End If
            LoadSelectedChildColumns(RecordBinding)
        End If

        LoadAncestorLabel()
        RecordBinding = LoadAncestorData()
        LoadAncestorColumns(RecordBinding)

        LoadingForm.Close()
    End Sub

    Private Sub BomTreeView_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles BomTreeView.NodeMouseDoubleClick
        Me.SelectedPartTextBox.Text = Me.BomTreeView.SelectedNode.Text
    End Sub

    Private Sub AncestorDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AncestorDataGridView.CellDoubleClick
        Me.SelectedPartTextBox.Text = Me.AncestorDataGridView.Item(0, e.RowIndex).Value
    End Sub
End Class