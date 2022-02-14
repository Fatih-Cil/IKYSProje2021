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
    public partial class PersonelGoruntule : Form
    {
        public PersonelGoruntule()
        {
            InitializeComponent();
        }
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;

        public void TabloDoldur()
        {
            PersonelDal personelDal = new PersonelDal();
            dgwPersonelListe.DataSource = personelDal.TumunuListele();



            dgwPersonelListe.Columns["PersonelId"].Visible = false;
            dgwPersonelListe.Columns["Sifre"].Visible = false;
           
            //dgwPersonelListe.Columns["BolumId"].Visible = false;
            //dgwPersonelListe.Columns["RolId"].Visible = false;
            //dgwPersonelListe.Columns["GorevId"].Visible = false;
            dgwPersonelListe.Columns["Bolum"].Visible = false;
            dgwPersonelListe.Columns["Bordro"].Visible = false;
            dgwPersonelListe.Columns["Gorev"].Visible = false;
            dgwPersonelListe.Columns["Loglar"].Visible = false;
            dgwPersonelListe.Columns["Roller"].Visible = false;
            dgwPersonelListe.Columns["PersonelDokuman"].Visible = false;
        }

        public void TabloSinirla()
        {
            dgwPersonelListe.Columns["PersonelId"].Visible = false;
            dgwPersonelListe.Columns["Sifre"].Visible = false;
            dgwPersonelListe.Columns["Bolum"].Visible = false;
            dgwPersonelListe.Columns["Bordro"].Visible = false;
            dgwPersonelListe.Columns["Gorev"].Visible = false;
            dgwPersonelListe.Columns["Loglar"].Visible = false;
            dgwPersonelListe.Columns["Roller"].Visible = false;
            dgwPersonelListe.Columns["PersonelDokuman"].Visible = false;
        }
        private void PersonelGoruntule_Load(object sender, EventArgs e)
        {
            TabloDoldur();
        }



        private void tbxAd_TextChanged(object sender, EventArgs e)
        {
            PersonelDal personelDal = new PersonelDal();
            dgwPersonelListe.DataSource = personelDal.PersonelAdindaAra(tbxAd.Text.ToUpper());
        }

        private void btnSicilNo_Click(object sender, EventArgs e)
        {
            dgwPersonelListe.DataSource = null;
            if (chbxPasif.Checked == true && tbxSicilNo.Text != "") //Pasifler dahil tüm kayıtta arama yapar
            {
                PersonelDal personelDal = new PersonelDal();
                var personel = personelDal.SicilNoAra(Convert.ToInt32(tbxSicilNo.Text));
                if (personel.Count > 0)
                {
                    dgwPersonelListe.DataSource = personel;
                    TabloSinirla();
                }
                else
                {
                    MessageBox.Show(tbxSicilNo.Text + " sicil numarasına ait bir personel bulunamadı.");
                }
            }
            else if (chbxPasif.Checked == false && tbxSicilNo.Text != "")
            {
                PersonelDal personelDal = new PersonelDal();
                var personel = personelDal.SicilNoAra(Convert.ToInt32(tbxSicilNo.Text), "AKTİF");
                if (personel.Count > 0)
                {
                    dgwPersonelListe.DataSource = personel;
                    TabloSinirla();
                }
                else
                {
                    MessageBox.Show("Aktif kayıtlar için " + tbxSicilNo.Text + " sicil numarasına ait bir personel bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Sicil numarası boş geçilemez. ");
             }

        }

        private void tbxSicilNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }
    }
}
