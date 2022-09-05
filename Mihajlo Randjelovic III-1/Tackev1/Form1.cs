using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tackev1 //Tackew1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btizracunaj_Click(object sender, EventArgs e)
        {
            Tacke a = new Tacke();
            a.X = double.Parse(textBox1.Text);
            a.Y = double.Parse(textBox2.Text);
            a.Rastojanje();
            lbrast.Text = a.D.ToString();
            //lbrast.Text = Math.Sqrt(Math.Pow(Convert.ToDouble(textBox2.Text), 2) + Math.Pow(Convert.ToDouble(textBox1.Text), 2)).ToString();
        }
    }
}
