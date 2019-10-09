Public Class TreeViewForm
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Public Sub TreeViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ParentForm IsNot Nothing Then
            Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
        Else
            Me.CenterToScreen()
        End If
        LoadData()
    End Sub
    Public Sub LoadData()
        LoadTreeNodes()
    End Sub
    Public Sub LoadTreeNodes()
        Dim Query As String
        Dim DirectChildPartNumber As String
        Dim SortNumber As String
        Dim RootPart As String = SelectedPartTextBox.Text
        Dim OldSelectedPart As String

        If Me.TreeView1.Nodes.Count > 0 Then
            OldSelectedPart = Me.TreeView1.Nodes(0).Text
        Else
            OldSelectedPart = ""
        End If
        If RootPart <> OldSelectedPart Then
            Query = "SELECT DISTINCT target_no FROM descendents WHERE target_no = '" + RootPart + "'"
            Dim ParentRecord As Array = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
            If ParentRecord IsNot Nothing Then
                Me.TreeView1.Nodes.Clear()

                Dim TreeRoot = New TreeNode(RootPart)
                Me.TreeView1.Nodes.Add(TreeRoot)

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
                RecurseNodes(Me.TreeView1.Nodes, RootRecord)

                Me.TreeView1.ExpandAll()
                Me.TreeView1.SelectedNode = TreeRoot
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

    Private Sub CollapseAllButton_Click(sender As Object, e As EventArgs) Handles CollapseAllButton.Click
        Me.TreeView1.CollapseAll()
    End Sub

    Private Sub ExpandAllButton_Click(sender As Object, e As EventArgs) Handles ExpandAllButton.Click
        Me.TreeView1.ExpandAll()
        Me.TreeView1.SelectedNode = Me.TreeView1.Nodes(0)
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
End Class