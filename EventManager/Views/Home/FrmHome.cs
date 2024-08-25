using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using EventManager.Util;
using EventManager.Views.Details;
using EventManager.Views.HomeAdmin;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventManager.Views.Home
{
    public partial class FrmHome : Form
    {
        private readonly EventoService _eventoService;
        private readonly TipoEventoService _tipoEventoService;
        private UsuarioDTO _usuario;

        public FrmHome(UsuarioDTO usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            _tipoEventoService = new TipoEventoService(new TipoEventoRepository());
            _eventoService = new EventoService(new EventoRepository());

            LoadEventos();
            FillTipoEventoComboBox(cbFiltroTipoEvento);
            cbFiltroTipoEvento.SelectedIndex = -1;

            ConfigureMaterialListView();

            MaterialListViewCustomizations.ApplyCustomizations(materialListViewEventos);

            VerificarAdmin(usuario);
        }

        private void VerificarAdmin(UsuarioDTO usuario)
        {
            if (AuthService.VerificarAdmin(usuario))
            {
                btnAdmin.Visible = true;
            }
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmHomeAdmin frm = new FrmHomeAdmin();
            frm.Show();
        }

        private void txtLimparFiltros_Click(object sender, EventArgs e)
        {
            txtFiltroNome.Clear();
            cbFiltroTipoEvento.SelectedIndex = -1;
        }

        private void txtFiltroNome_TextChanged(object sender, EventArgs e)
        {
            FiltrarEventos();
        }

        private void cbFiltroTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEventos();
        }

        private void FiltrarEventos()
        {
            string nomeFiltro = txtFiltroNome.Text;
            int? tipoEventoIdFiltro = null;

            if (cbFiltroTipoEvento.SelectedValue != null && int.TryParse(cbFiltroTipoEvento.SelectedValue.ToString(), out int tipoEventoId))
            {
                tipoEventoIdFiltro = tipoEventoId > 0 ? tipoEventoId : (int?)null;
            }

            var eventosFiltrados = _eventoService.BuscarTodosPorNomeETipoDeEvento(nomeFiltro, tipoEventoIdFiltro);

            materialListViewEventos.Items.Clear();
            foreach (var evento in eventosFiltrados)
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

        private void materialListViewEventos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listView = sender as MaterialListView;
            if (listView.SelectedItems.Count > 0)
            {
                var selectedItem = listView.SelectedItems[0];
                var evento = (EventoDTO)selectedItem.Tag;

                FrmEventoDetalhes frmDetalhes = new FrmEventoDetalhes(evento, _usuario);
                frmDetalhes.ShowDialog(); 
            }
        }
    }
}
