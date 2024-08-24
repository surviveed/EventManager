using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class SessaoIntegrante
    {
        [Key, Column("sessao_id", Order = 0)]
        [ForeignKey("Sessao")]
        public int SessaoId { get; set; }

        public virtual Sessao Sessao { get; set; }

        [Key, Column("pessoa_id", Order = 1)]
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
