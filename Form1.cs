using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace камни
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Enabled = false;
            this.Opacity = 0.5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label2.Visible = false;
            this.Opacity = 0.4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button2.Enabled = false;
            this.Opacity = 0.65;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button3.Enabled = false;
            this.Opacity = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button2.Enabled = false;
            this.Opacity = 0.8;
        }
    }
}
