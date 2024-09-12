Public Class frmSummaryReport

    Private Sub frmSummaryReport_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Event_HistoryTableAdapter.InsertQuery("9024")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Event_HistoryTableAdapter.InsertQuery("9023")
        RefreshScreen(Now.AddDays(-1))
        lblLastReportSent.Text = ""

        ''''''
        'InsertStatusRow(Now.AddDays(-1))
        'SendDailyUpdate(Now.AddDays(-1))
        'Timer1.Interval = 1000
        ''''''
        Timer1.Start()

    End Sub

    Private Sub RefreshScreen(ByVal dtReportDate As Date)
        Dim strDate As String
        Dim dtTempTime As Date
        Dim iRow, iTempHour As Integer
        Dim bAM As Boolean
        Dim dTimeOccupied, dTimeUnoccupied As Double
        Dim iNewHour, iNewMinute, iLastHour, iLastMinute, iTotalHour, iTotalMinute, i As Integer
        Dim tabGallonsUsed As WatchdogDataSet.Water_Usage_HistoryDataTable
        Dim strIrrigationStatus As String

        strDate = dtReportDate.Date

        Me.Text = "Summary Report for " & strDate

        lblDoorbells.Text = Event_HistoryTableAdapter.Get_Doorbells(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblPhoneCalls.Text = Event_HistoryTableAdapter.Get_TelephoneCalls(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblDoorOpenWarnings.Text = Event_HistoryTableAdapter.Get_DoorOpenWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblBrineTankWarnings.Text = Event_HistoryTableAdapter.Get_BrineTankWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblLizardNotFedWarnings.Text = Event_HistoryTableAdapter.Get_LizardNotFedWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblLizardTempWarnings.Text = Event_HistoryTableAdapter.Get_LizardTempWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblHouseHighTempWarnings.Text = Event_HistoryTableAdapter.Get_HouseTempHighWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblHouseLowTempWarnings.Text = Event_HistoryTableAdapter.Get_HouseTempLowWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblServerRoomHighTempWarnings.Text = Event_HistoryTableAdapter.Get_ServerRmTempHighWarning(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblInternetReconnects.Text = Event_HistoryTableAdapter.Get_InternetReconnects(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblTextMessagesSent.Text = Event_HistoryTableAdapter.Get_TextMessagesSent(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblSevereWeatherWarnings.Text = Event_HistoryTableAdapter.Get_SevereWeatherWarnings(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblSARAHInteractions.Text = Event_HistoryTableAdapter.Get_SARAHInteractions(strDate & " 12:00am", strDate & " 11:59pm").ToString
        lblLeakDetected.Text = Event_HistoryTableAdapter.Get_LeakDetected(strDate & " 12:00am", strDate & " 11:59pm").ToString

        'Errors List
        lblErrors.Text = Event_HistoryTableAdapter.Get_Errors(strDate & " 12:00am", strDate & " 11:59pm").ToString
        If CInt(lblErrors.Text) > 0 Then
            btnErrors.Enabled = True
            frmErrors.Errors_ListTableAdapter.FillBy_Errors(frmErrors.WatchdogDataSet.Errors_List, strDate & " 12:00am", strDate & " 11:59pm")
        Else
            btnErrors.Enabled = False
        End If

        'Get Gallons Used
        Try
            tabGallonsUsed = New WatchdogDataSet.Water_Usage_HistoryDataTable
            tabGallonsUsed = Water_Usage_HistoryTableAdapter.GetDataBy_WaterUsage(strDate & " 12:00am", strDate & " 11:59pm")
            If tabGallonsUsed.Rows.Count = 1 Then
                lblGallonsUsed.Text = tabGallonsUsed.Rows(0).ItemArray(1).ToString
                lblIrrigationGallons.Text = tabGallonsUsed.Rows(0).ItemArray(2).ToString
                strIrrigationStatus = tabGallonsUsed.Rows(0).ItemArray(3).ToString

                If strIrrigationStatus = "900" Then
                    lblIrrigationStatus.Text = "0"
                ElseIf strIrrigationStatus = "302" Then
                    lblIrrigationStatus.Text = "W"
                ElseIf strIrrigationStatus = "318" Then
                    lblIrrigationStatus.Text = "O"
                ElseIf strIrrigationStatus = "319" Then
                    lblIrrigationStatus.Text = "S"
                Else
                    lblIrrigationStatus.Text = "X"
                End If
            Else
                lblGallonsUsed.Text = "0"
                lblIrrigationStatus.Text = "X"
            End If
        Catch ex As Exception
            lblGallonsUsed.Text = "0"
            lblIrrigationStatus.Text = "X"
        End Try

        'IrrigationStatus
        'iCancelDeactivate = Irrigation_HistoryTableAdapter.CheckCancelDeactivated(strDate & " 7:00am", dtReportDate.AddDays(1).Date & " 6:59am")
        'iCancelWeather = Irrigation_HistoryTableAdapter.CheckCancelBadWeather(strDate & " 7:00am", dtReportDate.AddDays(1).Date & " 6:59am")
        'iCancelOverride = Irrigation_HistoryTableAdapter.CheckCancelOverride(strDate & " 7:00am", dtReportDate.AddDays(1).Date & " 6:59am")
        'iCancelRainedToday = Irrigation_HistoryTableAdapter.CheckCancelWetSoil(strDate & " 7:00am", dtReportDate.AddDays(1).Date & " 6:59am")

        'If iCancelDeactivate > 0 Then
        '    lblIrrigationStatus.Text = "X"
        'ElseIf iCancelWeather > 0 Then
        '    lblIrrigationStatus.Text = "W"
        'ElseIf iCancelOverride > 0 Then
        '    lblIrrigationStatus.Text = "O"
        'ElseIf iCancelRainedToday > 0 Then
        '    lblIrrigationStatus.Text = "S"
        'Else
        '    lblIrrigationStatus.Text = "0"
        'End If

        Irrigation_HistoryTableAdapter.FillBy_IrrigationStartStop(Me.WatchdogDataSet.Irrigation_History, strDate & " 7:00am", dtReportDate.AddDays(1).Date & " 06:59am")
        If lblIrrigationStatus.Text = "0" And WatchdogDataSet.Irrigation_History.Rows.Count >= 2 Then
            For i = 0 To WatchdogDataSet.Irrigation_History.Rows.Count - 1
                If WatchdogDataSet.Irrigation_History.Rows(i).Item(0) = "299" Then
                    'Get Irrigation Stop Time
                    dtTempTime = WatchdogDataSet.Irrigation_History.Rows(i).Item(1)
                    iTempHour = DatePart(DateInterval.Hour, dtTempTime)
                    bAM = True
                    If iTempHour >= 12 Then
                        iTempHour = iTempHour - 12
                        If iTempHour = 0 Then iTempHour = 12
                        bAM = False
                    End If
                    lblIrrigationStop.Text = iTempHour.ToString & ":"
                    If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                        lblIrrigationStop.Text = lblIrrigationStop.Text & "0"
                    End If
                    lblIrrigationStop.Text = lblIrrigationStop.Text & DatePart(DateInterval.Minute, dtTempTime)

                    If bAM Then
                        lblIrrigationStop.Text = lblIrrigationStop.Text & " AM"
                    Else
                        lblIrrigationStop.Text = lblIrrigationStop.Text & " PM"
                    End If
                    lblIrrigationStatus.Text = "1"
                End If

                If WatchdogDataSet.Irrigation_History.Rows(i).Item(0) = "298" Then
                    'Get Irrigation Start Time
                    dtTempTime = WatchdogDataSet.Irrigation_History.Rows(i).Item(1)
                    iTempHour = DatePart(DateInterval.Hour, dtTempTime)
                    bAM = True
                    If iTempHour >= 12 Then
                        iTempHour = iTempHour - 12
                        If iTempHour = 0 Then iTempHour = 12
                        bAM = False
                    End If
                    lblIrrigationStart.Text = iTempHour.ToString & ":"
                    If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                        lblIrrigationStart.Text = lblIrrigationStart.Text & "0"
                    End If
                    lblIrrigationStart.Text = lblIrrigationStart.Text & DatePart(DateInterval.Minute, dtTempTime)

                    If bAM Then
                        lblIrrigationStart.Text = lblIrrigationStart.Text & " AM"
                    Else
                        lblIrrigationStart.Text = lblIrrigationStart.Text & " PM"
                    End If
                    lblIrrigationStatus.Text = "1"
                End If
            Next
        Else
            lblIrrigationStart.Text = "00:00"
            lblIrrigationStop.Text = "00:00"
        End If


        'Roomba Start
        'Event_HistoryTableAdapter.FillBy_RoombaStart(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        'If WatchdogDataSet.Event_History.Rows.Count > 0 Then
        '    dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
        '    iTempHour = DatePart(DateInterval.Hour, dtTempTime)
        '    bAM = True
        '    If iTempHour >= 12 Then
        '        iTempHour = iTempHour - 12
        '        If iTempHour = 0 Then iTempHour = 12
        '        bAM = False
        '    End If
        '    lblRoombaStart.Text = iTempHour.ToString & ":"
        '    If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
        '        lblRoombaStart.Text = lblRoombaStart.Text & "0"
        '    End If
        '    lblRoombaStart.Text = lblRoombaStart.Text & DatePart(DateInterval.Minute, dtTempTime)

        '    If bAM Then
        '        lblRoombaStart.Text = lblRoombaStart.Text & " AM"
        '    Else
        '        lblRoombaStart.Text = lblRoombaStart.Text & " PM"
        '    End If
        'Else
        lblRoombaStart.Text = ""
        'End If

        'Roomba Dock
        'Event_HistoryTableAdapter.FillBy_RoombaDock(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        'If WatchdogDataSet.Event_History.Rows.Count > 0 Then
        '    dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
        '    iTempHour = DatePart(DateInterval.Hour, dtTempTime)
        '    bAM = True
        '    If iTempHour >= 12 Then
        '        iTempHour = iTempHour - 12
        '        If iTempHour = 0 Then iTempHour = 12
        '        bAM = False
        '    End If
        '    lblRoombaDock.Text = iTempHour.ToString & ":"
        '    If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
        '        lblRoombaDock.Text = lblRoombaDock.Text & "0"
        '    End If
        '    lblRoombaDock.Text = lblRoombaDock.Text & DatePart(DateInterval.Minute, dtTempTime)

        '    If bAM Then
        '        lblRoombaDock.Text = lblRoombaDock.Text & " AM"
        '    Else
        '        lblRoombaDock.Text = lblRoombaDock.Text & " PM"
        '    End If
        'Else
        lblRoombaDock.Text = ""
        'End If

        'Stair Lights On
        Event_HistoryTableAdapter.FillBy_StairLightsOn(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Event_History.Rows.Count > 0 Then
            dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
            iTempHour = DatePart(DateInterval.Hour, dtTempTime)
            bAM = True
            If iTempHour >= 12 Then
                iTempHour = iTempHour - 12
                If iTempHour = 0 Then iTempHour = 12
                bAM = False
            End If
            lblStairLightsOn.Text = iTempHour.ToString & ":"
            If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                lblStairLightsOn.Text = lblStairLightsOn.Text & "0"
            End If
            lblStairLightsOn.Text = lblStairLightsOn.Text & DatePart(DateInterval.Minute, dtTempTime)

            If bAM Then
                lblStairLightsOn.Text = lblStairLightsOn.Text & " AM"
            Else
                lblStairLightsOn.Text = lblStairLightsOn.Text & " PM"
            End If
        Else
            lblStairLightsOn.Text = ""
        End If


        'Stair Lights Off
        Event_HistoryTableAdapter.FillBy_StairLightsOff(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Event_History.Rows.Count > 0 Then
            If WatchdogDataSet.Event_History.Rows.Count > 2 Then
                iRow = WatchdogDataSet.Event_History.Rows.Count - 2
            Else
                iRow = 0
            End If
            dtTempTime = WatchdogDataSet.Event_History.Rows(iRow).Item(1)
            iTempHour = DatePart(DateInterval.Hour, dtTempTime)
            bAM = True
            If iTempHour >= 12 Then
                iTempHour = iTempHour - 12
                If iTempHour = 0 Then iTempHour = 12
                bAM = False
            End If
            lblStairLightsOff.Text = iTempHour.ToString & ":"
            If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                lblStairLightsOff.Text = lblStairLightsOff.Text & "0"
            End If
            lblStairLightsOff.Text = lblStairLightsOff.Text & DatePart(DateInterval.Minute, dtTempTime)

            If bAM Then
                lblStairLightsOff.Text = lblStairLightsOff.Text & " AM"
            Else
                lblStairLightsOff.Text = lblStairLightsOff.Text & " PM"
            End If
        Else
            lblStairLightsOff.Text = ""
        End If

        'Mail Delivered
        Event_HistoryTableAdapter.FillBy_MailDelivered(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Event_History.Rows.Count > 0 Then
            dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
            iTempHour = DatePart(DateInterval.Hour, dtTempTime)
            bAM = True
            If iTempHour >= 12 Then
                iTempHour = iTempHour - 12
                If iTempHour = 0 Then iTempHour = 12
                bAM = False
            End If
            lblMailDelivered.Text = iTempHour.ToString & ":"
            If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                lblMailDelivered.Text = lblMailDelivered.Text & "0"
            End If
            lblMailDelivered.Text = lblMailDelivered.Text & DatePart(DateInterval.Minute, dtTempTime)
            If bAM Then
                lblMailDelivered.Text = lblMailDelivered.Text & " AM"
            Else
                lblMailDelivered.Text = lblMailDelivered.Text & " PM"
            End If
        Else
            lblMailDelivered.Text = ""
        End If

        'Mail Retrieved
        Event_HistoryTableAdapter.FillBy_MailRetrieved(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Event_History.Rows.Count > 0 Then
            dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
            iTempHour = DatePart(DateInterval.Hour, dtTempTime)
            bAM = True
            If iTempHour >= 12 Then
                iTempHour = iTempHour - 12
                If iTempHour = 0 Then iTempHour = 12
                bAM = False
            End If
            lblMailRetrieved.Text = iTempHour.ToString & ":"
            If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
                lblMailRetrieved.Text = lblMailRetrieved.Text & "0"
            End If
            lblMailRetrieved.Text = lblMailRetrieved.Text & DatePart(DateInterval.Minute, dtTempTime)

            If bAM Then
                lblMailRetrieved.Text = lblMailRetrieved.Text & " AM"
            Else
                lblMailRetrieved.Text = lblMailRetrieved.Text & " PM"
            End If
        Else
            lblMailRetrieved.Text = ""
        End If

        'Lizard Fed
        'Event_HistoryTableAdapter.FillBy_LizardFed(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        'If WatchdogDataSet.Event_History.Rows.Count > 0 Then
        '    dtTempTime = WatchdogDataSet.Event_History.Rows(0).Item(1)
        '    iTempHour = DatePart(DateInterval.Hour, dtTempTime)
        '    bAM = True
        '    If iTempHour >= 12 Then
        '        iTempHour = iTempHour - 12
        '        If iTempHour = 0 Then iTempHour = 12
        '        bAM = False
        '    End If
        '    lblLizardFed.Text = iTempHour.ToString & ":"
        '    If DatePart(DateInterval.Minute, dtTempTime) < 10 Then
        '        lblLizardFed.Text = lblLizardFed.Text & "0"
        '    End If
        '    lblLizardFed.Text = lblLizardFed.Text & DatePart(DateInterval.Minute, dtTempTime)

        '    If bAM Then
        '        lblLizardFed.Text = lblLizardFed.Text & " AM"
        '    Else
        '        lblLizardFed.Text = lblLizardFed.Text & " PM"
        '    End If
        'Else
        lblLizardFed.Text = ""
        'End If

        'Get Power Usage
        'Dim xmlFeed3 As HttpWebRequest
        'Dim xmlData3 As DataSet = New DataSet()
        'Dim strPowerCost = ""
        'Dim strPowerUsed = ""

        'Try
        '    xmlFeed3 = WebRequest.Create("http://192.168.1.208/history/dailyhistory.xml?MTU=0&COUNT=1&INDEX=" & cbDaysAgo.Text)
        '    xmlFeed3.Timeout = 5000
        '    xmlData3.ReadXml(xmlFeed3.GetResponse().GetResponseStream())

        '    Dim strPower As String = xmlData3.Tables(0).Rows(0).Item(2)
        '    Dim strCost As String = xmlData3.Tables(0).Rows(0).Item(3)

        '    strPowerUsed = FormatNumber(CInt(strPower) / 1000, 1, TriState.False, TriState.True, TriState.UseDefault) & " W"
        '    If strPowerUsed.IndexOf("..") <> -1 Then
        '        strPowerUsed.Remove(strPowerUsed.IndexOf(".."), 1)
        '    End If
        '    lblPowerUsed.Text = strPowerUsed

        '    strPowerCost = "$" & FormatNumber((CInt(strCost) / 100), 2, TriState.False, TriState.True, TriState.UseDefault)
        '    If strPowerCost.IndexOf("..") <> -1 Then
        '        strPowerCost.Remove(strPowerCost.IndexOf(".."), 1)
        '    End If
        '    lblPowerCost.Text = strPowerCost

        'Catch e As Exception
        lblPowerUsed.Text = "0"
        lblPowerCost.Text = "0"
        'End Try

        'Time Occupied
        Event_HistoryTableAdapter.FillBy_HouseOccupied(Me.WatchdogDataSet.Event_History, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Event_History.Rows.Count = 0 Then
            dTimeOccupied = 24.0
            dTimeUnoccupied = 0
        Else
            dTimeOccupied = 0
            dTimeUnoccupied = 0
            iLastHour = 23
            iLastMinute = 59
            iTotalHour = 0
            iTotalMinute = 0
            Try
                For i = 0 To (WatchdogDataSet.Event_History.Rows.Count - 1)
                    '5023 = occupied, 5024 = unoccupied
                    If WatchdogDataSet.Event_History.Rows(i).Item(0) = "5024" Then
                        iLastHour = DatePart(DateInterval.Hour, WatchdogDataSet.Event_History.Rows(i).Item(1))
                        iLastMinute = DatePart(DateInterval.Minute, WatchdogDataSet.Event_History.Rows(i).Item(1))
                    ElseIf WatchdogDataSet.Event_History.Rows(i).Item(0) = "5023" And WatchdogDataSet.Event_History.Rows(i + 1).Item(0) <> "5023" Then
                        iNewHour = DatePart(DateInterval.Hour, WatchdogDataSet.Event_History.Rows(i).Item(1))
                        iTotalHour = iTotalHour + (iLastHour - iNewHour)
                        iNewMinute = DatePart(DateInterval.Minute, WatchdogDataSet.Event_History.Rows(i).Item(1))
                        iTotalMinute = iTotalMinute + (iLastMinute - iNewMinute)
                    End If
                Next
            Catch ex As Exception
                'do nothing
            End Try
            'Calculate time since midnight
            iNewHour = 0
            iNewMinute = 0
            iTotalHour = iTotalHour + (iLastHour - iNewHour)
            iTotalMinute = iTotalMinute + (iLastMinute - iNewMinute)

            If iTotalMinute >= 60 Then
                iTotalHour = iTotalHour + Math.DivRem(iTotalMinute, 60, i)
                iTotalMinute = iTotalMinute - (Math.DivRem(iTotalMinute, 60, i) * 60)
            End If
            dTimeOccupied = iTotalHour + (iTotalMinute / 60)
            If dTimeOccupied >= 23.95 Then
                dTimeOccupied = 24.0
            End If
            dTimeUnoccupied = 24.0 - dTimeOccupied
        End If
        lblTimeOccupied.Text = Format(dTimeOccupied, "#0.0#")
        lblTimeUnoccupied.Text = Format(dTimeUnoccupied, "00.0#")

        'Temperature
        Temp_Daily_AggregateTableAdapter.FillBy_Temp(Me.WatchdogDataSet.Temp_Daily_Aggregate, strDate & " 12:00am", strDate & " 11:59pm")
        If WatchdogDataSet.Temp_Daily_Aggregate.Rows.Count > 0 Then
            lblAvgInsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(1).ToString & " F"
            lblAvgOutsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(2).ToString & " F"
            lblMinInsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(3).ToString & " F"
            lblMinOutsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(4).ToString & " F"
            lblMaxInsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(5).ToString & " F"
            lblMaxOutsideTemp.Text = WatchdogDataSet.Temp_Daily_Aggregate.Rows(0).Item(6).ToString & " F"
        Else
            lblAvgInsideTemp.Text = ""
            lblAvgOutsideTemp.Text = ""
            lblMinInsideTemp.Text = ""
            lblMinOutsideTemp.Text = ""
            lblMaxInsideTemp.Text = ""
            lblMaxOutsideTemp.Text = ""
        End If

        lblLastRefresh.Text = Now.ToString

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim dtNow As Date

        dtNow = Now
        If dtNow.Hour = 7 Then
            RefreshScreen(Now.AddDays(-1))
            InsertStatusRow(Now.AddDays(-1))
            SendDailyUpdate(Now.AddDays(-1))
        End If

    End Sub

    Sub SendDailyUpdate(ByVal dtNow As Date)
        Dim strMessage As String
        Dim mySMTPClient As SmtpClient = New SmtpClient
        Dim Message As MailMessage
        Dim strDate As String
        Dim dWaterCost As Double
        Dim strWaterCost As String

        strDate = FormatDateTime(dtNow, DateFormat.ShortDate)

        'Build Message
        strMessage = "Watchdog Status Report for " & strDate & Chr(10)
        strMessage = strMessage & "--------------------------------------------------" & Chr(10) & Chr(10)

        If CInt(lblDoorbells.Text) > 0 Then
            strMessage = strMessage & "Doorbells:                 " & lblDoorbells.Text & Chr(10)
        End If

        If CInt(lblPhoneCalls.Text) > 0 Then
            strMessage = strMessage & "Phone Calls:               " & lblPhoneCalls.Text & Chr(10)
        End If

        If CInt(lblDoorOpenWarnings.Text) > 0 Then
            strMessage = strMessage & "Door Open Warnings:        " & lblDoorOpenWarnings.Text & Chr(10)
        End If

        If CInt(lblBrineTankWarnings.Text) > 0 Then
            strMessage = strMessage & "Brine Tank Warning:        " & lblBrineTankWarnings.Text & Chr(10)
        End If

        If CInt(lblLizardNotFedWarnings.Text) > 0 Then
            strMessage = strMessage & "Lizard Not Fed Warnings:   " & lblLizardNotFedWarnings.Text & Chr(10)
        End If

        'If CInt(lblLizardTempWarnings.Text) > 0 Then
        '    strMessage = strMessage & "Lizard Temp Warnings:      " & lblLizardTempWarnings.Text & Chr(10)
        'End If

        If CInt(lblHouseHighTempWarnings.Text) > 0 Then
            strMessage = strMessage & "House High Temp Warnings:  " & lblHouseHighTempWarnings.Text & Chr(10)
        End If

        If CInt(lblHouseLowTempWarnings.Text) > 0 Then
            strMessage = strMessage & "House Low Temp Warnings:   " & lblHouseLowTempWarnings.Text & Chr(10)
        End If

        If CInt(lblServerRoomHighTempWarnings.Text) > 0 Then
            strMessage = strMessage & "Server Room Temp Warnings: " & lblServerRoomHighTempWarnings.Text & Chr(10)
        End If

        If CInt(lblInternetReconnects.Text) > 0 Then
            strMessage = strMessage & "Internet Reconnects:       " & lblInternetReconnects.Text & Chr(10)
        End If

        If CInt(lblTextMessagesSent.Text) > 0 Then
            strMessage = strMessage & "Text Messages Sent:        " & lblTextMessagesSent.Text & Chr(10)
        End If

        If CInt(lblSevereWeatherWarnings.Text) > 0 Then
            strMessage = strMessage & "Severe Weather Warnings:   " & lblSevereWeatherWarnings.Text & Chr(10)
        End If

        If CInt(lblSARAHInteractions.Text) > 0 Then
            strMessage = strMessage & "SARAH Interactions:        " & lblSARAHInteractions.Text & Chr(10)
        End If

        If CInt(lblLeakDetected.Text) > 0 Then
            strMessage = strMessage & "Leak Detected:             " & lblLeakDetected.Text & Chr(10)
        End If

        If CInt(lblErrors.Text) > 0 Then
            strMessage = strMessage & "Errors:                    " & lblErrors.Text & Chr(10)
        End If


        strMessage = strMessage & Chr(10)
        If lblIrrigationStatus.Text = "X" Then
            strMessage = strMessage & "Irrigation did not run in the last 24 hrs because the system was deactivated." & Chr(10)
        End If
        If lblIrrigationStatus.Text = "W" Then
            strMessage = strMessage & "Irrigation did not run in the last 24 hrs due to bad weather forecast." & Chr(10)
        End If
        If lblIrrigationStatus.Text = "O" Then
            strMessage = strMessage & "Irrigation did not run in the last 24 hrs because the system was in an override state." & Chr(10)
        End If
        If lblIrrigationStatus.Text = "S" Then
            strMessage = strMessage & "Irrigation did not run in the last 24 hrs because the ground is wet." & Chr(10)
        End If
        If lblIrrigationStatus.Text = "1" Then
            strMessage = strMessage & "Irrigation ran successfully in the last 24 hrs and used " & lblIrrigationGallons.Text & " Gallons of water." & Chr(10)
            strMessage = strMessage & "Irrigation Started:  " & lblIrrigationStart.Text & Chr(10)
            strMessage = strMessage & "Irrigation Stopped:  " & lblIrrigationStop.Text & Chr(10)
        End If
        'if Irrigation Status = 0, display nothing
        strMessage = strMessage & Chr(10)

        'If lblLizardFed.Text = "" Then
        '    strMessage = strMessage & "The lizard was not fed yesterday." & Chr(10)
        'Else
        '    strMessage = strMessage & "Lizard Fed:          " & lblLizardFed.Text & Chr(10)
        'End If
        'strMessage = strMessage & Chr(10)

        'If lblRoombaStart.Text = "" Then
        '    strMessage = strMessage & "Roomba did not run yesterday." & Chr(10)
        'Else
        '    strMessage = strMessage & "Roomba Start:        " & lblRoombaStart.Text & Chr(10)
        '    strMessage = strMessage & "Roomba Docked:       " & lblRoombaDock.Text & Chr(10)
        'End If
        'strMessage = strMessage & Chr(10)

        strMessage = strMessage & "Power Used:          " & lblPowerUsed.Text & Chr(10)
        strMessage = strMessage & "Power Cost:          " & lblPowerCost.Text & Chr(10) & Chr(10)

        strMessage = strMessage & "Water Used:          " & lblGallonsUsed.Text & " gallons" & Chr(10)
        dWaterCost = CInt(lblGallonsUsed.Text) * 0.00416
        If dWaterCost < 1.0 Then
            strWaterCost = "$0" & FormatNumber(dWaterCost, 2, TriState.False, TriState.True, TriState.UseDefault)
        Else
            strWaterCost = "$" & FormatNumber(dWaterCost, 2, TriState.False, TriState.True, TriState.UseDefault)
        End If
        If strWaterCost.IndexOf("..") <> -1 Then
            strWaterCost.Remove(strWaterCost.IndexOf(".."), 1)
        End If
        strMessage = strMessage & "Water Cost:          " & strWaterCost & Chr(10) & Chr(10)

        strMessage = strMessage & "Stair Lights Off:    " & lblStairLightsOff.Text & Chr(10)
        strMessage = strMessage & "Stair Lights On:     " & lblStairLightsOn.Text & Chr(10)
        strMessage = strMessage & "Mail Delivered:      " & lblMailDelivered.Text & Chr(10)
        strMessage = strMessage & "Mail Retrieved:      " & lblMailRetrieved.Text & Chr(10) & Chr(10)

        strMessage = strMessage & "Min Inside Temp:     " & lblMinInsideTemp.Text & Chr(10)
        strMessage = strMessage & "Avg Inside Temp:     " & lblAvgInsideTemp.Text & Chr(10)
        strMessage = strMessage & "Max Inside Temp:     " & lblMaxInsideTemp.Text & Chr(10)
        strMessage = strMessage & "Min Outside Temp:    " & lblMinOutsideTemp.Text & Chr(10)
        strMessage = strMessage & "Avg Outside Temp:    " & lblAvgOutsideTemp.Text & Chr(10)
        strMessage = strMessage & "Max Outside Temp:    " & lblMaxOutsideTemp.Text & Chr(10) & Chr(10)

        strMessage = strMessage & "House Occupied:      " & lblTimeOccupied.Text & " hrs." & Chr(10)
        strMessage = strMessage & "House Unoccupied:    " & lblTimeUnoccupied.Text & " hrs." & Chr(10)

        If CInt(lblErrors.Text) > 0 Then
            Dim dsError_List As WatchdogDataSet
            strMessage = strMessage & Chr(10) & Chr(10)
            strMessage = strMessage & "Errors: " & Chr(10)
            strMessage = strMessage & "Timestamp " & Chr(9) & Chr(9) & "Description" & Chr(10)
            dsError_List = frmErrors.WatchdogDataSet
            For i = 0 To CInt(lblErrors.Text) - 1
                strMessage = strMessage & dsError_List.Errors_List.Rows.Item(i).ItemArray(1)
                strMessage = strMessage & Chr(9)
                strMessage = strMessage & dsError_List.Errors_List.Rows.Item(i).ItemArray(0)
                strMessage = strMessage & Chr(10)
            Next i
        End If

        'Send Message
        Try
            Message = New MailMessage("Watchdog@gmail.com", "gregspata@gmail.com")
            Message.Subject = "DAILY UPDATE"
            Message.Priority = MailPriority.High
            mySMTPClient.Host = "smtp-server.cinci.rr.com"
            mySMTPClient.Port = 25
            Message.Body = strMessage
            mySMTPClient.Send(Message)

            Message = Nothing
            Message = New MailMessage("Watchdog@gmail.com", "juli.spata72@gmail.com")
            Message.Subject = "DAILY UPDATE"
            Message.Priority = MailPriority.High
            mySMTPClient.Host = "smtp-server.cinci.rr.com"
            mySMTPClient.Port = 25
            Message.Body = strMessage
            mySMTPClient.Send(Message)

            lblLastReportSent.Text = Now.ToString
            Event_HistoryTableAdapter.InsertQuery("5052")
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Sub InsertStatusRow(ByVal dtDate As Date)
        Dim strDate As String
        Dim strRoombaStart, strRoombaDock As String

        strDate = FormatDateTime(dtDate, DateFormat.ShortDate)
        If lblRoombaStart.Text = "" Then
            strRoombaStart = "00:00:00"
        Else
            strRoombaStart = lblRoombaStart.Text
        End If
        If lblRoombaDock.Text = "" Then
            strRoombaDock = "00:00:00"
        Else
            strRoombaDock = lblRoombaDock.Text
        End If
        Try
            Event_Daily_AggregateTableAdapter.InsertQuery(CDate(strDate & " 11:59:00 pm"), CInt(lblDoorbells.Text), CInt(lblPhoneCalls.Text), CInt(lblDoorOpenWarnings.Text),
                                                          CInt(lblBrineTankWarnings.Text), CInt(lblLizardNotFedWarnings.Text), CInt(lblLizardTempWarnings.Text),
                                                          CInt(lblSevereWeatherWarnings.Text), CInt(lblHouseHighTempWarnings.Text), CInt(lblHouseLowTempWarnings.Text),
                                                          CInt(lblServerRoomHighTempWarnings.Text), CInt(lblInternetReconnects.Text), CInt(lblTextMessagesSent.Text),
                                                          CDate(strDate & " " & lblStairLightsOn.Text), CDate(strDate & " " & lblStairLightsOff.Text),
                                                          CDate(strDate & " " & lblMailDelivered.Text), CDate(strDate & " " & lblMailRetrieved.Text),
                                                          CDbl(lblTimeOccupied.Text), CDbl(lblTimeUnoccupied.Text), CInt(lblErrors.Text), CInt(lblSARAHInteractions.Text),
                                                          lblIrrigationStatus.Text, CDate(strDate & " " & lblIrrigationStart.Text), CDate(strDate & " " & lblIrrigationStop.Text),
                                                          lblPowerUsed.Text, lblPowerCost.Text, CDate(strDate & " " & lblLizardFed.Text), CDate(strDate & " " & strRoombaStart),
                                                          CDate(strDate & " " & strRoombaDock), lblGallonsUsed.Text, lblLeakDetected.Text, lblIrrigationGallons.Text)
        Catch ex As Exception
            'Do nothing
        End Try
    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnStop.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshScreen(Now.AddDays(CInt(cbDaysAgo.Text) * -1))
    End Sub

    Private Sub btnErrors_Click(sender As Object, e As EventArgs) Handles btnErrors.Click
        frmErrors.ShowDialog()
    End Sub
End Class
