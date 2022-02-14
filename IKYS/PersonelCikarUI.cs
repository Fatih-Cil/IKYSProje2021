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
    public partial class PersonelCikarUI : Form
    {
        public PersonelCikarUI()
        {
            InitializeComponent();
        }
        internal string hedefKlasor = "C:\\Doküman Yönetimi\\Personel Doküman\\VESİKALIK\\";
        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        private void PersonelCikarUI_Load(object sender, EventArgs e)
        {
            lblscno.Text = "";
            lblGSicilNo.Text = "";
            lblGAdSoyad.Text = "";
            pbxPersonelFoto.ImageLocation = "";
            gbxPersonelCikisOnay.Visible = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lblscno.Text = "";
            lblGSicilNo.Text = "";
            lblGAdSoyad.Text = "";
            pbxPersonelFoto.ImageLocation = "";
            gbxPersonelCikisOnay.Visible = false;
            if (tbxSicilNoAra.Text == "")
            {
                MessageBox.Show("Sicil numarası giriniz!");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                var calisan = personelDal.SicilNoAra(Convert.ToInt32(tbxSicilNoAra.Text));
                dgwPersonelCikar.DataSource = calisan;
                for (int i = 0; i < dgwPersonelCikar.ColumnCount; i++)
                {
                    dgwPersonelCikar.Columns[i].Visible = false;
                }
                dgwPersonelCikar.Columns["SicilNo"].Visible = true; dgwPersonelCikar.Columns["SicilNo"].HeaderText = "Sicil Numarası";
                dgwPersonelCikar.Columns["Ad"].Visible = true; dgwPersonelCikar.Columns["Ad"].HeaderText = "Personel Adı";
                dgwPersonelCikar.Columns["Soyad"].Visible = true; dgwPersonelCikar.Columns["Soyad"].HeaderText = "Personel Soyadı";
                dgwPersonelCikar.Columns["TcNo"].Visible = true; dgwPersonelCikar.Columns["TcNo"].HeaderText = "TC Numarası";
                dgwPersonelCikar.Columns["Durum"].Visible = true; dgwPersonelCikar.Columns["Durum"].HeaderText = "Durumu";
            }
        }

        private void dgwPersonelCikar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxPersonelCikisOnay.Visible = true;
            int PersonelId = Convert.ToInt32(dgwPersonelCikar.CurrentRow.Cells[0].Value.ToString());
            lblscno.Text = "Sicil No: ";
            lblGSicilNo.Text = dgwPersonelCikar.CurrentRow.Cells[1].Value.ToString();
            lblGAdSoyad.Text = "Ad Soyad: " + dgwPersonelCikar.CurrentRow.Cells[3].Value.ToString() + " " + dgwPersonelCikar.CurrentRow.Cells[4].Value.ToString();
            //vesikalık klasörü içinde sicil numarasına göre dosyayı kontrol ediyorum. 
            DirectoryInfo di = new DirectoryInfo(hedefKlasor);
            FileInfo[] files = di.GetFiles(dgwPersonelCikar.CurrentRow.Cells[1].Value.ToString() + "*");
            foreach (var fi in files)
            {
                //Çalışan fotoğrafını dosya yolundan çekerek picturebox içinde gösteriyorum.
                pbxPersonelFoto.ImageLocation = hedefKlasor + fi.Name.ToString();
                pbxPersonelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPersonelCikar_Click(object sender, EventArgs e)
        {
            if (chbxCikisiOnayla.Checked==false)
            {
                MessageBox.Show("Çıkış onayla kutucuğunu işaretleyiniz.");
            }
            else
            {
                PersonelDal personelDal = new PersonelDal();
                personelDal.PersonelCikis(Convert.ToInt32(lblGSicilNo.Text),dtpPersonelCikis.Value.Date,"PASİF");
                MessageBox.Show(lblGSicilNo.Text + " sicil numaralı çalışan " + dtpPersonelCikis.Value.Date + " tarihinde çıkışı yapıldı.");
                lblscno.Text = "";
                lblGSicilNo.Text = "";
                lblGAdSoyad.Text = "";
                dgwPersonelCikar.DataSource = "";
                pbxPersonelFoto.ImageLocation = "";
                gbxPersonelCikisOnay.Visible = false;
            }
        }
    }
}
