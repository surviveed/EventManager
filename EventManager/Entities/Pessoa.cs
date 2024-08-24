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

        public List<Evento> EventosOrganizados { get; set; } = new List<Evento>();
        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        public List<Sessao> Sessoes { get; set; } = new List<Sessao>(); // como integrante

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
