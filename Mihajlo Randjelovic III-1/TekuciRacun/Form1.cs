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
    public partial class GlavnaForma : Form
    {
        public TRacun racun;
        public GlavnaForma()
        {
            InitializeComponent();
            racun = new TRacun();
            racun.Stanje = 1000;
        }
        private void BTUplata_Click(object sender, EventArgs e)
        {
            FormUplata uplata = new FormUplata(this);
            uplata.ShowDialog();
        }

        private void BTIsplata_Click(object sender, EventArgs e)
        {
            FormIsplata isplata = new FormIsplata(this);
            isplata.ShowDialog();
        }

        private void BTStanje_Click(object sender, EventArgs e)
        {
            FormStanje stanje = new FormStanje(this.racun.Stanje);
            stanje.ShowDialog();
        }
    }
}
