using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarmarayBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private void button1_Click(object sender, EventArgs e)
        {   
            int durakSayisi = comboBox1.SelectedIndex - comboBox2.SelectedIndex;
            durakSayisi=Math.Abs(durakSayisi);
            
            if (durakSayisi <= 0 && durakSayisi <= 7)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(7.67);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(3.73);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(5.47);
            }
            else if (durakSayisi<= 8 && durakSayisi <= 14)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(9.85);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(4.60);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(6.80);
            }
            else if (durakSayisi <= 15 && durakSayisi <= 21)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(11.38);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(5.48);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(7.99);
            }
            else if(durakSayisi <= 22 && durakSayisi <= 28)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(13.13);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(6.24);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(9.31);
            }
            else if (durakSayisi <= 29 && durakSayisi <=35)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(15.32);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(7.33);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(10.94);
            }
            else if (durakSayisi <= 36 && durakSayisi <= 43)
            {
                if (radioButton1.Checked)
                    label6.Text = Convert.ToString(16.96);
                else if (radioButton2.Checked)
                    label6.Text = Convert.ToString(7.67);
                else if (radioButton3.Checked)
                    label6.Text = Convert.ToString(11.82);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?","DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("ÇIKIŞ İPTAL EDİLDİ.");
        }
    }
}
