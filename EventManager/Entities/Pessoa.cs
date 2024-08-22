using EventManager.Entities.enums;
using System.Collections.Generic;

namespace EventManager.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
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
