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
    public partial class HatirlaticiUI : Form
    {
        public HatirlaticiUI()
        {
            InitializeComponent();
        }
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;

        private void HatirlaticiUI_Load(object sender, EventArgs e)
        {
           lblGuncelTarih.Text= DateTime.Now.ToShortDateString();

            PersonelDal personelDal = new PersonelDal();
            dgwYaklasanDGunu.DataSource = personelDal.DogumTarihiYaklasan(DateTime.Now.Month.ToString(), "AKTİF");
            lblDGEKS.Text = dgwYaklasanDGunu.Rows.Count.ToString();
            dgwYaklasanKKutlama.DataSource = personelDal.KidemTarihiYaklasan(DateTime.Now.Month.ToString(), "AKTİF");
            lblKKEK.Text = dgwYaklasanKKutlama.Rows.Count.ToString();
            for (int i = 0; i < dgwYaklasanDGunu.ColumnCount; i++)
            {
                dgwYaklasanDGunu.Columns[i].Visible = false;
            }
            for (int i = 0; i < dgwYaklasanKKutlama.ColumnCount; i++)
            {
                dgwYaklasanKKutlama.Columns[i].Visible = false;
            }
            dgwYaklasanKKutlama.Columns["SicilNo"].Visible = true; dgwYaklasanKKutlama.Columns["SicilNo"].HeaderText = "Sicil Numarası";
            dgwYaklasanKKutlama.Columns["Ad"].Visible = true; dgwYaklasanKKutlama.Columns["Ad"].HeaderText ="Personel Adı";
            dgwYaklasanKKutlama.Columns["Soyad"].Visible = true; dgwYaklasanKKutlama.Columns["Soyad"].HeaderText = "Personel Soyadı";
            dgwYaklasanKKutlama.Columns["Eposta"].Visible = true; dgwYaklasanKKutlama.Columns["Eposta"].HeaderText = "E-Posta";
            dgwYaklasanKKutlama.Columns["IseGiris"].Visible = true; dgwYaklasanKKutlama.Columns["IseGiris"].HeaderText = "İşe Giriş Tarihi";

            dgwYaklasanDGunu.Columns["SicilNo"].Visible = true; dgwYaklasanDGunu.Columns["SicilNo"].HeaderText ="Sicil Numarası";
            dgwYaklasanDGunu.Columns["Ad"].Visible = true; dgwYaklasanDGunu.Columns["Ad"].HeaderText = "Personel Adı";
            dgwYaklasanDGunu.Columns["Soyad"].Visible = true; dgwYaklasanDGunu.Columns["Soyad"].HeaderText = "Personel Soyadı";
            dgwYaklasanDGunu.Columns["Eposta"].Visible = true; dgwYaklasanDGunu.Columns["Eposta"].HeaderText = "E-Posta";
            dgwYaklasanDGunu.Columns["DogumTarihi"].Visible = true; dgwYaklasanDGunu.Columns["DogumTarihi"].HeaderText = "Doğum Tarihi";

        }

    }
}
