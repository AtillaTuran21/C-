using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziyiListeyeAktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] notlar = { 100, 30, 45, 55, 60, 75, 50, 70, 15 };
            string[] adlar = {"Ecrin","Ayşe","İrem","Şevval","Mehmet","Ahmet","Yasin","Elif","Yağmur"};
            string[] soyadlar = { "Duymaz", "Yılmaz", "Soytürk", "Kaya", "Öztürk", "Alkan", "Gezer", "Ölmez", "Karabaşoğlu" };

            for(int i = 0; i < notlar.Length; i++)
            {
                listBox1.Items.Add(notlar[i]);
                listBox2.Items.Add(adlar[i]);
                listBox3.Items.Add(soyadlar[i]);
            }           
        }
    }
}
