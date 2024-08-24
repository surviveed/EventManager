using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.CrudEvento
{
    public partial class FrmEvento : Form
    {
        private readonly EventoService _eventoService;
        private readonly TipoEventoService _tipoEventoService;

        public FrmEvento()
        {
            InitializeComponent();
            var connectionString = DatabaseConfig.connectionString;
            var tipoEventoRepository = new TipoEventoRepository(connectionString);
            _tipoEventoService = new TipoEventoService(tipoEventoRepository);

            var eventoRepository = new EventoRepository(connectionString);
            _eventoService = new EventoService(eventoRepository);

            LoadEventos();
            FillTipoEventoComboBox(cbTipoEvento);

            DataGridViewCustomizations.ApplyCustomizations(dataGridViewEventos);
        }

        private void LoadEventos()
        {
            var eventos = _eventoService.BuscarTodos();
            dataGridViewEventos.DataSource = eventos;
        }

        private void FillTipoEventoComboBox(ComboBox comboBox)
        {
            IEnumerable<TipoEventoDTO> tiposEvento = _tipoEventoService.BuscarTodos();
            comboBox.DataSource = tiposEvento;
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var eventoDto = new EventoDTO
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                TipoEventoId = Convert.ToInt32(cbTipoEvento.SelectedValue)
            };
            _eventoService.Inserir(eventoDto);
            LoadEventos();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEventos.SelectedRows[0];
                var eventoDto = (EventoDTO)selectedRow.DataBoundItem;

                eventoDto.Nome = txtNome.Text;
                eventoDto.Descricao = txtDescricao.Text;
                eventoDto.TipoEventoId = Convert.ToInt32(cbTipoEvento.SelectedValue);

                _eventoService.Atualizar(eventoDto);
                LoadEventos();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEventos.SelectedRows[0];
                var eventoDto = (EventoDTO)selectedRow.DataBoundItem;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _eventoService.Remover(eventoDto.Id);
                    LoadEventos();
                    ClearFields();
                }
            }
        }

        private void dataGridViewEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEventos.SelectedRows[0];
                var eventoDto = (EventoDTO)selectedRow.DataBoundItem;

                txtNome.Text = eventoDto.Nome;
                txtDescricao.Text = eventoDto.Descricao;
                cbTipoEvento.SelectedValue = eventoDto.TipoEventoId;
            }
        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            cbTipoEvento.SelectedIndex = -1;
        }
    }
}
