namespace KÜTÜPHANE
{
    partial class kitapsil
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
            this.label1 = new System.Windows.Forms.Label();
            this.kod_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.data_yazarsoyad});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 563);
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
            this.data_kitapad.Width = 125;
            // 
            // data_yazarad
            // 
            this.data_yazarad.HeaderText = "YAZARIN ADI";
            this.data_yazarad.MinimumWidth = 6;
            this.data_yazarad.Name = "data_yazarad";
            this.data_yazarad.Width = 125;
            // 
            // data_yazarsoyad
            // 
            this.data_yazarsoyad.HeaderText = "YAZARIN SOYADI";
            this.data_yazarsoyad.MinimumWidth = 6;
            this.data_yazarsoyad.Name = "data_yazarsoyad";
            this.data_yazarsoyad.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(617, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTABIN KODU:";
            // 
            // kod_box
            // 
            this.kod_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kod_box.Location = new System.Drawing.Point(623, 189);
            this.kod_box.Name = "kod_box";
            this.kod_box.Size = new System.Drawing.Size(308, 40);
            this.kod_box.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(716, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "KİTABI SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(849, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "KİTAPLARI\r\nGÖR\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(558, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 84);
            this.button3.TabIndex = 5;
            this.button3.Text = "GERİ\r\nDÖN\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kitapsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kod_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP SİL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_kitapad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazarad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_yazarsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kod_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}