using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EventManager.Views.Details
{
    public partial class FrmEventoDetalhes : Form
    {
        private readonly EventoService _eventoService;
        private readonly PessoaService _pessoaService;
        private readonly SessaoService _sessaoService;

        public FrmEventoDetalhes(EventoDTO evento)
        {
            InitializeComponent();
            _eventoService = new EventoService(new EventoRepository());
            ConfiguracoesIniciais(evento);

            ConfigureMaterialListViewSessoes();
            LoadSessoes(evento);
            CreatePictureBoxes((int)evento.MediaAvaliacoes);
        }

        private void ConfiguracoesIniciais(EventoDTO evento)
        {
            lblNome.Text = evento.Nome;
            lblDescricao.Text = evento.Descricao;
            lblDescricaoTipoEvento.Text = evento.TipoEventoDescricao;
            lblNumeroDeSessoes.Text = evento.Sessoes.Count.ToString();
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


    }
}
