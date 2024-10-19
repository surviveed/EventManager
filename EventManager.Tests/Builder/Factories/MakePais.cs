using Bogus;
using EventManager.DTOs;
using EventManager.Entities;

namespace EventManager.Tests.Builder.Factories
{
    public class MakePais
    {
        private Faker<Pais> _fakerPAIS;
        private Faker<PaisDTO> _fakerPAISDTO;

        public MakePais()
        {
            _fakerPAIS = new Faker<Pais>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
                .RuleFor(c => c.Descricao, f => f.Address.City())
                .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100));


            _fakerPAISDTO = new Faker<PaisDTO>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
               .RuleFor(c => c.Descricao, f => f.Address.City())
               .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100));
        }

        public Pais GetData(int? id = null, string descricao = null, int? codigoIbge = null)
        {
            var pais = _fakerPAIS.Generate();

            pais.Id = id ?? pais.Id;
            pais.Descricao = descricao ?? pais.Descricao;
            pais.CodigoIbge = codigoIbge ?? pais.CodigoIbge;

            return pais;
        }

        public PaisDTO GetDataDto(int? id = null, string descricao = null, int? codigoIbge = null)
        {
            var paisDTO = _fakerPAISDTO.Generate();

            paisDTO.Id = id ?? paisDTO.Id;
            paisDTO.Descricao = descricao ?? paisDTO.Descricao;
            paisDTO.CodigoIbge = codigoIbge ?? paisDTO.CodigoIbge;

            return paisDTO;
        }
    }
}
