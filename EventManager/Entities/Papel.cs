using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Papel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("descricao")]
        public string Descricao { get; set; }

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public Papel() { }
        public Papel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
