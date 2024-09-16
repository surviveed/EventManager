using EventManager.Services;
using EventManager.Tests.Builder.Factories;
using EventManager.Tests.Builder.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class UfServiceTest
    {
        private InMemoryUfRepository inMemoryUfRepository;
        private UfService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryUfRepository = new InMemoryUfRepository();
            sut = new UfService(inMemoryUfRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewUf()
        {
            var uf = new MakeUF().GetDataDto();
            sut.Inserir(uf);

            var inMemoryUf = inMemoryUfRepository.items[0];

            Assert.IsNotNull(inMemoryUf);
            Assert.AreEqual(inMemoryUf.Id, 1);
            Assert.AreEqual(inMemoryUf.Descricao, uf.Descricao);
            Assert.AreEqual(inMemoryUf.CodigoIbge, uf.CodigoIbge);
           
        }

        [TestMethod]
        public void ShouldBeFindAllUf()
        {

            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 1, descricao: "Uf 1"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 2, descricao: "Uf 2"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 3, descricao: "Uf 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Descricao == "Uf 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Descricao == "Uf 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Descricao == "Uf 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdUf()
        {

            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 1, descricao: "Uf 1"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 2, descricao: "Uf 2"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 3, descricao: "Uf 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Descricao == "Uf 2");

        }

        [TestMethod]
        public void ShouldBeDeleteUf()
        {

            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 1, descricao: "Uf 1"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 2, descricao: "Uf 2"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 3, descricao: "Uf 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryUfRepository.items);
            Assert.IsTrue(inMemoryUfRepository.items.Count == 2);
            Assert.IsFalse(inMemoryUfRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateUf()
        {

            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 1, descricao: "Uf 1"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 2, descricao: "Uf 2"));
            inMemoryUfRepository.items.Add(new MakeUF().GetData(id: 3, descricao: "Uf 3"));

            sut.Atualizar(new MakeUF().GetDataDto(id: 2,descricao: "Updated Uf 2"));

            Assert.IsTrue(inMemoryUfRepository.items.Any(x => x.Id == 2 && x.Descricao == "Updated Uf 2"));
        }

    }
}
