using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersSaatleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        int sayac = 0;
        string ders = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Alarm Saati Girmediniz.");
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Alarm Dakikası Girmediniz.");
            }
            int alarm1=Convert.ToInt32(textBox2.Text);
            int alarm2=Convert.ToInt32(textBox3.Text);            
            listBox2.Items.Add(alarm1 + ":" + alarm2);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            timer1.Start();
            label2.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();           
            textBox1.Text = ders + "." + "Derstesiniz.";
            this.Location = new Point(1456, 13);
           
        }
    }
}
