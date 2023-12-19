using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE
{
    public partial class yöneticiekranı : Form
    {
        public yöneticiekranı()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaekran ekran = new anaekran();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyeişlemleri ekran = new üyeişlemleri();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ekran = new Form2();
            ekran.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yöneticideğiştir ekran = new yöneticideğiştir();
            ekran.Show();
            this.Dispose();
        }
    }
}
