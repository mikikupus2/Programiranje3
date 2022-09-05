using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolniZadatak31
{
    public partial class FormaUnosa : Form
    {
        GlavnaForma glavnaforma;
        public FormaUnosa(GlavnaForma glavnaforma)
        {
            InitializeComponent();
            this.glavnaforma = glavnaforma;
        }

        private void btunesi_Click(object sender, EventArgs e)
        {
            Dzerald jedandzerald = new Dzerald();
            jedandzerald.Sifra = int.Parse(tbsifra.Text);
            jedandzerald.Ime = tbime.Text;
            jedandzerald.Prezime = tbprezime.Text;
            jedandzerald.Valuta = tbvaluta.Text;
            jedandzerald.Iznos = double.Parse(tbiznos.Text);
            glavnaforma.listadzeralda.Add(jedandzerald);
            glavnaforma.dataGridView1.DataSource = null;
            glavnaforma.dataGridView1.Rows.Clear();
            glavnaforma.dataGridView1.DataSource = glavnaforma.listadzeralda;
            glavnaforma.dataGridView1.Refresh();
            Close();

        }
    }
}
