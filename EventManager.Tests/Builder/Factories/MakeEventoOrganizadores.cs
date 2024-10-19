using Bogus;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeEventoOrganizadores
    {
        private Faker<EventoOrganizadores> _eventoOrganizadores;


        public MakeEventoOrganizadores()
        {
            _eventoOrganizadores = new Faker<EventoOrganizadores>()
                .RuleFor(c => c.EventoId, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.PessoaId, f => f.Random.Int(min: 1, max: 50));
        }

        public EventoOrganizadores GetData(int? eventoId = null, int? pessoaId = null)
        {
            var eventoOrganizadores = _eventoOrganizadores.Generate();

            eventoOrganizadores.EventoId = eventoId ?? eventoOrganizadores.EventoId;
            eventoOrganizadores.PessoaId = pessoaId ?? eventoOrganizadores.PessoaId;

            return eventoOrganizadores;

        }
    }
}
