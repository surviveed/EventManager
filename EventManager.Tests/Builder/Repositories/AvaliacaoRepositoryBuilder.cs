using EventManager.Contracts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Repositories
{
    public class AvaliacaoRepositoryBuilder
    {
        private readonly Mock<IAvaliacaoRepository> _repository;

        public AvaliacaoRepositoryBuilder()
        {
            _repository = new Mock<IAvaliacaoRepository>();
        }

        public IAvaliacaoRepository Build() => _repository.Object;
    }
}
