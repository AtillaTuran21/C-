using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace askerDagitimiArrayL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList askerler = new ArrayList();
        ArrayList sehirler = new ArrayList();
        ArrayList yedekSehirler = new ArrayList();
        ArrayList yedekAskerler = new ArrayList();
        ArrayList atamaSonuclari = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {

            // textBoxlar boş değilse arrayliste ekliyoruz.
            if(textBox1.Text.Trim()!="")
            {
                askerler.Add(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textBoxlar boş değilse arrayliste ekliyoruz.
            if (textBox2.Text.Trim() != "")
            {
                sehirler.Add(textBox2.Text);
                listBox2.Items.Add(textBox2.Text);
            }
            textBox2.Clear();
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox4.Items.Clear();
            askerler.Clear();
            sehirler.Clear();
            yedekAskerler.Clear();
            yedekSehirler.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (askerler.Count != 0 && sehirler.Count != 0) // en az bir asker ve şehir eklenmelidir. Kontrol ediyoruz.
            {
                Random rastgele = new Random();
                // askerlerin ve şehirlerin yedekleri alınıyor.
                yedekAskerler.AddRange(askerler);
                yedekSehirler.AddRange(sehirler);
                int askerSec;
                int sehirSec;
                // asker sayısı kadar atama yapmak için asker sayısı bir değişkene atandı.
                // Eğer askerler.Count'u for içine yazsaydık askerler.Count her asker sildiiğimizde sayısı azalacak
                // ve hata verecekti.
                int askerSayisi = askerler.Count;
                for (int i = 0; i < askerSayisi; i++)
                {
                    if (sehirler.Count != 0) // şehirleri silerken hiç şehir kaldı mı diye kontrol ediyoruz.
                    {
                        askerSec = rastgele.Next(0, askerler.Count);
                        sehirSec = rastgele.Next(0, sehirler.Count);
                        // atamasonucu arrayliste atılıyor.
                        atamaSonuclari.Add($"{askerler[askerSec]} ==> {sehirler[sehirSec]}");
                        // rastgele seçilen asker ve şehirler arraylistlerden silindi.
                        askerler.RemoveAt(askerSec);
                        sehirler.RemoveAt(sehirSec);
                    }
                    else
                    {
                        sehirler.AddRange(yedekSehirler);
                        i--;
                    }
                }
                // Atama Sonuçları Listbox'a yazdırılıyor.
                foreach (object gez in atamaSonuclari)
                       listBox4.Items.Add(gez);
            }
            else
                MessageBox.Show("En az bir asker ve şehir eklenmelidir.");
            
        }
    }
}
