using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Windows.Forms;

namespace EventManager.Views.CrudTipoEvento
{
    public partial class FrmTipoEvento : Form
    {
        private readonly TipoEventoService _tipoEventoService;

        public FrmTipoEvento()
        {
            InitializeComponent();
            _tipoEventoService = new TipoEventoService(new TipoEventoRepository());

            LoadTiposEvento();
            DataGridViewCustomizations.ApplyCustomizations(dataGridViewTiposEvento);
        }

        private void LoadTiposEvento()
        {
            var tiposEvento = _tipoEventoService.BuscarTodos();
            dataGridViewTiposEvento.DataSource = tiposEvento;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var tipoEventoDto = new TipoEventoDTO
            {
                Descricao = txtDescricao.Text
            };
            _tipoEventoService.Inserir(tipoEventoDto);
            LoadTiposEvento();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTiposEvento.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTiposEvento.SelectedRows[0];
                var tipoEventoDto = (TipoEventoDTO)selectedRow.DataBoundItem;

                tipoEventoDto.Descricao = txtDescricao.Text;

                _tipoEventoService.Atualizar(tipoEventoDto);
                LoadTiposEvento();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTiposEvento.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTiposEvento.SelectedRows[0];
                var tipoEventoDto = (TipoEventoDTO)selectedRow.DataBoundItem;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _tipoEventoService.Remover(tipoEventoDto.Id);
                    LoadTiposEvento();
                    ClearFields();
                }
            }
        }

        private void dataGridViewTipoEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTiposEvento.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTiposEvento.SelectedRows[0];
                var tipoEventoDto = (TipoEventoDTO)selectedRow.DataBoundItem;

                txtDescricao.Text = tipoEventoDto.Descricao;
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
        }
    }
}
