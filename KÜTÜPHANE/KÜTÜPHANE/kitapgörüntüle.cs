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
    public partial class kitapgörüntüle : Form
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

        public kitapgörüntüle()
        {
            InitializeComponent();
        }

        private void gör_buton_Click(object sender, EventArgs e)
        {
            sırala();
        }

        private void geri_buton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Dispose();
        }
    }
}
