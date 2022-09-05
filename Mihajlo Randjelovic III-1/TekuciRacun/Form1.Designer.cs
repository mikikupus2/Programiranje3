namespace TekuciRacun
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
            this.BTUplata = new System.Windows.Forms.Button();
            this.BTIsplata = new System.Windows.Forms.Button();
            this.BTStanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTUplata
            // 
            this.BTUplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTUplata.Location = new System.Drawing.Point(317, 140);
            this.BTUplata.Name = "BTUplata";
            this.BTUplata.Size = new System.Drawing.Size(139, 59);
            this.BTUplata.TabIndex = 4;
            this.BTUplata.Text = "Uplata";
            this.BTUplata.UseVisualStyleBackColor = true;
            this.BTUplata.Click += new System.EventHandler(this.BTUplata_Click);
            // 
            // BTIsplata
            // 
            this.BTIsplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIsplata.Location = new System.Drawing.Point(317, 214);
            this.BTIsplata.Name = "BTIsplata";
            this.BTIsplata.Size = new System.Drawing.Size(139, 59);
            this.BTIsplata.TabIndex = 5;
            this.BTIsplata.Text = "Isplata";
            this.BTIsplata.UseVisualStyleBackColor = true;
            this.BTIsplata.Click += new System.EventHandler(this.BTIsplata_Click);
            // 
            // BTStanje
            // 
            this.BTStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStanje.Location = new System.Drawing.Point(317, 289);
            this.BTStanje.Name = "BTStanje";
            this.BTStanje.Size = new System.Drawing.Size(139, 59);
            this.BTStanje.TabIndex = 6;
            this.BTStanje.Text = "Stanje";
            this.BTStanje.UseVisualStyleBackColor = true;
            this.BTStanje.Click += new System.EventHandler(this.BTStanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tekući račun";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTStanje);
            this.Controls.Add(this.BTIsplata);
            this.Controls.Add(this.BTUplata);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTUplata;
        private System.Windows.Forms.Button BTIsplata;
        private System.Windows.Forms.Button BTStanje;
        private System.Windows.Forms.Label label1;
    }
}

