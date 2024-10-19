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
    public class LocalTest
    {
        private InMemoryLocalRepository inMemoryLocalRepository;
        private LocalService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryLocalRepository = new InMemoryLocalRepository();
            sut = new LocalService(inMemoryLocalRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewLocal()
        {
            var localDto = new MakeLocal().GetDataDTO();
            sut.Inserir(localDto);

            var inMemoryLocal = inMemoryLocalRepository.items[0];

            Assert.IsNotNull(inMemoryLocal);
            Assert.AreEqual(inMemoryLocal.Id, 1);
            Assert.AreEqual(inMemoryLocal.Nome, localDto.Nome);
            Assert.AreEqual(inMemoryLocal.Observacoes, localDto.Observacoes);
            Assert.AreEqual(inMemoryLocal.Capacidade, localDto.Capacidade);
            Assert.AreEqual(inMemoryLocal.CidadeId, localDto.CidadeId);
        }

        [TestMethod]
        public void ShouldBeFindAllLocal()
        {

            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 1, nome: "Nome 1"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 2, nome: "Nome 2"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 3, nome: "Nome 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Nome == "Nome 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Nome == "Nome 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Nome == "Nome 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdLocal()
        {

            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 1, nome: "Nome 1"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 2, nome: "Nome 2"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 3, nome: "Nome 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Nome == "Nome 2");

        }

        [TestMethod]
        public void ShouldBeDeleteLocal()
        {

            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 1, nome: "Nome 1"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 2, nome: "Nome 2"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 3, nome: "Nome 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryLocalRepository.items);
            Assert.IsTrue(inMemoryLocalRepository.items.Count == 2);
            Assert.IsFalse(inMemoryLocalRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateLocal()
        {

            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 1, nome: "Nome 1"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 2, nome: "Nome 2"));
            inMemoryLocalRepository.items.Add(new MakeLocal().GetData(id: 3, nome: "Nome 3"));

            sut.Atualizar(new MakeLocal().GetDataDTO(id: 2, "Updated NOME 2"));

            Assert.IsTrue(inMemoryLocalRepository.items.Any(x => x.Id == 2 && x.Nome == "Updated NOME 2"));
        }

    }

}
