using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Services;
using EventManager.Tests.Builder.Factories;
using EventManager.Tests.Builder.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class CidadeServiceTest
    {
        private InMemoryCidadeRepository inMemoryCidadeRepository;
        private CidadeService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryCidadeRepository = new InMemoryCidadeRepository();
            sut = new CidadeService(inMemoryCidadeRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewCidade()
        {
            var cidade = new MakeCidade().GetDataDto(id: 1);
            var cidade2 = new MakeCidade().GetData(id: 1);
            sut.Inserir(cidade);

            var inMemoryCidade = inMemoryCidadeRepository.items.FirstOrDefault(x => x.Id == cidade.Id);

            Assert.IsNotNull(inMemoryCidade);
            Assert.AreEqual(inMemoryCidade.Id, cidade.Id);
            Assert.AreEqual(inMemoryCidade.Descricao, cidade.Descricao);
            Assert.AreEqual(inMemoryCidade.CodigoIbge, cidade.CodigoIbge);
            Assert.AreEqual(inMemoryCidade.UfId, cidade.UfId);
        }

    }

}
