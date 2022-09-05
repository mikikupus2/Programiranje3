namespace TekuciRacun
{
    partial class FormIsplata
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
            this.BTIsplataIsplati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBiznosIsplata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTIsplataIsplati
            // 
            this.BTIsplataIsplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIsplataIsplati.Location = new System.Drawing.Point(270, 272);
            this.BTIsplataIsplati.Name = "BTIsplataIsplati";
            this.BTIsplataIsplati.Size = new System.Drawing.Size(229, 63);
            this.BTIsplataIsplati.TabIndex = 5;
            this.BTIsplataIsplati.Text = "Isplati";
            this.BTIsplataIsplati.UseVisualStyleBackColor = true;
            this.BTIsplataIsplati.Click += new System.EventHandler(this.BTIsplataIsplati_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite iznos:";
            // 
            // TBiznosIsplata
            // 
            this.TBiznosIsplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBiznosIsplata.Location = new System.Drawing.Point(270, 204);
            this.TBiznosIsplata.Name = "TBiznosIsplata";
            this.TBiznosIsplata.Size = new System.Drawing.Size(229, 47);
            this.TBiznosIsplata.TabIndex = 3;
            this.TBiznosIsplata.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Isplata";
            // 
            // FormIsplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTIsplataIsplati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBiznosIsplata);
            this.Name = "FormIsplata";
            this.Text = "FormIsplata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTIsplataIsplati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBiznosIsplata;
        private System.Windows.Forms.Label label2;
    }
}