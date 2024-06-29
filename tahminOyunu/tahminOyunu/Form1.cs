using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;
        int tahminSayisi=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            button2.Enabled = false;
            Random rastgeleSayi = new Random();
            sayi = rastgeleSayi.Next(1,100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenSayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();

            if (girilenSayi == sayi)
            {
                label2.Text = "Tebrikler Bildiniz.";
                button1.Enabled = false;
                button2.Enabled = true;
                textBox1.Enabled = false;
                label3.Text = tahminSayisi.ToString();
            }

            else if (girilenSayi > sayi)
            {
                label2.Text = "Lütfen Daha Küçük Bir Sayı Giriniz";
                tahminSayisi = tahminSayisi + 1;
            }

            else if (girilenSayi < sayi)
            {
                label2.Text = "Lütfen Daha Büyük Bir Sayı Giriniz";
                tahminSayisi = tahminSayisi + 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rastgeleSayi = new Random();
            sayi = rastgeleSayi.Next(1, 100);
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Focus();
            label3.Text = "";
        }
    }
}
