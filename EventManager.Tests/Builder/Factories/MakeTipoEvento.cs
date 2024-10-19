using Bogus;
using EventManager.DTOs;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeTipoEvento
    {
        private Faker<TipoEvento> _fakerTipoEvento;
        private Faker<TipoEventoDTO> _fakerTipoEventoDTO;


        public MakeTipoEvento()
        {
            _fakerTipoEvento = new Faker<TipoEvento>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Descricao, f => f.Lorem.Sentence(2));

            _fakerTipoEventoDTO = new Faker<TipoEventoDTO>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
               .RuleFor(c => c.Descricao, f => f.Lorem.Sentence(2));
        }

        public TipoEvento GetData(int? id = null, string descricao = null)
        {
            var tipoEvento = _fakerTipoEvento.Generate();

            tipoEvento.Id = id ?? tipoEvento.Id;
            tipoEvento.Descricao = descricao ?? tipoEvento.Descricao;

            return tipoEvento;
        }

        public TipoEventoDTO GetDataDTO(int? id = null, string descricao = null)
        {
            var tipoEvento = _fakerTipoEventoDTO.Generate();

            tipoEvento.Id = id ?? tipoEvento.Id;
            tipoEvento.Descricao = descricao ?? tipoEvento.Descricao;

            return tipoEvento;
        }
    }
}
