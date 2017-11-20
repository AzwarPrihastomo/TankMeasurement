using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modbus_Poll_CS;
using System.Timers;
using System.IO.Ports;
using System.IO;

namespace TankMeasurement
{
    public partial class Form1 : Form
    {
        public delegate void GUIDelegate();
        public delegate void LogDelegate(string item);
        modbus mb = new modbus();
        SerialPort sp = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        Encryp MyEncryp = new Encryp();
        StringToFormula myFormula = new StringToFormula();

        const String setting_file = "setting.ini";
        const String table_setting = "table.ini";
        const String log_file = "Log_";
        String fileLog;

        String FileTangki;
        String File54;

        bool isConnect = false;

        private Setting settingForm = new Setting();
        private Password passwordForm = new Password();
        private Tables tablesForm = new Tables();
        private About aboutForm = new About();
        private cMySQL oMysql = new cMySQL();
        private ExportCsv exportCsvForm = new ExportCsv();

        //------------ server SQL -----------------------------
        String master_user; //= "root"
        String master_pass; //= "usbw"
        String sql_address; //= "127.0.0.1"
        String database_name; //= "bts_security"
        //------------ Com Port -------------------------------
        String portModbus;
        int modBusBaud = 9600;

        //----------- Max Value -------------------------------
        Double maxValLevel;
        Double maxValTemp;
        Double maxValPress;

        //---------- update period  ---------------------------
        int update_period;
        //----------- modbus Sensors --------------------------
        int tempAddress = 1;
        double tempScale;
        double tempOffset;

        int pressAddress = 2;
        double pressScale;
        double pressOffset;

        int levelAddress = 3;
        string levelFormula = "";
        //---------- some vars --------------------------------
        String connstring;
        String defaultdir;

        short[] values = new short[20];
        double valLevel, valTemp, valPress;

        const int rowDensityTable54 = 1;
        const int colDensityStartTable54 = 1;
        const int ColTempTable54 = 0;
        const int rowTempStartTable54 = 3;

        const int colPersenTableTangki = 1;
        const int rowPersenTableTangki = 1;
        const int colLiterTableTangki = 2;

        DataSet myData = new DataSet();
        const string dataTable = "measuringdata";
        string myQuery;
        int dateNow;

        public Form1()
        {
            InitializeComponent();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            defaultdir = Directory.GetCurrentDirectory();
            loadConfig();
            loadTableSetting();
            updateSetting();
            DTLevel.Value = DateTime.Now;
            DTPress.Value = DateTime.Now;
            DTTemp.Value = DateTime.Now;
            dateNow = Convert.ToInt16(DateTime.Now.ToString("dd"));
            CreateNewLog();
        }

        private void updateSetting()
        {
            gaugeLevel.MaxValue = (float)maxValLevel;
            gaugePressure.MaxValue = (float)maxValPress;
            gaugeTemp.MaxValue = (float)maxValTemp;
        }

        private void displayCurrentSetting()
        {
            settingForm.modbusPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                settingForm.modbusPort.Items.Add(port);
            }

            settingForm.updatePeriod.Text = Convert.ToString(update_period);
            settingForm.modbusPort.Text = portModbus;
            settingForm.modbusBaud.Text = Convert.ToString(modBusBaud);
            settingForm.sql_address.Text = sql_address;
            settingForm.master_user.Text = master_user;
            settingForm.master_pass.Text = master_pass;
            settingForm.database_name.Text = database_name;
            settingForm.maxValLevel.Text = Convert.ToString(maxValLevel);
            settingForm.levelFormula.Text = levelFormula;
            settingForm.addrLevel.Text = Convert.ToString(levelAddress);
            settingForm.maxValTemp.Text = Convert.ToString(maxValTemp);
            settingForm.addrTemp.Text = Convert.ToString(tempAddress);
            settingForm.tempScale.Text = Convert.ToString(tempScale);
            settingForm.tempOffset.Text = Convert.ToString(tempOffset);
            settingForm.maxValPress.Text = Convert.ToString(maxValPress);
            settingForm.addrPress.Text = Convert.ToString(pressAddress);
            settingForm.pressScale.Text = Convert.ToString(pressScale);
            settingForm.pressOffset.Text = Convert.ToString(pressOffset);
        }

