namespace Win1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbporuka = new System.Windows.Forms.Label();
            this.txA = new System.Windows.Forms.TextBox();
            this.txB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbporuka
            // 
            this.lbporuka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbporuka.Location = new System.Drawing.Point(358, 241);
            this.lbporuka.Name = "lbporuka";
            this.lbporuka.Size = new System.Drawing.Size(100, 23);
            this.lbporuka.TabIndex = 1;
            this.lbporuka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txA
            // 
            this.txA.Location = new System.Drawing.Point(358, 87);
            this.txA.Name = "txA";
            this.txA.Size = new System.Drawing.Size(100, 20);
            this.txA.TabIndex = 2;
            this.txA.Text = "0";
            this.txA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txB
            // 
            this.txB.Location = new System.Drawing.Point(358, 132);
            this.txB.Name = "txB";
            this.txB.Size = new System.Drawing.Size(100, 20);
            this.txB.TabIndex = 3;
            this.txB.Text = "0";
            this.txB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "A+B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txB);
            this.Controls.Add(this.txA);
            this.Controls.Add(this.lbporuka);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Sabiranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbporuka;
        private System.Windows.Forms.TextBox txA;
        private System.Windows.Forms.TextBox txB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

