using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;

        private void Form1_Load(object sender, EventArgs e)
        {
           sayac = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            sayac = 0;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text=sayac.ToString();
        }
    }
}
