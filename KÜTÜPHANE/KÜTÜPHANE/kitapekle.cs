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
    public partial class kitapekle : Form
    {
        private int kod_kontrol()
        {
            int sayac = 0;
            string yol = @"kitaplar.txt";
            string[] metin;
            List<string> list = new List<string>(); 
            using (new FileStream(yol, FileMode.Open, FileAccess.Read))
            {
                metin = File.ReadAllLines(yol);
                if(metin.Length > 0 ) 
                {
                    foreach(string a in metin)
                    {
                        foreach(string b in a.Split(' '))
                        {
                            list.Add(b);
                        }
                        if (list[0].ToString() == kod_box.Text.ToString())
                        {
                            sayac = 1;
                        }
                        list.Clear();
                    }
                }
            }
            return sayac;
        }

        private void k_ekle()
        {
            string dosya_yolu = @"kitaplar.txt";
            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write))
            {
                StreamWriter yaz = new StreamWriter(fs);
                yaz.WriteLine(kod_box.Text + " " + kitapad_box.Text + " " + yazarad_box.Text + " " + yazarsoyad_box.Text + " " + sayfa_box.Text);
                yaz.Close();
            }
        }   

        public kitapekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = kod_kontrol();
            if(sayı == 1 )
            {
                MessageBox.Show("Kod kullanılıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                k_ekle();
                MessageBox.Show("Kitap eklendi","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
