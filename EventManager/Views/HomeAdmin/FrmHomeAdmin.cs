using EventManager.Views.CrudCidade;
using EventManager.Views.CrudEvento;
using EventManager.Views.CrudLocal;
using EventManager.Views.CrudPais;
using EventManager.Views.CrudPessoa;
using EventManager.Views.CrudSessao;
using EventManager.Views.CrudTipoEvento;
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

        private void btnTiposEvento_Click(object sender, EventArgs e)
        {
            FrmTipoEvento frm = new FrmTipoEvento();
            frm.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            FrmEvento frm = new FrmEvento();
            frm.Show();
        }

        private void btnSessoes_Click(object sender, EventArgs e)
        {
            FrmEventoNovo frm = new FrmEventoNovo();
            frm.Show();
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            FrmPessoa frm = new FrmPessoa();
            frm.Show();
        }
    }
}
