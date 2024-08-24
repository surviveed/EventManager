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

        public virtual ICollection<UsuarioPapel> UsuarioPapeis { get; set; }

        public Papel() { }
        public Papel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
