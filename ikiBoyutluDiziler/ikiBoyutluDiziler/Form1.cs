using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiBoyutluDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] OgrenciAdSoyad = new string[30];
        int[,] notlar= new int[30,4];
        int sayac = 0, toplam = 0, ort = 0;

        private void button1_Click(object sender, EventArgs e)
        { 
            if (sayac < OgrenciAdSoyad.Length)
            {
                OgrenciAdSoyad[sayac] = textBox1.Text.Trim().ToUpper();
                notlar[sayac, 0] = Convert.ToInt32(textBox2.Text);
                notlar[sayac, 1] = Convert.ToInt32(textBox3.Text);
                notlar[sayac, 2] = Convert.ToInt32(textBox4.Text);
                notlar[sayac, 3] = Convert.ToInt32(textBox5.Text);
                MessageBox.Show($"{sayac + 1}.Kayıt Eklendi");
                sayac++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int varmi=Array.IndexOf(OgrenciAdSoyad,textBox10.Text.Trim().ToUpper());
            if (varmi != -1)
            {
                listBox1.Items.Add(OgrenciAdSoyad[varmi]);
                listBox1.Items.Add($"Uygulama sınavı 1 : {notlar[varmi, 0]}");
                listBox1.Items.Add($"Uygulama sınavı 2 : {notlar[varmi, 1]}");
                listBox1.Items.Add($"Performans 1 : {notlar[varmi, 2]}");
                listBox1.Items.Add($"Performans 2 : {notlar[varmi, 3]}");
            }
            else
                MessageBox.Show("Kayıt bulunamadı");           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayac; i++)
            {
                listBox1.Items.Add("---------------------------");
                listBox1.Items.Add(OgrenciAdSoyad[i]);
                listBox1.Items.Add($"Uygulama sınavı 1 : {notlar[i, 0]}");
                listBox1.Items.Add($"Uygulama sınavı 2 : {notlar[i, 1]}");
                listBox1.Items.Add($"Performans 1 : {notlar[i, 2]}");
                listBox1.Items.Add($"Performans 2 : {notlar[i, 3]}");
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayac; i++)
            {
                toplam = notlar[i, 0] + notlar[i, 1] + notlar[i, 2] + notlar[i, 3];
                ort += toplam / 4;
            }
            int tumSinifOrtalama = ort / sayac;
            listBox1.Items.Add($"Tüm Sınıfın Ortalaması = {tumSinifOrtalama}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Öğrenci Ortalamaları");
            for (int i = 0; i < sayac; i++)
            {
                toplam = notlar[i, 0] + notlar[i, 1] + notlar[i, 2] + notlar[i, 3];
                ort = toplam / 4;
                listBox1.Items.Add($"{OgrenciAdSoyad[i]} = {ort}");
                listBox1.Items.Add("--------------------------");
            }
        }
    }
}
