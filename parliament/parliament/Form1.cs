using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parliament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown2.Maximum = (int)((double)numericUpDown1.Value * 0.90);
            label10.Text = "Брой народни представители: 0\nОт които независими: 0 (0%)\nБрой партии: 0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            label10.Text = "Брой народни представители: " + numericUpDown1.Value.ToString() + "\nОт които независими: " + numericUpDown2.Value.ToString() + " (" + Math.Round((numericUpDown2.Value/numericUpDown1.Value) * 100, 2) + "%)\nБрой партии: " + numericUpDown3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = (int)((double)numericUpDown1.Value * 0.90);
        }
    }
}
