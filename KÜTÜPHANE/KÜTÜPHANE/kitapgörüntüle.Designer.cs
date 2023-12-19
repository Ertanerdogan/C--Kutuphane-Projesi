namespace KÜTÜPHANE
{
    partial class kitapgörüntüle
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
            this.data_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_kitapad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_yazarsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gör_buton = new System.Windows.Forms.Button();
            this.geri_buton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_kod,
            this.data_kitapad,
            this.data_yazar,
            this.data_yazarsoyad,
            this.data_sayfa});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_kod
            // 
            this.data_kod.HeaderText = "KİTABIN KODU";
            this.data_kod.MinimumWidth = 6;
            this.data_kod.Name = "data_kod";
            this.data_kod.Width = 125;
            // 
            // data_kitapad
            // 
            this.data_kitapad.HeaderText = "KİTABIN ADI";
            this.data_kitapad.MinimumWidth = 6;
            this.data_kitapad.Name = "data_kitapad";
            this.data_kitapad.Width = 220;
            // 
            // data_yazar
            // 
            this.data_yazar.HeaderText = "YAZARIN ADI";
            this.data_yazar.MinimumWidth = 6;
            this.data_yazar.Name = "data_yazar";
            this.data_yazar.Width = 220;
            // 
            // data_yazarsoyad
            // 
            this.data_yazarsoyad.HeaderText = "YAZARIN SOYADI";
            this.data_yazarsoyad.MinimumWidth = 6;
            this.data_yazarsoyad.Name = "data_yazarsoyad";
            this.data_yazarsoyad.Width = 220;
            // 
            // data_sayfa
            // 
            this.data_sayfa.HeaderText = "SAYFA SAYISI";
            this.data_sayfa.MinimumWidth = 6;
            this.data_sayfa.Name = "data_sayfa";
            this.data_sayfa.Width = 125;
            // 
            // gör_buton
            // 
            this.gör_buton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gör_buton.Location = new System.Drawing.Point(801, 478);
            this.gör_buton.Name = "gör_buton";
            this.gör_buton.Size = new System.Drawing.Size(169, 63);
            this.gör_buton.TabIndex = 1;
            this.gör_buton.Text = "KİTAPLARI GÖR";
            this.gör_buton.UseVisualStyleBackColor = true;
            this.gör_buton.Click += new System.EventHandler(this.gör_buton_Click);
            // 
            // geri_buton
            // 
            this.geri_buton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_buton.Location = new System.Drawing.Point(12, 478);
            this.geri_buton.Name = "geri_buton";
            this.geri_buton.Size = new System.Drawing.Size(169, 63);
            this.geri_buton.TabIndex = 2;
            this.geri_buton.Text = "GERİ DÖN";
            this.geri_buton.UseVisualStyleBackColor = true;
            this.geri_buton.Click += new System.EventHandler(this.geri_buton_Click);
            // 
            // kitapgörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.geri_buton);
            this.Controls.Add(this.gör_buton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapgörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAPLARI GÖRÜNTÜLE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kitapad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazarsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sayfa;
        private System.Windows.Forms.Button gör_buton;
        private System.Windows.Forms.Button geri_buton;
    }
}