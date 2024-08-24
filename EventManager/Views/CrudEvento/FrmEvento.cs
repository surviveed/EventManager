using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            materialListViewEventos.Columns.Add("Id", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Nome", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Descrição", materialListViewEventos.Size.Width / 4);
            materialListViewEventos.Columns.Add("Tipo de Evento", materialListViewEventos.Size.Width / 4);

            CustomizarMaterialListView(materialListViewEventos);
        }

        private void LoadEventos()
        {
            var eventos = _eventoService.BuscarTodos();
            dataGridViewEventos.DataSource = eventos;

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
            listView.FullRowSelect = true;
            listView.GridLines = false;
            listView.View = View.Details;

            // Configurações Gerais
            listView.BackColor = Color.FromArgb(30, 30, 30); // Fundo cinza escuro
            listView.ForeColor = Color.White; // Texto branco
            listView.Font = new Font("Segoe UI", 10);

            // Linhas Alternadas
            listView.OwnerDraw = true;
            listView.DrawItem += (sender, e) =>
            {
                bool isSelected = e.Item.Selected;
                var backgroundColor = isSelected ? Color.FromArgb(50, 50, 50) : (e.ItemIndex % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(40, 40, 40));

                // Desenho do fundo das linhas
                e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

                // Desenho do texto
                TextRenderer.DrawText(e.Graphics, e.Item.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                // Adiciona uma borda inferior branca
                e.Graphics.DrawLine(new Pen(Color.White, 1), e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            };

            listView.DrawSubItem += (sender, e) =>
            {
                var subItem = e.SubItem;
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
                else
                {
                    var backgroundColor = e.ItemIndex % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(40, 40, 40);
                    e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
            };

            listView.DrawColumnHeader += (sender, e) =>
            {
                // Desenho do cabeçalho
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), e.Bounds); // Fundo do cabeçalho cinza escuro
                TextRenderer.DrawText(e.Graphics, e.Header.Text, new Font("Segoe UI", 10, FontStyle.Bold), e.Bounds, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

    }
}
