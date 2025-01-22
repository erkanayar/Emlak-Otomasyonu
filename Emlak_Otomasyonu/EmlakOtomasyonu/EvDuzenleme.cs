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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmlakOtomasyonu
{
    public partial class EvDuzenleme : Form
    {
        public decimal EmlakNumarasi = 111111111;
        public EvDuzenleme(int OdaSayisi, int KatNumarasi, string il, string Semt, decimal Alan, int turuSayi, string turu, bool Aktif,
            DateTime YapimTarihi, decimal Fiyat = 800, decimal EmlakNumarasi = 11111111)
        {
            InitializeComponent();
            txtOdaSayisi.Text = OdaSayisi.ToString();
            txtKatNumarasi.Text = KatNumarasi.ToString();
            cmb_il.Text = il.ToString();
            cmb_semt.Text = Semt.ToString();
            txtAlan.Text = Alan.ToString();
            if (turu.Equals("satilik"))
            {
                rbSatilik.Checked = true;
            }
            if(Aktif)
            {
                rbAktif.Checked = true;
            }
            else
            {
                rbPasif.Checked = true;
            }
            txtFiyat.Text = Fiyat.ToString();
            yapim.Text = YapimTarihi.ToShortDateString();
            FileStream fs = new FileStream("../../room_cost.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            int i = 0;
            while(yazi != null)
            {
                string[] dosya = yazi.Split('|');
                if (turuSayi == i)
                {
                    cbEvTur.Text = dosya[0];
                }
                yazi = sr.ReadLine();
                i++;
            }
            this.EmlakNumarasi = EmlakNumarasi;
            sr.Close();
            fs.Close();
        }

        public EvDuzenleme(int OdaSayisi, int KatNumarasi, string il, string Semt, decimal Alan, int turuSayi, string turu, bool Aktif,
            DateTime YapimTarihi, decimal Kira = 800, decimal Depozito = 100, decimal EmlakNumarasi = 111111111)
        {
            InitializeComponent();
            txtOdaSayisi.Text = OdaSayisi.ToString();
            txtKatNumarasi.Text = KatNumarasi.ToString();
            cmb_il.Text = il.ToString();
            cmb_semt.Text = Semt.ToString();
            txtAlan.Text = Alan.ToString();

        }

        private void cb_İl_SelectedValueChanged(object sender, EventArgs e)
        {
            Ev.sehir = (cmb_il.SelectedIndex) + 1;
            string dosya_yolu = "../../semtler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Semt Dosyası Bulunmuyor");
                return;
            }
            else
            {
                List<string> semtler = DosyaIslemleri.DosyaOkumaSemt(dosya_yolu, cmb_il.Text);
                cmb_semt.Items.Clear();
                foreach (string semt in semtler)
                {
                    cmb_semt.Items.Add(semt);
                }
                cmb_semt.Enabled = true;
            }
        }

        private void rbSatilik_CheckedChanged(object sender, EventArgs e)
        {
            FormKontrol.SatilikRadioButton(this);
        }

        private void rbKiralik_CheckedChanged(object sender, EventArgs e)
        {
            FormKontrol.KiralikRadioButton(this);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Ev ev in Ev.evler)
            {
                Console.WriteLine(ev.EmlakNumarasi);
                Console.WriteLine(ev.OdaSayisi);

            }
            foreach (Ev ev in Ev.evler)
            {
                if(ev.EmlakNumarasi == EmlakNumarasi)
                {
                    Ev.evler.RemoveAt(i);
                    break;
                }
                i++;
            }
            if (rbSatilik.Checked)
            {
                int a = DosyaIslemleri.RoomCastSayisi(cbEvTur);

                SatilikEv satilikEv = new SatilikEv(
                        int.Parse(txtOdaSayisi.Text), int.Parse(txtKatNumarasi.Text), cmb_il.Text,
                    cmb_semt.Text, int.Parse(txtAlan.Text), a, "satilik", true, DateTime.Parse(yapim.Text), int.Parse(txtFiyat.Text));
                Ev.evler.Add(satilikEv);
                MessageBox.Show("Satılık Ev Kaydedildi");
                string dosya_yolu = "../../satilik.txt";
                DosyaIslemleri.DosyaSatilikYazmak(dosya_yolu, "satilik");
            }
            else
            {
                try
                {
                    int a = DosyaIslemleri.RoomCastSayisi(cbEvTur);

                    KiralikEv kiralikEv = new KiralikEv(int.Parse(txtOdaSayisi.Text), int.Parse(txtKatNumarasi.Text), cmb_il.Text,
                            cmb_semt.Text, int.Parse(txtAlan.Text), a, "kiralik", true, DateTime.Parse(yapim.Text), decimal.Parse(txtKira.Text), decimal.Parse(txtDepozito.Text));
                    Ev.evler.Add(kiralikEv);
                    MessageBox.Show("Kiralık Ev Kaydedildi");
                    string dosya_yolu = "../../kiralik.txt";

                    DosyaIslemleri.DosyaSatilikYazmak(dosya_yolu, "satilik");

                }
                catch (Exception)
                {

                    MessageBox.Show("Boş alan bırakmayınız!", "HATA");
                }

            }
        }

        private void txtOdaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbSemt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_İl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_İl_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void EvDuzenleme_Load(object sender, EventArgs e)
        {
            cmb_il.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void yapim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] istanbul = { "Sancaktepe", "Üsküdar", "Kadıköy", "Beşiktaş", "Ümraniye" };
            string[] ankara = { "Çankaya", "Turgutlu", "Etimesgut", "Gölbaşı", "Keçiören" };
            string[] konya = { "Selçuklu", "Meram", "Beyşehir", "Cihanbeyli", "Karatay" };
            cmb_semt.Items.Clear();
            cmb_semt.Text = "";

            if (cmb_il.Text == "İstanbul")
            {
                cmb_semt.Enabled = true;
                cmb_semt.Items.AddRange(istanbul);
            }
            else if (cmb_il.Text == "Ankara")
            {
                cmb_semt.Enabled = true;
                cmb_semt.Items.AddRange(ankara);
            }
            else if (cmb_il.Text == "Konya")
            {
                cmb_semt.Enabled = true;
                cmb_semt.Items.AddRange(konya);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SorguEkrani sorguekrani = new SorguEkrani();
            this.Hide();
            sorguekrani.Show();
        }
    }
}
