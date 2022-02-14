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
    public partial class BordroGoruntuleUI : Form
    {
        public BordroGoruntuleUI()
        {
            InitializeComponent();
        }

        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        private void BordroGoruntuleUI_Load(object sender, EventArgs e)
        {
            gbxBordroYazdir.Visible = false;
            PersonelDal personelDal = new PersonelDal();
            cbxSicilNoAra.DataSource = personelDal.TumunuListele("AKTİF");
            cbxSicilNoAra.DisplayMember = "SicilNo";
            cbxSicilNoAra.ValueMember = "PersonelId";

        }

        private void btnSicileGoreTumKayitlar_Click(object sender, EventArgs e)
        {
            gbxBordroYazdir.Visible = false;

            BordroDal bordroDal = new BordroDal();
            dgwBordroGoruntule.DataSource = bordroDal.TumunuListele(Convert.ToInt32(cbxSicilNoAra.SelectedValue), dtpBordroTarihi.Value.Month.ToString(), dtpBordroTarihi.Value.Year.ToString());
            for (int i = 0; i < dgwBordroGoruntule.ColumnCount; i++)
            {
                dgwBordroGoruntule.Columns[i].Visible = false;
            }
            dgwBordroGoruntule.Columns["BordroId"].Visible = true; dgwBordroGoruntule.Columns["BordroId"].HeaderText = "Bordro ID";
            dgwBordroGoruntule.Columns["Tarih"].Visible = true; dgwBordroGoruntule.Columns["Tarih"].HeaderText = "Bordro Tarihi";
            dgwBordroGoruntule.Columns["HiMesai"].Visible = true; dgwBordroGoruntule.Columns["HiMesai"].HeaderText = "Hafta İçi Ek Mesai Saati";
            dgwBordroGoruntule.Columns["HsMesai"].Visible = true; dgwBordroGoruntule.Columns["HsMesai"].HeaderText = "Hafta Sonu Ek Mesai Saati";
            dgwBordroGoruntule.Columns["Prim"].Visible = true; dgwBordroGoruntule.Columns["Prim"].HeaderText = "Ek Prim";
            dgwBordroGoruntule.Columns["Ucret"].Visible = true; dgwBordroGoruntule.Columns["Ucret"].HeaderText = "Toplam Ücret";

        }

        private void btnTariheGoreAra_Click(object sender, EventArgs e)
        {
            gbxBordroYazdir.Visible = false;
            BordroDal bordroDal = new BordroDal();
            dgwBordroGoruntule.DataSource = bordroDal.TumunuListele(dtptumkayittarih.Value.Month.ToString(), dtptumkayittarih.Value.Year.ToString());
            for (int i = 0; i < dgwBordroGoruntule.ColumnCount; i++)
            {
                dgwBordroGoruntule.Columns[i].Visible = false;
            }
            dgwBordroGoruntule.Columns["BordroId"].Visible = true; dgwBordroGoruntule.Columns["BordroId"].HeaderText = "Bordro ID";
            dgwBordroGoruntule.Columns["Tarih"].Visible = true; dgwBordroGoruntule.Columns["Tarih"].HeaderText = "Bordro Tarihi";
            dgwBordroGoruntule.Columns["HiMesai"].Visible = true; dgwBordroGoruntule.Columns["HiMesai"].HeaderText = "Hafta İçi Ek Mesai Saati";
            dgwBordroGoruntule.Columns["HsMesai"].Visible = true; dgwBordroGoruntule.Columns["HsMesai"].HeaderText = "Hafta Sonu Ek Mesai Saati";
            dgwBordroGoruntule.Columns["Prim"].Visible = true; dgwBordroGoruntule.Columns["Prim"].HeaderText = "Ek Prim";
            dgwBordroGoruntule.Columns["Ucret"].Visible = true; dgwBordroGoruntule.Columns["Ucret"].HeaderText = "Toplam Ücret";

        }

        private void dgwBordroGoruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxBordroYazdir.Visible = false;
            gbxBordroYazdir.Visible = true;
            
            int PersonelID = Convert.ToInt32(dgwBordroGoruntule.CurrentRow.Cells[8].Value.ToString());


            PersonelDal personelDal = new PersonelDal();
            Personel calisan= personelDal.PersonelAra(PersonelID);
           
            BolumDal bolumDal = new BolumDal();
            Bolum bolum= bolumDal.BolumAdiGetir(calisan.BolumId);
            lblBolum.Text ="Bölüm: " + bolum.BolumAdi;

            SirketDal sirketDal = new SirketDal();
            lblSirketAdi.Text="İşyeri Ünvanı: "+sirketDal.SirketAdiGetir(bolum.SirketId);

            GorevDal gorevDal = new GorevDal();
            Gorev gorev= gorevDal.GorevAdiGetir(calisan.GorevId);
            lblGorev.Text = "Görevi: "+gorev.GorevAdi;

            lblSicilNo.Text = "Sicil No: "+calisan.SicilNo.ToString();
            lblAdSoyad.Text = "Adı Soyadı: "+calisan.Ad + " " + calisan.Soyad;
            lblTCNo.Text = "T.C.Kimlik No: "+calisan.TcNo;
            lblIseGirisTarihi.Text = "İşe Giriş Tarihi: "+calisan.IseGiris.ToShortDateString();
            lblMaas.Text = "Maaş: "+calisan.Maas.ToString()+" TL";

            lblCalistigiGun.Text ="Çalıştığı Gün Sayısı: "+ dgwBordroGoruntule.CurrentRow.Cells[6].Value.ToString();

            lblhiems.Text= "H.İ. Ek Mesai Saati: "+dgwBordroGoruntule.CurrentRow.Cells[2].Value.ToString();
            lblhsems.Text= "H.S. Ek Mesai Saati: "+ dgwBordroGoruntule.CurrentRow.Cells[3].Value.ToString();
            lblPirimUcreti .Text="Pirim Ücreti: "+ dgwBordroGoruntule.CurrentRow.Cells[4].Value.ToString()+" TL";
            DateTime gelentarih = Convert.ToDateTime(dgwBordroGoruntule.CurrentRow.Cells[1].Value.ToString());
            lblYilAy.Text = "Yıl/Ay: "+gelentarih.Date.Year + "/" + gelentarih.Date.Month;
            decimal saatucreti=Convert.ToDecimal(dgwBordroGoruntule.CurrentRow.Cells[5].Value.ToString());

            lblhiemu.Text ="H.İ. Ek Mesai Ücreti: "+ ((saatucreti * 3 / 2) * (Convert.ToDecimal(dgwBordroGoruntule.CurrentRow.Cells[2].Value))).ToString()+" TL";
            lblhsemu.Text = "H.S. Ek Mesai Ücreti: "+((saatucreti * 2) * (Convert.ToDecimal(dgwBordroGoruntule.CurrentRow.Cells[3].Value))).ToString()+" TL";

            lblToplamUcret.Text = "Toplam Ödenecek Ücret: "+ dgwBordroGoruntule.CurrentRow.Cells[7].Value.ToString() +" TL";

        }
        Font Baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font Govde = new Font("Verdana",12);
        SolidBrush SolidBrush = new SolidBrush(Color.Black);
        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;

            e.Graphics.DrawString("ÜCRET BORDROSU",Baslik,SolidBrush,350,50);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", Govde, SolidBrush, 70, 70);
            e.Graphics.DrawString(lblSirketAdi.Text, Govde, SolidBrush, 80, 90);e.Graphics.DrawString(lblYilAy.Text, Govde, SolidBrush, 620, 90);

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", Govde, SolidBrush, 70, 110);
            e.Graphics.DrawString(lblSicilNo.Text, Govde,SolidBrush, 80, 140); e.Graphics.DrawString(lblIseGirisTarihi.Text, Govde, SolidBrush, 520, 140);
            e.Graphics.DrawString(lblTCNo.Text, Govde, SolidBrush, 80, 200);
            e.Graphics.DrawString(lblAdSoyad.Text, Govde, SolidBrush, 80, 230);
            e.Graphics.DrawString(lblBolum.Text, Govde, SolidBrush, 80, 260); 
            e.Graphics.DrawString(lblGorev.Text, Govde, SolidBrush, 80, 290);
            
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", Govde, SolidBrush, 70, 320);
            e.Graphics.DrawString(lblCalistigiGun.Text, Govde, SolidBrush, 80, 350);e.Graphics.DrawString(lblMaas.Text, Govde, SolidBrush, 400, 350);
            e.Graphics.DrawString(lblhiems.Text, Govde, SolidBrush, 80, 380); e.Graphics.DrawString(lblhiemu.Text, Govde, SolidBrush, 400,380);
            e.Graphics.DrawString(lblhsems.Text, Govde, SolidBrush, 80, 410); e.Graphics.DrawString(lblhsemu.Text, Govde, SolidBrush, 400,410);
            e.Graphics.DrawString(lblPirimUcreti.Text, Govde, SolidBrush, 400, 440);

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", Govde, SolidBrush, 70, 470);
            e.Graphics.DrawString(lblToplamUcret.Text, Baslik, SolidBrush, 420, 500);

            e.Graphics.DrawString("İşveren Vekili Adı Soyadı / İmza", Govde, SolidBrush, 100, 750);e.Graphics.DrawString("İşçi Adı Soyadı / İmza", Govde, SolidBrush, 485, 750);
            e.Graphics.DrawString("--------------------------------------", Govde, SolidBrush, 100, 780); e.Graphics.DrawString("---------------------------", Govde, SolidBrush, 485, 780);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ppdDiyalog.ShowDialog();
        }
    }
}
