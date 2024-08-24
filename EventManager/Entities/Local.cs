using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Local
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("capacidade")]
        public int Capacidade { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("observacoes")]
        public string Observacoes { get; set; }

        [Column("cidade_id")]
        public int CidadeId { get; set; }

        [ForeignKey("cidade_id")]
        public Cidade Cidade { get; set; }

        public Local() { }

        public Local(int id, string nome, int capacidade, string endereco, string observacoes, int cidadeId)
        {
            Id = id;
            Nome = nome;
            Capacidade = capacidade;
            Endereco = endereco;
            Observacoes = observacoes;
            CidadeId = cidadeId;
        }
    }
}
