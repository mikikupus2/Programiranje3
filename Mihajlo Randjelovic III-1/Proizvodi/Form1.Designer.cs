namespace Proizvodi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbproizvodi = new System.Windows.Forms.ListBox();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.lbrez = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbprehrambeni = new System.Windows.Forms.RadioButton();
            this.rbtehnicki = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtgarancija = new System.Windows.Forms.TextBox();
            this.DTPproizvodnja = new System.Windows.Forms.DateTimePicker();
            this.DTProk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbproizvodi
            // 
            this.lbproizvodi.FormattingEnabled = true;
            this.lbproizvodi.Location = new System.Drawing.Point(338, 119);
            this.lbproizvodi.Name = "lbproizvodi";
            this.lbproizvodi.Size = new System.Drawing.Size(222, 238);
            this.lbproizvodi.TabIndex = 0;
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(199, 35);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(100, 20);
            this.txtnaziv.TabIndex = 1;
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(199, 61);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(100, 20);
            this.txtcena.TabIndex = 2;
            // 
            // lbrez
            // 
            this.lbrez.FormattingEnabled = true;
            this.lbrez.Location = new System.Drawing.Point(566, 119);
            this.lbrez.Name = "lbrez";
            this.lbrez.Size = new System.Drawing.Size(222, 238);
            this.lbrez.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cena";
            // 
            // rbprehrambeni
            // 
            this.rbprehrambeni.AutoSize = true;
            this.rbprehrambeni.Location = new System.Drawing.Point(384, 76);
            this.rbprehrambeni.Name = "rbprehrambeni";
            this.rbprehrambeni.Size = new System.Drawing.Size(84, 17);
            this.rbprehrambeni.TabIndex = 7;
            this.rbprehrambeni.TabStop = true;
            this.rbprehrambeni.Text = "Prehrambeni";
            this.rbprehrambeni.UseVisualStyleBackColor = true;
            // 
            // rbtehnicki
            // 
            this.rbtehnicki.AutoSize = true;
            this.rbtehnicki.Location = new System.Drawing.Point(474, 76);
            this.rbtehnicki.Name = "rbtehnicki";
            this.rbtehnicki.Size = new System.Drawing.Size(66, 17);
            this.rbtehnicki.TabIndex = 8;
            this.rbtehnicki.TabStop = true;
            this.rbtehnicki.Text = "Tehnicki";
            this.rbtehnicki.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum proizvodnje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgarancija
            // 
            this.txtgarancija.Location = new System.Drawing.Point(201, 223);
            this.txtgarancija.Name = "txtgarancija";
            this.txtgarancija.Size = new System.Drawing.Size(100, 20);
            this.txtgarancija.TabIndex = 11;
            // 
            // DTPproizvodnja
            // 
            this.DTPproizvodnja.Location = new System.Drawing.Point(101, 102);
            this.DTPproizvodnja.Name = "DTPproizvodnja";
            this.DTPproizvodnja.Size = new System.Drawing.Size(200, 20);
            this.DTPproizvodnja.TabIndex = 12;
            // 
            // DTProk
            // 
            this.DTProk.Location = new System.Drawing.Point(101, 181);
            this.DTProk.Name = "DTProk";
            this.DTProk.Size = new System.Drawing.Size(200, 20);
            this.DTProk.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Garancija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rok Upotrebe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTProk);
            this.Controls.Add(this.DTPproizvodnja);
            this.Controls.Add(this.txtgarancija);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtehnicki);
            this.Controls.Add(this.rbprehrambeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbrez);
            this.Controls.Add(this.txtcena);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.lbproizvodi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbproizvodi;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.ListBox lbrez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbprehrambeni;
        private System.Windows.Forms.RadioButton rbtehnicki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtgarancija;
        private System.Windows.Forms.DateTimePicker DTPproizvodnja;
        private System.Windows.Forms.DateTimePicker DTProk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

