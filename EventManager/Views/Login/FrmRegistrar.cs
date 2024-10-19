using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Windows.Forms;

namespace EventManager.Views.Login
{
    public partial class FrmRegistrar : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly PessoaService _pessoaService;

        public FrmRegistrar()
        {
            _usuarioService = new UsuarioService(new UsuarioRepository());
            _pessoaService = new PessoaService(new PessoaRepository());
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var pessoaDto = new PessoaDTO
            {
                Id = 0,
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                TipoPessoa = Entities.enums.TipoPessoa.PARTICIPANTE
            };
            _pessoaService.Inserir(pessoaDto);

            PessoaDTO pessoaComId = _pessoaService.BuscarPorCpf(txtCpf.Text);

            var usuarioDto = new UsuarioDTO
            {
                Id = 0,
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Pessoa = pessoaComId
            };
            _usuarioService.Inserir(usuarioDto);
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
