namespace KontrolniZadatak31
{
    partial class FormaUnosa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btunesi = new System.Windows.Forms.Button();
            this.tbsifra = new System.Windows.Forms.TextBox();
            this.tbime = new System.Windows.Forms.TextBox();
            this.tbprezime = new System.Windows.Forms.TextBox();
            this.tbvaluta = new System.Windows.Forms.TextBox();
            this.tbiznos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valuta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iznos";
            // 
            // btunesi
            // 
            this.btunesi.Location = new System.Drawing.Point(308, 256);
            this.btunesi.Name = "btunesi";
            this.btunesi.Size = new System.Drawing.Size(151, 47);
            this.btunesi.TabIndex = 5;
            this.btunesi.Text = "Unesi";
            this.btunesi.UseVisualStyleBackColor = true;
            this.btunesi.Click += new System.EventHandler(this.btunesi_Click);
            // 
            // tbsifra
            // 
            this.tbsifra.Location = new System.Drawing.Point(359, 126);
            this.tbsifra.Name = "tbsifra";
            this.tbsifra.Size = new System.Drawing.Size(100, 20);
            this.tbsifra.TabIndex = 7;
            // 
            // tbime
            // 
            this.tbime.Location = new System.Drawing.Point(359, 152);
            this.tbime.Name = "tbime";
            this.tbime.Size = new System.Drawing.Size(100, 20);
            this.tbime.TabIndex = 8;
            // 
            // tbprezime
            // 
            this.tbprezime.Location = new System.Drawing.Point(359, 178);
            this.tbprezime.Name = "tbprezime";
            this.tbprezime.Size = new System.Drawing.Size(100, 20);
            this.tbprezime.TabIndex = 9;
            // 
            // tbvaluta
            // 
            this.tbvaluta.Location = new System.Drawing.Point(359, 204);
            this.tbvaluta.Name = "tbvaluta";
            this.tbvaluta.Size = new System.Drawing.Size(100, 20);
            this.tbvaluta.TabIndex = 10;
            // 
            // tbiznos
            // 
            this.tbiznos.Location = new System.Drawing.Point(359, 230);
            this.tbiznos.Name = "tbiznos";
            this.tbiznos.Size = new System.Drawing.Size(100, 20);
            this.tbiznos.TabIndex = 11;
            // 
            // FormaUnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbiznos);
            this.Controls.Add(this.tbvaluta);
            this.Controls.Add(this.tbprezime);
            this.Controls.Add(this.tbime);
            this.Controls.Add(this.tbsifra);
            this.Controls.Add(this.btunesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaUnosa";
            this.Text = "FormaUnosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btunesi;
        private System.Windows.Forms.TextBox tbsifra;
        private System.Windows.Forms.TextBox tbime;
        private System.Windows.Forms.TextBox tbprezime;
        private System.Windows.Forms.TextBox tbvaluta;
        private System.Windows.Forms.TextBox tbiznos;
    }
}