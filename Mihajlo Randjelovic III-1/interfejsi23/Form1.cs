using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfejsi23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btracunaj_Click(object sender, EventArgs e)
        {
            Analiticka a = new Analiticka();
            a.X = double.Parse(txtx.Text);
            a.Y = double.Parse(txty.Text);
            lblrez.Text = a.Odstojanje().ToString();
        }
    }
}
