namespace ProjekatMenjacnica
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
            this.btok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiznos = new System.Windows.Forms.TextBox();
            this.lbkupovni = new System.Windows.Forms.Label();
            this.lbprodajni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbkup = new System.Windows.Forms.RadioButton();
            this.rbprod = new System.Windows.Forms.RadioButton();
            this.txtstanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btok
            // 
            this.btok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btok.Location = new System.Drawing.Point(220, 310);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(310, 43);
            this.btok.TabIndex = 0;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prodajni kurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kupovni kurs";
            // 
            // txtiznos
            // 
            this.txtiznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiznos.Location = new System.Drawing.Point(220, 264);
            this.txtiznos.Name = "txtiznos";
            this.txtiznos.Size = new System.Drawing.Size(310, 31);
            this.txtiznos.TabIndex = 7;
            // 
            // lbkupovni
            // 
            this.lbkupovni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbkupovni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkupovni.Location = new System.Drawing.Point(209, 76);
            this.lbkupovni.Name = "lbkupovni";
            this.lbkupovni.Size = new System.Drawing.Size(120, 28);
            this.lbkupovni.TabIndex = 8;
            this.lbkupovni.Text = "0";
            this.lbkupovni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbprodajni
            // 
            this.lbprodajni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbprodajni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprodajni.Location = new System.Drawing.Point(209, 122);
            this.lbprodajni.Name = "lbprodajni";
            this.lbprodajni.Size = new System.Drawing.Size(120, 28);
            this.lbprodajni.TabIndex = 9;
            this.lbprodajni.Text = "0";
            this.lbprodajni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stanje:";
            // 
            // rbkup
            // 
            this.rbkup.AutoSize = true;
            this.rbkup.Checked = true;
            this.rbkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbkup.Location = new System.Drawing.Point(220, 229);
            this.rbkup.Name = "rbkup";
            this.rbkup.Size = new System.Drawing.Size(120, 29);
            this.rbkup.TabIndex = 14;
            this.rbkup.TabStop = true;
            this.rbkup.Text = "Kupovina";
            this.rbkup.UseVisualStyleBackColor = true;
            // 
            // rbprod
            // 
            this.rbprod.AutoSize = true;
            this.rbprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbprod.Location = new System.Drawing.Point(426, 229);
            this.rbprod.Name = "rbprod";
            this.rbprod.Size = new System.Drawing.Size(104, 29);
            this.rbprod.TabIndex = 15;
            this.rbprod.Text = "Prodaja";
            this.rbprod.UseVisualStyleBackColor = true;
            // 
            // txtstanje
            // 
            this.txtstanje.Location = new System.Drawing.Point(489, 58);
            this.txtstanje.Multiline = true;
            this.txtstanje.Name = "txtstanje";
            this.txtstanje.ReadOnly = true;
            this.txtstanje.Size = new System.Drawing.Size(184, 78);
            this.txtstanje.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstanje);
            this.Controls.Add(this.rbprod);
            this.Controls.Add(this.rbkup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbprodajni);
            this.Controls.Add(this.lbkupovni);
            this.Controls.Add(this.txtiznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtiznos;
        private System.Windows.Forms.Label lbkupovni;
        private System.Windows.Forms.Label lbprodajni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbkup;
        private System.Windows.Forms.RadioButton rbprod;
        private System.Windows.Forms.TextBox txtstanje;
    }
}

