namespace KÜTÜPHANE
{
    partial class kayıtol
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
            this.kullanıcı_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parola_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ad_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soyad_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yas_box = new System.Windows.Forms.TextBox();
            this.üyeol1 = new System.Windows.Forms.Button();
            this.geridon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(601, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // kullanıcı_box
            // 
            this.kullanıcı_box.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.kullanıcı_box.Location = new System.Drawing.Point(63, 97);
            this.kullanıcı_box.Name = "kullanıcı_box";
            this.kullanıcı_box.Size = new System.Drawing.Size(304, 44);
            this.kullanıcı_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(601, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD";
            // 
            // parola_box
            // 
            this.parola_box.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.parola_box.Location = new System.Drawing.Point(63, 244);
            this.parola_box.Name = "parola_box";
            this.parola_box.Size = new System.Drawing.Size(304, 44);
            this.parola_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(601, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "YAŞ";
            // 
            // ad_box
            // 
            this.ad_box.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.ad_box.Location = new System.Drawing.Point(608, 97);
            this.ad_box.Name = "ad_box";
            this.ad_box.Size = new System.Drawing.Size(260, 44);
            this.ad_box.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "KULLANICI ADI";
            // 
            // soyad_box
            // 
            this.soyad_box.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.soyad_box.Location = new System.Drawing.Point(608, 244);
            this.soyad_box.Name = "soyad_box";
            this.soyad_box.Size = new System.Drawing.Size(260, 44);
            this.soyad_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "PAROLA";
            // 
            // yas_box
            // 
            this.yas_box.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.yas_box.Location = new System.Drawing.Point(608, 358);
            this.yas_box.Name = "yas_box";
            this.yas_box.Size = new System.Drawing.Size(260, 44);
            this.yas_box.TabIndex = 9;
            // 
            // üyeol
            // 
            this.üyeol1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.üyeol1.Location = new System.Drawing.Point(657, 456);
            this.üyeol1.Name = "üyeol";
            this.üyeol1.Size = new System.Drawing.Size(146, 65);
            this.üyeol1.TabIndex = 10;
            this.üyeol1.Text = "ÜYE OL";
            this.üyeol1.UseVisualStyleBackColor = true;
            this.üyeol1.Click += new System.EventHandler(this.üyeol_Click);
            // 
            // geridon
            // 
            this.geridon.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.geridon.Location = new System.Drawing.Point(41, 453);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(132, 68);
            this.geridon.TabIndex = 11;
            this.geridon.Text = "GERİ DÖN";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // kayıtol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.üyeol1);
            this.Controls.Add(this.yas_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyad_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ad_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parola_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanıcı_box);
            this.Controls.Add(this.label1);
            this.Name = "kayıtol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT OL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanıcı_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parola_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ad_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyad_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yas_box;
        private System.Windows.Forms.Button üyeol1;
        private System.Windows.Forms.Button geridon;
    }
}