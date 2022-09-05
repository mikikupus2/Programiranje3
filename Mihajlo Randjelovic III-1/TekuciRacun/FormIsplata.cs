using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekuciRacun
{
    public partial class FormIsplata : Form
    {
        public GlavnaForma glavna;
        public FormIsplata(GlavnaForma glavna)
        {
            InitializeComponent();
            this.glavna = glavna;
        }

        private void BTIsplataIsplati_Click(object sender, EventArgs e)
        {
            if (glavna.racun.Stanje - double.Parse(TBiznosIsplata.Text) > 100)
            {
                glavna.racun.Isplata(double.Parse(TBiznosIsplata.Text));
                Close();
            }
            else
                MessageBox.Show("Nemate dovoljno sredstava na racunu \nStanje na racunu iznosi:"
                    + glavna.racun.Stanje + "\n" + "Potrebno vam je jos:" + (double.Parse(TBiznosIsplata.Text) - glavna.racun.Stanje + 100).ToString()
                    ,"GRESKA!", MessageBoxButtons.OK ,MessageBoxIcon.Error);

        }
    }
}
