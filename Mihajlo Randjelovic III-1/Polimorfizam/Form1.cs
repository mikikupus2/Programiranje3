using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Osoba[] os = new Osoba[100];
        int vrsta;
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            /*txtbroj.Enabled = true;
            vrsta = r.Next(1, 4);
            if (vrsta == 1)
            {
                lblvrsta.Text = "Podarci o osobi";
                txtbroj.Enabled = false;
            }
            else if(vrsta == 2)
                lblvrsta.Text = "Podaci o uceniku";
            else
                lblvrsta.Text = "Podaci o penzioneru";*/
            for(int i=0;i<100;i++)
            {
                vrsta = r.Next(1, 4);
                if (vrsta == 1)
                    os[i] = new Osoba("x", "y");
                else if (vrsta == 2)
                    os[i] = new Ucenik("x", "y", 5.0);
                else
                    os[i] = new Penzioner("x", "y", 60);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (vrsta == 1)
            {
                os = new Osoba(txtime.Text, txtprez.Text);
                txtrez.Text = os.Predstavi_se();
            }
            else if(vrsta == 2)
            {
                os = new Ucenik(txtime.Text, txtprez.Text,double.Parse(txtbroj.Text));
                txtrez.Text = os.Predstavi_se();
            }
            else
            {
                os = new Penzioner(txtime.Text, txtprez.Text, int.Parse(txtbroj.Text));
                txtrez.Text = os.Predstavi_se();
            }*/
            lbrez.Items.Clear();
            for (int i = 0; i < 100; i++)
                lbrez.Items.Add(os[i].Predstavi_se());
        }
    }
}
