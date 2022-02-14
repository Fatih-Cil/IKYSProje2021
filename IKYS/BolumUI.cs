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
    public partial class BolumUI : Form
    {
        public BolumUI()
        {
            InitializeComponent();
        }
        internal int BolumID = 0;
        internal int SirketID = 0;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;

        public void TabloDoldur()
        {

            BolumDal bolumDal = new BolumDal();
            dgwBolum.DataSource = bolumDal.TumunuListele();
            for (int i = 0; i < dgwBolum.ColumnCount; i++)
            {
                dgwBolum.Columns[i].Visible = false;
            }
            dgwBolum.Columns["BolumAdi"].Visible = true; dgwBolum.Columns["BolumAdi"].HeaderText = "Bölüm Adı";
            
        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwBolum.CurrentRow.Cells[i].Value == null || dgwBolum.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwBolum.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        
        private void BolumUI_Load(object sender, EventArgs e)
        {

            TabloDoldur();
            SirketDal sirket = new SirketDal();

            cbxSirketAdi.DataSource = sirket.TumunuListele();
            cbxSirketAdi.DisplayMember = "Unvan";
            cbxSirketAdi.ValueMember = "SirketId"; //selectedvalue ile bu değer comboboxtan okuyacağım. 
        }

        private void dgwBolum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BolumID = Convert.ToInt32(dgwBolum.CurrentRow.Cells[0].Value.ToString());
            tbxBolumAdi.Text = (SutunBosmu(1) == 0 ? "" : dgwBolum.CurrentRow.Cells[1].Value.ToString());
        }

        private void lblBolumListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            if (tbxBolumAdi.Text == "")
            {
                MessageBox.Show("Bölüm adı boş geçilemez.");
            }
            else
            {
                BolumDal bolumDal = new BolumDal();
                List<Bolum> bul = bolumDal.Ara(tbxBolumAdi.Text.ToUpper()); //bölüm adı varsa count sıfırdan büyük olacağı için bölüm eklenmiyor.
                if (bul.Count > 0)
                {
                    MessageBox.Show("Bu isimde bir bolum var!");
                }
                else
                {


                    SirketID = Convert.ToInt32(cbxSirketAdi.SelectedValue);
                    Bolum bolum = new Bolum();
                    bolum.BolumAdi = tbxBolumAdi.Text.ToUpper();
                    bolum.SirketId = SirketID;
                    bolumDal.Ekle(bolum);
                    MessageBox.Show(bolum.BolumAdi + " adında yeni bölüm eklendi.");
                    
                    //LOG YOLLAMAK İÇİN METHOD ÇAĞIRIYORUM.
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "BÖLÜM YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    
                    TabloDoldur();
                    tbxBolumAdi.Text = "";
                    BolumID = 0;
                    SirketID = 0;

                }
            }
        }

        private void lblBolumSil_Click(object sender, EventArgs e)
        {
            if (BolumID == 0)
            {
                MessageBox.Show("Silmek istediğiniz bölümü tabloda seçiniz.");
            }
            else
            {

                try
                {
                    BolumDal bolumDal = new BolumDal();

                    bolumDal.Sil(BolumID);


                    MessageBox.Show(tbxBolumAdi.Text + " bolumü silindi.");

                    LogDal logDal = new LogDal();
                    logDal.LogGonder("SİLME", "BÖLÜM YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    TabloDoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Silme işlemi yapılamadı. Bu bölümu kullanan personel var.");
                }

                tbxBolumAdi.Text = "";
                BolumID = 0;
            }
        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            if (BolumID == 0)
            {
                MessageBox.Show("Güncellemek istediğiniz görevi tabloda seçiniz.");
            }
            else
            {
                string guncelBolumAdi = tbxBolumAdi.Text.ToUpper();
                BolumDal bolumDal = new BolumDal();
                bolumDal.Guncelle(BolumID, guncelBolumAdi);

                MessageBox.Show("Bölüm güncellendi.");
                LogDal logDal = new LogDal();
                logDal.LogGonder("GÜNCELLEME", "BÖLÜM YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                TabloDoldur();
                tbxBolumAdi.Text = "";
                BolumID = 0;
            }
        }
    }
}
