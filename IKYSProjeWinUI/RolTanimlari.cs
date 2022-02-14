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
    public partial class RolTanimlari : Form
    {
        internal int SessionId;

        public RolTanimlari()
        {
            InitializeComponent();
        }

        private void RolTanimlari_Load(object sender, EventArgs e)
        {
            RolDal sorgula = new RolDal();
            dgwRolTanimlari.DataSource = sorgula.RolListele();
            

        }
    }
}
