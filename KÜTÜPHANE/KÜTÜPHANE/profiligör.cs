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
    public partial class profiligör : Form
    {
        public profiligör()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyeekranı ekran = new üyeekranı();
            ekran.Show();
            this.Dispose();
        }

        private void profiligör_Load(object sender, EventArgs e)
        {
            string dosya_yolu = @"giriş.txt";
            string yol = @"kisiler.txt";
            StreamReader sr = new StreamReader(dosya_yolu);
            string metin = sr.ReadLine();
            List <string> list = new List<string>();
            List<string> liste = new List<string>();
            foreach (string kelime in metin.Split(' '))
            {
                list.Add(kelime);
            }
            string kad = list[0];
            sr.Close();

            using(StreamReader oku = new StreamReader(yol))
            {
                string[] lines = File.ReadAllLines(yol);
                if(lines.Length > 0) 
                {
                    foreach(string a in lines)
                    {
                        foreach(string b in a.Split(' '))
                        {
                            liste.Add(b);
                        }
                        if (liste[0] == kad)
                        {
                            kullanıcı_label.Text = liste[0];
                            parola_label.Text = liste[1];
                            ad_label.Text = liste[2];
                            soyad_label.Text = liste[3];
                            yas_label.Text = liste[4];
                        }
                        liste.Clear();
                    }
                }

            }
        }
        static string kisi;
        private int var()
        {
            int sayac = 0;
            string dosya_yolu = @"giriş.txt";
            string yol = @"oduncliste.txt";

            StreamReader oku = new StreamReader(dosya_yolu);
            string bilgi = oku.ReadLine();
            oku.Close();
            List<string> list = new List<string>();
            foreach(string a in bilgi.Split(' '))
            {
                list.Add(a);
            }
            kisi = list[0];

            string[] metin = File.ReadAllLines(yol);
            List<string> liste = new List<string>();
            if(metin.Length > 0 )
            {
                foreach(string i in metin)
                {
                    foreach(string j in i.Split(' '))
                    {
                        liste.Add(j);
                    }
                    if (liste[0] == kisi)
                    {
                        sayac = 1;
                    }
                    liste.Clear();
                }
            }
            return sayac;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyedegistir ekran = new üyedegistir();
            ekran.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı = var();
            if(sayı == 1)
            {
                aldigimkitap ekran = new aldigimkitap();
                ekran.Show();
                this.Dispose();
            }
            else if(sayı == 0)
            {
                MessageBox.Show("Ödünç aldığın kitap yok","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
