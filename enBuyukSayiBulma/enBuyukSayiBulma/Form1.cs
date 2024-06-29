using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enBuyukSayiBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1= Convert.ToInt32(textBox1.Text); 
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3=Convert.ToInt32(textBox2.Text);


            if (sayi1 >= sayi2 && sayi1 >= sayi3)
                label6.Text = sayi1.ToString();

            else if (sayi2 >= sayi3 && sayi2 >= sayi1)
                label7.Text = sayi2.ToString();

            else if (sayi3 >= sayi2 && sayi1 > sayi3)
                label7.Text = sayi2.ToString()          

          







        }
    }
}
