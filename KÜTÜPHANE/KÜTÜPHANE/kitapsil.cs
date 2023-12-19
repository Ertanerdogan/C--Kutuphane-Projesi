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
    public partial class kitapsil : Form
    {
        private void kitapsil1()
        {
            string dosya_yolu = @"kitaplar.txt";
            string yol = @"gecicikitaplar.txt";
            StreamWriter yaz = new StreamWriter(yol);
            string[] metin = File.ReadAllLines(dosya_yolu);
            foreach (string met in metin)
            {
                yaz.WriteLine(met);
            }
            yaz.Close();
        }

        private void kitapsil2()
        {
            string dosya_yolu = @"kitaplar.txt";
            string yol = @"gecicikitaplar.txt";
            List<string> lines = new List<string>();
            string silinecek = kod_box.Text;
            int sayac = 0;
            using (StreamWriter yaz = new StreamWriter(dosya_yolu))
            {
                using (FileStream file = new FileStream(yol, FileMode.Open, FileAccess.Read))
                {
                    StreamReader oku = new StreamReader(file);
                    string[] metin = File.ReadAllLines(yol);
                    if (metin.Length == 1)
                    {
                        MessageBox.Show("Kitap yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (string a in metin)
                        {
                            foreach (string b in a.Split(' '))
                            {
                                lines.Add(b);
                            }
                            if (lines[0] == silinecek)
                            {
                                if(silinecek == "0001")
                                {
                                    sayac = 1;
                                    MessageBox.Show("Bu kitabı silemezsin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    yaz.WriteLine(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4]);
                                    lines.Clear();
                                }
                                else
                                {
                                    lines.Clear();
                                    sayac = 1;
                                    MessageBox.Show("Silme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    continue;
                                }
                                
                            }
                            else
                            {
                                yaz.WriteLine(lines[0] + " " + lines[1] + " " + lines[2] + " " + lines[3] + " " + lines[4]);
                                lines.Clear();
                            }
                        }
                        if(sayac == 0)
                        {
                            MessageBox.Show("Kitap bulunamadı","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    oku.Close();
                }
            }
        }

        private void kitapsırala()
        {
            string dosya_yolu = @"kitaplar.txt";
            string[] metin;
            List<string> list = new List<string>();
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            metin = File.ReadAllLines(dosya_yolu);

            if (metin.Length != 1)
            {
                dataGridView1.Rows.Clear();
                foreach (string a in metin)
                {
                    foreach (string b in a.Split(' '))
                    {
                        list.Add(b);
                    }
                    dataGridView1.Rows.Add(list[0], list[1], list[2], list[3]);
                    list.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kitap yok", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fs.Close();
        }

        private int odunc()
        {
            int sayac = 0;
            string kod = kod_box.Text;
            string dosya_yolu = @"oduncliste.txt";
            string[] metin = File.ReadAllLines(dosya_yolu);
            List<string> list = new List<string>();
            if(metin.Length > 0)
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list.Add(b);
                    }
                    if (list[1] == kod)
                    {
                        sayac = 1;
                    }
                    list.Clear();
                }
            }
            return sayac;
        }

        public kitapsil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapsırala();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = odunc();
            if(sayı == 1)
            {
                MessageBox.Show("Bu kitap birisine ödünç verildi", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                kitapsil1();
                kitapsil2();
            }
        }
    }
}
