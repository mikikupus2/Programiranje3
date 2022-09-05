using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatMenjacnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Menjacnica menjacnica;
        private void Form1_Load(object sender, EventArgs e)
        {
            menjacnica = new Menjacnica(117,120,1000,1000000);
            lbkupovni.Text = menjacnica.KupovniKurs.ToString();
            lbprodajni.Text = menjacnica.ProdajniKurs.ToString();
            txtstanje.Text = menjacnica.Stanje();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (rbkup.Checked)
                if (menjacnica.Kolicinadinara >= menjacnica.KupovniKurs * double.Parse(txtiznos.Text))
                    menjacnica.Kupovina(double.Parse(txtiznos.Text));
                else
                    MessageBox.Show("Nema dovoljno dinara u kasi !!!");
            else
                if (menjacnica.Kolicinaevra >= double.Parse(txtiznos.Text))
                    menjacnica.Prodaja(double.Parse(txtiznos.Text));
                else
                    MessageBox.Show("Nema dovoljno Eura u kasi !!!");
            txtstanje.Text = "";
            txtstanje.Text = menjacnica.Stanje();
        }
    }
}
