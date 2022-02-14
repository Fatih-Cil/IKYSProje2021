
namespace IKYS
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.MainMenu = new System.Windows.Forms.Panel();
            this.lblTarihGuncel = new System.Windows.Forms.Label();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmKurumsal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSirketBilgisi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBolumIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGorevTanimlari = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRoller = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelYonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDokumanYonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKurumsalDokuman = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumsalDokumanKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumsalDokümanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelDokuman = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDokümanKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDokümanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBordro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBordroOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBordroGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBolumRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonelRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHatirlatici = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogKontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAktifKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİştenÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeliSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenu.BackgroundImage")));
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenu.Controls.Add(this.lblTarihGuncel);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1284, 978);
            this.MainMenu.TabIndex = 0;
            // 
            // lblTarihGuncel
            // 
            this.lblTarihGuncel.AutoSize = true;
            this.lblTarihGuncel.Location = new System.Drawing.Point(1077, 903);
            this.lblTarihGuncel.Name = "lblTarihGuncel";
            this.lblTarihGuncel.Size = new System.Drawing.Size(44, 20);
            this.lblTarihGuncel.TabIndex = 0;
            this.lblTarihGuncel.Text = "Tarih";
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopMenu.Controls.Add(this.menuStrip1);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1284, 69);
            this.TopMenu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKurumsal,
            this.tsmPersonelYonetim,
            this.tsmDokumanYonetim,
            this.tsmBordro,
            this.tsmRaporlama,
            this.tsmHatirlatici,
            this.tsmLogKontrol,
            this.tsmAktifKullanici});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(48, 23, 0, 23);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 75);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmKurumsal
            // 
            this.tsmKurumsal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSirketBilgisi,
            this.tsmBolumIslemleri,
            this.tsmGorevTanimlari,
            this.tsmRoller});
            this.tsmKurumsal.Name = "tsmKurumsal";
            this.tsmKurumsal.Size = new System.Drawing.Size(119, 29);
            this.tsmKurumsal.Text = "KURUMSAL";
            // 
            // tsmSirketBilgisi
            // 
            this.tsmSirketBilgisi.Name = "tsmSirketBilgisi";
            this.tsmSirketBilgisi.Size = new System.Drawing.Size(235, 34);
            this.tsmSirketBilgisi.Text = "Şirket Bilgisi";
            this.tsmSirketBilgisi.Click += new System.EventHandler(this.tsmSirketBilgisi_Click);
            // 
            // tsmBolumIslemleri
            // 
            this.tsmBolumIslemleri.Name = "tsmBolumIslemleri";
            this.tsmBolumIslemleri.Size = new System.Drawing.Size(235, 34);
            this.tsmBolumIslemleri.Text = "Bolüm İşlemleri";
            this.tsmBolumIslemleri.Click += new System.EventHandler(this.tsmBolumIslemleri_Click);
            // 
            // tsmGorevTanimlari
            // 
            this.tsmGorevTanimlari.Name = "tsmGorevTanimlari";
            this.tsmGorevTanimlari.Size = new System.Drawing.Size(235, 34);
            this.tsmGorevTanimlari.Text = "Görev Tanımları";
            this.tsmGorevTanimlari.Click += new System.EventHandler(this.tsmGorevTanimlari_Click);
            // 
            // tsmRoller
            // 
            this.tsmRoller.Name = "tsmRoller";
            this.tsmRoller.Size = new System.Drawing.Size(235, 34);
            this.tsmRoller.Text = "Roller";
            this.tsmRoller.Click += new System.EventHandler(this.tsmRoller_Click);
            // 
            // tsmPersonelYonetim
            // 
            this.tsmPersonelYonetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonelEkle,
            this.tsmPersonelGoruntule,
            this.tsmPersonelGuncelle,
            this.personelİştenÇıkarToolStripMenuItem,
            this.personeliSilToolStripMenuItem});
            this.tsmPersonelYonetim.Name = "tsmPersonelYonetim";
            this.tsmPersonelYonetim.Size = new System.Drawing.Size(192, 29);
            this.tsmPersonelYonetim.Text = "PERSONEL YÖNETİM";
            // 
            // tsmPersonelEkle
            // 
            this.tsmPersonelEkle.Name = "tsmPersonelEkle";
            this.tsmPersonelEkle.Size = new System.Drawing.Size(270, 34);
            this.tsmPersonelEkle.Text = "Personel Ekle";
            this.tsmPersonelEkle.Click += new System.EventHandler(this.tsmPersonelEkle_Click);
            // 
            // tsmPersonelGoruntule
            // 
            this.tsmPersonelGoruntule.Name = "tsmPersonelGoruntule";
            this.tsmPersonelGoruntule.Size = new System.Drawing.Size(270, 34);
            this.tsmPersonelGoruntule.Text = "Personel Görüntüle";
            this.tsmPersonelGoruntule.Click += new System.EventHandler(this.tsmPersonelGoruntule_Click);
            // 
            // tsmPersonelGuncelle
            // 
            this.tsmPersonelGuncelle.Name = "tsmPersonelGuncelle";
            this.tsmPersonelGuncelle.Size = new System.Drawing.Size(270, 34);
            this.tsmPersonelGuncelle.Text = "Personel Güncelle";
            this.tsmPersonelGuncelle.Click += new System.EventHandler(this.tsmPersonelGuncelle_Click);
            // 
            // tsmDokumanYonetim
            // 
            this.tsmDokumanYonetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKurumsalDokuman,
            this.tsmPersonelDokuman});
            this.tsmDokumanYonetim.Name = "tsmDokumanYonetim";
            this.tsmDokumanYonetim.Size = new System.Drawing.Size(198, 29);
            this.tsmDokumanYonetim.Text = "DOKÜMAN YÖNETİM";
            // 
            // tsmKurumsalDokuman
            // 
            this.tsmKurumsalDokuman.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurumsalDokumanKategoriToolStripMenuItem,
            this.kurumsalDokümanİşlemleriToolStripMenuItem});
            this.tsmKurumsalDokuman.Name = "tsmKurumsalDokuman";
            this.tsmKurumsalDokuman.Size = new System.Drawing.Size(270, 34);
            this.tsmKurumsalDokuman.Text = "Kurumsal Döküman";
            // 
            // kurumsalDokumanKategoriToolStripMenuItem
            // 
            this.kurumsalDokumanKategoriToolStripMenuItem.Name = "kurumsalDokumanKategoriToolStripMenuItem";
            this.kurumsalDokumanKategoriToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.kurumsalDokumanKategoriToolStripMenuItem.Text = "Kurumsal Doküman Kategori";
            this.kurumsalDokumanKategoriToolStripMenuItem.Click += new System.EventHandler(this.kurumsalDokumanKategoriToolStripMenuItem_Click);
            // 
            // kurumsalDokümanİşlemleriToolStripMenuItem
            // 
            this.kurumsalDokümanİşlemleriToolStripMenuItem.Name = "kurumsalDokümanİşlemleriToolStripMenuItem";
            this.kurumsalDokümanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.kurumsalDokümanİşlemleriToolStripMenuItem.Text = "Kurumsal Doküman İşlemleri";
            this.kurumsalDokümanİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kurumsalDokümanİşlemleriToolStripMenuItem_Click);
            // 
            // tsmPersonelDokuman
            // 
            this.tsmPersonelDokuman.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDokümanKategoriToolStripMenuItem,
            this.personelDokümanİşlemleriToolStripMenuItem});
            this.tsmPersonelDokuman.Name = "tsmPersonelDokuman";
            this.tsmPersonelDokuman.Size = new System.Drawing.Size(270, 34);
            this.tsmPersonelDokuman.Text = "Personel Döküman";
            // 
            // personelDokümanKategoriToolStripMenuItem
            // 
            this.personelDokümanKategoriToolStripMenuItem.Name = "personelDokümanKategoriToolStripMenuItem";
            this.personelDokümanKategoriToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.personelDokümanKategoriToolStripMenuItem.Text = "Personel Doküman Kategori";
            this.personelDokümanKategoriToolStripMenuItem.Click += new System.EventHandler(this.personelDokümanKategoriToolStripMenuItem_Click);
            // 
            // personelDokümanİşlemleriToolStripMenuItem
            // 
            this.personelDokümanİşlemleriToolStripMenuItem.Name = "personelDokümanİşlemleriToolStripMenuItem";
            this.personelDokümanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.personelDokümanİşlemleriToolStripMenuItem.Text = "Personel Doküman İşlemleri";
            this.personelDokümanİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelDokümanİşlemleriToolStripMenuItem_Click);
            // 
            // tsmBordro
            // 
            this.tsmBordro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBordroOlustur,
            this.tsmBordroGoruntule});
            this.tsmBordro.Name = "tsmBordro";
            this.tsmBordro.Size = new System.Drawing.Size(101, 29);
            this.tsmBordro.Text = "BORDRO";
            // 
            // tsmBordroOlustur
            // 
            this.tsmBordroOlustur.Name = "tsmBordroOlustur";
            this.tsmBordroOlustur.Size = new System.Drawing.Size(252, 34);
            this.tsmBordroOlustur.Text = "Bordro Oluştur";
            this.tsmBordroOlustur.Click += new System.EventHandler(this.tsmBordroOlustur_Click);
            // 
            // tsmBordroGoruntule
            // 
            this.tsmBordroGoruntule.Name = "tsmBordroGoruntule";
            this.tsmBordroGoruntule.Size = new System.Drawing.Size(252, 34);
            this.tsmBordroGoruntule.Text = "Bordro Görüntüle";
            this.tsmBordroGoruntule.Click += new System.EventHandler(this.tsmBordroGoruntule_Click);
            // 
            // tsmRaporlama
            // 
            this.tsmRaporlama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBolumRaporlama,
            this.tsmPersonelRaporlama});
            this.tsmRaporlama.Name = "tsmRaporlama";
            this.tsmRaporlama.Size = new System.Drawing.Size(135, 29);
            this.tsmRaporlama.Text = "RAPORLAMA";
            // 
            // tsmBolumRaporlama
            // 
            this.tsmBolumRaporlama.Name = "tsmBolumRaporlama";
            this.tsmBolumRaporlama.Size = new System.Drawing.Size(271, 34);
            this.tsmBolumRaporlama.Text = "Bolum Raporlama";
            this.tsmBolumRaporlama.Click += new System.EventHandler(this.tsmBolumRaporlama_Click);
            // 
            // tsmPersonelRaporlama
            // 
            this.tsmPersonelRaporlama.Name = "tsmPersonelRaporlama";
            this.tsmPersonelRaporlama.Size = new System.Drawing.Size(271, 34);
            this.tsmPersonelRaporlama.Text = "Personel Raporlama";
            this.tsmPersonelRaporlama.Click += new System.EventHandler(this.tsmPersonelRaporlama_Click);
            // 
            // tsmHatirlatici
            // 
            this.tsmHatirlatici.Name = "tsmHatirlatici";
            this.tsmHatirlatici.Size = new System.Drawing.Size(127, 29);
            this.tsmHatirlatici.Text = "HATIRLATICI";
            this.tsmHatirlatici.Click += new System.EventHandler(this.tsmHatirlatici_Click);
            // 
            // tsmLogKontrol
            // 
            this.tsmLogKontrol.Name = "tsmLogKontrol";
            this.tsmLogKontrol.Size = new System.Drawing.Size(144, 29);
            this.tsmLogKontrol.Text = "LOG KONTROL";
            this.tsmLogKontrol.Click += new System.EventHandler(this.tsmLogKontrol_Click);
            // 
            // tsmAktifKullanici
            // 
            this.tsmAktifKullanici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCikis});
            this.tsmAktifKullanici.Name = "tsmAktifKullanici";
            this.tsmAktifKullanici.Size = new System.Drawing.Size(91, 29);
            this.tsmAktifKullanici.Text = "Kullanıcı";
            // 
            // tsmCikis
            // 
            this.tsmCikis.Name = "tsmCikis";
            this.tsmCikis.Size = new System.Drawing.Size(150, 34);
            this.tsmCikis.Text = "Çıkış";
            this.tsmCikis.Click += new System.EventHandler(this.tsmCikis_Click);
            // 
            // personelİştenÇıkarToolStripMenuItem
            // 
            this.personelİştenÇıkarToolStripMenuItem.Name = "personelİştenÇıkarToolStripMenuItem";
            this.personelİştenÇıkarToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.personelİştenÇıkarToolStripMenuItem.Text = "Personel Çıkış İşlemi";
            this.personelİştenÇıkarToolStripMenuItem.Click += new System.EventHandler(this.personelİştenÇıkarToolStripMenuItem_Click);
            // 
            // personeliSilToolStripMenuItem
            // 
            this.personeliSilToolStripMenuItem.Name = "personeliSilToolStripMenuItem";
            this.personeliSilToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.personeliSilToolStripMenuItem.Text = "Personel Sil";
            this.personeliSilToolStripMenuItem.Click += new System.EventHandler(this.personeliSilToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 978);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İNSAN KAYNAKLARI YÖNETİM SİSTEMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmKurumsal;
        private System.Windows.Forms.ToolStripMenuItem tsmSirketBilgisi;
        private System.Windows.Forms.ToolStripMenuItem tsmBolumIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmGorevTanimlari;
        private System.Windows.Forms.ToolStripMenuItem tsmRoller;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelYonetim;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelGoruntule;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelGuncelle;
        private System.Windows.Forms.ToolStripMenuItem tsmDokumanYonetim;
        private System.Windows.Forms.ToolStripMenuItem tsmKurumsalDokuman;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelDokuman;
        private System.Windows.Forms.ToolStripMenuItem tsmBordro;
        private System.Windows.Forms.ToolStripMenuItem tsmBordroOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmBordroGoruntule;
        private System.Windows.Forms.ToolStripMenuItem tsmRaporlama;
        private System.Windows.Forms.ToolStripMenuItem tsmBolumRaporlama;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonelRaporlama;
        private System.Windows.Forms.ToolStripMenuItem tsmHatirlatici;
        private System.Windows.Forms.ToolStripMenuItem tsmLogKontrol;
        private System.Windows.Forms.ToolStripMenuItem tsmAktifKullanici;
        private System.Windows.Forms.ToolStripMenuItem tsmCikis;
        private System.Windows.Forms.Label lblTarihGuncel;
        private System.Windows.Forms.ToolStripMenuItem kurumsalDokumanKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDokümanKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurumsalDokümanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDokümanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİştenÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeliSilToolStripMenuItem;
    }
}