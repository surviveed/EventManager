using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.CrudUsuario
{
    public partial class FrmUsuario : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly PessoaService _pessoaService;

        public FrmUsuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioRepository());
            _pessoaService = new PessoaService(new PessoaRepository());
            FillPessoaComboBox(cbPessoa);
            ConfigureMaterialListView();
            LoadUsuarios();

            MaterialListViewCustomizations.ApplyCustomizations(materialListViewUsuarios);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewUsuarios.Size.Width / 4;
            materialListViewUsuarios.Columns.Add("ID", size);
            materialListViewUsuarios.Columns.Add("Nome", size);
            materialListViewUsuarios.Columns.Add("Email", size);
            materialListViewUsuarios.Columns.Add("Senha", size);
        }

        private void FillPessoaComboBox(ComboBox comboBox)
        {
            IEnumerable<PessoaDTO> pessoas = _pessoaService.BuscarTodos();
            comboBox.DataSource = pessoas;
            comboBox.DisplayMember = "nome";
            comboBox.ValueMember = "id";
        }

        private void LoadUsuarios()
        {
            materialListViewUsuarios.Items.Clear();
            var usuarios = _usuarioService.BuscarTodos();

            foreach (var usuario in usuarios)
            {
                var listViewItem = new ListViewItem(usuario.Id.ToString())
                {
                    Tag = usuario
                };
                listViewItem.SubItems.Add(usuario.Nome);
                listViewItem.SubItems.Add(usuario.Email);
                listViewItem.SubItems.Add(usuario.Senha); // Por questões de segurança, normalmente a senha não é exibida

                materialListViewUsuarios.Items.Add(listViewItem);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var usuarioDto = new UsuarioDTO
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Pessoa = _pessoaService.BuscarPorId(Convert.ToInt32(cbPessoa.SelectedValue))
            };
            _usuarioService.Inserir(usuarioDto);
            LoadUsuarios();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewUsuarios.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUsuarios.SelectedItems[0];
                var usuarioDto = (UsuarioDTO)selectedItem.Tag;

                usuarioDto.Nome = txtNome.Text;
                usuarioDto.Email = txtEmail.Text;
                usuarioDto.Senha = txtSenha.Text;

                _usuarioService.Atualizar(usuarioDto);
                LoadUsuarios();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewUsuarios.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUsuarios.SelectedItems[0];
                var usuarioDto = (UsuarioDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _usuarioService.Remover(usuarioDto.Id);
                    LoadUsuarios();
                    ClearFields();
                }
            }
        }

        private void materialListViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewUsuarios.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUsuarios.SelectedItems[0];
                var usuarioDto = (UsuarioDTO)selectedItem.Tag;

                txtNome.Text = usuarioDto.Nome;
                txtEmail.Text = usuarioDto.Email;
                txtSenha.Text = usuarioDto.Senha;
            }
        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }
    }
}
