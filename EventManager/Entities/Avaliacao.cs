using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Avaliacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("comentario")]
        public string Comentario { get; set; }

        [Required]
        [Column("nota")]
        public int Nota { get; set; }

        [Column("pessoa_id")]
        public int PessoaId { get; set; }

        [ForeignKey("pessoa_id")]
        public Pessoa Pessoa { get; set;}

        [Column("sessao_id")]
        public int SessaoId { get; set; }

        [ForeignKey("sessao_id")]
        public Sessao Sessao { get; set; }

        public Avaliacao() { }

        public Avaliacao(int id, string comentario, int nota, int pessoaId, int sessaoId)
        {
            Id = id;
            Comentario = comentario;
            Nota = nota;
            PessoaId = pessoaId;
            SessaoId = sessaoId;
        }
    }
}
