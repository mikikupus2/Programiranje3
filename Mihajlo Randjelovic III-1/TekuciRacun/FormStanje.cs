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
    public partial class FormStanje : Form
    {
        public FormStanje(double stanje)
        {
            InitializeComponent();
            LBStanje.Text = "Stanje: " + stanje.ToString();
        }

        private void BTUreduStanje_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