        private void getUserSetting()
        {
            update_period = Convert.ToInt16(settingForm.updatePeriod.Text);
            portModbus = settingForm.modbusPort.Text;
            modBusBaud = Convert.ToInt16(settingForm.modbusBaud.Text);
            sql_address = settingForm.sql_address.Text;
            master_user = settingForm.master_user.Text;
            master_pass = settingForm.master_pass.Text;
            database_name = settingForm.database_name.Text;
            levelFormula = settingForm.levelFormula.Text;
            levelAddress = Convert.ToInt16(settingForm.addrLevel.Text);
            maxValLevel = Convert.ToDouble(settingForm.maxValLevel.Text);
            maxValTemp = Convert.ToDouble(settingForm.maxValTemp.Text);
            tempAddress = Convert.ToInt16(settingForm.addrTemp.Text);
            tempScale = Convert.ToDouble(settingForm.tempScale.Text);
            tempOffset = Convert.ToDouble(settingForm.tempOffset.Text);
            maxValPress = Convert.ToDouble(settingForm.maxValPress.Text);
            pressAddress = Convert.ToInt16(settingForm.addrPress.Text);
            pressScale = Convert.ToDouble(settingForm.pressScale.Text);
            pressOffset = Convert.ToDouble(settingForm.pressOffset.Text);
        }

