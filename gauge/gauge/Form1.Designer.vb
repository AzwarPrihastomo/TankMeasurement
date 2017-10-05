Imports AquaControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
    Me.gaugeLevel = New AquaControls.AquaGauge()
    Me.ChkTodayLevel = New System.Windows.Forms.CheckBox()
    Me.DTLevel = New System.Windows.Forms.DateTimePicker()
    Me.ChartLevel = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.tableTangki = New System.Windows.Forms.DataGridView()
    Me.table54 = New System.Windows.Forms.DataGridView()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
    Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
    Me.gaugeTemp = New AquaControls.AquaGauge()
    Me.ChkTodayTemp = New System.Windows.Forms.CheckBox()
    Me.DTTemp = New System.Windows.Forms.DateTimePicker()
    Me.ChartTemp = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.dataGridExport = New System.Windows.Forms.DataGridView()
    Me.data_log_table = New System.Windows.Forms.DataGridView()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
    Me.gaugePressure = New AquaControls.AquaGauge()
    Me.ChkTodayPress = New System.Windows.Forms.CheckBox()
    Me.DTPress = New System.Windows.Forms.DateTimePicker()
    Me.ChartPressure = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.portCom = New System.IO.Ports.SerialPort(Me.components)
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportToCsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.btnRun = New System.Windows.Forms.Button()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.LevelStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.TempStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.PressStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.menuLevel = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ExportCsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.menuTemp = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ExportCsvToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.menuPress = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ExportCsvToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.TotalKilograms = New System.Windows.Forms.TextBox()
    Me.Panel7 = New System.Windows.Forms.Panel()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Panel6 = New System.Windows.Forms.Panel()
    Me.cBoxDensity = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.tBoxLevel = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.tBoxPress = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.tBoxTemp = New System.Windows.Forms.TextBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.kilogramsVapour = New System.Windows.Forms.TextBox()
    Me.vapourDensity = New System.Windows.Forms.TextBox()
    Me.TemperatureFactor = New System.Windows.Forms.TextBox()
    Me.pressureFactor = New System.Windows.Forms.TextBox()
    Me.nettLitersProductVapour = New System.Windows.Forms.TextBox()
    Me.levelVapour = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.kilogramLiquid = New System.Windows.Forms.TextBox()
    Me.Multiplier = New System.Windows.Forms.TextBox()
    Me.Liters15C = New System.Windows.Forms.TextBox()
    Me.volCorrectionFactor = New System.Windows.Forms.TextBox()
    Me.nettLiterProducLiquid = New System.Windows.Forms.TextBox()
    Me.density15C = New System.Windows.Forms.TextBox()
    Me.faktorKoreksiTemp = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.SystemStatus = New System.Windows.Forms.ToolStripStatusLabel()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer3.Panel1.SuspendLayout()
    Me.SplitContainer3.Panel2.SuspendLayout()
    Me.SplitContainer3.SuspendLayout()
    CType(Me.ChartLevel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tableTangki, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.table54, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer2.Panel1.SuspendLayout()
    Me.SplitContainer2.Panel2.SuspendLayout()
    Me.SplitContainer2.SuspendLayout()
    CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer4.Panel1.SuspendLayout()
    Me.SplitContainer4.Panel2.SuspendLayout()
    Me.SplitContainer4.SuspendLayout()
    CType(Me.ChartTemp, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dataGridExport, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.data_log_table, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer5.Panel1.SuspendLayout()
    Me.SplitContainer5.Panel2.SuspendLayout()
    Me.SplitContainer5.SuspendLayout()
    CType(Me.ChartPressure, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    Me.menuLevel.SuspendLayout()
    Me.menuTemp.SuspendLayout()
    Me.menuPress.SuspendLayout()
    Me.Panel5.SuspendLayout()
    Me.Panel7.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
    Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
    Me.SplitContainer1.Size = New System.Drawing.Size(1160, 792)
    Me.SplitContainer1.SplitterDistance = 256
    Me.SplitContainer1.SplitterWidth = 5
    Me.SplitContainer1.TabIndex = 2
    '
    'SplitContainer3
    '
    Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer3.Location = New System.Drawing.Point(0, 32)
    Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.SplitContainer3.Name = "SplitContainer3"
    '
    'SplitContainer3.Panel1
    '
    Me.SplitContainer3.Panel1.Controls.Add(Me.gaugeLevel)
    '
    'SplitContainer3.Panel2
    '
    Me.SplitContainer3.Panel2.Controls.Add(Me.ChkTodayLevel)
    Me.SplitContainer3.Panel2.Controls.Add(Me.DTLevel)
    Me.SplitContainer3.Panel2.Controls.Add(Me.ChartLevel)
    Me.SplitContainer3.Panel2.Controls.Add(Me.tableTangki)
    Me.SplitContainer3.Panel2.Controls.Add(Me.table54)
    Me.SplitContainer3.Size = New System.Drawing.Size(1160, 224)
    Me.SplitContainer3.SplitterDistance = 249
    Me.SplitContainer3.SplitterWidth = 5
    Me.SplitContainer3.TabIndex = 0
    '
    'gaugeLevel
    '
    Me.gaugeLevel.BackColor = System.Drawing.Color.Transparent
    Me.gaugeLevel.DialColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.gaugeLevel.DialText = Nothing
    Me.gaugeLevel.Dock = System.Windows.Forms.DockStyle.Top
    Me.gaugeLevel.Glossiness = 70.0!
    Me.gaugeLevel.Location = New System.Drawing.Point(0, 0)
    Me.gaugeLevel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.gaugeLevel.MaxValue = 100.0!
    Me.gaugeLevel.MinValue = 0!
    Me.gaugeLevel.Name = "gaugeLevel"
    Me.gaugeLevel.RecommendedValue = 1.0!
    Me.gaugeLevel.Size = New System.Drawing.Size(249, 249)
    Me.gaugeLevel.TabIndex = 1
    Me.gaugeLevel.ThresholdPercent = 0!
    Me.gaugeLevel.Value = 0!
    '
    'ChkTodayLevel
    '
    Me.ChkTodayLevel.AutoSize = True
    Me.ChkTodayLevel.Checked = True
    Me.ChkTodayLevel.CheckState = System.Windows.Forms.CheckState.Checked
    Me.ChkTodayLevel.Location = New System.Drawing.Point(55, 9)
    Me.ChkTodayLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChkTodayLevel.Name = "ChkTodayLevel"
    Me.ChkTodayLevel.Size = New System.Drawing.Size(70, 21)
    Me.ChkTodayLevel.TabIndex = 11
    Me.ChkTodayLevel.Text = "Today"
    Me.ChkTodayLevel.UseVisualStyleBackColor = True
    '
    'DTLevel
    '
    Me.DTLevel.Enabled = False
    Me.DTLevel.Location = New System.Drawing.Point(141, 7)
    Me.DTLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.DTLevel.Name = "DTLevel"
    Me.DTLevel.Size = New System.Drawing.Size(265, 22)
    Me.DTLevel.TabIndex = 10
    Me.DTLevel.Value = New Date(2012, 10, 23, 0, 0, 0, 0)
    '
    'ChartLevel
    '
    ChartArea1.Name = "ChartArea1"
    Me.ChartLevel.ChartAreas.Add(ChartArea1)
    Me.ChartLevel.Dock = System.Windows.Forms.DockStyle.Fill
    Legend1.Alignment = System.Drawing.StringAlignment.Far
    Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
    Legend1.Name = "Legend1"
    Me.ChartLevel.Legends.Add(Legend1)
    Me.ChartLevel.Location = New System.Drawing.Point(0, 0)
    Me.ChartLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChartLevel.Name = "ChartLevel"
    Series1.ChartArea = "ChartArea1"
    Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
    Series1.Color = System.Drawing.Color.Blue
    Series1.Legend = "Legend1"
    Series1.Name = "Tank Level"
    Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
    Me.ChartLevel.Series.Add(Series1)
    Me.ChartLevel.Size = New System.Drawing.Size(906, 224)
    Me.ChartLevel.TabIndex = 2
    Me.ChartLevel.Text = "Chart1"
    '
    'tableTangki
    '
    Me.tableTangki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.tableTangki.Location = New System.Drawing.Point(420, 33)
    Me.tableTangki.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.tableTangki.Name = "tableTangki"
    Me.tableTangki.Size = New System.Drawing.Size(320, 185)
    Me.tableTangki.TabIndex = 12
    '
    'table54
    '
    Me.table54.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.table54.Location = New System.Drawing.Point(55, 33)
    Me.table54.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.table54.Name = "table54"
    Me.table54.Size = New System.Drawing.Size(320, 185)
    Me.table54.TabIndex = 12
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Silver
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1160, 32)
    Me.Panel1.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(467, 9)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(148, 20)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tank Level ( % )"
    '
    'SplitContainer2
    '
    Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.SplitContainer2.Name = "SplitContainer2"
    Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer2.Panel1
    '
    Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer4)
    Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
    '
    'SplitContainer2.Panel2
    '
    Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer5)
    Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
    Me.SplitContainer2.Size = New System.Drawing.Size(1160, 531)
    Me.SplitContainer2.SplitterDistance = 259
    Me.SplitContainer2.SplitterWidth = 5
    Me.SplitContainer2.TabIndex = 0
    '
    'SplitContainer4
    '
    Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer4.Location = New System.Drawing.Point(0, 32)
    Me.SplitContainer4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.SplitContainer4.Name = "SplitContainer4"
    '
    'SplitContainer4.Panel1
    '
    Me.SplitContainer4.Panel1.Controls.Add(Me.gaugeTemp)
    '
    'SplitContainer4.Panel2
    '
    Me.SplitContainer4.Panel2.Controls.Add(Me.ChkTodayTemp)
    Me.SplitContainer4.Panel2.Controls.Add(Me.DTTemp)
    Me.SplitContainer4.Panel2.Controls.Add(Me.ChartTemp)
    Me.SplitContainer4.Panel2.Controls.Add(Me.dataGridExport)
    Me.SplitContainer4.Panel2.Controls.Add(Me.data_log_table)
    Me.SplitContainer4.Size = New System.Drawing.Size(1160, 227)
    Me.SplitContainer4.SplitterDistance = 249
    Me.SplitContainer4.SplitterWidth = 5
    Me.SplitContainer4.TabIndex = 0
    '
    'gaugeTemp
    '
    Me.gaugeTemp.BackColor = System.Drawing.Color.Transparent
    Me.gaugeTemp.DialColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.gaugeTemp.DialText = Nothing
    Me.gaugeTemp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gaugeTemp.Glossiness = 70.0!
    Me.gaugeTemp.Location = New System.Drawing.Point(0, 0)
    Me.gaugeTemp.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.gaugeTemp.MaxValue = 200.0!
    Me.gaugeTemp.MinValue = 0!
    Me.gaugeTemp.Name = "gaugeTemp"
    Me.gaugeTemp.RecommendedValue = 0!
    Me.gaugeTemp.Size = New System.Drawing.Size(249, 249)
    Me.gaugeTemp.TabIndex = 1
    Me.gaugeTemp.ThresholdPercent = 0!
    Me.gaugeTemp.Value = 0!
    '
    'ChkTodayTemp
    '
    Me.ChkTodayTemp.AutoSize = True
    Me.ChkTodayTemp.Checked = True
    Me.ChkTodayTemp.CheckState = System.Windows.Forms.CheckState.Checked
    Me.ChkTodayTemp.Location = New System.Drawing.Point(55, 9)
    Me.ChkTodayTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChkTodayTemp.Name = "ChkTodayTemp"
    Me.ChkTodayTemp.Size = New System.Drawing.Size(70, 21)
    Me.ChkTodayTemp.TabIndex = 11
    Me.ChkTodayTemp.Text = "Today"
    Me.ChkTodayTemp.UseVisualStyleBackColor = True
    '
    'DTTemp
    '
    Me.DTTemp.Enabled = False
    Me.DTTemp.Location = New System.Drawing.Point(141, 7)
    Me.DTTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.DTTemp.Name = "DTTemp"
    Me.DTTemp.Size = New System.Drawing.Size(265, 22)
    Me.DTTemp.TabIndex = 10
    Me.DTTemp.Value = New Date(2012, 10, 23, 0, 0, 0, 0)
    '
    'ChartTemp
    '
    ChartArea2.Name = "ChartArea1"
    Me.ChartTemp.ChartAreas.Add(ChartArea2)
    Me.ChartTemp.Dock = System.Windows.Forms.DockStyle.Fill
    Legend2.Alignment = System.Drawing.StringAlignment.Far
    Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
    Legend2.Name = "Legend1"
    Me.ChartTemp.Legends.Add(Legend2)
    Me.ChartTemp.Location = New System.Drawing.Point(0, 0)
    Me.ChartTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChartTemp.Name = "ChartTemp"
    Series2.ChartArea = "ChartArea1"
    Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
    Series2.Color = System.Drawing.Color.SeaGreen
    Series2.Legend = "Legend1"
    Series2.Name = "Temperature"
    Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
    Me.ChartTemp.Series.Add(Series2)
    Me.ChartTemp.Size = New System.Drawing.Size(906, 227)
    Me.ChartTemp.TabIndex = 3
    Me.ChartTemp.Text = "Chart1"
    '
    'dataGridExport
    '
    Me.dataGridExport.AllowUserToAddRows = False
    Me.dataGridExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dataGridExport.Location = New System.Drawing.Point(371, 9)
    Me.dataGridExport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.dataGridExport.Name = "dataGridExport"
    Me.dataGridExport.Size = New System.Drawing.Size(301, 181)
    Me.dataGridExport.TabIndex = 12
    Me.dataGridExport.Visible = False
    '
    'data_log_table
    '
    Me.data_log_table.AllowUserToAddRows = False
    Me.data_log_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.data_log_table.Location = New System.Drawing.Point(35, 9)
    Me.data_log_table.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.data_log_table.Name = "data_log_table"
    Me.data_log_table.Size = New System.Drawing.Size(301, 181)
    Me.data_log_table.TabIndex = 12
    Me.data_log_table.Visible = False
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.Silver
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1160, 32)
    Me.Panel2.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(433, 9)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(204, 20)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "TEMPERATURE ( ° C )"
    '
    'SplitContainer5
    '
    Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer5.Location = New System.Drawing.Point(0, 32)
    Me.SplitContainer5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.SplitContainer5.Name = "SplitContainer5"
    '
    'SplitContainer5.Panel1
    '
    Me.SplitContainer5.Panel1.Controls.Add(Me.gaugePressure)
    '
    'SplitContainer5.Panel2
    '
    Me.SplitContainer5.Panel2.Controls.Add(Me.ChkTodayPress)
    Me.SplitContainer5.Panel2.Controls.Add(Me.DTPress)
    Me.SplitContainer5.Panel2.Controls.Add(Me.ChartPressure)
    Me.SplitContainer5.Panel2.Controls.Add(Me.Chart3)
    Me.SplitContainer5.Size = New System.Drawing.Size(1160, 235)
    Me.SplitContainer5.SplitterDistance = 253
    Me.SplitContainer5.SplitterWidth = 5
    Me.SplitContainer5.TabIndex = 0
    '
    'gaugePressure
    '
    Me.gaugePressure.BackColor = System.Drawing.Color.Transparent
    Me.gaugePressure.DialColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.gaugePressure.DialText = Nothing
    Me.gaugePressure.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gaugePressure.Glossiness = 70.0!
    Me.gaugePressure.Location = New System.Drawing.Point(0, 0)
    Me.gaugePressure.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.gaugePressure.MaxValue = 200.0!
    Me.gaugePressure.MinValue = 0!
    Me.gaugePressure.Name = "gaugePressure"
    Me.gaugePressure.RecommendedValue = 0!
    Me.gaugePressure.Size = New System.Drawing.Size(253, 253)
    Me.gaugePressure.TabIndex = 1
    Me.gaugePressure.ThresholdPercent = 0!
    Me.gaugePressure.Value = 0!
    '
    'ChkTodayPress
    '
    Me.ChkTodayPress.AutoSize = True
    Me.ChkTodayPress.Checked = True
    Me.ChkTodayPress.CheckState = System.Windows.Forms.CheckState.Checked
    Me.ChkTodayPress.Location = New System.Drawing.Point(51, 9)
    Me.ChkTodayPress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChkTodayPress.Name = "ChkTodayPress"
    Me.ChkTodayPress.Size = New System.Drawing.Size(70, 21)
    Me.ChkTodayPress.TabIndex = 11
    Me.ChkTodayPress.Text = "Today"
    Me.ChkTodayPress.UseVisualStyleBackColor = True
    '
    'DTPress
    '
    Me.DTPress.Enabled = False
    Me.DTPress.Location = New System.Drawing.Point(137, 7)
    Me.DTPress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.DTPress.Name = "DTPress"
    Me.DTPress.Size = New System.Drawing.Size(265, 22)
    Me.DTPress.TabIndex = 10
    Me.DTPress.Value = New Date(2012, 10, 23, 0, 0, 0, 0)
    '
    'ChartPressure
    '
    ChartArea3.Name = "ChartArea1"
    Me.ChartPressure.ChartAreas.Add(ChartArea3)
    Me.ChartPressure.Dock = System.Windows.Forms.DockStyle.Fill
    Legend3.Alignment = System.Drawing.StringAlignment.Far
    Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
    Legend3.Name = "Legend1"
    Me.ChartPressure.Legends.Add(Legend3)
    Me.ChartPressure.Location = New System.Drawing.Point(0, 0)
    Me.ChartPressure.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.ChartPressure.Name = "ChartPressure"
    Series3.ChartArea = "ChartArea1"
    Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
    Series3.Color = System.Drawing.Color.BlueViolet
    Series3.Legend = "Legend1"
    Series3.Name = "Pressure"
    Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
    Me.ChartPressure.Series.Add(Series3)
    Me.ChartPressure.Size = New System.Drawing.Size(902, 235)
    Me.ChartPressure.TabIndex = 4
    Me.ChartPressure.Text = "Chart1"
    '
    'Chart3
    '
    ChartArea4.Name = "ChartArea1"
    Me.Chart3.ChartAreas.Add(ChartArea4)
    Me.Chart3.Dock = System.Windows.Forms.DockStyle.Fill
    Legend4.Alignment = System.Drawing.StringAlignment.Far
    Legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
    Legend4.Name = "Legend1"
    Me.Chart3.Legends.Add(Legend4)
    Me.Chart3.Location = New System.Drawing.Point(0, 0)
    Me.Chart3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Chart3.Name = "Chart3"
    Me.Chart3.Size = New System.Drawing.Size(902, 235)
    Me.Chart3.TabIndex = 3
    Me.Chart3.Text = "Chart3"
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.Color.Silver
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(1160, 32)
    Me.Panel3.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(467, 9)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(172, 20)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "PRESSURE ( Kpa )"
    '
    'portCom
    '
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
    Me.MenuStrip1.Size = New System.Drawing.Size(1573, 28)
    Me.MenuStrip1.TabIndex = 3
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.TablesToolStripMenuItem, Me.ExportToCsvToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'SettingToolStripMenuItem
    '
    Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
    Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
    Me.SettingToolStripMenuItem.Text = "Setting"
    '
    'TablesToolStripMenuItem
    '
    Me.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem"
    Me.TablesToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
    Me.TablesToolStripMenuItem.Text = "Tables"
    '
    'ExportToCsvToolStripMenuItem
    '
    Me.ExportToCsvToolStripMenuItem.Name = "ExportToCsvToolStripMenuItem"
    Me.ExportToCsvToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
    Me.ExportToCsvToolStripMenuItem.Text = "Export to Csv"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
    '
    'ExitToolStripMenuItem1
    '
    Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
    Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(171, 26)
    Me.ExitToolStripMenuItem1.Text = "Exit"
    '
    'AboutToolStripMenuItem
    '
    Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
    Me.AboutToolStripMenuItem.Text = "About"
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.Color.Silver
    Me.Panel4.Controls.Add(Me.Button1)
    Me.Panel4.Controls.Add(Me.btnRun)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel4.Location = New System.Drawing.Point(0, 820)
    Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(1573, 37)
    Me.Panel4.TabIndex = 4
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(1324, 5)
    Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(100, 28)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    Me.Button1.Visible = False
    '
    'btnRun
    '
    Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Right
    Me.btnRun.Location = New System.Drawing.Point(1444, 5)
    Me.btnRun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnRun.Name = "btnRun"
    Me.btnRun.Size = New System.Drawing.Size(100, 28)
    Me.btnRun.TabIndex = 0
    Me.btnRun.Text = "Run"
    Me.btnRun.UseVisualStyleBackColor = True
    '
    'StatusStrip1
    '
    Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemStatus, Me.LevelStatus, Me.TempStatus, Me.PressStatus})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 857)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
    Me.StatusStrip1.Size = New System.Drawing.Size(1573, 25)
    Me.StatusStrip1.TabIndex = 5
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'LevelStatus
    '
    Me.LevelStatus.Name = "LevelStatus"
    Me.LevelStatus.Size = New System.Drawing.Size(120, 20)
    Me.LevelStatus.Text = "Tank Level Status"
    '
    'TempStatus
    '
    Me.TempStatus.Name = "TempStatus"
    Me.TempStatus.Size = New System.Drawing.Size(170, 20)
    Me.TempStatus.Text = "Tank Temperature Status"
    '
    'PressStatus
    '
    Me.PressStatus.Name = "PressStatus"
    Me.PressStatus.Size = New System.Drawing.Size(140, 20)
    Me.PressStatus.Text = "Tank Pressure Status"
    '
    'Timer1
    '
    Me.Timer1.Interval = 50
    '
    'menuLevel
    '
    Me.menuLevel.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.menuLevel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCsvToolStripMenuItem})
    Me.menuLevel.Name = "menu"
    Me.menuLevel.Size = New System.Drawing.Size(148, 28)
    '
    'ExportCsvToolStripMenuItem
    '
    Me.ExportCsvToolStripMenuItem.Name = "ExportCsvToolStripMenuItem"
    Me.ExportCsvToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
    Me.ExportCsvToolStripMenuItem.Text = "Export Csv"
    '
    'menuTemp
    '
    Me.menuTemp.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.menuTemp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCsvToolStripMenuItem1})
    Me.menuTemp.Name = "menuTemp"
    Me.menuTemp.Size = New System.Drawing.Size(148, 28)
    '
    'ExportCsvToolStripMenuItem1
    '
    Me.ExportCsvToolStripMenuItem1.Name = "ExportCsvToolStripMenuItem1"
    Me.ExportCsvToolStripMenuItem1.Size = New System.Drawing.Size(147, 24)
    Me.ExportCsvToolStripMenuItem1.Text = "Export Csv"
    '
    'menuPress
    '
    Me.menuPress.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.menuPress.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCsvToolStripMenuItem2})
    Me.menuPress.Name = "menuPress"
    Me.menuPress.Size = New System.Drawing.Size(148, 28)
    '
    'ExportCsvToolStripMenuItem2
    '
    Me.ExportCsvToolStripMenuItem2.Name = "ExportCsvToolStripMenuItem2"
    Me.ExportCsvToolStripMenuItem2.Size = New System.Drawing.Size(147, 24)
    Me.ExportCsvToolStripMenuItem2.Text = "Export Csv"
    '
    'SaveFileDialog1
    '
    Me.SaveFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
    '
    'NotifyIcon1
    '
    Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
    Me.NotifyIcon1.Text = "NotifyIcon1"
    Me.NotifyIcon1.Visible = True
    '
    'Panel5
    '
    Me.Panel5.Controls.Add(Me.TotalKilograms)
    Me.Panel5.Controls.Add(Me.Panel7)
    Me.Panel5.Controls.Add(Me.Panel6)
    Me.Panel5.Controls.Add(Me.GroupBox2)
    Me.Panel5.Controls.Add(Me.GroupBox1)
    Me.Panel5.Controls.Add(Me.Label23)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
    Me.Panel5.Location = New System.Drawing.Point(1160, 28)
    Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(413, 792)
    Me.Panel5.TabIndex = 6
    '
    'TotalKilograms
    '
    Me.TotalKilograms.Location = New System.Drawing.Point(203, 722)
    Me.TotalKilograms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TotalKilograms.Name = "TotalKilograms"
    Me.TotalKilograms.Size = New System.Drawing.Size(132, 22)
    Me.TotalKilograms.TabIndex = 12
    '
    'Panel7
    '
    Me.Panel7.BackColor = System.Drawing.Color.Silver
    Me.Panel7.Controls.Add(Me.Label22)
    Me.Panel7.Controls.Add(Me.Label15)
    Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel7.Location = New System.Drawing.Point(0, 0)
    Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(413, 32)
    Me.Panel7.TabIndex = 4
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label22.Location = New System.Drawing.Point(128, 9)
    Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(103, 20)
    Me.Label22.TabIndex = 0
    Me.Label22.Text = "Calculation"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.Location = New System.Drawing.Point(467, 9)
    Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(148, 20)
    Me.Label15.TabIndex = 0
    Me.Label15.Text = "Tank Level ( % )"
    '
    'Panel6
    '
    Me.Panel6.Controls.Add(Me.cBoxDensity)
    Me.Panel6.Controls.Add(Me.Label4)
    Me.Panel6.Controls.Add(Me.Label5)
    Me.Panel6.Controls.Add(Me.tBoxLevel)
    Me.Panel6.Controls.Add(Me.Label6)
    Me.Panel6.Controls.Add(Me.tBoxPress)
    Me.Panel6.Controls.Add(Me.Label7)
    Me.Panel6.Controls.Add(Me.tBoxTemp)
    Me.Panel6.Location = New System.Drawing.Point(31, 52)
    Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(332, 154)
    Me.Panel6.TabIndex = 3
    '
    'cBoxDensity
    '
    Me.cBoxDensity.FormattingEnabled = True
    Me.cBoxDensity.Location = New System.Drawing.Point(172, 111)
    Me.cBoxDensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.cBoxDensity.Name = "cBoxDensity"
    Me.cBoxDensity.Size = New System.Drawing.Size(132, 24)
    Me.cBoxDensity.TabIndex = 2
    Me.cBoxDensity.Text = "0.510"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(16, 17)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(118, 17)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Level Liquid ( % )"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(16, 49)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(131, 17)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Temperature ( ° C )"
    '
    'tBoxLevel
    '
    Me.tBoxLevel.Location = New System.Drawing.Point(172, 14)
    Me.tBoxLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.tBoxLevel.Name = "tBoxLevel"
    Me.tBoxLevel.Size = New System.Drawing.Size(132, 22)
    Me.tBoxLevel.TabIndex = 1
    Me.tBoxLevel.Text = "70"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(16, 81)
    Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(112, 17)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Pressure ( Kpa )"
    '
    'tBoxPress
    '
    Me.tBoxPress.Location = New System.Drawing.Point(172, 78)
    Me.tBoxPress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.tBoxPress.Name = "tBoxPress"
    Me.tBoxPress.Size = New System.Drawing.Size(132, 22)
    Me.tBoxPress.TabIndex = 1
    Me.tBoxPress.Text = "15"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(16, 114)
    Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(55, 17)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Density"
    '
    'tBoxTemp
    '
    Me.tBoxTemp.Location = New System.Drawing.Point(172, 46)
    Me.tBoxTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.tBoxTemp.Name = "tBoxTemp"
    Me.tBoxTemp.Size = New System.Drawing.Size(132, 22)
    Me.tBoxTemp.TabIndex = 1
    Me.tBoxTemp.Text = "30"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.kilogramsVapour)
    Me.GroupBox2.Controls.Add(Me.vapourDensity)
    Me.GroupBox2.Controls.Add(Me.TemperatureFactor)
    Me.GroupBox2.Controls.Add(Me.pressureFactor)
    Me.GroupBox2.Controls.Add(Me.nettLitersProductVapour)
    Me.GroupBox2.Controls.Add(Me.levelVapour)
    Me.GroupBox2.Controls.Add(Me.Label16)
    Me.GroupBox2.Controls.Add(Me.Label17)
    Me.GroupBox2.Controls.Add(Me.Label18)
    Me.GroupBox2.Controls.Add(Me.Label19)
    Me.GroupBox2.Controls.Add(Me.Label20)
    Me.GroupBox2.Controls.Add(Me.Label21)
    Me.GroupBox2.Location = New System.Drawing.Point(31, 478)
    Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox2.Size = New System.Drawing.Size(332, 222)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    '
    'kilogramsVapour
    '
    Me.kilogramsVapour.Location = New System.Drawing.Point(172, 177)
    Me.kilogramsVapour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.kilogramsVapour.Name = "kilogramsVapour"
    Me.kilogramsVapour.Size = New System.Drawing.Size(132, 22)
    Me.kilogramsVapour.TabIndex = 12
    '
    'vapourDensity
    '
    Me.vapourDensity.Location = New System.Drawing.Point(172, 145)
    Me.vapourDensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.vapourDensity.Name = "vapourDensity"
    Me.vapourDensity.Size = New System.Drawing.Size(132, 22)
    Me.vapourDensity.TabIndex = 11
    '
    'TemperatureFactor
    '
    Me.TemperatureFactor.Location = New System.Drawing.Point(172, 113)
    Me.TemperatureFactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TemperatureFactor.Name = "TemperatureFactor"
    Me.TemperatureFactor.Size = New System.Drawing.Size(132, 22)
    Me.TemperatureFactor.TabIndex = 10
    '
    'pressureFactor
    '
    Me.pressureFactor.Location = New System.Drawing.Point(172, 81)
    Me.pressureFactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.pressureFactor.Name = "pressureFactor"
    Me.pressureFactor.Size = New System.Drawing.Size(132, 22)
    Me.pressureFactor.TabIndex = 15
    '
    'nettLitersProductVapour
    '
    Me.nettLitersProductVapour.Location = New System.Drawing.Point(172, 49)
    Me.nettLitersProductVapour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.nettLitersProductVapour.Name = "nettLitersProductVapour"
    Me.nettLitersProductVapour.Size = New System.Drawing.Size(132, 22)
    Me.nettLitersProductVapour.TabIndex = 14
    '
    'levelVapour
    '
    Me.levelVapour.Location = New System.Drawing.Point(172, 17)
    Me.levelVapour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.levelVapour.Name = "levelVapour"
    Me.levelVapour.Size = New System.Drawing.Size(132, 22)
    Me.levelVapour.TabIndex = 13
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(8, 181)
    Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(120, 17)
    Me.Label16.TabIndex = 5
    Me.Label16.Text = "Kilograms Vapour"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(8, 149)
    Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(105, 17)
    Me.Label17.TabIndex = 2
    Me.Label17.Text = "Vapour Density"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(8, 117)
    Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(126, 17)
    Me.Label18.TabIndex = 3
    Me.Label18.Text = "Temperatur Factor"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(8, 85)
    Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(109, 17)
    Me.Label19.TabIndex = 8
    Me.Label19.Text = "Pressure Factor"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(8, 53)
    Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(142, 17)
    Me.Label20.TabIndex = 7
    Me.Label20.Text = "Nett Liters at Product"
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Location = New System.Drawing.Point(8, 21)
    Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(92, 17)
    Me.Label21.TabIndex = 6
    Me.Label21.Text = "Level Vapour"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.kilogramLiquid)
    Me.GroupBox1.Controls.Add(Me.Multiplier)
    Me.GroupBox1.Controls.Add(Me.Liters15C)
    Me.GroupBox1.Controls.Add(Me.volCorrectionFactor)
    Me.GroupBox1.Controls.Add(Me.nettLiterProducLiquid)
    Me.GroupBox1.Controls.Add(Me.density15C)
    Me.GroupBox1.Controls.Add(Me.faktorKoreksiTemp)
    Me.GroupBox1.Controls.Add(Me.Label14)
    Me.GroupBox1.Controls.Add(Me.Label13)
    Me.GroupBox1.Controls.Add(Me.Label12)
    Me.GroupBox1.Controls.Add(Me.Label11)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Location = New System.Drawing.Point(31, 213)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.GroupBox1.Size = New System.Drawing.Size(332, 257)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    '
    'kilogramLiquid
    '
    Me.kilogramLiquid.Location = New System.Drawing.Point(172, 209)
    Me.kilogramLiquid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.kilogramLiquid.Name = "kilogramLiquid"
    Me.kilogramLiquid.Size = New System.Drawing.Size(132, 22)
    Me.kilogramLiquid.TabIndex = 9
    '
    'Multiplier
    '
    Me.Multiplier.Location = New System.Drawing.Point(172, 177)
    Me.Multiplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Multiplier.Name = "Multiplier"
    Me.Multiplier.Size = New System.Drawing.Size(132, 22)
    Me.Multiplier.TabIndex = 12
    '
    'Liters15C
    '
    Me.Liters15C.Location = New System.Drawing.Point(172, 145)
    Me.Liters15C.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Liters15C.Name = "Liters15C"
    Me.Liters15C.Size = New System.Drawing.Size(132, 22)
    Me.Liters15C.TabIndex = 11
    '
    'volCorrectionFactor
    '
    Me.volCorrectionFactor.Location = New System.Drawing.Point(172, 113)
    Me.volCorrectionFactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.volCorrectionFactor.Name = "volCorrectionFactor"
    Me.volCorrectionFactor.Size = New System.Drawing.Size(132, 22)
    Me.volCorrectionFactor.TabIndex = 10
    '
    'nettLiterProducLiquid
    '
    Me.nettLiterProducLiquid.Location = New System.Drawing.Point(172, 81)
    Me.nettLiterProducLiquid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.nettLiterProducLiquid.Name = "nettLiterProducLiquid"
    Me.nettLiterProducLiquid.Size = New System.Drawing.Size(132, 22)
    Me.nettLiterProducLiquid.TabIndex = 15
    '
    'density15C
    '
    Me.density15C.Location = New System.Drawing.Point(172, 49)
    Me.density15C.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.density15C.Name = "density15C"
    Me.density15C.Size = New System.Drawing.Size(132, 22)
    Me.density15C.TabIndex = 14
    '
    'faktorKoreksiTemp
    '
    Me.faktorKoreksiTemp.Location = New System.Drawing.Point(172, 17)
    Me.faktorKoreksiTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.faktorKoreksiTemp.Name = "faktorKoreksiTemp"
    Me.faktorKoreksiTemp.Size = New System.Drawing.Size(132, 22)
    Me.faktorKoreksiTemp.TabIndex = 13
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(8, 213)
    Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(112, 17)
    Me.Label14.TabIndex = 4
    Me.Label14.Text = "Kilograms Liquid"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(8, 181)
    Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(64, 17)
    Me.Label13.TabIndex = 5
    Me.Label13.Text = "Multiplier"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(8, 149)
    Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(98, 17)
    Me.Label12.TabIndex = 2
    Me.Label12.Text = "Liters at 15° C"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(8, 117)
    Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(145, 17)
    Me.Label11.TabIndex = 3
    Me.Label11.Text = "Vol. Correction Factor"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(8, 85)
    Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(142, 17)
    Me.Label10.TabIndex = 8
    Me.Label10.Text = "Nett Liters at Product"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(8, 53)
    Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(110, 17)
    Me.Label9.TabIndex = 7
    Me.Label9.Text = "Density at 15° C"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(8, 21)
    Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(139, 17)
    Me.Label8.TabIndex = 6
    Me.Label8.Text = "Faktor Koreksi Temp"
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(39, 726)
    Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(106, 17)
    Me.Label23.TabIndex = 5
    Me.Label23.Text = "Total Kilograms"
    '
    'SystemStatus
    '
    Me.SystemStatus.Name = "SystemStatus"
    Me.SystemStatus.Size = New System.Drawing.Size(39, 20)
    Me.SystemStatus.Text = "IDLE"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1573, 882)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.Panel5)
    Me.Controls.Add(Me.Panel4)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.Name = "Form1"
    Me.Text = "Monitoring"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.SplitContainer3.Panel1.ResumeLayout(False)
    Me.SplitContainer3.Panel2.ResumeLayout(False)
    Me.SplitContainer3.Panel2.PerformLayout()
    CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer3.ResumeLayout(False)
    CType(Me.ChartLevel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tableTangki, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.table54, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.SplitContainer2.Panel1.ResumeLayout(False)
    Me.SplitContainer2.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer2.ResumeLayout(False)
    Me.SplitContainer4.Panel1.ResumeLayout(False)
    Me.SplitContainer4.Panel2.ResumeLayout(False)
    Me.SplitContainer4.Panel2.PerformLayout()
    CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer4.ResumeLayout(False)
    CType(Me.ChartTemp, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dataGridExport, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.data_log_table, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.SplitContainer5.Panel1.ResumeLayout(False)
    Me.SplitContainer5.Panel2.ResumeLayout(False)
    Me.SplitContainer5.Panel2.PerformLayout()
    CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer5.ResumeLayout(False)
    CType(Me.ChartPressure, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.menuLevel.ResumeLayout(False)
    Me.menuTemp.ResumeLayout(False)
    Me.menuPress.ResumeLayout(False)
    Me.Panel5.ResumeLayout(False)
    Me.Panel5.PerformLayout()
    Me.Panel7.ResumeLayout(False)
    Me.Panel7.PerformLayout()
    Me.Panel6.ResumeLayout(False)
    Me.Panel6.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents gaugeLevel As AquaControls.AquaGauge
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents gaugeTemp As AquaControls.AquaGauge
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents gaugePressure As AquaControls.AquaGauge
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartLevel As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents portCom As System.IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartPressure As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ChartTemp As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChkTodayLevel As System.Windows.Forms.CheckBox
    Friend WithEvents DTLevel As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkTodayTemp As System.Windows.Forms.CheckBox
    Friend WithEvents DTTemp As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkTodayPress As System.Windows.Forms.CheckBox
    Friend WithEvents DTPress As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents data_log_table As System.Windows.Forms.DataGridView
    Friend WithEvents LevelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TempStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PressStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuLevel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportCsvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToCsvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTemp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuPress As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportCsvToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportCsvToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dataGridExport As System.Windows.Forms.DataGridView
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBoxPress As System.Windows.Forms.TextBox
    Friend WithEvents tBoxTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBoxLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kilogramLiquid As System.Windows.Forms.TextBox
    Friend WithEvents Multiplier As System.Windows.Forms.TextBox
    Friend WithEvents Liters15C As System.Windows.Forms.TextBox
    Friend WithEvents volCorrectionFactor As System.Windows.Forms.TextBox
    Friend WithEvents nettLiterProducLiquid As System.Windows.Forms.TextBox
    Friend WithEvents density15C As System.Windows.Forms.TextBox
    Friend WithEvents faktorKoreksiTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kilogramsVapour As System.Windows.Forms.TextBox
    Friend WithEvents vapourDensity As System.Windows.Forms.TextBox
    Friend WithEvents TemperatureFactor As System.Windows.Forms.TextBox
    Friend WithEvents pressureFactor As System.Windows.Forms.TextBox
    Friend WithEvents nettLitersProductVapour As System.Windows.Forms.TextBox
    Friend WithEvents levelVapour As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TotalKilograms As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tableTangki As System.Windows.Forms.DataGridView
    Friend WithEvents table54 As System.Windows.Forms.DataGridView
    Friend WithEvents cBoxDensity As System.Windows.Forms.ComboBox
  Friend WithEvents SystemStatus As ToolStripStatusLabel
End Class
