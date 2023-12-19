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

    public partial class üyedegistir : Form
    {
        string kad;
        private int et()
        {
            int sayac = 0;
            string dosya_yolu = @"giriş.txt";
            StreamReader sr = new StreamReader(dosya_yolu);
            string s = sr.ReadToEnd();
            sr.Close();
            List<string> list = new List<string>();
            foreach (string a in s.Split(' '))
            {
                list.Add(a);
            }

            kad = list[0];

            if (list[1] == eski_text.Text)
            {
                sayac = 1;
            }
            return sayac;
        }

        private void degistir()
        {
            string dosya_yolu = @"giriş.txt";
            StreamWriter yaz = new StreamWriter(dosya_yolu);
            yaz.Write(kad + " " + yeni_text.Text);
            yaz.Close();
        }
        
        private void fonk1()
        {
            string dosya_yolu = @"kisiler.txt";
            string yol = @"gecicikisiler.txt";
            string metin = File.ReadAllText(dosya_yolu);
            File.WriteAllText(yol,metin);
        }
        
        private void fonk2()
        {
            string yol = @"kisiler.txt";
            string dosya_yolu = @"gecicikisiler.txt";
            string file = @"giriş.txt";
            List<string> list = new List<string>();
            List<string> s = new List<string>();
            using(StreamReader oku = new StreamReader(dosya_yolu))
            {
                using(StreamWriter yaz = new StreamWriter(yol))
                {
                    using(StreamReader sr = new StreamReader(file))
                    {
                        string bilgi = sr.ReadLine();
                        foreach(string line in bilgi.Split(' '))
                        {
                            s.Add(line);
                        }

                        string[] metin = File.ReadAllLines(dosya_yolu);
                        if (metin.Length > 0)
                        {
                            foreach (string a in metin)
                            {
                                foreach (string b in a.Split(' '))
                                {
                                    list.Add(b);
                                }
                                if (list[0] == s[0])
                                {
                                    yaz.WriteLine(list[0] + " " + yeni_text.Text + " " + list[2] + " " + list[3] + " " + list[4]);
                                }
                                else
                                {
                                    yaz.WriteLine(list[0] + " " + list[1] + " " + list[2] + " " + list[3] + " " + list[4]);
                                }
                                list.Clear();
                            }
                        }
                    }
                        
                }
            }
        }


        public üyedegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = et();
            if (sayı == 1)
            {
                degistir();
                fonk1();
                fonk2();
                MessageBox.Show("Şifre değiştirildi", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eski şifren yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyeekranı ekran = new üyeekranı();
            ekran.Show();
            this.Dispose();
        }
    }
}
