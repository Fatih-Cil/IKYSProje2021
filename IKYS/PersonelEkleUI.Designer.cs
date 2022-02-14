
namespace IKYS
{
    partial class PersonelEkleUI
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
            this.gbxKisisel = new System.Windows.Forms.GroupBox();
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
            this.gbxKurumsal = new System.Windows.Forms.GroupBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.cbxGorev = new System.Windows.Forms.ComboBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.tbxMaas = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblOzelSaglik = new System.Windows.Forms.Label();
            this.cbxOzelSaglik = new System.Windows.Forms.ComboBox();
            this.lbldurum = new System.Windows.Forms.Label();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.gbxPersonelEkle = new System.Windows.Forms.GroupBox();
            this.gbxFotoEkle = new System.Windows.Forms.GroupBox();
            this.tbxDosyaAdi = new System.Windows.Forms.TextBox();
            this.tbxDosyaYolu = new System.Windows.Forms.TextBox();
            this.pbxPersonelFoto = new System.Windows.Forms.PictureBox();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.btnFotoEkle = new System.Windows.Forms.Button();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgwPersonelEkle = new System.Windows.Forms.DataGridView();
            this.gbxKisisel.SuspendLayout();
            this.gbxKurumsal.SuspendLayout();
            this.gbxPersonelEkle.SuspendLayout();
            this.gbxFotoEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonelFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxKisisel
            // 
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
            this.gbxKisisel.Location = new System.Drawing.Point(27, 56);
            this.gbxKisisel.Name = "gbxKisisel";
            this.gbxKisisel.Size = new System.Drawing.Size(366, 362);
            this.gbxKisisel.TabIndex = 2;
            this.gbxKisisel.TabStop = false;
            this.gbxKisisel.Text = "Kişisle Bilgiler";
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(33, 280);
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
            this.cbxKangrubu.Location = new System.Drawing.Point(126, 272);
            this.cbxKangrubu.Name = "cbxKangrubu";
            this.cbxKangrubu.Size = new System.Drawing.Size(97, 28);
            this.cbxKangrubu.TabIndex = 16;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(68, 244);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 20);
            this.lblAdres.TabIndex = 15;
            this.lblAdres.Text = "Adres";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(62, 209);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(60, 20);
            this.lblEposta.TabIndex = 14;
            this.lblEposta.Text = "Eposta";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(81, 174);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 20);
            this.lblCep.TabIndex = 13;
            this.lblCep.Text = "Cep";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(126, 142);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpDogumTarihi.TabIndex = 12;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(126, 238);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(200, 26);
            this.tbxAdres.TabIndex = 6;
            // 
            // tbxEposta
            // 
            this.tbxEposta.Location = new System.Drawing.Point(126, 206);
            this.tbxEposta.Name = "tbxEposta";
            this.tbxEposta.Size = new System.Drawing.Size(200, 26);
            this.tbxEposta.TabIndex = 5;
            // 
            // tbxCep
            // 
            this.tbxCep.Location = new System.Drawing.Point(126, 174);
            this.tbxCep.Name = "tbxCep";
            this.tbxCep.Size = new System.Drawing.Size(200, 26);
            this.tbxCep.TabIndex = 4;
            this.tbxCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCep_KeyPress);
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(126, 110);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(200, 26);
            this.tbxSoyad.TabIndex = 3;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(126, 78);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(200, 26);
            this.tbxAd.TabIndex = 2;
            // 
            // tbxTcNo
            // 
            this.tbxTcNo.Location = new System.Drawing.Point(126, 46);
            this.tbxTcNo.MaxLength = 11;
            this.tbxTcNo.Name = "tbxTcNo";
            this.tbxTcNo.Size = new System.Drawing.Size(200, 26);
            this.tbxTcNo.TabIndex = 1;
            this.tbxTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTcNo_KeyPress);
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(20, 147);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(103, 20);
            this.lblDogumTarihi.TabIndex = 11;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.Location = new System.Drawing.Point(62, 113);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(63, 20);
            this.lblSoyAdi.TabIndex = 10;
            this.lblSoyAdi.Text = "Soyadı*";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(87, 84);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(38, 20);
            this.lblAdi.TabIndex = 9;
            this.lblAdi.Text = "Adı*";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(66, 52);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(59, 20);
            this.lblTcNo.TabIndex = 8;
            this.lblTcNo.Text = "TC No*";
            // 
            // gbxKurumsal
            // 
            this.gbxKurumsal.Controls.Add(this.cbxRol);
            this.gbxKurumsal.Controls.Add(this.cbxGorev);
            this.gbxKurumsal.Controls.Add(this.cbxBolum);
            this.gbxKurumsal.Controls.Add(this.cbxDurum);
            this.gbxKurumsal.Controls.Add(this.tbxMaas);
            this.gbxKurumsal.Controls.Add(this.tbxSifre);
            this.gbxKurumsal.Controls.Add(this.lblRol);
            this.gbxKurumsal.Controls.Add(this.lblGorev);
            this.gbxKurumsal.Controls.Add(this.lblBolum);
            this.gbxKurumsal.Controls.Add(this.lblOzelSaglik);
            this.gbxKurumsal.Controls.Add(this.cbxOzelSaglik);
            this.gbxKurumsal.Controls.Add(this.lbldurum);
            this.gbxKurumsal.Controls.Add(this.lblIseGirisTarihi);
            this.gbxKurumsal.Controls.Add(this.lblMaas);
            this.gbxKurumsal.Controls.Add(this.label1);
            this.gbxKurumsal.Controls.Add(this.dtpIseGirisTarihi);
            this.gbxKurumsal.Location = new System.Drawing.Point(407, 60);
            this.gbxKurumsal.Name = "gbxKurumsal";
            this.gbxKurumsal.Size = new System.Drawing.Size(373, 358);
            this.gbxKurumsal.TabIndex = 3;
            this.gbxKurumsal.TabStop = false;
            this.gbxKurumsal.Text = "Kurumsal Bilgiler";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(140, 242);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(187, 28);
            this.cbxRol.TabIndex = 26;
            // 
            // cbxGorev
            // 
            this.cbxGorev.FormattingEnabled = true;
            this.cbxGorev.Location = new System.Drawing.Point(140, 208);
            this.cbxGorev.Name = "cbxGorev";
            this.cbxGorev.Size = new System.Drawing.Size(187, 28);
            this.cbxGorev.TabIndex = 25;
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Location = new System.Drawing.Point(140, 174);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(187, 28);
            this.cbxBolum.TabIndex = 24;
            // 
            // cbxDurum
            // 
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cbxDurum.Location = new System.Drawing.Point(140, 276);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(116, 28);
            this.cbxDurum.TabIndex = 20;
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
            this.tbxSifre.Size = new System.Drawing.Size(200, 26);
            this.tbxSifre.TabIndex = 13;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(101, 245);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 20);
            this.lblRol.TabIndex = 29;
            this.lblRol.Text = "Rol*";
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(77, 211);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(61, 20);
            this.lblGorev.TabIndex = 28;
            this.lblGorev.Text = "Görevi*";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(69, 177);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(69, 20);
            this.lblBolum.TabIndex = 27;
            this.lblBolum.Text = "Bölümü*";
            // 
            // lblOzelSaglik
            // 
            this.lblOzelSaglik.AutoSize = true;
            this.lblOzelSaglik.Location = new System.Drawing.Point(44, 148);
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
            this.cbxOzelSaglik.Location = new System.Drawing.Point(140, 140);
            this.cbxOzelSaglik.Name = "cbxOzelSaglik";
            this.cbxOzelSaglik.Size = new System.Drawing.Size(116, 28);
            this.cbxOzelSaglik.TabIndex = 22;
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(77, 279);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(63, 20);
            this.lbldurum.TabIndex = 21;
            this.lbldurum.Text = "Durum*";
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
            // gbxPersonelEkle
            // 
            this.gbxPersonelEkle.Controls.Add(this.dgwPersonelEkle);
            this.gbxPersonelEkle.Controls.Add(this.gbxFotoEkle);
            this.gbxPersonelEkle.Controls.Add(this.btnPersonelEkle);
            this.gbxPersonelEkle.Controls.Add(this.gbxKisisel);
            this.gbxPersonelEkle.Controls.Add(this.gbxKurumsal);
            this.gbxPersonelEkle.Controls.Add(this.lblMesaj);
            this.gbxPersonelEkle.Location = new System.Drawing.Point(12, 79);
            this.gbxPersonelEkle.Name = "gbxPersonelEkle";
            this.gbxPersonelEkle.Size = new System.Drawing.Size(1114, 799);
            this.gbxPersonelEkle.TabIndex = 4;
            this.gbxPersonelEkle.TabStop = false;
            this.gbxPersonelEkle.Text = "PERSONEL EKLE";
            // 
            // gbxFotoEkle
            // 
            this.gbxFotoEkle.Controls.Add(this.tbxDosyaAdi);
            this.gbxFotoEkle.Controls.Add(this.tbxDosyaYolu);
            this.gbxFotoEkle.Controls.Add(this.pbxPersonelFoto);
            this.gbxFotoEkle.Controls.Add(this.lblDosyaAdi);
            this.gbxFotoEkle.Controls.Add(this.btnFotoEkle);
            this.gbxFotoEkle.Controls.Add(this.lblDosyaYolu);
            this.gbxFotoEkle.Location = new System.Drawing.Point(805, 61);
            this.gbxFotoEkle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFotoEkle.Name = "gbxFotoEkle";
            this.gbxFotoEkle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFotoEkle.Size = new System.Drawing.Size(291, 406);
            this.gbxFotoEkle.TabIndex = 9;
            this.gbxFotoEkle.TabStop = false;
            this.gbxFotoEkle.Text = "Personel Fotoğraf";
            // 
            // tbxDosyaAdi
            // 
            this.tbxDosyaAdi.Location = new System.Drawing.Point(108, 321);
            this.tbxDosyaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDosyaAdi.Name = "tbxDosyaAdi";
            this.tbxDosyaAdi.ReadOnly = true;
            this.tbxDosyaAdi.Size = new System.Drawing.Size(152, 26);
            this.tbxDosyaAdi.TabIndex = 10;
            // 
            // tbxDosyaYolu
            // 
            this.tbxDosyaYolu.Location = new System.Drawing.Point(108, 285);
            this.tbxDosyaYolu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDosyaYolu.Name = "tbxDosyaYolu";
            this.tbxDosyaYolu.ReadOnly = true;
            this.tbxDosyaYolu.Size = new System.Drawing.Size(152, 26);
            this.tbxDosyaYolu.TabIndex = 9;
            // 
            // pbxPersonelFoto
            // 
            this.pbxPersonelFoto.Location = new System.Drawing.Point(59, 34);
            this.pbxPersonelFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPersonelFoto.Name = "pbxPersonelFoto";
            this.pbxPersonelFoto.Size = new System.Drawing.Size(178, 206);
            this.pbxPersonelFoto.TabIndex = 8;
            this.pbxPersonelFoto.TabStop = false;
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(21, 325);
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
            this.btnFotoEkle.Location = new System.Drawing.Point(132, 350);
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
            this.lblDosyaYolu.Location = new System.Drawing.Point(11, 290);
            this.lblDosyaYolu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(90, 20);
            this.lblDosyaYolu.TabIndex = 6;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPersonelEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonelEkle.Location = new System.Drawing.Point(653, 423);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(127, 44);
            this.btnPersonelEkle.TabIndex = 4;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(75, 435);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(573, 20);
            this.lblMesaj.TabIndex = 10;
            this.lblMesaj.Text = "Çalışanın sicil numarası kayıt işlemi tamamlandığında otomatik olarak verilecekti" +
    "r. ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgwPersonelEkle
            // 
            this.dgwPersonelEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelEkle.Location = new System.Drawing.Point(36, 479);
            this.dgwPersonelEkle.Name = "dgwPersonelEkle";
            this.dgwPersonelEkle.RowHeadersWidth = 62;
            this.dgwPersonelEkle.RowTemplate.Height = 28;
            this.dgwPersonelEkle.Size = new System.Drawing.Size(1059, 113);
            this.dgwPersonelEkle.TabIndex = 11;
            // 
            // PersonelEkleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1285, 1195);
            this.Controls.Add(this.gbxPersonelEkle);
            this.Name = "PersonelEkleUI";
            this.Text = "PersonelEkleUI";
            this.Load += new System.EventHandler(this.PersonelEkleUI_Load);
            this.gbxKisisel.ResumeLayout(false);
            this.gbxKisisel.PerformLayout();
            this.gbxKurumsal.ResumeLayout(false);
            this.gbxKurumsal.PerformLayout();
            this.gbxPersonelEkle.ResumeLayout(false);
            this.gbxPersonelEkle.PerformLayout();
            this.gbxFotoEkle.ResumeLayout(false);
            this.gbxFotoEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonelFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label lblOzelSaglik;
        private System.Windows.Forms.ComboBox cbxOzelSaglik;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
        private System.Windows.Forms.TextBox tbxMaas;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.ComboBox cbxGorev;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.GroupBox gbxPersonelEkle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnFotoEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.PictureBox pbxPersonelFoto;
        private System.Windows.Forms.GroupBox gbxFotoEkle;
        private System.Windows.Forms.TextBox tbxDosyaAdi;
        private System.Windows.Forms.TextBox tbxDosyaYolu;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.DataGridView dgwPersonelEkle;
    }
}