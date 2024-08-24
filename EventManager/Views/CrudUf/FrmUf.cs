using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
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
            _ufService = new UfService(new UfRepository());
            _paisService = new PaisService(new PaisRepository());
            
            LoadUfs();
            FillPaisComboBox(cbPais);

            DataGridViewCustomizations.ApplyCustomizations(dataGridViewUfs);
        }

        private void LoadUfs()
        {
            var ufs = _ufService.BuscarTodos();
            dataGridViewUfs.DataSource = ufs;
        }

        private void FillPaisComboBox(ComboBox comboBox)
        {
            IEnumerable<PaisDTO> paises = _paisService.BuscarTodos();
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
