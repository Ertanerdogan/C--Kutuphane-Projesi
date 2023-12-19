namespace KÜTÜPHANE
{
    partial class üyekitapgör
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
            this.data_yazarad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_yazarsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_kod,
            this.data_kitapad,
            this.data_yazarad,
            this.data_yazarsoyad,
            this.data_sayfa});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 459);
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
            // data_yazarad
            // 
            this.data_yazarad.HeaderText = "YAZARIN ADI";
            this.data_yazarad.MinimumWidth = 6;
            this.data_yazarad.Name = "data_yazarad";
            this.data_yazarad.Width = 220;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(773, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "KİTAPLARI GÖR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // üyekitapgör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "üyekitapgör";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAPLARI GÖR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kitapad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazarad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazarsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sayfa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}