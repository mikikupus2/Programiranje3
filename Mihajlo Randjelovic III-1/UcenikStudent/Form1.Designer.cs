namespace UcenikStudent
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtocena = new System.Windows.Forms.TextBox();
            this.txtbroj = new System.Windows.Forms.TextBox();
            this.lbkandidati = new System.Windows.Forms.ListBox();
            this.lbbroj = new System.Windows.Forms.Label();
            this.lbrez = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(162, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(544, 20);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ocena=";
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(162, 52);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(544, 20);
            this.txtime.TabIndex = 6;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(162, 78);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(544, 20);
            this.txtprezime.TabIndex = 7;
            // 
            // txtocena
            // 
            this.txtocena.Location = new System.Drawing.Point(162, 104);
            this.txtocena.Name = "txtocena";
            this.txtocena.Size = new System.Drawing.Size(544, 20);
            this.txtocena.TabIndex = 8;
            this.txtocena.TextChanged += new System.EventHandler(this.txtocena_TextChanged);
            // 
            // txtbroj
            // 
            this.txtbroj.Location = new System.Drawing.Point(162, 130);
            this.txtbroj.Name = "txtbroj";
            this.txtbroj.ReadOnly = true;
            this.txtbroj.Size = new System.Drawing.Size(544, 20);
            this.txtbroj.TabIndex = 9;
            // 
            // lbkandidati
            // 
            this.lbkandidati.FormattingEnabled = true;
            this.lbkandidati.Location = new System.Drawing.Point(80, 208);
            this.lbkandidati.Name = "lbkandidati";
            this.lbkandidati.Size = new System.Drawing.Size(626, 186);
            this.lbkandidati.TabIndex = 10;
            // 
            // lbbroj
            // 
            this.lbbroj.AutoSize = true;
            this.lbbroj.Location = new System.Drawing.Point(77, 133);
            this.lbbroj.Name = "lbbroj";
            this.lbbroj.Size = new System.Drawing.Size(31, 13);
            this.lbbroj.TabIndex = 11;
            this.lbbroj.Text = "???=";
            // 
            // lbrez
            // 
            this.lbrez.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbrez.Location = new System.Drawing.Point(80, 397);
            this.lbrez.Name = "lbrez";
            this.lbrez.Size = new System.Drawing.Size(626, 31);
            this.lbrez.TabIndex = 12;
            this.lbrez.Text = "Rezultat";
            this.lbrez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(626, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Unesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mihajlo Randjelovic III-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbrez);
            this.Controls.Add(this.lbbroj);
            this.Controls.Add(this.lbkandidati);
            this.Controls.Add(this.txtbroj);
            this.Controls.Add(this.txtocena);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtocena;
        private System.Windows.Forms.TextBox txtbroj;
        private System.Windows.Forms.ListBox lbkandidati;
        private System.Windows.Forms.Label lbbroj;
        private System.Windows.Forms.Label lbrez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

