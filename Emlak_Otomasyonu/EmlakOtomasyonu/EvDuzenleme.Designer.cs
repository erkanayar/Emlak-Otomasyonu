namespace EmlakOtomasyonu
{
    partial class EvDuzenleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yapim = new System.Windows.Forms.DateTimePicker();
            this.txtDepozito = new System.Windows.Forms.TextBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.cbEvTur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKatNumarasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbKiralik = new System.Windows.Forms.RadioButton();
            this.rbSatilik = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPasif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_il = new System.Windows.Forms.ComboBox();
            this.cmb_semt = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // yapim
            // 
            this.yapim.Location = new System.Drawing.Point(628, 33);
            this.yapim.MaxDate = new System.DateTime(2024, 11, 15, 0, 0, 0, 0);
            this.yapim.Name = "yapim";
            this.yapim.Size = new System.Drawing.Size(316, 38);
            this.yapim.TabIndex = 7;
            this.yapim.Value = new System.DateTime(2024, 11, 15, 0, 0, 0, 0);
            this.yapim.ValueChanged += new System.EventHandler(this.yapim_ValueChanged);
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(574, 228);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(173, 38);
            this.txtDepozito.TabIndex = 9;
            this.txtDepozito.Visible = false;
            this.txtDepozito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(574, 280);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(173, 38);
            this.txtKira.TabIndex = 10;
            this.txtKira.Visible = false;
            this.txtKira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kirasi :";
            this.label8.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(574, 228);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(173, 38);
            this.txtFiyat.TabIndex = 9;
            this.txtFiyat.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fiyatı :";
            this.label9.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.AutoSize = true;
            this.btnGonder.Location = new System.Drawing.Point(816, 272);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(108, 42);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "Kaydet";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // cbEvTur
            // 
            this.cbEvTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbEvTur.FormattingEnabled = true;
            this.cbEvTur.ItemHeight = 30;
            this.cbEvTur.Items.AddRange(new object[] {
            "Daire",
            "Bahçeli",
            "Dubleks",
            "Mustakil"});
            this.cbEvTur.Location = new System.Drawing.Point(232, 297);
            this.cbEvTur.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbEvTur.Name = "cbEvTur";
            this.cbEvTur.Size = new System.Drawing.Size(170, 38);
            this.cbEvTur.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 36;
            this.label7.Text = "Evin Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "Yapım Tarihi :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKatNumarasi
            // 
            this.txtKatNumarasi.Location = new System.Drawing.Point(232, 242);
            this.txtKatNumarasi.Name = "txtKatNumarasi";
            this.txtKatNumarasi.Size = new System.Drawing.Size(170, 38);
            this.txtKatNumarasi.TabIndex = 6;
            this.txtKatNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kat Numarası :";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(232, 193);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(170, 38);
            this.txtOdaSayisi.TabIndex = 5;
            this.txtOdaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Oda Sayısı :";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(232, 144);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(170, 38);
            this.txtAlan.TabIndex = 4;
            this.txtAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Alan(m2) :";
            // 
            // rbKiralik
            // 
            this.rbKiralik.AutoSize = true;
            this.rbKiralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbKiralik.Location = new System.Drawing.Point(129, 40);
            this.rbKiralik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbKiralik.Name = "rbKiralik";
            this.rbKiralik.Size = new System.Drawing.Size(116, 35);
            this.rbKiralik.TabIndex = 3;
            this.rbKiralik.TabStop = true;
            this.rbKiralik.Text = "Kiralık";
            this.rbKiralik.UseVisualStyleBackColor = true;
            this.rbKiralik.CheckedChanged += new System.EventHandler(this.rbKiralik_CheckedChanged);
            // 
            // rbSatilik
            // 
            this.rbSatilik.AutoSize = true;
            this.rbSatilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbSatilik.Location = new System.Drawing.Point(10, 40);
            this.rbSatilik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSatilik.Name = "rbSatilik";
            this.rbSatilik.Size = new System.Drawing.Size(115, 35);
            this.rbSatilik.TabIndex = 2;
            this.rbSatilik.TabStop = true;
            this.rbSatilik.Text = "Satılık";
            this.rbSatilik.UseVisualStyleBackColor = true;
            this.rbSatilik.CheckedChanged += new System.EventHandler(this.rbSatilik_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "İlçe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "İl :";
            // 
            // rbPasif
            // 
            this.rbPasif.AutoSize = true;
            this.rbPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbPasif.Location = new System.Drawing.Point(39, 70);
            this.rbPasif.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPasif.Name = "rbPasif";
            this.rbPasif.Size = new System.Drawing.Size(101, 35);
            this.rbPasif.TabIndex = 12;
            this.rbPasif.TabStop = true;
            this.rbPasif.Text = "Pasif";
            this.rbPasif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbAktif.Location = new System.Drawing.Point(39, 28);
            this.rbAktif.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(94, 35);
            this.rbAktif.TabIndex = 11;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAktif);
            this.groupBox1.Controls.Add(this.rbPasif);
            this.groupBox1.Location = new System.Drawing.Point(757, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 110);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // cmb_il
            // 
            this.cmb_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_il.FormattingEnabled = true;
            this.cmb_il.Location = new System.Drawing.Point(236, 36);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Size = new System.Drawing.Size(166, 39);
            this.cmb_il.TabIndex = 48;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // cmb_semt
            // 
            this.cmb_semt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semt.FormattingEnabled = true;
            this.cmb_semt.Location = new System.Drawing.Point(236, 81);
            this.cmb_semt.Name = "cmb_semt";
            this.cmb_semt.Size = new System.Drawing.Size(166, 39);
            this.cmb_semt.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKiralik);
            this.groupBox2.Controls.Add(this.rbSatilik);
            this.groupBox2.Location = new System.Drawing.Point(454, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 99);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 51;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_semt);
            this.Controls.Add(this.cmb_il);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yapim);
            this.Controls.Add(this.txtDepozito);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.cbEvTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKatNumarasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "EvDuzenleme";
            this.Text = "Ev Düzenleme Ekranı";
            this.Load += new System.EventHandler(this.EvDuzenleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker yapim;
        public System.Windows.Forms.TextBox txtDepozito;
        public System.Windows.Forms.TextBox txtKira;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtFiyat;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGonder;
        public System.Windows.Forms.ComboBox cbEvTur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtKatNumarasi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtOdaSayisi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rbKiralik;
        public System.Windows.Forms.RadioButton rbSatilik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rbPasif;
        public System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_il;
        private System.Windows.Forms.ComboBox cmb_semt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}