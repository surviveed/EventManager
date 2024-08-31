using EventManager.DTOs;
using EventManager.Repositories;
using EventManager.Services;
using System;
using System.Windows.Forms;

namespace EventManager.Views.Details
{
    public partial class FrmSessaoDetalhes : Form
    {
        private readonly SessaoService _sessaoService;
        private readonly EventoService _eventoService;
        private readonly LocalService _localService;
        private readonly AvaliacaoService _avaliacaoService;
        private readonly SessaoDTO _sessao;
        private readonly UsuarioDTO _usuario;

        public FrmSessaoDetalhes(SessaoDTO sessao, UsuarioDTO usuario)
        {
            _sessao = sessao;
            _usuario = usuario;
            InitializeComponent();
            _sessaoService = new SessaoService(new SessaoRepository(), new PessoaRepository());
            _eventoService = new EventoService(new EventoRepository());
            _localService = new LocalService(new LocalRepository());
            _avaliacaoService = new AvaliacaoService(new AvaliacaoRepository());

            ConfiguracoesIniciais(sessao);
            ConfigureMaterialListViewPalestrantes();
            ConfigureMaterialListViewParticipantes();
            LoadPalestrantes(sessao);
            LoadParticipantes(sessao);

            VerificarSeJaParticipante(sessao, usuario.Pessoa);
            VerificarSeJaAvaliou(sessao, usuario.Pessoa);
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

        private void VerificarSeJaParticipante(SessaoDTO sessao, PessoaDTO pessoa)
        {
            if (sessao.Integrantes.Contains(pessoa))
            {
                btnParticipar.Visible = false;
            }

        }

        private void VerificarSeJaAvaliou(SessaoDTO sessao, PessoaDTO pessoa)
        {
            foreach(AvaliacaoDTO avaliacao in sessao.Avaliacoes)
            {
                if(avaliacao.PessoaId == pessoa.Id) 
                {
                    groupBoxAvaliacoes.Visible = false;
                    break;
                }
            }
        }

        private void btnEnviar_Click(object sender, System.EventArgs e)
        {
            try
            {
                AvaliacaoDTO avaliacao = new AvaliacaoDTO
                {
                    Nota = ObterNotaSelecionada(),
                    SessaoId = _sessao.Id,
                    PessoaId = _usuario.Pessoa.Id,
                    Comentario = txtComentarios.Text
                };

                _avaliacaoService.Inserir(avaliacao);
                MessageBox.Show("Avaliação inserida com sucesso!");
                LimparCampos();
                VerificarSeJaAvaliou(_sessao, _usuario.Pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao inserir a avaliação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObterNotaSelecionada()
        {
            if (rbNota1.Checked) return 1;
            if (rbNota2.Checked) return 2;
            if (rbNota3.Checked) return 3;
            if (rbNota4.Checked) return 4;
            if (rbNota5.Checked) return 5;
            throw new InvalidOperationException("Nenhuma nota selecionada.");
        }

        private void btnParticipar_Click(object sender, System.EventArgs e)
        {
            _sessao.Integrantes.Add(_usuario.Pessoa);
            _sessaoService.AtualizarIntegrantes(_sessao, _sessao.Integrantes);
            LoadPalestrantes(_sessao);
            LoadParticipantes(_sessao);
        }

        private void LimparCampos()
        {
            txtComentarios.Clear();
            rbNota1.Checked = false; rbNota2.Checked = false; rbNota3.Checked = false; rbNota4.Checked = false; rbNota5.Checked = false;
        }
    }
}
