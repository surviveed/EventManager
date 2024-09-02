using EventManager.DTOs;
using EventManager.Services;
using EventManager.Tests.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class AvaliacaoServiceTest
    {
        [TestMethod]
        public void ShouldBeCreateANewAvaliacao()
        {
            var service = CreateService();
            var av = CreateAvaliacaoDto();
            service.Inserir(av);
        }

        private AvaliacaoService CreateService()
        {
            var avaliacaoService = new AvaliacaoRepositoryBuilder().Build();
            return new AvaliacaoService(avaliacaoService);
        }
        private AvaliacaoDTO CreateAvaliacaoDto()
        {
            return new AvaliacaoDTO()
            {
                Id = 1,
                Comentario = "Example Comment",
                Nota = 10,
                PessoaId = 1,
                PessoaNome = "John Doe",
                SessaoId = 1
            };
        }
    }

}
