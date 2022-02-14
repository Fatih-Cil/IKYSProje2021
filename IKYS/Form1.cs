using IKYS.Business;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisManager girisManager = new GirisManager();
            int sonuc=girisManager.KontrolEt(tbxTcNo.Text, tbxSifre.Text); //girilen bilgileri kontrol için methoda iletiliyor
            if (sonuc==1)
            {
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("INSAN KAYNAKLARI YÖNETİM SİSTEMİ PROJE ÖDEVİ\n" +
                "Hazırlayan: Fatih Çil\n"+"Numara: 192132180");
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
    }
}
