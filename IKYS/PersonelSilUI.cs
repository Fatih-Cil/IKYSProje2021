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
    public partial class PersonelSilUI : Form
    {
        public PersonelSilUI()
        {
            InitializeComponent();
        }
        internal string hedefKlasor = "C:\\Doküman Yönetimi\\Personel Doküman\\VESİKALIK\\";
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        private void btnAra_Click(object sender, EventArgs e)
        {
            lblscno.Text = "";
            lblGSicilNo.Text = "";
            lblGAdSoyad.Text = "";
            pbxPersonelFoto.ImageLocation = "";
            gbxPersonelSilOnay.Visible = false;
            if (tbxSicilNoAra.Text == "")
            {
                MessageBox.Show("Sicil numarası giriniz!");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                var calisan = personelDal.SicilNoAra(Convert.ToInt32(tbxSicilNoAra.Text));
                dgwPersonelSil.DataSource = calisan;
                for (int i = 0; i < dgwPersonelSil.ColumnCount; i++)
                {
                    dgwPersonelSil.Columns[i].Visible = false;
                }
                dgwPersonelSil.Columns["SicilNo"].Visible = true; dgwPersonelSil.Columns["SicilNo"].HeaderText = "Sicil Numarası";
                dgwPersonelSil.Columns["Ad"].Visible = true; dgwPersonelSil.Columns["Ad"].HeaderText = "Personel Adı";
                dgwPersonelSil.Columns["Soyad"].Visible = true; dgwPersonelSil.Columns["Soyad"].HeaderText = "Personel Soyadı";
                dgwPersonelSil.Columns["TcNo"].Visible = true; dgwPersonelSil.Columns["TcNo"].HeaderText = "TC Numarası";
                dgwPersonelSil.Columns["Durum"].Visible = true; dgwPersonelSil.Columns["Durum"].HeaderText = "Durumu";
            }

        }

        private void dgwPersonelSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            gbxPersonelSilOnay.Visible = true;
            int PersonelId = Convert.ToInt32(dgwPersonelSil.CurrentRow.Cells[0].Value.ToString());
            lblscno.Text = "Sicil No: ";
            lblGSicilNo.Text = dgwPersonelSil.CurrentRow.Cells[1].Value.ToString();
            lblGAdSoyad.Text = "Ad Soyad: " + dgwPersonelSil.CurrentRow.Cells[3].Value.ToString() + " " + dgwPersonelSil.CurrentRow.Cells[4].Value.ToString();
            //vesikalık klasörü içinde sicil numarasına göre dosyayı kontrol ediyorum. 
            DirectoryInfo di = new DirectoryInfo(hedefKlasor);
            FileInfo[] files = di.GetFiles(dgwPersonelSil.CurrentRow.Cells[1].Value.ToString() + "*");
            foreach (var fi in files)
            {
                //Çalışan fotoğrafını dosya yolundan çekerek picturebox içinde gösteriyorum.
                pbxPersonelFoto.ImageLocation = hedefKlasor + fi.Name.ToString();
                pbxPersonelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void PersonelSilUI_Load(object sender, EventArgs e)
        {
            lblscno.Text = "";
            lblGSicilNo.Text = "";
            lblGAdSoyad.Text = "";
            pbxPersonelFoto.ImageLocation = "";
            gbxPersonelSilOnay.Visible = false;
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (chbxSilmeyiOnayla.Checked == false)
            {
                MessageBox.Show("Silmeyi onaylayı işaretleyiniz.");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                personelDal.PersonelSil(Convert.ToInt32(lblGSicilNo.Text));
               
                //vesikalık klasörü içinde sicil numarasına göre dosyayı aratıp siliyorum 
                DirectoryInfo di = new DirectoryInfo(hedefKlasor);
                FileInfo[] files = di.GetFiles(dgwPersonelSil.CurrentRow.Cells[1].Value.ToString() + "*");
                foreach (var fi in files)
                {
                    File.Delete(Path.Combine((hedefKlasor), (fi.Name.ToString())));

                }
                MessageBox.Show(lblGSicilNo.Text + " sicil numaralı personel silindi.");

                //LOG YOLLUYORUM
                LogDal logDal = new LogDal();
                logDal.LogGonder("SİLME", "PERSONEL YÖNETİMİ", AktifKullaniciAdi, AktifKullaniciID);

                lblscno.Text = "";
                lblGSicilNo.Text = "";
                lblGAdSoyad.Text = "";
                pbxPersonelFoto.ImageLocation = "";
                gbxPersonelSilOnay.Visible = false;
                tbxSicilNoAra.Text = "";
                dgwPersonelSil.DataSource = "";
            }
        }
    }
}
