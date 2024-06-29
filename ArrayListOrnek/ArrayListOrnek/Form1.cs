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

namespace ArrayListOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()!="" && textBox2.Text.Trim()!="")
            {
                sehirler.Add(textBox1.Text);
                sehirler.Add(textBox2.Text);
                MessageBox.Show("Eklendi.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sehirler.TrimToSize();
            for(int i = 0; i < sehirler.Count; i=i+2)
            {
                listBox1.Items.Add(sehirler[i] + " ==> " + sehirler[i+1]);              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int indeks = sehirler.IndexOf(textBox3.Text);
            if (indeks != -1)
            {
                listBox1.Items.Add(sehirler[indeks - 1] + " ==> " + sehirler[indeks]);
            }
            else
                listBox1.Items.Add("Bulunamadı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int indeks = sehirler.IndexOf(textBox3.Text);
            if (indeks != -1)
            {
                if(textBox4.Text.Trim()!="")
                {
                    sehirler[indeks-1]=textBox4.Text;
                    MessageBox.Show("Güncellendi.");
                }
                else
                {
                    MessageBox.Show("İl Adı Girilmedi.");
                }
            }
            else
                MessageBox.Show("Bulunamadı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int indeks = sehirler.IndexOf(textBox3.Text);
            if (indeks != -1)
            {
                sehirler.RemoveAt(indeks);
                sehirler.RemoveAt(indeks-1);
                MessageBox.Show("Silindi.");
            }
            else
                MessageBox.Show("Bulunamadı.");
        }
    }
}
