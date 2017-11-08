namespace TankMeasurement
{
    partial class ExportCsv
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
            this.btExport = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.datepicker = new System.Windows.Forms.GroupBox();
            this.DtStart = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.DtEnd = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.ChkToday = new System.Windows.Forms.CheckBox();
            this.datepicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(120, 135);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 22;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(201, 135);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // datepicker
            // 
            this.datepicker.Controls.Add(this.DtStart);
            this.datepicker.Controls.Add(this.Label2);
            this.datepicker.Controls.Add(this.DtEnd);
            this.datepicker.Controls.Add(this.Label1);
            this.datepicker.Location = new System.Drawing.Point(12, 35);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(264, 83);
            this.datepicker.TabIndex = 20;
            this.datepicker.TabStop = false;
            this.datepicker.Text = "Date";
            // 
            // DtStart
            // 
            this.DtStart.Location = new System.Drawing.Point(49, 19);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(200, 20);
            this.DtStart.TabIndex = 12;
            this.DtStart.Value = new System.DateTime(2012, 10, 23, 0, 0, 0, 0);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "End";
            // 
            // DtEnd
            // 
            this.DtEnd.Location = new System.Drawing.Point(49, 45);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Size = new System.Drawing.Size(200, 20);
            this.DtEnd.TabIndex = 12;
            this.DtEnd.Value = new System.DateTime(2012, 10, 23, 0, 0, 0, 0);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Start";
            // 
            // ChkToday
            // 
            this.ChkToday.AutoSize = true;
            this.ChkToday.Checked = true;
            this.ChkToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkToday.Location = new System.Drawing.Point(12, 12);
            this.ChkToday.Name = "ChkToday";
            this.ChkToday.Size = new System.Drawing.Size(56, 17);
            this.ChkToday.TabIndex = 18;
            this.ChkToday.Text = "Today";
            this.ChkToday.UseVisualStyleBackColor = true;
            // 
            // ExportCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 174);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.ChkToday);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportCsv";
            this.Text = "ExportCsv";
            this.datepicker.ResumeLayout(false);
            this.datepicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btExport;
        internal System.Windows.Forms.Button btCancel;
        internal System.Windows.Forms.GroupBox datepicker;
        internal System.Windows.Forms.DateTimePicker DtStart;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DtEnd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox ChkToday;
    }
}