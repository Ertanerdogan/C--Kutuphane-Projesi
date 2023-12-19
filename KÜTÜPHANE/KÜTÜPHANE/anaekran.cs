using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yöneticigiriş ekran = new yöneticigiriş();
            ekran.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtol ekran = new kayıtol();
            ekran.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            üyegiriş ekran = new üyegiriş();
            ekran.Show();
            this.Dispose();
        }
    }
}
