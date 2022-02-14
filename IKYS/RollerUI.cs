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
    public partial class RollerUI : Form
    {
        public RollerUI()
        {
            InitializeComponent();
        }
        internal int AktifKullaniciID=0;
        private void RollerUI_Load(object sender, EventArgs e)
        {
            //form yüklenirken roldal sınıfından nesne üretilip datagride aktarılıyor.
            RolDal rolDal = new RolDal();
            dgwRoller.DataSource=rolDal.TumunuListele();
            //gösterilmesini istemediğim sütunları gizliyorum.
            for (int i = 0; i < dgwRoller.ColumnCount; i++)
            {
                dgwRoller.Columns[i].Visible = false;
            }
            dgwRoller.Columns["RolAdi"].Visible = true; dgwRoller.Columns["RolAdi"].HeaderText = "Rol Adı";
            dgwRoller.Columns["RolAciklama"].Visible = true; dgwRoller.Columns["RolAciklama"].HeaderText = "Açıklama";
           }
    }
}
