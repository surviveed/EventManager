using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Uf
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

        [Column("pais_id")]
        public int PaisId { get; set; }

        [ForeignKey("pais_id")]
        public Pais Pais { get; set; }

        public Uf() { }

        public Uf(int id, string descricao, int codigoIbge, int paisId)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            PaisId = paisId;
        }
    }
}
