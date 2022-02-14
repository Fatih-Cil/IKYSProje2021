using IKYS.Business;
using IKYS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYS
{
    public partial class PersonelGuncelleUI : Form
    {
        public PersonelGuncelleUI()
        {
            InitializeComponent();
        }
        internal string hedefKlasor = "C:\\Doküman Yönetimi\\Personel Doküman\\VESİKALIK\\";
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        internal int PersonelID = 0;

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {

            if (lblGelenSicilNo.Text == "" || lblGelenSicilNo.Text == null)
            {
                MessageBox.Show("Öncelikle sicil numarası aratmanız gerekiyor.");
            }
            else
            {
                OpenFileDialog file = new OpenFileDialog();
                file.RestoreDirectory = true;
                file.Title = "Personel fotoğrafı seçin.";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    tbxDosyaYolu.Text = file.FileName;

                    tbxDosyaAdi.Text = file.SafeFileName;
                    
                    pbxPersonelFoto.Visible = true;
                    pbxPersonelFoto.ImageLocation = tbxDosyaYolu.Text;
                    pbxPersonelFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                }

            }

        }

        private void tbxSicilNoAra_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void tbxTcNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxCep_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxMaas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxYillikIzin_KeyPress(object sender, KeyPressEventArgs e)
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

        public void FormuTemizle()
        {
            PersonelID = 0;
            lblGelenSicilNo.Text = "";
            tbxTcNo.Text = "";
            tbxAd.Text = "";
            tbxSoyad.Text = "";
            tbxCep.Text = "";
            tbxEposta.Text = "";
            tbxAdres.Text = "";
            tbxSifre.Text = "";
            tbxMaas.Text = "";
            tbxYillikIzin.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            dtpIseGirisTarihi.Value = DateTime.Now;
            cbxKangrubu.Text = "";
            cbxOzelSaglik.Text = "";
            tbxDosyaYolu.Text = "";
            tbxDosyaAdi.Text = "";
            pbxPersonelFoto.ImageLocation = tbxDosyaYolu.Text;
            chbxSifreGuncelle.Checked = false;chbxSifreGuncelle.Visible = false;


        }

        private void btnAra_Click(object sender, EventArgs e)
        {


            FormuTemizle();

            if (tbxSicilNoAra.Text == "" || tbxSicilNoAra.Text == null)
            {
                MessageBox.Show("Sicil Numarası boş geçilemez!");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                var calisan = personelDal.SicilNoAra(Convert.ToInt32(tbxSicilNoAra.Text));
                if (calisan.Count == 0)
                {
                    MessageBox.Show("Bu sicil numarasına ait bir kayıt bulunamadı!");
                }
                else
                {
                    chbxSifreGuncelle.Visible = true;
                    foreach (var item in calisan)
                    {
                        PersonelID = item.PersonelId;
                        lblGelenSicilNo.Text = item.SicilNo.ToString();
                        tbxTcNo.Text = item.TcNo;
                        tbxAd.Text = item.Ad;
                        tbxSoyad.Text = item.Soyad;
                        tbxCep.Text = item.Cep;
                        tbxEposta.Text = item.Eposta;
                        tbxAdres.Text = item.Adres;
                        tbxSifre.Text = "***";
                        tbxMaas.Text = item.Maas.ToString();
                        tbxYillikIzin.Text = item.YillikIzin.ToString();
                        dtpDogumTarihi.Value = item.DogumTarihi.Value;
                        dtpIseGirisTarihi.Value = item.IseGiris.Date;
                        cbxKangrubu.Text = item.KanGrubu;
                        cbxOzelSaglik.Text = item.OzelSaglik;
                        cbxBolum.SelectedValue = item.BolumId;
                        cbxGorev.SelectedValue = item.GorevId;
                        cbxRol.SelectedValue = item.RolId;
                        cbxDurum.Text = item.Durum;

                        try
                        {
                            //vesikalık klasörü içinde sicil numarasına göre dosyayı kontrol ediyorum. 
                            DirectoryInfo di = new DirectoryInfo(hedefKlasor);
                            FileInfo[] files = di.GetFiles(item.SicilNo.ToString() + "*");
                            foreach (var fi in files)
                            {
                                //Çalışan fotoğrafını dosya yolundan çekerek picturebox içinde gösteriyorum.
                                pbxPersonelFoto.ImageLocation = hedefKlasor + fi.Name.ToString();
                                pbxPersonelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        


                       

                        tbxSicilNoAra.Text = "";
                    }

                }

            }

        }

        private void PersonelGuncelleUI_Load(object sender, EventArgs e)
        {
            BolumDal bolumDal = new BolumDal();
            cbxBolum.DataSource = bolumDal.TumunuListele();
            cbxBolum.DisplayMember = "BolumAdi";
            cbxBolum.ValueMember = "BolumId";

            GorevDal gorevDal = new GorevDal();
            cbxGorev.DataSource = gorevDal.TumunuListele();
            cbxGorev.DisplayMember = "GorevAdi";
            cbxGorev.ValueMember = "GorevId";

            RolDal rolDal = new RolDal();
            cbxRol.DataSource = rolDal.TumunuListele();
            cbxRol.DisplayMember = "RolAdi";
            cbxRol.ValueMember = "RolId";

            dtpDogumTarihi.Value = DateTime.Now;
            dtpIseGirisTarihi.Value = DateTime.Now;

            
            chbxSifreGuncelle.Visible = false;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (tbxDosyaAdi.Text != "" || tbxDosyaYolu.Text != "")
            {
                string kaynakDosyaYolu = tbxDosyaYolu.Text;
                string dosyaAdi = tbxDosyaAdi.Text;
                string dosyaUzantisi = Path.GetExtension(kaynakDosyaYolu);//uzantıyı alıyorum.

                try
                {
                    //vesikalık klasörü içinde sicil numarasına göre dosyayı aratıp siliyorum 
                    DirectoryInfo di = new DirectoryInfo(hedefKlasor);
                    FileInfo[] files = di.GetFiles(lblGelenSicilNo.Text + "*");
                    foreach (var fi in files)
                    {
                        File.Delete(Path.Combine((hedefKlasor), (fi.Name.ToString())));
                        
                    }

                   // kaynakdosyayolu seçilen belgenin yoludur, hedef klasor ana dizini gösteriyor. seçilen dosyayı sicil numarası adıyla kayıt ediyorum.
                    File.Copy(kaynakDosyaYolu, Path.Combine((hedefKlasor), (lblGelenSicilNo.Text + dosyaUzantisi)));

                    tbxDosyaAdi.Text = "";
                    tbxDosyaYolu.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (lblGelenSicilNo.Text == "" || lblGelenSicilNo.Text == null)
            {
                MessageBox.Show("Güncelleme için bir sicil numarası aratmanız gerekiyor.");
            }
            else if (tbxYillikIzin.Text=="" || lblGelenSicilNo.Text == null)
            {
                MessageBox.Show("Yıllık izin boş geçilemez.");
            }

            else
            {
                if (tbxSifre.Text=="") //şifre girmezse bir önceki şifreyi koruyorum.
                {
                    tbxSifre.Text = "***";
                }
                
                if (tbxSifre.Text!="***")
                {
                    MD5Sifreleme mD5Sifreleme = new MD5Sifreleme();
                    tbxSifre.Text= mD5Sifreleme.MD5Sifrele(tbxSifre.Text);
                }
                
                PersonelDal personelDal = new PersonelDal();
                personelDal.Guncelle(PersonelID,tbxTcNo.Text,tbxAd.Text, tbxSoyad.Text, tbxCep.Text, tbxEposta.Text, tbxAdres.Text, tbxSifre.Text,
                   Convert.ToDouble(tbxYillikIzin.Text),Convert.ToDouble(tbxMaas.Text), cbxOzelSaglik.Text, cbxKangrubu.Text,
                    Convert.ToInt32(cbxBolum.SelectedValue), Convert.ToInt32(cbxGorev.SelectedValue), Convert.ToInt32( cbxRol.SelectedValue), 
                    dtpDogumTarihi.Value.Date, dtpIseGirisTarihi.Value.Date,cbxDurum.Text);
                FormuTemizle();
                
                MessageBox.Show("Personel güncellendi!");

                //LOG YOLLUYORUM
                LogDal logDal = new LogDal();
                logDal.LogGonder("GÜNCELLEME", "PERSONEL YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);


            }

        }

        private void chbxSifreGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSifreGuncelle.Checked==true)
            {
                
                tbxSifre.ReadOnly = false;
                tbxSifre.Text = "";

            }
            else
            {
                
                tbxSifre.ReadOnly = true;
                tbxSifre.Text = "***";
            }
        }

        
    }
}
