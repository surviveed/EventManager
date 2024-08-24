using EventManager.DTOs;
using EventManager.Entities.enums;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EventManager.Views.CrudPessoa
{
    public partial class FrmPessoa : Form
    {
        private readonly PessoaService _pessoaService;

        public FrmPessoa()
        {
            InitializeComponent();
            _pessoaService = new PessoaService(new PessoaRepository());
            LoadPessoas();

            ConfigureMaterialListView();
            FillTipoPessoaComboBox();
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewPessoas.Size.Width / 4;
            materialListViewPessoas.Columns.Add("ID", size);
            materialListViewPessoas.Columns.Add("Nome", size);
            materialListViewPessoas.Columns.Add("CPF", size);
            materialListViewPessoas.Columns.Add("Tipo Pessoa", size);
        }

        private void LoadPessoas()
        {
            materialListViewPessoas.Items.Clear();
            var pessoas = _pessoaService.BuscarTodos();

            foreach (var pessoa in pessoas)
            {
                var listViewItem = new ListViewItem(pessoa.Id.ToString())
                {
                    Tag = pessoa
                };
                listViewItem.SubItems.Add(pessoa.Nome);
                listViewItem.SubItems.Add(pessoa.Cpf);
                listViewItem.SubItems.Add(pessoa.TipoPessoa.ToString());

                materialListViewPessoas.Items.Add(listViewItem);
            }
        }

        private void FillTipoPessoaComboBox()
        {
            cbTipoPessoa.DataSource = Enum.GetValues(typeof(TipoPessoa))
                                          .Cast<TipoPessoa>()
                                          .Select(t => t.ToString())
                                          .ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoaDto = new PessoaDTO
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                TipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), cbTipoPessoa.SelectedItem.ToString())
            };
            _pessoaService.Inserir(pessoaDto);
            LoadPessoas();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewPessoas.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPessoas.SelectedItems[0];
                var pessoaDto = (PessoaDTO)selectedItem.Tag;

                pessoaDto.Nome = txtNome.Text;
                pessoaDto.Cpf = txtCpf.Text;
                pessoaDto.TipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), cbTipoPessoa.SelectedItem.ToString());

                _pessoaService.Atualizar(pessoaDto);
                LoadPessoas();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewPessoas.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPessoas.SelectedItems[0];
                var pessoaDto = (PessoaDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _pessoaService.Remover(pessoaDto.Id);
                    LoadPessoas();
                    ClearFields();
                }
            }
        }

        private void materialListViewPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewPessoas.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPessoas.SelectedItems[0];
                var pessoaDto = (PessoaDTO)selectedItem.Tag;

                txtNome.Text = pessoaDto.Nome;
                txtCpf.Text = pessoaDto.Cpf;
                cbTipoPessoa.SelectedItem = pessoaDto.TipoPessoa.ToString();
            }
        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtCpf.Clear();
            cbTipoPessoa.SelectedIndex = -1;
        }
    }
}
