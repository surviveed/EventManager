using Bogus;
using EventManager.DTOs;
using EventManager.Entities;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeUF
    {
        private Faker<Uf> _fakerUF;
        private Faker<UfDTO> _fakerUFDTO;

        public MakeUF()
        {
            _fakerUF = new Faker<Uf>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
                .RuleFor(c => c.Descricao, f => f.Address.City())
                .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100))
                .RuleFor(c => c.PaisId, f => f.Random.Number(1, 100));


            _fakerUFDTO = new Faker<UfDTO>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
               .RuleFor(c => c.Descricao, f => f.Address.City())
               .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100))
               .RuleFor(c => c.PaisId, f => f.Random.Number(1, 100));
        }

        public Uf GetData(int? id = null, string descricao = null, int? codigoIbge = null, int? paisId = null)
        {
            var uf = _fakerUF.Generate();

            uf.Id = id ?? uf.Id;
            uf.Descricao = descricao ?? uf.Descricao;
            uf.CodigoIbge = codigoIbge ?? uf.CodigoIbge;
            uf.PaisId = paisId ?? uf.PaisId;

            return uf;
        }

        public UfDTO GetDataDto(int? id = null, string descricao = null, int? codigoIbge = null, int? paisId = null)
        {
            var ufDTO = _fakerUFDTO.Generate();

            ufDTO.Id = id ?? ufDTO.Id;
            ufDTO.Descricao = descricao ?? ufDTO.Descricao;
            ufDTO.CodigoIbge = codigoIbge ?? ufDTO.CodigoIbge;
            ufDTO.PaisId = paisId ?? ufDTO.PaisId;

            return ufDTO;
        }
    }
}
