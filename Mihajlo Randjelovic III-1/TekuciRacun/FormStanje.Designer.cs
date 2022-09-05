namespace TekuciRacun
{
    partial class FormStanje
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
            this.LBStanje = new System.Windows.Forms.Label();
            this.BTUreduStanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBStanje
            // 
            this.LBStanje.AutoSize = true;
            this.LBStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStanje.Location = new System.Drawing.Point(288, 173);
            this.LBStanje.Name = "LBStanje";
            this.LBStanje.Size = new System.Drawing.Size(201, 39);
            this.LBStanje.TabIndex = 0;
            this.LBStanje.Text = "Stanje:1000";
            // 
            // BTUreduStanje
            // 
            this.BTUreduStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTUreduStanje.Location = new System.Drawing.Point(299, 229);
            this.BTUreduStanje.Name = "BTUreduStanje";
            this.BTUreduStanje.Size = new System.Drawing.Size(179, 61);
            this.BTUreduStanje.TabIndex = 1;
            this.BTUreduStanje.Text = "U redu";
            this.BTUreduStanje.UseVisualStyleBackColor = true;
            this.BTUreduStanje.Click += new System.EventHandler(this.BTUreduStanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stanje računa";
            // 
            // FormStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTUreduStanje);
            this.Controls.Add(this.LBStanje);
            this.Name = "FormStanje";
            this.Text = "Stanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBStanje;
        private System.Windows.Forms.Button BTUreduStanje;
        private System.Windows.Forms.Label label1;
    }
}