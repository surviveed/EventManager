using Bogus;
using EventManager.DTOs;
using EventManager.Entities;


namespace EventManager.Tests.Builder.Factories
{
    public class MakePapel
    {
        private Faker<Papel> _fakerPapel;
        private Faker<PapelDTO> _fakerPapelDTO;


        public MakePapel()
        {
            _fakerPapel = new Faker<Papel>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Descricao, f => f.Lorem.Sentence(2));

            _fakerPapelDTO    = new Faker<PapelDTO>("pt_BR")
              .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
              .RuleFor(c => c.Descricao, f => f.Lorem.Sentence(2));
        }

        public Papel GetData(int? id = null, string descricao = null)
        {
            var papel = _fakerPapel.Generate();

            papel.Id = id ?? papel.Id;
            papel.Descricao = descricao ?? papel.Descricao;

            return papel;
        }

        public PapelDTO GetDataDTO(int? id = null, string descricao = null)
        {
            var papel = _fakerPapelDTO.Generate();

            papel.Id = id ?? papel.Id;
            papel.Descricao = descricao ?? papel.Descricao;

            return papel;
        }
    }
}
