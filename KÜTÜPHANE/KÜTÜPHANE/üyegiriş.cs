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
    public partial class üyegiriş : Form
    {

        private int kont()
        {
            string dosya_yolu = @"kisiler.txt";
            string yol = @"giriş.txt";
            string[] metin;
            int sayac = 0;
            List<string> list = new List<string>();
            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            {
                StreamReader oku = new StreamReader(dosya_yolu);
                StreamWriter yaz = new StreamWriter(yol);
                metin = File.ReadAllLines(dosya_yolu);
                if (metin.Length != 0)
                {
                    foreach (string a in metin)
                    {
                        foreach (string b in a.Split(' '))
                        {
                            list.Add(b);
                        }
                        if (list[0] == kullanıcı_textbox.Text && list[1] == parola_textbox.Text)
                        {
                            yaz.WriteLine(list[0] + " " + list[1] + " " + list[2] + " " + list[3] + " " + list[4]);
                            sayac = 1;
                        }
                        list.Clear();
                    }
                }
                yaz.Close();
                oku.Close();
            }
            return sayac;
        }

        public üyegiriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran ekran = new anaekran();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = kont();
            if(sayi == 1)
            {
                string yol = @"giriş.txt";
                StreamWriter yaz = new StreamWriter(yol);
                yaz.Write(kullanıcı_textbox.Text + " " + parola_textbox.Text);
                yaz.Close();
                üyeekranı ekran = new üyeekranı();
                ekran.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
