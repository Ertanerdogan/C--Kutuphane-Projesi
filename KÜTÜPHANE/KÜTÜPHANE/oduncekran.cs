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
    public partial class oduncekran : Form
    {
        private void sırala()
        {
            string dosya_yolu = @"kitaplar.txt";
            string[] metin;
            List<string> list = new List<string>();
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            metin = File.ReadAllLines(dosya_yolu);

            if (metin.Length >= 1)
            {
                dataGridView1.Rows.Clear();
                foreach (string a in metin)
                {
                    foreach (string b in a.Split(' '))
                    {
                        list.Add(b);
                    }
                    dataGridView1.Rows.Add(list[0], list[1], list[2], list[3], list[4]);
                    list.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kitap yok", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fs.Close();
        }
        static string kisi;
        private int kontrol_et()
        {
            int sayac = 1;
            string dosya_yolu = "oduncliste.txt";
            string yol = @"giriş.txt";

            string[] metin = File.ReadAllLines(dosya_yolu);

            List<string> list = new List<string>();
            List<string> info = new List<string>();

            StreamReader kul = new StreamReader(yol);
            string kullanici = kul.ReadToEnd();
            kul.Close();

            foreach(string c in kullanici.Split(' '))
            {
                info.Add(c);
            }
            kisi = info[0];
            
            if(metin.Length > 0)
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list.Add(b);
                    }
                    if (list[0] == kisi)
                    {
                        sayac = 0;
                    }
                }
            }
            
            return sayac;         
        }

        private void al()
        {
            string dosya_yolu = @"kitaplar.txt";
            string[] metin = File.ReadAllLines(dosya_yolu);
            string yol = @"oduncliste.txt";
            List<string> list = new List<string>();
            using (FileStream fs = new FileStream(yol,FileMode.Append,FileAccess.Write))
            {
                StreamWriter yaz = new StreamWriter(fs);
                if (metin.Length > 0)
                {
                    foreach (string a in metin)
                    {
                        foreach (string b in a.Split(' '))
                        {
                            list.Add(b);
                        }

                        if (list[0] == kod_text.Text)
                        {
                            yaz.WriteLine(kisi + " " + kod_text.Text);
                            MessageBox.Show("İşlem başarılı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        list.Clear();
                    }
                }
                yaz.Close();
            }
            
        }

        public oduncekran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            üyeekranı ekran = new üyeekranı();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sırala();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = kontrol_et();
            if(sayı == 1)
            {
                al();
            }
            else
            {
                MessageBox.Show("Zaten ödünç aldığınız bir kitap var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
