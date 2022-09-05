using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proizvodi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
        List<Proizvod> lista_proizvoda = new List<Proizvod>();
        private void button1_Click(object sender, EventArgs e)
        {
            if(rbprehrambeni.Checked)
            {
                Prehrambeni novi = new Prehrambeni(txtnaziv.Text, double.Parse(txtcena.Text), DTPproizvodnja.Value, DTProk.Value);
                lista_proizvoda.Add(novi);
            }
            else
            {
                Tehnicki novi = new Tehnicki(txtnaziv.Text, double.Parse(txtcena.Text), DTPproizvodnja.Value, int.Parse(txtgarancija.Text));
                lista_proizvoda.Add(novi);
            }
            lbproizvodi.Items.Clear();
            for (int i = 0; i < lista_proizvoda.Count; i++)
            {
                if (lista_proizvoda[i] is Prehrambeni)
                    lbproizvodi.Items.Add(lista_proizvoda[i].GetType().ToString() + ", " + lista_proizvoda[i].Naziv.ToString() + ", " + lista_proizvoda[i].Cena.ToString() + ", " + lista_proizvoda[i].Datum_proizvodnje.ToString());
                else if (lista_proizvoda[i] is Tehnicki)
                    lbproizvodi.Items.Add(lista_proizvoda[i].GetType().ToString() + ", " + lista_proizvoda[i].Naziv.ToString() + ", " + lista_proizvoda[i].Cena.ToString() + ", " + lista_proizvoda[i].Datum_proizvodnje.ToString());
            }
            for (int i = 0; i < lista_proizvoda.Count; i++)
            {
               if(lista_proizvoda[i].Upotrebljiv())
                    lbrez.Items.Add(lista_proizvoda[i].GetType().ToString() + ", " + lista_proizvoda[i].Naziv.ToString() + ", " + lista_proizvoda[i].Cena.ToString() + ", " + lista_proizvoda[i].Datum_proizvodnje.ToString());
            }

        }
    }
}
