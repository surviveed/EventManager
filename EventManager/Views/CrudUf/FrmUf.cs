using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventManager.Views.CrudUf
{
    public partial class FrmUf : Form
    {
        private readonly UfService _ufService;
        private readonly PaisService _paisService;

        public FrmUf()
        {
            InitializeComponent();
            // Inicializar a conexão com o banco de dados
            var connectionString = DatabaseConfig.connectionString;
            var ufRepository = new UfRepository(connectionString);
            _ufService = new UfService(ufRepository);

            var paisRepository = new PaisRepository(connectionString);
            _paisService = new PaisService(paisRepository);
            
            LoadUfs();
            FillPaisComboBox(cbPais);

            #region CUSTOMIZAÇÃO DO DATAGRID
            // Linhas alternadas
            dataGridViewUfs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewUfs.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Linha selecionada
            dataGridViewUfs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 125, 33);
            dataGridViewUfs.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewUfs.DefaultCellStyle.ForeColor = Color.FromArgb(75, 75, 75);

            // Bordas
            dataGridViewUfs.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Cabeçalho
            dataGridViewUfs.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);

            dataGridViewUfs.EnableHeadersVisualStyles = false; // Habilita a edição do cabeçalho

            dataGridViewUfs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 84, 21);
            dataGridViewUfs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion
        }

        private void LoadUfs()
        {
            var ufs = _ufService.BuscarTodos();
            dataGridViewUfs.DataSource = ufs;
        }

        private void FillPaisComboBox(ComboBox comboBox)
        {
            IEnumerable<PaisDTO> paises = _paisService.ObterTodos();
            comboBox.DataSource = paises;
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var ufDto = new UfDTO
            {
                Descricao = txtDescricao.Text,
                CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text),
                PaisId = Convert.ToInt32(cbPais.SelectedValue)
            };
            _ufService.Inserir(ufDto);
            LoadUfs();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUfs.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUfs.SelectedRows[0];
                var ufDto = (UfDTO)selectedRow.DataBoundItem;

                ufDto.Descricao = txtDescricao.Text;
                ufDto.CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text);
                ufDto.PaisId = Convert.ToInt32(cbPais.SelectedValue);

                _ufService.Atualizar(ufDto);
                LoadUfs();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUfs.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUfs.SelectedRows[0];
                var ufDto = (UfDTO)selectedRow.DataBoundItem;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _ufService.Remover(ufDto.Id);
                    LoadUfs();
                    ClearFields();
                }
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
            txtCodigoIbge.Clear();
            cbPais.SelectedIndex = -1;
        }

        private void dataGridViewUfs_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUfs.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUfs.SelectedRows[0];
                var ufDto = (UfDTO)selectedRow.DataBoundItem;

                txtDescricao.Text = ufDto.Descricao;
                txtCodigoIbge.Text = ufDto.CodigoIbge.ToString();
                cbPais.SelectedIndex = (int)selectedRow.Cells[3].Value - 1;
            }
        }
    }
}
