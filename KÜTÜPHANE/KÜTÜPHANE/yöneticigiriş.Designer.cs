﻿namespace KÜTÜPHANE
{
    partial class yöneticigiriş
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
            this.parola_textbox = new System.Windows.Forms.TextBox();
            this.kullanıcı_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(201, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAROLA :";
            // 
            // parola_textbox
            // 
            this.parola_textbox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola_textbox.Location = new System.Drawing.Point(210, 309);
            this.parola_textbox.Name = "parola_textbox";
            this.parola_textbox.Size = new System.Drawing.Size(514, 44);
            this.parola_textbox.TabIndex = 2;
            // 
            // kullanıcı_textbox
            // 
            this.kullanıcı_textbox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_textbox.Location = new System.Drawing.Point(210, 117);
            this.kullanıcı_textbox.Name = "kullanıcı_textbox";
            this.kullanıcı_textbox.Size = new System.Drawing.Size(514, 44);
            this.kullanıcı_textbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(518, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(210, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yöneticigiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullanıcı_textbox);
            this.Controls.Add(this.parola_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yöneticigiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parola_textbox;
        private System.Windows.Forms.TextBox kullanıcı_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}