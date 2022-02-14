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
    public partial class PDKategoriUI : Form
    {
        public PDKategoriUI()
        {
            InitializeComponent();
        }
        internal int PDKategoriID = 0;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        public void TabloDoldur()
        {

            PDKategoriDal pDKategoriDal = new PDKategoriDal();
            dgwPDKategori.DataSource = pDKategoriDal.TumunuListele();
            dgwPDKategori.Columns["PDKAdi"].HeaderText = "Personel Doküman Kategori Adı";


            dgwPDKategori.Columns["PDKId"].Visible = false;
            dgwPDKategori.Columns["PersonelDokuman"].Visible = false;

        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwPDKategori.CurrentRow.Cells[i].Value == null || dgwPDKategori.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwPDKategori.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;

            }

        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (tbxKategoriAdi.Text == "")
            {
                MessageBox.Show("Kategori adı boş geçilemez.");
            }
            else if (tbxKategoriAdi.Text.ToUpper() == "VESİKALIK")
            {
                MessageBox.Show("Vesikalık adında klasör açamazsınız. Bu klasöre erişim ve düzenleme Personel Yönetim ekranından yapılmaktadır.");
            }

            else
            {
                PDKategoriDal pDKategoriDal = new PDKategoriDal();
                List<PDKategori> bul = pDKategoriDal.Ara(tbxKategoriAdi.Text.ToUpper());
                if (bul.Count > 0)
                {
                    MessageBox.Show("Bu isimde bir kategori var!");
                }
                else
                {

                    PDKategori pDKategori = new PDKategori();
                    pDKategori.PDKAdi = tbxKategoriAdi.Text.ToUpper();
                    pDKategoriDal.Ekle(pDKategori);

                    //kategori eklenince doküman yönetiminde belirttiğim yerde o isimde klasöor oluşuyor.
                    string klasor = tbxKategoriAdi.Text.ToUpper();
                    Directory.CreateDirectory("C:\\Doküman Yönetimi\\Personel Doküman\\" + klasor);
                    MessageBox.Show(tbxKategoriAdi.Text + " isminde yeni kategori eklendi.");


                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "PD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    TabloDoldur();
                    tbxKategoriAdi.Text = "";

                }



            }
        }

        private void PDKategoriUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (PDKategoriID == 0)
            {
                MessageBox.Show("Güncellemek istediğiniz kategoriyi tabloda seçiniz.");
            }
            else
            {
                try
                {
                    string guncelkategoriAdi = tbxKategoriAdi.Text.ToUpper();
                    PDKategoriDal pDKategoriDal = new PDKategoriDal();

                    //eski kategori adı sistemden aranıp getiriliyor
                    var eskikategori = pDKategoriDal.KategoriAra(PDKategoriID);
                    string eskiKategoriAdi = eskikategori.PDKAdi;
                    string kaynakklasor = "C:\\Doküman Yönetimi\\Personel Doküman\\" + eskiKategoriAdi;
                    //DİZİNİN BOŞ OLUP OLMADIĞINI KONTROL EDİYORUM. DİZİN BOŞ İSE KAYNAK KLASÖRÜ SİLİYORUM.
                    Directory.Delete(kaynakklasor, false);

                    
                    pDKategoriDal.Guncelle(PDKategoriID, guncelkategoriAdi);

                    Directory.CreateDirectory("C:\\Doküman Yönetimi\\Personel Doküman\\" + guncelkategoriAdi);
                   


                    MessageBox.Show(eskiKategoriAdi + " kategori adi " + tbxKategoriAdi.Text.ToUpper() + " kategori adı ile değişti. ");

                    //LOG YOLLAMAK İÇİN METHOD ÇAĞIRIYORUM.
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("GÜNCELLEME", "PD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);


                    //işem sonunda listeleme ve textlerin silinmesi
                    TabloDoldur();
                    tbxKategoriAdi.Text = "";
                    PDKategoriID = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message+"Güncelleme yapılamaz.");tbxKategoriAdi.Text = "";
                } 
            }
        }

        private void lblKategoriSil_Click(object sender, EventArgs e)
        {
            if (PDKategoriID == 0)
            {
                MessageBox.Show("Silmek istediğiniz kategoriyi tabloda seçiniz.");
            }
            else
            {
                string kaynakklasor = "C:\\Doküman Yönetimi\\Personel Doküman\\" + tbxKategoriAdi.Text;
                string[] dosyalar = Directory.GetFiles(kaynakklasor);

                if (Directory.Exists(kaynakklasor) && dosyalar.Count() > 0) //kaynak klasör varsa
                {

                    MessageBox.Show(tbxKategoriAdi.Text + " dizini boş değil. Silinemez. ");
                }
                else
                {
                    try
                    {
                        PDKategoriDal pDKategoriDal = new PDKategoriDal();
                        pDKategoriDal.Sil(PDKategoriID);
                        Directory.Delete(kaynakklasor, false);
                        MessageBox.Show(tbxKategoriAdi.Text + " kategori silindi.");
                        LogDal logDal = new LogDal();
                        logDal.LogGonder("SİLME", "PD KATEGORİ YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                        TabloDoldur();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Silme işlemi yapılamadı. Bu kategoriye atanan dosya var.");
                    }

                }

                tbxKategoriAdi.Text = "";
                PDKategoriID = 0;
            }
        }

        private void dgwPDKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PDKategoriID = Convert.ToInt32(dgwPDKategori.CurrentRow.Cells[0].Value.ToString());
            tbxKategoriAdi.Text = (SutunBosmu(1) == 0 ? "" : dgwPDKategori.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
