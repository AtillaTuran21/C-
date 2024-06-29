using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }
        class Telefon
        {
            public string telRenk= "Siyah";
            public int depolamaAlani = 64 ;
            public int bataryaKapasitesi = 1000;
            public int kameraSayisi = 3;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefon telefon1 = new Telefon();
            MessageBox.Show("\nTelefonun Rengi:"+telefon1.telRenk + "\n Telefonun Depolama Alanı:"+ telefon1.depolamaAlani + "\n Telefonun Batarya Kapasitesi:"+ telefon1.bataryaKapasitesi +"\n Telefonun Kamera Sayısı:" + telefon1.kameraSayisi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telefon telefon2 = new Telefon();
            telefon2.telRenk = "Beyaz";
            telefon2.depolamaAlani = 120 ;
            telefon2.bataryaKapasitesi = 2000;
            telefon2.kameraSayisi = 4;
            MessageBox.Show("Telefonun Rengi:" + telefon2.telRenk + "\n Telefonun Depolama Alanı:" + telefon2.depolamaAlani + "\n Telefonun Batarya Kapasitesi:" + telefon2.bataryaKapasitesi + "\n Telefonun Kamera Sayısı:" + telefon2.kameraSayisi);
            
        }
    }
}
