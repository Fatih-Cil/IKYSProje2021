using IKYSProjeWinUI.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYSProjeWinUI
{
    public partial class Sirketwinform : Form
    {
        public Sirketwinform()
        {
            InitializeComponent();
        }
        public int SirketId = 0;

        private void Sirketwinform_Load(object sender, EventArgs e)
        {

            SirketDal sorgula = new SirketDal();
            dgwSirketBilgisi.DataSource = sorgula.SirketListele();


        }

        private void dgwSirketBilgisi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SirketId = Convert.ToInt32(dgwSirketBilgisi.CurrentRow.Cells[0].Value.ToString());
            tbxVergiDairesiNo.Text = dgwSirketBilgisi.CurrentRow.Cells[5].Value.ToString();
            tbxVergiDairesiAdi.Text = dgwSirketBilgisi.CurrentRow.Cells[4].Value.ToString();
            tbxUnvan.Text = dgwSirketBilgisi.CurrentRow.Cells[1].Value.ToString();
            tbxAdres.Text = dgwSirketBilgisi.CurrentRow.Cells[2].Value.ToString();
            tbxTelefon.Text = dgwSirketBilgisi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (SirketId != 0)
            {
                if (tbxVergiDairesiNo.Text != "" && tbxVergiDairesiAdi.Text != "" && tbxUnvan.Text != "" && tbxTelefon.Text != "" && tbxAdres.Text != "")
                {
                    SirketDal sirketara = new SirketDal();
                    if (sirketara.SirketAra(tbxVergiDairesiNo.Text) == 1)
                    {
                        MessageBox.Show("Aynı vergi numarasına ait bir şirket mevcut. Kayıt Yapılamaz");
                    }
                    else
                    {

                        SirketDal sorgula = new SirketDal();
                        sorgula.SirketUpdate(SirketId, tbxUnvan.Text.ToUpper(), tbxAdres.Text.ToUpper(), tbxTelefon.Text.ToUpper(), tbxVergiDairesiNo.Text.ToUpper(), tbxVergiDairesiAdi.Text.ToUpper());
                        dgwSirketBilgisi.DataSource = sorgula.SirketListele();
                        tbxVergiDairesiNo.Text = "";
                        tbxVergiDairesiAdi.Text = "";
                        tbxUnvan.Text = "";
                        tbxAdres.Text = "";
                        tbxTelefon.Text = "";
                        SirketId = 0;
                    }
                }
                else MessageBox.Show("Tüm alanların doldurulması zorunludur. ");
            }
            else MessageBox.Show("Lütfen tablodan işlem yapmak istediğiniz satıra çift tıklayın.");
        }

        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            if (tbxVergiDairesiNo.Text != "" && tbxVergiDairesiAdi.Text != "" && tbxUnvan.Text != "" && tbxTelefon.Text != "" && tbxAdres.Text != "")
            {
                SirketDal sirketara = new SirketDal();
                if (sirketara.SirketAra(tbxVergiDairesiNo.Text) == 1)
                {
                    MessageBox.Show("Aynı vergi numarasına ait bir şirket mevcut. Kayıt Yapılamaz");
                }
                else
                {
                    Sirket sirket = new Sirket();
                    sirket.VergiDairesiNo = tbxVergiDairesiNo.Text.ToUpper();
                    sirket.VergiDairesiAdi = tbxVergiDairesiAdi.Text.ToUpper();
                    sirket.Unvan = tbxUnvan.Text.ToUpper();
                    sirket.Telefon = tbxTelefon.Text.ToUpper();
                    sirket.Adres = tbxAdres.Text.ToUpper();

                    //Şirket eklenmesi için yollanıyor.
                    SirketDal sirketDal = new SirketDal();
                    sirketDal.SirketEkle(sirket);

                    //Eklemeden sonra tablo tolduruluyor ve editler siliniyor.

                    dgwSirketBilgisi.DataSource = sirketDal.SirketListele();
                    tbxVergiDairesiNo.Text = "";
                    tbxVergiDairesiAdi.Text = "";
                    tbxUnvan.Text = "";
                    tbxAdres.Text = "";
                    tbxTelefon.Text = "";
                }
               

            }
            else MessageBox.Show("Tüm alanların doldurulması zorunludur. ");



           
        }

        private void btnSirketSil_Click(object sender, EventArgs e)
        {

            if (SirketId != 0)
            {
                SirketDal sirketSil = new SirketDal();
                sirketSil.SirketSil(SirketId);
                dgwSirketBilgisi.DataSource = sirketSil.SirketListele();
                SirketId = 0;
                tbxVergiDairesiNo.Text = "";
                tbxVergiDairesiAdi.Text = "";
                tbxUnvan.Text = "";
                tbxAdres.Text = "";
                tbxTelefon.Text = "";
            }
            else MessageBox.Show("Lütfen tablodan işlem yapmak istediğiniz satıra çift tıklayın.");
        }
    }
}
