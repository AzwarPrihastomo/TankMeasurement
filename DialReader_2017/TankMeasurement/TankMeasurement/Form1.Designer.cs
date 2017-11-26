namespace TankMeasurement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
      this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
      this.gaugeLevel = new AquaControls.AquaGauge();
      this.ChkTodayLevel = new System.Windows.Forms.CheckBox();
      this.DTLevel = new System.Windows.Forms.DateTimePicker();
      this.ChartLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tableTangki = new System.Windows.Forms.DataGridView();
      this.table54 = new System.Windows.Forms.DataGridView();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.Label1 = new System.Windows.Forms.Label();
      this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
      this.SplitContainer4 = new System.Windows.Forms.SplitContainer();
      this.gaugeTemp = new AquaControls.AquaGauge();
      this.data_log_table = new System.Windows.Forms.DataGridView();
      this.ChkTodayTemp = new System.Windows.Forms.CheckBox();
      this.DTTemp = new System.Windows.Forms.DateTimePicker();
      this.ChartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.dataGridExport = new System.Windows.Forms.DataGridView();
      this.Panel2 = new System.Windows.Forms.Panel();
      this.Label2 = new System.Windows.Forms.Label();
      this.SplitContainer5 = new System.Windows.Forms.SplitContainer();
      this.gaugePressure = new AquaControls.AquaGauge();
      this.ChkTodayPress = new System.Windows.Forms.CheckBox();
      this.DTPress = new System.Windows.Forms.DateTimePicker();
      this.ChartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.Panel3 = new System.Windows.Forms.Panel();
      this.Label3 = new System.Windows.Forms.Label();
      this.Panel5 = new System.Windows.Forms.Panel();
      this.TotalKilograms = new System.Windows.Forms.TextBox();
      this.Panel7 = new System.Windows.Forms.Panel();
      this.Label22 = new System.Windows.Forms.Label();
      this.Label15 = new System.Windows.Forms.Label();
      this.Panel6 = new System.Windows.Forms.Panel();
      this.cBoxDensity = new System.Windows.Forms.ComboBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.tBoxLevel = new System.Windows.Forms.TextBox();
      this.Label6 = new System.Windows.Forms.Label();
      this.tBoxPress = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.tBoxTemp = new System.Windows.Forms.TextBox();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.kilogramsVapour = new System.Windows.Forms.TextBox();
      this.vapourDensity = new System.Windows.Forms.TextBox();
      this.TemperatureFactor = new System.Windows.Forms.TextBox();
      this.pressureFactor = new System.Windows.Forms.TextBox();
      this.nettLitersProductVapour = new System.Windows.Forms.TextBox();
      this.levelVapour = new System.Windows.Forms.TextBox();
      this.Label16 = new System.Windows.Forms.Label();
      this.Label17 = new System.Windows.Forms.Label();
      this.Label18 = new System.Windows.Forms.Label();
      this.Label19 = new System.Windows.Forms.Label();
      this.Label20 = new System.Windows.Forms.Label();
      this.Label21 = new System.Windows.Forms.Label();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.kilogramLiquid = new System.Windows.Forms.TextBox();
      this.Multiplier = new System.Windows.Forms.TextBox();
      this.Liters15C = new System.Windows.Forms.TextBox();
      this.volCorrectionFactor = new System.Windows.Forms.TextBox();
      this.nettLiterProducLiquid = new System.Windows.Forms.TextBox();
      this.density15C = new System.Windows.Forms.TextBox();
      this.faktorKoreksiTemp = new System.Windows.Forms.TextBox();
      this.Label14 = new System.Windows.Forms.Label();
      this.Label13 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.Label10 = new System.Windows.Forms.Label();
      this.Label9 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.Label23 = new System.Windows.Forms.Label();
      this.Panel4 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.btnLog = new System.Windows.Forms.Button();
      this.btnHide = new System.Windows.Forms.Button();
      this.btnRun = new System.Windows.Forms.Button();
      this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
      this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ExportToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
      this.LevelStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.portCom = new System.IO.Ports.SerialPort(this.components);
      this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.menuLevel = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ExportCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuTemp = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ExportCsvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPress = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ExportCsvToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.panel8 = new System.Windows.Forms.Panel();
      this.textLog = new System.Windows.Forms.TextBox();
      this.huToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).BeginInit();
      this.SplitContainer3.Panel1.SuspendLayout();
      this.SplitContainer3.Panel2.SuspendLayout();
      this.SplitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChartLevel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableTangki)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.table54)).BeginInit();
      this.Panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
      this.SplitContainer2.Panel1.SuspendLayout();
      this.SplitContainer2.Panel2.SuspendLayout();
      this.SplitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer4)).BeginInit();
      this.SplitContainer4.Panel1.SuspendLayout();
      this.SplitContainer4.Panel2.SuspendLayout();
      this.SplitContainer4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.data_log_table)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).BeginInit();
      this.Panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer5)).BeginInit();
      this.SplitContainer5.Panel1.SuspendLayout();
      this.SplitContainer5.Panel2.SuspendLayout();
      this.SplitContainer5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChartPressure)).BeginInit();
      this.Panel3.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.Panel7.SuspendLayout();
      this.Panel6.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.MenuStrip1.SuspendLayout();
      this.StatusStrip1.SuspendLayout();
      this.menuLevel.SuspendLayout();
      this.menuTemp.SuspendLayout();
      this.menuPress.SuspendLayout();
      this.panel8.SuspendLayout();
      this.SuspendLayout();
      // 
      // SplitContainer1
      // 
      this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer1.Location = new System.Drawing.Point(0, 28);
      this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // SplitContainer1.Panel1
      // 
      this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer3);
      this.SplitContainer1.Panel1.Controls.Add(this.Panel1);
      // 
      // SplitContainer1.Panel2
      // 
      this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
      this.SplitContainer1.Size = new System.Drawing.Size(1054, 774);
      this.SplitContainer1.SplitterDistance = 250;
      this.SplitContainer1.SplitterWidth = 5;
      this.SplitContainer1.TabIndex = 7;
      // 
      // SplitContainer3
      // 
      this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer3.Location = new System.Drawing.Point(0, 32);
      this.SplitContainer3.Margin = new System.Windows.Forms.Padding(4);
      this.SplitContainer3.Name = "SplitContainer3";
      // 
      // SplitContainer3.Panel1
      // 
      this.SplitContainer3.Panel1.Controls.Add(this.gaugeLevel);
      // 
      // SplitContainer3.Panel2
      // 
      this.SplitContainer3.Panel2.Controls.Add(this.ChkTodayLevel);
      this.SplitContainer3.Panel2.Controls.Add(this.DTLevel);
      this.SplitContainer3.Panel2.Controls.Add(this.ChartLevel);
      this.SplitContainer3.Panel2.Controls.Add(this.tableTangki);
      this.SplitContainer3.Panel2.Controls.Add(this.table54);
      this.SplitContainer3.Size = new System.Drawing.Size(1054, 218);
      this.SplitContainer3.SplitterDistance = 224;
      this.SplitContainer3.SplitterWidth = 5;
      this.SplitContainer3.TabIndex = 0;
      // 
      // gaugeLevel
      // 
      this.gaugeLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.gaugeLevel.BackColor = System.Drawing.Color.Transparent;
      this.gaugeLevel.DialColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.gaugeLevel.DialText = null;
      this.gaugeLevel.Glossiness = 70F;
      this.gaugeLevel.Location = new System.Drawing.Point(0, 0);
      this.gaugeLevel.Margin = new System.Windows.Forms.Padding(5);
      this.gaugeLevel.MaxValue = 100F;
      this.gaugeLevel.MinValue = 0F;
      this.gaugeLevel.Name = "gaugeLevel";
      this.gaugeLevel.RecommendedValue = 0F;
      this.gaugeLevel.Size = new System.Drawing.Size(225, 225);
      this.gaugeLevel.TabIndex = 1;
      this.gaugeLevel.ThresholdPercent = 0F;
      this.gaugeLevel.Value = 0F;
      // 
      // ChkTodayLevel
      // 
      this.ChkTodayLevel.AutoSize = true;
      this.ChkTodayLevel.Checked = true;
      this.ChkTodayLevel.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ChkTodayLevel.Location = new System.Drawing.Point(55, 9);
      this.ChkTodayLevel.Margin = new System.Windows.Forms.Padding(4);
      this.ChkTodayLevel.Name = "ChkTodayLevel";
      this.ChkTodayLevel.Size = new System.Drawing.Size(70, 21);
      this.ChkTodayLevel.TabIndex = 11;
      this.ChkTodayLevel.Text = "Today";
      this.ChkTodayLevel.UseVisualStyleBackColor = true;
      this.ChkTodayLevel.CheckedChanged += new System.EventHandler(this.ChkTodayLevel_CheckedChanged);
      // 
      // DTLevel
      // 
      this.DTLevel.Enabled = false;
      this.DTLevel.Location = new System.Drawing.Point(141, 7);
      this.DTLevel.Margin = new System.Windows.Forms.Padding(4);
      this.DTLevel.Name = "DTLevel";
      this.DTLevel.Size = new System.Drawing.Size(265, 22);
      this.DTLevel.TabIndex = 10;
      this.DTLevel.Value = new System.DateTime(2012, 10, 23, 0, 0, 0, 0);
      this.DTLevel.ValueChanged += new System.EventHandler(this.DTLevel_ValueChanged);
      // 
      // ChartLevel
      // 
      chartArea1.Name = "ChartArea1";
      this.ChartLevel.ChartAreas.Add(chartArea1);
      this.ChartLevel.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Alignment = System.Drawing.StringAlignment.Far;
      legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend1.Name = "Legend1";
      this.ChartLevel.Legends.Add(legend1);
      this.ChartLevel.Location = new System.Drawing.Point(0, 0);
      this.ChartLevel.Margin = new System.Windows.Forms.Padding(4);
      this.ChartLevel.Name = "ChartLevel";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Color = System.Drawing.Color.Blue;
      series1.Legend = "Legend1";
      series1.Name = "Tank Level";
      series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.ChartLevel.Series.Add(series1);
      this.ChartLevel.Size = new System.Drawing.Size(825, 218);
      this.ChartLevel.TabIndex = 13;
      this.ChartLevel.Text = "Chart1";
      this.ChartLevel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartLevel_MouseDown);
      // 
      // tableTangki
      // 
      this.tableTangki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableTangki.Location = new System.Drawing.Point(429, 7);
      this.tableTangki.Margin = new System.Windows.Forms.Padding(4);
      this.tableTangki.Name = "tableTangki";
      this.tableTangki.Size = new System.Drawing.Size(320, 185);
      this.tableTangki.TabIndex = 12;
      // 
      // table54
      // 
      this.table54.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.table54.Location = new System.Drawing.Point(101, 9);
      this.table54.Margin = new System.Windows.Forms.Padding(4);
      this.table54.Name = "table54";
      this.table54.Size = new System.Drawing.Size(320, 185);
      this.table54.TabIndex = 12;
      // 
      // Panel1
      // 
      this.Panel1.BackColor = System.Drawing.Color.Silver;
      this.Panel1.Controls.Add(this.Label1);
      this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel1.Location = new System.Drawing.Point(0, 0);
      this.Panel1.Margin = new System.Windows.Forms.Padding(4);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(1054, 32);
      this.Panel1.TabIndex = 1;
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label1.Location = new System.Drawing.Point(467, 9);
      this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(148, 20);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Tank Level ( % )";
      // 
      // SplitContainer2
      // 
      this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
      this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
      this.SplitContainer2.Name = "SplitContainer2";
      this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // SplitContainer2.Panel1
      // 
      this.SplitContainer2.Panel1.Controls.Add(this.SplitContainer4);
      this.SplitContainer2.Panel1.Controls.Add(this.Panel2);
      // 
      // SplitContainer2.Panel2
      // 
      this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer5);
      this.SplitContainer2.Panel2.Controls.Add(this.Panel3);
      this.SplitContainer2.Size = new System.Drawing.Size(1054, 519);
      this.SplitContainer2.SplitterDistance = 252;
      this.SplitContainer2.SplitterWidth = 5;
      this.SplitContainer2.TabIndex = 0;
      // 
      // SplitContainer4
      // 
      this.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer4.Location = new System.Drawing.Point(0, 32);
      this.SplitContainer4.Margin = new System.Windows.Forms.Padding(4);
      this.SplitContainer4.Name = "SplitContainer4";
      // 
      // SplitContainer4.Panel1
      // 
      this.SplitContainer4.Panel1.Controls.Add(this.gaugeTemp);
      // 
      // SplitContainer4.Panel2
      // 
      this.SplitContainer4.Panel2.Controls.Add(this.data_log_table);
      this.SplitContainer4.Panel2.Controls.Add(this.ChkTodayTemp);
      this.SplitContainer4.Panel2.Controls.Add(this.DTTemp);
      this.SplitContainer4.Panel2.Controls.Add(this.ChartTemp);
      this.SplitContainer4.Panel2.Controls.Add(this.dataGridExport);
      this.SplitContainer4.Size = new System.Drawing.Size(1054, 220);
      this.SplitContainer4.SplitterDistance = 224;
      this.SplitContainer4.SplitterWidth = 5;
      this.SplitContainer4.TabIndex = 0;
      // 
      // gaugeTemp
      // 
      this.gaugeTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.gaugeTemp.BackColor = System.Drawing.Color.Transparent;
      this.gaugeTemp.DialColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.gaugeTemp.DialText = null;
      this.gaugeTemp.Glossiness = 70F;
      this.gaugeTemp.Location = new System.Drawing.Point(0, 0);
      this.gaugeTemp.Margin = new System.Windows.Forms.Padding(5);
      this.gaugeTemp.MaxValue = 200F;
      this.gaugeTemp.MinValue = 0F;
      this.gaugeTemp.Name = "gaugeTemp";
      this.gaugeTemp.RecommendedValue = 0F;
      this.gaugeTemp.Size = new System.Drawing.Size(225, 225);
      this.gaugeTemp.TabIndex = 1;
      this.gaugeTemp.ThresholdPercent = 0F;
      this.gaugeTemp.Value = 0F;
      // 
      // data_log_table
      // 
      this.data_log_table.AllowUserToAddRows = false;
      this.data_log_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.data_log_table.Location = new System.Drawing.Point(429, 37);
      this.data_log_table.Margin = new System.Windows.Forms.Padding(4);
      this.data_log_table.Name = "data_log_table";
      this.data_log_table.RowHeadersVisible = false;
      this.data_log_table.Size = new System.Drawing.Size(301, 181);
      this.data_log_table.TabIndex = 12;
      this.data_log_table.Visible = false;
      // 
      // ChkTodayTemp
      // 
      this.ChkTodayTemp.AutoSize = true;
      this.ChkTodayTemp.Checked = true;
      this.ChkTodayTemp.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ChkTodayTemp.Location = new System.Drawing.Point(55, 9);
      this.ChkTodayTemp.Margin = new System.Windows.Forms.Padding(4);
      this.ChkTodayTemp.Name = "ChkTodayTemp";
      this.ChkTodayTemp.Size = new System.Drawing.Size(70, 21);
      this.ChkTodayTemp.TabIndex = 11;
      this.ChkTodayTemp.Text = "Today";
      this.ChkTodayTemp.UseVisualStyleBackColor = true;
      this.ChkTodayTemp.CheckedChanged += new System.EventHandler(this.ChkTodayTemp_CheckedChanged);
      // 
      // DTTemp
      // 
      this.DTTemp.Enabled = false;
      this.DTTemp.Location = new System.Drawing.Point(141, 7);
      this.DTTemp.Margin = new System.Windows.Forms.Padding(4);
      this.DTTemp.Name = "DTTemp";
      this.DTTemp.Size = new System.Drawing.Size(265, 22);
      this.DTTemp.TabIndex = 10;
      this.DTTemp.Value = new System.DateTime(2012, 10, 23, 0, 0, 0, 0);
      this.DTTemp.ValueChanged += new System.EventHandler(this.DTTemp_ValueChanged);
      // 
      // ChartTemp
      // 
      chartArea2.Name = "ChartArea1";
      this.ChartTemp.ChartAreas.Add(chartArea2);
      this.ChartTemp.Dock = System.Windows.Forms.DockStyle.Fill;
      legend2.Alignment = System.Drawing.StringAlignment.Far;
      legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend2.Name = "Legend1";
      this.ChartTemp.Legends.Add(legend2);
      this.ChartTemp.Location = new System.Drawing.Point(0, 0);
      this.ChartTemp.Margin = new System.Windows.Forms.Padding(4);
      this.ChartTemp.Name = "ChartTemp";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.Color = System.Drawing.Color.SeaGreen;
      series2.Legend = "Legend1";
      series2.Name = "Temperature";
      series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.ChartTemp.Series.Add(series2);
      this.ChartTemp.Size = new System.Drawing.Size(825, 220);
      this.ChartTemp.TabIndex = 13;
      this.ChartTemp.Text = "Chart1";
      this.ChartTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartTemp_MouseDown);
      // 
      // dataGridExport
      // 
      this.dataGridExport.AllowUserToAddRows = false;
      this.dataGridExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridExport.Location = new System.Drawing.Point(371, 9);
      this.dataGridExport.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridExport.Name = "dataGridExport";
      this.dataGridExport.Size = new System.Drawing.Size(301, 181);
      this.dataGridExport.TabIndex = 12;
      this.dataGridExport.Visible = false;
      // 
      // Panel2
      // 
      this.Panel2.BackColor = System.Drawing.Color.Silver;
      this.Panel2.Controls.Add(this.Label2);
      this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel2.Location = new System.Drawing.Point(0, 0);
      this.Panel2.Margin = new System.Windows.Forms.Padding(4);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(1054, 32);
      this.Panel2.TabIndex = 2;
      // 
      // Label2
      // 
      this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Label2.AutoSize = true;
      this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label2.Location = new System.Drawing.Point(433, 9);
      this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(204, 20);
      this.Label2.TabIndex = 0;
      this.Label2.Text = "TEMPERATURE ( ° C )";
      // 
      // SplitContainer5
      // 
      this.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer5.Location = new System.Drawing.Point(0, 32);
      this.SplitContainer5.Margin = new System.Windows.Forms.Padding(4);
      this.SplitContainer5.Name = "SplitContainer5";
      // 
      // SplitContainer5.Panel1
      // 
      this.SplitContainer5.Panel1.Controls.Add(this.gaugePressure);
      // 
      // SplitContainer5.Panel2
      // 
      this.SplitContainer5.Panel2.Controls.Add(this.ChkTodayPress);
      this.SplitContainer5.Panel2.Controls.Add(this.DTPress);
      this.SplitContainer5.Panel2.Controls.Add(this.ChartPressure);
      this.SplitContainer5.Size = new System.Drawing.Size(1054, 230);
      this.SplitContainer5.SplitterDistance = 228;
      this.SplitContainer5.SplitterWidth = 5;
      this.SplitContainer5.TabIndex = 0;
      // 
      // gaugePressure
      // 
      this.gaugePressure.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.gaugePressure.BackColor = System.Drawing.Color.Transparent;
      this.gaugePressure.DialColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.gaugePressure.DialText = null;
      this.gaugePressure.Glossiness = 70F;
      this.gaugePressure.Location = new System.Drawing.Point(0, 2);
      this.gaugePressure.Margin = new System.Windows.Forms.Padding(5);
      this.gaugePressure.MaxValue = 200F;
      this.gaugePressure.MinValue = 0F;
      this.gaugePressure.Name = "gaugePressure";
      this.gaugePressure.RecommendedValue = 0F;
      this.gaugePressure.Size = new System.Drawing.Size(225, 225);
      this.gaugePressure.TabIndex = 1;
      this.gaugePressure.ThresholdPercent = 0F;
      this.gaugePressure.Value = 0F;
      // 
      // ChkTodayPress
      // 
      this.ChkTodayPress.AutoSize = true;
      this.ChkTodayPress.Checked = true;
      this.ChkTodayPress.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ChkTodayPress.Location = new System.Drawing.Point(51, 9);
      this.ChkTodayPress.Margin = new System.Windows.Forms.Padding(4);
      this.ChkTodayPress.Name = "ChkTodayPress";
      this.ChkTodayPress.Size = new System.Drawing.Size(70, 21);
      this.ChkTodayPress.TabIndex = 11;
      this.ChkTodayPress.Text = "Today";
      this.ChkTodayPress.UseVisualStyleBackColor = true;
      this.ChkTodayPress.CheckedChanged += new System.EventHandler(this.ChkTodayPress_CheckedChanged);
      // 
      // DTPress
      // 
      this.DTPress.Enabled = false;
      this.DTPress.Location = new System.Drawing.Point(137, 7);
      this.DTPress.Margin = new System.Windows.Forms.Padding(4);
      this.DTPress.Name = "DTPress";
      this.DTPress.Size = new System.Drawing.Size(265, 22);
      this.DTPress.TabIndex = 10;
      this.DTPress.Value = new System.DateTime(2012, 10, 23, 0, 0, 0, 0);
      this.DTPress.ValueChanged += new System.EventHandler(this.DTPress_ValueChanged);
      // 
      // ChartPressure
      // 
      chartArea3.Name = "ChartArea1";
      this.ChartPressure.ChartAreas.Add(chartArea3);
      this.ChartPressure.Dock = System.Windows.Forms.DockStyle.Fill;
      legend3.Alignment = System.Drawing.StringAlignment.Far;
      legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend3.Name = "Legend1";
      this.ChartPressure.Legends.Add(legend3);
      this.ChartPressure.Location = new System.Drawing.Point(0, 0);
      this.ChartPressure.Margin = new System.Windows.Forms.Padding(4);
      this.ChartPressure.Name = "ChartPressure";
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series3.Color = System.Drawing.Color.BlueViolet;
      series3.Legend = "Legend1";
      series3.Name = "Pressure";
      series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.ChartPressure.Series.Add(series3);
      this.ChartPressure.Size = new System.Drawing.Size(821, 230);
      this.ChartPressure.TabIndex = 12;
      this.ChartPressure.Text = "Chart1";
      this.ChartPressure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartPressure_MouseDown);
      // 
      // Panel3
      // 
      this.Panel3.BackColor = System.Drawing.Color.Silver;
      this.Panel3.Controls.Add(this.Label3);
      this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel3.Location = new System.Drawing.Point(0, 0);
      this.Panel3.Margin = new System.Windows.Forms.Padding(4);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new System.Drawing.Size(1054, 32);
      this.Panel3.TabIndex = 3;
      // 
      // Label3
      // 
      this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Label3.AutoSize = true;
      this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label3.Location = new System.Drawing.Point(467, 9);
      this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(167, 20);
      this.Label3.TabIndex = 0;
      this.Label3.Text = "PRESSURE ( Psi )";
      // 
      // Panel5
      // 
      this.Panel5.Controls.Add(this.TotalKilograms);
      this.Panel5.Controls.Add(this.Panel7);
      this.Panel5.Controls.Add(this.Panel6);
      this.Panel5.Controls.Add(this.GroupBox2);
      this.Panel5.Controls.Add(this.GroupBox1);
      this.Panel5.Controls.Add(this.Label23);
      this.Panel5.Dock = System.Windows.Forms.DockStyle.Right;
      this.Panel5.Location = new System.Drawing.Point(1054, 28);
      this.Panel5.Margin = new System.Windows.Forms.Padding(4);
      this.Panel5.Name = "Panel5";
      this.Panel5.Size = new System.Drawing.Size(413, 774);
      this.Panel5.TabIndex = 11;
      // 
      // TotalKilograms
      // 
      this.TotalKilograms.Location = new System.Drawing.Point(203, 722);
      this.TotalKilograms.Margin = new System.Windows.Forms.Padding(4);
      this.TotalKilograms.Name = "TotalKilograms";
      this.TotalKilograms.ReadOnly = true;
      this.TotalKilograms.Size = new System.Drawing.Size(132, 22);
      this.TotalKilograms.TabIndex = 12;
      // 
      // Panel7
      // 
      this.Panel7.BackColor = System.Drawing.Color.Silver;
      this.Panel7.Controls.Add(this.Label22);
      this.Panel7.Controls.Add(this.Label15);
      this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel7.Location = new System.Drawing.Point(0, 0);
      this.Panel7.Margin = new System.Windows.Forms.Padding(4);
      this.Panel7.Name = "Panel7";
      this.Panel7.Size = new System.Drawing.Size(413, 32);
      this.Panel7.TabIndex = 4;
      // 
      // Label22
      // 
      this.Label22.AutoSize = true;
      this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label22.Location = new System.Drawing.Point(128, 9);
      this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label22.Name = "Label22";
      this.Label22.Size = new System.Drawing.Size(103, 20);
      this.Label22.TabIndex = 0;
      this.Label22.Text = "Calculation";
      // 
      // Label15
      // 
      this.Label15.AutoSize = true;
      this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label15.Location = new System.Drawing.Point(467, 9);
      this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label15.Name = "Label15";
      this.Label15.Size = new System.Drawing.Size(148, 20);
      this.Label15.TabIndex = 0;
      this.Label15.Text = "Tank Level ( % )";
      // 
      // Panel6
      // 
      this.Panel6.Controls.Add(this.cBoxDensity);
      this.Panel6.Controls.Add(this.Label4);
      this.Panel6.Controls.Add(this.Label5);
      this.Panel6.Controls.Add(this.tBoxLevel);
      this.Panel6.Controls.Add(this.Label6);
      this.Panel6.Controls.Add(this.tBoxPress);
      this.Panel6.Controls.Add(this.Label7);
      this.Panel6.Controls.Add(this.tBoxTemp);
      this.Panel6.Location = new System.Drawing.Point(31, 52);
      this.Panel6.Margin = new System.Windows.Forms.Padding(4);
      this.Panel6.Name = "Panel6";
      this.Panel6.Size = new System.Drawing.Size(332, 154);
      this.Panel6.TabIndex = 3;
      // 
      // cBoxDensity
      // 
      this.cBoxDensity.FormattingEnabled = true;
      this.cBoxDensity.Location = new System.Drawing.Point(172, 111);
      this.cBoxDensity.Margin = new System.Windows.Forms.Padding(4);
      this.cBoxDensity.Name = "cBoxDensity";
      this.cBoxDensity.Size = new System.Drawing.Size(132, 24);
      this.cBoxDensity.TabIndex = 2;
      this.cBoxDensity.Text = "0.510";
      // 
      // Label4
      // 
      this.Label4.AutoSize = true;
      this.Label4.Location = new System.Drawing.Point(16, 17);
      this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(118, 17);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "Level Liquid ( % )";
      // 
      // Label5
      // 
      this.Label5.AutoSize = true;
      this.Label5.Location = new System.Drawing.Point(16, 49);
      this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(131, 17);
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Temperature ( ° C )";
      // 
      // tBoxLevel
      // 
      this.tBoxLevel.Location = new System.Drawing.Point(172, 14);
      this.tBoxLevel.Margin = new System.Windows.Forms.Padding(4);
      this.tBoxLevel.Name = "tBoxLevel";
      this.tBoxLevel.ReadOnly = true;
      this.tBoxLevel.Size = new System.Drawing.Size(132, 22);
      this.tBoxLevel.TabIndex = 1;
      this.tBoxLevel.Text = "70";
      // 
      // Label6
      // 
      this.Label6.AutoSize = true;
      this.Label6.Location = new System.Drawing.Point(16, 81);
      this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(109, 17);
      this.Label6.TabIndex = 0;
      this.Label6.Text = "Pressure ( Bar )";
      // 
      // tBoxPress
      // 
      this.tBoxPress.Location = new System.Drawing.Point(172, 78);
      this.tBoxPress.Margin = new System.Windows.Forms.Padding(4);
      this.tBoxPress.Name = "tBoxPress";
      this.tBoxPress.ReadOnly = true;
      this.tBoxPress.Size = new System.Drawing.Size(132, 22);
      this.tBoxPress.TabIndex = 1;
      this.tBoxPress.Text = "15";
      // 
      // Label7
      // 
      this.Label7.AutoSize = true;
      this.Label7.Location = new System.Drawing.Point(16, 114);
      this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(55, 17);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Density";
      // 
      // tBoxTemp
      // 
      this.tBoxTemp.Location = new System.Drawing.Point(172, 46);
      this.tBoxTemp.Margin = new System.Windows.Forms.Padding(4);
      this.tBoxTemp.Name = "tBoxTemp";
      this.tBoxTemp.ReadOnly = true;
      this.tBoxTemp.Size = new System.Drawing.Size(132, 22);
      this.tBoxTemp.TabIndex = 1;
      this.tBoxTemp.Text = "30";
      // 
      // GroupBox2
      // 
      this.GroupBox2.Controls.Add(this.kilogramsVapour);
      this.GroupBox2.Controls.Add(this.vapourDensity);
      this.GroupBox2.Controls.Add(this.TemperatureFactor);
      this.GroupBox2.Controls.Add(this.pressureFactor);
      this.GroupBox2.Controls.Add(this.nettLitersProductVapour);
      this.GroupBox2.Controls.Add(this.levelVapour);
      this.GroupBox2.Controls.Add(this.Label16);
      this.GroupBox2.Controls.Add(this.Label17);
      this.GroupBox2.Controls.Add(this.Label18);
      this.GroupBox2.Controls.Add(this.Label19);
      this.GroupBox2.Controls.Add(this.Label20);
      this.GroupBox2.Controls.Add(this.Label21);
      this.GroupBox2.Location = new System.Drawing.Point(31, 478);
      this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
      this.GroupBox2.Size = new System.Drawing.Size(332, 222);
      this.GroupBox2.TabIndex = 2;
      this.GroupBox2.TabStop = false;
      // 
      // kilogramsVapour
      // 
      this.kilogramsVapour.Location = new System.Drawing.Point(172, 177);
      this.kilogramsVapour.Margin = new System.Windows.Forms.Padding(4);
      this.kilogramsVapour.Name = "kilogramsVapour";
      this.kilogramsVapour.ReadOnly = true;
      this.kilogramsVapour.Size = new System.Drawing.Size(132, 22);
      this.kilogramsVapour.TabIndex = 12;
      // 
      // vapourDensity
      // 
      this.vapourDensity.Location = new System.Drawing.Point(172, 145);
      this.vapourDensity.Margin = new System.Windows.Forms.Padding(4);
      this.vapourDensity.Name = "vapourDensity";
      this.vapourDensity.ReadOnly = true;
      this.vapourDensity.Size = new System.Drawing.Size(132, 22);
      this.vapourDensity.TabIndex = 11;
      // 
      // TemperatureFactor
      // 
      this.TemperatureFactor.Location = new System.Drawing.Point(172, 113);
      this.TemperatureFactor.Margin = new System.Windows.Forms.Padding(4);
      this.TemperatureFactor.Name = "TemperatureFactor";
      this.TemperatureFactor.ReadOnly = true;
      this.TemperatureFactor.Size = new System.Drawing.Size(132, 22);
      this.TemperatureFactor.TabIndex = 10;
      // 
      // pressureFactor
      // 
      this.pressureFactor.Location = new System.Drawing.Point(172, 81);
      this.pressureFactor.Margin = new System.Windows.Forms.Padding(4);
      this.pressureFactor.Name = "pressureFactor";
      this.pressureFactor.ReadOnly = true;
      this.pressureFactor.Size = new System.Drawing.Size(132, 22);
      this.pressureFactor.TabIndex = 15;
      // 
      // nettLitersProductVapour
      // 
      this.nettLitersProductVapour.Location = new System.Drawing.Point(172, 49);
      this.nettLitersProductVapour.Margin = new System.Windows.Forms.Padding(4);
      this.nettLitersProductVapour.Name = "nettLitersProductVapour";
      this.nettLitersProductVapour.ReadOnly = true;
      this.nettLitersProductVapour.Size = new System.Drawing.Size(132, 22);
      this.nettLitersProductVapour.TabIndex = 14;
      // 
      // levelVapour
      // 
      this.levelVapour.Location = new System.Drawing.Point(172, 17);
      this.levelVapour.Margin = new System.Windows.Forms.Padding(4);
      this.levelVapour.Name = "levelVapour";
      this.levelVapour.ReadOnly = true;
      this.levelVapour.Size = new System.Drawing.Size(132, 22);
      this.levelVapour.TabIndex = 13;
      // 
      // Label16
      // 
      this.Label16.AutoSize = true;
      this.Label16.Location = new System.Drawing.Point(8, 181);
      this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label16.Name = "Label16";
      this.Label16.Size = new System.Drawing.Size(120, 17);
      this.Label16.TabIndex = 5;
      this.Label16.Text = "Kilograms Vapour";
      // 
      // Label17
      // 
      this.Label17.AutoSize = true;
      this.Label17.Location = new System.Drawing.Point(8, 149);
      this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label17.Name = "Label17";
      this.Label17.Size = new System.Drawing.Size(105, 17);
      this.Label17.TabIndex = 2;
      this.Label17.Text = "Vapour Density";
      // 
      // Label18
      // 
      this.Label18.AutoSize = true;
      this.Label18.Location = new System.Drawing.Point(8, 117);
      this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label18.Name = "Label18";
      this.Label18.Size = new System.Drawing.Size(126, 17);
      this.Label18.TabIndex = 3;
      this.Label18.Text = "Temperatur Factor";
      // 
      // Label19
      // 
      this.Label19.AutoSize = true;
      this.Label19.Location = new System.Drawing.Point(8, 85);
      this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label19.Name = "Label19";
      this.Label19.Size = new System.Drawing.Size(109, 17);
      this.Label19.TabIndex = 8;
      this.Label19.Text = "Pressure Factor";
      // 
      // Label20
      // 
      this.Label20.AutoSize = true;
      this.Label20.Location = new System.Drawing.Point(8, 53);
      this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label20.Name = "Label20";
      this.Label20.Size = new System.Drawing.Size(142, 17);
      this.Label20.TabIndex = 7;
      this.Label20.Text = "Nett Liters at Product";
      // 
      // Label21
      // 
      this.Label21.AutoSize = true;
      this.Label21.Location = new System.Drawing.Point(8, 21);
      this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label21.Name = "Label21";
      this.Label21.Size = new System.Drawing.Size(92, 17);
      this.Label21.TabIndex = 6;
      this.Label21.Text = "Level Vapour";
      // 
      // GroupBox1
      // 
      this.GroupBox1.Controls.Add(this.kilogramLiquid);
      this.GroupBox1.Controls.Add(this.Multiplier);
      this.GroupBox1.Controls.Add(this.Liters15C);
      this.GroupBox1.Controls.Add(this.volCorrectionFactor);
      this.GroupBox1.Controls.Add(this.nettLiterProducLiquid);
      this.GroupBox1.Controls.Add(this.density15C);
      this.GroupBox1.Controls.Add(this.faktorKoreksiTemp);
      this.GroupBox1.Controls.Add(this.Label14);
      this.GroupBox1.Controls.Add(this.Label13);
      this.GroupBox1.Controls.Add(this.Label12);
      this.GroupBox1.Controls.Add(this.Label11);
      this.GroupBox1.Controls.Add(this.Label10);
      this.GroupBox1.Controls.Add(this.Label9);
      this.GroupBox1.Controls.Add(this.Label8);
      this.GroupBox1.Location = new System.Drawing.Point(31, 213);
      this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.GroupBox1.Size = new System.Drawing.Size(332, 257);
      this.GroupBox1.TabIndex = 2;
      this.GroupBox1.TabStop = false;
      // 
      // kilogramLiquid
      // 
      this.kilogramLiquid.Location = new System.Drawing.Point(172, 209);
      this.kilogramLiquid.Margin = new System.Windows.Forms.Padding(4);
      this.kilogramLiquid.Name = "kilogramLiquid";
      this.kilogramLiquid.ReadOnly = true;
      this.kilogramLiquid.Size = new System.Drawing.Size(132, 22);
      this.kilogramLiquid.TabIndex = 9;
      // 
      // Multiplier
      // 
      this.Multiplier.Location = new System.Drawing.Point(172, 177);
      this.Multiplier.Margin = new System.Windows.Forms.Padding(4);
      this.Multiplier.Name = "Multiplier";
      this.Multiplier.ReadOnly = true;
      this.Multiplier.Size = new System.Drawing.Size(132, 22);
      this.Multiplier.TabIndex = 12;
      // 
      // Liters15C
      // 
      this.Liters15C.Location = new System.Drawing.Point(172, 145);
      this.Liters15C.Margin = new System.Windows.Forms.Padding(4);
      this.Liters15C.Name = "Liters15C";
      this.Liters15C.ReadOnly = true;
      this.Liters15C.Size = new System.Drawing.Size(132, 22);
      this.Liters15C.TabIndex = 11;
      // 
      // volCorrectionFactor
      // 
      this.volCorrectionFactor.Location = new System.Drawing.Point(172, 113);
      this.volCorrectionFactor.Margin = new System.Windows.Forms.Padding(4);
      this.volCorrectionFactor.Name = "volCorrectionFactor";
      this.volCorrectionFactor.ReadOnly = true;
      this.volCorrectionFactor.Size = new System.Drawing.Size(132, 22);
      this.volCorrectionFactor.TabIndex = 10;
      // 
      // nettLiterProducLiquid
      // 
      this.nettLiterProducLiquid.Location = new System.Drawing.Point(172, 81);
      this.nettLiterProducLiquid.Margin = new System.Windows.Forms.Padding(4);
      this.nettLiterProducLiquid.Name = "nettLiterProducLiquid";
      this.nettLiterProducLiquid.ReadOnly = true;
      this.nettLiterProducLiquid.Size = new System.Drawing.Size(132, 22);
      this.nettLiterProducLiquid.TabIndex = 15;
      // 
      // density15C
      // 
      this.density15C.Location = new System.Drawing.Point(172, 49);
      this.density15C.Margin = new System.Windows.Forms.Padding(4);
      this.density15C.Name = "density15C";
      this.density15C.ReadOnly = true;
      this.density15C.Size = new System.Drawing.Size(132, 22);
      this.density15C.TabIndex = 14;
      // 
      // faktorKoreksiTemp
      // 
      this.faktorKoreksiTemp.Location = new System.Drawing.Point(172, 17);
      this.faktorKoreksiTemp.Margin = new System.Windows.Forms.Padding(4);
      this.faktorKoreksiTemp.Name = "faktorKoreksiTemp";
      this.faktorKoreksiTemp.ReadOnly = true;
      this.faktorKoreksiTemp.Size = new System.Drawing.Size(132, 22);
      this.faktorKoreksiTemp.TabIndex = 13;
      // 
      // Label14
      // 
      this.Label14.AutoSize = true;
      this.Label14.Location = new System.Drawing.Point(8, 213);
      this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label14.Name = "Label14";
      this.Label14.Size = new System.Drawing.Size(112, 17);
      this.Label14.TabIndex = 4;
      this.Label14.Text = "Kilograms Liquid";
      // 
      // Label13
      // 
      this.Label13.AutoSize = true;
      this.Label13.Location = new System.Drawing.Point(8, 181);
      this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(64, 17);
      this.Label13.TabIndex = 5;
      this.Label13.Text = "Multiplier";
      // 
      // Label12
      // 
      this.Label12.AutoSize = true;
      this.Label12.Location = new System.Drawing.Point(8, 149);
      this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label12.Name = "Label12";
      this.Label12.Size = new System.Drawing.Size(98, 17);
      this.Label12.TabIndex = 2;
      this.Label12.Text = "Liters at 15° C";
      // 
      // Label11
      // 
      this.Label11.AutoSize = true;
      this.Label11.Location = new System.Drawing.Point(8, 117);
      this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(145, 17);
      this.Label11.TabIndex = 3;
      this.Label11.Text = "Vol. Correction Factor";
      // 
      // Label10
      // 
      this.Label10.AutoSize = true;
      this.Label10.Location = new System.Drawing.Point(8, 85);
      this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(142, 17);
      this.Label10.TabIndex = 8;
      this.Label10.Text = "Nett Liters at Product";
      // 
      // Label9
      // 
      this.Label9.AutoSize = true;
      this.Label9.Location = new System.Drawing.Point(8, 53);
      this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(110, 17);
      this.Label9.TabIndex = 7;
      this.Label9.Text = "Density at 15° C";
      // 
      // Label8
      // 
      this.Label8.AutoSize = true;
      this.Label8.Location = new System.Drawing.Point(8, 21);
      this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(139, 17);
      this.Label8.TabIndex = 6;
      this.Label8.Text = "Faktor Koreksi Temp";
      // 
      // Label23
      // 
      this.Label23.AutoSize = true;
      this.Label23.Location = new System.Drawing.Point(39, 726);
      this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Label23.Name = "Label23";
      this.Label23.Size = new System.Drawing.Size(106, 17);
      this.Label23.TabIndex = 5;
      this.Label23.Text = "Total Kilograms";
      // 
      // Panel4
      // 
      this.Panel4.BackColor = System.Drawing.Color.Silver;
      this.Panel4.Controls.Add(this.button1);
      this.Panel4.Controls.Add(this.btnLog);
      this.Panel4.Controls.Add(this.btnHide);
      this.Panel4.Controls.Add(this.btnRun);
      this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.Panel4.Location = new System.Drawing.Point(0, 802);
      this.Panel4.Margin = new System.Windows.Forms.Padding(4);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new System.Drawing.Size(1467, 37);
      this.Panel4.TabIndex = 9;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(971, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // btnLog
      // 
      this.btnLog.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnLog.Location = new System.Drawing.Point(1053, 5);
      this.btnLog.Margin = new System.Windows.Forms.Padding(4);
      this.btnLog.Name = "btnLog";
      this.btnLog.Size = new System.Drawing.Size(124, 28);
      this.btnLog.TabIndex = 2;
      this.btnLog.Text = "Show Log";
      this.btnLog.UseVisualStyleBackColor = true;
      this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
      // 
      // btnHide
      // 
      this.btnHide.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnHide.Location = new System.Drawing.Point(1185, 5);
      this.btnHide.Margin = new System.Windows.Forms.Padding(4);
      this.btnHide.Name = "btnHide";
      this.btnHide.Size = new System.Drawing.Size(144, 28);
      this.btnHide.TabIndex = 1;
      this.btnHide.Text = "Hide Calculation";
      this.btnHide.UseVisualStyleBackColor = true;
      this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
      // 
      // btnRun
      // 
      this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnRun.Location = new System.Drawing.Point(1337, 5);
      this.btnRun.Margin = new System.Windows.Forms.Padding(4);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(100, 28);
      this.btnRun.TabIndex = 0;
      this.btnRun.Text = "Run";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // MenuStrip1
      // 
      this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.huToolStripMenuItem});
      this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
      this.MenuStrip1.Name = "MenuStrip1";
      this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
      this.MenuStrip1.Size = new System.Drawing.Size(1467, 28);
      this.MenuStrip1.TabIndex = 8;
      this.MenuStrip1.Text = "MenuStrip1";
      // 
      // FileToolStripMenuItem
      // 
      this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.TablesToolStripMenuItem,
            this.ExportToCsvToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem1});
      this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
      this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
      this.FileToolStripMenuItem.Text = "File";
      // 
      // SettingToolStripMenuItem
      // 
      this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
      this.SettingToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.SettingToolStripMenuItem.Text = "Setting";
      this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
      // 
      // TablesToolStripMenuItem
      // 
      this.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem";
      this.TablesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.TablesToolStripMenuItem.Text = "Tables";
      this.TablesToolStripMenuItem.Click += new System.EventHandler(this.TablesToolStripMenuItem_Click);
      // 
      // ExportToCsvToolStripMenuItem
      // 
      this.ExportToCsvToolStripMenuItem.Name = "ExportToCsvToolStripMenuItem";
      this.ExportToCsvToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.ExportToCsvToolStripMenuItem.Text = "Export to Csv";
      this.ExportToCsvToolStripMenuItem.Click += new System.EventHandler(this.ExportToCsvToolStripMenuItem_Click);
      // 
      // ToolStripSeparator1
      // 
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      this.ToolStripSeparator1.Size = new System.Drawing.Size(178, 6);
      // 
      // ExitToolStripMenuItem1
      // 
      this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
      this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
      this.ExitToolStripMenuItem1.Text = "Exit";
      this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
      // 
      // AboutToolStripMenuItem
      // 
      this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
      this.AboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
      this.AboutToolStripMenuItem.Text = "About";
      this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // StatusStrip1
      // 
      this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LevelStatus});
      this.StatusStrip1.Location = new System.Drawing.Point(0, 839);
      this.StatusStrip1.Name = "StatusStrip1";
      this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.StatusStrip1.Size = new System.Drawing.Size(1467, 25);
      this.StatusStrip1.TabIndex = 10;
      this.StatusStrip1.Text = "StatusStrip1";
      // 
      // LevelStatus
      // 
      this.LevelStatus.Name = "LevelStatus";
      this.LevelStatus.Size = new System.Drawing.Size(120, 20);
      this.LevelStatus.Text = "Tank Level Status";
      // 
      // SaveFileDialog1
      // 
      this.SaveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
      // 
      // menuLevel
      // 
      this.menuLevel.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuLevel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportCsvToolStripMenuItem});
      this.menuLevel.Name = "menu";
      this.menuLevel.Size = new System.Drawing.Size(148, 28);
      // 
      // ExportCsvToolStripMenuItem
      // 
      this.ExportCsvToolStripMenuItem.Name = "ExportCsvToolStripMenuItem";
      this.ExportCsvToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
      this.ExportCsvToolStripMenuItem.Text = "Export Csv";
      this.ExportCsvToolStripMenuItem.Click += new System.EventHandler(this.ExportCsvToolStripMenuItem_Click);
      // 
      // menuTemp
      // 
      this.menuTemp.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportCsvToolStripMenuItem1});
      this.menuTemp.Name = "menuTemp";
      this.menuTemp.Size = new System.Drawing.Size(148, 28);
      // 
      // ExportCsvToolStripMenuItem1
      // 
      this.ExportCsvToolStripMenuItem1.Name = "ExportCsvToolStripMenuItem1";
      this.ExportCsvToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
      this.ExportCsvToolStripMenuItem1.Text = "Export Csv";
      this.ExportCsvToolStripMenuItem1.Click += new System.EventHandler(this.ExportCsvToolStripMenuItem1_Click);
      // 
      // menuPress
      // 
      this.menuPress.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuPress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportCsvToolStripMenuItem2});
      this.menuPress.Name = "menuPress";
      this.menuPress.Size = new System.Drawing.Size(148, 28);
      // 
      // ExportCsvToolStripMenuItem2
      // 
      this.ExportCsvToolStripMenuItem2.Name = "ExportCsvToolStripMenuItem2";
      this.ExportCsvToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
      this.ExportCsvToolStripMenuItem2.Text = "Export Csv";
      this.ExportCsvToolStripMenuItem2.Click += new System.EventHandler(this.ExportCsvToolStripMenuItem2_Click);
      // 
      // NotifyIcon1
      // 
      this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
      this.NotifyIcon1.Text = "NotifyIcon1";
      this.NotifyIcon1.Visible = true;
      this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.textLog);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel8.Location = new System.Drawing.Point(0, 28);
      this.panel8.Margin = new System.Windows.Forms.Padding(4);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(1054, 774);
      this.panel8.TabIndex = 12;
      // 
      // textLog
      // 
      this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textLog.Location = new System.Drawing.Point(0, 0);
      this.textLog.Margin = new System.Windows.Forms.Padding(4);
      this.textLog.MaxLength = 32766;
      this.textLog.Multiline = true;
      this.textLog.Name = "textLog";
      this.textLog.ReadOnly = true;
      this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textLog.Size = new System.Drawing.Size(1054, 774);
      this.textLog.TabIndex = 0;
      this.textLog.WordWrap = false;
      // 
      // huToolStripMenuItem
      // 
      this.huToolStripMenuItem.Name = "huToolStripMenuItem";
      this.huToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
      this.huToolStripMenuItem.Text = "hu";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1467, 864);
      this.Controls.Add(this.SplitContainer1);
      this.Controls.Add(this.panel8);
      this.Controls.Add(this.Panel5);
      this.Controls.Add(this.Panel4);
      this.Controls.Add(this.MenuStrip1);
      this.Controls.Add(this.StatusStrip1);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
      this.SplitContainer1.ResumeLayout(false);
      this.SplitContainer3.Panel1.ResumeLayout(false);
      this.SplitContainer3.Panel2.ResumeLayout(false);
      this.SplitContainer3.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).EndInit();
      this.SplitContainer3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ChartLevel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableTangki)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.table54)).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.SplitContainer2.Panel1.ResumeLayout(false);
      this.SplitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
      this.SplitContainer2.ResumeLayout(false);
      this.SplitContainer4.Panel1.ResumeLayout(false);
      this.SplitContainer4.Panel2.ResumeLayout(false);
      this.SplitContainer4.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer4)).EndInit();
      this.SplitContainer4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.data_log_table)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).EndInit();
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.SplitContainer5.Panel1.ResumeLayout(false);
      this.SplitContainer5.Panel2.ResumeLayout(false);
      this.SplitContainer5.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SplitContainer5)).EndInit();
      this.SplitContainer5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ChartPressure)).EndInit();
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
      this.Panel5.ResumeLayout(false);
      this.Panel5.PerformLayout();
      this.Panel7.ResumeLayout(false);
      this.Panel7.PerformLayout();
      this.Panel6.ResumeLayout(false);
      this.Panel6.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.Panel4.ResumeLayout(false);
      this.MenuStrip1.ResumeLayout(false);
      this.MenuStrip1.PerformLayout();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.menuLevel.ResumeLayout(false);
      this.menuTemp.ResumeLayout(false);
      this.menuPress.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.SplitContainer SplitContainer3;
        internal AquaControls.AquaGauge gaugeLevel;
        internal System.Windows.Forms.CheckBox ChkTodayLevel;
        internal System.Windows.Forms.DateTimePicker DTLevel;
        internal System.Windows.Forms.DataGridView tableTangki;
        internal System.Windows.Forms.DataGridView table54;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.SplitContainer SplitContainer4;
        internal AquaControls.AquaGauge gaugeTemp;
        internal System.Windows.Forms.CheckBox ChkTodayTemp;
        internal System.Windows.Forms.DateTimePicker DTTemp;
        internal System.Windows.Forms.DataGridView dataGridExport;
        internal System.Windows.Forms.DataGridView data_log_table;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.SplitContainer SplitContainer5;
        internal AquaControls.AquaGauge gaugePressure;
        internal System.Windows.Forms.CheckBox ChkTodayPress;
        internal System.Windows.Forms.DateTimePicker DTPress;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.TextBox TotalKilograms;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.ComboBox cBoxDensity;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tBoxLevel;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tBoxPress;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tBoxTemp;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox kilogramsVapour;
        internal System.Windows.Forms.TextBox vapourDensity;
        internal System.Windows.Forms.TextBox TemperatureFactor;
        internal System.Windows.Forms.TextBox pressureFactor;
        internal System.Windows.Forms.TextBox nettLitersProductVapour;
        internal System.Windows.Forms.TextBox levelVapour;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox kilogramLiquid;
        internal System.Windows.Forms.TextBox Multiplier;
        internal System.Windows.Forms.TextBox Liters15C;
        internal System.Windows.Forms.TextBox volCorrectionFactor;
        internal System.Windows.Forms.TextBox nettLiterProducLiquid;
        internal System.Windows.Forms.TextBox density15C;
        internal System.Windows.Forms.TextBox faktorKoreksiTemp;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button btnRun;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TablesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportToCsvToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel LevelStatus;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartLevel;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartTemp;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartPressure;
        internal System.IO.Ports.SerialPort portCom;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.ContextMenuStrip menuLevel;
        internal System.Windows.Forms.ToolStripMenuItem ExportCsvToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip menuTemp;
        internal System.Windows.Forms.ToolStripMenuItem ExportCsvToolStripMenuItem1;
        internal System.Windows.Forms.ContextMenuStrip menuPress;
        internal System.Windows.Forms.ToolStripMenuItem ExportCsvToolStripMenuItem2;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button btnLog;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem huToolStripMenuItem;
  }
}

