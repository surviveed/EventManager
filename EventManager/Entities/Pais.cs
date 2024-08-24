using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Pais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("codigo_ibge")]
        public int CodigoIbge { get; set; }

        public Pais() { }

        public Pais(int id, string descricao, int codigoIbge) 
        { 
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
        }
    }
}
