using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Figura F = null;
        Krug K = null;
        Pravougaonik P = null;
        Trougao T = null;
        private void btpov_Click(object sender, EventArgs e)
        {
            if (rbkrug.Checked)
            {
                K = new Krug(Convert.ToDouble(txta.Text), Convert.ToDouble(txtb.Text));
                F = K;
            }
            else if(rbPrav.Checked)
            {
                P = new Pravougaonik(Convert.ToDouble(txta.Text), Convert.ToDouble(txtb.Text));
                F = P;
            }
            else
            {
                T = new Trougao(Convert.ToDouble(txta.Text), Convert.ToDouble(txtb.Text));
                F = T;
            }
            F.Povrsina();
            txtp.Text = F.P.ToString();
        }

        private void rbPrav_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPrav.Checked)
            {
                lba.Text = "";
                lba.Text = "a=";
                lbb.Text = "";
                lbb.Text = "b=";
            }
            else if(rbkrug.Checked)
            {
                lba.Text = "";
                lba.Text = "x=";
                lbb.Text = "";
                lbb.Text = "y=";
            }
            else
            {
                lba.Text = "";
                lba.Text = "a=";
                lbb.Text = "";
                lbb.Text = "h=";
            }
        }
    }
}
