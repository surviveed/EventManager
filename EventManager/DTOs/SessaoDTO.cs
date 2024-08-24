using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.DTOs
{
    public class SessaoDTO
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int EventoId { get; set; }
        public string EventoNome { get; set; }
        public int LocalId { get; set; }
        public string LocalNome { get; set; }

        public List<AvaliacaoDTO> Avaliacoes { get; set; } = new List<AvaliacaoDTO>();
        public List<PessoaDTO> Integrantes { get; set; } = new List<PessoaDTO>();

        public SessaoDTO() { }

        public SessaoDTO(int id, DateTime dataInicio, DateTime dataFim, int eventoId, string eventoNome, int localId, string localNome)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            EventoId = eventoId;
            EventoNome = eventoNome;
            LocalId = localId;
            LocalNome = localNome;
        }

        public SessaoDTO(Sessao entity)
        {
            Id = entity.Id;
            DataInicio = entity.DataInicio;
            DataFim = entity.DataFim;
            EventoId = entity.EventoId;
            EventoNome = entity.Evento.Nome;
            LocalId = entity.LocalId;
            if(entity.Local != null)
            {
                LocalNome = entity.Local.Nome;
            }

            if(entity.SessaoIntegrantes != null)
            {
                Integrantes = entity.SessaoIntegrantes.Select(e => new PessoaDTO(
                                e.Pessoa.Id, e.Pessoa.Nome, e.Pessoa.Cpf, e.Pessoa.TipoPessoa))
                            .ToList();
            }

            foreach(Avaliacao avaliacao in entity.Avaliacoes)
            {
                Avaliacoes.Add(new AvaliacaoDTO(avaliacao));
            }
        }
    }
}
