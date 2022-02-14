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
    public partial class DepartmanIslemleri : Form
    {
        internal int SessionId;

        public DepartmanIslemleri()
        {
            InitializeComponent();
        }

        private void DepartmanIslemleri_Load(object sender, EventArgs e)
        {
            BolumDal sorgula = new BolumDal();
            dgwDepartman.DataSource = sorgula.BolumListele();

        }
    }
}
