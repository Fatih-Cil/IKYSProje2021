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
    public partial class BolumRaporlamaUI : Form
    {
        public BolumRaporlamaUI()
        {
            InitializeComponent();
        }
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        private void BolumRaporlamaUI_Load(object sender, EventArgs e)
        {
            BolumDal bolumDal = new BolumDal();
            cbxBolum.DataSource = bolumDal.TumunuListele();
            cbxBolum.DisplayMember = "BolumAdi";
            cbxBolum.ValueMember = "BolumId";

        }

        private void cbxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonelDal personelDal = new PersonelDal();
                tbxPasifSayisi.Text= (personelDal.BolumIdIleAra(Convert.ToInt32(cbxBolum.SelectedValue), "PASİF")).Count.ToString();

                List<Personel> getir= personelDal.BolumIdIleAra(Convert.ToInt32(cbxBolum.SelectedValue), "AKTİF");
                dgwBolumRaporlama.DataSource = getir;

                for (int i = 0; i < dgwBolumRaporlama.ColumnCount; i++)
                {
                    dgwBolumRaporlama.Columns[i].Visible = false;
                }
                dgwBolumRaporlama.Columns["SicilNo"].Visible = true; dgwBolumRaporlama.Columns["SicilNo"].HeaderText = "Sicil No";
                dgwBolumRaporlama.Columns["TcNo"].Visible = true; dgwBolumRaporlama.Columns["TcNo"].HeaderText = "TC No";
                dgwBolumRaporlama.Columns["Ad"].Visible = true; dgwBolumRaporlama.Columns["Ad"].HeaderText = "Ad";
                dgwBolumRaporlama.Columns["Soyad"].Visible = true; dgwBolumRaporlama.Columns["Soyad"].HeaderText = "Soyad";
                dgwBolumRaporlama.Columns["IseGiris"].Visible = true; dgwBolumRaporlama.Columns["IseGiris"].HeaderText = "İşe Giriş";
                dgwBolumRaporlama.Columns["Durum"].Visible = true; dgwBolumRaporlama.Columns["Durum"].HeaderText = "Durum";

                int toplamMaas = 0;

                
                for (int i = 0; i < dgwBolumRaporlama.RowCount; i++)
                {
                    toplamMaas += Convert.ToInt32(dgwBolumRaporlama.Rows[i].Cells[11].Value);
                }
                tbxBolumAdi.Text = cbxBolum.Text;
                tbxCalisanSayisi.Text = dgwBolumRaporlama.RowCount.ToString();
                tbxAylikMaliyet.Text = toplamMaas.ToString();
                tbxBolumYillikMaliyet.Text = (12*toplamMaas).ToString();


            }
            catch 
            {

              
            }
           

        }
    }
}
