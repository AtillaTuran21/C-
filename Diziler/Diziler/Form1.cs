using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] notlar = { 80, 40, 50, 60, 75, 90, 25, 30, 35, 60, 70, 95, 80, 85, 90, 70, 90, 30, 15 };
        float ort;
        int toplam = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Array.Sort(notlar);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "50 Den Küçük Notlar";
            for(int i = 0; i < notlar.Length; i++)
            {
                if(notlar[i] < 50)
                {
                    listBox1.Items.Add(notlar[i]);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "70-85 Arası Notlar";
            for(int i = 0; i <notlar.Length; i++)
            {
                if (notlar[i] >= 70 && notlar[i] <= 85)
                {
                    listBox1.Items.Add(notlar[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Tüm Notların Ortalaması";
           for( int i = 0; i < notlar.Length; i++)
           {
                toplam+=notlar[i];
           }  
            ort=toplam/notlar.Length;
            listBox1.Items.Add(ort);                      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int enyukseknot = notlar[0];
            for(int i=0; i<notlar.Length; i++)
            {
                listBox1.Items.Add(notlar[i]);
            }
            for(int i = 0; i < notlar.Length; i++)
            {
                if(notlar[i]>enyukseknot)
                    enyukseknot=notlar[i];
            }
            label1.Text = enyukseknot.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int endusuknot = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                listBox1.Items.Add(notlar[i]);
            }
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endusuknot)
                    endusuknot = notlar[i];
            }
            label1.Text = endusuknot.ToString();
        }
    }
}
