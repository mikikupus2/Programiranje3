using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrijskaTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valjak a = new Valjak();
            a.R = double.Parse(textBox1.Text);
            a.H = double.Parse(textBox2.Text);
            a.Povrsina();
            a.Zapremina();
            lblp.Text = a.P.ToString();
            lblv.Text = a.V.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kupa a = new Kupa();
            a.R = double.Parse(textBox1.Text);
            a.H = double.Parse(textBox2.Text);
            a.Povrsina();
            a.Zapremina();
            lblp.Text = a.P.ToString();
            lblv.Text = a.V.ToString();
        }
    }
}/*ZA DOMACI DA METODE ZA POVRSINU I ZAPREMINU BUDU STATICKE*/
