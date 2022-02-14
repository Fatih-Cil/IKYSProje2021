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
    public partial class PersonelRaporlamaUI : Form
    {
        public PersonelRaporlamaUI()
        {
            InitializeComponent();
        }

        public int AktifKullaniciID = 0;
        public string AktifKullaniciAdi;
        private void PersonelRaporlamaUI_Load(object sender, EventArgs e)
        {
            PersonelDal personelDal = new PersonelDal();
            cbxSicilNo.DataSource = personelDal.TumunuListele("AKTİF");
            cbxSicilNo.DisplayMember = "SicilNo";
            cbxSicilNo.ValueMember = "SicilNo";
        }

        private void cbxSicilNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxBolum.Text = "";
            tbxAylikMaliyet.Text = "";
            tbxYillikMaliyet.Text = "";
            tbxKanGrubu.Text = "";
            tbxToplamKanGrubu.Text = ""
;
            try
            {
                int maas = 0;

                PersonelDal personelDal = new PersonelDal();
                var personel = personelDal.SicilNoAra(Convert.ToInt32(cbxSicilNo.SelectedValue), "AKTİF");
                foreach (var item in personel)
                {
                    maas = Convert.ToInt32(item.Maas);

                    BolumDal bolumDal = new BolumDal();
                    Bolum bolumadi = bolumDal.BolumAdiGetir(item.BolumId);
                    tbxBolum.Text = bolumadi.BolumAdi.ToString();
                    tbxKanGrubu.Text = item.KanGrubu.ToString();
                    tbxAylikMaliyet.Text = maas.ToString();
                    tbxYillikMaliyet.Text = (maas * 12).ToString();

                    var kan = personelDal.KanGrubuAra(tbxKanGrubu.Text, "AKTİF");
                    tbxToplamKanGrubu.Text = kan.Count.ToString();
                    dgwKGListesi.DataSource = kan;
                    for (int i = 0; i < dgwKGListesi.ColumnCount; i++)
                    {
                        dgwKGListesi.Columns[i].Visible = false;
                    }
                    dgwKGListesi.Columns["SicilNo"].Visible = true; dgwKGListesi.Columns["SicilNo"].HeaderText = "Sicil No";
                    dgwKGListesi.Columns["TcNo"].Visible = true; dgwKGListesi.Columns["TcNo"].HeaderText = "TC No";
                    dgwKGListesi.Columns["Ad"].Visible = true; dgwKGListesi.Columns["Ad"].HeaderText = "Adı";
                    dgwKGListesi.Columns["Soyad"].Visible = true; dgwKGListesi.Columns["Soyad"].HeaderText = "Soyadı";
                    dgwKGListesi.Columns["KanGrubu"].Visible = true; dgwKGListesi.Columns["KanGrubu"].HeaderText = "Kan Grubu";
                    dgwKGListesi.Columns["Durum"].Visible = true; dgwKGListesi.Columns["Durum"].HeaderText = "Durum";

                }

            }
            catch
            {


            }


        }

    }
}
