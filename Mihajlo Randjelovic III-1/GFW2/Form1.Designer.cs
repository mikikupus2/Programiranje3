namespace GFW2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtroug = new System.Windows.Forms.RadioButton();
            this.rbkrug = new System.Windows.Forms.RadioButton();
            this.rbPrav = new System.Windows.Forms.RadioButton();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.btpov = new System.Windows.Forms.Button();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtroug);
            this.panel1.Controls.Add(this.rbkrug);
            this.panel1.Controls.Add(this.rbPrav);
            this.panel1.Location = new System.Drawing.Point(87, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 135);
            this.panel1.TabIndex = 0;
            // 
            // rbtroug
            // 
            this.rbtroug.AutoSize = true;
            this.rbtroug.Location = new System.Drawing.Point(24, 99);
            this.rbtroug.Name = "rbtroug";
            this.rbtroug.Size = new System.Drawing.Size(65, 17);
            this.rbtroug.TabIndex = 2;
            this.rbtroug.Text = "Trougao";
            this.rbtroug.UseVisualStyleBackColor = true;
            this.rbtroug.CheckedChanged += new System.EventHandler(this.rbPrav_CheckedChanged);
            // 
            // rbkrug
            // 
            this.rbkrug.AutoSize = true;
            this.rbkrug.Location = new System.Drawing.Point(24, 59);
            this.rbkrug.Name = "rbkrug";
            this.rbkrug.Size = new System.Drawing.Size(47, 17);
            this.rbkrug.TabIndex = 1;
            this.rbkrug.Text = "Krug";
            this.rbkrug.UseVisualStyleBackColor = true;
            this.rbkrug.CheckedChanged += new System.EventHandler(this.rbPrav_CheckedChanged);
            // 
            // rbPrav
            // 
            this.rbPrav.AutoSize = true;
            this.rbPrav.Checked = true;
            this.rbPrav.Location = new System.Drawing.Point(24, 19);
            this.rbPrav.Name = "rbPrav";
            this.rbPrav.Size = new System.Drawing.Size(91, 17);
            this.rbPrav.TabIndex = 0;
            this.rbPrav.TabStop = true;
            this.rbPrav.Text = "Pravougaonik";
            this.rbPrav.UseVisualStyleBackColor = true;
            this.rbPrav.CheckedChanged += new System.EventHandler(this.rbPrav_CheckedChanged);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(387, 195);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(387, 249);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 2;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(668, 222);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(100, 20);
            this.txtp.TabIndex = 3;
            // 
            // btpov
            // 
            this.btpov.Location = new System.Drawing.Point(517, 214);
            this.btpov.Name = "btpov";
            this.btpov.Size = new System.Drawing.Size(87, 35);
            this.btpov.TabIndex = 4;
            this.btpov.Text = "Povrsina";
            this.btpov.UseVisualStyleBackColor = true;
            this.btpov.Click += new System.EventHandler(this.btpov_Click);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(362, 198);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(19, 13);
            this.lba.TabIndex = 5;
            this.lba.Text = "a=";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(362, 256);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(19, 13);
            this.lbb.TabIndex = 6;
            this.lbb.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "P=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.btpov);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtroug;
        private System.Windows.Forms.RadioButton rbkrug;
        private System.Windows.Forms.RadioButton rbPrav;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Button btpov;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label label3;
    }
}

