using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimGalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        int kontrol = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim2.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim3.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim4.jpg";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim5.jpg";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim6.jpg";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim7.jpg";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim8.jpg";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim9.jpg";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim10.jpg";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim1.jpg";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimlerr\\resim10.jpg";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sayac==1)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim1.jpg";
                sayac++;
            }
            else if(sayac==2)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim2.jpg";
                sayac++;
            }
            else if (sayac == 3)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim3.jpg";
                sayac++;
            }
            else if (sayac == 4)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim4.jpg";
                sayac++;
            }
            else if (sayac == 5)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim5.jpg";
                sayac++;
            }
            else if (sayac == 6)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim6.jpg";
                sayac++;
            }
            else if (sayac == 7)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim7.jpg";
                sayac++;
            }
            else if (sayac == 8)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim8.jpg";
                sayac++;
            }
            else if (sayac == 9)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim9.jpg";
                sayac++;
            }
            else if (sayac == 10)
            {
                pictureBox1.ImageLocation = "Resimlerr\\resim10.jpg";
                sayac=1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
