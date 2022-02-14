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
    public partial class SirketUI : Form
    {
        public SirketUI()
        {
            InitializeComponent();
        }

        internal int SirketID = 0;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        public void TabloDoldur()
        {
            SirketDal sirketDal = new SirketDal();
            dgwSirket.DataSource = sirketDal.TumunuListele();

            for (int i = 0; i < dgwSirket.ColumnCount; i++)
            {
                dgwSirket.Columns[i].Visible = false;
            }
            dgwSirket.Columns["Unvan"].Visible = true; dgwSirket.Columns["Unvan"].HeaderText = "Ünvan";
            dgwSirket.Columns["Telefon"].Visible = true; dgwSirket.Columns["Telefon"].HeaderText = "Telefon";
            dgwSirket.Columns["Adres"].Visible = true; dgwSirket.Columns["Adres"].HeaderText = "Adres";
            dgwSirket.Columns["VergiDairesiNo"].Visible = true; dgwSirket.Columns["VergiDairesiNo"].HeaderText = "Vergi Dairesi Numarası";
            dgwSirket.Columns["VergiDairesiAdi"].Visible = true; dgwSirket.Columns["VergiDairesiAdi"].HeaderText = "Vergi Dairesi Adı";
        }
        private void SirketUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa tıklandığında program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwSirket.CurrentRow.Cells[i].Value == null || dgwSirket.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwSirket.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;

            }
        }

        private void dgwSirket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SirketID = Convert.ToInt32(dgwSirket.CurrentRow.Cells[0].Value.ToString());
            tbxUnvan.Text = (SutunBosmu(1) == 0 ? "" : dgwSirket.CurrentRow.Cells[1].Value.ToString());
            tbxTelefon.Text = (SutunBosmu(2) == 0 ? "" : dgwSirket.CurrentRow.Cells[2].Value.ToString());
            tbxAdres.Text = (SutunBosmu(3) == 0 ? "" : dgwSirket.CurrentRow.Cells[3].Value.ToString());
            tbxVergiNo.Text = (SutunBosmu(4) == 0 ? "" : dgwSirket.CurrentRow.Cells[4].Value.ToString());
            tbxVergiAdi.Text = (SutunBosmu(5) == 0 ? "" : dgwSirket.CurrentRow.Cells[5].Value.ToString());
        }

        private void lblBolumListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            if (SirketID == 0)
            {
                MessageBox.Show("Güncellemek istediğiniz şirketi tabloda seçiniz.");
            }
            else
            {
                string guncelUmvan = tbxUnvan.Text.ToUpper();
                string guncelTelefon = tbxTelefon.Text.ToUpper();
                string guncelAdres = tbxAdres.Text.ToUpper();
                string guncelvdno = tbxVergiNo.Text.ToUpper();
                string guncelvdadi = tbxVergiAdi.Text.ToUpper();

                SirketDal sirketDal = new SirketDal();
                sirketDal.Guncelle(SirketID, guncelUmvan, guncelTelefon, guncelAdres, guncelvdno, guncelvdadi);

                MessageBox.Show("Şirket bilgileri güncellendi.");

                //log tablosuna ilgili işlemi yazıyorum.
                LogDal logDal = new LogDal();
                logDal.LogGonder("GÜNCELLEME", "ŞİRKET YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);

                TabloDoldur();

                tbxUnvan.Text = "";
                tbxTelefon.Text = "";
                tbxAdres.Text = "";
                tbxVergiNo.Text = "";
                tbxVergiAdi.Text = "";
                SirketID = 0; //işlem bitince seçili satırın id'sini sıfır yapıyorum
            }
        }

        private void tbxTelefon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxVergiNo_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }
}
