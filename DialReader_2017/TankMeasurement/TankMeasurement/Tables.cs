using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TankMeasurement
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form1 test = new Form1();
                test.openCsv(openFileDialog1.FileName, ref table54);
                File54.Text = openFileDialog1.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form1 test = new Form1();
                test.openCsv(openFileDialog1.FileName, ref tableTangki);
                FileTangki.Text = openFileDialog1.FileName;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
