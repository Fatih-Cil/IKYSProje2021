
namespace IKYS
{
    partial class PersonelGuncelleUI
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
            this.gbxPersonelGuncelle = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.tbxSicilNoAra = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblSicilAra = new System.Windows.Forms.Label();
            this.gbxFotoEkle = new System.Windows.Forms.GroupBox();
            this.tbxDosyaAdi = new System.Windows.Forms.TextBox();
            this.tbxDosyaYolu = new System.Windows.Forms.TextBox();
            this.pbxPersonelFoto = new System.Windows.Forms.PictureBox();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.btnFotoEkle = new System.Windows.Forms.Button();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.gbxKisisel = new System.Windows.Forms.GroupBox();
            this.lblGelenSicilNo = new System.Windows.Forms.Label();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.cbxKangrubu = new System.Windows.Forms.ComboBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxEposta = new System.Windows.Forms.TextBox();
            this.tbxCep = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxTcNo = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.gbxKurumsal = new System.Windows.Forms.GroupBox();
            this.chbxSifreGuncelle = new System.Windows.Forms.CheckBox();
            this.tbxYillikIzin = new System.Windows.Forms.TextBox();
            this.lbldurum = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.cbxGorev = new System.Windows.Forms.ComboBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.tbxMaas = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblOzelSaglik = new System.Windows.Forms.Label();
            this.cbxOzelSaglik = new System.Windows.Forms.ComboBox();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblYillikİzin = new System.Windows.Forms.Label();
            this.gbxPersonelGuncelle.SuspendLayout();
            this.gbxFotoEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonelFoto)).BeginInit();
            this.gbxKisisel.SuspendLayout();
            this.gbxKurumsal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPersonelGuncelle
            // 
            this.gbxPersonelGuncelle.Controls.Add(this.cbxDurum);
            this.gbxPersonelGuncelle.Controls.Add(this.btnAra);
            this.gbxPersonelGuncelle.Controls.Add(this.tbxSicilNoAra);
            this.gbxPersonelGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxPersonelGuncelle.Controls.Add(this.lblSicilAra);
            this.gbxPersonelGuncelle.Controls.Add(this.gbxFotoEkle);
            this.gbxPersonelGuncelle.Controls.Add(this.gbxKisisel);
            this.gbxPersonelGuncelle.Controls.Add(this.gbxKurumsal);
            this.gbxPersonelGuncelle.Location = new System.Drawing.Point(12, 78);
            this.gbxPersonelGuncelle.Name = "gbxPersonelGuncelle";
            this.gbxPersonelGuncelle.Size = new System.Drawing.Size(1113, 497);
            this.gbxPersonelGuncelle.TabIndex = 0;
            this.gbxPersonelGuncelle.TabStop = false;
            this.gbxPersonelGuncelle.Text = "PERSONEL GÜNCELLE";
            // 
            // cbxDurum
            // 
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cbxDurum.Location = new System.Drawing.Point(553, 424);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(116, 28);
            this.cbxDurum.TabIndex = 32;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Location = new System.Drawing.Point(237, 55);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(94, 36);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // tbxSicilNoAra
            // 
            this.tbxSicilNoAra.Location = new System.Drawing.Point(114, 59);
            this.tbxSicilNoAra.Name = "tbxSicilNoAra";
            this.tbxSicilNoAra.Size = new System.Drawing.Size(117, 26);
            this.tbxSicilNoAra.TabIndex = 14;
            this.tbxSicilNoAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSicilNoAra_KeyPress);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(943, 59);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(128, 42);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblSicilAra
            // 
            this.lblSicilAra.AutoSize = true;
            this.lblSicilAra.Location = new System.Drawing.Point(38, 61);
            this.lblSicilAra.Name = "lblSicilAra";
            this.lblSicilAra.Size = new System.Drawing.Size(61, 20);
            this.lblSicilAra.TabIndex = 13;
            this.lblSicilAra.Text = "Sicil No";
            // 
            // gbxFotoEkle
            // 
            this.gbxFotoEkle.Controls.Add(this.tbxDosyaAdi);
            this.gbxFotoEkle.Controls.Add(this.tbxDosyaYolu);
            this.gbxFotoEkle.Controls.Add(this.pbxPersonelFoto);
            this.gbxFotoEkle.Controls.Add(this.lblDosyaAdi);
            this.gbxFotoEkle.Controls.Add(this.btnFotoEkle);
            this.gbxFotoEkle.Controls.Add(this.lblDosyaYolu);
            this.gbxFotoEkle.Location = new System.Drawing.Point(806, 111);
            this.gbxFotoEkle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFotoEkle.Name = "gbxFotoEkle";
            this.gbxFotoEkle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFotoEkle.Size = new System.Drawing.Size(295, 362);
            this.gbxFotoEkle.TabIndex = 12;
            this.gbxFotoEkle.TabStop = false;
            this.gbxFotoEkle.Text = "Personel Fotoğraf";
            // 
            // tbxDosyaAdi
            // 
            this.tbxDosyaAdi.Location = new System.Drawing.Point(113, 268);
            this.tbxDosyaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDosyaAdi.Name = "tbxDosyaAdi";
            this.tbxDosyaAdi.ReadOnly = true;
            this.tbxDosyaAdi.Size = new System.Drawing.Size(152, 26);
            this.tbxDosyaAdi.TabIndex = 10;
            // 
            // tbxDosyaYolu
            // 
            this.tbxDosyaYolu.Location = new System.Drawing.Point(113, 232);
            this.tbxDosyaYolu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDosyaYolu.Name = "tbxDosyaYolu";
            this.tbxDosyaYolu.ReadOnly = true;
            this.tbxDosyaYolu.Size = new System.Drawing.Size(152, 26);
            this.tbxDosyaYolu.TabIndex = 9;
            // 
            // pbxPersonelFoto
            // 
            this.pbxPersonelFoto.Location = new System.Drawing.Point(83, 45);
            this.pbxPersonelFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPersonelFoto.Name = "pbxPersonelFoto";
            this.pbxPersonelFoto.Size = new System.Drawing.Size(148, 176);
            this.pbxPersonelFoto.TabIndex = 8;
            this.pbxPersonelFoto.TabStop = false;
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(26, 272);
            this.lblDosyaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(81, 20);
            this.lblDosyaAdi.TabIndex = 7;
            this.lblDosyaAdi.Text = "Dosya Adı";
            // 
            // btnFotoEkle
            // 
            this.btnFotoEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnFotoEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFotoEkle.Location = new System.Drawing.Point(137, 297);
            this.btnFotoEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFotoEkle.Name = "btnFotoEkle";
            this.btnFotoEkle.Size = new System.Drawing.Size(127, 44);
            this.btnFotoEkle.TabIndex = 5;
            this.btnFotoEkle.Text = "Fotoğraf Ekle";
            this.btnFotoEkle.UseVisualStyleBackColor = false;
            this.btnFotoEkle.Click += new System.EventHandler(this.btnFotoEkle_Click);
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(16, 237);
            this.lblDosyaYolu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(90, 20);
            this.lblDosyaYolu.TabIndex = 6;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // gbxKisisel
            // 
            this.gbxKisisel.Controls.Add(this.lblGelenSicilNo);
            this.gbxKisisel.Controls.Add(this.lblKanGrubu);
            this.gbxKisisel.Controls.Add(this.cbxKangrubu);
            this.gbxKisisel.Controls.Add(this.lblAdres);
            this.gbxKisisel.Controls.Add(this.lblEposta);
            this.gbxKisisel.Controls.Add(this.lblCep);
            this.gbxKisisel.Controls.Add(this.dtpDogumTarihi);
            this.gbxKisisel.Controls.Add(this.tbxAdres);
            this.gbxKisisel.Controls.Add(this.tbxEposta);
            this.gbxKisisel.Controls.Add(this.tbxCep);
            this.gbxKisisel.Controls.Add(this.tbxSoyad);
            this.gbxKisisel.Controls.Add(this.tbxAd);
            this.gbxKisisel.Controls.Add(this.tbxTcNo);
            this.gbxKisisel.Controls.Add(this.lblDogumTarihi);
            this.gbxKisisel.Controls.Add(this.lblSoyAdi);
            this.gbxKisisel.Controls.Add(this.lblAdi);
            this.gbxKisisel.Controls.Add(this.lblTcNo);
            this.gbxKisisel.Controls.Add(this.lblSicilNo);
            this.gbxKisisel.Location = new System.Drawing.Point(26, 111);
            this.gbxKisisel.Name = "gbxKisisel";
            this.gbxKisisel.Size = new System.Drawing.Size(381, 362);
            this.gbxKisisel.TabIndex = 10;
            this.gbxKisisel.TabStop = false;
            this.gbxKisisel.Text = "Kişisle Bilgiler";
            // 
            // lblGelenSicilNo
            // 
            this.lblGelenSicilNo.AutoSize = true;
            this.lblGelenSicilNo.ForeColor = System.Drawing.Color.Red;
            this.lblGelenSicilNo.Location = new System.Drawing.Point(122, 45);
            this.lblGelenSicilNo.Name = "lblGelenSicilNo";
            this.lblGelenSicilNo.Size = new System.Drawing.Size(0, 20);
            this.lblGelenSicilNo.TabIndex = 19;
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(32, 311);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(86, 20);
            this.lblKanGrubu.TabIndex = 17;
            this.lblKanGrubu.Text = "Kan Grubu";
            // 
            // cbxKangrubu
            // 
            this.cbxKangrubu.FormattingEnabled = true;
            this.cbxKangrubu.Items.AddRange(new object[] {
            "0 RH+",
            "0 RH-",
            "A RH+",
            "A RH-",
            "B RH+",
            "B RH-",
            "AB RH+",
            "AB RH-"});
            this.cbxKangrubu.Location = new System.Drawing.Point(125, 303);
            this.cbxKangrubu.Name = "cbxKangrubu";
            this.cbxKangrubu.Size = new System.Drawing.Size(97, 28);
            this.cbxKangrubu.TabIndex = 16;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(67, 275);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 20);
            this.lblAdres.TabIndex = 15;
            this.lblAdres.Text = "Adres";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(61, 240);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(60, 20);
            this.lblEposta.TabIndex = 14;
            this.lblEposta.Text = "Eposta";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(80, 205);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 20);
            this.lblCep.TabIndex = 13;
            this.lblCep.Text = "Cep";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(125, 173);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpDogumTarihi.TabIndex = 12;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(125, 269);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(200, 26);
            this.tbxAdres.TabIndex = 6;
            // 
            // tbxEposta
            // 
            this.tbxEposta.Location = new System.Drawing.Point(125, 237);
            this.tbxEposta.Name = "tbxEposta";
            this.tbxEposta.Size = new System.Drawing.Size(200, 26);
            this.tbxEposta.TabIndex = 5;
            // 
            // tbxCep
            // 
            this.tbxCep.Location = new System.Drawing.Point(125, 205);
            this.tbxCep.Name = "tbxCep";
            this.tbxCep.Size = new System.Drawing.Size(200, 26);
            this.tbxCep.TabIndex = 4;
            this.tbxCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCep_KeyPress);
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(125, 141);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(200, 26);
            this.tbxSoyad.TabIndex = 3;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(125, 109);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(200, 26);
            this.tbxAd.TabIndex = 2;
            // 
            // tbxTcNo
            // 
            this.tbxTcNo.Location = new System.Drawing.Point(125, 77);
            this.tbxTcNo.MaxLength = 11;
            this.tbxTcNo.Name = "tbxTcNo";
            this.tbxTcNo.ReadOnly = true;
            this.tbxTcNo.Size = new System.Drawing.Size(200, 26);
            this.tbxTcNo.TabIndex = 1;
            this.tbxTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTcNo_KeyPress);
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(19, 178);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(103, 20);
            this.lblDogumTarihi.TabIndex = 11;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.Location = new System.Drawing.Point(61, 144);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(63, 20);
            this.lblSoyAdi.TabIndex = 10;
            this.lblSoyAdi.Text = "Soyadı*";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(86, 115);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(38, 20);
            this.lblAdi.TabIndex = 9;
            this.lblAdi.Text = "Adı*";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(65, 83);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(59, 20);
            this.lblTcNo.TabIndex = 8;
            this.lblTcNo.Text = "TC No*";
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.Location = new System.Drawing.Point(63, 45);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(65, 20);
            this.lblSicilNo.TabIndex = 18;
            this.lblSicilNo.Text = "Sicil No:";
            // 
            // gbxKurumsal
            // 
            this.gbxKurumsal.Controls.Add(this.chbxSifreGuncelle);
            this.gbxKurumsal.Controls.Add(this.tbxYillikIzin);
            this.gbxKurumsal.Controls.Add(this.lbldurum);
            this.gbxKurumsal.Controls.Add(this.cbxRol);
            this.gbxKurumsal.Controls.Add(this.cbxGorev);
            this.gbxKurumsal.Controls.Add(this.cbxBolum);
            this.gbxKurumsal.Controls.Add(this.tbxMaas);
            this.gbxKurumsal.Controls.Add(this.tbxSifre);
            this.gbxKurumsal.Controls.Add(this.lblRol);
            this.gbxKurumsal.Controls.Add(this.lblGorev);
            this.gbxKurumsal.Controls.Add(this.lblBolum);
            this.gbxKurumsal.Controls.Add(this.lblOzelSaglik);
            this.gbxKurumsal.Controls.Add(this.cbxOzelSaglik);
            this.gbxKurumsal.Controls.Add(this.lblIseGirisTarihi);
            this.gbxKurumsal.Controls.Add(this.lblMaas);
            this.gbxKurumsal.Controls.Add(this.label1);
            this.gbxKurumsal.Controls.Add(this.dtpIseGirisTarihi);
            this.gbxKurumsal.Controls.Add(this.lblYillikİzin);
            this.gbxKurumsal.Location = new System.Drawing.Point(413, 111);
            this.gbxKurumsal.Name = "gbxKurumsal";
            this.gbxKurumsal.Size = new System.Drawing.Size(388, 362);
            this.gbxKurumsal.TabIndex = 11;
            this.gbxKurumsal.TabStop = false;
            this.gbxKurumsal.Text = "Kurumsal Bilgiler";
            // 
            // chbxSifreGuncelle
            // 
            this.chbxSifreGuncelle.AutoSize = true;
            this.chbxSifreGuncelle.Location = new System.Drawing.Point(244, 49);
            this.chbxSifreGuncelle.Name = "chbxSifreGuncelle";
            this.chbxSifreGuncelle.Size = new System.Drawing.Size(126, 24);
            this.chbxSifreGuncelle.TabIndex = 34;
            this.chbxSifreGuncelle.Text = "Şifre Değiştir";
            this.chbxSifreGuncelle.UseVisualStyleBackColor = true;
            this.chbxSifreGuncelle.CheckedChanged += new System.EventHandler(this.chbxSifreGuncelle_CheckedChanged);
            // 
            // tbxYillikIzin
            // 
            this.tbxYillikIzin.Location = new System.Drawing.Point(140, 141);
            this.tbxYillikIzin.Name = "tbxYillikIzin";
            this.tbxYillikIzin.Size = new System.Drawing.Size(116, 26);
            this.tbxYillikIzin.TabIndex = 31;
            this.tbxYillikIzin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxYillikIzin_KeyPress);
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(75, 316);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(63, 20);
            this.lbldurum.TabIndex = 33;
            this.lbldurum.Text = "Durum*";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(140, 278);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(187, 28);
            this.cbxRol.TabIndex = 26;
            // 
            // cbxGorev
            // 
            this.cbxGorev.FormattingEnabled = true;
            this.cbxGorev.Location = new System.Drawing.Point(140, 244);
            this.cbxGorev.Name = "cbxGorev";
            this.cbxGorev.Size = new System.Drawing.Size(187, 28);
            this.cbxGorev.TabIndex = 25;
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Location = new System.Drawing.Point(140, 210);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(187, 28);
            this.cbxBolum.TabIndex = 24;
            // 
            // tbxMaas
            // 
            this.tbxMaas.Location = new System.Drawing.Point(140, 77);
            this.tbxMaas.Name = "tbxMaas";
            this.tbxMaas.Size = new System.Drawing.Size(200, 26);
            this.tbxMaas.TabIndex = 14;
            this.tbxMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMaas_KeyPress);
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(140, 45);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.ReadOnly = true;
            this.tbxSifre.Size = new System.Drawing.Size(98, 26);
            this.tbxSifre.TabIndex = 13;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(101, 281);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 20);
            this.lblRol.TabIndex = 29;
            this.lblRol.Text = "Rol*";
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(77, 247);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(61, 20);
            this.lblGorev.TabIndex = 28;
            this.lblGorev.Text = "Görevi*";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(69, 213);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(69, 20);
            this.lblBolum.TabIndex = 27;
            this.lblBolum.Text = "Bölümü*";
            // 
            // lblOzelSaglik
            // 
            this.lblOzelSaglik.AutoSize = true;
            this.lblOzelSaglik.Location = new System.Drawing.Point(44, 184);
            this.lblOzelSaglik.Name = "lblOzelSaglik";
            this.lblOzelSaglik.Size = new System.Drawing.Size(88, 20);
            this.lblOzelSaglik.TabIndex = 23;
            this.lblOzelSaglik.Text = "Özel Sağlık";
            // 
            // cbxOzelSaglik
            // 
            this.cbxOzelSaglik.FormattingEnabled = true;
            this.cbxOzelSaglik.Items.AddRange(new object[] {
            "YATARAK",
            "AYAKTA"});
            this.cbxOzelSaglik.Location = new System.Drawing.Point(140, 176);
            this.cbxOzelSaglik.Name = "cbxOzelSaglik";
            this.cbxOzelSaglik.Size = new System.Drawing.Size(116, 28);
            this.cbxOzelSaglik.TabIndex = 22;
            // 
            // lblIseGirisTarihi
            // 
            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(23, 118);
            this.lblIseGirisTarihi.Name = "lblIseGirisTarihi";
            this.lblIseGirisTarihi.Size = new System.Drawing.Size(109, 20);
            this.lblIseGirisTarihi.TabIndex = 19;
            this.lblIseGirisTarihi.Text = "İşe Giriş Tarihi";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(84, 84);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(54, 20);
            this.lblMaas.TabIndex = 18;
            this.lblMaas.Text = "Maaş*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Şifre*";
            // 
            // dtpIseGirisTarihi
            // 
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(140, 109);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpIseGirisTarihi.TabIndex = 16;
            // 
            // lblYillikİzin
            // 
            this.lblYillikİzin.AutoSize = true;
            this.lblYillikİzin.Location = new System.Drawing.Point(69, 143);
            this.lblYillikİzin.Name = "lblYillikİzin";
            this.lblYillikİzin.Size = new System.Drawing.Size(69, 20);
            this.lblYillikİzin.TabIndex = 30;
            this.lblYillikİzin.Text = "Yıllık İzin";
            // 
            // PersonelGuncelleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 599);
            this.Controls.Add(this.gbxPersonelGuncelle);
            this.Name = "PersonelGuncelleUI";
            this.Text = "PersonelGuncelleUI";
            this.Load += new System.EventHandler(this.PersonelGuncelleUI_Load);
            this.gbxPersonelGuncelle.ResumeLayout(false);
            this.gbxPersonelGuncelle.PerformLayout();
            this.gbxFotoEkle.ResumeLayout(false);
            this.gbxFotoEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonelFoto)).EndInit();
            this.gbxKisisel.ResumeLayout(false);
            this.gbxKisisel.PerformLayout();
            this.gbxKurumsal.ResumeLayout(false);
            this.gbxKurumsal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonelGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxSicilNoAra;
        private System.Windows.Forms.Label lblSicilAra;
        private System.Windows.Forms.GroupBox gbxFotoEkle;
        private System.Windows.Forms.TextBox tbxDosyaAdi;
        private System.Windows.Forms.TextBox tbxDosyaYolu;
        private System.Windows.Forms.PictureBox pbxPersonelFoto;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Button btnFotoEkle;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.GroupBox gbxKisisel;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.ComboBox cbxKangrubu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.TextBox tbxEposta;
        private System.Windows.Forms.TextBox tbxCep;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxTcNo;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblSoyAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.GroupBox gbxKurumsal;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.ComboBox cbxGorev;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.TextBox tbxMaas;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblOzelSaglik;
        private System.Windows.Forms.ComboBox cbxOzelSaglik;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
        private System.Windows.Forms.TextBox tbxYillikIzin;
        private System.Windows.Forms.Label lblYillikİzin;
        private System.Windows.Forms.Label lblGelenSicilNo;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.CheckBox chbxSifreGuncelle;
    }
}