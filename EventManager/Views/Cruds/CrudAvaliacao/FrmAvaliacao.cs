using EventManager.Config;
using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EventManager.Views.CrudAvaliacao
{
    public partial class FrmAvaliacao : Form
    {
        private readonly AvaliacaoService _avaliacaoService;
        private readonly PessoaService _pessoaService;
        private readonly SessaoService _sessaoService;

        public FrmAvaliacao()
        {
            InitializeComponent();
            _avaliacaoService = new AvaliacaoService(new AvaliacaoRepository());
            _pessoaService = new PessoaService(new PessoaRepository());
            _sessaoService = new SessaoService(new SessaoRepository(), new PessoaRepository());

            ConfigureMaterialListView();
            LoadAvaliacoes();
            FillComboBoxes();
            MaterialListViewCustomizations.ApplyCustomizations(materialListViewAvaliacoes);
        }

        private void ConfigureMaterialListView()
        {
            int size = materialListViewAvaliacoes.Size.Width / 5;
            materialListViewAvaliacoes.Columns.Add("ID", size);
            materialListViewAvaliacoes.Columns.Add("Nota", size);
            materialListViewAvaliacoes.Columns.Add("Comentário", size);
            materialListViewAvaliacoes.Columns.Add("Pessoa", size);
            materialListViewAvaliacoes.Columns.Add("Sessão", size);
        }

        private void LoadAvaliacoes()
        {
            materialListViewAvaliacoes.Items.Clear();
            var avaliacoes = _avaliacaoService.BuscarTodos();

            foreach (var avaliacao in avaliacoes)
            {
                var listViewItem = new ListViewItem(avaliacao.Id.ToString())
                {
                    Tag = avaliacao
                };
                listViewItem.SubItems.Add(avaliacao.Nota.ToString());
                listViewItem.SubItems.Add(avaliacao.Comentario);
                listViewItem.SubItems.Add(avaliacao.PessoaNome);
                listViewItem.SubItems.Add(avaliacao.SessaoId.ToString());

                materialListViewAvaliacoes.Items.Add(listViewItem);
            }
        }

        private void FillComboBoxes()
        {
            // Preencher os ComboBoxes com Pessoas e Sessoes disponíveis
            cbPessoa.DataSource = _pessoaService.BuscarTodos()
                                                .Select(p => new { p.Id, p.Nome })
                                                .ToList();
            cbPessoa.DisplayMember = "nome";
            cbPessoa.ValueMember = "id";

            cbSessao.DataSource = _sessaoService.BuscarTodos()
                                                .Select(s => new { s.Id })
                                                .ToList();
            cbSessao.DisplayMember = "id";
            cbSessao.ValueMember = "id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var avaliacaoDto = new AvaliacaoDTO
            {
                Nota = Convert.ToInt32(txtNota.Text),
                Comentario = txtComentario.Text,
                PessoaId = (int)cbPessoa.SelectedValue,
                SessaoId = (int)cbSessao.SelectedValue
            };
            _avaliacaoService.Inserir(avaliacaoDto);
            LoadAvaliacoes();
            ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListViewAvaliacoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewAvaliacoes.SelectedItems[0];
                var avaliacaoDto = (AvaliacaoDTO)selectedItem.Tag;

                avaliacaoDto.Nota = Convert.ToInt32(txtNota.Text);
                avaliacaoDto.Comentario = txtComentario.Text;
                avaliacaoDto.PessoaId = (int)cbPessoa.SelectedValue;
                avaliacaoDto.SessaoId = (int)cbSessao.SelectedValue;

                _avaliacaoService.Atualizar(avaliacaoDto);
                LoadAvaliacoes();
                ClearFields();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (materialListViewAvaliacoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewAvaliacoes.SelectedItems[0];
                var avaliacaoDto = (AvaliacaoDTO)selectedItem.Tag;

                var confirmResult = MessageBox.Show(
                    "Você realmente deseja excluir?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _avaliacaoService.Remover(avaliacaoDto.Id);
                    LoadAvaliacoes();
                    ClearFields();
                }
            }
        }

        private void materialListViewAvaliacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewAvaliacoes.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewAvaliacoes.SelectedItems[0];
                var avaliacaoDto = (AvaliacaoDTO)selectedItem.Tag;

                txtNota.Text = avaliacaoDto.Nota.ToString();
                txtComentario.Text = avaliacaoDto.Comentario;
                cbPessoa.SelectedValue = avaliacaoDto.PessoaId;
                cbSessao.SelectedValue = avaliacaoDto.SessaoId;
            }
        }

        private void ClearFields()
        {
            txtNota.Clear();
            txtComentario.Clear();
            cbPessoa.SelectedIndex = -1;
            cbSessao.SelectedIndex = -1;
        }
    }
}
