using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Mihajlo Randjelovic III-1*/
namespace UcenikStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Osnovna> lista_kandidata = new List<Osnovna>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtime.Text != "" && txtprezime.Text != "" && txtocena.Text != "" && txtbroj.Text != "")
            {
                if (int.Parse(txtocena.Text) > 5)
                {
                    Student novi = new Student(int.Parse(txtid.Text), txtime.Text, txtprezime.Text, int.Parse(txtbroj.Text), int.Parse(txtocena.Text));
                    lista_kandidata.Add(novi);
                }
                else
                {
                    Ucenik novi = new Ucenik(int.Parse(txtid.Text), txtime.Text, txtprezime.Text, double.Parse(txtbroj.Text), int.Parse(txtocena.Text));
                    lista_kandidata.Add(novi);
                }
                lbkandidati.Items.Clear();
                int broj_studenata = 0, broj_ucenika = 0;
                for (int i = 0; i < lista_kandidata.Count; i++)
                {
                    if (lista_kandidata[i] is Ucenik)
                    {
                        lbkandidati.Items.Add(lista_kandidata[i].GetType().ToString().Substring(14) + ", " + lista_kandidata[i].Ime + ", " + lista_kandidata[i].Prezime +
                            ", Ocena:" + ((Ucenik)lista_kandidata[i]).Ocena_iz_programiranja.ToString() + ", Prosek:" + ((Ucenik)lista_kandidata[i]).Prosek.ToString());
                        broj_ucenika++;
                    }
                    else if (lista_kandidata[i] is Student)
                    {
                        lbkandidati.Items.Add(lista_kandidata[i].GetType().ToString().Substring(14) + ", " + lista_kandidata[i].Ime + ", " + lista_kandidata[i].Prezime
                            +", Ocena:" + ((Student)lista_kandidata[i]).Ocena_iz_programiranja.ToString() + ", Broj ispita:" + ((Student)lista_kandidata[i]).Broj_casova.ToString());
                        broj_studenata++;
                    }
                        
                }
                lbrez.Text = "Broj Ucenika: " + broj_ucenika.ToString() + ", Broj Studenata: " + broj_studenata.ToString() + ", Ukupan broj: " + lista_kandidata.Count.ToString();
            }
            else
                MessageBox.Show("Niste lepo uneli podatke!", "GRESKA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtid.Text = txtime.Text = txtprezime.Text = txtocena.Text = txtbroj.Text = "";
            lbbroj.Text = "???=";
            txtbroj.ReadOnly = true;
        }

        private void txtocena_TextChanged(object sender, EventArgs e)
        {
            if(txtocena.Text != "")
            {
                if (int.Parse(txtocena.Text) > 5)
                {
                    lbbroj.Text = "Broj casova=";
                    txtbroj.ReadOnly = false;
                }
                else
                {
                    lbbroj.Text = "Prosek=";
                    txtbroj.ReadOnly = false;
                }
            }
        }
    }
}
