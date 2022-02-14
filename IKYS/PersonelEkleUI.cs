using IKYS.Business;
using IKYS.DataAccess;
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

namespace IKYS
{
    public partial class PersonelEkleUI : Form
    {
        public PersonelEkleUI()
        {
            InitializeComponent();
        }
        internal int BolumID = 0;
        internal int GorevID = 0;
        internal int RolID = 0;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        internal string hedefKlasor= "C:\\Doküman Yönetimi\\Personel Doküman\\VESİKALIK";
        private void PersonelEkleUI_Load(object sender, EventArgs e)
        {

            BolumDal bolumDal = new BolumDal();
            cbxBolum.DataSource = bolumDal.TumunuListele();
            cbxBolum.DisplayMember = "BolumAdi";
            cbxBolum.ValueMember = "BolumId";

            GorevDal gorevDal = new GorevDal();
            cbxGorev.DataSource = gorevDal.TumunuListele();
            cbxGorev.DisplayMember = "GorevAdi";
            cbxGorev.ValueMember = "GorevId";

            RolDal rolDal = new RolDal();
            cbxRol.DataSource = rolDal.TumunuListele();
            cbxRol.DisplayMember = "RolAdi";
            cbxRol.ValueMember = "RolId";


        }

        private void tbxTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sadece rakam girilmesi sağlanıyor. nokta bir digit ifade olduğu için burada onuda engelliyoruz.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void tbxMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sadece rakam girilmesi sağlanıyor. nokta bir digit ifade olduğu için burada onuda engelliyoruz.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void tbxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sadece rakam girilmesi sağlanıyor. nokta bir digit ifade olduğu için burada onuda engelliyoruz.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            
            if (tbxTcNo.Text == "" || tbxAd.Text == "" || tbxSoyad.Text == "" || tbxSifre.Text == "" || tbxMaas.Text == "" || cbxDurum.Text == "" || cbxBolum.Text == "" || cbxGorev.Text == "" || cbxRol.Text == "")
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                List<Personel> bul = personelDal.PersonelTcNoAra(tbxTcNo.Text);
                if (bul.Count > 0)
                {
                    MessageBox.Show("Kayıt yapılamadı. Bu TC No ile bir personel var!");
                }
                else
                {


                    Personel personelGetir = personelDal.SonPersonel();
                    int SonSicilNo = personelGetir.SicilNo;

                    Personel personelyeni = new Personel();
                    personelyeni.SicilNo = SonSicilNo + 1;
                    personelyeni.TcNo = tbxTcNo.Text;
                    personelyeni.Ad = tbxAd.Text.ToUpper();
                    personelyeni.Soyad = tbxSoyad.Text.ToUpper();
                    personelyeni.DogumTarihi = dtpDogumTarihi.Value.Date;
                    personelyeni.Cep = tbxCep.Text;
                    personelyeni.Eposta = tbxEposta.Text.ToLower();
                    personelyeni.Adres = tbxAdres.Text.ToUpper();
                    //şifreyi md5 olarak hashliyorum.
                    MD5Sifreleme mD5Sifreleme = new MD5Sifreleme();
                    string md5liSifre = mD5Sifreleme.MD5Sifrele(tbxSifre.Text);
                    personelyeni.Sifre = md5liSifre;
                    personelyeni.YillikIzin = 0;
                    personelyeni.Maas = Convert.ToDouble(tbxMaas.Text);
                    personelyeni.OzelSaglik = cbxOzelSaglik.Text;
                    personelyeni.KanGrubu = cbxKangrubu.Text;
                    personelyeni.IseGiris = dtpIseGirisTarihi.Value.Date;
                    personelyeni.Durum = cbxDurum.Text;
                    personelyeni.BolumId = Convert.ToInt32(cbxBolum.SelectedValue);
                    personelyeni.GorevId = Convert.ToInt32(cbxGorev.SelectedValue);
                    personelyeni.RolId = Convert.ToInt32(cbxRol.SelectedValue);
                    personelDal.PersonelEkle(personelyeni);

                    string kaynakDosyaYolu = tbxDosyaYolu.Text;
                    string dosyaAdi = tbxDosyaAdi.Text;
                    string dosyaUzantisi = Path.GetExtension(kaynakDosyaYolu);//uzantıyı alıyorum.
                    try
                    {
                        // kaynakdosyayolu seçilen belgenin yoludur, hedef klasor ana dizini gösteriyor. son sicil noya 1 ekleyip bu isimde vesikalık fotonun adını değiştiriyor ve hedef klasöre kopyalıyor.
                        File.Copy(kaynakDosyaYolu, Path.Combine((hedefKlasor), (SonSicilNo + 1).ToString() + dosyaUzantisi));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                   

                    //datagrid içine eklenen yeni personel listeleniyor.
                    dgwPersonelEkle.DataSource = personelDal.SicilNoAra(personelyeni.SicilNo);
                   

                    MessageBox.Show(personelyeni.SicilNo + " sicil numarası ile yeni kişi eklendi.");

                    //LOG YOLLAMAK İÇİN METHOD ÇAĞIRIYORUM.
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "PERSONEL YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);

                    
                    tbxTcNo.Text = "";tbxAd.Text = ""; tbxSoyad.Text = "";tbxCep.Text = "";tbxEposta.Text = "";tbxAdres.Text = "";tbxSifre.Text = "";tbxMaas.Text = "";tbxDosyaAdi.Text = "";tbxDosyaYolu.Text = "";
                    cbxKangrubu.Text = "";cbxOzelSaglik.Text = "";cbxDurum.Text = ""; pbxPersonelFoto.Visible = false;

                    BolumID = 0;
                    GorevID = 0;
                    RolID = 0;

                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox tbox = (TextBox)item;
                            tbox.Clear();
                        }
                    }
                }


            }

        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "JPG Dosyası |*.jpg |JPEG Dosyası|*.jpeg |PNG Dosyası |*.png";
            file.FilterIndex = 3;
            file.RestoreDirectory = true; //son açılan pencere tekrar açılması için 
            file.CheckFileExists = false; //dosya adı varmı kontrol yapıyor
            file.Title = "Resim Dosyası Seçiniz";
            file.ShowDialog();
            if (file.ShowDialog()==DialogResult.OK)
            {
                tbxDosyaYolu.Text = file.FileName;
                tbxDosyaAdi.Text = file.SafeFileName;
                pbxPersonelFoto.Visible = true;
                pbxPersonelFoto.ImageLocation = tbxDosyaYolu.Text;
                pbxPersonelFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                
                file.Reset();
            }
             
        }
    }
}
