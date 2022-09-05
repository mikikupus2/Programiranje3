namespace InterfejsiKontrolni
{
    partial class IzvestajForma
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
            this.TBIzvestaj = new System.Windows.Forms.TextBox();
            this.BTOKIzvestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBIzvestaj
            // 
            this.TBIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBIzvestaj.Location = new System.Drawing.Point(170, 55);
            this.TBIzvestaj.Multiline = true;
            this.TBIzvestaj.Name = "TBIzvestaj";
            this.TBIzvestaj.ReadOnly = true;
            this.TBIzvestaj.Size = new System.Drawing.Size(470, 266);
            this.TBIzvestaj.TabIndex = 0;
            // 
            // BTOKIzvestaj
            // 
            this.BTOKIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTOKIzvestaj.Location = new System.Drawing.Point(170, 345);
            this.BTOKIzvestaj.Name = "BTOKIzvestaj";
            this.BTOKIzvestaj.Size = new System.Drawing.Size(470, 58);
            this.BTOKIzvestaj.TabIndex = 4;
            this.BTOKIzvestaj.Text = "OK";
            this.BTOKIzvestaj.UseVisualStyleBackColor = true;
            this.BTOKIzvestaj.Click += new System.EventHandler(this.BTOKIzvestaj_Click);
            // 
            // IzvestajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTOKIzvestaj);
            this.Controls.Add(this.TBIzvestaj);
            this.Name = "IzvestajForma";
            this.Text = "IzvestajForma";
            this.Load += new System.EventHandler(this.IzvestajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBIzvestaj;
        private System.Windows.Forms.Button BTOKIzvestaj;
    }
}