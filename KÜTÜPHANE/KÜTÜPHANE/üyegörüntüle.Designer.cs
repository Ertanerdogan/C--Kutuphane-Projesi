namespace KÜTÜPHANE
{
    partial class üyegörüntüle
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
            this.data_kullanıcı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_kullanıcı,
            this.data_ad,
            this.data_soyad,
            this.data_yas,
            this.data_sifre});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_kullanıcı
            // 
            this.data_kullanıcı.HeaderText = "KULLANICI ADI";
            this.data_kullanıcı.MinimumWidth = 6;
            this.data_kullanıcı.Name = "data_kullanıcı";
            this.data_kullanıcı.Width = 225;
            // 
            // data_ad
            // 
            this.data_ad.HeaderText = "AD";
            this.data_ad.MinimumWidth = 6;
            this.data_ad.Name = "data_ad";
            this.data_ad.Width = 200;
            // 
            // data_soyad
            // 
            this.data_soyad.HeaderText = "SOYAD";
            this.data_soyad.MinimumWidth = 6;
            this.data_soyad.Name = "data_soyad";
            this.data_soyad.Width = 200;
            // 
            // data_yas
            // 
            this.data_yas.HeaderText = "YAŞ";
            this.data_yas.MinimumWidth = 6;
            this.data_yas.Name = "data_yas";
            this.data_yas.Width = 125;
            // 
            // data_sifre
            // 
            this.data_sifre.HeaderText = "ŞİFRE";
            this.data_sifre.MinimumWidth = 6;
            this.data_sifre.Name = "data_sifre";
            this.data_sifre.Width = 175;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(775, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÜYELERİ GÖRÜNTÜLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // üyegörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "üyegörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYELERİ GÖRÜNTÜLE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kullanıcı;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}