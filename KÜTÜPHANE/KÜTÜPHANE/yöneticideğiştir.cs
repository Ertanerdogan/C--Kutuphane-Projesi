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
    public partial class yöneticideğiştir : Form
    {

        static string kad = "";
        private int eski_kontrol()
        {
            int sayac = 0;
            string dosya_yolu = @"admin.txt";
            StreamReader fs = new StreamReader(dosya_yolu);
            string metin = fs.ReadToEnd();
            List<string> list = new List<string>();
            foreach (string a in metin.Split(' '))
            {
                list.Add(a);
            }
            if (list[1] == eski_box.Text)
            {
                sayac = 1;
            }
            kad = list[0];
            fs.Close();
            return sayac;
        }

        private void degis()
        {
            string yol = @"admin.txt";
            using (StreamWriter yaz = new StreamWriter(yol))
            {
                yaz.Write(kad + " " + yeni_box.Text);
            }
        }

        public yöneticideğiştir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kont = eski_kontrol();
            if (kont == 1)
            {
                degis();
                MessageBox.Show("Şifre başarıyla değiştirildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eski şifren yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yöneticiekranı ekran = new yöneticiekranı();
            ekran.Show();
            this.Dispose();
        }
    }
}
