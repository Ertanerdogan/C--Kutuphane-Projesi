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
    public partial class üyeişlemleri : Form
    {
        public üyeişlemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyeekle ekran = new üyeekle();
            ekran.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            üyegörüntüle ekran = new üyegörüntüle();
            ekran.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            üyesil ekran = new üyesil();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yöneticiekranı ekran = new yöneticiekranı();
            ekran.Show();
            this.Dispose();
        }
    }
}
