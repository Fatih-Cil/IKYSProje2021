using IKYS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IKYS
{
    public partial class PersonelDokumanIslemleriUI : Form
    {
        public PersonelDokumanIslemleriUI()
        {
            InitializeComponent();
        }

        internal int PDID = 0;
        internal int PersonelID = 0;
        internal string kaynakDosyaYolu;
        internal string hedefKlasor = "C:\\Doküman Yönetimi\\Personel Doküman\\";
        internal string DosyaAdi;
        internal string dosyaUzantisi;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        public void TabloDoldur()
        {

            PersonelDokumanDal personelDokuman = new PersonelDokumanDal();
            dgwPersonelDokuman.DataSource = personelDokuman.TumunuListele();
            dgwPersonelDokuman.Columns["PDPath"].HeaderText = "Personel Dokümanın Yolu";
            dgwPersonelDokuman.Columns["PDKId"].HeaderText = "Personel Dokümanın ID'si";
            dgwPersonelDokuman.Columns["PersonelId"].Visible = false;

            dgwPersonelDokuman.Columns["PDId"].Visible = false;
            dgwPersonelDokuman.Columns["PDKategori"].Visible = false;
            dgwPersonelDokuman.Columns["Personel"].Visible = false;
            

        }
        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
            

           

        }
        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwPersonelDokuman.CurrentRow.Cells[i].Value == null || dgwPersonelDokuman.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwPersonelDokuman.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void dgwPersonelDokuman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PDID = Convert.ToInt32(dgwPersonelDokuman.CurrentRow.Cells[0].Value.ToString());
            tbxPersonelDosyaPath.Text = (SutunBosmu(1) == 0 ? "" : dgwPersonelDokuman.CurrentRow.Cells[1].Value.ToString());
            llblDosyaAc.Text = (SutunBosmu(1) == 0 ? "" : dgwPersonelDokuman.CurrentRow.Cells[1].Value.ToString());
        }

        private void PersonelDokumanIslemleriUI_Load(object sender, EventArgs e)
        {
            TabloDoldur();
            PDKategoriDal pDKategoriDal = new PDKategoriDal();
            cbxPDKategori.DataSource = pDKategoriDal.TumunuListele();
            cbxPDKategori.DisplayMember = "PDKAdi";
            cbxPDKategori.ValueMember = "PDKId"; //selected value ile bu değeri alabilirim.

            cbxPDKategoriAra.DataSource = pDKategoriDal.TumunuListele();
            cbxPDKategoriAra.DisplayMember = "PDKAdi";
            cbxPDKategoriAra.ValueMember = "PDKId";



            PersonelDal personelDal = new PersonelDal();
            cbxSicilNo.DataSource = personelDal.TumunuListele("AKTİF");
            cbxSicilNo.DisplayMember = "SicilNo";
            cbxSicilNo.ValueMember = "PersonelId";

            cbxSicilNoAra.DataSource = personelDal.TumunuListele("AKTİF");
            cbxSicilNoAra.DisplayMember = "SicilNo";
            cbxSicilNoAra.ValueMember = "PersonelId";
        }

        private void btnPDSec_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Title = "Personele ait bir doküman seçiniz.";

            if (file.ShowDialog() == DialogResult.OK)
            {
                kaynakDosyaYolu = file.FileName;

                DosyaAdi = file.SafeFileName;
                dosyaUzantisi = Path.GetExtension(kaynakDosyaYolu);//uzantıyı alıyorum.
                lblDosyaAdi.Text = DosyaAdi;



            }

        }

        private void btnPDKaydet_Click(object sender, EventArgs e)
        {

            if (lblDosyaAdi.Text == "" || cbxPDKategori.Text == "" || lblDosyaAdi.Text == null)
            {
                MessageBox.Show("Öcelikle yüklemek istediğiniz dosyayı seçmelisiniz.");
            }
            else
            {
                try
                {
                    PersonelDal personelDal = new PersonelDal();
                    List<Personel> bul = personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNo.Text));
                    foreach (var item in bul)
                    {
                        PersonelID = item.PersonelId;
                    }
                    //Dosya eklenirken adı değişiyor. yeni ad : personelID-seçilenkategoriadı-seçilen dosyanın adı
                    string yeniDosyaAdi = (cbxSicilNo.Text.ToString() +"-" + DosyaAdi);

                    PersonelDokuman personelDokuman = new PersonelDokuman();
                    personelDokuman.PdPath = hedefKlasor + cbxPDKategori.Text.ToString() + "\\" + yeniDosyaAdi;
                    personelDokuman.PersonelId = PersonelID;
                    personelDokuman.PDKId = Convert.ToInt32(cbxPDKategori.SelectedValue);


                    //kaynak dosya yolu seçilen belgenin yoludur, hedef klasor ana dizini gösteriyor. kategoriye göre ana dizindeki klasöre gidiyor. içine şirketID-ilgili kategori adı-seçilen dosyanın adı şeklinde ekleme yapıyor.
                    File.Copy(kaynakDosyaYolu, Path.Combine((hedefKlasor + cbxPDKategori.Text.ToString()), yeniDosyaAdi));

                    PersonelDokumanDal personelDokumanDal = new PersonelDokumanDal();
                    personelDokumanDal.Ekle(personelDokuman);

                    MessageBox.Show(cbxPDKategori.Text + " klasörüne yeni belge eklendi.");
                    TabloDoldur();


                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "PERSONEL DOKÜMAN İŞLEMLERİ", AktifKullaniciAdi, AktifKullaniciID);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                lblDosyaAdi.Text = "";
            }
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {

            if (chbxOnay.Checked!=true)
            {
                MessageBox.Show("Silme işlemi için onayı tıklayın.");

            }
            else
            {
                if (tbxPersonelDosyaPath.Text == "" || tbxPersonelDosyaPath.Text == null)
                {
                    MessageBox.Show("Silmek istediğiniz dosyayı tablodan seçiniz.");
                }
                else
                {
                    try
                    {
                        File.Delete(tbxPersonelDosyaPath.Text);
                        PersonelDokumanDal personelDokuman = new PersonelDokumanDal();
                        personelDokuman.Sil(PDID);


                        MessageBox.Show("Seçilen dosya sistemden silindi.");
                        TabloDoldur();
                        LogDal logDal = new LogDal();
                        logDal.LogGonder("SİLME", "PERSONEL DOKÜMAN İŞLEMLERİ", AktifKullaniciAdi, AktifKullaniciID);
                        tbxPersonelDosyaPath.Text = "";
                        llblDosyaAc.Text = "Tablodan bir dokuman seçiniz.";
                        chbxOnay.Checked = false;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }

        

        private void btnSicilNoAra_Click(object sender, EventArgs e)
        {
            PersonelDokumanDal personelDokumanDal = new PersonelDokumanDal();
            //sicil no seçildiğinde önce sicilden personel id yi buluyorum. sonra o id ile eşleşen dökümanları listeliyorum.
            
            PersonelDal personelDal = new PersonelDal();
            List<Personel> personels= personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNoAra.Text));
            foreach (var item in personels)
            {

                dgwPersonelDokuman.DataSource = personelDokumanDal.PersonelIdiledAra(item.PersonelId);
            }
        }

        private void btnkategoriara_Click(object sender, EventArgs e)
        {
            PersonelDokumanDal personelDokumanDal = new PersonelDokumanDal();
            dgwPersonelDokuman.DataSource = personelDokumanDal.PDKIdAra(Convert.ToInt32(cbxPDKategoriAra.SelectedValue));
            
        }

        private void btnSicilveKategoriAra_Click(object sender, EventArgs e)
        {
            PersonelDokumanDal personelDokumanDal = new PersonelDokumanDal();
            //sicil no seçildiğinde önce sicilden personel id yi buluyorum. sonra o id ile eşleşen dökümanları listeliyorum.

            PersonelDal personelDal = new PersonelDal();
            List<Personel> personels = personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNoAra.Text));
            foreach (var item in personels)
            {

                dgwPersonelDokuman.DataSource = personelDokumanDal.PIDveKategoriAra(item.PersonelId, Convert.ToInt32(cbxPDKategoriAra.SelectedValue));
            }

        }

        private void llblDosyaAc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llblDosyaAc.Text == "Tablodan bir dokuman seçiniz.")
            {
                MessageBox.Show("Tablodan bir dokuman seçiniz.");

            }
            else
            {
                try
                {
                    Process.Start(llblDosyaAc.Text.ToString());

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
