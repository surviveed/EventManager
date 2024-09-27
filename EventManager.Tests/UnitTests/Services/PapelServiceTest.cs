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
    public class PapelTest
    {
        private InMemoryPapelRepository inMemoryPapelRepository;
        private PapelService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryPapelRepository = new InMemoryPapelRepository();
            sut = new PapelService(inMemoryPapelRepository);
        }

        [TestMethod]
        public void ShouldBeFindAllPapel()
        {

            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 1, descricao: "Descricao 1"));
            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 2, descricao: "Descricao 2"));
            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 3, descricao: "Descricao 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Descricao == "Descricao 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Descricao == "Descricao 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Descricao == "Descricao 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdPapel()
        {

            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 1, descricao: "Descricao 1"));
            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 2, descricao: "Descricao 2"));
            inMemoryPapelRepository.items.Add(new MakePapel().GetData(id: 3, descricao: "Descricao 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Descricao == "Descricao 2");

        }
    }
}
