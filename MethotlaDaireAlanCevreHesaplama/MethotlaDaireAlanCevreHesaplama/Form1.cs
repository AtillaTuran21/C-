using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethotlaDaireAlanCevreHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Daire daire= new Daire();
            double sonucalan=daire.alanHesapla();
            MessageBox.Show(sonucalan.ToString());
            double sonuccevre=daire.cevreHesapla();
            MessageBox.Show(sonuccevre.ToString());           
        }
        class Daire
        {
            public int yaricap = 5;
            public double alanHesapla()
            {
                double alan = 3.14 * (yaricap * yaricap);
                return alan;
            }
            public double cevreHesapla()
            {
                double cevre=2*(3.14)*yaricap;
                return cevre;
            }
        }
    }
}
