namespace EmlakOtomasyonu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_İl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSemt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbKiralik = new System.Windows.Forms.RadioButton();
            this.RbSatilik = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.rbPasif = new System.Windows.Forms.RadioButton();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl :";
            // 
            // cb_İl
            // 
            this.cb_İl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_İl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cb_İl.FormattingEnabled = true;
            this.cb_İl.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Konya"});
            this.cb_İl.Location = new System.Drawing.Point(231, 35);
            this.cb_İl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cb_İl.Name = "cb_İl";
            this.cb_İl.Size = new System.Drawing.Size(170, 38);
            this.cb_İl.TabIndex = 0;
            this.cb_İl.SelectedIndexChanged += new System.EventHandler(this.cb_İl_SelectedIndexChanged);
            this.cb_İl.SelectedValueChanged += new System.EventHandler(this.cb_İl_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlçe :";
            // 
            // cbSemt
            // 
            this.cbSemt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemt.Enabled = false;
            this.cbSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbSemt.FormattingEnabled = true;
            this.cbSemt.Location = new System.Drawing.Point(231, 85);
            this.cbSemt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbSemt.Name = "cbSemt";
            this.cbSemt.Size = new System.Drawing.Size(170, 38);
            this.cbSemt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "Önerilen Fiyat : _ _ ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbKiralik);
            this.groupBox2.Controls.Add(this.RbSatilik);
            this.groupBox2.Location = new System.Drawing.Point(453, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 99);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // RbKiralik
            // 
            this.RbKiralik.AutoSize = true;
            this.RbKiralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.RbKiralik.Location = new System.Drawing.Point(129, 40);
            this.RbKiralik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RbKiralik.Name = "RbKiralik";
            this.RbKiralik.Size = new System.Drawing.Size(116, 35);
            this.RbKiralik.TabIndex = 3;
            this.RbKiralik.TabStop = true;
            this.RbKiralik.Text = "Kiralik";
            this.RbKiralik.UseVisualStyleBackColor = true;
            this.RbKiralik.CheckedChanged += new System.EventHandler(this.rbKiralik_CheckedChanged_1);
            // 
            // RbSatilik
            // 
            this.RbSatilik.AutoSize = true;
            this.RbSatilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.RbSatilik.Location = new System.Drawing.Point(10, 40);
            this.RbSatilik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RbSatilik.Name = "RbSatilik";
            this.RbSatilik.Size = new System.Drawing.Size(115, 35);
            this.RbSatilik.TabIndex = 2;
            this.RbSatilik.TabStop = true;
            this.RbSatilik.Text = "Satılık";
            this.RbSatilik.UseVisualStyleBackColor = true;
            this.RbSatilik.CheckedChanged += new System.EventHandler(this.rbSatilik_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAktif);
            this.groupBox1.Controls.Add(this.rbPasif);
            this.groupBox1.Location = new System.Drawing.Point(756, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 110);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
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
            this.rbAktif.CheckedChanged += new System.EventHandler(this.rbAktif_CheckedChanged);
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
            // yapim
            // 
            this.yapim.Location = new System.Drawing.Point(627, 39);
            this.yapim.MaxDate = new System.DateTime(2024, 11, 15, 0, 0, 0, 0);
            this.yapim.Name = "yapim";
            this.yapim.Size = new System.Drawing.Size(343, 37);
            this.yapim.TabIndex = 54;
            this.yapim.Value = new System.DateTime(2024, 11, 15, 0, 0, 0, 0);
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(573, 234);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(173, 37);
            this.txtDepozito.TabIndex = 56;
            this.txtDepozito.Visible = false;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(573, 286);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(173, 37);
            this.txtKira.TabIndex = 58;
            this.txtKira.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 68;
            this.label8.Text = "Kirasi :";
            this.label8.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(573, 234);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(173, 37);
            this.txtFiyat.TabIndex = 57;
            this.txtFiyat.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 31);
            this.label9.TabIndex = 67;
            this.label9.Text = "Fiyatı :";
            this.label9.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.AutoSize = true;
            this.btnGonder.Location = new System.Drawing.Point(811, 278);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(115, 42);
            this.btnGonder.TabIndex = 59;
            this.btnGonder.Text = "Kaydet";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click_1);
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
            this.cbEvTur.Location = new System.Drawing.Point(231, 303);
            this.cbEvTur.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbEvTur.Name = "cbEvTur";
            this.cbEvTur.Size = new System.Drawing.Size(170, 38);
            this.cbEvTur.TabIndex = 55;
            this.cbEvTur.SelectedIndexChanged += new System.EventHandler(this.cbEvTur_SelectedIndexChanged);
            this.cbEvTur.SelectedValueChanged += new System.EventHandler(this.cbEvTur_SelectedValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 31);
            this.label7.TabIndex = 66;
            this.label7.Text = "Evin Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 31);
            this.label6.TabIndex = 65;
            this.label6.Text = "Yapım Tarihi :";
            // 
            // txtKatNumarasi
            // 
            this.txtKatNumarasi.Location = new System.Drawing.Point(231, 248);
            this.txtKatNumarasi.Name = "txtKatNumarasi";
            this.txtKatNumarasi.Size = new System.Drawing.Size(170, 37);
            this.txtKatNumarasi.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 31);
            this.label5.TabIndex = 64;
            this.label5.Text = "Kat Numarası :";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(231, 199);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(170, 37);
            this.txtOdaSayisi.TabIndex = 52;
            this.txtOdaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 63;
            this.label4.Text = "Oda Sayısı :";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(231, 150);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(170, 37);
            this.txtAlan.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "Alan(m2) :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 73;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSemt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_İl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Yeni Kayıt Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_İl;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbSemt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton RbKiralik;
        public System.Windows.Forms.RadioButton RbSatilik;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbAktif;
        public System.Windows.Forms.RadioButton rbPasif;
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
        private System.Windows.Forms.Button button1;
    }
}

