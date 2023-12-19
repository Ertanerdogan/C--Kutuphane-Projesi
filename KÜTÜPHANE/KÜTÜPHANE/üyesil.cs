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
    public partial class üyesil : Form
    {

        private void görüntüle()
        {
            string dosya_yolu = @"kisiler.txt";
            string[] lines;
            List<string> list = new List<string>();
            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            {
                lines = File.ReadAllLines(dosya_yolu);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Üyemiz yok", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    foreach (string a in lines)
                    {
                        foreach (string b in a.Split(' '))
                        {
                            list.Add(b);
                        }
                        dataGridView1.Rows.Add(list[0], list[2], list[3]);
                        list.Clear();
                    }
                }
            }
        }

        private void üyesil1()
        {
            string dosya_yolu = @"kisiler.txt";
            string yol = @"gecicikisiler.txt";
            StreamWriter yaz = new StreamWriter(yol);
            string[] metin = File.ReadAllLines(dosya_yolu);
            foreach (string met in metin)
            {
                yaz.WriteLine(met);
            }
            yaz.Close();
        }

        private void üyesil2()
        {
            string dosya_yolu = @"kisiler.txt";
            string yol = @"gecicikisiler.txt";
            List<string> lines = new List<string>();
            string silinecek = kullanıcı_box.Text;
            using (StreamWriter yaz = new StreamWriter(dosya_yolu))
            {
                using (FileStream file = new FileStream(yol, FileMode.Open, FileAccess.Read))
                {
                    StreamReader oku = new StreamReader(file);
                    string[] metin = File.ReadAllLines(yol);
                    if(metin.Length == 0)
                    {
                        MessageBox.Show("Kullanıcı bulunamadı", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach(string a in metin)
                        {
                            foreach(string b in a.Split(' '))
                            {
                                lines.Add(b);
                            }
                            if (lines[0] == silinecek)
                            {
                                if (silinecek == "ertanbaba55")
                                {
                                    MessageBox.Show("Bu üyeyi silemezsin","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    yaz.WriteLine(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4]);
                                    lines.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("İşlem başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lines.Clear();
                                    continue;
                                }
                            }
                            else
                            {
                                yaz.WriteLine(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4]);
                                lines.Clear();
                            }
                        }
                    }
                    oku.Close();
                }
            }

            
            
        }

        private void üyeyisil3()
        {
            string dosya = @"oduncliste.txt";
            string yol = @"geciciodunc.txt";
            StreamWriter sr = new StreamWriter(yol);
            string silinecek = kullanıcı_box.Text;

            string[] metin = File.ReadAllLines(dosya);
            foreach(string met in metin)
            {
                sr.WriteLine(met);
            }
            sr.Close();
        } 

        private void üyeyisil4()
        {
            string dosya = @"oduncliste.txt";
            string yol = @"geciciodunc.txt";
            List<string> list = new List<string>();
            string[] metin = File.ReadAllLines(yol);

            StreamWriter yaz = new StreamWriter(dosya);
            if(metin.Length > 0)
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list.Add(b);
                    }
                    if (list[0] == kullanıcı_box.Text)
                    {
                        list.Clear();
                        continue;
                    }
                    else
                    {
                        yaz.WriteLine(list[0] + " " + list[1]);
                        list.Clear();
                    }
                }
            }
            yaz.Close();
        }

        public üyesil()
        {
            InitializeComponent();
        }

        private void üyegöster_Click(object sender, EventArgs e)
        {
            görüntüle();
        }

        private void geridön_Click(object sender, EventArgs e)
        {
            üyeişlemleri ekran = new üyeişlemleri();
            ekran.Show();
            this.Dispose();
        }

        private void üyeyisil_Click(object sender, EventArgs e)
        {
            üyesil1();
            üyesil2();
            üyeyisil3();
            üyeyisil4();
        }
    }
}
