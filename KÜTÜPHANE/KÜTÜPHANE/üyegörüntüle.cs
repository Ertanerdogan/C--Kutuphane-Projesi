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
    public partial class üyegörüntüle : Form
    {

        private void görüntüle()
        {
            string dosya_yolu = @"kisiler.txt";
            string[] lines;
            List<string> list = new List<string>();
            using(FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            {
                lines = File.ReadAllLines(dosya_yolu);
                if(lines.Length < 1)
                {
                    MessageBox.Show("Üyemiz yok", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(lines.Length >= 1)
                {
                    dataGridView1.Rows.Clear();
                    foreach(string a in lines)
                    {
                        foreach(string b in a.Split(' '))
                        {
                            list.Add(b);
                        }
                        dataGridView1.Rows.Add(list[0], list[2], list[3], list[4].ToString(), list[1]);
                        list.Clear();
                    }
                }
            }
        }
        public üyegörüntüle()
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
            görüntüle();
        }
    }
}
