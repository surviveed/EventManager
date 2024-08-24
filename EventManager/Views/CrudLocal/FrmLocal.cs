using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.CrudLocal
{
    public partial class FrmLocal : Form
    {
        private readonly LocalService _localService;
        private readonly CidadeService _cidadeService;

        public FrmLocal()
        {
            InitializeComponent();
            _cidadeService = new CidadeService(new CidadeRepository());
            _localService = new LocalService(new LocalRepository());

            ConfigureMaterialListView();
            LoadLocais();
            FillCidadeComboBox(cbCidade);

            MaterialListViewCustomizations.ApplyCustomizations(materialListViewLocais);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewLocais.Size.Width / 6;
            materialListViewLocais.Columns.Add("ID", size);
            materialListViewLocais.Columns.Add("Nome", size);
            materialListViewLocais.Columns.Add("Capacidade", size);
            materialListViewLocais.Columns.Add("Endereço", size);
            materialListViewLocais.Columns.Add("Cidade", size);
            materialListViewLocais.Columns.Add("Observações", size);
        }

        private void LoadLocais()
        {
            materialListViewLocais.Items.Clear();
            var locais = _localService.BuscarTodos();

            foreach (var local in locais)
            {
                var listViewItem = new ListViewItem(local.Id.ToString())
                {
                    Tag = local
                };
                listViewItem.SubItems.Add(local.Nome);
                listViewItem.SubItems.Add(local.Capacidade.ToString());
                listViewItem.SubItems.Add(local.Endereco);
                listViewItem.SubItems.Add(local.CidadeDescricao);
                listViewItem.SubItems.Add(local.Observacoes);

                materialListViewLocais.Items.Add(listViewItem);
            }
        }

        private void FillCidadeComboBox(ComboBox comboBox)
        {
            IEnumerable<CidadeDTO> cidades = _cidadeService.BuscarTodos();
            comboBox.DataSource = cidades;
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var localDto = new LocalDTO
            {
                Nome = txtNome.Text,
                Capacidade = Convert.ToInt32(txtCapacidade.Text),
                Endereco = txtEndereco.Text,
                CidadeId = Convert.ToInt32(cbCidade.SelectedValue),
                Observacoes = txtObservacoes.Text
            };
            _localService.Inserir(localDto);
            LoadLocais();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewLocais.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewLocais.SelectedItems[0];
                var localDto = (LocalDTO)selectedItem.Tag;

                localDto.Nome = txtNome.Text;
                localDto.Capacidade = Convert.ToInt32(txtCapacidade.Text);
                localDto.Endereco = txtEndereco.Text;
                localDto.CidadeId = Convert.ToInt32(cbCidade.SelectedValue);
                localDto.Observacoes = txtObservacoes.Text;

                _localService.Atualizar(localDto);
                LoadLocais();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewLocais.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewLocais.SelectedItems[0];
                var localDto = (LocalDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _localService.Remover(localDto.Id);
                    LoadLocais();
                    ClearFields();
                }
            }
        }

        private void materialListViewLocais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewLocais.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewLocais.SelectedItems[0];
                var localDto = (LocalDTO)selectedItem.Tag;

                txtNome.Text = localDto.Nome;
                txtCapacidade.Text = localDto.Capacidade.ToString();
                txtEndereco.Text = localDto.Endereco;
                cbCidade.SelectedValue = localDto.CidadeId;
                txtObservacoes.Text = localDto.Observacoes;
            }
        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtCapacidade.Clear();
            txtEndereco.Clear();
            txtObservacoes.Clear();
            cbCidade.SelectedIndex = -1;
        }
    }
}
