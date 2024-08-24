using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EventManager.Entities
{
    public class Cidade
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

        [Column("uf_id")]
        public int UfId { get; set; } 

        [ForeignKey("uf_id")]
        public Uf Uf { get; set; }

        public List<Local> Locais { get; set; } = new List<Local>();

        public Cidade() { }

        public Cidade(int id, string descricao, int codigoIbge, int ufId)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            UfId = ufId;
        }
    }
}
