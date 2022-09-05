using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatoriKvadrat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(txtk1.Text), a2 = double.Parse(txtk2.Text);
            Kvadrat k1, k2, k3;
            k1 = new Kvadrat(a1);
            k2 = new Kvadrat(a2);
            if (k1 == k2)
                k3 = k2;
            else
                k3 = k1 + k2;
            txtk3.Text = k3.Stranica.ToString();
            txtk2.Text = k2.Stranica.ToString();
            txtk1.Text = k1.Stranica.ToString();
        }
    }
}
