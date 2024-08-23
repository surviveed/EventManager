using EventManager.Views.CrudCidade;
using EventManager.Views.CrudLocal;
using EventManager.Views.CrudPais;
using EventManager.Views.CrudUf;
using System;
using System.Windows.Forms;

namespace EventManager.Views.HomeAdmin
{
    public partial class FrmHomeAdmin : Form
    {
        public FrmHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais();
            frm.Show();
        }

        private void btnUfs_Click(object sender, EventArgs e)
        {
            FrmUf frm = new FrmUf();
            frm.Show();
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            FrmCidade frm = new FrmCidade();
            frm.Show();
        }

        private void btnLocais_Click(object sender, EventArgs e)
        {
            FrmLocal frm = new FrmLocal();
            frm.Show();
        }
    }
}
