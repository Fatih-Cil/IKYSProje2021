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
    public partial class BordroOlusturUI : Form
    {
        public BordroOlusturUI()
        {
            InitializeComponent();
        }
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        public int PersonelID = 0;
        public int BordroID = 0;

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwBordroSil.CurrentRow.Cells[i].Value == null || dgwBordroSil.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwBordroSil.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void tbxHIEkMesaiSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // sadece rakam girilmesi sağlanıyor. nokta bir digit ifade olduğu için burada onuda engelliyoruz.
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbxSicilNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwBordroEkle.DataSource = "";
            dgwBordroSil.DataSource = "";
            gbxBordroSil.Visible = false;

            try
            {

                PersonelDal personelDal = new PersonelDal();

                foreach (var item in personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNo.SelectedValue), "AKTİF"))
                {
                    gbxPersonelBilgileri.Visible = true;
                    tbxCalistigiGun.Text = "30";
                    tbxToplamUcret.Text = "";
                    tbxHIEkMesaiSaati.Text = "0";
                    tbxHSEkMesaiSaati.Text = "0";
                    tbxPrim.Text = "0";
                    tbxMaas.Text = item.Maas.ToString();
                    tbxSaatUcreti.Text = Convert.ToDecimal(item.Maas / 225).ToString();
                    //2 haneli olarak sayıyı yukarı yuvarlıyorum.
                    tbxSaatUcreti.Text = Math.Round(decimal.Parse(tbxSaatUcreti.Text), 2).ToString();
                    PersonelID = item.PersonelId;
                    lblGsicilno.Text = item.SicilNo.ToString();
                    lblgelentc.Text = item.TcNo;
                    lblgelenadsoyad.Text = item.Ad + " " + item.Soyad;
                    lblgelengiristarih.Text = item.IseGiris.ToShortDateString();
                    //lblSirketAdi.Text=lblSirketAdi.Text+":"+
                }

            }
            catch
            {

            }


        }

        private void BordroOlusturUI_Load(object sender, EventArgs e)
        {  //aynı tarihli bordro oluşturulmak istendiğinde gözükecek olan grupbox başlangıçta görünmez yapılıyor. 
            gbxBordroSil.Visible = false;

            //sayfa yüklendiğinde personel bilgileri alanı temizleniyor.
            lblGsicilno.Text = "";
            lblgelentc.Text = "";
            lblgelenadsoyad.Text = "";
            lblgelengiristarih.Text = "";
            tbxCalistigiGun.Text = "30";
            tbxHIEkMesaiSaati.Text = "0";
            tbxHSEkMesaiSaati.Text = "0";
            tbxPrim.Text = "0";

            //sicil numarası combobox aktif kullanıcılar listeliniyor.
            PersonelDal personelDal = new PersonelDal();
            cbxSicilNo.DataSource = personelDal.TumunuListele("AKTİF");
            cbxSicilNo.DisplayMember = "SicilNo";
            cbxSicilNo.ValueMember = "SicilNo";
            
        }

        private void tbxHSEkMesaiSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // ondalıklı değer girilmesi için 1 adet virgule onay veriyorum.
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxCalistigiGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // ondalıklı değer girilmesi için 1 adet virgule onay veriyorum.
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(tbxCalistigiGun.Text) > 30)
            {
                MessageBox.Show("Çalışılan süre maksimum 30 gün girilmesi gerekir.");
                tbxCalistigiGun.Text = "30";
            }
            else
            {
                decimal calistigiGun = 0;
                decimal hiem = 0;
                decimal hsem = 0;
                decimal pirim = 0;

                tbxMaas.Text = (tbxMaas.Text == "") ? tbxMaas.Text = "0" : tbxMaas.Text = tbxMaas.Text;
                tbxSaatUcreti.Text = (tbxSaatUcreti.Text == "") ? tbxSaatUcreti.Text = "0" : tbxSaatUcreti.Text = tbxSaatUcreti.Text;
                calistigiGun = (tbxCalistigiGun.Text == "" || tbxCalistigiGun.Text == null) ? calistigiGun = 0 : calistigiGun = Convert.ToDecimal(tbxCalistigiGun.Text);
                decimal ayliknetucret = (calistigiGun == 30) ? ayliknetucret = Convert.ToDecimal(tbxMaas.Text) : ayliknetucret = calistigiGun * (Convert.ToDecimal(tbxMaas.Text) / 30);

                hiem = (tbxHIEkMesaiSaati.Text == "") ? hiem = 0 : hiem = Convert.ToDecimal(tbxHIEkMesaiSaati.Text);
                hsem = (tbxHSEkMesaiSaati.Text == "") ? hsem = 0 : hsem = Convert.ToDecimal(tbxHSEkMesaiSaati.Text);
                pirim = (tbxPrim.Text == "") ? pirim = 0 : pirim = Convert.ToDecimal(tbxPrim.Text);
                
                decimal toplamucret = (ayliknetucret) + (hiem * (Convert.ToDecimal(tbxSaatUcreti.Text) * 3 / 2) + (hsem * (Convert.ToDecimal(tbxSaatUcreti.Text) * 2)) + pirim);

                tbxToplamUcret.Text = (Math.Ceiling((decimal)toplamucret * 100) / 100).ToString();

            }





        }

        private void tbxPrim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // ondalıklı değer girilmesi için 1 adet virgule onay veriyorum.
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnBordroKayit_Click(object sender, EventArgs e)
        {
            if (lblGsicilno.Text == "" || tbxToplamUcret.Text == "")
            {
                MessageBox.Show("Lütfen sicil numarası seçin ve hesapla botona basın.");
            }
            else
            {
                BordroDal bordroDal = new BordroDal();
                var kayit=bordroDal.BordroKontrol(PersonelID, dtpBordroTarih.Value.Date.Month.ToString(), dtpBordroTarih.Value.Date.Year.ToString());
                if (kayit.Count>0)
                {
                    MessageBox.Show(lblgelenadsoyad.Text+ " adına "+ dtpBordroTarih.Value.Date.Year.ToString() + " yılı "+ dtpBordroTarih.Value.Date.Month.ToString() +". ay için daha önce bir bordro oluşturulmuş. Yeni bordro oluşturmak için bu kaydı öncelikle silmeniz gerekiyor.");
                    gbxBordroSil.Visible = true;
                    dgwBordroSil.DataSource = kayit;
                    for (int i = 0; i < dgwBordroSil.ColumnCount; i++)
                    {
                        dgwBordroSil.Columns[i].Visible = false;
                    }
                    dgwBordroSil.Columns["BordroId"].Visible = true; dgwBordroSil.Columns["BordroId"].HeaderText = "Bordro ID";
                    dgwBordroSil.Columns["Tarih"].Visible = true; dgwBordroSil.Columns["Tarih"].HeaderText = "Bordro Tarihi";
                    dgwBordroSil.Columns["HiMesai"].Visible = true; dgwBordroSil.Columns["HiMesai"].HeaderText = "Hafta İçi Ek Mesai Saati";
                    dgwBordroSil.Columns["HsMesai"].Visible = true; dgwBordroSil.Columns["HsMesai"].HeaderText = "Hafta Sonu Ek Mesai Saati";
                    dgwBordroSil.Columns["Prim"].Visible = true; dgwBordroSil.Columns["Prim"].HeaderText = "Ek Prim";
                    dgwBordroSil.Columns["Ucret"].Visible = true; dgwBordroSil.Columns["Ucret"].HeaderText = "Toplam Ücret";

                }
                else
                {
                   

                    Bordro bordro = new Bordro();

                    bordro.PersonelId = PersonelID;
                    bordro.Tarih = dtpBordroTarih.Value.Date;
                    bordro.HiMesai = Convert.ToDouble(tbxHIEkMesaiSaati.Text);
                    bordro.HsMesai = Convert.ToDouble(tbxHSEkMesaiSaati.Text);
                    bordro.Prim = Convert.ToDouble(tbxPrim.Text);
                    bordro.SaatUcret = Convert.ToDouble(tbxSaatUcreti.Text);
                    bordro.CalistigiGun = Convert.ToDouble(tbxCalistigiGun.Text);
                    bordro.Ucret = Convert.ToDouble(tbxToplamUcret.Text);


                    bordroDal.BordroEkle(bordro);

                    MessageBox.Show(lblgelenadsoyad.Text + " adına " + dtpBordroTarih.Value.Date.Month.ToString() + ". ay için yeni bordro kayıt edildi.");

                   dgwBordroEkle.DataSource= bordroDal.BordroKontrol(PersonelID, dtpBordroTarih.Value.Date.Month.ToString(), dtpBordroTarih.Value.Date.Year.ToString());
                    for (int i = 0; i < dgwBordroEkle.ColumnCount; i++)
                    {
                        dgwBordroEkle.Columns[i].Visible = false;
                    }
                    dgwBordroEkle.Columns["BordroId"].Visible = true; dgwBordroEkle.Columns["BordroId"].HeaderText = "Bordro ID";
                    dgwBordroEkle.Columns["Tarih"].Visible = true; dgwBordroEkle.Columns["Tarih"].HeaderText = "Bordro Tarihi";
                    dgwBordroEkle.Columns["HiMesai"].Visible = true; dgwBordroEkle.Columns["HiMesai"].HeaderText = "Hafta İçi Ek Mesai Saati";
                    dgwBordroEkle.Columns["HsMesai"].Visible = true; dgwBordroEkle.Columns["HsMesai"].HeaderText = "Hafta Sonu Ek Mesai Saati";
                    dgwBordroEkle.Columns["Prim"].Visible = true; dgwBordroEkle.Columns["Prim"].HeaderText = "Ek Prim";
                    dgwBordroEkle.Columns["Ucret"].Visible = true; dgwBordroEkle.Columns["Ucret"].HeaderText = "Toplam Ücret";

                    tbxCalistigiGun.Text = "30"; tbxHIEkMesaiSaati.Text = "0";tbxHSEkMesaiSaati.Text = "0";tbxPrim.Text = "0"; tbxToplamUcret.Text = "";
                    lblGsicilno.Text = ""; lblgelenadsoyad.Text = ""; lblgelentc.Text = "";lblgelengiristarih.Text = ""; tbxMaas.Text = "";tbxSaatUcreti.Text = "";

                    //ilgili işlem için log yolluyorum.
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "BORDRO YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);

                    
                }



            }
        }

       

        private void btnBordroSil_Click(object sender, EventArgs e)
        {
            if (BordroID == 0)
            {
                MessageBox.Show("Silmek istediğiniz bordroyu tablodan seçiniz.");
            }
            else
            {

                try
                {
                    BordroDal bordrosil = new BordroDal();
                    bordrosil.Sil(BordroID);
                    MessageBox.Show("Seçilen Bordro silindi.");
                    gbxBordroSil.Visible = false;
                    dgwBordroSil.DataSource = "";

                    tbxBordroID.Text = ""; tbxBordroTarihi.Text = "";
                    BordroID = 0;

                    LogDal logDal = new LogDal();
                    logDal.LogGonder("SİLME", "BORDRO YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    

                }
                catch
                {

                }
            }  
        }

        private void dgwBordroSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BordroID = Convert.ToInt32(dgwBordroSil.CurrentRow.Cells[0].Value.ToString());
            tbxBordroID.Text = (SutunBosmu(0) == 0 ? "" : dgwBordroSil.CurrentRow.Cells[0].Value.ToString());
            tbxBordroTarihi.Text = (SutunBosmu(1) == 0 ? "" : dgwBordroSil.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
