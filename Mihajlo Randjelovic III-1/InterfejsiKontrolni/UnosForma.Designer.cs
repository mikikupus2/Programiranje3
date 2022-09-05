namespace InterfejsiKontrolni
{
    partial class UnosForma
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
            this.TBIme = new System.Windows.Forms.TextBox();
            this.TBPrezime = new System.Windows.Forms.TextBox();
            this.TBBroj_poena = new System.Windows.Forms.TextBox();
            this.BTOKUnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBIme
            // 
            this.TBIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBIme.Location = new System.Drawing.Point(394, 123);
            this.TBIme.Name = "TBIme";
            this.TBIme.Size = new System.Drawing.Size(184, 47);
            this.TBIme.TabIndex = 0;
            // 
            // TBPrezime
            // 
            this.TBPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrezime.Location = new System.Drawing.Point(394, 185);
            this.TBPrezime.Name = "TBPrezime";
            this.TBPrezime.Size = new System.Drawing.Size(184, 47);
            this.TBPrezime.TabIndex = 1;
            // 
            // TBBroj_poena
            // 
            this.TBBroj_poena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBroj_poena.Location = new System.Drawing.Point(394, 251);
            this.TBBroj_poena.Name = "TBBroj_poena";
            this.TBBroj_poena.Size = new System.Drawing.Size(184, 47);
            this.TBBroj_poena.TabIndex = 2;
            // 
            // BTOKUnos
            // 
            this.BTOKUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTOKUnos.Location = new System.Drawing.Point(208, 318);
            this.BTOKUnos.Name = "BTOKUnos";
            this.BTOKUnos.Size = new System.Drawing.Size(370, 58);
            this.BTOKUnos.TabIndex = 3;
            this.BTOKUnos.Text = "OK";
            this.BTOKUnos.UseVisualStyleBackColor = true;
            this.BTOKUnos.Click += new System.EventHandler(this.BTOKUnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj Poena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(551, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unesite podatke ucenika";
            // 
            // UnosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTOKUnos);
            this.Controls.Add(this.TBBroj_poena);
            this.Controls.Add(this.TBPrezime);
            this.Controls.Add(this.TBIme);
            this.Name = "UnosForma";
            this.Text = "UnosForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBIme;
        private System.Windows.Forms.TextBox TBPrezime;
        private System.Windows.Forms.TextBox TBBroj_poena;
        private System.Windows.Forms.Button BTOKUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}