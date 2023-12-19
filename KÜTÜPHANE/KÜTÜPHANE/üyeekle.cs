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
    public partial class üyeekle : Form
    {

        public int kontrol()
        {
            int sayac = 0;
            string yol = @"kisiler.txt";
            string[] line;
            List<string> lines = new List<string>();
            using (FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                line = File.ReadAllLines(yol);
                for(int i = 0; i < line.Length;i++)
                {
                    lines.Clear();
                    foreach(string kelime in sr.ReadLine().Split(' '))
                    {
                        lines.Add(kelime);
                    }
                    if (lines[0] == kullanici_box.Text)
                    {
                        sayac++;
                    }
                }
                sr.Close();
            }
            return sayac;
        }

        public void ekle()
        {
            string dosya_yolu = @"kisiler.txt";
            using (FileStream file  = new FileStream(dosya_yolu,FileMode.Append,FileAccess.Write))
            {
                StreamWriter yaz = new StreamWriter(file);
                string metin = (kullanici_box.Text + " " + parola_box.Text + " " + ad_box.Text + " " + soyad_box.Text + " " + yas_box.Text);
                yaz.WriteLine(metin);
                yaz.Close();
            }     
        }

        public üyeekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyeişlemleri ekran = new üyeişlemleri();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = kontrol();
            if(sayı == 0)
            {
                ekle();
                MessageBox.Show("İşlem başarılı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı kullanılıyor","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
