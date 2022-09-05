using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrijskoTelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object[] niz = new object[50];
        int index = 0;
        private void btUnesi_Click(object sender, EventArgs e)
        {
            if(double.Parse(txth.Text)<= 0)
            {
                niz[index] = new Lopta(double.Parse(txtr.Text));
                index++;
            }
            else if(txtr.Text == "" || txth.Text == "")
            {
                MessageBox.Show("Niste lepo uneli podatke!", "GRESKA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                niz[index] = new Valjak(double.Parse(txtr.Text), double.Parse(txth.Text));
                index++;
            }
            listBox1.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                if (niz[i] is Lopta)
                    listBox1.Items.Add(niz[i].GetType().ToString().Substring(17) + "," + ((Lopta)niz[i]).V.ToString());
                else if (niz[i] is Valjak)
                    listBox1.Items.Add(niz[i].GetType().ToString().Substring(17) + "," + ((Valjak)niz[i]).V.ToString());
            }
            txth.Text = "0";
            txtr.Text = "0";
        }

        private void btNajvece_Click(object sender, EventArgs e)
        {
            List<Lopta> lopte = new List<Lopta>();
            List<Valjak> valjci = new List<Valjak>();
            for(int i = 0; i < index;i++)
            {
                if (niz[i] is Lopta)
                    lopte.Add((Lopta)niz[i]);
                else if (niz[i] is Valjak)
                    valjci.Add((Valjak)niz[i]);
            }
            if (rbLopta.Checked)
            {
                Lopta najveci = new Lopta(0);
                foreach (Lopta l in lopte)
                {
                    if (l >= najveci)
                        najveci = l;
                }
                lbNajvece.Text = najveci.ToString().Substring(17) + "," + najveci.V.ToString();
            }
            else
            {
                Valjak najveci = new Valjak(0, 0);
                foreach (Valjak v in valjci)
                {
                    if (v >= najveci)
                        najveci = v;
                }
                lbNajvece.Text = najveci.ToString().Substring(17) + "," + najveci.V.ToString();
            }
        }
    }
}
