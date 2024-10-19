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

        [TestMethod]
        public void ShouldBeFindAllCidade()
        {

            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 1, descricao: "cidade 1"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 2, descricao: "cidade 2"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 3, descricao: "cidade 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Descricao == "cidade 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Descricao == "cidade 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Descricao == "cidade 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdCidade()
        {

            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 1, descricao: "cidade 1"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 2, descricao: "cidade 2"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 3, descricao: "cidade 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Descricao == "cidade 2");

        }

        [TestMethod]
        public void ShouldBeDeleteCidade()
        {

            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 1, descricao: "cidade 1"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 2, descricao: "cidade 2"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 3, descricao: "cidade 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryCidadeRepository.items);
            Assert.IsTrue(inMemoryCidadeRepository.items.Count == 2);
            Assert.IsFalse(inMemoryCidadeRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateCidade()
        {

            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 1, descricao: "cidade 1"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 2, descricao: "cidade 2"));
            inMemoryCidadeRepository.items.Add(new MakeCidade().GetData(id: 3, descricao: "cidade 3"));

            sut.Atualizar(new MakeCidade().GetDataDto(id: 2, descricao: "Updated cidade 2"));

            Assert.IsTrue(inMemoryCidadeRepository.items.Any(x => x.Id == 2 && x.Descricao == "Updated cidade 2"));
        }

    }

}
