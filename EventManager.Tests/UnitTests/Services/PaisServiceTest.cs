using EventManager.Services;
using EventManager.Tests.Builder.Factories;
using EventManager.Tests.Builder.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class PaisServiceTest
    {
        private InMemoryPaisRepository inMemoryPaisRepository;
        private PaisService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryPaisRepository = new InMemoryPaisRepository();
            sut = new PaisService(inMemoryPaisRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewPais()
        {
            var pais = new MakePais().GetDataDto();
            sut.Inserir(pais);

            var inMemoryPais = inMemoryPaisRepository.items[0];

            Assert.IsNotNull(inMemoryPais);
            Assert.AreEqual(inMemoryPais.Id, 1);
            Assert.AreEqual(inMemoryPais.Descricao, pais.Descricao);
            Assert.AreEqual(inMemoryPais.CodigoIbge, pais.CodigoIbge);
           
        }

        [TestMethod]
        public void ShouldBeFindAllPais()
        {

            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 1, descricao: "Pais 1"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 2, descricao: "Pais 2"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 3, descricao: "Pais 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Descricao == "Pais 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Descricao == "Pais 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Descricao == "Pais 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdTipoPais()
        {

            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 1, descricao: "Pais 1"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 2, descricao: "Pais 2"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 3, descricao: "Pais 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Descricao == "Pais 2");

        }

        [TestMethod]
        public void ShouldBeDeleteTipoPais()
        {

            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 1, descricao: "Pais 1"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 2, descricao: "Pais 2"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 3, descricao: "Pais 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryPaisRepository.items);
            Assert.IsTrue(inMemoryPaisRepository.items.Count == 2);
            Assert.IsFalse(inMemoryPaisRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateTipoPais()
        {

            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryPaisRepository.items.Add(new MakePais().GetData(id: 3, descricao: "Tipo 3"));

            sut.Atualizar(new MakePais().GetDataDto(id: 2,descricao: "Updated Pais 2"));

            Assert.IsTrue(inMemoryPaisRepository.items.Any(x => x.Id == 2 && x.Descricao == "Updated Pais 2"));
        }

    }
}
