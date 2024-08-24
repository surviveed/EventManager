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

            ConfigureMaterialListView();
            LoadTiposEvento();
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewTiposEvento.Size.Width / 2;
            materialListViewTiposEvento.Columns.Add("ID", size);
            materialListViewTiposEvento.Columns.Add("Descrição", size);
        }

        private void LoadTiposEvento()
        {
            materialListViewTiposEvento.Items.Clear();
            var tiposEvento = _tipoEventoService.BuscarTodos();

            foreach (var tipoEvento in tiposEvento)
            {
                var listViewItem = new ListViewItem(tipoEvento.Id.ToString())
                {
                    Tag = tipoEvento
                };
                listViewItem.SubItems.Add(tipoEvento.Descricao);

                materialListViewTiposEvento.Items.Add(listViewItem);
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewTiposEvento.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewTiposEvento.SelectedItems[0];
                var tipoEventoDto = (TipoEventoDTO)selectedItem.Tag;

                tipoEventoDto.Descricao = txtDescricao.Text;

                _tipoEventoService.Atualizar(tipoEventoDto);
                LoadTiposEvento();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewTiposEvento.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewTiposEvento.SelectedItems[0];
                var tipoEventoDto = (TipoEventoDTO)selectedItem.Tag;

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

        private void materialListViewTiposEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewTiposEvento.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewTiposEvento.SelectedItems[0];
                var tipoEventoDto = (TipoEventoDTO)selectedItem.Tag;

                txtDescricao.Text = tipoEventoDto.Descricao;
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
        }
    }
}
