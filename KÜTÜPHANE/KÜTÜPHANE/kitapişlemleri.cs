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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yöneticiekranı ekran = new yöneticiekranı();
            ekran.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitapgörüntüle ekran = new kitapgörüntüle();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapekle ekran = new kitapekle();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapsil ekran = new kitapsil();   
            ekran.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odunclistesi ekran = new odunclistesi();
            ekran.Show();
            this.Dispose();
        }
    }
}
