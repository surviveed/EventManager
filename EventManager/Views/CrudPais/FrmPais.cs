using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
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

            var paisRepository = new PaisRepository();
            _paisService = new PaisService(paisRepository);

            LoadPaises();

            DataGridViewCustomizations.ApplyCustomizations(dataGridViewPaises);
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

            _paisService.Inserir(paisDto);
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
