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
    public partial class FormUplata : Form
    {
        public GlavnaForma glavna;
        public FormUplata(GlavnaForma glavna)
        {
            InitializeComponent();
            this.glavna = glavna;
        }

        private void BTUplataUplati_Click(object sender, EventArgs e)
        {
            glavna.racun.Uplata(double.Parse(TBiznosUplata.Text));
            Close();
        }
    }
}
