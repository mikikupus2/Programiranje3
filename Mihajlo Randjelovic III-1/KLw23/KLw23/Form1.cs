using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLw23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ucenik[] Ucenici = new Ucenik[50];
        Ucenik jedanU = null;
        int bru = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int id, razred;
            double prosek;
            string ime;
            id = int.Parse(txtId.Text);
            if(id != 0)
            {
                ime = txtime.Text;
                razred = int.Parse(txtrazred.Text);
                prosek = double.Parse(txtprosek.Text);
                jedanU = new Ucenik(id, ime, razred, prosek);
                Ucenici[bru] = jedanU;
                bru++;
                dgspisak.DataSource = null;
                dgspisak.Rows.Clear();
                dgspisak.DataSource = Ucenici;
                //dgspisak.Refresh();
            }
        }

        private void rbprvi_CheckedChanged(object sender, EventArgs e)
        {
            Ucenik[] Razred = new Ucenik[50];
            int brr = 0, razred, j =0;
            double prr = 0;
            if (rbprvi.Checked)
                razred = 1;
            else if (rbdrugi.Checked)
                razred = 2;
            else if (rbtreci.Checked)
                razred = 3;
            else if (rbcetvrti.Checked)
                razred = 4;
            else
                razred = 0;
            for(int i=0;i<bru;i++)
            {
                if(Ucenici[i].Razred == razred)
                {
                    brr++;
                    prr += Ucenici[i].Prosek;
                    Razred[j++] = Ucenici[i];
                }
            }
            dgspisak.DataSource = null;
            dgspisak.Rows.Clear();
            dgspisak.DataSource = Razred;
            if (brr > 0)
            {

                lbbru.Text = brr.ToString();
                lbprosek.Text = (prr / brr).ToString();
            }
            else
            {
                lbbru.Text = "Nema";
                lbprosek.Text = "";
            }   
        }
    }
}
