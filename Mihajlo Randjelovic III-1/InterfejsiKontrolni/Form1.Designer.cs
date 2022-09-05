namespace InterfejsiKontrolni
{
    partial class GlavnaForma
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
            this.BTUnos = new System.Windows.Forms.Button();
            this.BTOcena = new System.Windows.Forms.Button();
            this.BTIzvestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTUnos
            // 
            this.BTUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTUnos.Location = new System.Drawing.Point(225, 65);
            this.BTUnos.Name = "BTUnos";
            this.BTUnos.Size = new System.Drawing.Size(304, 93);
            this.BTUnos.TabIndex = 0;
            this.BTUnos.Text = "Unos";
            this.BTUnos.UseVisualStyleBackColor = true;
            this.BTUnos.Click += new System.EventHandler(this.BTUnos_Click);
            // 
            // BTOcena
            // 
            this.BTOcena.Enabled = false;
            this.BTOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTOcena.Location = new System.Drawing.Point(225, 164);
            this.BTOcena.Name = "BTOcena";
            this.BTOcena.Size = new System.Drawing.Size(304, 93);
            this.BTOcena.TabIndex = 1;
            this.BTOcena.Text = "Oceni";
            this.BTOcena.UseVisualStyleBackColor = true;
            this.BTOcena.Click += new System.EventHandler(this.BTOcena_Click);
            // 
            // BTIzvestaj
            // 
            this.BTIzvestaj.Enabled = false;
            this.BTIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIzvestaj.Location = new System.Drawing.Point(225, 263);
            this.BTIzvestaj.Name = "BTIzvestaj";
            this.BTIzvestaj.Size = new System.Drawing.Size(304, 93);
            this.BTIzvestaj.TabIndex = 2;
            this.BTIzvestaj.Text = "Izvestaj";
            this.BTIzvestaj.UseVisualStyleBackColor = true;
            this.BTIzvestaj.Click += new System.EventHandler(this.BTIzvestaj_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTIzvestaj);
            this.Controls.Add(this.BTOcena);
            this.Controls.Add(this.BTUnos);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTUnos;
        private System.Windows.Forms.Button BTOcena;
        private System.Windows.Forms.Button BTIzvestaj;
    }
}

