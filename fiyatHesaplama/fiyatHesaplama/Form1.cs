using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiyatHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int fiyat = Convert.ToInt32(textBox1.Text); ;
            int sonfiyat;
            int komisyon;
            
            if (radioButton1.Checked == true)
            {
                sonfiyat = (fiyat * 10) / 100;
                sonfiyat = fiyat - sonfiyat;
                label3.Text = sonfiyat.ToString();
            }

            else if (radioButton2.Checked == true)
            {
                komisyon = (fiyat * 3) / 100;
                komisyon = fiyat + komisyon;
                label3.Text = komisyon.ToString();
            }

            else if (radioButton3.Checked == true)
            {
                komisyon = (fiyat * 6) / 100;
                komisyon = fiyat + komisyon;
                label3.Text = komisyon.ToString();
            }

            else if (radioButton4.Checked == true)
            {
                komisyon = (fiyat * 9) / 100;
                komisyon = fiyat + komisyon;
                label3.Text = komisyon.ToString();
            }

            else if (radioButton5.Checked == true)
            {
                komisyon = (fiyat * 20) / 100;
                komisyon = fiyat + komisyon;
                label3.Text = komisyon.ToString();
            }
            


            




        }
    }
}
