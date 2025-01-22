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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmlakOtomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string dosya_yolu = "../../users.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kullanıcı Dosyası Bulunmuyor. Öncelikle Kullanıcı Ekleyiniz");
            }
            else
            {
                List<Kullanici> kullanicilar = DosyaIslemleri.DosyaOkuma(dosya_yolu);
                string kullaniciAdi = txtKullaniciAdi.Text;
                string sifre = txtSifre.Text;

                foreach(Kullanici kullanici in kullanicilar)
                {
                    if(kullanici.KullaniciAdi.Equals(kullaniciAdi) && kullanici.Sifre.Equals(sifre))
                    {
                        SecenekEkrani secenekEkrani = new SecenekEkrani();
                        this.Hide();
                        secenekEkrani.Show();
                        MessageBox.Show("Giriş Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!","HATA");
                    }
                }
            }
        }

        private void btnGiris_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnGiris_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecenekEkrani secenekekrani = new SecenekEkrani();
            secenekekrani.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtKullaniciAdi, "Bu alan boş bırakılamaz.");
            toolTip1.SetToolTip(txtSifre, "Bu alan boş bırakılamaz.");
        }
    }
}
