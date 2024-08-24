using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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

        public List<Uf> Ufs { get; set; } = new List<Uf>();

        public Pais() { }

        public Pais(int id, string descricao, int codigoIbge) 
        { 
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
        }
    }
}
