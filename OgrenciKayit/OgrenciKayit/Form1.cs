using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = textBox1.Text;
            ogrenci.soyad = textBox2.Text;
            ogrenci.sınıf = textBox3.Text;
            ogrenci.no = textBox4.Text;
            ogrenci.cinsiyet = comboBox1.SelectedItem;
            listBox1.Items.Add(ogrenci.ad);
            listBox2.Items.Add(ogrenci.soyad);
            listBox3.Items.Add(ogrenci.no);
            listBox4.Items.Add(ogrenci.cinsiyet);
            listBox5.Items.Add(ogrenci.sınıf);
        }      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Ogrenci
        {
            public string ad;
            public string soyad;
            public string no;
            public string sınıf;
            public object cinsiyet;
        }
    }
}
