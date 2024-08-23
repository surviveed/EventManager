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
            // Inicializar a conexão com o banco de dados
            var connectionString = DatabaseConfig.connectionString;
            var cidadeRepository = new CidadeRepository(connectionString);
            _cidadeService = new CidadeService(cidadeRepository);

            var localRepository = new LocalRepository(connectionString);
            _localService = new LocalService(localRepository);

            LoadLocais();
            FillCidadeComboBox(cbCidade);

            DataGridViewCustomizations.ApplyCustomizations(dataGridViewLocais);
        }

        private void LoadLocais()
        {
            var locais = _localService.BuscarTodos();
            dataGridViewLocais.DataSource = locais;
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
                Observacoes = txtObservacoes.Text,
                CidadeId = Convert.ToInt32(cbCidade.SelectedValue)
            };
            _localService.Inserir(localDto);
            LoadLocais();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocais.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewLocais.SelectedRows[0];
                var localDto = (LocalDTO)selectedRow.DataBoundItem;

                localDto.Nome = txtNome.Text;
                localDto.Capacidade = Convert.ToInt32(txtCapacidade.Text);
                localDto.Endereco = txtEndereco.Text;
                localDto.Observacoes = txtObservacoes.Text;
                localDto.CidadeId = Convert.ToInt32(cbCidade.SelectedValue);

                _localService.Atualizar(localDto);
                LoadLocais();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocais.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewLocais.SelectedRows[0];
                var localDto = (LocalDTO)selectedRow.DataBoundItem;

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

        private void dataGridViewLocais_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLocais.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewLocais.SelectedRows[0];
                var localDto = (LocalDTO)selectedRow.DataBoundItem;

                txtNome.Text = localDto.Nome;
                txtCapacidade.Text = localDto.Capacidade.ToString();
                txtEndereco.Text = localDto.Endereco;
                txtObservacoes.Text = localDto.Observacoes;
                cbCidade.SelectedIndex = (int)selectedRow.Cells[5].Value - 1;
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
