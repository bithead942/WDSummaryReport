<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummaryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummaryReport))
        Me.Event_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDSummaryReport2.WatchdogDataSet()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastReportSent = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblDoorbells = New System.Windows.Forms.Label()
        Me.lblPhoneCalls = New System.Windows.Forms.Label()
        Me.lblDoorOpenWarnings = New System.Windows.Forms.Label()
        Me.lblBrineTankWarnings = New System.Windows.Forms.Label()
        Me.lblLizardNotFedWarnings = New System.Windows.Forms.Label()
        Me.lblLizardTempWarnings = New System.Windows.Forms.Label()
        Me.lblSevereWeatherWarnings = New System.Windows.Forms.Label()
        Me.lblHouseHighTempWarnings = New System.Windows.Forms.Label()
        Me.lblHouseLowTempWarnings = New System.Windows.Forms.Label()
        Me.lblServerRoomHighTempWarnings = New System.Windows.Forms.Label()
        Me.lblInternetReconnects = New System.Windows.Forms.Label()
        Me.lblTextMessagesSent = New System.Windows.Forms.Label()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.lblStairLightsOn = New System.Windows.Forms.Label()
        Me.lblStairLightsOff = New System.Windows.Forms.Label()
        Me.lblMailDelivered = New System.Windows.Forms.Label()
        Me.lblMailRetrieved = New System.Windows.Forms.Label()
        Me.lblLastRefresh = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Temp_Daily_AggregateDataGridView = New System.Windows.Forms.DataGridView()
        Me.Temp_Daily_AggregateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblMaxInsideTemp = New System.Windows.Forms.Label()
        Me.lblMinOutsideTemp = New System.Windows.Forms.Label()
        Me.lblMinInsideTemp = New System.Windows.Forms.Label()
        Me.lblAvgOutsideTemp = New System.Windows.Forms.Label()
        Me.lblAvgInsideTemp = New System.Windows.Forms.Label()
        Me.lblMaxOutsideTemp = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbDaysAgo = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTimeOccupied = New System.Windows.Forms.Label()
        Me.lblTimeUnoccupied = New System.Windows.Forms.Label()
        Me.Event_Daily_AggregateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_Daily_AggregateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSARAHInteractions = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Irrigation_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Irrigation_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblIrrigationStart = New System.Windows.Forms.Label()
        Me.lblIrrigationStop = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblIrrigationStatus = New System.Windows.Forms.Label()
        Me.lblLizardFed = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New WDSummaryReport2.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Event_HistoryTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter()
        Me.Temp_Daily_AggregateTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Temp_Daily_AggregateTableAdapter()
        Me.Event_Daily_AggregateTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Event_Daily_AggregateTableAdapter()
        Me.Irrigation_HistoryTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Irrigation_HistoryTableAdapter()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblPowerUsed = New System.Windows.Forms.Label()
        Me.lblPowerCost = New System.Windows.Forms.Label()
        Me.Water_Usage_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Water_Usage_HistoryTableAdapter = New WDSummaryReport2.WatchdogDataSetTableAdapters.Water_Usage_HistoryTableAdapter()
        Me.Water_Usage_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblGallonsUsed = New System.Windows.Forms.Label()
        Me.lblLeakDetected = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblRoombaDock = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblRoombaStart = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.btnErrors = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblIrrigationGallons = New System.Windows.Forms.Label()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_Daily_AggregateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_Daily_AggregateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Event_Daily_AggregateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Daily_AggregateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Irrigation_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Irrigation_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Water_Usage_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Water_Usage_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Event_HistoryDataGridView
        '
        Me.Event_HistoryDataGridView.AutoGenerateColumns = False
        Me.Event_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.Event_HistoryDataGridView.DataSource = Me.Event_HistoryBindingSource
        Me.Event_HistoryDataGridView.Location = New System.Drawing.Point(589, 164)
        Me.Event_HistoryDataGridView.Name = "Event_HistoryDataGridView"
        Me.Event_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_HistoryDataGridView.TabIndex = 2
        Me.Event_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Event_HistoryBindingSource
        '
        Me.Event_HistoryBindingSource.DataMember = "Event_History"
        Me.Event_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(217, 153)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(298, 153)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 9)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Last Report Sent:"
        '
        'lblLastReportSent
        '
        Me.lblLastReportSent.AutoSize = True
        Me.lblLastReportSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastReportSent.Location = New System.Drawing.Point(463, 166)
        Me.lblLastReportSent.Name = "lblLastReportSent"
        Me.lblLastReportSent.Size = New System.Drawing.Size(85, 9)
        Me.lblLastReportSent.TabIndex = 6
        Me.lblLastReportSent.Text = "01/01/2001 12:00:00 AM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 9)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Doorbells:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 9)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Phone Calls:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 9)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Open Door Warnings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 9)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Brine Tank Warning:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 9)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lizard Not Fed Warnings:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 9)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Lizard Temp Warnings:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(166, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 9)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Severe Weather Warnings:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(166, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 9)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "House High Temp Warnings:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(166, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 9)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "House Low Temp Warnings:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(166, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 9)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Server Room High Temp Warnings:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(166, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 9)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Internet Reconnects:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(166, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 9)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Text Messages Sent:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(504, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 9)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Errors:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(363, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 9)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Stair Lights On:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(363, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 9)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Stair Lights Off:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(363, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 9)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Mail Delivered:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(363, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 9)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Mail Retrieved:"
        '
        'lblDoorbells
        '
        Me.lblDoorbells.AutoSize = True
        Me.lblDoorbells.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorbells.Location = New System.Drawing.Point(136, 6)
        Me.lblDoorbells.Name = "lblDoorbells"
        Me.lblDoorbells.Size = New System.Drawing.Size(9, 9)
        Me.lblDoorbells.TabIndex = 24
        Me.lblDoorbells.Text = "0"
        '
        'lblPhoneCalls
        '
        Me.lblPhoneCalls.AutoSize = True
        Me.lblPhoneCalls.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneCalls.Location = New System.Drawing.Point(136, 20)
        Me.lblPhoneCalls.Name = "lblPhoneCalls"
        Me.lblPhoneCalls.Size = New System.Drawing.Size(9, 9)
        Me.lblPhoneCalls.TabIndex = 25
        Me.lblPhoneCalls.Text = "0"
        '
        'lblDoorOpenWarnings
        '
        Me.lblDoorOpenWarnings.AutoSize = True
        Me.lblDoorOpenWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorOpenWarnings.Location = New System.Drawing.Point(136, 33)
        Me.lblDoorOpenWarnings.Name = "lblDoorOpenWarnings"
        Me.lblDoorOpenWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblDoorOpenWarnings.TabIndex = 26
        Me.lblDoorOpenWarnings.Text = "0"
        '
        'lblBrineTankWarnings
        '
        Me.lblBrineTankWarnings.AutoSize = True
        Me.lblBrineTankWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrineTankWarnings.Location = New System.Drawing.Point(136, 47)
        Me.lblBrineTankWarnings.Name = "lblBrineTankWarnings"
        Me.lblBrineTankWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblBrineTankWarnings.TabIndex = 27
        Me.lblBrineTankWarnings.Text = "0"
        '
        'lblLizardNotFedWarnings
        '
        Me.lblLizardNotFedWarnings.AutoSize = True
        Me.lblLizardNotFedWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLizardNotFedWarnings.Location = New System.Drawing.Point(136, 60)
        Me.lblLizardNotFedWarnings.Name = "lblLizardNotFedWarnings"
        Me.lblLizardNotFedWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblLizardNotFedWarnings.TabIndex = 28
        Me.lblLizardNotFedWarnings.Text = "0"
        '
        'lblLizardTempWarnings
        '
        Me.lblLizardTempWarnings.AutoSize = True
        Me.lblLizardTempWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLizardTempWarnings.Location = New System.Drawing.Point(136, 73)
        Me.lblLizardTempWarnings.Name = "lblLizardTempWarnings"
        Me.lblLizardTempWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblLizardTempWarnings.TabIndex = 29
        Me.lblLizardTempWarnings.Text = "0"
        '
        'lblSevereWeatherWarnings
        '
        Me.lblSevereWeatherWarnings.AutoSize = True
        Me.lblSevereWeatherWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSevereWeatherWarnings.Location = New System.Drawing.Point(330, 73)
        Me.lblSevereWeatherWarnings.Name = "lblSevereWeatherWarnings"
        Me.lblSevereWeatherWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblSevereWeatherWarnings.TabIndex = 30
        Me.lblSevereWeatherWarnings.Text = "0"
        '
        'lblHouseHighTempWarnings
        '
        Me.lblHouseHighTempWarnings.AutoSize = True
        Me.lblHouseHighTempWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseHighTempWarnings.Location = New System.Drawing.Point(330, 6)
        Me.lblHouseHighTempWarnings.Name = "lblHouseHighTempWarnings"
        Me.lblHouseHighTempWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblHouseHighTempWarnings.TabIndex = 31
        Me.lblHouseHighTempWarnings.Text = "0"
        '
        'lblHouseLowTempWarnings
        '
        Me.lblHouseLowTempWarnings.AutoSize = True
        Me.lblHouseLowTempWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseLowTempWarnings.Location = New System.Drawing.Point(330, 20)
        Me.lblHouseLowTempWarnings.Name = "lblHouseLowTempWarnings"
        Me.lblHouseLowTempWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblHouseLowTempWarnings.TabIndex = 32
        Me.lblHouseLowTempWarnings.Text = "0"
        '
        'lblServerRoomHighTempWarnings
        '
        Me.lblServerRoomHighTempWarnings.AutoSize = True
        Me.lblServerRoomHighTempWarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerRoomHighTempWarnings.Location = New System.Drawing.Point(330, 33)
        Me.lblServerRoomHighTempWarnings.Name = "lblServerRoomHighTempWarnings"
        Me.lblServerRoomHighTempWarnings.Size = New System.Drawing.Size(9, 9)
        Me.lblServerRoomHighTempWarnings.TabIndex = 33
        Me.lblServerRoomHighTempWarnings.Text = "0"
        '
        'lblInternetReconnects
        '
        Me.lblInternetReconnects.AutoSize = True
        Me.lblInternetReconnects.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetReconnects.Location = New System.Drawing.Point(330, 47)
        Me.lblInternetReconnects.Name = "lblInternetReconnects"
        Me.lblInternetReconnects.Size = New System.Drawing.Size(9, 9)
        Me.lblInternetReconnects.TabIndex = 34
        Me.lblInternetReconnects.Text = "0"
        '
        'lblTextMessagesSent
        '
        Me.lblTextMessagesSent.AutoSize = True
        Me.lblTextMessagesSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextMessagesSent.Location = New System.Drawing.Point(330, 60)
        Me.lblTextMessagesSent.Name = "lblTextMessagesSent"
        Me.lblTextMessagesSent.Size = New System.Drawing.Size(9, 9)
        Me.lblTextMessagesSent.TabIndex = 35
        Me.lblTextMessagesSent.Text = "0"
        '
        'lblErrors
        '
        Me.lblErrors.AutoSize = True
        Me.lblErrors.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrors.Location = New System.Drawing.Point(605, 87)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(9, 9)
        Me.lblErrors.TabIndex = 36
        Me.lblErrors.Text = "0"
        '
        'lblStairLightsOn
        '
        Me.lblStairLightsOn.AutoSize = True
        Me.lblStairLightsOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStairLightsOn.Location = New System.Drawing.Point(452, 6)
        Me.lblStairLightsOn.Name = "lblStairLightsOn"
        Me.lblStairLightsOn.Size = New System.Drawing.Size(37, 9)
        Me.lblStairLightsOn.TabIndex = 37
        Me.lblStairLightsOn.Text = "12:00 AM"
        '
        'lblStairLightsOff
        '
        Me.lblStairLightsOff.AutoSize = True
        Me.lblStairLightsOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStairLightsOff.Location = New System.Drawing.Point(452, 20)
        Me.lblStairLightsOff.Name = "lblStairLightsOff"
        Me.lblStairLightsOff.Size = New System.Drawing.Size(37, 9)
        Me.lblStairLightsOff.TabIndex = 38
        Me.lblStairLightsOff.Text = "12:00 AM"
        '
        'lblMailDelivered
        '
        Me.lblMailDelivered.AutoSize = True
        Me.lblMailDelivered.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailDelivered.Location = New System.Drawing.Point(452, 33)
        Me.lblMailDelivered.Name = "lblMailDelivered"
        Me.lblMailDelivered.Size = New System.Drawing.Size(37, 9)
        Me.lblMailDelivered.TabIndex = 39
        Me.lblMailDelivered.Text = "12:00 AM"
        '
        'lblMailRetrieved
        '
        Me.lblMailRetrieved.AutoSize = True
        Me.lblMailRetrieved.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailRetrieved.Location = New System.Drawing.Point(452, 47)
        Me.lblMailRetrieved.Name = "lblMailRetrieved"
        Me.lblMailRetrieved.Size = New System.Drawing.Size(37, 9)
        Me.lblMailRetrieved.TabIndex = 40
        Me.lblMailRetrieved.Text = "12:00 AM"
        '
        'lblLastRefresh
        '
        Me.lblLastRefresh.AutoSize = True
        Me.lblLastRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastRefresh.Location = New System.Drawing.Point(463, 153)
        Me.lblLastRefresh.Name = "lblLastRefresh"
        Me.lblLastRefresh.Size = New System.Drawing.Size(85, 9)
        Me.lblLastRefresh.TabIndex = 43
        Me.lblLastRefresh.Text = "01/01/2001 12:00:00 AM"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(391, 153)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 9)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Last Refresh:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3600000
        '
        'Temp_Daily_AggregateDataGridView
        '
        Me.Temp_Daily_AggregateDataGridView.AutoGenerateColumns = False
        Me.Temp_Daily_AggregateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Temp_Daily_AggregateDataGridView.DataSource = Me.Temp_Daily_AggregateBindingSource
        Me.Temp_Daily_AggregateDataGridView.Location = New System.Drawing.Point(569, 164)
        Me.Temp_Daily_AggregateDataGridView.Name = "Temp_Daily_AggregateDataGridView"
        Me.Temp_Daily_AggregateDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Temp_Daily_AggregateDataGridView.TabIndex = 43
        Me.Temp_Daily_AggregateDataGridView.Visible = False
        '
        'Temp_Daily_AggregateBindingSource
        '
        Me.Temp_Daily_AggregateBindingSource.DataSource = Me.WatchdogDataSet
        Me.Temp_Daily_AggregateBindingSource.Position = 0
        '
        'lblMaxInsideTemp
        '
        Me.lblMaxInsideTemp.AutoSize = True
        Me.lblMaxInsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxInsideTemp.Location = New System.Drawing.Point(605, 60)
        Me.lblMaxInsideTemp.Name = "lblMaxInsideTemp"
        Me.lblMaxInsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblMaxInsideTemp.TabIndex = 55
        Me.lblMaxInsideTemp.Text = "99 F"
        '
        'lblMinOutsideTemp
        '
        Me.lblMinOutsideTemp.AutoSize = True
        Me.lblMinOutsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinOutsideTemp.Location = New System.Drawing.Point(605, 47)
        Me.lblMinOutsideTemp.Name = "lblMinOutsideTemp"
        Me.lblMinOutsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblMinOutsideTemp.TabIndex = 54
        Me.lblMinOutsideTemp.Text = "99 F"
        '
        'lblMinInsideTemp
        '
        Me.lblMinInsideTemp.AutoSize = True
        Me.lblMinInsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinInsideTemp.Location = New System.Drawing.Point(605, 33)
        Me.lblMinInsideTemp.Name = "lblMinInsideTemp"
        Me.lblMinInsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblMinInsideTemp.TabIndex = 53
        Me.lblMinInsideTemp.Text = "99 F"
        '
        'lblAvgOutsideTemp
        '
        Me.lblAvgOutsideTemp.AutoSize = True
        Me.lblAvgOutsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgOutsideTemp.Location = New System.Drawing.Point(605, 20)
        Me.lblAvgOutsideTemp.Name = "lblAvgOutsideTemp"
        Me.lblAvgOutsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblAvgOutsideTemp.TabIndex = 52
        Me.lblAvgOutsideTemp.Text = "99 F"
        '
        'lblAvgInsideTemp
        '
        Me.lblAvgInsideTemp.AutoSize = True
        Me.lblAvgInsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgInsideTemp.Location = New System.Drawing.Point(605, 6)
        Me.lblAvgInsideTemp.Name = "lblAvgInsideTemp"
        Me.lblAvgInsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblAvgInsideTemp.TabIndex = 51
        Me.lblAvgInsideTemp.Text = "99 F"
        '
        'lblMaxOutsideTemp
        '
        Me.lblMaxOutsideTemp.AutoSize = True
        Me.lblMaxOutsideTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxOutsideTemp.Location = New System.Drawing.Point(605, 73)
        Me.lblMaxOutsideTemp.Name = "lblMaxOutsideTemp"
        Me.lblMaxOutsideTemp.Size = New System.Drawing.Size(20, 9)
        Me.lblMaxOutsideTemp.TabIndex = 50
        Me.lblMaxOutsideTemp.Text = "99 F"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(504, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 9)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Max Inside Temp:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(504, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 9)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Min Outside Temp:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(504, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 9)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Min Inside Temp:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(504, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(87, 9)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Avg Outside Temp:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(504, 6)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 9)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "Avg Inside Temp:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(504, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 9)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "Max Outside Temp:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cbDaysAgo)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 39)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show History"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(47, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 9)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "days ago"
        '
        'cbDaysAgo
        '
        Me.cbDaysAgo.FormattingEnabled = True
        Me.cbDaysAgo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cbDaysAgo.Location = New System.Drawing.Point(12, 16)
        Me.cbDaysAgo.Name = "cbDaysAgo"
        Me.cbDaysAgo.Size = New System.Drawing.Size(31, 17)
        Me.cbDaysAgo.TabIndex = 43
        Me.cbDaysAgo.Text = "1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(94, 14)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 42
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(363, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 9)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Time Occupied:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(363, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 9)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Time Unoccupied:"
        '
        'lblTimeOccupied
        '
        Me.lblTimeOccupied.AutoSize = True
        Me.lblTimeOccupied.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOccupied.Location = New System.Drawing.Point(453, 60)
        Me.lblTimeOccupied.Name = "lblTimeOccupied"
        Me.lblTimeOccupied.Size = New System.Drawing.Size(23, 9)
        Me.lblTimeOccupied.TabIndex = 59
        Me.lblTimeOccupied.Text = "00.00"
        Me.lblTimeOccupied.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimeUnoccupied
        '
        Me.lblTimeUnoccupied.AutoSize = True
        Me.lblTimeUnoccupied.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeUnoccupied.Location = New System.Drawing.Point(453, 73)
        Me.lblTimeUnoccupied.Name = "lblTimeUnoccupied"
        Me.lblTimeUnoccupied.Size = New System.Drawing.Size(23, 9)
        Me.lblTimeUnoccupied.TabIndex = 60
        Me.lblTimeUnoccupied.Text = "00.00"
        Me.lblTimeUnoccupied.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Event_Daily_AggregateDataGridView
        '
        Me.Event_Daily_AggregateDataGridView.AutoGenerateColumns = False
        Me.Event_Daily_AggregateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_Daily_AggregateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.Event_Daily_AggregateDataGridView.DataSource = Me.Event_Daily_AggregateBindingSource
        Me.Event_Daily_AggregateDataGridView.Location = New System.Drawing.Point(571, 142)
        Me.Event_Daily_AggregateDataGridView.Name = "Event_Daily_AggregateDataGridView"
        Me.Event_Daily_AggregateDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_Daily_AggregateDataGridView.TabIndex = 60
        Me.Event_Daily_AggregateDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Summary_date"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Summary_date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doorbells"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doorbells"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone_call"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone_call"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Door_open_warning"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Door_open_warning"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Brine_tank_warning"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Brine_tank_warning"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Lizard_not_fed_warning"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lizard_not_fed_warning"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Lizard_temp_warning"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lizard_temp_warning"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Severe_weather_warning"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Severe_weather_warning"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "House_high_temp_warning"
        Me.DataGridViewTextBoxColumn9.HeaderText = "House_high_temp_warning"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "House_low_temp_warning"
        Me.DataGridViewTextBoxColumn10.HeaderText = "House_low_temp_warning"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Server_room_high_temp_warning"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Server_room_high_temp_warning"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Internet_reconnected"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Internet_reconnected"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Text_messages_sent"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Text_messages_sent"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Stair_lights_on"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stair_lights_on"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Stair_lights_off"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Stair_lights_off"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Mail_delivered"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Mail_delivered"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Mail_retrieved"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Mail_retrieved"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "House_occupied"
        Me.DataGridViewTextBoxColumn18.HeaderText = "House_occupied"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "House_unoccupied"
        Me.DataGridViewTextBoxColumn21.HeaderText = "House_unoccupied"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Errors"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Errors"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Event_Daily_AggregateBindingSource
        '
        Me.Event_Daily_AggregateBindingSource.DataMember = "Event_Daily_Aggregate"
        Me.Event_Daily_AggregateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'lblSARAHInteractions
        '
        Me.lblSARAHInteractions.AutoSize = True
        Me.lblSARAHInteractions.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSARAHInteractions.Location = New System.Drawing.Point(136, 87)
        Me.lblSARAHInteractions.Name = "lblSARAHInteractions"
        Me.lblSARAHInteractions.Size = New System.Drawing.Size(9, 9)
        Me.lblSARAHInteractions.TabIndex = 62
        Me.lblSARAHInteractions.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 87)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 9)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "SARAH Interactions:"
        '
        'Irrigation_HistoryDataGridView
        '
        Me.Irrigation_HistoryDataGridView.AutoGenerateColumns = False
        Me.Irrigation_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Irrigation_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Irrigation_HistoryDataGridView.DataSource = Me.Irrigation_HistoryBindingSource
        Me.Irrigation_HistoryDataGridView.Location = New System.Drawing.Point(587, 142)
        Me.Irrigation_HistoryDataGridView.Name = "Irrigation_HistoryDataGridView"
        Me.Irrigation_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Irrigation_HistoryDataGridView.TabIndex = 62
        Me.Irrigation_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Irrigation_HistoryBindingSource
        '
        Me.Irrigation_HistoryBindingSource.DataMember = "Irrigation_History"
        Me.Irrigation_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(363, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 9)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Irrigation Start:"
        '
        'lblIrrigationStart
        '
        Me.lblIrrigationStart.AutoSize = True
        Me.lblIrrigationStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrrigationStart.Location = New System.Drawing.Point(452, 115)
        Me.lblIrrigationStart.Name = "lblIrrigationStart"
        Me.lblIrrigationStart.Size = New System.Drawing.Size(37, 9)
        Me.lblIrrigationStart.TabIndex = 64
        Me.lblIrrigationStart.Text = "12:00 AM"
        '
        'lblIrrigationStop
        '
        Me.lblIrrigationStop.AutoSize = True
        Me.lblIrrigationStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrrigationStop.Location = New System.Drawing.Point(452, 101)
        Me.lblIrrigationStop.Name = "lblIrrigationStop"
        Me.lblIrrigationStop.Size = New System.Drawing.Size(37, 9)
        Me.lblIrrigationStop.TabIndex = 66
        Me.lblIrrigationStop.Text = "12:00 AM"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(363, 101)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 9)
        Me.Label32.TabIndex = 65
        Me.Label32.Text = "Irrigation Stop:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(166, 87)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 9)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Irrigation Status:"
        '
        'lblIrrigationStatus
        '
        Me.lblIrrigationStatus.AutoSize = True
        Me.lblIrrigationStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrrigationStatus.Location = New System.Drawing.Point(330, 87)
        Me.lblIrrigationStatus.Name = "lblIrrigationStatus"
        Me.lblIrrigationStatus.Size = New System.Drawing.Size(9, 9)
        Me.lblIrrigationStatus.TabIndex = 68
        Me.lblIrrigationStatus.Text = "0"
        '
        'lblLizardFed
        '
        Me.lblLizardFed.AutoSize = True
        Me.lblLizardFed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLizardFed.Location = New System.Drawing.Point(452, 87)
        Me.lblLizardFed.Name = "lblLizardFed"
        Me.lblLizardFed.Size = New System.Drawing.Size(37, 9)
        Me.lblLizardFed.TabIndex = 70
        Me.lblLizardFed.Text = "12:00 AM"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(363, 87)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 9)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "Lizard Fed:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Event_Daily_AggregateTableAdapter = Nothing
        Me.TableAdapterManager.Event_HistoryTableAdapter = Me.Event_HistoryTableAdapter
        Me.TableAdapterManager.Irrigation_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.Temp_Daily_AggregateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WDSummaryReport2.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Water_Usage_HistoryTableAdapter = Nothing
        '
        'Event_HistoryTableAdapter
        '
        Me.Event_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Temp_Daily_AggregateTableAdapter
        '
        Me.Temp_Daily_AggregateTableAdapter.ClearBeforeFill = True
        '
        'Event_Daily_AggregateTableAdapter
        '
        Me.Event_Daily_AggregateTableAdapter.ClearBeforeFill = True
        '
        'Irrigation_HistoryTableAdapter
        '
        Me.Irrigation_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(166, 101)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 9)
        Me.Label33.TabIndex = 71
        Me.Label33.Text = "Power Used:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(166, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 9)
        Me.Label35.TabIndex = 72
        Me.Label35.Text = "Power Cost:"
        '
        'lblPowerUsed
        '
        Me.lblPowerUsed.AutoSize = True
        Me.lblPowerUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerUsed.Location = New System.Drawing.Point(310, 101)
        Me.lblPowerUsed.Name = "lblPowerUsed"
        Me.lblPowerUsed.Size = New System.Drawing.Size(29, 9)
        Me.lblPowerUsed.TabIndex = 73
        Me.lblPowerUsed.Text = "99.9 W"
        Me.lblPowerUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPowerCost
        '
        Me.lblPowerCost.AutoSize = True
        Me.lblPowerCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerCost.Location = New System.Drawing.Point(312, 114)
        Me.lblPowerCost.Name = "lblPowerCost"
        Me.lblPowerCost.Size = New System.Drawing.Size(27, 9)
        Me.lblPowerCost.TabIndex = 74
        Me.lblPowerCost.Text = "$99.99"
        Me.lblPowerCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Water_Usage_HistoryBindingSource
        '
        Me.Water_Usage_HistoryBindingSource.DataMember = "Water_Usage_History"
        Me.Water_Usage_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Water_Usage_HistoryTableAdapter
        '
        Me.Water_Usage_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Water_Usage_HistoryDataGridView
        '
        Me.Water_Usage_HistoryDataGridView.AutoGenerateColumns = False
        Me.Water_Usage_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Water_Usage_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.Water_Usage_HistoryDataGridView.DataSource = Me.Water_Usage_HistoryBindingSource
        Me.Water_Usage_HistoryDataGridView.Location = New System.Drawing.Point(603, 142)
        Me.Water_Usage_HistoryDataGridView.Name = "Water_Usage_HistoryDataGridView"
        Me.Water_Usage_HistoryDataGridView.Size = New System.Drawing.Size(10, 11)
        Me.Water_Usage_HistoryDataGridView.TabIndex = 75
        Me.Water_Usage_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Gallons_Used"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Gallons_Used"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 101)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 9)
        Me.Label36.TabIndex = 76
        Me.Label36.Text = "Gallons Used:"
        '
        'lblGallonsUsed
        '
        Me.lblGallonsUsed.AutoSize = True
        Me.lblGallonsUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonsUsed.Location = New System.Drawing.Point(136, 101)
        Me.lblGallonsUsed.Name = "lblGallonsUsed"
        Me.lblGallonsUsed.Size = New System.Drawing.Size(9, 9)
        Me.lblGallonsUsed.TabIndex = 77
        Me.lblGallonsUsed.Text = "0"
        '
        'lblLeakDetected
        '
        Me.lblLeakDetected.AutoSize = True
        Me.lblLeakDetected.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeakDetected.Location = New System.Drawing.Point(136, 113)
        Me.lblLeakDetected.Name = "lblLeakDetected"
        Me.lblLeakDetected.Size = New System.Drawing.Size(9, 9)
        Me.lblLeakDetected.TabIndex = 79
        Me.lblLeakDetected.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 113)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(69, 9)
        Me.Label38.TabIndex = 78
        Me.Label38.Text = "Leak Detected:"
        '
        'lblRoombaDock
        '
        Me.lblRoombaDock.AutoSize = True
        Me.lblRoombaDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoombaDock.Location = New System.Drawing.Point(302, 127)
        Me.lblRoombaDock.Name = "lblRoombaDock"
        Me.lblRoombaDock.Size = New System.Drawing.Size(37, 9)
        Me.lblRoombaDock.TabIndex = 83
        Me.lblRoombaDock.Text = "12:00 AM"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(166, 127)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(68, 9)
        Me.Label39.TabIndex = 82
        Me.Label39.Text = "Roomba Dock:"
        '
        'lblRoombaStart
        '
        Me.lblRoombaStart.AutoSize = True
        Me.lblRoombaStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoombaStart.Location = New System.Drawing.Point(108, 127)
        Me.lblRoombaStart.Name = "lblRoombaStart"
        Me.lblRoombaStart.Size = New System.Drawing.Size(37, 9)
        Me.lblRoombaStart.TabIndex = 81
        Me.lblRoombaStart.Text = "12:00 AM"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(12, 127)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(67, 9)
        Me.Label41.TabIndex = 80
        Me.Label41.Text = "Roomba Start:"
        '
        'btnErrors
        '
        Me.btnErrors.Location = New System.Drawing.Point(506, 101)
        Me.btnErrors.Name = "btnErrors"
        Me.btnErrors.Size = New System.Drawing.Size(119, 23)
        Me.btnErrors.TabIndex = 84
        Me.btnErrors.Text = "Errors"
        Me.btnErrors.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(363, 127)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(84, 9)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Irrigation Gallons:"
        '
        'lblIrrigationGallons
        '
        Me.lblIrrigationGallons.AutoSize = True
        Me.lblIrrigationGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrrigationGallons.Location = New System.Drawing.Point(467, 127)
        Me.lblIrrigationGallons.Name = "lblIrrigationGallons"
        Me.lblIrrigationGallons.Size = New System.Drawing.Size(9, 9)
        Me.lblIrrigationGallons.TabIndex = 86
        Me.lblIrrigationGallons.Text = "0"
        '
        'frmSummaryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 186)
        Me.Controls.Add(Me.lblIrrigationGallons)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.btnErrors)
        Me.Controls.Add(Me.lblRoombaDock)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lblRoombaStart)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.lblLeakDetected)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.lblGallonsUsed)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Water_Usage_HistoryDataGridView)
        Me.Controls.Add(Me.lblPowerCost)
        Me.Controls.Add(Me.lblPowerUsed)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblLizardFed)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lblIrrigationStatus)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblIrrigationStop)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lblIrrigationStart)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Irrigation_HistoryDataGridView)
        Me.Controls.Add(Me.lblSARAHInteractions)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Event_Daily_AggregateDataGridView)
        Me.Controls.Add(Me.lblTimeUnoccupied)
        Me.Controls.Add(Me.lblTimeOccupied)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMaxInsideTemp)
        Me.Controls.Add(Me.lblMinOutsideTemp)
        Me.Controls.Add(Me.lblMinInsideTemp)
        Me.Controls.Add(Me.lblAvgOutsideTemp)
        Me.Controls.Add(Me.lblAvgInsideTemp)
        Me.Controls.Add(Me.lblMaxOutsideTemp)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Temp_Daily_AggregateDataGridView)
        Me.Controls.Add(Me.lblLastRefresh)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblMailRetrieved)
        Me.Controls.Add(Me.lblMailDelivered)
        Me.Controls.Add(Me.lblStairLightsOff)
        Me.Controls.Add(Me.lblStairLightsOn)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.lblTextMessagesSent)
        Me.Controls.Add(Me.lblInternetReconnects)
        Me.Controls.Add(Me.lblServerRoomHighTempWarnings)
        Me.Controls.Add(Me.lblHouseLowTempWarnings)
        Me.Controls.Add(Me.lblHouseHighTempWarnings)
        Me.Controls.Add(Me.lblSevereWeatherWarnings)
        Me.Controls.Add(Me.lblLizardTempWarnings)
        Me.Controls.Add(Me.lblLizardNotFedWarnings)
        Me.Controls.Add(Me.lblBrineTankWarnings)
        Me.Controls.Add(Me.lblDoorOpenWarnings)
        Me.Controls.Add(Me.lblPhoneCalls)
        Me.Controls.Add(Me.lblDoorbells)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLastReportSent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Event_HistoryDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSummaryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Report"
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_Daily_AggregateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_Daily_AggregateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Event_Daily_AggregateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Daily_AggregateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Irrigation_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Irrigation_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Water_Usage_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Water_Usage_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WatchdogDataSet As WatchdogDataSet
    Friend WithEvents TableAdapterManager As WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_HistoryTableAdapter As WDSummaryReport2.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Friend WithEvents Event_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastReportSent As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblDoorbells As System.Windows.Forms.Label
    Friend WithEvents lblPhoneCalls As System.Windows.Forms.Label
    Friend WithEvents lblDoorOpenWarnings As System.Windows.Forms.Label
    Friend WithEvents lblBrineTankWarnings As System.Windows.Forms.Label
    Friend WithEvents lblLizardNotFedWarnings As System.Windows.Forms.Label
    Friend WithEvents lblLizardTempWarnings As System.Windows.Forms.Label
    Friend WithEvents lblSevereWeatherWarnings As System.Windows.Forms.Label
    Friend WithEvents lblHouseHighTempWarnings As System.Windows.Forms.Label
    Friend WithEvents lblHouseLowTempWarnings As System.Windows.Forms.Label
    Friend WithEvents lblServerRoomHighTempWarnings As System.Windows.Forms.Label
    Friend WithEvents lblInternetReconnects As System.Windows.Forms.Label
    Friend WithEvents lblTextMessagesSent As System.Windows.Forms.Label
    Friend WithEvents lblErrors As System.Windows.Forms.Label
    Friend WithEvents lblStairLightsOn As System.Windows.Forms.Label
    Friend WithEvents lblStairLightsOff As System.Windows.Forms.Label
    Friend WithEvents lblMailDelivered As System.Windows.Forms.Label
    Friend WithEvents lblMailRetrieved As System.Windows.Forms.Label
    Friend WithEvents lblLastRefresh As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Temp_Daily_AggregateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_Daily_AggregateTableAdapter As WatchdogDataSetTableAdapters.Temp_Daily_AggregateTableAdapter
    Friend WithEvents Temp_Daily_AggregateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lblMaxInsideTemp As System.Windows.Forms.Label
    Friend WithEvents lblMinOutsideTemp As System.Windows.Forms.Label
    Friend WithEvents lblMinInsideTemp As System.Windows.Forms.Label
    Friend WithEvents lblAvgOutsideTemp As System.Windows.Forms.Label
    Friend WithEvents lblAvgInsideTemp As System.Windows.Forms.Label
    Friend WithEvents lblMaxOutsideTemp As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbDaysAgo As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOccupied As System.Windows.Forms.Label
    Friend WithEvents lblTimeUnoccupied As System.Windows.Forms.Label
    Friend WithEvents Event_Daily_AggregateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Daily_AggregateTableAdapter As WatchdogDataSetTableAdapters.Event_Daily_AggregateTableAdapter
    Friend WithEvents Event_Daily_AggregateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSARAHInteractions As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Irrigation_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Irrigation_HistoryTableAdapter As WatchdogDataSetTableAdapters.Irrigation_HistoryTableAdapter
    Friend WithEvents Irrigation_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblIrrigationStart As System.Windows.Forms.Label
    Friend WithEvents lblIrrigationStop As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblIrrigationStatus As System.Windows.Forms.Label
    Friend WithEvents lblLizardFed As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblPowerUsed As System.Windows.Forms.Label
    Friend WithEvents lblPowerCost As System.Windows.Forms.Label
    Friend WithEvents Water_Usage_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Water_Usage_HistoryTableAdapter As WatchdogDataSetTableAdapters.Water_Usage_HistoryTableAdapter
    Friend WithEvents Water_Usage_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblGallonsUsed As System.Windows.Forms.Label
    Friend WithEvents lblLeakDetected As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblRoombaDock As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblRoombaStart As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnErrors As System.Windows.Forms.Button
    Friend WithEvents Label37 As Label
    Friend WithEvents lblIrrigationGallons As Label
End Class
