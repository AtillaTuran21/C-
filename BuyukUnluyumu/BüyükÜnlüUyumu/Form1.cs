using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BüyükÜnlüUyumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kalinUnluler = "AaIıOoUu";
        string inceUnluler = "EeİiÖöÜü";
        string rakamlar = "0123456789";
        bool kalinUnluVarMi = false;
        bool inceUnluVarMi = false;
        bool rakamVarmi = false;
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("ÇIKIŞ İPTAL EDİLDİ.");
        }
        private void button1_Click(object sender, EventArgs e)
        {                   
            if (textBox1.Text == " ")
                label1.Text = Convert.ToString("BİR KELİME GİRMEDİNİZ.");
            else if (textBox1.Text.Contains(" "))
                label1.Text = Convert.ToString("TEK KELİME GİRİNİZ.");
            else 
            {
                string kelime = textBox1.Text;
                for (int i = 0; i < kelime.Length; i++)
                {
                    if (kalinUnluler.Contains(kelime[i]))
                    {
                        kalinUnluVarMi = true;
                    }
                    else if (inceUnluler.Contains(kelime[i]))
                    {
                        inceUnluVarMi = true;
                    }
                    else if (rakamlar.Contains(kelime[i]))
                    {
                        rakamVarmi = true;
                    }
                    else
                        label1.Text=Convert.ToString("SESLİ HARF GİRMELİSİNİZ.");
                }
            }
            if (rakamVarmi == true)
                label1.Text = Convert.ToString("RAKAM İÇEREMEZ");
            else if (kalinUnluVarMi == true && inceUnluVarMi == true)
                label1.Text = Convert.ToString("BÜYÜK ÜNLÜ UYUMUNA UYMUYOR");
            else if (kalinUnluVarMi == false && inceUnluVarMi == true)
                label1.Text = Convert.ToString("BÜYÜK ÜNLÜ UYUMUNA UYUYOR");
            else if (kalinUnluVarMi == true && inceUnluVarMi == false)
                label1.Text = Convert.ToString("BÜYÜK ÜNLÜ UYUMUNA UYUYOR");
        } 
    }
}
