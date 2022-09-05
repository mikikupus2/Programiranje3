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
    public partial class FormaPrikaza : Form
    {
        public FormaPrikaza(List<Dzerald> listadzeralda, string valuta)
        {
            InitializeComponent();
            List<Dzerald> rezultantni_dzeraldi = new List<Dzerald>();
            foreach (Dzerald dzerald in listadzeralda)
                if (dzerald.Valuta == valuta)
                    rezultantni_dzeraldi.Add(dzerald);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rezultantni_dzeraldi;
            dataGridView1.Refresh();
        }

        private void bturedu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
