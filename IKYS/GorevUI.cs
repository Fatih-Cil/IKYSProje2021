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
    public partial class GorevUI : Form
    {
        public GorevUI()
        {
            InitializeComponent();
        }
        internal int GorevID = 0; //ekleme, güncelleme ve silme gorevid ile kontrol edeceğim.id olmadan işlem yapmaya izin vermeyeceğim.
        public int AktifKullaniciID=0;
        public string AktifKullaniciAdi;
        public void TabloDoldur()
        {
            GorevDal gorevDal = new GorevDal();
            dgwGorev.DataSource = gorevDal.TumunuListele();
            for (int i = 0; i < dgwGorev.ColumnCount; i++)
            {
                dgwGorev.Columns[i].Visible = false;
            }
            dgwGorev.Columns["GorevAdi"].Visible = true; dgwGorev.Columns["GorevAdi"].HeaderText = "Görev Adı";
           
            

        }

        
        private void GorevUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
            
        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwGorev.CurrentRow.Cells[i].Value == null || dgwGorev.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwGorev.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;

            }

        }
        private void dgwGorev_CellContentClick(object sender, DataGridViewCellEventArgs e) //datagrid içinde tıklanan satıra ait veri ilgili textbox'a atanıyor.veri yoksa boş değer atıyor.
        {
            GorevID = Convert.ToInt32(dgwGorev.CurrentRow.Cells[0].Value.ToString());
            tbxGorevAdi.Text = (SutunBosmu(1) == 0 ? "" : dgwGorev.CurrentRow.Cells[1].Value.ToString());
        }

        private void lblGorevListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnGorevGuncelle_Click(object sender, EventArgs e)
        {
            if (GorevID == 0)
            {
                MessageBox.Show("Güncellemek istediğiniz görevi tabloda seçiniz.");
            }
            else
            {
                string guncelGorevAdi = tbxGorevAdi.Text.ToUpper();
                GorevDal gorevDal = new GorevDal();
                gorevDal.Guncelle(GorevID, guncelGorevAdi);

                
                MessageBox.Show("Görev güncellendi.");

                //LOG YOLLAMAK İÇİN METHOD ÇAĞIRIYORUM.
                LogDal logDal = new LogDal();
                logDal.LogGonder("GÜNCELLEME", "GÖREV YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
              

                //işem sonunda listeleme ve textlerin silinmesi
                TabloDoldur();
                tbxGorevAdi.Text = "";
                GorevID = 0;
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (tbxGorevAdi.Text == "")
            {
                MessageBox.Show("Görev adı boş geçilemez.");
            }
            
            else
            {
                GorevDal gorevDal = new GorevDal();
                List<Gorev> bul = gorevDal.Ara(tbxGorevAdi.Text.ToUpper());
                if (bul.Count > 0)
                {
                    MessageBox.Show("Bu isimde bir görev var!");
                }
                else
                {
                    Gorev gorev = new Gorev();
                    gorev.GorevAdi = tbxGorevAdi.Text.ToUpper();
                    gorevDal.Ekle(gorev);
                    MessageBox.Show(tbxGorevAdi.Text + " isminde yeni görev eklendi.");
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "GÖREV YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    TabloDoldur();
                    tbxGorevAdi.Text = "";
                    GorevID = 0;
                }
            }


        }

        private void lblGorevSil_Click(object sender, EventArgs e)
        {

            if (GorevID == 0)
            {
                MessageBox.Show("Silmek istediğiniz görevi tabloda seçiniz.");
            }
            else
            {

                try
                {
                    GorevDal gorevDal = new GorevDal();
                    gorevDal.Sil(GorevID);
                    MessageBox.Show(tbxGorevAdi.Text + " görevi silindi.");
                    LogDal logDal = new LogDal();
                    logDal.LogGonder("SİLME", "GÖREV YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);
                    TabloDoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Silme işlemi yapılamadı. Bu göreve atanan personel var.");
                }


                tbxGorevAdi.Text = "";
                GorevID = 0;
            }

        }
    }
}
