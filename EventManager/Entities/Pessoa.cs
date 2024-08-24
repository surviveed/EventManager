using EventManager.Entities.enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("cpf")]
        public string Cpf { get; set; }

        [Required]
        [Column("tipopessoa")]
        public TipoPessoa TipoPessoa { get; set; }

        public virtual ICollection<EventoOrganizadores> EventoOrganizadores { get; set; }

        public virtual List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();

        public virtual ICollection<SessaoIntegrante> SessaoIntegrantes { get; set; }

        public Pessoa() { }

        public Pessoa(int id, string nome, string cpf, TipoPessoa tipoPessoa)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }
    }
}
