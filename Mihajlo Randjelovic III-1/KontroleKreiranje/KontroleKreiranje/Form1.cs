using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontroleKreiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button dugme = new Button();
            dugme.Location = new Point(100, 100);
            dugme.Size = new Size(80, 50);
            dugme.Text = "Dugme";
            dugme.MouseClick += Dugme_MouseClick;
            Controls.Add(dugme);
            Label labela = new Label();
            labela.Location = new Point((this.Width / 2)- (labela.Width / 2), (this.Height / 2)- (labela.Height / 2));
            labela.Text = "Labela";
            Controls.Add(labela);
        }

        private void Dugme_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Pozdrav");
            for (int i = 0, y = 100; i < 5; i++, y+=30)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(200, y);
                Controls.Add(tb);
            }
            Random r = new Random();
            Button bt = new Button();
            int rx = r.Next(this.Width - bt.Width);
            int ry = r.Next(this.Height - bt.Height);
            bt.Location= new Point(rx, ry);
            Controls.Add(bt);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Location = e.Location;
            Controls.Add(tb);
        }
    }
}
