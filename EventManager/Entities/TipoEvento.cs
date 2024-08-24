using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EventManager.Entities
{
    public class TipoEvento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("descricao")]
        public string Descricao { get; set; }

        public List<Evento> Eventos { get; set; } = new List<Evento>();

        public TipoEvento() { }

        public TipoEvento(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
