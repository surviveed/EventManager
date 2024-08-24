using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventManager.Views.CrudSessao
{
    public partial class FrmEventoNovo : Form
    {
        private readonly EventoService _eventoService;
        private readonly TipoEventoService _tipoEventoService;

        public FrmEventoNovo()
        {
            InitializeComponent();
            _tipoEventoService = new TipoEventoService(new TipoEventoRepository());
            _eventoService = new EventoService(new EventoRepository());

            LoadEventos();
            FillTipoEventoComboBox(cbTipoEvento);

            //DataGridViewCustomizations.ApplyCustomizations(dataGridViewEventos);

            materialListViewEventos.Columns.Add("Id", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Nome", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Descrição", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Tipo de Evento", materialListViewEventos.Size.Width / 4);

            CustomizarMaterialListView(materialListViewEventos);
        }

        private void LoadEventos()
        {
            var eventos = _eventoService.BuscarTodos();
            //dataGridViewEventos.DataSource = eventos;

            materialListViewEventos.Items.Clear();
            foreach (var evento in eventos)
            {
                var listItem = new ListViewItem(evento.Id.ToString());
                listItem.SubItems.Add(evento.Nome);
                listItem.SubItems.Add(evento.Descricao);
                listItem.SubItems.Add(evento.TipoEventoDescricao);
                listItem.Tag = evento; // Armazene o DTO completo para facilitar a edição e exclusão
                materialListViewEventos.Items.Add(listItem);
            }
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

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            cbTipoEvento.SelectedIndex = -1;
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

        private void CustomizarMaterialListView(MaterialListView listView)
        {
            listView.Font = new Font("Segoe UI", 10);

            listView.DrawSubItem += (sender, e) =>
            {
                var subItem = e.SubItem;
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(92, 173, 255)), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
                else
                {
                    var backgroundColor = e.ItemIndex % 2 == 0 ? Color.FromArgb(245, 245, 245) : Color.FromArgb(230, 230, 230);
                    e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
            };
        }

        private void materialListViewEventos_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
