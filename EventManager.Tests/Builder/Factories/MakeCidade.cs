using Bogus;
using EventManager.DTOs;
using EventManager.Entities;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeCidade
    {
        private Faker<Cidade> _fakerCidade;
        private Faker<CidadeDTO> _fakerCidadeDTO;

        public MakeCidade()
        {
            var idUf = new Faker("pt_BR").Random.Number(1, 10000);
            var uf = new MakeUF().GetData(id: idUf);
            var pais = new MakePais().GetData(id: uf.PaisId);
            uf.Pais = pais;

            _fakerCidade = new Faker<Cidade>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
                .RuleFor(c => c.Descricao, f => f.Address.City())
                .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100))
                .RuleFor(c => c.UfId, idUf)
                .RuleFor(c => c.Uf, uf);


            _fakerCidadeDTO = new Faker<CidadeDTO>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Number(1, 1000))
               .RuleFor(c => c.Descricao, f => f.Address.City())
               .RuleFor(c => c.CodigoIbge, f => f.Random.Number(1, 100))
               .RuleFor(c => c.UfId, f => f.Random.Number(1, 1000))
               .RuleFor(c => c.UfDescricao, f => f.Address.State());
        }

        public Cidade GetData(int? id = null, string descricao = null, int? codigoIbge = null, int? ufId = null)
        {
            var cidade = _fakerCidade.Generate();

            cidade.Id = id ?? cidade.Id;
            cidade.Descricao = descricao ?? cidade.Descricao;
            cidade.CodigoIbge = codigoIbge ?? cidade.CodigoIbge;
            cidade.UfId = ufId ?? cidade.UfId;

            return cidade;
        }

        public CidadeDTO GetDataDto(int? id = null, string descricao = null, int? codigoIbge = null, string ufDescricao = null, int? ufId = null)
        {
            var cidadeDTO = _fakerCidadeDTO.Generate();

            cidadeDTO.Id = id ?? cidadeDTO.Id;
            cidadeDTO.Descricao = descricao ?? cidadeDTO.Descricao;
            cidadeDTO.CodigoIbge = codigoIbge ?? cidadeDTO.CodigoIbge;
            cidadeDTO.UfId = ufId ?? cidadeDTO.UfId;
            cidadeDTO.UfDescricao = ufDescricao ?? cidadeDTO.UfDescricao;

            return cidadeDTO;
        }
    }
}
