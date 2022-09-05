using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Razlomci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Razlomak a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Razlomak(int.Parse(txti1.Text), int.Parse(txtb1.Text));
            b = new Razlomak(int.Parse(txti2.Text), int.Parse(txtb2.Text));
            c = a * b;
            txti3.Text = c.IspisiImenilac();
            txtb3.Text = c.IspisiBrojilac();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
