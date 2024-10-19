using Bogus;
using EventManager.DTOs;
using EventManager.Entities;
using System.Collections.Generic;
using System.Diagnostics;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeEvento
    {
        private Faker<Evento> _fakerEvento;
        private Faker<EventoDTO> _fakerEventoDTO;

        public MakeEvento()
        {
            int tipoEventoId = new Faker().Random.Int(min:1, max:50);
            TipoEvento tipoEvento = new MakeTipoEvento().GetData(tipoEventoId);

            _fakerEvento = new Faker<Evento>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
                .RuleFor(c => c.Nome, f => f.Name.FirstName())
                .RuleFor(c => c.Descricao, f => f.Lorem.Word())
                .RuleFor(c => c.TipoEventoId, tipoEvento.Id)
                .RuleFor(c => c.TipoEvento, tipoEvento);


            _fakerEventoDTO = new Faker<EventoDTO>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
                .RuleFor(c => c.Nome, f => f.Name.FirstName())
                .RuleFor(c => c.Descricao, f => f.Lorem.Word())
                .RuleFor(c => c.TipoEventoId, f => f.Random.Int(min: 1, max: 50));
        }

        public Evento GetData(int? id = null, string nome = null, string descricao = null,int? tipoEventoId = null)
        {
            var evento = _fakerEvento.Generate();
            evento.Id = id ?? evento.Id;
            evento.Nome = nome ?? evento.Nome;
            evento.Descricao = descricao ?? evento.Descricao;
            evento.TipoEventoId = tipoEventoId ?? evento.TipoEventoId;
            evento.EventoOrganizadores = new List<EventoOrganizadores>();

            return evento;
        }

        public EventoDTO GetDataDto(int? id = null, string nome = null, string descricao = null, int? tipoEventoId = null)
        {
            var eventoDTO = _fakerEventoDTO.Generate();

            eventoDTO.Id = id ?? eventoDTO.Id;
            eventoDTO.Nome = nome ?? eventoDTO.Nome;
            eventoDTO.Descricao = descricao ?? eventoDTO.Descricao;
            eventoDTO.TipoEventoId = tipoEventoId ?? eventoDTO.TipoEventoId;

            return eventoDTO;
        }
    }
}