        private void saveConfig()
        {
            String namafile;
            namafile = defaultdir + "\\" + setting_file;
            using (StreamWriter io_write =
            new StreamWriter(@namafile, false))
            {
                io_write.WriteLine(MyEncryp.Encrypt(master_user));
                io_write.WriteLine(MyEncryp.Encrypt(master_pass));
                io_write.WriteLine(MyEncryp.Encrypt(sql_address));
                io_write.WriteLine(MyEncryp.Encrypt(database_name));
                io_write.WriteLine(MyEncryp.Encrypt(portModbus));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(modBusBaud)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(maxValLevel)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(maxValTemp)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(maxValPress)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(update_period)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(tempAddress)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(tempScale)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(tempOffset)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(pressAddress)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(pressScale)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(pressOffset)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(levelFormula)));
                io_write.WriteLine(MyEncryp.Encrypt(Convert.ToString(levelAddress)));

            }
        }

        private void loadConfig()
        {
            String namafile;
            namafile = defaultdir + "\\" + setting_file;
            using (StreamReader io_read =
            new StreamReader(@namafile, true))
            {
                master_user = MyEncryp.Decrypt(io_read.ReadLine());
                master_pass = MyEncryp.Decrypt(io_read.ReadLine());
                sql_address = MyEncryp.Decrypt(io_read.ReadLine());
                database_name = MyEncryp.Decrypt(io_read.ReadLine());
                portModbus = MyEncryp.Decrypt(io_read.ReadLine());
                modBusBaud = Convert.ToInt16(MyEncryp.Decrypt(io_read.ReadLine()));
                maxValLevel = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                maxValTemp = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                maxValPress = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                update_period = Convert.ToInt16(MyEncryp.Decrypt(io_read.ReadLine()));
                tempAddress = Convert.ToInt16(MyEncryp.Decrypt(io_read.ReadLine()));
                tempScale = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                tempOffset = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                pressAddress = Convert.ToInt16(MyEncryp.Decrypt(io_read.ReadLine()));
                pressScale = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                pressOffset = Convert.ToDouble(MyEncryp.Decrypt(io_read.ReadLine()));
                levelFormula = MyEncryp.Decrypt(io_read.ReadLine());
                levelAddress = Convert.ToInt16(MyEncryp.Decrypt(io_read.ReadLine()));
            }
        }

        private void loadTableSetting()
        {
            String namafile;
            namafile = defaultdir + "\\" + table_setting;
            if (!File.Exists(namafile))
                return;
            using (StreamReader io_read =
            new StreamReader(@namafile, true))
            {
                FileTangki = io_read.ReadLine();
                File54 = io_read.ReadLine();
            }
            openCsv(File54, ref table54);
            openCsv(FileTangki, ref tableTangki);
            cBoxDensity.Items.Clear();
            for (int i = colDensityStartTable54; i < table54.ColumnCount; i++)
            {
                cBoxDensity.Items.Add(Convert.ToString(table54[i, rowDensityTable54].Value));
            }
        }

        private void saveTableSetting(string file54, string fileTangki)
        {
            String namafile;
            namafile = defaultdir + "\\" + table_setting;
            using (StreamWriter io_write =
            new StreamWriter(@namafile, false))
            {
                io_write.WriteLine(fileTangki);
                io_write.WriteLine(file54);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "Run")
            {
                WriteLog("Running Process");
                RunProcess();
            }
            else
            {
                WriteLog("Stopping Process");
                StopProcess();
            }
        }

        private void RunProcess()
        {
            if (!mb.Open(portModbus, modBusBaud, 8, Parity.None, StopBits.One))
                return;
            connstring = "server=" + sql_address + ";user id=" + master_user + ";password=" + master_pass + "; port=3307; database=" + (char)34 + database_name + (char)34 + ";";
            if (!oMysql.Connect(connstring))
            {
                WriteLog("Cannot Connect to mySql Server");
                return;
            }
            {
                btnRun.Text = "Stop";
                timer.AutoReset = true;
                timer.Interval = 1000 * update_period;
                timer.Start();
                isConnect = true;
            }

        }

        private void StopProcess()
        {
            oMysql.DisConnect();
            timer.Stop();
            mb.Close();
            btnRun.Text = "Run";
            isConnect = false;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PollAllData();
        }

        private void PollAllData()
        {
            ushort pollStart;
            ushort pollLength;

            pollStart = 0;
            pollLength = 8;

            try
            {
                WriteLog("Requesting Data");
                while (!mb.SendFc3(Convert.ToByte("1"), pollStart, pollLength, ref values)) ;
                WriteLog("Data accuired");
                String data = "Data = ";
                for (int i = 0; i < pollLength; i++)
                {
                    data += Convert.ToString(values[i]) + ",\t";
                }
                WriteLog(data);
            }
            catch (Exception err)
            {
                WriteLog("Error in modbus read: " + err.Message);
                MessageBox.Show("Error in modbus read: " + err.Message);
            }

            DoUpdate();
        }

        public void DoUpdate()
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoUpdate);
                this.Invoke(delegateMethod, new object[] { });
            }
            else
            {
                UpdateALL();
            }
        }

        private void UpdateALL()
        {
            if (dateNow != Convert.ToInt16(DateTime.Now.ToString("dd")))
            {
                CreateNewLog();
                DTLevel.Value = DateTime.Now;
                DTPress.Value = DateTime.Now;
                DTTemp.Value = DateTime.Now;
                dateNow = Convert.ToInt16(DateTime.Now.ToString("dd"));
            }
            valLevel = CalculateEquation(levelFormula, (double)values[levelAddress]);
            valPress = ((double)values[pressAddress] * pressScale) + pressOffset;
            if (valPress < 0)
                valPress = 0;
            valTemp = ((double)values[tempAddress] * tempScale) + tempOffset;
            gaugeLevel.Value = (float)valLevel;
            gaugeTemp.Value = (float)valTemp;
            gaugePressure.Value = (float)valPress;
            WriteLog("updating display");
            tBoxLevel.Text = Convert.ToString(valLevel);
            tBoxPress.Text = Convert.ToString(valPress);
            tBoxTemp.Text = Convert.ToString(valTemp);
            calculateData(valLevel, valPress, valTemp, Convert.ToDouble(cBoxDensity.Text));
            myQuery = "INSERT INTO `tankmeasurement`.`measuringdata` (`DataCompleteTime`, `TankLevel`, `TankPress`, `TankTemp`, `KgLiquid`, `KgVapour`, `KgTotal`) VALUES (now(), '" + Convert.ToString(valLevel) + "', '" + Convert.ToString(valPress) + "', '" + Convert.ToString(valTemp) + "', '" + kilogramLiquid.Text + "', '" + kilogramsVapour.Text + "', '" + TotalKilograms.Text + "');";
            WriteLog(myQuery);
            if (!oMysql.SetData(myQuery))
            {
                MessageBox.Show("Error upload, Process stopped");
                StopProcess();
                WriteLog("update database error, process stop");
            }
            WriteLog("updating chart");
            updateLevelChart();
            updatePressChart();
            updateTempChart();
        }

        private void updateLevelChart()
        {
            if (!isConnect)
                return;
            myQuery = "SELECT `DataCompleteTime`, `TankLevel` FROM `" + dataTable + "`where DataCompleteTime > '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 00:00:00' and DataCompleteTime < '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 23:59:59';";
            myData = oMysql.GetData(myQuery);
            data_log_table.DataSource = myData.Tables[0];
            myData.Dispose();
            ChartLevel.Series["Tank Level"].Points.Clear();
            for (int i = 0; i < data_log_table.RowCount; i++)
            {
                ChartLevel.Series["Tank Level"].Points.AddXY(Convert.ToDateTime(data_log_table[0, i].Value), Convert.ToDouble(data_log_table[1, i].Value));
            }
        }

        private void updatePressChart()
        {
            if (!isConnect)
                return;
            myQuery = "SELECT `DataCompleteTime`, `TankPress` FROM `" + dataTable + "`where DataCompleteTime > '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 00:00:00' and DataCompleteTime < '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 23:59:59';";
            myData = oMysql.GetData(myQuery);
            data_log_table.DataSource = myData.Tables[0];
            myData.Dispose();
            ChartPressure.Series["Pressure"].Points.Clear();
            for (int i = 0; i < data_log_table.RowCount; i++)
            {
                ChartPressure.Series["Pressure"].Points.AddXY(Convert.ToDateTime(data_log_table[0, i].Value), Convert.ToDouble(data_log_table[1, i].Value));
            }
        }

        private void updateTempChart()
        {
            if (!isConnect)
                return;
            myQuery = "SELECT `DataCompleteTime`, `TankTemp` FROM `" + dataTable + "`where DataCompleteTime > '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 00:00:00' and DataCompleteTime < '" + DTLevel.Value.ToString("yyyy-MM-dd") + " 23:59:59';";
            myData = oMysql.GetData(myQuery);
            data_log_table.DataSource = myData.Tables[0];
            myData.Dispose();
            ChartTemp.Series["Temperature"].Points.Clear();
            for (int i = 0; i < data_log_table.RowCount; i++)
            {
                ChartTemp.Series["Temperature"].Points.AddXY(Convert.ToDateTime(data_log_table[0, i].Value), Convert.ToDouble(data_log_table[1, i].Value));
            }
        }

        private void calculateData(double valLevel, double valPress, double valTemp, double densityVal)
        {
            if ((valLevel <= 0) || (valPress < 0) || (valTemp <= 0) || (densityVal <= 0))
                return;
            //'-----------------------------faktorKoreksiTemp---------------------------------------------------------
            int rowTempLookup, colDensityLookup;
            rowTempLookup = rowTempStartTable54;
            colDensityLookup = colDensityStartTable54;
            for (int i = rowTempStartTable54; i < table54.RowCount; i++)
            {

                if (valTemp <= Convert.ToDouble(table54[ColTempTable54, i].Value))
                {
                    rowTempLookup = i;
                    break;
                }
                rowTempLookup = i;
            }
            for (int i = colDensityStartTable54; i < table54.ColumnCount; i++)
            {
                if (densityVal <= Convert.ToDouble(table54[i, rowDensityTable54].Value))
                {
                    colDensityLookup = i;
                    break;
                }
                colDensityLookup = i;
            }
            faktorKoreksiTemp.Text = Convert.ToString(table54[colDensityLookup, rowTempLookup].Value);

            //---------------------------density15C ---------------------------------------------------------------
            density15C.Text = Convert.ToString(densityVal * Convert.ToDouble(faktorKoreksiTemp.Text));

            //---------------------------nettLiterProduc-----------------------------------------------------------
            int rowPersenLookup = rowPersenTableTangki;
            for (int i = rowPersenTableTangki; i < tableTangki.RowCount; i++)
            {
                if (valLevel <= Convert.ToDouble(tableTangki[colPersenTableTangki, i].Value))
                {
                    rowPersenLookup = i;
                    break;
                }
                rowPersenLookup = i;
            }
            nettLiterProducLiquid.Text = Convert.ToString(tableTangki[colLiterTableTangki, rowPersenLookup].Value);

            //------------------------- volCorrectionFactor -------------------------------------------------------
            volCorrectionFactor.Text = faktorKoreksiTemp.Text;

            //------------------------ Liters15C ------------------------------------------------------------------
            Liters15C.Text = Convert.ToString(Convert.ToDouble(nettLiterProducLiquid.Text) * Convert.ToDouble(volCorrectionFactor.Text));

            //------------------------ Multiplier -----------------------------------------------------------------
            Multiplier.Text = Convert.ToString(Convert.ToDouble(density15C.Text) - 0.0011);

            //------------------------ kilogramLiquid -------------------------------------------------------------
            kilogramLiquid.Text = Convert.ToString(Convert.ToDouble(Liters15C.Text) * Convert.ToDouble(Multiplier.Text));

            //======================== CALCULATE VAPOUR ===========================================================

            //----------------------- levelVapour -----------------------------------------------------------------
            levelVapour.Text = Convert.ToString(100 - valLevel);

            //----------------------- nettLitersProductVapour -----------------------------------------------------
            int rowMaxLookup = rowPersenTableTangki;
            for (int i = rowPersenTableTangki; i < tableTangki.RowCount; i++)
            {
                if (Convert.ToDouble(tableTangki[colPersenTableTangki, i].Value) >= 100)
                {
                    rowMaxLookup = i;
                    break;
                }
                rowMaxLookup = i;
            }
            nettLitersProductVapour.Text = Convert.ToString(Convert.ToDouble(tableTangki[colLiterTableTangki, rowMaxLookup].Value) - Convert.ToDouble(nettLiterProducLiquid.Text));

            //--------------------- pressureFactor ----------------------------------------------------------------
            pressureFactor.Text = Convert.ToString((1.033 + valPress) / 1.033);

            //-------------------- TemperatureFactor --------------------------------------------------------------
            TemperatureFactor.Text = Convert.ToString(273 / (valTemp + 273));

            //------------------- vapourDensity -------------------------------------------------------------------
            vapourDensity.Text = "2.433036";

            //------------------- kilogramsVapour -----------------------------------------------------------------
            kilogramsVapour.Text = Convert.ToString(Convert.ToDouble(nettLitersProductVapour.Text) * Convert.ToDouble(pressureFactor.Text) * Convert.ToDouble(TemperatureFactor.Text) * Convert.ToDouble(vapourDensity.Text) * 0.001);

            //=================== TOTAL KILOGRAMS =================================================================
            TotalKilograms.Text = Convert.ToString(Convert.ToDouble(kilogramLiquid.Text) + Convert.ToDouble(kilogramsVapour.Text));


        }

        private double CalculateEquation(string equation, double XValue)
        {
            StringToFormula myFormula = new StringToFormula();
            string finalEqu = equation.Replace("X", Convert.ToString(XValue));
            return myFormula.Eval(finalEqu);
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordForm.passkey.Text = "";
            if (passwordForm.ShowDialog() != DialogResult.OK)
                return;
            if (passwordForm.passkey.Text != "FFbrother")
                return;
            displayCurrentSetting();
            if (settingForm.ShowDialog() == DialogResult.OK)
            {
                getUserSetting();
                saveConfig();
                updateSetting();
            }
        }

        public void openCsv(String filename, ref DataGridView datagrid)
        {
            if (!File.Exists(filename))
            {
                return;
            }
            datagrid.Visible = false;
            datagrid.Columns.Clear();
            datagrid.Rows.Clear();
            string all_line;
            using (StreamReader io_read =
            new StreamReader(filename, true))
            {
                all_line = io_read.ReadToEnd();
            }
            string[] lines = all_line.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Split(',').Length > datagrid.ColumnCount)
                {
                    datagrid.ColumnCount = line.Split(',').Length;
                }
                datagrid.Rows.Add(line.Split(','));
            }
            datagrid.ColumnHeadersVisible = false;
            datagrid.RowHeadersVisible = false;
            datagrid.AllowUserToAddRows = false;
            datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            datagrid.Visible = true;
        }

        private void TablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablesForm.File54.Text = File54;
            tablesForm.FileTangki.Text = FileTangki;
            openCsv(File54, ref tablesForm.table54);
            openCsv(FileTangki, ref tablesForm.tableTangki);
            if (tablesForm.ShowDialog() == DialogResult.OK)
            {
                saveTableSetting(tablesForm.File54.Text, tablesForm.FileTangki.Text);
            }

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnect)
            {
                e.Cancel = true;
                NotifyIcon1.Visible = true;
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                NotifyIcon1.BalloonTipTitle = "Tank Manitoring";
                NotifyIcon1.BalloonTipText = "Tank Manitoring \r\n stop first if you want to close";
                NotifyIcon1.ShowBalloonTip(50000);
                this.Hide();
                ShowInTaskbar = false;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon1.Visible = false;
        }

        private void ChkTodayLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTodayLevel.Checked)
            {
                DTLevel.Enabled = false;
                DTLevel.Value = DateTime.Now;
            }
            else
            {
                DTLevel.Enabled = true;
            }
        }

        private void ChkTodayTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTodayTemp.Checked)
            {
                DTTemp.Enabled = false;
                DTTemp.Value = DateTime.Now;
            }
            else
            {
                DTTemp.Enabled = true;
            }
        }

        private void ChkTodayPress_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTodayPress.Checked)
            {
                DTPress.Enabled = false;
                DTPress.Value = DateTime.Now;
            }
            else
            {
                DTPress.Enabled = true;
            }
        }

        private void DTLevel_ValueChanged(object sender, EventArgs e)
        {
            updateLevelChart();
        }

        private void DTTemp_ValueChanged(object sender, EventArgs e)
        {
            updateTempChart();
        }

        private void DTPress_ValueChanged(object sender, EventArgs e)
        {
            updatePressChart();
        }

        private void ExportToCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void ExportToCsv()
        {
            exportCsvForm.ChkToday.Checked = true;
            exportCsvForm.DtStart.Value = DateTime.Now;
            exportCsvForm.DtEnd.Value = DateTime.Now;
            if (exportCsvForm.ShowDialog() == DialogResult.OK)
            {
                if (!isConnect)
                {
                    MessageBox.Show("Please run first");
                    return;
                }
                if (SaveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                myQuery = "SELECT * FROM `" + dataTable + "`where DataCompleteTime > '" + exportCsvForm.DtStart.Value.ToString("yyyy-MM-dd") + " 00:00:00' and DataCompleteTime < '" + exportCsvForm.DtEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59';";
                myData = oMysql.GetData(myQuery);
                data_log_table.DataSource = myData.Tables[0];
                myData.Dispose();
                String namafile;
                namafile = SaveFileDialog1.FileName;
                using (StreamWriter io_write =
                new StreamWriter(@namafile, false))
                {
                    io_write.WriteLine("Time;Tank Level;Tank Pressure;Tank Temperature;Kg Liquid;Kg Vapour;Kg Total");
                    for (int i = 0; i < data_log_table.RowCount; i++)
                    {
                        string line = "";
                        for (int j = 0; j < data_log_table.ColumnCount; j++)
                        {
                            line += Convert.ToString(data_log_table[j, i].Value) + ";";
                        }
                        io_write.WriteLine(line);
                    }
                }
            }
        }

        private void ChartLevel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuLevel.Show();
                menuLevel.Location = System.Windows.Forms.Cursor.Position;
            }
        }

        private void ChartTemp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuTemp.Show();
                menuTemp.Location = System.Windows.Forms.Cursor.Position;
            }
        }

        private void ChartPressure_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuPress.Show();
                menuPress.Location = System.Windows.Forms.Cursor.Position;
            }
        }

        private void ExportCsvToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void ExportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void ExportCsvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void WriteLog(string item)
        {
            if (this.InvokeRequired)
            {
                LogDelegate delegateMethod = new LogDelegate(this.WriteLog);
                this.Invoke(delegateMethod, new object[] { item });
            }
            else
            {
                String logLine = DateTime.Now.ToString() + ": " + item;
                File.AppendAllText(fileLog, logLine + Environment.NewLine);
                textLog.AppendText(logLine + "\r\n");
            }
        }

        private void CreateNewLog()
        {
            fileLog = defaultdir + "\\" + log_file + DateTime.Now.ToString("MM_dd_yyyy") + ".txt";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (btnHide.Text == "Hide Calculation")
            {
                btnHide.Text = "Show Calculation";
                Panel5.Visible = false;
            }
            else
            {
                btnHide.Text = "Hide Calculation";
                Panel5.Visible = true;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (btnLog.Text == "Show Log")
            {
                SplitContainer1.Visible = false;
                btnLog.Text = "Hide Log";
            }
            else
            {
                SplitContainer1.Visible = true;
                btnLog.Text = "Show Log";
            }

        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
