using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KombinasyonHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, r, sonuc;
            n = Convert.ToInt32(textBox1.Text);
            r = Convert.ToInt32(textBox2.Text);
            sonuc = FaktoriyelHesapla(n) / (FaktoriyelHesapla(r) * FaktoriyelHesapla(n - r));
            label4.Text = sonuc.ToString();
        }
        public int FaktoriyelHesapla(int sayi)
        {
            int s = 1;
            for (int i = 1; i <= sayi; i++)
            {
                s *= i;
            }
            return s;
        }
        

    }
}
