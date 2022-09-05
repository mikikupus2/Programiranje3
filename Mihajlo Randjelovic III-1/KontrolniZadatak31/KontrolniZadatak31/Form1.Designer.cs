namespace KontrolniZadatak31
{
    partial class GlavnaForma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btunos = new System.Windows.Forms.Button();
            this.btispis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbizabranavaluta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // btunos
            // 
            this.btunos.Location = new System.Drawing.Point(26, 363);
            this.btunos.Name = "btunos";
            this.btunos.Size = new System.Drawing.Size(75, 64);
            this.btunos.TabIndex = 1;
            this.btunos.Text = "Unos";
            this.btunos.UseVisualStyleBackColor = true;
            this.btunos.Click += new System.EventHandler(this.btunos_Click);
            // 
            // btispis
            // 
            this.btispis.Location = new System.Drawing.Point(691, 363);
            this.btispis.Name = "btispis";
            this.btispis.Size = new System.Drawing.Size(75, 64);
            this.btispis.TabIndex = 2;
            this.btispis.Text = "Ispis";
            this.btispis.UseVisualStyleBackColor = true;
            this.btispis.Click += new System.EventHandler(this.btispis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite izabranu valutu:";
            // 
            // tbizabranavaluta
            // 
            this.tbizabranavaluta.Location = new System.Drawing.Point(321, 386);
            this.tbizabranavaluta.Name = "tbizabranavaluta";
            this.tbizabranavaluta.Size = new System.Drawing.Size(258, 20);
            this.tbizabranavaluta.TabIndex = 4;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbizabranavaluta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btispis);
            this.Controls.Add(this.btunos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btunos;
        private System.Windows.Forms.Button btispis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbizabranavaluta;
    }
}

