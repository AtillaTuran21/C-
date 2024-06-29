using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizilerSayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] rastgeleSayilar=new int[6];
        Random rnd = new Random();
        int[] secilenSayilar=new int[6];
        int[] bilinenSayilar = new int[6];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            rastgeleSayiTut();
            for (int i = 0; i < bilinenSayilar.Length; i++)
                bilinenSayilar[i] = 0;
            if (radioButton1.Checked)
            {
                bool kontrol = true;
                secilenSayilar[0] = comboBox1.SelectedIndex + 1;
                secilenSayilar[1] = comboBox2.SelectedIndex + 1;
                secilenSayilar[2] = comboBox3.SelectedIndex + 1;
                secilenSayilar[3] = comboBox4.SelectedIndex + 1;
                secilenSayilar[4] = comboBox5.SelectedIndex + 1;
                secilenSayilar[5] = comboBox6.SelectedIndex + 1;
                for (int i = 0; i < secilenSayilar.Length; i++)
                {
                    for (int j = 0; j < secilenSayilar.Length; j++)
                    {
                        if (i != j)
                            if (secilenSayilar[i] == secilenSayilar[j])
                                kontrol = false;
                    }
                }
                if (kontrol == false)
                {
                    MessageBox.Show("Aynı Sayı Seçilemez. ");
                    kontrol = true;
                }
                else
                {
                    Array.Sort(secilenSayilar);
                    for (int i = 0; i < secilenSayilar.Length; i++)
                        listBox1.Items.Add(secilenSayilar[i]);
                }
            }
            else if (radioButton2.Checked)
            {
                int sayi;
                for (int i = 0; i < secilenSayilar.Length; i++)
                {
                    sayi = rnd.Next(1, 50);
                    if (Array.IndexOf(secilenSayilar, sayi) != -1)
                         i--;                    
                    else                   
                        secilenSayilar[i] = sayi;                   
                }
                Array.Sort(secilenSayilar);
                for (int i = 0; i < secilenSayilar.Length; i++)
                    listBox1.Items.Add(secilenSayilar[i]);
            }
            int indisSirasi = 0;
            for (int i = 0; i < secilenSayilar.Length; i++)
            {
                for (int j = 0; j < rastgeleSayilar.Length; j++)
                {
                    
                    if (secilenSayilar[i] == rastgeleSayilar[j])
                    {
                        bilinenSayilar[indisSirasi] = secilenSayilar[i];
                        indisSirasi++;
                    }                 
                }
            }
            Array.Sort(bilinenSayilar);
            for (int i = 0; i < bilinenSayilar.Length; i++)
                if (bilinenSayilar[i]!=0)
                    listBox3.Items.Add(bilinenSayilar[i]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=1;i<=49;i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
                comboBox6.Items.Add(i);
            }
            if(radioButton1.Checked)            
                groupBox1.Enabled = true;            
            else
                groupBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)            
                groupBox1.Enabled = true;            
            else
                groupBox1.Enabled = false;
        }

        public void rastgeleSayiTut()
        {
            int sayi;
            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                sayi = rnd.Next(1,50);
                if (Array.IndexOf(rastgeleSayilar,sayi) != -1)                
                    i--;                
                else               
                    rastgeleSayilar[i] = sayi;                
            }
            Array.Sort(rastgeleSayilar);
            for (int i = 0; i < rastgeleSayilar.Length; i++)
                listBox2.Items.Add(rastgeleSayilar[i]);
        }
    }
}
