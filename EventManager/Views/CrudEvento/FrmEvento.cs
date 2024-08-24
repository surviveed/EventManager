using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.CrudSessao
{
    public partial class FrmEvento : Form
    {
        private readonly EventoService _eventoService;
        private readonly TipoEventoService _tipoEventoService;

        public FrmEvento()
        {
            InitializeComponent();
            _tipoEventoService = new TipoEventoService(new TipoEventoRepository());
            _eventoService = new EventoService(new EventoRepository());

            LoadEventos();
            FillTipoEventoComboBox(cbTipoEvento);

            ConfigureMaterialListView();

            MaterialListViewCustomizations.ApplyCustomizations(materialListViewEventos);
        }

        private void LoadEventos()
        {
            var eventos = _eventoService.BuscarTodos();

            materialListViewEventos.Items.Clear();
            foreach (var evento in eventos)
            {
                var listItem = new ListViewItem(evento.Id.ToString());
                listItem.SubItems.Add(evento.Nome);
                listItem.SubItems.Add(evento.Descricao);
                listItem.SubItems.Add(evento.TipoEventoDescricao);
                listItem.SubItems.Add(evento.MediaAvaliacoes.ToString() != "NaN" ? evento.MediaAvaliacoes.ToString("0.0") : "0.0");
                listItem.Tag = evento; 
                materialListViewEventos.Items.Add(listItem);
            }
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewEventos.Size.Width / 5;
            materialListViewEventos.Columns.Add("ID", size);
            materialListViewEventos.Columns.Add("Nome", size);
            materialListViewEventos.Columns.Add("Descrição", size);
            materialListViewEventos.Columns.Add("Tipo de Evento", size);
            materialListViewEventos.Columns.Add("Média Avaliações", size);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewEventos.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewEventos.SelectedItems[0];
                var eventoDto = (EventoDTO)selectedItem.Tag;

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
            if (materialListViewEventos.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewEventos.SelectedItems[0];
                var eventoDto = (EventoDTO)selectedItem.Tag;

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

        private void materialListViewEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewEventos.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewEventos.SelectedItems[0];
                var eventoDto = (EventoDTO)selectedItem.Tag;

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
