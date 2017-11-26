﻿namespace TankMeasurement
{
  partial class Form2
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
      this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(168, 548);
      this.panel1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(0, 107);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(168, 73);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(168, 72);
      this.panel3.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(45, -7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 97);
      this.label1.TabIndex = 0;
      this.label1.Text = "m";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.angularGauge1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(168, 352);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(650, 196);
      this.panel2.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(181, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      // 
      // cartesianChart1
      // 
      this.cartesianChart1.Location = new System.Drawing.Point(185, 35);
      this.cartesianChart1.Name = "cartesianChart1";
      this.cartesianChart1.Size = new System.Drawing.Size(621, 222);
      this.cartesianChart1.TabIndex = 3;
      this.cartesianChart1.Text = "cartesianChart1";
      // 
      // angularGauge1
      // 
      this.angularGauge1.Location = new System.Drawing.Point(17, 14);
      this.angularGauge1.Name = "angularGauge1";
      this.angularGauge1.Size = new System.Drawing.Size(167, 170);
      this.angularGauge1.TabIndex = 0;
      this.angularGauge1.Text = "angularGauge1";
      // 
      // Form2
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
      this.ClientSize = new System.Drawing.Size(818, 548);
      this.Controls.Add(this.cartesianChart1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form2";
      this.Text = "Form2";
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private LiveCharts.WinForms.AngularGauge angularGauge1;
    private LiveCharts.WinForms.CartesianChart cartesianChart1;
  }
}