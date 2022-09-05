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
    public partial class IzvestajForma : Form
    {
        GlavnaForma glavna;
        public IzvestajForma(GlavnaForma glavna)
        {
            InitializeComponent();
            this.glavna = glavna;
        }

        private void IzvestajForma_Load(object sender, EventArgs e)
        {
            TBIzvestaj.Text = glavna.ucenik.Izvestaj();
        }

        private void BTOKIzvestaj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
