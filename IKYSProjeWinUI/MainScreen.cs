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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        public int personelId { get; set; }
        public string personelAdi { get; set; }
        public int personelRolId { get; set; }

        
        public void MenuKisitla(int rolId)
        {
            if (rolId == 2) //rol power user ise istenilen modüller görülmesi engelleniyor
            {
                kURUMSALToolStripMenuItem.Visible = false;
                yeniKayıtToolStripMenuItem.Visible = false;
                personelSilToolStripMenuItem.Visible = false;
                bordroOluşturToolStripMenuItem.Visible = false;
                lOGKONTROLToolStripMenuItem.Visible = false;
                kdekleToolStripMenuItem.Visible = false;
                kdsilToolStripMenuItem.Visible = false;
                pdekleToolStripMenuItem1.Visible = false;
                pdsilToolStripMenuItem1.Visible = false;
            }
        }

        private void Formgetir(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            
            panel1.Controls.Add(form);

            form.Show();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            kullanıcıToolStripMenuItem.Text = "Hoşgeldin "+personelAdi;
            
            MenuKisitla(personelRolId);
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şirketBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sirketwinform sirketwinform = new Sirketwinform();
            Formgetir(sirketwinform);
        }

        private void departmanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmanIslemleri departmanIslemleri = new DepartmanIslemleri();
            departmanIslemleri.SessionId = this.personelId;
            Formgetir(departmanIslemleri);
            
        }

        private void görevTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevTanimlari gorevTanimlari = new GorevTanimlari();
            gorevTanimlari.SessionId = this.personelId;
            Formgetir(gorevTanimlari);
        }

        private void rollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolTanimlari rolTanimlari = new RolTanimlari();
            rolTanimlari.SessionId = this.personelId;
            Formgetir(rolTanimlari);
            

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personelIslemleri = new PersonelIslemleri();
            personelIslemleri.SessionId = this.personelId;
            Formgetir(personelIslemleri);
        }
    }
}
