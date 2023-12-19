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
    public partial class üyeekranı : Form
    {
        public üyeekranı()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaekran ekran = new anaekran();
            ekran.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyekitapgör ekran = new üyekitapgör();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profiligör ekran = new profiligör();
            ekran.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oduncekran ekran = new oduncekran();
            ekran.Show();
            this.Dispose();
        }

   
    }
}
