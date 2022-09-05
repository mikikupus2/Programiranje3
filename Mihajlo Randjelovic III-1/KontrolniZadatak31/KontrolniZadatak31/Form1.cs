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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            dataGridView1.DataSource = listadzeralda;
        }
        public List<Dzerald> listadzeralda = new List<Dzerald>();
        private void btunos_Click(object sender, EventArgs e)
        {
            FormaUnosa unos = new FormaUnosa(this);
            unos.ShowDialog();
        }

        private void btispis_Click(object sender, EventArgs e)
        {
            FormaPrikaza prikaz = new FormaPrikaza(listadzeralda, tbizabranavaluta.Text);
            prikaz.ShowDialog();
        }
    }
}
