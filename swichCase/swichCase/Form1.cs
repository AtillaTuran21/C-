using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swichCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunler=comboBox1.SelectedItem.ToString();

            switch(gunler)
            {
                case "PAZARTESİ":
                case "SALI":
                case "ÇARŞAMBA":
                case "PERŞEMBE":
                case "CUMA":
                    label2.Text = "HAFTA İÇİ";
                    break;
                case "CUMARTESİ":
                case "PAZAR":
                    label2.Text = "HAFTA SONU";
                    break;

                    
            }

        }
    }
}
