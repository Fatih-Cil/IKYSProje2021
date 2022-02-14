using IKYS.Business;
using IKYS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYS
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public int AktifId { get; set; }
        public string AktifAd { get; set; }
        public int AktifRol { get; set; }
        
        public void TopMenuKisitla(int id)
        {
            //giriş yapan kullanıcının rollerine göre üst menude kısıtlamalar yapıyorum.
            if (id == 2)
            {
                
                tsmKurumsal.Visible = false;
                tsmPersonelEkle.Visible = false;
                tsmPersonelGuncelle.Visible = false;
                personelİştenÇıkarToolStripMenuItem.Visible = false;
                personeliSilToolStripMenuItem.Visible = false;
                kurumsalDokumanKategoriToolStripMenuItem.Visible = false;
                personelDokümanKategoriToolStripMenuItem.Visible = false;
                tsmBordroOlustur.Visible = false;
                tsmLogKontrol.Visible = false;
             }

        }

        private void Formgetir(Form form)
        {
            MainMenu.Controls.Clear(); //daha önce yüklenen form varsa diye temizliyorum
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainMenu.Controls.Add(form);

            form.Show();
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            TopMenuKisitla(AktifRol);
            tsmAktifKullanici.Text = "Hoşgeldin "+AktifAd;
            lblTarihGuncel.Text = DateTime.Now.ToLongDateString();
        }


        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmRoller_Click(object sender, EventArgs e)
        {
            RollerUI rollerUI = new RollerUI();
            Formgetir(rollerUI); //Getirilecek sayfa ana sayfa içinde açması için ilgili methoda yollanıyor.
        }

        private void tsmGorevTanimlari_Click(object sender, EventArgs e)
        {
            GorevUI gorevUI = new GorevUI();
            gorevUI.AktifKullaniciID = AktifId;
            gorevUI.AktifKullaniciAdi = AktifAd;
            Formgetir(gorevUI);
        }

        private void tsmBolumIslemleri_Click(object sender, EventArgs e)
        {
            BolumUI bolumUI = new BolumUI();
            bolumUI.AktifKullaniciID = AktifId;
            bolumUI.AktifKullaniciAdi = AktifAd;
            Formgetir(bolumUI);
        }

        private void tsmSirketBilgisi_Click(object sender, EventArgs e)
        {
            SirketUI sirketUI = new SirketUI();
            sirketUI.AktifKullaniciID = AktifId;
            sirketUI.AktifKullaniciAdi = AktifAd;
            Formgetir(sirketUI);
        }

        private void tsmLogKontrol_Click(object sender, EventArgs e)
        {
            LogYonetimUI logYonetimUI = new LogYonetimUI();
            Formgetir(logYonetimUI);
        }

        private void tsmPersonelGoruntule_Click(object sender, EventArgs e)
        {
            PersonelGoruntule personelGoruntuleUI = new PersonelGoruntule();
            personelGoruntuleUI.AktifKullaniciID = AktifId;
            personelGoruntuleUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelGoruntuleUI);

        }

        private void tsmPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkleUI personelEkleUI = new PersonelEkleUI();
            personelEkleUI.AktifKullaniciID = AktifId;
            personelEkleUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelEkleUI);
        }

        private void kurumsalDokumanKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KDKategoriUI kDKategori = new KDKategoriUI();
            kDKategori.AktifKullaniciID = AktifId;
            kDKategori.AktifKullaniciAdi = AktifAd;
            Formgetir(kDKategori);
        }

        private void personelDokümanKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDKategoriUI pDKategori = new PDKategoriUI();
            pDKategori.AktifKullaniciID = AktifId;
            pDKategori.AktifKullaniciAdi = AktifAd;
            Formgetir(pDKategori);
        }

        private void kurumsalDokümanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurumsalDokumanIslemleriUI kurumsalDokumanIslemleriUI = new KurumsalDokumanIslemleriUI();
            kurumsalDokumanIslemleriUI.AktifKullaniciID = AktifId;
            kurumsalDokumanIslemleriUI.AktifKullaniciAdi = AktifAd;
            Formgetir(kurumsalDokumanIslemleriUI);
        }

        private void personelDokümanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelDokumanIslemleriUI personelDokuman = new PersonelDokumanIslemleriUI();
            personelDokuman.AktifKullaniciID = AktifId;
            personelDokuman.AktifKullaniciAdi = AktifAd;
            Formgetir(personelDokuman);
        }

        private void tsmBolumRaporlama_Click(object sender, EventArgs e)
        {
            BolumRaporlamaUI bolumRaporlamaUI = new BolumRaporlamaUI();
            bolumRaporlamaUI.AktifKullaniciID = AktifId;
            bolumRaporlamaUI.AktifKullaniciAdi = AktifAd;
            Formgetir(bolumRaporlamaUI);
        }

        private void tsmPersonelRaporlama_Click(object sender, EventArgs e)
        {
            PersonelRaporlamaUI personelRaporlamaUI = new PersonelRaporlamaUI();
            personelRaporlamaUI.AktifKullaniciID = AktifId;
            personelRaporlamaUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelRaporlamaUI);
        }

        private void tsmHatirlatici_Click(object sender, EventArgs e)
        {
            HatirlaticiUI hatirlaticiUI = new HatirlaticiUI();
            hatirlaticiUI.AktifKullaniciID = AktifId;
            hatirlaticiUI.AktifKullaniciAdi = AktifAd;
            Formgetir(hatirlaticiUI);
        }

        private void tsmBordroOlustur_Click(object sender, EventArgs e)
        {
            BordroOlusturUI bordroOlusturUI = new BordroOlusturUI();
            bordroOlusturUI.AktifKullaniciID = AktifId;
            bordroOlusturUI.AktifKullaniciAdi = AktifAd;
            Formgetir(bordroOlusturUI);

        }

        private void tsmBordroGoruntule_Click(object sender, EventArgs e)
        {
            BordroGoruntuleUI bordroGoruntuleUI = new BordroGoruntuleUI();
            bordroGoruntuleUI.AktifKullaniciID = AktifId;
            bordroGoruntuleUI.AktifKullaniciAdi = AktifAd;
            Formgetir(bordroGoruntuleUI);
        }

        private void tsmPersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelleUI personelGuncelleUI = new PersonelGuncelleUI();
            personelGuncelleUI.AktifKullaniciID = AktifId;
            personelGuncelleUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelGuncelleUI);
        }

        private void personeliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSilUI personelSilUI = new PersonelSilUI();
            personelSilUI.AktifKullaniciID = AktifId;
            personelSilUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelSilUI);
        }

        private void personelİştenÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelCikarUI personelCikarUI = new PersonelCikarUI();
            personelCikarUI.AktifKullaniciID = AktifId;
            personelCikarUI.AktifKullaniciAdi = AktifAd;
            Formgetir(personelCikarUI);
        }
    }
}
