using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Windows.Forms;

namespace EventManager.Views.CrudPais
{
    public partial class FrmPais : Form
    {
        private readonly PaisService _paisService;

        public FrmPais()
        {
            InitializeComponent();
            ConfigureMaterialListView();
            _paisService = new PaisService(new PaisRepository());
            LoadPaises();
            MaterialListViewCustomizations.ApplyCustomizations(materialListViewPaises);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewPaises.Size.Width / 3;
            materialListViewPaises.Columns.Add("ID", size);
            materialListViewPaises.Columns.Add("Descrição", size);
            materialListViewPaises.Columns.Add("Código IBGE", size);
        }

        private void LoadPaises()
        {
            materialListViewPaises.Items.Clear();
            var paises = _paisService.BuscarTodos();

            foreach (var pais in paises)
            {
                var listViewItem = new ListViewItem(pais.Id.ToString())
                {
                    Tag = pais
                };
                listViewItem.SubItems.Add(pais.Descricao);
                listViewItem.SubItems.Add(pais.CodigoIbge.ToString());

                materialListViewPaises.Items.Add(listViewItem);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var paisDto = new PaisDTO
            {
                Descricao = txtDescricao.Text,
                CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text)
            };
            _paisService.Inserir(paisDto);
            LoadPaises();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewPaises.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPaises.SelectedItems[0];
                var paisDto = (PaisDTO)selectedItem.Tag;

                paisDto.Descricao = txtDescricao.Text;
                paisDto.CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text);

                _paisService.Atualizar(paisDto);
                LoadPaises();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewPaises.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPaises.SelectedItems[0];
                var paisDto = (PaisDTO)selectedItem.Tag;

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

        private void materialListViewPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewPaises.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewPaises.SelectedItems[0];
                var paisDto = (PaisDTO)selectedItem.Tag;

                txtDescricao.Text = paisDto.Descricao;
                txtCodigoIbge.Text = paisDto.CodigoIbge.ToString();
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
            txtCodigoIbge.Clear();
        }
    }
}
