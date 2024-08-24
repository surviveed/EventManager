using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Sessao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Column("data_fim")]
        public DateTime DataFim { get; set; }

        [Required]
        [ForeignKey("evento_id")]
        public Evento Evento { get; set; }

        [Column("evento_id")]
        public int EventoId { get; set; }

        [Required]
        [ForeignKey("local_id")]
        public Local Local { get; set; }

        [Column("local_id")]
        public int LocalId { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        public virtual ICollection<SessaoIntegrante> SessaoIntegrantes { get; set; }

        public Sessao() { }

        public Sessao(int id, DateTime dataInicio, DateTime dataFim, int eventoId, int localId)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            EventoId = eventoId;
            LocalId = localId;
        }
    }
}
