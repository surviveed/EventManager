using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.CrudCidade
{
    public partial class FrmCidade : Form
    {
        private readonly CidadeService _cidadeService;
        private readonly UfService _ufService;

        public FrmCidade()
        {
            InitializeComponent();
            // Inicializar a conexão com o banco de dados
            var connectionString = DatabaseConfig.connectionString;
            var ufRepository = new UfRepository(connectionString);
            _ufService = new UfService(ufRepository);

            var cidadeRepository = new CidadeRepository(connectionString);
            _cidadeService = new CidadeService(cidadeRepository);

            LoadCidades();
            FillUfComboBox(cbUf);

            DataGridViewCustomizations.ApplyCustomizations(dataGridViewCidades);
        }

        private void LoadCidades()
        {
            var cidades = _cidadeService.BuscarTodos();
            dataGridViewCidades.DataSource = cidades;
        }

        private void FillUfComboBox(ComboBox comboBox)
        {
            IEnumerable<UfDTO> ufs = _ufService.BuscarTodos();
            comboBox.DataSource = ufs;
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var cidadeDto = new CidadeDTO
            {
                Descricao = txtDescricao.Text,
                CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text),
                UfId = Convert.ToInt32(cbUf.SelectedValue)
            };
            _cidadeService.Inserir(cidadeDto);
            LoadCidades();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCidades.SelectedRows[0];
                var cidadeDto = (CidadeDTO)selectedRow.DataBoundItem;

                cidadeDto.Descricao = txtDescricao.Text;
                cidadeDto.CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text);
                cidadeDto.UfId = Convert.ToInt32(cbUf.SelectedValue);

                _cidadeService.Atualizar(cidadeDto);
                LoadCidades();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCidades.SelectedRows[0];
                var cidadeDto = (CidadeDTO)selectedRow.DataBoundItem;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _cidadeService.Remover(cidadeDto.Id);
                    LoadCidades();
                    ClearFields();
                }
            }
        }

        private void dataGridViewCidades_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCidades.SelectedRows[0];
                var cidadeDto = (CidadeDTO)selectedRow.DataBoundItem;

                txtDescricao.Text = cidadeDto.Descricao;
                txtCodigoIbge.Text = cidadeDto.CodigoIbge.ToString();
                cbUf.SelectedIndex = (int)selectedRow.Cells[3].Value - 1;
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
            txtCodigoIbge.Clear();
            cbUf.SelectedIndex = -1;
        }
    }
}
