using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritmetika;
using Nestaticke;
/*napraviti staticku klasu koja ima metode kvadrata 
 * i kub i uraditi kao windows aplikaciju*/
namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Calculator.Kvadrat(double.Parse(textBox1.Text)).ToString();
            //label2.Text = Calculator.Kub(double.Parse(textBox1.Text)).ToString();
            label1.Text = Realni.Kvadrat(double.Parse(textBox1.Text)).ToString();
            label2.Text = Realni.Kub(double.Parse(textBox1.Text)).ToString();
            Realnib obj1 = new Realnib();
            label3.Text = obj1.Kvadrat(double.Parse(textBox1.Text)).ToString();
        }
    }
}
