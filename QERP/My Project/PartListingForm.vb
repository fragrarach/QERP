﻿Public Class PartListingForm

    Friend WithEvents ActivePartsCheckBox As New CheckBox With {
            .Text = "Show Inactive",
            .Checked = True
        }

    Friend WithEvents KeepOpenCheckBox As New CheckBox With {
            .Text = "Keep Open",
            .Checked = True
        }

    Shadows ParentForm As PartForm
    Shadows FormInitialized As Boolean

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Public Sub New(ByRef ParentFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        ParentForm = ParentFormArg
    End Sub

    Public Sub New(ByRef ParentFormArg As Form, ByRef MdiFormArg As Form)
        InitializeComponent()
        Me.KeyPreview = True
        Me.Owner = MdiFormArg
        Me.MdiParent = MdiFormArg
        ParentForm = ParentFormArg
    End Sub

    Public Overrides Sub ListingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (FormInitialized) Then
            FormInitialized = True

            If ParentForm IsNot Nothing Then
                Me.Location = PositioningMethods.CenterToCenter(Me, ParentForm)
            Else
                Me.CenterToScreen()
            End If

            Dim ActivePartsHost As New ToolStripControlHost(ActivePartsCheckBox)
            PartListingToolStrip.Items.Add(ActivePartsHost)

            Dim ToolStripSeparator2 As New ToolStripSeparator
            PartListingToolStrip.Items.Add(ToolStripSeparator2)

            Dim KeepOpenHost As New ToolStripControlHost(KeepOpenCheckBox)
            PartListingToolStrip.Items.Add(KeepOpenHost)

            LoadCount()

            Dim RecordBinding As BindingSource = LoadListingData(Me)

            LoadColumns(RecordBinding)

            If Not IsNothing(ParentForm) Then
                If ParentForm.GetType() Is GetType(PartForm) Then
                    If ParentForm.SelectedPartTextBox.Text IsNot Nothing Then
                        Search(ParentForm.SelectedPartTextBox, True)
                    End If
                End If
            End If
        End If
    End Sub

    Public Overrides Sub LoadColumns(Optional RecordBinding As BindingSource = Nothing)
        Dim ColumnIndex As Int16 = 0

        If Not IsNothing(RecordBinding) Then
            Me.DataGridView.DataSource = RecordBinding
        End If

        Me.DataGridView.RowHeadersWidth = 20

        For i = 0 To Me.DataGridView.Columns.Count - 1
            Me.DataGridView.Columns(i).ReadOnly = True
        Next

        Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
        Me.DataGridView.Columns(ColumnIndex).Width = 112
        Me.DataGridView.Columns(ColumnIndex).Frozen = True


        If PartListingConfig.ActiveColumns(0) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(1) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(2) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 365
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(3) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(4) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(5) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(6) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 75
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        If PartListingConfig.ActiveColumns(7) = True Then
            ColumnIndex += 1
            Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
            Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
            Me.DataGridView.Columns(ColumnIndex).Width = 100
            Me.DataGridView.Columns(ColumnIndex).Visible = True
        Else
            ColumnIndex += 1
            Me.DataGridView.Columns(ColumnIndex).Visible = False
        End If

        Dim UserColumns As List(Of String) = FilerMethods.LoadPartIndexes()
        For i = 0 To UserColumns.Count - 1
            If PartListingConfig.ActiveColumns(8 + i) = True Then
                ColumnIndex += 1
                Me.DataGridView.Columns.Item(ColumnIndex).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
                Me.DataGridView.Columns(ColumnIndex).HeaderText = PartListingConfig.ColumnNames(ColumnIndex)
                Me.DataGridView.Columns(ColumnIndex).Width = 120
                Me.DataGridView.Columns(ColumnIndex).Visible = True
            Else
                ColumnIndex += 1
                Me.DataGridView.Columns(ColumnIndex).Visible = False
            End If
        Next


    End Sub

    Public Overrides Function CountQueryBuilder() As Object
        Dim Query As String = "SELECT COUNT(*) FROM part "

        If ActivePartsCheckBox.Checked = False Then
            Query += "WHERE prt_active = TRUE "
        End If

        Dim Record As Object = PostgresMethods.PostgresQuery(Query, ProdConnectionString)
        Dim Count As String = Record(0, 0)
        Return Count
    End Function

    Public Overrides Function ListingQueryBuilder() As Object
        Dim Query As String = "SELECT p.prt_no"


        Query += ", p.prt_desc1"

        Query += ", p.prt_desc2"

        Query += ", p.prt_desc3"

        Query += ", p.prt_sort"

        Query += ", p.prt_type"

        Query += ", pg.pgr_no"

        Query += ", p.prt_upc"

        Query += ", p.prt_location"


        Dim k As Int16 = 1
        For i = 1 To 3
            For j = 1 To 5
                Query += ", p.prt_idx" & i & "_" & j
                k += 1
            Next
        Next

        Query += " FROM part p JOIN part_group pg ON p.pgr_id = pg.pgr_id "

        If ActivePartsCheckBox.Checked = False Then
            Query += "WHERE prt_active = TRUE "
        End If

        Query += "ORDER BY p.prt_no"

        Return Query
    End Function

    Public Overrides Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If Not IsNothing(ParentForm) Then
            If ParentForm.GetType() Is GetType(PartForm) Then
                If e.ColumnIndex = 0 Then
                    ParentForm.SelectedPartTextBox.Text = Me.DataGridView.Item(0, e.RowIndex).Value
                    If KeepOpenCheckBox.Checked = False Then
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Public Overrides Sub ColumnConfigButton_Click(sender As Object, e As EventArgs)
        Dim MyConfig As New PartListingConfigForm(Me)
        MyConfig.ShowDialog()
    End Sub

    Private Sub ActivePartsCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ActivePartsCheckBox.CheckStateChanged
        Dim RecordBinding As BindingSource = LoadListingData(Me)
        LoadColumns(RecordBinding)
        LoadCount()
    End Sub
End Class