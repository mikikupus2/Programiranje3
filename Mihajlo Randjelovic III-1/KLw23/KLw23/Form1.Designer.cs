namespace KLw23
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtrazred = new System.Windows.Forms.TextBox();
            this.txtprosek = new System.Windows.Forms.TextBox();
            this.dgspisak = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbprvi = new System.Windows.Forms.RadioButton();
            this.rbdrugi = new System.Windows.Forms.RadioButton();
            this.rbtreci = new System.Windows.Forms.RadioButton();
            this.rbcetvrti = new System.Windows.Forms.RadioButton();
            this.rbsvi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbbru = new System.Windows.Forms.Label();
            this.lbprosek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgspisak)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ImeIPrezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razred";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prosek";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(101, 74);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(100, 20);
            this.txtime.TabIndex = 5;
            // 
            // txtrazred
            // 
            this.txtrazred.Location = new System.Drawing.Point(101, 103);
            this.txtrazred.Name = "txtrazred";
            this.txtrazred.Size = new System.Drawing.Size(100, 20);
            this.txtrazred.TabIndex = 6;
            // 
            // txtprosek
            // 
            this.txtprosek.Location = new System.Drawing.Point(101, 129);
            this.txtprosek.Name = "txtprosek";
            this.txtprosek.Size = new System.Drawing.Size(100, 20);
            this.txtprosek.TabIndex = 7;
            // 
            // dgspisak
            // 
            this.dgspisak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgspisak.Location = new System.Drawing.Point(224, 48);
            this.dgspisak.Name = "dgspisak";
            this.dgspisak.Size = new System.Drawing.Size(547, 349);
            this.dgspisak.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbsvi);
            this.panel1.Controls.Add(this.rbcetvrti);
            this.panel1.Controls.Add(this.rbtreci);
            this.panel1.Controls.Add(this.rbdrugi);
            this.panel1.Controls.Add(this.rbprvi);
            this.panel1.Location = new System.Drawing.Point(35, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 131);
            this.panel1.TabIndex = 10;
            // 
            // rbprvi
            // 
            this.rbprvi.AutoSize = true;
            this.rbprvi.Location = new System.Drawing.Point(37, 13);
            this.rbprvi.Name = "rbprvi";
            this.rbprvi.Size = new System.Drawing.Size(78, 17);
            this.rbprvi.TabIndex = 0;
            this.rbprvi.TabStop = true;
            this.rbprvi.Text = "Prvi razred ";
            this.rbprvi.UseVisualStyleBackColor = true;
            this.rbprvi.CheckedChanged += new System.EventHandler(this.rbprvi_CheckedChanged);
            // 
            // rbdrugi
            // 
            this.rbdrugi.AutoSize = true;
            this.rbdrugi.Location = new System.Drawing.Point(37, 36);
            this.rbdrugi.Name = "rbdrugi";
            this.rbdrugi.Size = new System.Drawing.Size(85, 17);
            this.rbdrugi.TabIndex = 1;
            this.rbdrugi.TabStop = true;
            this.rbdrugi.Text = "Drugi razred ";
            this.rbdrugi.UseVisualStyleBackColor = true;
            this.rbdrugi.CheckedChanged += new System.EventHandler(this.rbprvi_CheckedChanged);
            // 
            // rbtreci
            // 
            this.rbtreci.AutoSize = true;
            this.rbtreci.Location = new System.Drawing.Point(37, 59);
            this.rbtreci.Name = "rbtreci";
            this.rbtreci.Size = new System.Drawing.Size(81, 17);
            this.rbtreci.TabIndex = 2;
            this.rbtreci.TabStop = true;
            this.rbtreci.Text = "Treci razred";
            this.rbtreci.UseVisualStyleBackColor = true;
            this.rbtreci.CheckedChanged += new System.EventHandler(this.rbprvi_CheckedChanged);
            // 
            // rbcetvrti
            // 
            this.rbcetvrti.AutoSize = true;
            this.rbcetvrti.Location = new System.Drawing.Point(37, 82);
            this.rbcetvrti.Name = "rbcetvrti";
            this.rbcetvrti.Size = new System.Drawing.Size(87, 17);
            this.rbcetvrti.TabIndex = 3;
            this.rbcetvrti.TabStop = true;
            this.rbcetvrti.Text = "Cetvrti razred";
            this.rbcetvrti.UseVisualStyleBackColor = true;
            this.rbcetvrti.CheckedChanged += new System.EventHandler(this.rbprvi_CheckedChanged);
            // 
            // rbsvi
            // 
            this.rbsvi.AutoSize = true;
            this.rbsvi.Location = new System.Drawing.Point(37, 105);
            this.rbsvi.Name = "rbsvi";
            this.rbsvi.Size = new System.Drawing.Size(40, 17);
            this.rbsvi.TabIndex = 11;
            this.rbsvi.TabStop = true;
            this.rbsvi.Text = "Svi";
            this.rbsvi.UseVisualStyleBackColor = true;
            this.rbsvi.CheckedChanged += new System.EventHandler(this.rbprvi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Razred";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prosecna ocena";
            // 
            // lbbru
            // 
            this.lbbru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbbru.Location = new System.Drawing.Point(122, 339);
            this.lbbru.Name = "lbbru";
            this.lbbru.Size = new System.Drawing.Size(79, 23);
            this.lbbru.TabIndex = 13;
            this.lbbru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbprosek
            // 
            this.lbprosek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbprosek.Location = new System.Drawing.Point(122, 374);
            this.lbprosek.Name = "lbprosek";
            this.lbprosek.Size = new System.Drawing.Size(79, 23);
            this.lbprosek.TabIndex = 14;
            this.lbprosek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbprosek);
            this.Controls.Add(this.lbbru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgspisak);
            this.Controls.Add(this.txtprosek);
            this.Controls.Add(this.txtrazred);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgspisak)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtrazred;
        private System.Windows.Forms.TextBox txtprosek;
        private System.Windows.Forms.DataGridView dgspisak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbsvi;
        private System.Windows.Forms.RadioButton rbcetvrti;
        private System.Windows.Forms.RadioButton rbtreci;
        private System.Windows.Forms.RadioButton rbdrugi;
        private System.Windows.Forms.RadioButton rbprvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbbru;
        private System.Windows.Forms.Label lbprosek;
    }
}

