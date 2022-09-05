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
    public partial class UnosForma : Form
    {
        GlavnaForma glavna;
        public UnosForma(GlavnaForma glavna)
        {
            InitializeComponent();
            this.glavna = glavna;
        }

        private void BTOKUnos_Click(object sender, EventArgs e)
        {
            if(TBIme.Text == "" || TBPrezime.Text == "" || TBBroj_poena.Text == "")
            {
                MessageBox.Show("Niste lepo uneli podatke!", "GRESKA!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                glavna.ucenik = new Ucenik(TBIme.Text, TBPrezime.Text, int.Parse(TBBroj_poena.Text));
                Close();
            }
        }
    }
}
