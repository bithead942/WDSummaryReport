<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrors))
        Me.Errors_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.Errors_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDSummaryReport2.WatchdogDataSet()
        Me.Errors_ListTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Errors_ListTableAdapter()
        Me.TableAdapterManager = New WDSummaryReport2.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Errors_ListDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Errors_ListBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.WatchdogDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Errors_ListDataGridView
        '
        Me.Errors_ListDataGridView.AllowUserToAddRows = false
        Me.Errors_ListDataGridView.AllowUserToDeleteRows = false
        Me.Errors_ListDataGridView.AllowUserToResizeColumns = false
        Me.Errors_ListDataGridView.AllowUserToResizeRows = false
        Me.Errors_ListDataGridView.AutoGenerateColumns = false
        Me.Errors_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Errors_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.Errors_ListDataGridView.DataSource = Me.Errors_ListBindingSource
        Me.Errors_ListDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Errors_ListDataGridView.MultiSelect = false
        Me.Errors_ListDataGridView.Name = "Errors_ListDataGridView"
        Me.Errors_ListDataGridView.ReadOnly = true
        Me.Errors_ListDataGridView.RowHeadersVisible = false
        Me.Errors_ListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Errors_ListDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Errors_ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Errors_ListDataGridView.Size = New System.Drawing.Size(463, 162)
        Me.Errors_ListDataGridView.TabIndex = 2
        '
        'Errors_ListBindingSource
        '
        Me.Errors_ListBindingSource.DataMember = "Errors_List"
        Me.Errors_ListBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Errors_ListTableAdapter
        '
        Me.Errors_ListTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Event_Daily_AggregateTableAdapter = Nothing
        Me.TableAdapterManager.Event_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.Irrigation_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.Temp_Daily_AggregateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WDSummaryReport2.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Water_Usage_HistoryTableAdapter = Nothing
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = true
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Event_Description"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Event_Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = true
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 320
        '
        'frmErrors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 186)
        Me.Controls.Add(Me.Errors_ListDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmErrors"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Error List"
        CType(Me.Errors_ListDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Errors_ListBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WatchdogDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Errors_ListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Errors_ListTableAdapter As WDSummaryReport2.WatchdogDataSetTableAdapters.Errors_ListTableAdapter
    Friend WithEvents TableAdapterManager As WDSummaryReport2.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents Errors_ListDataGridView As System.Windows.Forms.DataGridView
    Public WithEvents WatchdogDataSet As WDSummaryReport2.WatchdogDataSet
End Class
