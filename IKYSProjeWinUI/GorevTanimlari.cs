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
    public partial class GorevTanimlari : Form
    {
        internal int SessionId;

        public GorevTanimlari()
        {
            InitializeComponent();
        }

        

        private void GorevTanimlari_Load(object sender, EventArgs e)
        {
            GorevDal sorgula = new GorevDal();
            dgwGorevTanimlari.DataSource = sorgula.GorevListele();
        }
    }
}
