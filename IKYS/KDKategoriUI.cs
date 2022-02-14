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
    public partial class KDKategoriUI : Form
    {
        public KDKategoriUI()
        {
            InitializeComponent();
        }
        internal int KDKategoriID = 0;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        public void TabloDoldur()
        {

            KDKategoriDal kDKategoriDal = new KDKategoriDal();
            dgwKDKategori.DataSource = kDKategoriDal.TumunuListele();
            dgwKDKategori.Columns["KDKAdi"].HeaderText = "Kurumsal Doküman Kadtegori Adı";
            dgwKDKategori.Columns["KDKId"].Visible = false;
            dgwKDKategori.Columns["KurumsalDokuman"].Visible = false;
            
        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwKDKategori.CurrentRow.Cells[i].Value == null || dgwKDKategori.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwKDKategori.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;

            }

        }
        private void KDKategoriUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (tbxKategoriAdi.Text == "")
            {
                MessageBox.Show("Kategori adı boş geçilemez.");
            }

            else
            {
                KDKategoriDal kDKategoriDal = new KDKategoriDal();
                List<KDKategori> bul = kDKategoriDal.Ara(tbxKategoriAdi.Text.ToUpper());
                if (bul.Count > 0)
                {
                    MessageBox.Show("Bu isimde bir kategori var!");
                }
                else
                {

                    KDKategori kDKategori = new KDKategori();
                    kDKategori.KDKAdi = tbxKategoriAdi.Text.ToUpper();
                    kDKategoriDal.Ekle(kDKategori);
                    
                    //kategori eklenince doküman yönetiminde belirttiğim yerde o isimde klasöor oluşuyor.
                    string klasor = tbxKategoriAdi.Text.ToUpper();
                    Directory.CreateDirectory("C:\\Doküman Yönetimi\\Kurumsal Doküman\\" + klasor);
                    MessageBox.Show(tbxKategoriAdi.Text + " isminde yeni kategori eklendi.");
                    
                    
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "KD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    TabloDoldur();
                    tbxKategoriAdi.Text = "";
                    
                }
   
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (KDKategoriID == 0)
            {
                MessageBox.Show("Güncellemek istediğiniz kategoriyi tabloda seçiniz.");
            }
            else
            {

                try
                {

                   
                    string guncelkategoriAdi = tbxKategoriAdi.Text.ToUpper();
                    KDKategoriDal kDKategoriDal = new KDKategoriDal();

                    //eski kategori adı sistemden aranıp getiriliyor
                    var eskikategori = kDKategoriDal.KategoriAra(KDKategoriID);
                    string eskiKategoriAdi = eskikategori.KDKAdi;
                    string kaynakklasor = "C:\\Doküman Yönetimi\\Kurumsal Doküman\\" + eskiKategoriAdi;
                    //DİZİNİN BOŞ OLUP OLMADIĞINI KONTROL EDİYORUM. DİZİN BOŞ İSE KAYNAK KLASÖRÜ SİLİYORUM.
                    Directory.Delete(kaynakklasor, false);
                    //kategori yeni adı db de güncelleniyor
                    kDKategoriDal.Guncelle(KDKategoriID, guncelkategoriAdi);

                    Directory.CreateDirectory("C:\\Doküman Yönetimi\\Kurumsal Doküman\\" + guncelkategoriAdi);
                   
                    MessageBox.Show(eskiKategoriAdi + " kategori adi " + tbxKategoriAdi.Text.ToUpper() + " kategori adı ile değişti. ");

                    //LOG YOLLAMAK İÇİN METHOD ÇAĞIRIYORUM.
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("GÜNCELLEME", "KD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);


                    //işem sonunda listeleme ve textlerin silinmesi
                    TabloDoldur();
                    tbxKategoriAdi.Text = "";
                    KDKategoriID = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message+"Güncelleme yapılamaz."); tbxKategoriAdi.Text = "";
                }
                
            }
        }

        private void dgwKDKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KDKategoriID = Convert.ToInt32(dgwKDKategori.CurrentRow.Cells[0].Value.ToString());
            tbxKategoriAdi.Text = (SutunBosmu(1) == 0 ? "" : dgwKDKategori.CurrentRow.Cells[1].Value.ToString());
        }

        private void lblKategoriSil_Click(object sender, EventArgs e)
        {

            if (KDKategoriID == 0)
            {
                MessageBox.Show("Silmek istediğiniz kategoriyi tabloda seçiniz.");
            }
            else
            {
                try
                {
                    string kaynakklasor = "C:\\Doküman Yönetimi\\Kurumsal Doküman\\" + tbxKategoriAdi.Text;
                    string[] dosyalar = Directory.GetFiles(kaynakklasor);
                    if (Directory.Exists(kaynakklasor) && dosyalar.Count() > 0) //kaynak klasör varsa
                    {

                        MessageBox.Show(tbxKategoriAdi.Text + " dizini boş değil. Silinemez. ");
                    }
                    else
                    {

                        try
                        {
                            KDKategoriDal kDKategoriDal = new KDKategoriDal();
                            kDKategoriDal.Sil(KDKategoriID);
                            Directory.Delete(kaynakklasor, false); //dizin her ihtimale karşı gene kontrol ediyorum. false doluysa işlem yapmaz
                            MessageBox.Show(tbxKategoriAdi.Text + " kategori silindi.");
                            LogDal logDal = new LogDal();
                            logDal.LogGonder("SİLME", "KD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                            TabloDoldur();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Silme işlemi yapılamadı. Bu kategoriye atanan dosya var.");
                        }


                        tbxKategoriAdi.Text = "";
                        KDKategoriID = 0;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                 
            }
        }
    }
}
