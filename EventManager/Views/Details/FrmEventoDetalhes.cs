using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Util;
using ReaLTaiizor.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EventManager.Views.Details
{
    public partial class FrmEventoDetalhes : Form
    {
        private readonly UsuarioDTO _usuario;

        public FrmEventoDetalhes(EventoDTO evento, UsuarioDTO usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            ConfiguracoesIniciais(evento);

            ConfigureMaterialListViewSessoes();
            LoadSessoes(evento);

            ConfigureMaterialListViewOrganizadores();
            LoadPessoas(evento);

            ConfigureMaterialListViewAvaliacoes();
            LoadAvaliacoes(evento);

            CreatePictureBoxes((int)evento.MediaAvaliacoes);

            VerificarAdmin(usuario);
        }

        private void VerificarAdmin(UsuarioDTO usuario)
        {
            if (AuthService.VerificarAdmin(usuario))
            {
                groupBoxAvaliacoes.Visible = true;
            }
        }

        private void ConfiguracoesIniciais(EventoDTO evento)
        {
            lblNome.Text = evento.Nome;
            lblDescricao.Text = evento.Descricao;
            lblDescricaoTipoEvento.Text = evento.TipoEventoDescricao;
            lblNumeroDeSessoes.Text = evento?.Sessoes.Count.ToString();
            lblNumeroDeOrganizadores.Text = evento?.Organizadores.Count.ToString();
        }

        private void ConfigureMaterialListViewSessoes()
        {
            int size = materialListViewSessoes.Size.Width / 5;
            materialListViewSessoes.Columns.Add("ID", size);
            materialListViewSessoes.Columns.Add("Data Início", size);
            materialListViewSessoes.Columns.Add("Data Fim", size);
            materialListViewSessoes.Columns.Add("Evento", size);
            materialListViewSessoes.Columns.Add("Local", size);
        }

        private void LoadSessoes(EventoDTO evento)
        {
            materialListViewSessoes.Items.Clear();
            var sessoes = evento.Sessoes;

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

        private void ConfigureMaterialListViewOrganizadores()
        {
            int size = materialListViewOrganizadores.Size.Width / 2;
            materialListViewOrganizadores.Columns.Add("ID", size);
            materialListViewOrganizadores.Columns.Add("Nome", size);
        }

        private void LoadPessoas(EventoDTO evento)
        {
            materialListViewOrganizadores.Items.Clear();
            var pessoas = evento.Organizadores;

            foreach (var pessoa in pessoas)
            {
                var listViewItem = new ListViewItem(pessoa.Id.ToString())
                {
                    Tag = pessoa
                };
                listViewItem.SubItems.Add(pessoa.Nome);

                materialListViewOrganizadores.Items.Add(listViewItem);
            }
        }

        private void ConfigureMaterialListViewAvaliacoes()
        {
            int size = materialListViewAvaliacoes.Size.Width / 5;
            materialListViewAvaliacoes.Columns.Add("ID", size);
            materialListViewAvaliacoes.Columns.Add("Nota", size);
            materialListViewAvaliacoes.Columns.Add("Comentário", size);
            materialListViewAvaliacoes.Columns.Add("Pessoa", size);
            materialListViewAvaliacoes.Columns.Add("Sessão", size);
        }

        private void LoadAvaliacoes(EventoDTO evento)
        {
            materialListViewAvaliacoes.Items.Clear();
            List<AvaliacaoDTO> avaliacoes = new List<AvaliacaoDTO>();

            foreach(SessaoDTO sessao in evento.Sessoes)
            {
                foreach(AvaliacaoDTO avaliacao in sessao.Avaliacoes)
                {
                    avaliacoes.Add(avaliacao);
                }
            }

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

        private void CreatePictureBoxes(int count)
        {
            int spacingX = 5;
            int startX = 170; // Ponto inicial X
            int startY = 14; // Ponto inicial Y

            for (int i = 0; i < count; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = 23,
                    Height = 23,
                    Location = new Point(startX + (i * (23 + spacingX)), startY), // Calcular a posição X
                    Image = LoadImage("star.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                pictureBox.Parent = materialCard3;
            }
        }

        private Image LoadImage(string fileName)
        {
            string resourcesPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            string caminho = Path.Combine(resourcesPath, fileName);

            if (File.Exists(caminho))
            {
                return Image.FromFile(caminho);
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado: " + caminho);
                return null;
            }
        }

        private void materialListViewSessoes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listView = sender as MaterialListView;
            if (listView.SelectedItems.Count > 0)
            {
                var selectedItem = listView.SelectedItems[0];
                var sessao = (SessaoDTO)selectedItem.Tag;

                FrmSessaoDetalhes frmDetalhes = new FrmSessaoDetalhes(sessao, _usuario);
                frmDetalhes.ShowDialog();
            }
        }
    }
}
