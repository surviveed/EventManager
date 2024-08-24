using EventManager.Entities.enums;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.DTOs
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public List<EventoDTO> EventosOrganizados { get; set; } = new List<EventoDTO>();
        //public List<AvaliacaoDTO> Avaliacoes { get; set; } = new List<AvaliacaoDTO>();
        //public List<SessaoDTO> Sessoes { get; set; } = new List<SessaoDTO>();

        public PessoaDTO() { }

        public PessoaDTO(int id, string nome, string cpf, TipoPessoa tipoPessoa)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }

        public PessoaDTO(Pessoa pessoa)
        {
            Id = pessoa.Id;
            Nome = pessoa.Nome;
            Cpf = pessoa.Cpf;
            TipoPessoa = pessoa.TipoPessoa;

            EventosOrganizados = pessoa.EventoOrganizadores.Select(e => new EventoDTO(e.Evento)).ToList();
            //Avaliacoes = pessoa.Avaliacoes.Select(a => new AvaliacaoDTO(a)).ToList();
            //Sessoes = pessoa.Sessoes.Select(s => new SessaoDTO(s.Sessao)).ToList();
        }
    }
}
