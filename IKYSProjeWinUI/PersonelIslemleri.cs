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
    public partial class PersonelIslemleri : Form
    {
        internal int SessionId;
        public int dgpersonelId = 0;
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelListeleAktif_Click(object sender, EventArgs e)
        {
            PersonelDal sorgula = new PersonelDal();
            dgwPersonelBilgileri.DataSource = sorgula.AktifPersonelListesi();
        }

        private void btnPersonelListelePasif_Click(object sender, EventArgs e)
        {
            PersonelDal sorgula = new PersonelDal();
            dgwPersonelBilgileri.DataSource = sorgula.PasifPersonelListesi();
        }

        private void btnPersonelListeleHepsi_Click(object sender, EventArgs e)
        {




            PersonelDal sorgula = new PersonelDal();
         dgwPersonelBilgileri.DataSource = sorgula.PersonelListeleHepsi();



        }

        public int SutunBosmu(int i) //datagridview içindeki hücrelerde boş yada null olan değer varsa program obje hatası vermemesi için kontrol ediyorum. 
        {
            if (dgwPersonelBilgileri.CurrentRow.Cells[i].Value == null || dgwPersonelBilgileri.CurrentRow.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwPersonelBilgileri.CurrentRow.Cells[i].Value.ToString()))
            {
                return 0;
            }
            else
            {
               return 1;

            }

        }

        private void dgwPersonelBilgileri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgpersonelId = Convert.ToInt32(dgwPersonelBilgileri.CurrentRow.Cells[0].Value.ToString());
           
            tbxSicilNo.Text = (SutunBosmu(1) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[1].Value.ToString());
            tbxTcNo.Text = (SutunBosmu(2) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[2].Value.ToString());
            tbxAdi.Text = (SutunBosmu(3) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[3].Value.ToString());
            tbxSoyad.Text = (SutunBosmu(4) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[4].Value.ToString());

            tbxDogumTarihi.Text = (SutunBosmu(5) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[5].Value.ToString());

            tbxCep1.Text=(SutunBosmu(6) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[6].Value.ToString());
           
            
            
            
            tbxCep2.Text = (SutunBosmu(7) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[7].Value.ToString());
            tbxEposta1.Text = (SutunBosmu(8) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[8].Value.ToString());

            tbxEposta2.Text = (SutunBosmu(9) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[9].Value.ToString());
            tbxAdres.Text = (SutunBosmu(10) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[10].Value.ToString());
            tbxSifre.Text = (SutunBosmu(11) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[11].Value.ToString());
            tbxYillikIzin.Text = (SutunBosmu(12) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[12].Value.ToString());

            tbxMaas.Text = (SutunBosmu(13) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[13].Value.ToString());
            cbxOzelSaglik.Text = (SutunBosmu(14) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[14].Value.ToString());
            cbxKanGrubu.Text = (SutunBosmu(15) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[15].Value.ToString());
            dtpIseGiris.Text = (SutunBosmu(16) == 0 ? "" : dgwPersonelBilgileri.CurrentRow.Cells[16].Value.ToString());

            dtpIstenCikis.Text = (SutunBosmu(17) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[17].Value.ToString());
            cbxDurum.Text = (SutunBosmu(18) == 0 ?  "" : dgwPersonelBilgileri.CurrentRow.Cells[18].Value.ToString());

            int bolumID=int.Parse(dgwPersonelBilgileri.CurrentRow.Cells[19].Value.ToString());
            BolumDal bolumsorgula = new BolumDal();
            cbxBolum.Items.Add(bolumsorgula.BolumAra(bolumID));
            cbxBolum.SelectedIndex=0;

            int gorevID = int.Parse(dgwPersonelBilgileri.CurrentRow.Cells[20].Value.ToString());
            GorevDal gorevsorgula = new GorevDal();
            cbxGorev.Items.Add(gorevsorgula.GorevAra(gorevID));
            cbxGorev.SelectedIndex = 0;

            int rolID = int.Parse(dgwPersonelBilgileri.CurrentRow.Cells[21].Value.ToString());
            RolDal rolsorgula = new RolDal();
            cbxRol.Items.Add(rolsorgula.RolAra(rolID));
            cbxRol.SelectedIndex = 0;
           
        }

        private void tbxYillikIzin_TabStopChanged(object sender, EventArgs e)
        {

            //if (tbxYillikIzin.Text!=digi)
            //{

            //}
            //if (System.Text.RegularExpressions.Regex.IsMatch(tbxYillikIzin.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    tbxYillikIzin.Text = tbxYillikIzin.Text.Remove(tbxYillikIzin.Text.Length - 1);
            //}
        }

        private void tbxYillikIzin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
