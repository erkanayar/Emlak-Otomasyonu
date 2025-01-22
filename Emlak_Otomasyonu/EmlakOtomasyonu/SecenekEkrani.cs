using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class SecenekEkrani : Form
    {
        public SecenekEkrani()
        {
            InitializeComponent();
        }

        private void btnEvEkleme_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnSorgulama_Click(object sender, EventArgs e)
        {
            SorguEkrani sorguEkrani = new SorguEkrani();
            this.Hide();
            sorguEkrani.Show();
        }

        private void SecenekEkrani_Load(object sender, EventArgs e)
        {
            DosyaIslemleri.DosyaIdBelirleme();
        }
    }
}
