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
    public partial class LogYonetimUI : Form
    {
        public LogYonetimUI()
        {
            InitializeComponent();
        }
        internal int AktifKullaniciID = 0;
        public void TabloDoldur()
        {
            LogDal logDal = new LogDal();
            dgwLogYonetim.DataSource = logDal.TumunuListele();
           
            dgwLogYonetim.Columns["Personel"].Visible = false;
            dgwLogYonetim.Columns["PersonelId"].Visible = false;
            dgwLogYonetim.Columns["LogId"].Visible = false;
        }
        private void LogYonetimUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
            PersonelDal personelDal = new PersonelDal();
            cbxSicilNo.DataSource= personelDal.TumunuListele();
            cbxSicilNo.DisplayMember = "SicilNo";
            cbxSicilNo.ValueMember = "PersonelId";
         
        }

        private void cbxEylem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogDal logDal = new LogDal();
            dgwLogYonetim.DataSource= logDal.EylemAra(cbxEylem.SelectedItem.ToString());
            
        }

        private void cbxModul_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogDal logDal = new LogDal();
            dgwLogYonetim.DataSource = logDal.ModulAra(cbxModul.SelectedItem.ToString());
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnSicilNoAra_Click(object sender, EventArgs e)
        {
            if (cbxSicilNoModul.Text=="" || cbxSicilNo.Text=="")
            {
                MessageBox.Show("Modül ve Sicil No boş olamaz.");
            }
            else
            {
               
                PersonelDal personelDal = new PersonelDal();
                var personel = personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNo.Text));
                foreach (var item in personel)
                {

                    LogDal logDal = new LogDal();
                    dgwLogYonetim.DataSource = logDal.SicilNoAra(item.PersonelId, cbxSicilNoModul.SelectedItem.ToString(), dtpSicilNoTarihi.Value.Date);

                }

            }
              
        }

        private void btnCokluSecim_Click(object sender, EventArgs e)
        {

            if (cbxEylem.Text=="" || cbxModul.Text=="")
            {
                MessageBox.Show("Eylem ve modül seçiniz.");
            }
            else
            {
                LogDal logDal = new LogDal();
                dgwLogYonetim.DataSource = logDal.CokluAra(cbxEylem.SelectedItem.ToString(), cbxModul.SelectedItem.ToString(), dtpSinirliSecimTarihi.Value.Date); ;

            }
            
        }

        private void btnTarihTopluListele_Click(object sender, EventArgs e)
        {
            LogDal logDal = new LogDal();
            dgwLogYonetim.DataSource= logDal.TariheGoreAra(dtpTopluTarih.Value.Date);
        }
    }
}
