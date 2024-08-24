using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class EventoOrganizadores
    {
        [Key, Column("evento_id", Order = 0)]
        [ForeignKey("Evento")]
        public int EventoId { get; set; }

        public virtual Evento Evento { get; set; }

        [Key, Column("pessoa_id", Order = 1)]
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
