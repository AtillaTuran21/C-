using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilİlceSecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Pendik");
                listBox1.Items.Add("Kartal");
                listBox1.Items.Add("Kadıköy");
                listBox1.Items.Add("Üsküdar");
                listBox1.Items.Add("Maltepe");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Gebze");
                listBox1.Items.Add("Darıca");
                listBox1.Items.Add("Çayırova");
                listBox1.Items.Add("Derince");
                listBox1.Items.Add("Dilovası");
            }
            if (comboBox1.SelectedIndex == 2)
            {   listBox1.Items.Clear();
                listBox1.Items.Add("Çankaya");
                listBox1.Items.Add("Keçiöğren");
                listBox1.Items.Add("Polatlı");
                listBox1.Items.Add("Sincan");
                listBox1.Items.Add("Gölbaşı");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Buca");
                listBox1.Items.Add("Konak");
                listBox1.Items.Add("Çeşme");
                listBox1.Items.Add("Bornova");
                listBox1.Items.Add("Ödemiş");
            }


        }
    }
}
