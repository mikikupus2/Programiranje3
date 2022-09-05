namespace interfejsi23
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrez = new System.Windows.Forms.Label();
            this.btracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(195, 111);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 0;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(195, 148);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 20);
            this.txty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y=";
            // 
            // lblrez
            // 
            this.lblrez.AutoSize = true;
            this.lblrez.Location = new System.Drawing.Point(213, 234);
            this.lblrez.Name = "lblrez";
            this.lblrez.Size = new System.Drawing.Size(35, 13);
            this.lblrez.TabIndex = 4;
            this.lblrez.Text = "label3";
            // 
            // btracunaj
            // 
            this.btracunaj.Location = new System.Drawing.Point(172, 189);
            this.btracunaj.Name = "btracunaj";
            this.btracunaj.Size = new System.Drawing.Size(123, 23);
            this.btracunaj.TabIndex = 5;
            this.btracunaj.Text = "Izracunaj";
            this.btracunaj.UseVisualStyleBackColor = true;
            this.btracunaj.Click += new System.EventHandler(this.btracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btracunaj);
            this.Controls.Add(this.lblrez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrez;
        private System.Windows.Forms.Button btracunaj;
    }
}

