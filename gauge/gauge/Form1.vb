Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Ports

Public Class Form1
    Public myData As New DataSet
    Public myQuery As String
    Public oMysql As New cMySQL
    Public AESCrypter As New AESCrypter
    Public setting_file = "setting.ini"
    Public table_setting = "table.ini"

    Public file_tangki
    Public file_54

    Public rowDensityTable54 = 1
    Public colDensityStartTable54 = 1
    Public ColTempTable54 = 0
    Public rowTempStartTable54 = 3

    Public colPersenTableTangki = 1
    Public rowPersenTableTangki = 1
    Public colLiterTableTangki = 2


    Public dataTable = "measuringdata"
    'Public table_level = "tank_level"
    'Public table_pressure = "pressure"
    'Public table_temp = "temperature"
    Public isConnected As Boolean = False

    Public log_file = "Log_"
    Public log_writer As StreamWriter
    Public logdate As Integer
    '------------ server SQL -----------------------------
    Public master_user As String '= "root"
    Public master_pass As String '= "usbw"
    Public sql_address As String '= "127.0.0.1"
    Public database_name As String '= "bts_security"
    '------------ Com Port -------------------------------
    Public portComName As String
    Public baudrate As String = "9600"

    '----------- Max Value -------------------------------
    Public maxValLevel As Double
    Public maxValTemp As Double
    Public maxValPress As Double
    Public reqTimeOut As Integer
    Public reqComTimeOut As Integer
    Public ComReqRetry As Integer

    '---------- ids --------------------------------------
    Public idLevel As String
    Public idTemp As String
    Public idPress As String

    Public update_period As Integer
    Public reqDataCommand As String
    Public reqRawCommand As String

    Public connstring As String
    Public defaultdir As String

    Public bufferCom As String = ""

    Public gotLevel As Boolean
    Public dataLevel As String = ""
    Public gotLevelTime As Date

    Public gotTemp As Boolean
    Public dataTemp As String = ""
    Public gotTempTime As Date

    Public gotPress As Boolean
    Public dataPress As String = ""
    Public gotPressTime As Date

    Public reqDataCommandReply As String = "ComAccepted"
    Public OutliersDetetionFailed As String = "Err500"
    Public NoValidSensorAfterReading As String = "Err100"
    Public NoValidSensorAfterLearning As String = "Err200"
    Public MotorCannotReachTargetPosWhenLearning As String = "Err300"
    Public HomingFailure As String = "Err400"
    Public UnrecognizedCommand As String = "Err800"

    Public Enum ERROR_CODE
        NoError
        OutlierDetFailed
        NoValidSensorReading
        NoValidSensorLearning
        MotorCannotReachLearning
        HomingFailure
        UnrecognizeCommand
    End Enum

    Public ErrLevel As Integer
    Public ErrPress As Integer
    Public ErrTemp As Integer

    Public levelDammage As Boolean
    Public PresDammage As Boolean
    Public TempDammage As Boolean

    Public gotComReplyLevel As Boolean
    Public gotComReplyTemp As Boolean
    Public gotComReplyPress As Boolean

    Public levelRequested As Boolean
    Public tempRequested As Boolean
    Public presRequested As Boolean

    Public levelRequestedTimeout As Boolean
    Public tempRequestedTimeout As Boolean
    Public presRequestedTimeout As Boolean


    Public time_req_level As Date
    Public time_req_temp As Date
    Public time_req_press As Date

    Public timeCountReqLevel As Date
    Public timeCountTemp As Date
    Public timeCountPress As Date

    Public timeComCountReqLevel As Date
    Public timeComCountTemp As Date
    Public timeComCountPress As Date

    Public ComLevelRequested As Boolean
    Public ComTempRequested As Boolean
    Public ComPresRequested As Boolean

    Public ComRetryCountLevel As Integer
    Public ComRetryCountTemp As Integer
    Public ComRetryCountPress As Integer



    Public dataComplete As Boolean


    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        password.passkey.Text = ""

        If password.ShowDialog = Windows.Forms.DialogResult.OK Then
            If password.passkey.Text = "FFbrother" Then
                display_current_setting()
                If setting.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    get_user_setting()
                    save_allsetting()
                    update_setting()
                End If
            Else
                MessageBox.Show("Wrong password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        defaultdir = CurDir()
        load_setting()
        update_setting()
        load_table_setting()
        DTLevel.Value = Now
        DTPress.Value = Now
        DTTemp.Value = Now
        create_file()
    End Sub

    Private Sub display_current_setting()
        Dim ports As String() = SerialPort.GetPortNames()
        setting.portComName.Items.Clear()
        For Each port In ports
            setting.portComName.Items.Add(port)
        Next port

        setting.portComName.Text = portComName

        setting.maxValLevel.Text = maxValLevel
        setting.maxValTemp.Text = maxValTemp
        setting.maxValPress.Text = maxValPress

        setting.update_period.Text = update_period
        setting.reqDataCommand.Text = reqDataCommand
        setting.reqRawCommand.Text = reqRawCommand

        setting.master_user.Text = master_user
        setting.master_pass.Text = master_pass
        setting.sql_address.Text = sql_address
        setting.database_name.Text = database_name

        setting.reqTimeOut.Text = reqTimeOut
        setting.idLevel.Text = idLevel
        setting.idTemp.Text = idTemp
        setting.idPress.Text = idPress
        setting.reqComTimeOut.Text = reqComTimeOut
        setting.ComReqRetry.Text = ComReqRetry
    End Sub

    Private Sub get_user_setting()
        portComName = setting.portComName.Text

        maxValLevel = setting.maxValLevel.Text
        maxValTemp = setting.maxValTemp.Text
        maxValPress = setting.maxValPress.Text

        update_period = setting.update_period.Text
        reqDataCommand = setting.reqDataCommand.Text
        reqRawCommand = setting.reqRawCommand.Text

        master_user = setting.master_user.Text
        master_pass = setting.master_pass.Text
        sql_address = setting.sql_address.Text
        database_name = setting.database_name.Text

        reqTimeOut = setting.reqTimeOut.Text
        idLevel = setting.idLevel.Text
        idTemp = setting.idTemp.Text
        idPress = setting.idPress.Text
        reqComTimeOut = setting.reqComTimeOut.Text
        ComReqRetry = setting.ComReqRetry.Text

    End Sub

    Private Sub update_setting()
        gaugeLevel.MaxValue = maxValLevel
        gaugePressure.MaxValue = maxValPress
        gaugeTemp.MaxValue = maxValTemp
    End Sub

    Private Sub load_table_setting()
        Dim namafile As String
        namafile = defaultdir & "\" & table_setting
        If IO.File.Exists(namafile) Then
            Dim io_read As New StreamReader(namafile)
            file_54 = io_read.ReadLine
            openCsv(file_54, table54)
            file_tangki = io_read.ReadLine
            openCsv(file_tangki, tableTangki)
            io_read.Close()
        End If
        cBoxDensity.Items.Clear()
        For i = colDensityStartTable54 To table54.ColumnCount - 1
            cBoxDensity.Items.Add(table54.Item(i, rowDensityTable54).value)
        Next

    End Sub

    Private Sub save_table_setting(ByVal file54 As String, ByVal fileTangki As String)
        Dim namafile As String
        namafile = defaultdir & "\" & table_setting
        Dim io_write As New StreamWriter(namafile)
        io_write.WriteLine(file54)
        io_write.WriteLine(fileTangki)
        io_write.Close()
        load_table_setting()
    End Sub

    Private Sub load_setting()
        Dim namafile As String

        namafile = defaultdir & "\" & setting_file
        If IO.File.Exists(namafile) Then
            Dim io_read As New StreamReader(namafile)
            portComName = AESCrypter.AES_Decrypt(io_read.ReadLine)

            maxValLevel = AESCrypter.AES_Decrypt(io_read.ReadLine)
            maxValTemp = AESCrypter.AES_Decrypt(io_read.ReadLine)
            maxValPress = AESCrypter.AES_Decrypt(io_read.ReadLine)

            update_period = AESCrypter.AES_Decrypt(io_read.ReadLine)
            reqDataCommand = AESCrypter.AES_Decrypt(io_read.ReadLine)
            reqRawCommand = AESCrypter.AES_Decrypt(io_read.ReadLine)

            master_user = AESCrypter.AES_Decrypt(io_read.ReadLine)
            master_pass = AESCrypter.AES_Decrypt(io_read.ReadLine)
            sql_address = AESCrypter.AES_Decrypt(io_read.ReadLine)
            database_name = AESCrypter.AES_Decrypt(io_read.ReadLine)

            reqTimeOut = AESCrypter.AES_Decrypt(io_read.ReadLine)
            idLevel = AESCrypter.AES_Decrypt(io_read.ReadLine)
            idTemp = AESCrypter.AES_Decrypt(io_read.ReadLine)
            idPress = AESCrypter.AES_Decrypt(io_read.ReadLine)

            reqComTimeOut = AESCrypter.AES_Decrypt(io_read.ReadLine)
            ComReqRetry = AESCrypter.AES_Decrypt(io_read.ReadLine)

            io_read.Close()
        End If
    End Sub

    Public Sub save_allsetting()
        Dim namafile As String
        namafile = defaultdir & "\" & setting_file
        Dim io_write As New StreamWriter(namafile)

        io_write.WriteLine(AESCrypter.AES_Encrypt(portComName))

        io_write.WriteLine(AESCrypter.AES_Encrypt(maxValLevel))
        io_write.WriteLine(AESCrypter.AES_Encrypt(maxValTemp))
        io_write.WriteLine(AESCrypter.AES_Encrypt(maxValPress))

        io_write.WriteLine(AESCrypter.AES_Encrypt(update_period))
        io_write.WriteLine(AESCrypter.AES_Encrypt(reqDataCommand))
        io_write.WriteLine(AESCrypter.AES_Encrypt(reqRawCommand))

        io_write.WriteLine(AESCrypter.AES_Encrypt(master_user))
        io_write.WriteLine(AESCrypter.AES_Encrypt(master_pass))
        io_write.WriteLine(AESCrypter.AES_Encrypt(sql_address))
        io_write.WriteLine(AESCrypter.AES_Encrypt(database_name))

        io_write.WriteLine(AESCrypter.AES_Encrypt(reqTimeOut))
        io_write.WriteLine(AESCrypter.AES_Encrypt(idLevel))
        io_write.WriteLine(AESCrypter.AES_Encrypt(idTemp))
        io_write.WriteLine(AESCrypter.AES_Encrypt(idPress))

        io_write.WriteLine(AESCrypter.AES_Encrypt(reqComTimeOut))
        io_write.WriteLine(AESCrypter.AES_Encrypt(ComReqRetry))

        io_write.Close()

    End Sub

    Private Sub connect()
        connstring = "server=" & sql_address & ";user id=" & master_user & ";password=" & master_pass & "; port=3307; database=" & Chr(34) & database_name & Chr(34) & ";"
        If oMysql.Connect(connstring) Then
            portCom.PortName = portComName
            portCom.BaudRate = baudrate
            portCom.DtrEnable = True
            portCom.RtsEnable = True
            portCom.Open()

            isConnected = True

            time_req_level = Now
            time_req_press = Now
            time_req_temp = Now

            levelRequested = False
            tempRequested = False
            presRequested = False

            ComlevelRequested = False
            ComtempRequested = False
            CompresRequested = False

            Timer1.Enabled = True

            update_chart_press()
            update_chart_tankLevel()
            update_chart_temp()

            levelRequestedTimeout = False
            tempRequestedTimeout = False
            presRequestedTimeout = False

            gotLevel = False
            gotPress = False
            gotTemp = False

            ErrLevel = ERROR_CODE.NoError
            ErrPress = ERROR_CODE.NoError
            ErrTemp = ERROR_CODE.NoError

            levelDammage = False
            PresDammage = False
            TempDammage = False

            ComRetryCountLevel = 0
            ComRetryCountTemp = 0
            ComRetryCountPress = 0

            dataComplete = False

            btnRun.Text = "Stop"
        Else
            add_log("cannot connect to SQL server")
            MessageBox.Show("Cannot connect to SQL server", "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub disconnect()
        Timer1.Enabled = False
        portCom.Close()
        oMysql.DisConnect()
        btnRun.Text = "Run"
        isConnected = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        If (btnRun.Text = "Run") Then
            add_log("user try connect")
            connect()
        Else
            add_log("user try disconnect")
            disconnect()
        End If
    End Sub

    Private Sub SplitContainer3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainer3.Resize
        SplitContainer3.SplitterDistance = SplitContainer3.Height
    End Sub

    Private Sub SplitContainer4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainer4.Resize
        SplitContainer4.SplitterDistance = SplitContainer4.Height
    End Sub

    Private Sub SplitContainer5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainer5.Resize
        SplitContainer5.SplitterDistance = SplitContainer5.Height
    End Sub

    Private Sub update_chart_tankLevel()
        If isConnected Then
            'SELECT `AccLevelTime`, `TankLevel` FROM `measuringdata`
            'myQuery = "SELECT * FROM `" & table_level & "`where time_receive > '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 00:00:00' and time_receive < '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myQuery = "SELECT `AccLevelTime`, `TankLevel` FROM `" & dataTable & "`where AccLevelTime > '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 00:00:00' and AccLevelTime < '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myData = oMysql.GetData(myQuery)
            data_log_table.DataSource = myData.Tables(0)
            myData.Dispose()
            ChartLevel.Series("Tank Level").Points.Clear()
            For i = 0 To data_log_table.RowCount - 1
                ChartLevel.Series("Tank Level").Points.AddXY(data_log_table.Item(0, i).Value, data_log_table.Item(1, i).Value)
            Next
        End If
    End Sub

    Private Sub update_chart_temp()
        If isConnected Then
            'SELECT `AccTempTime`, `TankTemp` FROM `measuringdata`
            'myQuery = "SELECT * FROM `" & table_temp & "`where time_receive > '" & DTTemp.Value.ToString("yyyy-MM-dd") & " 00:00:00' and time_receive < '" & DTTemp.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myQuery = "SELECT `AccTempTime`, `TankTemp` FROM `" & dataTable & "`where AccTempTime > '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 00:00:00' and AccTempTime < '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myData = oMysql.GetData(myQuery)
            data_log_table.DataSource = myData.Tables(0)
            myData.Dispose()
            ChartTemp.Series("Temperature").Points.Clear()
            For i = 0 To data_log_table.RowCount - 1
                ChartTemp.Series("Temperature").Points.AddXY(data_log_table.Item(0, i).Value, data_log_table.Item(1, i).Value)
            Next
        End If
    End Sub

    Private Sub update_chart_press()
        If isConnected Then
            'SELECT `AccPressTime`, `TankPress` FROM `measuringdata`
            'myQuery = "SELECT * FROM `" & table_pressure & "`where time_receive > '" & DTPress.Value.ToString("yyyy-MM-dd") & " 00:00:00' and time_receive < '" & DTPress.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myQuery = "SELECT `AccPressTime`, `TankPress` FROM `" & dataTable & "`where AccPressTime > '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 00:00:00' and AccPressTime < '" & DTLevel.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            myData = oMysql.GetData(myQuery)
            data_log_table.DataSource = myData.Tables(0)
            myData.Dispose()
            ChartPressure.Series("Pressure").Points.Clear()
            For i = 0 To data_log_table.RowCount - 1
                ChartPressure.Series("Pressure").Points.AddXY(data_log_table.Item(0, i).Value, data_log_table.Item(1, i).Value)
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim check_datelog As Integer = Convert.ToInt16(Now.ToString("dd"))
        If logdate <> check_datelog Then
            create_file()
        End If

        ' ================ REQUEST DATA =====================================================================================================================================================
        If (Now > time_req_level) And ((presRequested = False) Or presRequestedTimeout) And ((tempRequested = False) Or tempRequestedTimeout) _
            And (levelRequestedTimeout = False) And levelDammage = False Then

            time_req_level = time_req_level.AddSeconds(update_period)
            portCom.WriteLine(idLevel & ":" & reqDataCommand & "?")
            timeCountReqLevel = Now
            timeComCountReqLevel = Now
            levelRequested = True
            ComLevelRequested = True
            LevelStatus.ForeColor = Color.Black
            LevelStatus.Text = "Tank Level data requested"
            add_log("Tank Level data requested")
            'Console.WriteLine("level request data")

        ElseIf (Now > time_req_press) And ((levelRequested = False) Or levelRequestedTimeout) And ((tempRequested = False) Or tempRequestedTimeout) _
            And (presRequestedTimeout = False) And TempDammage = False Then

            time_req_press = time_req_press.AddSeconds(update_period)
            portCom.WriteLine(idPress & ":" & reqDataCommand & "?")
            timeCountPress = Now
            timeComCountPress = Now
            presRequested = True
            ComPresRequested = True
            PressStatus.ForeColor = Color.Black
            PressStatus.Text = "Tank Temperature data requested"
            add_log("Tank Temperature data requested")
            'Console.WriteLine("pressure request data")

        ElseIf (Now > time_req_temp) And ((levelRequested = False) Or levelRequestedTimeout) And ((presRequested = False) Or presRequestedTimeout) _
            And (tempRequestedTimeout = False) And PresDammage = False Then

            time_req_temp = time_req_temp.AddSeconds(update_period)
            portCom.WriteLine(idTemp & ":" & reqDataCommand & "?")
            timeCountTemp = Now
            timeComCountTemp = Now
            tempRequested = True
            ComTempRequested = True
            TempStatus.ForeColor = Color.Black
            TempStatus.Text = "Tank pressure data requested"
            add_log("Tank pressure data requested")
            'Console.WriteLine("Temperature request data")
        End If

        ' ================ COMMAND REPLY INCOMING CHECK ====================================================================================================================================
        If gotComReplyLevel Then
            gotComReplyLevel = False
            ComLevelRequested = False
            LevelStatus.ForeColor = Color.Green
            LevelStatus.Text = "Tank Level data reading"
            add_log("Tank Level data reading")
        End If
        If gotComReplyTemp Then
            gotComReplyTemp = False
            ComTempRequested = False
            TempStatus.ForeColor = Color.Green
            TempStatus.Text = "Tank Temperature data reading"
            add_log("Tank Temperature data reading")
        End If
        If gotComReplyPress Then
            gotComReplyPress = False
            ComPresRequested = False
            PressStatus.ForeColor = Color.Green
            PressStatus.Text = "Tank pressure data reading"
            add_log("Tank pressure data reading")
        End If

        ' ================ DATA INCOMING CHECK ====================================================================================================================================
        If gotLevel Then
            levelRequested = False
        End If
        If gotTemp Then
            tempRequested = False
        End If
        If gotPress Then
            presRequested = False
        End If

        If ((gotLevel Or levelRequestedTimeout) And (gotPress Or presRequestedTimeout) And (gotTemp Or tempRequestedTimeout)) Then
            store_data()
            update_chart_tankLevel()
            update_chart_temp()
            update_chart_press()

            If gotLevel Then
                gotLevel = False
                gaugeLevel.Value = Convert.ToDouble(dataLevel)
                LevelStatus.ForeColor = Color.Green
                LevelStatus.Text = "Tank Level got data"
                add_log("Tank level got data")
                ComRetryCountLevel = 0
            End If
            If gotTemp Then
                gotTemp = False
                gaugeTemp.Value = Convert.ToDouble(dataTemp)
                TempStatus.Text = "Tank Temperature got data"
                add_log("Tank Temperature got data")
                ComRetryCountTemp = 0
            End If
            If gotPress Then
                gotPress = False
                gaugePressure.Value = Convert.ToDouble(dataPress)
                PressStatus.Text = "Tank pressure got data"
                add_log("Tank pressure got data")
                ComRetryCountPress = 0
            End If
        End If

        ' ================ COMMAND REPLY TIMEOUT CHECKING ============================================================================================================================
        If ComLevelRequested Then
            If Now > timeComCountReqLevel.AddSeconds(reqComTimeOut) Then
                LevelStatus.ForeColor = Color.Red
                LevelStatus.Text = "Tank Level Command not response"
                add_log("Tank Level Command not response")
                levelRequestedTimeout = True
                ComLevelRequested = False
            End If
        End If

        If ComTempRequested Then
            If Now > timeComCountTemp.AddSeconds(reqComTimeOut) Then
                TempStatus.ForeColor = Color.Red
                TempStatus.Text = "Tank Temperature Command not response"
                add_log("Tank Temperature Command not response")
                tempRequestedTimeout = True
                ComTempRequested = False
            End If
        End If

        If ComPresRequested Then
            If Now > timeComCountPress.AddSeconds(reqComTimeOut) Then
                PressStatus.ForeColor = Color.Red
                PressStatus.Text = "Tank pressure Command not response"
                add_log("Tank pressure Command not response")
                presRequestedTimeout = True
                ComPresRequested = False
            End If
        End If

        ' ================ DATA TIMEOUT CHECKING ====================================================================================================================================
        If levelRequested Then
            If Now > timeCountReqLevel.AddSeconds(reqTimeOut) Then
                LevelStatus.ForeColor = Color.Red
                LevelStatus.Text = "Tank level data request time out"
                add_log("Tank level data request time out")
                levelRequestedTimeout = True
                levelRequested = False
            End If
        End If

        If tempRequested Then
            If Now > timeCountTemp.AddSeconds(reqTimeOut) Then
                TempStatus.ForeColor = Color.Red
                TempStatus.Text = "Tank temperature data request time out"
                add_log("Tank temperature data request time out")
                tempRequestedTimeout = True
                tempRequested = False
            End If
        End If

        If presRequested Then
            If Now > timeCountPress.AddSeconds(reqTimeOut) Then
                PressStatus.ForeColor = Color.Red
                PressStatus.Text = "Tank pressure data request time out"
                add_log("Tank pressure data request time out")
                presRequestedTimeout = True
                presRequested = False
            End If
        End If
        ' ================ ERROR CHECKING =========================================================================================================================================
        If (ErrLevel = ERROR_CODE.HomingFailure) Or ErrLevel = ERROR_CODE.MotorCannotReachLearning Then
            levelDammage = True
        End If
        If (ErrTemp = ERROR_CODE.HomingFailure) Or ErrTemp = ERROR_CODE.MotorCannotReachLearning Then
            tempDammage = True
        End If
        If (ErrPress = ERROR_CODE.HomingFailure) Or ErrPress = ERROR_CODE.MotorCannotReachLearning Then
            presDammage = True
        End If
        If ErrLevel <> ERROR_CODE.NoError Then
            levelRequestedTimeout = True
            ErrLevel = ERROR_CODE.NoError
        End If
        If ErrTemp <> ERROR_CODE.NoError Then
            tempRequestedTimeout = True
            ErrTemp = ERROR_CODE.NoError
        End If
        If ErrPress <> ERROR_CODE.NoError Then
            presRequestedTimeout = True
            ErrPress = ERROR_CODE.NoError
        End If
        ' ================ RETRY CHECKING =========================================================================================================================================
        If levelRequestedTimeout And (ComRetryCountLevel < ComReqRetry) Then
            ComRetryCountLevel = ComRetryCountLevel + 1
            levelRequestedTimeout = False
            time_req_level = Now
            add_log("Tank Level command retry " & ComRetryCountLevel)
        Else
            time_req_level = time_req_level.AddSeconds(update_period)
            levelRequestedTimeout = False
        End If

        If tempRequestedTimeout And (ComRetryCountTemp < ComReqRetry) Then
            ComRetryCountTemp = ComRetryCountTemp + 1
            tempRequestedTimeout = False
            time_req_temp = Now
            add_log("Tank Temp command retry " & ComRetryCountTemp)
        Else
            time_req_temp = time_req_temp.AddSeconds(update_period)
            tempRequestedTimeout = False
        End If

        If presRequestedTimeout And (ComRetryCountPress < ComReqRetry) Then
            ComRetryCountPress = ComRetryCountPress + 1
            presRequestedTimeout = False
            time_req_press = Now
            add_log("Tank pressure command retry " & ComRetryCountPress)
        Else
            time_req_press = time_req_press.AddSeconds(update_period)
            presRequestedTimeout = False
        End If

    End Sub

    Private Sub calculateData(ByVal levelVal As Double, ByVal tempVal As Double, ByVal pressureVal As Double, ByVal densityVal As Double)
        '============================== CALCULATE LIQUID =======================================================
        If (levelVal <= 0) Or (tempVal <= 0) Or (pressureVal <= 0) Or (densityVal <= 0) Then
            Exit Sub
        End If

        '-----------------------------faktorKoreksiTemp---------------------------------------------------------
        Dim rowTempLookup As Integer
        Dim colDensityLookup As Integer
        For i = rowTempStartTable54 To table54.RowCount - 1
            If tempVal <= table54.Item(ColTempTable54, i).value Then
                rowTempLookup = i
                Exit For
            End If
            rowTempLookup = i
        Next
        For i = colDensityStartTable54 To table54.ColumnCount - 1
            If densityVal <= table54.Item(i, rowDensityTable54).value Then
                colDensityLookup = i
                Exit For
            End If
            colDensityLookup = i
        Next
        faktorKoreksiTemp.Text = table54.Item(colDensityLookup, rowTempLookup).Value

        '---------------------------density15C ---------------------------------------------------------------
        density15C.Text = densityVal * Convert.ToDouble(faktorKoreksiTemp.Text)

        '---------------------------nettLiterProduc-----------------------------------------------------------
        Dim rowPersenLookup As Integer
        For i = rowPersenTableTangki To tableTangki.RowCount - 1
            If levelVal <= tableTangki.Item(colPersenTableTangki, i).value Then
                rowPersenLookup = i
                Exit For
            End If
            rowPersenLookup = i
        Next
        nettLiterProducLiquid.Text = tableTangki.Item(colLiterTableTangki, rowPersenLookup).value

        '------------------------- volCorrectionFactor -------------------------------------------------------
        volCorrectionFactor.Text = faktorKoreksiTemp.Text

        '------------------------ Liters15C ------------------------------------------------------------------
        Liters15C.Text = Convert.ToDouble(nettLiterProducLiquid.Text) * Convert.ToDouble(volCorrectionFactor.Text)

        '------------------------ Multiplier -----------------------------------------------------------------
        Multiplier.Text = Convert.ToDouble(density15C.Text) - 0.0011

        '------------------------ kilogramLiquid -------------------------------------------------------------
        kilogramLiquid.Text = Convert.ToDouble(Liters15C.Text) * Convert.ToDouble(Multiplier.Text)

        '======================== CALCULATE VAPOUR ===========================================================

        '----------------------- levelVapour -----------------------------------------------------------------
        levelVapour.Text = 100 - levelVal

        '----------------------- nettLitersProductVapour -----------------------------------------------------
        Dim rowMaxLookup As Integer
        For i = rowPersenTableTangki To tableTangki.RowCount - 1
            If tableTangki.Item(colPersenTableTangki, i).value = 100 Then
                rowMaxLookup = i
                Exit For
            End If
            rowMaxLookup = i
        Next
        nettLitersProductVapour.Text = tableTangki.Item(colLiterTableTangki, rowMaxLookup).value - Convert.ToDouble(nettLiterProducLiquid.Text)

        '--------------------- pressureFactor ----------------------------------------------------------------
        pressureFactor.Text = (1.033 + pressureVal) / 1.033

        '-------------------- TemperatureFactor --------------------------------------------------------------
        TemperatureFactor.Text = 273 / (tempVal + 273)

        '------------------- vapourDensity -------------------------------------------------------------------
        vapourDensity.Text = 2.433036

        '------------------- kilogramsVapour -----------------------------------------------------------------
        kilogramsVapour.Text = Convert.ToDouble(nettLitersProductVapour.Text) * Convert.ToDouble(pressureFactor.Text) * Convert.ToDouble(TemperatureFactor.Text) * Convert.ToDouble(vapourDensity.Text) * 0.001

        '=================== TOTAL KILOGRAMS =================================================================
        TotalKilograms.Text = Convert.ToDouble(kilogramLiquid.Text) + Convert.ToDouble(kilogramsVapour.Text)

    End Sub

    Private Sub store_data()
        Dim levelStatus, pressStatus, tempStatus As String
        Dim levelVal, pressVal, tempVal As Double
        Dim levelTime, pressTime, tempTime As String

        If (gotLevel) Then
            levelStatus = "OK"
            levelVal = dataLevel
            levelTime = gotLevelTime.ToString("yyyy-MM-dd H:mm:ss")
        Else
            levelStatus = "FAIL"
            levelVal = 0
            levelTime = Now.ToString("yyyy-MM-dd H:mm:ss")
        End If
        If (gotPress) Then
            pressStatus = "OK"
            pressVal = dataPress
            pressTime = gotPressTime.ToString("yyyy-MM-dd H:mm:ss")
        Else
            pressStatus = "FAIL"
            pressVal = 0
            pressTime = Now.ToString("yyyy-MM-dd H:mm:ss")
        End If
        If (gotTemp) Then
            tempStatus = "OK"
            tempVal = dataTemp
            tempTime = gotTempTime.ToString("yyyy-MM-dd H:mm:ss")
        Else
            tempStatus = "FAIL"
            tempVal = 0
            tempTime = Now.ToString("yyyy-MM-dd H:mm:ss")
        End If
        tBoxLevel.Text = levelVal
        tBoxPress.Text = pressVal
        tBoxTemp.Text = pressVal
        calculateData(Convert.ToDouble(tBoxLevel.Text), Convert.ToDouble(tBoxTemp.Text), Convert.ToDouble(tBoxPress.Text), Convert.ToDouble(cBoxDensity.Text))
        myQuery = "INSERT INTO `" & dataTable & "` (`DataCompleteTime`, `LevelStatus`, `TankLevel`, `AccLevelTime`, `PressStatus`, `TankPress`, `AccPressTime`, `TempStatus`, `TankTemp`, `AccTempTime`, `KgLiquid`, `KgVapour`, `KgTotal`) VALUES (now(),'" & levelStatus & "', '" & levelVal & "', '" & levelTime & "', '" & pressStatus & "', '" & pressVal & "', '" & pressTime & "', '" & tempStatus & "', '" & tempVal & "', '" & tempTime & "', '" & kilogramLiquid.Text & "', '" & kilogramsVapour.Text & "', '" & TotalKilograms.Text & "');"
        oMysql.SetData(myQuery)

    End Sub

    Private Sub ChkTodayLevel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodayLevel.CheckedChanged
        If ChkTodayLevel.Checked Then
            DTLevel.Enabled = False
            DTLevel.Value = Now
        Else
            DTLevel.Enabled = True
        End If
    End Sub

    Private Sub ChkTodayTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodayTemp.CheckedChanged
        If ChkTodayTemp.Checked Then
            DTTemp.Enabled = False
            DTTemp.Value = Now
        Else
            DTTemp.Enabled = True
        End If
    End Sub

    Private Sub ChkTodayPress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodayPress.CheckedChanged
        If ChkTodayPress.Checked Then
            DTPress.Enabled = False
            DTPress.Value = Now
        Else
            DTPress.Enabled = True
        End If
    End Sub

    Private Sub DTLevel_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTLevel.ValueChanged
        update_chart_tankLevel()
    End Sub

    Private Sub DTTemp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTTemp.ValueChanged
        update_chart_temp()
    End Sub

    Private Sub DTPress_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPress.ValueChanged
        update_chart_press()
    End Sub

    Private Sub portCom_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles portCom.DataReceived
        Dim got_data As String = ""
        Dim strip_str As String = ""
        Dim errVal As Integer
        got_data = portCom.ReadExisting
        bufferCom &= got_data

        If bufferCom.Contains(vbCrLf) Then
            strip_str = bufferCom.Split(vbCrLf)(0)
            bufferCom = bufferCom.Replace(strip_str & vbCrLf, "")
            add_log("client send data -->" & strip_str)
            If strip_str.Contains(reqDataCommand & "=") Then
                strip_str = strip_str.Replace(reqDataCommand & "=", "")
                If strip_str.Contains(idLevel & ":") Then
                    gotLevel = True
                    dataLevel = strip_str.Replace(idLevel & ":", "")
                    gotLevelTime = Now
                ElseIf strip_str.Contains(idPress & ":") Then
                    gotPress = True
                    dataPress = strip_str.Replace(idPress & ":", "")
                    gotPressTime = Now
                ElseIf strip_str.Contains(idTemp & ":") Then
                    gotTemp = True
                    dataTemp = strip_str.Replace(idTemp & ":", "")
                    gotTempTime = Now
                End If
            ElseIf strip_str.Contains(reqDataCommandReply) Then
                If strip_str.Contains(idLevel & ":") Then
                    gotComReplyLevel = True
                ElseIf strip_str.Contains(idPress & ":") Then
                    gotComReplyPress = True
                ElseIf strip_str.Contains(idTemp & ":") Then
                    gotComReplyTemp = True
                End If
            ElseIf strip_str.Contains(OutliersDetetionFailed) Then
                errVal = ERROR_CODE.OutlierDetFailed
            ElseIf strip_str.Contains(NoValidSensorAfterReading) Then
                errVal = ERROR_CODE.NoValidSensorReading
            ElseIf strip_str.Contains(NoValidSensorAfterLearning) Then
                errVal = ERROR_CODE.NoValidSensorLearning
            ElseIf strip_str.Contains(MotorCannotReachTargetPosWhenLearning) Then
                errVal = ERROR_CODE.MotorCannotReachLearning
            ElseIf strip_str.Contains(HomingFailure) Then
                errVal = ERROR_CODE.HomingFailure
            ElseIf strip_str.Contains(UnrecognizedCommand) Then
                errVal = ERROR_CODE.UnrecognizeCommand
            End If
            If errVal <> 0 Then
                If strip_str.Contains(idLevel & ":") Then
                    ErrLevel = errVal
                ElseIf strip_str.Contains(idPress & ":") Then
                    ErrPress = errVal
                ElseIf strip_str.Contains(idTemp & ":") Then
                    ErrTemp = errVal
                End If
            End If
        End If
            'bufferCom = ""
    End Sub

    Private Sub export_csv(ByVal field)
        If Not isConnected Then
            MessageBox.Show("Please run first", "Need Run", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If field = 0 Then
            ExportCsv.fieldSelect.SelectedIndex = -1
            ExportCsv.fieldSelect.Text = ""
        Else
            ExportCsv.fieldSelect.Text = ExportCsv.fieldSelect.Items(field - 1)
        End If
        If ExportCsv.ShowDialog() = Windows.Forms.DialogResult.OK Then
            myQuery = "SELECT * FROM `" & dataTable & "`where DataCompleteTime > '" & ExportCsv.DtStart.Value.ToString("yyyy-MM-dd") & " 00:00:00' and DataCompleteTime < '" & ExportCsv.DtEnd.Value.ToString("yyyy-MM-dd") & " 23:59:59';"
            If isConnected Then
                myData = oMysql.GetData(myQuery)
                dataGridExport.DataSource = myData.Tables(0)
                myData.Dispose()
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim namafile As String
                    namafile = SaveFileDialog1.FileName
                    Dim io_write As New StreamWriter(namafile)
                    io_write.WriteLine("DataCompleteTime;LevelStatus;TankLevel;AccLevelTime;PressStatus;TankPress;AccPressTime;TempStatus;TankTemp;AccTempTime;KgLiquid;KgVapour;KgTotal")
                    For i = 0 To dataGridExport.RowCount - 1
                        Dim baris As String = ""
                        For j = 0 To dataGridExport.ColumnCount - 1
                            baris = baris & dataGridExport.Item(j, i).Value.ToString & ";"
                        Next
                        'io_write.WriteLine(dataGridExport.Item(0, i).Value.ToString & ";" & dataGridExport.Item(1, i).Value.ToString & ";")
                        io_write.WriteLine(baris)
                    Next
                    io_write.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ExportToCsvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToCsvToolStripMenuItem.Click
        export_csv(0)
    End Sub

    Private Sub ChartLevel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChartLevel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            menuLevel.Show()
            menuLevel.Location = Windows.Forms.Cursor.Position
        End If
    End Sub

    Private Sub ExportCsvToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCsvToolStripMenuItem1.Click
        export_csv(2)
    End Sub

    Private Sub ExportCsvToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCsvToolStripMenuItem2.Click
        export_csv(3)
    End Sub

    Private Sub ChartTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChartTemp.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            menuTemp.Show()
            menuTemp.Location = Windows.Forms.Cursor.Position
        End If
    End Sub

    Private Sub ChartPressure_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChartPressure.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            menuPress.Show()
            menuPress.Location = Windows.Forms.Cursor.Position
        End If
    End Sub

    Private Sub ExportCsvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCsvToolStripMenuItem.Click
        export_csv(1)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub create_file()
        Dim namafile As String
        namafile = defaultdir & "\" & log_file & Now.ToString("MM_dd_yyyy") & ".txt"
        log_writer = New StreamWriter(namafile, True)
        add_log("program running...")
        logdate = Convert.ToInt16(Now.ToString("dd"))
    End Sub

    Private Sub add_log(ByVal log_item As String)
        log_writer.WriteLine(Now.ToString & ":" & log_item)
        log_writer.Flush()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        disconnect()
        Application.Exit()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isConnected Then
            e.Cancel = True
            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Tank Manitoring"
            NotifyIcon1.BalloonTipText = "Tank Manitoring" & vbCrLf & "stop first if you want to close"
            NotifyIcon1.ShowBalloonTip(50000)
            Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'calculateData(Convert.ToDouble(tBoxLevel.Text), Convert.ToDouble(tBoxTemp.Text), Convert.ToDouble(tBoxPress.Text), Convert.ToDouble(cBoxDensity.Text))
        gotComReplyLevel = True
        gotComReplyPress = True
        gotComReplyTemp = True

        gotPress = True
        gotLevel = True
        gotTemp = True
        dataPress = 10
        dataLevel = 25
        dataTemp = 30

    End Sub

    Public Sub openCsv(ByVal filename As String, ByRef datagrid As DataGridView)
        If IO.File.Exists(filename) Then
            datagrid.Visible = False
            datagrid.Columns.Clear()
            datagrid.Rows.Clear()
            For Each line As String In System.IO.File.ReadAllLines(filename)
                If line.Split(",").Count > datagrid.ColumnCount Then
                    datagrid.ColumnCount = line.Split(",").Count
                End If
                datagrid.Rows.Add(line.Split(","))
            Next
            datagrid.ColumnHeadersVisible = False
            datagrid.RowHeadersVisible = False
            datagrid.AllowUserToAddRows = False
            datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            datagrid.Visible = True
        End If
    End Sub

    Private Sub TablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablesToolStripMenuItem.Click
        tables.File54.Text = file_54
        tables.FileTangki.Text = file_tangki
        openCsv(file_54, tables.table54)
        openCsv(file_tangki, tables.tableTangki)
        If tables.ShowDialog = Windows.Forms.DialogResult.OK Then
            save_table_setting(tables.File54.Text, tables.FileTangki.Text)
        End If
    End Sub
End Class
