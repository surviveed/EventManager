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

            ConfigureMaterialListView();
            LoadUfs();
            FillPaisComboBox(cbPais);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewUfs.Size.Width / 3;
            materialListViewUfs.Columns.Add("ID", size);
            materialListViewUfs.Columns.Add("Descrição", size);
            materialListViewUfs.Columns.Add("Código IBGE", size);
            materialListViewUfs.Columns.Add("País", size);
        }

        private void LoadUfs()
        {
            materialListViewUfs.Items.Clear();
            var ufs = _ufService.BuscarTodos();

            foreach (var uf in ufs)
            {
                var listViewItem = new ListViewItem(uf.Id.ToString())
                {
                    Tag = uf
                };
                listViewItem.SubItems.Add(uf.Descricao);
                listViewItem.SubItems.Add(uf.CodigoIbge.ToString());
                listViewItem.SubItems.Add(uf.PaisDescricao);

                materialListViewUfs.Items.Add(listViewItem);
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewUfs.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUfs.SelectedItems[0];
                var ufDto = (UfDTO)selectedItem.Tag;

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
            if (materialListViewUfs.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUfs.SelectedItems[0];
                var ufDto = (UfDTO)selectedItem.Tag;

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

        private void materialListViewUfs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewUfs.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUfs.SelectedItems[0];
                var ufDto = (UfDTO)selectedItem.Tag;

                txtDescricao.Text = ufDto.Descricao;
                txtCodigoIbge.Text = ufDto.CodigoIbge.ToString();
                cbPais.SelectedValue = ufDto.PaisId;
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
            txtCodigoIbge.Clear();
            cbPais.SelectedIndex = -1;
        }
    }
}
