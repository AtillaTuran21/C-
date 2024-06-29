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

namespace AskerDagıtmaProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList askerler = new ArrayList();
        ArrayList sehirler = new ArrayList();
        ArrayList yedeksehirler = new ArrayList();
        ArrayList sonuclar = new ArrayList();
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()!= "")
            {
                listBox1.Items.Add(textBox1.Text);
                MessageBox.Show("Eklendi.");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
                MessageBox.Show("Kişi Girmediniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim()!= "")
            {
                listBox2.Items.Add(textBox2.Text);
                MessageBox.Show("Eklendi.");
                textBox2.Clear();
                textBox2.Focus();
            }
            else
                MessageBox.Show("Şehir Girmediniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            askerler.AddRange(listBox1.Items);
            sehirler.AddRange(listBox2.Items);
            yedeksehirler.AddRange(sehirler);
            if (askerler.Count != 0 && sehirler.Count != 0)
            {
                int askersayisi = askerler.Count;
                for (int i = 0; i < askersayisi; i++)
                {
                    if (sehirler.Count != 0)
                    {
                        int askersec = random.Next(0, askerler.Count);
                        int sehirsec = random.Next(0, sehirler.Count);
                        sonuclar.Add(askerler[askersec]+"==>"+sehirler[sehirsec]);
                        askerler.RemoveAt(askersec);
                        sehirler.RemoveAt(sehirsec);
                    }
                    else
                        sehirler.AddRange(yedeksehirler);
                        i--;           
                }
                foreach (object gez in sonuclar)
                    listBox3.Items.Add(gez);
            }
            else
                MessageBox.Show("En Az Bir Asker ve Bir Şehir Seçilmelidir.");
            
        }
              

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear(); 
            listBox3.Items.Clear();
            askerler.Clear();
            sehirler.Clear();
        }
    }
}
