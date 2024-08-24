using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("tipoevento_id")]
        public int TipoEventoId { get; set; }

        [ForeignKey("tipoevento_id")]
        public TipoEvento TipoEvento { get; set; }

  
        public virtual List<Sessao> Sessoes { get; set; } = new List<Sessao>();

        public virtual ICollection<EventoOrganizadores> EventoOrganizadores { get; set; }

        public Evento() { }

        public Evento(int id, string nome, string descricao, int tipoEventoId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            TipoEventoId = tipoEventoId;
        }

        public double CalcularMediaAvaliacoes() 
        { 
            double soma = 0;
            double quantidade = 0;
            foreach(Sessao sessao in Sessoes)
            {
                foreach(Avaliacao avaliacao in sessao.Avaliacoes)
                {
                    soma += avaliacao.Nota;
                    quantidade++;
                }
            }
            return soma / quantidade;
        }
    }
}
