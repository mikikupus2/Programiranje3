namespace TekuciRacun
{
    partial class FormUplata
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
            this.TBiznosUplata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTUplataUplati = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBiznosUplata
            // 
            this.TBiznosUplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBiznosUplata.Location = new System.Drawing.Point(276, 189);
            this.TBiznosUplata.Name = "TBiznosUplata";
            this.TBiznosUplata.Size = new System.Drawing.Size(229, 47);
            this.TBiznosUplata.TabIndex = 0;
            this.TBiznosUplata.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite iznos:";
            // 
            // BTUplataUplati
            // 
            this.BTUplataUplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTUplataUplati.Location = new System.Drawing.Point(276, 266);
            this.BTUplataUplati.Name = "BTUplataUplati";
            this.BTUplataUplati.Size = new System.Drawing.Size(229, 63);
            this.BTUplataUplati.TabIndex = 2;
            this.BTUplataUplati.Text = "Uplati";
            this.BTUplataUplati.UseVisualStyleBackColor = true;
            this.BTUplataUplati.Click += new System.EventHandler(this.BTUplataUplati_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "Uplata";
            // 
            // FormUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTUplataUplati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBiznosUplata);
            this.Name = "FormUplata";
            this.Text = "FormUplata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBiznosUplata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTUplataUplati;
        private System.Windows.Forms.Label label2;
    }
}