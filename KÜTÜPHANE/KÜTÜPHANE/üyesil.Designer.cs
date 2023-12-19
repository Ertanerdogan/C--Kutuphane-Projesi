namespace KÜTÜPHANE
{
    partial class üyesil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.üyeyisil = new System.Windows.Forms.Button();
            this.kullanıcı_box = new System.Windows.Forms.TextBox();
            this.geridön = new System.Windows.Forms.Button();
            this.üyegöster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_kullanıcı,
            this.data_ad,
            this.data_soyad});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_kullanıcı
            // 
            this.data_kullanıcı.HeaderText = "KULLANICI ADI";
            this.data_kullanıcı.MinimumWidth = 6;
            this.data_kullanıcı.Name = "data_kullanıcı";
            this.data_kullanıcı.Width = 220;
            // 
            // data_ad
            // 
            this.data_ad.HeaderText = "AD";
            this.data_ad.MinimumWidth = 6;
            this.data_ad.Name = "data_ad";
            this.data_ad.Width = 150;
            // 
            // data_soyad
            // 
            this.data_soyad.HeaderText = "SOYAD";
            this.data_soyad.MinimumWidth = 6;
            this.data_soyad.Name = "data_soyad";
            this.data_soyad.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(554, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ ÜYENİN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(556, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ADI";
            // 
            // üyeyisil
            // 
            this.üyeyisil.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyeyisil.Location = new System.Drawing.Point(790, 267);
            this.üyeyisil.Name = "üyeyisil";
            this.üyeyisil.Size = new System.Drawing.Size(168, 94);
            this.üyeyisil.TabIndex = 3;
            this.üyeyisil.Text = "ÜYEYİ SİL";
            this.üyeyisil.UseVisualStyleBackColor = true;
            this.üyeyisil.Click += new System.EventHandler(this.üyeyisil_Click);
            // 
            // kullanıcı_box
            // 
            this.kullanıcı_box.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_box.Location = new System.Drawing.Point(561, 177);
            this.kullanıcı_box.Name = "kullanıcı_box";
            this.kullanıcı_box.Size = new System.Drawing.Size(397, 36);
            this.kullanıcı_box.TabIndex = 4;
            // 
            // geridön
            // 
            this.geridön.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geridön.Location = new System.Drawing.Point(680, 427);
            this.geridön.Name = "geridön";
            this.geridön.Size = new System.Drawing.Size(168, 94);
            this.geridön.TabIndex = 5;
            this.geridön.Text = "GERİ DÖN";
            this.geridön.UseVisualStyleBackColor = true;
            this.geridön.Click += new System.EventHandler(this.geridön_Click);
            // 
            // üyegöster
            // 
            this.üyegöster.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyegöster.Location = new System.Drawing.Point(561, 267);
            this.üyegöster.Name = "üyegöster";
            this.üyegöster.Size = new System.Drawing.Size(168, 94);
            this.üyegöster.TabIndex = 6;
            this.üyegöster.Text = "ÜYELERİ\r\nGÖSTER\r\n\r\n";
            this.üyegöster.UseVisualStyleBackColor = true;
            this.üyegöster.Click += new System.EventHandler(this.üyegöster_Click);
            // 
            // üyesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.üyegöster);
            this.Controls.Add(this.geridön);
            this.Controls.Add(this.kullanıcı_box);
            this.Controls.Add(this.üyeyisil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "üyesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYE SİL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kullanıcı;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button üyeyisil;
        private System.Windows.Forms.TextBox kullanıcı_box;
        private System.Windows.Forms.Button geridön;
        private System.Windows.Forms.Button üyegöster;
    }
}