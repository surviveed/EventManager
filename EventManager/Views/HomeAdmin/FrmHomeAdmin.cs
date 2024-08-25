using EventManager.Views.CrudAvaliacao;
using EventManager.Views.CrudCidade;
using EventManager.Views.CrudLocal;
using EventManager.Views.CrudPais;
using EventManager.Views.CrudPessoa;
using EventManager.Views.CrudSessao;
using EventManager.Views.CrudTipoEvento;
using EventManager.Views.CrudUf;
using EventManager.Views.CrudUsuario;
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
            FrmPais f = new FrmPais();
            f.Show();
        }

        private void btnUfs_Click(object sender, EventArgs e)
        {
            FrmUf f = new FrmUf();
            f.Show();
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            FrmCidade f = new FrmCidade();
            f.Show();
        }

        private void btnLocais_Click(object sender, EventArgs e)
        {
            FrmLocal f = new FrmLocal();
            f.Show();
        }

        private void btnTiposDeEventos_Click(object sender, EventArgs e)
        {
            FrmTipoEvento f = new FrmTipoEvento();
            f.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            FrmEvento f = new FrmEvento();
            f.Show();
        }

        private void btnSessoes_Click(object sender, EventArgs e)
        {
            FrmSessao f = new FrmSessao();
            f.Show();
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            FrmAvaliacao f = new FrmAvaliacao();
            f.Show();
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            FrmPessoa f = new FrmPessoa();
            f.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();
        }
    }
}
