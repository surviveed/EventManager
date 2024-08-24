using EventManager.Entities;

namespace EventManager.DTOs
{
    public class AvaliacaoDTO
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public int Nota { get; set; }
        public int PessoaId { get; set; }
        public string PessoaNome { get; set; }
        public int SessaoId { get; set; }

        public AvaliacaoDTO() { }

        public AvaliacaoDTO(int id, string comentario, int nota, int pessoaId, string pessoaNome, int sessaoId)
        {
            Id = id;
            Comentario = comentario;
            Nota = nota;
            PessoaId = pessoaId;
            PessoaNome = pessoaNome;
            SessaoId = sessaoId;
        }

        public AvaliacaoDTO(Avaliacao avaliacao)
        {
            Id = avaliacao.Id;
            Comentario = avaliacao.Comentario;
            Nota = avaliacao.Nota;
            PessoaId = avaliacao.Pessoa.Id;
            PessoaNome = avaliacao.Pessoa.Nome;
            SessaoId = avaliacao.SessaoId;
        }
    }
}
