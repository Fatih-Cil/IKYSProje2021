using IKYS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYS
{
    public partial class KurumsalDokumanIslemleriUI : Form
    {
        public KurumsalDokumanIslemleriUI()
        {
            InitializeComponent();
        }
        internal int SirketID = 0;
        internal int KDID = 0;
        internal string hedefKlasor= "C:\\Doküman Yönetimi\\Kurumsal Doküman\\";
        internal string kaynakDosyaYolu;
        internal string DosyaAdi;
        internal string dosyaUzantisi;
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;

        public void TabloDoldur()
        {

            KurumsalDokumanDal kurumsalDokuman = new KurumsalDokumanDal();
            dgwKurumsalDokuman.DataSource = kurumsalDokuman.TumunuListele();
            for (int i = 0; i < dgwKurumsalDokuman.ColumnCount; i++)
            {
                dgwKurumsalDokuman.Columns[i].Visible = false;
            }
            dgwKurumsalDokuman.Columns["KDPath"].Visible = true; dgwKurumsalDokuman.Columns["KDPath"].HeaderText = "Kurumsal Dokümanın Yolu";
            dgwKurumsalDokuman.Columns["KDKId"].Visible = true; dgwKurumsalDokuman.Columns["KDKId"].HeaderText = "Kurumsal Dokümanın ID'si";


        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwKurumsalDokuman.CurrentRow.Cells[i].Value == null || dgwKurumsalDokuman.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwKurumsalDokuman.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void btnKDEkle_Click(object sender, EventArgs e) //dosya seç butonu
        {
           
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Title = "Kurumsal bir doküman seçiniz.";
            
            if (file.ShowDialog()==DialogResult.OK)
            {
             kaynakDosyaYolu = file.FileName;
                
             DosyaAdi = file.SafeFileName;
                dosyaUzantisi = Path.GetExtension(kaynakDosyaYolu);//uzantıyı alıyorum.
                lblDosyaAdi.Text = DosyaAdi;

               

            }
            
            
                
           


        }

        private void KurumsalDokumanIslemleriUI_Load(object sender, EventArgs e)
        {

            TabloDoldur();
            

            KDKategoriDal kDKategori = new KDKategoriDal();
            cbxKDKategori.DataSource = kDKategori.TumunuListele();
            cbxKDKategori.DisplayMember = "KDKAdi";
            cbxKDKategori.ValueMember = "KDKId"; //selected value ile bu değeri alabilirim.

            SirketDal sirket = new SirketDal();

            cbxSirket.DataSource= sirket.TumunuListele();
            cbxSirket.DisplayMember = "Unvan";
            cbxSirket.ValueMember = "SirketId"; //selectedvalue ile bu değer comboboxtan okuyacağım. 
            



        }

        private void btnKDKaydet_Click(object sender, EventArgs e)
        {

            if (lblDosyaAdi.Text=="" || cbxKDKategori.Text==""|| lblDosyaAdi.Text==null)
            {
                MessageBox.Show("Öcelikle yüklemek istediğiniz dosyayı seçmelisiniz.");
            }
            else
            {
                try
                {
                   
                    KurumsalDokuman kurumsalDokuman = new KurumsalDokuman();
                    string yeniDosyaAdi = (cbxSirket.SelectedValue.ToString() + "-"  + DosyaAdi);
                    //hedef klasor yolunu yukarda bu sınıfın başında tanımladım.
                    kurumsalDokuman.KdPath = hedefKlasor + cbxKDKategori.Text.ToString()+"\\"+yeniDosyaAdi;
                    kurumsalDokuman.SirketId= Convert.ToInt32(cbxSirket.SelectedValue);
                    kurumsalDokuman.KDKId = Convert.ToInt32(cbxKDKategori.SelectedValue);

                    //kaynak dosya yolu seçilen belgenin yoludur, hedef klasor ana dizini gösteriyor. kategoriye göre ana dizindeki klasöre gidiyor. içine şirketID-ilgili kategori adı-seçilen dosyanın adı şeklinde ekleme yapıyor.
                    File.Copy(kaynakDosyaYolu, Path.Combine((hedefKlasor + cbxKDKategori.Text.ToString()), yeniDosyaAdi));

                    KurumsalDokumanDal kurumsalDokumanDal = new KurumsalDokumanDal();
                    kurumsalDokumanDal.Ekle(kurumsalDokuman);
                    MessageBox.Show(cbxKDKategori.Text + " klasörüne yeni belge eklendi.");
                    TabloDoldur();


                    LogDal logDal = new LogDal();
                    logDal.LogGonder("EKLEME", "KURUMSAL DOKÜMAN İŞLEMLERİ", AktifKullaniciAdi, AktifKullaniciID);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
                lblDosyaAdi.Text = "";
            }
            
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            TabloDoldur();
        }

        private void dgwKurumsalDokuman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KDID = Convert.ToInt32(dgwKurumsalDokuman.CurrentRow.Cells[0].Value.ToString());
            tbxDosyaPath.Text = (SutunBosmu(1) == 0 ? "" : dgwKurumsalDokuman.CurrentRow.Cells[1].Value.ToString());
            linkLabel1.Text = (SutunBosmu(1) == 0 ? "" : dgwKurumsalDokuman.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            if (chbxOnay.Checked!=true)
            {
                MessageBox.Show("Silme işlemi için onayı tıklayınız.");
            }
            else
            {
                if (tbxDosyaPath.Text == "" || tbxDosyaPath.Text == null)
                {
                    MessageBox.Show("Silmek istediğiniz dosyayı tablodan seçiniz.");
                }
                else
                {
                    try
                    {
                        File.Delete(tbxDosyaPath.Text);
                        KurumsalDokumanDal kurumsalDokumanDal = new KurumsalDokumanDal();
                        kurumsalDokumanDal.Sil(KDID);
                        MessageBox.Show("Seçilen dosya sistemden silindi.");
                        TabloDoldur();
                        LogDal logDal = new LogDal();
                        logDal.LogGonder("SİLME", "KURUMSAL DOKÜMAN İŞLEMLERİ", AktifKullaniciAdi, AktifKullaniciID);
                        tbxDosyaPath.Text = "";
                        linkLabel1.Text = "Silmek istediğiniz dosyayı tablodan seçiniz.";
                        chbxOnay.Checked = false;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }
            
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text== "Tablodan bir dokuman seçiniz.")
            {
                MessageBox.Show("Tablodan bir dokuman seçiniz.");

            }
            else
            {
                try
                {
                    Process.Start(linkLabel1.Text.ToString());

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
