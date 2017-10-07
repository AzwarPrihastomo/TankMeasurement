<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setting))
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.idLevel = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.maxValLevel = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.portComName = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.idTemp = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.maxValTemp = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.idPress = New System.Windows.Forms.TextBox()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.maxValPress = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.reqComTimeOut = New System.Windows.Forms.TextBox()
    Me.reqTimeOut = New System.Windows.Forms.TextBox()
    Me.reqRawCommand = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.ComReqRetry = New System.Windows.Forms.TextBox()
    Me.reqDataCommand = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.update_period = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.GroupBox5 = New System.Windows.Forms.GroupBox()
    Me.database_name = New System.Windows.Forms.TextBox()
    Me.master_pass = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.master_user = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.sql_address = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.usePredCheck = New System.Windows.Forms.CheckBox()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox5.SuspendLayout()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.idLevel)
    Me.GroupBox1.Controls.Add(Me.Label15)
    Me.GroupBox1.Controls.Add(Me.maxValLevel)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Location = New System.Drawing.Point(414, 18)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox1.Size = New System.Drawing.Size(291, 126)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Tank Level"
    '
    'idLevel
    '
    Me.idLevel.Location = New System.Drawing.Point(112, 69)
    Me.idLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.idLevel.Name = "idLevel"
    Me.idLevel.Size = New System.Drawing.Size(148, 26)
    Me.idLevel.TabIndex = 1
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(9, 74)
    Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(69, 20)
    Me.Label15.TabIndex = 0
    Me.Label15.Text = "Id Name"
    '
    'maxValLevel
    '
    Me.maxValLevel.Location = New System.Drawing.Point(112, 29)
    Me.maxValLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.maxValLevel.Name = "maxValLevel"
    Me.maxValLevel.Size = New System.Drawing.Size(148, 26)
    Me.maxValLevel.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 34)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(83, 20)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Max Value"
    '
    'portComName
    '
    Me.portComName.FormattingEnabled = True
    Me.portComName.Location = New System.Drawing.Point(158, 278)
    Me.portComName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.portComName.Name = "portComName"
    Me.portComName.Size = New System.Drawing.Size(148, 28)
    Me.portComName.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 283)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(75, 20)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Com Port"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.idTemp)
    Me.GroupBox2.Controls.Add(Me.Label16)
    Me.GroupBox2.Controls.Add(Me.maxValTemp)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Location = New System.Drawing.Point(414, 154)
    Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox2.Size = New System.Drawing.Size(291, 122)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Temperature"
    '
    'idTemp
    '
    Me.idTemp.Location = New System.Drawing.Point(112, 69)
    Me.idTemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.idTemp.Name = "idTemp"
    Me.idTemp.Size = New System.Drawing.Size(148, 26)
    Me.idTemp.TabIndex = 1
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(9, 74)
    Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(69, 20)
    Me.Label16.TabIndex = 0
    Me.Label16.Text = "Id Name"
    '
    'maxValTemp
    '
    Me.maxValTemp.Location = New System.Drawing.Point(112, 29)
    Me.maxValTemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.maxValTemp.Name = "maxValTemp"
    Me.maxValTemp.Size = New System.Drawing.Size(148, 26)
    Me.maxValTemp.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 34)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(83, 20)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Max Value"
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.idPress)
    Me.GroupBox3.Controls.Add(Me.Label17)
    Me.GroupBox3.Controls.Add(Me.maxValPress)
    Me.GroupBox3.Controls.Add(Me.Label5)
    Me.GroupBox3.Location = New System.Drawing.Point(414, 285)
    Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox3.Size = New System.Drawing.Size(291, 126)
    Me.GroupBox3.TabIndex = 0
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Pressure"
    '
    'idPress
    '
    Me.idPress.Location = New System.Drawing.Point(112, 69)
    Me.idPress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.idPress.Name = "idPress"
    Me.idPress.Size = New System.Drawing.Size(148, 26)
    Me.idPress.TabIndex = 1
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(9, 74)
    Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(69, 20)
    Me.Label17.TabIndex = 0
    Me.Label17.Text = "Id Name"
    '
    'maxValPress
    '
    Me.maxValPress.Location = New System.Drawing.Point(112, 29)
    Me.maxValPress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.maxValPress.Name = "maxValPress"
    Me.maxValPress.Size = New System.Drawing.Size(148, 26)
    Me.maxValPress.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(9, 34)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(83, 20)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Max Value"
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.portComName)
    Me.GroupBox4.Controls.Add(Me.reqComTimeOut)
    Me.GroupBox4.Controls.Add(Me.reqTimeOut)
    Me.GroupBox4.Controls.Add(Me.reqRawCommand)
    Me.GroupBox4.Controls.Add(Me.Label6)
    Me.GroupBox4.Controls.Add(Me.Label18)
    Me.GroupBox4.Controls.Add(Me.ComReqRetry)
    Me.GroupBox4.Controls.Add(Me.reqDataCommand)
    Me.GroupBox4.Controls.Add(Me.Label1)
    Me.GroupBox4.Controls.Add(Me.Label14)
    Me.GroupBox4.Controls.Add(Me.Label20)
    Me.GroupBox4.Controls.Add(Me.update_period)
    Me.GroupBox4.Controls.Add(Me.Label13)
    Me.GroupBox4.Controls.Add(Me.Label4)
    Me.GroupBox4.Controls.Add(Me.Label19)
    Me.GroupBox4.Controls.Add(Me.Label8)
    Me.GroupBox4.Controls.Add(Me.Label7)
    Me.GroupBox4.Location = New System.Drawing.Point(18, 18)
    Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox4.Size = New System.Drawing.Size(387, 326)
    Me.GroupBox4.TabIndex = 1
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "General"
    '
    'reqComTimeOut
    '
    Me.reqComTimeOut.Location = New System.Drawing.Point(158, 198)
    Me.reqComTimeOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.reqComTimeOut.Name = "reqComTimeOut"
    Me.reqComTimeOut.Size = New System.Drawing.Size(148, 26)
    Me.reqComTimeOut.TabIndex = 1
    '
    'reqTimeOut
    '
    Me.reqTimeOut.Location = New System.Drawing.Point(158, 158)
    Me.reqTimeOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.reqTimeOut.Name = "reqTimeOut"
    Me.reqTimeOut.Size = New System.Drawing.Size(148, 26)
    Me.reqTimeOut.TabIndex = 1
    '
    'reqRawCommand
    '
    Me.reqRawCommand.Location = New System.Drawing.Point(158, 118)
    Me.reqRawCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.reqRawCommand.Name = "reqRawCommand"
    Me.reqRawCommand.Size = New System.Drawing.Size(148, 26)
    Me.reqRawCommand.TabIndex = 1
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(9, 203)
    Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(137, 20)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Comand Time Out"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(9, 163)
    Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(112, 20)
    Me.Label18.TabIndex = 0
    Me.Label18.Text = "Data Time Out"
    '
    'ComReqRetry
    '
    Me.ComReqRetry.Location = New System.Drawing.Point(158, 238)
    Me.ComReqRetry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.ComReqRetry.Name = "ComReqRetry"
    Me.ComReqRetry.Size = New System.Drawing.Size(148, 26)
    Me.ComReqRetry.TabIndex = 1
    '
    'reqDataCommand
    '
    Me.reqDataCommand.Location = New System.Drawing.Point(158, 78)
    Me.reqDataCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.reqDataCommand.Name = "reqDataCommand"
    Me.reqDataCommand.Size = New System.Drawing.Size(148, 26)
    Me.reqDataCommand.TabIndex = 1
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(9, 123)
    Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(112, 20)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Req Raw Com"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(9, 243)
    Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(124, 20)
    Me.Label20.TabIndex = 0
    Me.Label20.Text = "Retry Command"
    '
    'update_period
    '
    Me.update_period.Location = New System.Drawing.Point(158, 35)
    Me.update_period.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.update_period.Name = "update_period"
    Me.update_period.Size = New System.Drawing.Size(148, 26)
    Me.update_period.TabIndex = 1
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(9, 83)
    Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(115, 20)
    Me.Label13.TabIndex = 0
    Me.Label13.Text = "Req Data Com"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(316, 203)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(37, 20)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Sec"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(316, 163)
    Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(37, 20)
    Me.Label19.TabIndex = 0
    Me.Label19.Text = "Sec"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(316, 40)
    Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(37, 20)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Sec"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(9, 40)
    Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(111, 20)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Update Period"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(471, 531)
    Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(112, 35)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Save"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(592, 531)
    Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(112, 35)
    Me.Button2.TabIndex = 2
    Me.Button2.Text = "Cancel"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'GroupBox5
    '
    Me.GroupBox5.Controls.Add(Me.database_name)
    Me.GroupBox5.Controls.Add(Me.master_pass)
    Me.GroupBox5.Controls.Add(Me.Label12)
    Me.GroupBox5.Controls.Add(Me.master_user)
    Me.GroupBox5.Controls.Add(Me.Label11)
    Me.GroupBox5.Controls.Add(Me.sql_address)
    Me.GroupBox5.Controls.Add(Me.Label10)
    Me.GroupBox5.Controls.Add(Me.Label9)
    Me.GroupBox5.Location = New System.Drawing.Point(18, 354)
    Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.GroupBox5.Size = New System.Drawing.Size(387, 212)
    Me.GroupBox5.TabIndex = 3
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "Server"
    '
    'database_name
    '
    Me.database_name.Location = New System.Drawing.Point(158, 157)
    Me.database_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.database_name.Name = "database_name"
    Me.database_name.Size = New System.Drawing.Size(148, 26)
    Me.database_name.TabIndex = 6
    '
    'master_pass
    '
    Me.master_pass.Location = New System.Drawing.Point(158, 117)
    Me.master_pass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.master_pass.Name = "master_pass"
    Me.master_pass.Size = New System.Drawing.Size(148, 26)
    Me.master_pass.TabIndex = 8
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(16, 162)
    Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(55, 20)
    Me.Label12.TabIndex = 4
    Me.Label12.Text = "dBase"
    '
    'master_user
    '
    Me.master_user.Location = New System.Drawing.Point(158, 77)
    Me.master_user.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.master_user.Name = "master_user"
    Me.master_user.Size = New System.Drawing.Size(148, 26)
    Me.master_user.TabIndex = 9
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(16, 122)
    Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(78, 20)
    Me.Label11.TabIndex = 3
    Me.Label11.Text = "Password"
    '
    'sql_address
    '
    Me.sql_address.Location = New System.Drawing.Point(158, 37)
    Me.sql_address.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.sql_address.Name = "sql_address"
    Me.sql_address.Size = New System.Drawing.Size(148, 26)
    Me.sql_address.TabIndex = 7
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(16, 82)
    Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(43, 20)
    Me.Label10.TabIndex = 2
    Me.Label10.Text = "User"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(16, 42)
    Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(102, 20)
    Me.Label9.TabIndex = 5
    Me.Label9.Text = "MySql Server"
    '
    'usePredCheck
    '
    Me.usePredCheck.AutoSize = True
    Me.usePredCheck.Checked = True
    Me.usePredCheck.CheckState = System.Windows.Forms.CheckState.Checked
    Me.usePredCheck.Location = New System.Drawing.Point(427, 419)
    Me.usePredCheck.Name = "usePredCheck"
    Me.usePredCheck.Size = New System.Drawing.Size(138, 24)
    Me.usePredCheck.TabIndex = 4
    Me.usePredCheck.Text = "Use Prediction"
    Me.usePredCheck.UseVisualStyleBackColor = True
    '
    'setting
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(726, 586)
    Me.Controls.Add(Me.usePredCheck)
    Me.Controls.Add(Me.GroupBox5)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.GroupBox3)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "setting"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Setting"
    Me.TopMost = True
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    Me.GroupBox5.ResumeLayout(False)
    Me.GroupBox5.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents portComName As System.Windows.Forms.ComboBox
    Friend WithEvents maxValLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents maxValTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents maxValPress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents update_period As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents database_name As System.Windows.Forms.TextBox
    Friend WithEvents master_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents master_user As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sql_address As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents reqRawCommand As System.Windows.Forms.TextBox
    Friend WithEvents reqDataCommand As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents idLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents idTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents idPress As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents reqTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents reqComTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComReqRetry As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents usePredCheck As CheckBox
End Class
