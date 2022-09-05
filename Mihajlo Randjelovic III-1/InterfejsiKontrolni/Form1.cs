using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfejsiKontrolni
{
    public partial class GlavnaForma : Form
    {
        public Ucenik ucenik;
        public GlavnaForma()
        {
            InitializeComponent();
        }
        private void BTIzvestaj_Click(object sender, EventArgs e)
        {
            IzvestajForma izvestaj = new IzvestajForma(this);
            izvestaj.ShowDialog();
        }

        private void BTUnos_Click(object sender, EventArgs e)
        {
            UnosForma unos = new UnosForma(this);
            unos.ShowDialog();
            BTOcena.Enabled = true;
            BTIzvestaj.Enabled = true;
        }

        private void BTOcena_Click(object sender, EventArgs e)
        {
            ucenik.Oceni();
        }
    }
}
