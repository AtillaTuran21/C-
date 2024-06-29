using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Urun urun;
        Dukkan dukkan = new Dukkan();
        List<Urun> urunList = new List<Urun>();
        bool veriGirisi()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
               !string.IsNullOrEmpty(textBox2.Text) &&
               !string.IsNullOrEmpty(textBox4.Text) &&
               !string.IsNullOrEmpty(comboBox1.Text))
                return true;
            else
                return false;
        }

        bool yeniUrun()
        {
            urun = new Urun();
            urun.UrunKodu = Convert.ToInt32(textBox1.Text);
            urun.UrunAdi = textBox2.Text;
            urun.UrunKategori = comboBox1.Text;
            urun.StokMiktari = Convert.ToInt32(textBox4.Text);
            bool sonuc = dukkan.urunEkle(urun); return sonuc;            
        }

        void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            comboBox2.Text = ""; 
        }

        void aktifEt()
        {
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (veriGirisi())
            {
                if (yeniUrun())
                { MessageBox.Show("Ürün Eklendi."); Temizle(); }
                else
                    MessageBox.Show("Ürün Eklenemedi.");
            }
            else
                MessageBox.Show("Boş Bilgi Bırakmayınız.");
        }
           
        private void button3_Click(object sender, EventArgs e)
        {
            Urun urun = dukkan.urunAra(Convert.ToInt32(textBox5.Text));
            if(urun != null)
            {
                textBox6.Text = urun.UrunAdi;
                comboBox2.Text = urun.UrunKategori.ToString();
                textBox3.Text = urun.StokMiktari.ToString();
                MessageBox.Show("Ürün Bulundu.");
                aktifEt();
            }
            else
                MessageBox.Show("Ürün Bulunamadı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                if (dukkan.urunSil(Convert.ToInt32(textBox5.Text)))
                    MessageBox.Show("Ürün Silindi.");
                else
                    MessageBox.Show("Ürün Silinemedi.");
            }
            else
                MessageBox.Show("Silme İşlemi İptal Edildi.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dukkan.urunDuzenle(urun); Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            urunList = dukkan.urunleriGonder();
            foreach(Urun urun in urunList)
            {
                listBox1.Items.Add(urun.UrunKodu);
                listBox2.Items.Add(urun.UrunAdi);
                listBox3.Items.Add(urun.UrunKategori);
                listBox4.Items.Add(urun.StokMiktari);
            }
        }
    }
}
