using Bogus;
using EventManager.DTOs;
using EventManager.Entities;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeLocal
    {
        private Faker<Local> _fakerLocal;
        private Faker<LocalDTO> _fakerLocalDTO;


        public MakeLocal()
        {
            var idCidade = new Faker("pt_BR").Random.Number(1, 10000);
            var cidade = new MakeCidade().GetData(id: idCidade);

            _fakerLocal = new Faker<Local>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(min: 1, max: 50))
                .RuleFor(c => c.Nome, f => f.Locale)
                .RuleFor(c => c.Capacidade, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Endereco, f => f.Locale)
                .RuleFor(c => c.Observacoes, f => f.Lorem.Sentence(2))
                .RuleFor(c => c.CidadeId, f => idCidade)
                .RuleFor(c => c.Cidade, f => cidade);

            _fakerLocalDTO = new Faker<LocalDTO>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Number(min: 1, max: 50))
                .RuleFor(c => c.Nome, f => f.Locale)
                .RuleFor(c => c.Capacidade, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Endereco, f => f.Locale)
                .RuleFor(c => c.Observacoes, f => f.Lorem.Sentence(2))
                .RuleFor(c => c.CidadeId, f => idCidade);
        }

        public Local GetData(int? id = null, string nome = null, int? capacidade = null, string endereco = null, string observacoes = null, int? cidadeId = null)
        {
            var local = _fakerLocal.Generate();

            local.Id = id ?? local.Id;
            local.Nome = nome ?? local.Nome;
            local.Capacidade = capacidade ?? local.Capacidade;
            local.Endereco = endereco ?? local.Endereco;
            local.Observacoes = observacoes ?? local.Observacoes;
            local.CidadeId = cidadeId ?? local.CidadeId;

            local.Cidade.Id = cidadeId ?? local.CidadeId;

            return local;
        }

        public LocalDTO GetDataDTO(int? id = null, string nome = null, int? capacidade = null, string endereco = null, string observacoes = null)
        {
            var localDTO = _fakerLocalDTO.Generate();

            localDTO.Id = id ?? localDTO.Id;
            localDTO.Nome = nome ?? localDTO.Nome;
            localDTO.Capacidade = capacidade ?? localDTO.Capacidade;
            localDTO.Endereco = endereco ?? localDTO.Endereco;
            localDTO.Observacoes = observacoes ?? localDTO.Observacoes;
           

            return localDTO;
        }
    }
}
