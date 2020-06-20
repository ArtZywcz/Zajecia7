using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zajecia7v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.Font = fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "To jest tytuł alertu", "To jest treść alertu", ToolTipIcon.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var test = colorDialog1.ShowDialog();
            if (test == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 nowy = new Form2();
            nowy.ShowDialog();
        }
    }
}
