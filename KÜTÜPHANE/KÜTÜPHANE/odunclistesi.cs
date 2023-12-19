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
    public partial class odunclistesi : Form
    {
        private void fonk1()
        {
            string dosya = @"oduncliste.txt";
            string kitap = @"kitaplar.txt";
            string üye = @"kisiler.txt";

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();

            string[] metin = File.ReadAllLines(dosya);
            if(metin.Length > 0 )
            {
                foreach(string a in metin)
                {
                    foreach(string b in a.Split(' '))
                    {
                        list1.Add(b);
                    }
                    string alan_kisi = list1[0];
                    string alınan_kitap = list1[1];

                    string[] bilgi = File.ReadAllLines(kitap);
                    if(bilgi.Length > 0 )
                    {
                        foreach(string i in bilgi)
                        {
                            foreach(string j in i.Split(' '))
                            {
                                list2.Add(j);
                            }
                            if (list2[0] == alınan_kitap)
                            {
                                dataGridView1.Rows.Add(alan_kisi, list2[0], list2[1], list2[2], list2[3]);
                            }
                            list2.Clear();
                        }
                    }
                    list1.Clear();
                }
            }
        }


        public odunclistesi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ekran = new Form2();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fonk1();
        }
    }
}
