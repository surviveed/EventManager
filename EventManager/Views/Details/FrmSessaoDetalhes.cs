using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System.Windows.Forms;

namespace EventManager.Views.Details
{
    public partial class FrmSessaoDetalhes : Form
    {
        private readonly EventoService _eventoService;
        private readonly LocalService _localService;
        private readonly PessoaService _pessoaService;
        private readonly AvaliacaoService _avaliacaoService;
        private readonly SessaoDTO _sessao;
        private readonly UsuarioDTO _usuario;

        public FrmSessaoDetalhes(SessaoDTO sessao, UsuarioDTO usuario)
        {
            _sessao = sessao;
            _usuario = usuario;
            InitializeComponent();
            _eventoService = new EventoService(new EventoRepository());
            _localService = new LocalService(new LocalRepository());
            _pessoaService = new PessoaService(new PessoaRepository());
            _avaliacaoService = new AvaliacaoService(new AvaliacaoRepository());

            ConfiguracoesIniciais(sessao);
            ConfigureMaterialListViewPalestrantes();
            ConfigureMaterialListViewParticipantes();
            LoadPalestrantes(sessao);
            LoadParticipantes(sessao);


        }

        private void ConfiguracoesIniciais(SessaoDTO sessao)
        {
            EventoDTO evento = _eventoService.BuscarPorId(sessao.EventoId);
            LocalDTO local = _localService.BuscarPorId(sessao.LocalId);
            
            lblNome.Text = sessao.EventoNome;
            lblDescricaoTipoEvento.Text = evento.TipoEventoDescricao;
            lblDataInicio.Text = sessao.DataInicio.ToLongDateString();
            lblDataFim.Text = sessao.DataFim.ToLongDateString();

            int numeroPalestrantes = 0, numeroParticipantes = 0;
            foreach(PessoaDTO pessoa in sessao.Integrantes)
            {
                if (!pessoa.TipoPessoa.ToString().Equals("PALESTRANTE"))
                {
                    numeroParticipantes++;
                } 
                else
                {
                    numeroPalestrantes++;
                }
            }

            lblNumeroDePalestrantes.Text = numeroPalestrantes.ToString();
            lblNumeroDeParticipantes.Text = numeroParticipantes.ToString();
            lblCapacidade.Text = local.Capacidade.ToString();
        }

        private void ConfigureMaterialListViewPalestrantes()
        {
            int size = materialListViewPalestrantes.Size.Width / 2;
            materialListViewPalestrantes.Columns.Add("ID", size);
            materialListViewPalestrantes.Columns.Add("Nome", size);
        }

        private void ConfigureMaterialListViewParticipantes()
        {
            int size = materialListViewParticipantes.Size.Width / 2;
            materialListViewParticipantes.Columns.Add("ID", size);
            materialListViewParticipantes.Columns.Add("Nome", size);
        }

        private void LoadPalestrantes(SessaoDTO sessao)
        {
            materialListViewPalestrantes.Items.Clear();
            var pessoas = sessao.Integrantes;

            foreach (var pessoa in pessoas)
            {
                if (pessoa.TipoPessoa.ToString().Equals("PALESTRANTE"))
                {
                    var listViewItem = new ListViewItem(pessoa.Id.ToString())
                    {
                        Tag = pessoa
                    };
                    listViewItem.SubItems.Add(pessoa.Nome);

                    materialListViewPalestrantes.Items.Add(listViewItem);
                }
            }
        }

        private void LoadParticipantes(SessaoDTO sessao)
        {
            materialListViewParticipantes.Items.Clear();
            var pessoas = sessao.Integrantes;

            foreach (var pessoa in pessoas)
            {
                if (!pessoa.TipoPessoa.ToString().Equals("PALESTRANTE"))
                {
                    var listViewItem = new ListViewItem(pessoa.Id.ToString())
                    {
                        Tag = pessoa
                    };
                    listViewItem.SubItems.Add(pessoa.Nome);

                    materialListViewParticipantes.Items.Add(listViewItem);
                }
            }
        }

        private bool VerificarSeJaParticipante(SessaoDTO sessao, PessoaDTO pessoa)
        {
            if (sessao.Integrantes.Contains(pessoa))
            {
                return true;
            }
            return false;
        }

        private bool VerificarSeJaAvaliou(SessaoDTO sessao, PessoaDTO pessoa)
        {
            foreach(AvaliacaoDTO avaliacao in sessao.Avaliacoes)
            {
                if(avaliacao.PessoaId == pessoa.Id) 
                { 
                    return true;
                }
            }
            return false;
        }

        private void btnEnviar_Click(object sender, System.EventArgs e)
        {
            AvaliacaoDTO avaliacao = new AvaliacaoDTO();
            int nota = 0;
            if(rbNota1.Checked)
            {
                nota = 1;
            } 
            else if (rbNota2.Checked)
            {
                nota = 2;
            } 
            else if (rbNota3.Checked)
            {
                nota = 3;
            } 
            else if (rbNota4.Checked)
            {
                nota = 4;
            } 
            else if(rbNota5.Checked)
            {
                nota = 5;
            }
            avaliacao.Nota = nota;
            avaliacao.SessaoId = _sessao.Id;
            avaliacao.Comentario = txtComentarios.Text;
            //avaliacao.PessoaId = ;
            _avaliacaoService.Inserir(avaliacao);
            MessageBox.Show("Avaliação inserida com sucesso!");
        }
    }
}
