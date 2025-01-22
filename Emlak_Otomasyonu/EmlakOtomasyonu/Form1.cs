using ClassLibrary;
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

namespace EmlakOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void cb_İl_SelectedValueChanged(object sender, EventArgs e)
        {
            Ev.sehir = (cb_İl.SelectedIndex)+1;
            string dosya_yolu = "../../semtler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Semt Dosyası Bulunmuyor");
                return;
            }
            else
            {
                List<string> semtler = DosyaIslemleri.DosyaOkumaSemt(dosya_yolu, cb_İl.Text);
                cbSemt.Items.Clear();
                foreach (string semt in semtler)
                {
                    cbSemt.Items.Add(semt);
                }
                cbSemt.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void cb_İl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            bool kontrol = FormKontrol.FormButtonKontrol(this);
            if (kontrol)
            {
                if (RbSatilik.Checked)
                {
                    SatilikEv satilikEv = new SatilikEv(
                        int.Parse(txtOdaSayisi.Text), int.Parse(txtKatNumarasi.Text), cb_İl.Text,
                    cbSemt.Text, int.Parse(txtAlan.Text), cbEvTur.Items.IndexOf(cbEvTur.SelectedItem), "satilik", true, DateTime.Parse(yapim.Text), int.Parse(txtFiyat.Text));
                    Ev.evler.Add(satilikEv);
                    string dosya_yolu = "../../satilik.txt";
                    DosyaIslemleri.DosyaSatilikEvOkuma();
                    DosyaIslemleri.DosyaSatilikYazmak(dosya_yolu, "satilik");
                    MessageBox.Show("Satılık ev eklendi");
                }
                else
                {
                    KiralikEv kiralikEv = new KiralikEv(int.Parse(txtOdaSayisi.Text), int.Parse(txtKatNumarasi.Text), cb_İl.Text,
                        cbSemt.Text, int.Parse(txtAlan.Text), cbEvTur.Items.IndexOf(cbEvTur.SelectedItem), "kiralik", true, DateTime.Parse(yapim.Text), decimal.Parse(txtKira.Text), decimal.Parse(txtDepozito.Text));
                    Ev.evler.Add(kiralikEv);
                    string dosya_yolu = "../../kiralik.txt";
                    DosyaIslemleri.DosyaKiralikEvYazmak(dosya_yolu, "kiralik");
                    MessageBox.Show("Kiralık ev eklendi");
                }
                Ev.id++;
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!","HATA");
            }
        }

        private void rbSatilik_CheckedChanged_1(object sender, EventArgs e)
        {
            txtFiyat.Show();
            txtDepozito.Hide();
            FormKontrol.SatilikRadioButton(this);
        }

        private void rbKiralik_CheckedChanged_1(object sender, EventArgs e)
        {
            FormKontrol.KiralikRadioButton(this);
            txtDepozito.Show();
            txtFiyat.Hide();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEvTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEvTur_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (txtOdaSayisi.Text != "" && cbEvTur.Text != "")
            {
                label10.Text = "Önerilen Fiyat : " + (Ev.FiyatHesapla(int.Parse(txtOdaSayisi.Text), cbEvTur.Text).ToString());
                if (RbSatilik.Checked==true)
                {
                    label10.Text = "Önerilen Fiyat : " + (Ev.FiyatHesapla(int.Parse(txtOdaSayisi.Text), cbEvTur.Text) * 100).ToString();

                }
            }
        }

        private void txtOdaSayisi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecenekEkrani secenekekrani = new SecenekEkrani();
            this.Hide();
            secenekekrani.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
