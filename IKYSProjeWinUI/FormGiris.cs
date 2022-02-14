using IKYSProjeWinUI.Business;
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
    public partial class FormGiris : Form
    {

        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisKontrol girisKontrol = new GirisKontrol();
            int durum = girisKontrol.KontrolEt(tbxTcNo.Text, tbxSifre.Text);
            if (durum == 1)
            {
                this.Hide();
            }
            else if (durum == 3)
            {
                MessageBox.Show("Giriş Yetkiniz yok!");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }



        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
