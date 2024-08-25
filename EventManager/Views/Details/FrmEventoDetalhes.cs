using EventManager.DTOs;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EventManager.Views.Details
{
    public partial class FrmEventoDetalhes : Form
    {

        public FrmEventoDetalhes(EventoDTO evento)
        {
            InitializeComponent();
            ConfiguracoesIniciais(evento);

            ConfigureMaterialListViewSessoes();
            LoadSessoes(evento);

            ConfigureMaterialListViewOrganizadores();
            LoadPessoas(evento);

            CreatePictureBoxes((int)evento.MediaAvaliacoes);
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
            int size = materialListViewOrganizadores.Size.Width / 4;
            materialListViewOrganizadores.Columns.Add("ID", size);
            materialListViewOrganizadores.Columns.Add("Nome", size);
            materialListViewOrganizadores.Columns.Add("CPF", size);
            materialListViewOrganizadores.Columns.Add("Tipo Pessoa", size);
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
                listViewItem.SubItems.Add(pessoa.Cpf);
                listViewItem.SubItems.Add(pessoa.TipoPessoa.ToString());

                materialListViewOrganizadores.Items.Add(listViewItem);
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
