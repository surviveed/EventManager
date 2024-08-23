using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EventManager.Views.CrudPais
{
    public partial class FrmPais : Form
    {

        private readonly PaisService _paisService;

        public FrmPais()
        {
            InitializeComponent();

            // Inicializar a conexão com o banco de dados
            var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=eventmanager";
            var paisRepository = new PaisRepository(connectionString);
            _paisService = new PaisService(paisRepository);

            // Carregar todos os países na lista ao iniciar o formulário
            LoadPaises();

            #region CUSTOMIZAÇÃO DO DATAGRID
            // Linhas alternadas
            dataGridViewPaises.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewPaises.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Linha selecionada
            dataGridViewPaises.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 125, 33);
            dataGridViewPaises.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewPaises.DefaultCellStyle.ForeColor = Color.FromArgb(75, 75, 75);

            // Bordas
            dataGridViewPaises.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Cabeçalho
            dataGridViewPaises.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);

            dataGridViewPaises.EnableHeadersVisualStyles = false; // Habilita a edição do cabeçalho

            dataGridViewPaises.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 84, 21);
            dataGridViewPaises.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion
        }

        private void LoadPaises()
        {
            var paises = _paisService.ObterTodos().ToList();
            dataGridViewPaises.DataSource = paises;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var paisDto = new PaisDTO
            {
                Descricao = txtDescricao.Text,
                CodigoIbge = int.Parse(txtCodigoIbge.Text)
            };

            _paisService.Adicionar(paisDto);
            LoadPaises();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPaises.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPaises.SelectedRows[0];
                var paisDto = (PaisDTO)selectedRow.DataBoundItem;

                paisDto.Descricao = txtDescricao.Text;
                paisDto.CodigoIbge = int.Parse(txtCodigoIbge.Text);

                _paisService.Atualizar(paisDto);
                LoadPaises();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPaises.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPaises.SelectedRows[0];
                var paisDto = (PaisDTO)selectedRow.DataBoundItem;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _paisService.Remover(paisDto.Id);
                    LoadPaises();
                    ClearFields();
                }
            }
        }


        private void dataGridViewPaises_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPaises.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPaises.SelectedRows[0];
                var paisDto = (PaisDTO)selectedRow.DataBoundItem;

                txtDescricao.Text = paisDto.Descricao;
                txtCodigoIbge.Text = paisDto.CodigoIbge.ToString();
            }
        }

        private void ClearFields()
        {
            txtDescricao.Text = string.Empty;
            txtCodigoIbge.Text = string.Empty;
        }
    }
}
