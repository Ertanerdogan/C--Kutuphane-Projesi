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
    public partial class kayıtol : Form
    {

        private int kontrol()
        {
            int sayac = 0;
            string yol = @"kisiler.txt";
            string[] line;
            List<string> lines = new List<string>();
            using (FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                line = File.ReadAllLines(yol);
                for (int i = 0; i < line.Length; i++)
                {
                    lines.Clear();
                    foreach (string kelime in sr.ReadLine().Split(' '))
                    {
                        lines.Add(kelime);
                    }
                    if (lines[0] == kullanıcı_box.Text)
                    {
                        sayac++;
                    }
                }
                sr.Close();
            }
            return sayac;
        }

        private void üyeol()
        {
            string dosya_yolu = @"kisiler.txt";
            using (FileStream file = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write))
            {
                StreamWriter yaz = new StreamWriter(file);
                yaz.WriteLine(kullanıcı_box.Text + " " + parola_box.Text + " " + ad_box.Text + " " + soyad_box.Text + " " + yas_box.Text);
                yaz.Close();
            }
        }

        public kayıtol()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            anaekran ekran = new anaekran();
            ekran.Show();
            this.Dispose();
        }

        private void üyeol_Click(object sender, EventArgs e)
        {
            int sayı = kontrol();
            if (sayı == 0)
            {
                üyeol();
                MessageBox.Show("Başarıyla kayıt oldunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı kullanılıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
