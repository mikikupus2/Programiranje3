namespace Polimorfizam
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
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprez = new System.Windows.Forms.TextBox();
            this.txtbroj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblvrsta = new System.Windows.Forms.Label();
            this.txtrez = new System.Windows.Forms.TextBox();
            this.lbrez = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(140, 127);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(197, 20);
            this.txtime.TabIndex = 0;
            // 
            // txtprez
            // 
            this.txtprez.Location = new System.Drawing.Point(140, 153);
            this.txtprez.Name = "txtprez";
            this.txtprez.Size = new System.Drawing.Size(197, 20);
            this.txtprez.TabIndex = 1;
            // 
            // txtbroj
            // 
            this.txtbroj.Location = new System.Drawing.Point(140, 179);
            this.txtbroj.Name = "txtbroj";
            this.txtbroj.Size = new System.Drawing.Size(197, 20);
            this.txtbroj.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Prikazi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblvrsta
            // 
            this.lblvrsta.Location = new System.Drawing.Point(137, 107);
            this.lblvrsta.Name = "lblvrsta";
            this.lblvrsta.Size = new System.Drawing.Size(200, 17);
            this.lblvrsta.TabIndex = 5;
            this.lblvrsta.Text = "Prikazi";
            // 
            // txtrez
            // 
            this.txtrez.Location = new System.Drawing.Point(394, 111);
            this.txtrez.Name = "txtrez";
            this.txtrez.Size = new System.Drawing.Size(197, 20);
            this.txtrez.TabIndex = 6;
            // 
            // lbrez
            // 
            this.lbrez.FormattingEnabled = true;
            this.lbrez.Location = new System.Drawing.Point(413, 163);
            this.lbrez.Name = "lbrez";
            this.lbrez.Size = new System.Drawing.Size(197, 225);
            this.lbrez.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbrez);
            this.Controls.Add(this.txtrez);
            this.Controls.Add(this.lblvrsta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbroj);
            this.Controls.Add(this.txtprez);
            this.Controls.Add(this.txtime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprez;
        private System.Windows.Forms.TextBox txtbroj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblvrsta;
        private System.Windows.Forms.TextBox txtrez;
        private System.Windows.Forms.ListBox lbrez;
    }
}

