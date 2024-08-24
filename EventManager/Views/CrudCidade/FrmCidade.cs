using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager.Views.CrudCidade
{
    public partial class FrmCidade : Form
    {
        private readonly CidadeService _cidadeService;
        private readonly UfService _ufService;

        public FrmCidade()
        {
            InitializeComponent();
            _ufService = new UfService(new UfRepository());
            _cidadeService = new CidadeService(new CidadeRepository());

            ConfigureMaterialListView();
            LoadCidades();
            FillUfComboBox(cbUf);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewCidades.Size.Width / 4;
            materialListViewCidades.Columns.Add("ID", size);
            materialListViewCidades.Columns.Add("Descrição", size);
            materialListViewCidades.Columns.Add("Código IBGE", size);
            materialListViewCidades.Columns.Add("UF", size);
        }

        private void LoadCidades()
        {
            materialListViewCidades.Items.Clear();
            var cidades = _cidadeService.BuscarTodos();

            foreach (var cidade in cidades)
            {
                var listViewItem = new ListViewItem(cidade.Id.ToString())
                {
                    Tag = cidade
                };
                listViewItem.SubItems.Add(cidade.Descricao);
                listViewItem.SubItems.Add(cidade.CodigoIbge.ToString());
                listViewItem.SubItems.Add(cidade.UfDescricao);

                materialListViewCidades.Items.Add(listViewItem);
            }
        }

        private void FillUfComboBox(ComboBox comboBox)
        {
            IEnumerable<UfDTO> ufs = _ufService.BuscarTodos();
            comboBox.DataSource = ufs;
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var cidadeDto = new CidadeDTO
            {
                Descricao = txtDescricao.Text,
                CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text),
                UfId = Convert.ToInt32(cbUf.SelectedValue)
            };
            _cidadeService.Inserir(cidadeDto);
            LoadCidades();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewCidades.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewCidades.SelectedItems[0];
                var cidadeDto = (CidadeDTO)selectedItem.Tag;

                cidadeDto.Descricao = txtDescricao.Text;
                cidadeDto.CodigoIbge = Convert.ToInt32(txtCodigoIbge.Text);
                cidadeDto.UfId = Convert.ToInt32(cbUf.SelectedValue);

                _cidadeService.Atualizar(cidadeDto);
                LoadCidades();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewCidades.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewCidades.SelectedItems[0];
                var cidadeDto = (CidadeDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _cidadeService.Remover(cidadeDto.Id);
                    LoadCidades();
                    ClearFields();
                }
            }
        }

        private void materialListViewCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewCidades.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewCidades.SelectedItems[0];
                var cidadeDto = (CidadeDTO)selectedItem.Tag;

                txtDescricao.Text = cidadeDto.Descricao;
                txtCodigoIbge.Text = cidadeDto.CodigoIbge.ToString();
                cbUf.SelectedValue = cidadeDto.UfId;
            }
        }

        private void ClearFields()
        {
            txtDescricao.Clear();
            txtCodigoIbge.Clear();
            cbUf.SelectedIndex = -1;
        }
    }
}
