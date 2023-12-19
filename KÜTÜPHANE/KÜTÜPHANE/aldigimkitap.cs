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
    public partial class aldigimkitap : Form
    {
        static string kisi;
        
        private void göster()
        {
            string giris = @"giriş.txt";
            string kitap = @"kitaplar.txt";
            string odunc = @"oduncliste.txt";

            StreamReader streamReader = new StreamReader(giris);
            string bilgi = streamReader.ReadLine();
            streamReader.Close();
            List<string> list1 = new List<string>();
            foreach(string line in bilgi.Split(' '))
            {
                list1.Add(line);
            }
            kisi = list1[0];

            string[] metin = File.ReadAllLines(odunc);
            List<string> list2 = new List<string>();
            if(metin.Length > 0)
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list2.Add(b);
                    }
                    if (list2[0] == kisi)
                    {
                        string alınacak = list2[1];
                        string[] dizi = File.ReadAllLines(kitap);
                        List<string> list3 = new List<string>();
                        if(dizi.Length > 0)
                        {
                            foreach(string i in dizi)
                            {
                                foreach(string j in i.Split(' '))
                                {
                                    list3.Add(j);
                                }
                                if (list3[0] == alınacak)
                                {
                                    kod_label.Text = list3[0];
                                    kad_label.Text = list3[1];
                                    yad_label.Text = list3[2];
                                    ysoyad_label.Text = list3[3];
                                    sayfa_label.Text = list3[4];
                                }
                                list3.Clear();
                            }
                        }

                    }
                    list2.Clear();
                }
            }

            
        }

        private void iadeet1()
        {
            string dosya_yolu = @"geciciodunc.txt";
            string yol = @"oduncliste.txt";
            string metin = File.ReadAllText(yol);
            File.WriteAllText(dosya_yolu, metin);
        }

        private void iadeet2()
        {
            string dosya_yolu = @"oduncliste.txt";
            string yol = @"geciciodunc.txt";
            string giris = @"giriş.txt";
            List<string> list1 = new List<string>();
            string kullanici;

            StreamReader sr = new StreamReader(giris);
            string bilgi = sr.ReadLine();
            sr.Close();
            foreach(string bil in bilgi.Split(' '))
            {
                list1.Add(bil);
            }
            kullanici = list1[0];
            List<string> list2 = new List<string>();
            string[] metin = File.ReadAllLines(yol);
            StreamWriter yaz = new StreamWriter(dosya_yolu);
            if(metin.Length > 0)
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list2.Add(b);
                    }
                    if (list2[0] == kullanici)
                    {
                        list2.Clear();
                        continue;
                    }
                    else
                    {
                        yaz.WriteLine(list2[0] + " " + list2[1]);
                        list2.Clear();
                    }
                    
                }
                yaz.Close();
            }
        }


        public aldigimkitap()
        {
            InitializeComponent();
        }

        private void aldigimkitap_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profiligör ekran = new profiligör();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iadeet1();
            iadeet2();
            MessageBox.Show("İade işlemi başarılı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            profiligör ekran = new profiligör();
            ekran.Show();
            this.Dispose();
        }
    }
}
