using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE
{
    public partial class yöneticigiriş : Form
    {
        public yöneticigiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"admin.txt";
            string line;
            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                line = sr.ReadLine();
            }

            if(kullanıcı_textbox.Text + " " + parola_textbox.Text == line)
            {
                yöneticiekranı ekran = new yöneticiekranı();
                ekran.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error); ;
            }

                 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran ekran = new anaekran();
            ekran.Show();
            this.Dispose();
        }
    }
}
