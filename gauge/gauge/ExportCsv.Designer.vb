<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportCsv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportCsv))
        Me.ChkToday = New System.Windows.Forms.CheckBox
        Me.DtStart = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.datepicker = New System.Windows.Forms.GroupBox
        Me.fieldSelect = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btCancel = New System.Windows.Forms.Button
        Me.btExport = New System.Windows.Forms.Button
        Me.datepicker.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkToday
        '
        Me.ChkToday.AutoSize = True
        Me.ChkToday.Checked = True
        Me.ChkToday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkToday.Location = New System.Drawing.Point(12, 14)
        Me.ChkToday.Name = "ChkToday"
        Me.ChkToday.Size = New System.Drawing.Size(56, 17)
        Me.ChkToday.TabIndex = 13
        Me.ChkToday.Text = "Today"
        Me.ChkToday.UseVisualStyleBackColor = True
        '
        'DtStart
        '
        Me.DtStart.Location = New System.Drawing.Point(49, 19)
        Me.DtStart.Name = "DtStart"
        Me.DtStart.Size = New System.Drawing.Size(200, 20)
        Me.DtStart.TabIndex = 12
        Me.DtStart.Value = New Date(2012, 10, 23, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Start"
        '
        'DtEnd
        '
        Me.DtEnd.Location = New System.Drawing.Point(49, 45)
        Me.DtEnd.Name = "DtEnd"
        Me.DtEnd.Size = New System.Drawing.Size(200, 20)
        Me.DtEnd.TabIndex = 12
        Me.DtEnd.Value = New Date(2012, 10, 23, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "End"
        '
        'datepicker
        '
        Me.datepicker.Controls.Add(Me.DtStart)
        Me.datepicker.Controls.Add(Me.Label2)
        Me.datepicker.Controls.Add(Me.DtEnd)
        Me.datepicker.Controls.Add(Me.Label1)
        Me.datepicker.Location = New System.Drawing.Point(12, 37)
        Me.datepicker.Name = "datepicker"
        Me.datepicker.Size = New System.Drawing.Size(264, 83)
        Me.datepicker.TabIndex = 15
        Me.datepicker.TabStop = False
        Me.datepicker.Text = "Date"
        '
        'fieldSelect
        '
        Me.fieldSelect.FormattingEnabled = True
        Me.fieldSelect.Items.AddRange(New Object() {"Tank Level", "Tank Temperature", "Tank Pressure"})
        Me.fieldSelect.Location = New System.Drawing.Point(155, 12)
        Me.fieldSelect.Name = "fieldSelect"
        Me.fieldSelect.Size = New System.Drawing.Size(121, 21)
        Me.fieldSelect.TabIndex = 16
        Me.fieldSelect.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Field"
        Me.Label3.Visible = False
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(201, 137)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 17
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btExport
        '
        Me.btExport.Location = New System.Drawing.Point(120, 137)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(75, 23)
        Me.btExport.TabIndex = 17
        Me.btExport.Text = "Export"
        Me.btExport.UseVisualStyleBackColor = True
        '
        'ExportCsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 167)
        Me.Controls.Add(Me.btExport)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.fieldSelect)
        Me.Controls.Add(Me.datepicker)
        Me.Controls.Add(Me.ChkToday)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportCsv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ExportCsv"
        Me.datepicker.ResumeLayout(False)
        Me.datepicker.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkToday As System.Windows.Forms.CheckBox
    Friend WithEvents DtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datepicker As System.Windows.Forms.GroupBox
    Friend WithEvents fieldSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btExport As System.Windows.Forms.Button
End Class
