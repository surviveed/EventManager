using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EventManager.Views.CrudSessao
{
    public partial class FrmSessao : Form
    {
        private readonly SessaoService _sessaoService;
        private readonly EventoService _eventoService;
        private readonly LocalService _localService;

        public FrmSessao()
        {
            InitializeComponent();
            _sessaoService = new SessaoService(new SessaoRepository(), new PessoaRepository());
            _eventoService = new EventoService(new EventoRepository());
            _localService = new LocalService(new LocalRepository());
            LoadSessoes();

            ConfigureMaterialListView();
            FillComboBoxes();

            MaterialListViewCustomizations.ApplyCustomizations(materialListViewSessoes);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewSessoes.Size.Width / 5;
            materialListViewSessoes.Columns.Add("ID", size);
            materialListViewSessoes.Columns.Add("Data Início", size);
            materialListViewSessoes.Columns.Add("Data Fim", size);
            materialListViewSessoes.Columns.Add("Evento", size);
            materialListViewSessoes.Columns.Add("Local", size);
        }

        private void LoadSessoes()
        {
            materialListViewSessoes.Items.Clear();
            var sessoes = _sessaoService.BuscarTodos();

            foreach (var sessao in sessoes)
            {
                var listViewItem = new ListViewItem(sessao.Id.ToString())
                {
                    Tag = sessao
                };
                listViewItem.SubItems.Add(sessao.DataInicio.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(sessao.DataFim.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(sessao.EventoNome);
                listViewItem.SubItems.Add(sessao.LocalNome);

                materialListViewSessoes.Items.Add(listViewItem);
            }
        }

        private void FillComboBoxes()
        {
            // Preencher os ComboBoxes com Eventos e Locais disponíveis (supondo que esses métodos existam)
            cbEvento.DataSource = _eventoService.BuscarTodos()
                                               .Select(e => new { e.Id, e.Nome })
                                               .ToList();
            cbEvento.DisplayMember = "nome";
            cbEvento.ValueMember = "id";

            cbLocal.DataSource = _localService.BuscarTodos()
                                               .Select(l => new { l.Id, l.Nome })
                                               .ToList();
            cbLocal.DisplayMember = "nome";
            cbLocal.ValueMember = "id";
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var sessaoDto = new SessaoDTO
            {
                DataInicio = dtpDataInicio.Value,
                DataFim = dtpDataFim.Value,
                EventoId = (int)cbEvento.SelectedValue,
                LocalId = (int)cbLocal.SelectedValue
            };
            _sessaoService.Inserir(sessaoDto);
            LoadSessoes();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewSessoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewSessoes.SelectedItems[0];
                var sessaoDto = (SessaoDTO)selectedItem.Tag;

                sessaoDto.DataInicio = dtpDataInicio.Value;
                sessaoDto.DataFim = dtpDataFim.Value;
                sessaoDto.EventoId = (int)cbEvento.SelectedValue;
                sessaoDto.LocalId = (int)cbLocal.SelectedValue;

                _sessaoService.Atualizar(sessaoDto);
                LoadSessoes();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewSessoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewSessoes.SelectedItems[0];
                var sessaoDto = (SessaoDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _sessaoService.Remover(sessaoDto.Id);
                    LoadSessoes();
                    ClearFields();
                }
            }
        }

        private void materialListViewSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewSessoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewSessoes.SelectedItems[0];
                var sessaoDto = (SessaoDTO)selectedItem.Tag;

                dtpDataInicio.Value = sessaoDto.DataInicio;
                dtpDataFim.Value = sessaoDto.DataFim;
                cbEvento.SelectedValue = sessaoDto.EventoId;
                cbLocal.SelectedValue = sessaoDto.LocalId;
            }
        }

        private void ClearFields()
        {
            dtpDataInicio.Value = DateTime.Now;
            dtpDataFim.Value = DateTime.Now;
            cbEvento.SelectedIndex = -1;
            cbLocal.SelectedIndex = -1;
        }
    }
}
