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
    public class TipoEventoTest
    {
        private InMemoryTipoEventoRepository inMemoryTipoEventoRepository;
        private TipoEventoService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryTipoEventoRepository = new InMemoryTipoEventoRepository();
            sut = new TipoEventoService(inMemoryTipoEventoRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewTipoEvento()
        {
            var tipoEventoDto = new MakeTipoEvento().GetDataDTO();
            sut.Inserir(tipoEventoDto);

            var inMemoryTipoEvento = inMemoryTipoEventoRepository.items[0];

            Assert.IsNotNull(inMemoryTipoEvento);
            Assert.AreEqual(inMemoryTipoEvento.Id, 1);
            Assert.AreEqual(inMemoryTipoEvento.Descricao, tipoEventoDto.Descricao);
        }

        [TestMethod]
        public void ShouldBeFindAllTipoEvento()
        {

            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 3, descricao: "Tipo 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Descricao == "Tipo 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Descricao == "Tipo 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Descricao == "Tipo 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdTipoEvento()
        {

            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 3, descricao: "Tipo 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Descricao == "Tipo 2");

        }

        [TestMethod]
        public void ShouldBeDeleteTipoEvento()
        {

            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 3, descricao: "Tipo 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryTipoEventoRepository.items);
            Assert.IsTrue(inMemoryTipoEventoRepository.items.Count == 2);
            Assert.IsFalse(inMemoryTipoEventoRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateTipoEvento()
        {

            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryTipoEventoRepository.items.Add(new MakeTipoEvento().GetData(id: 3, descricao: "Tipo 3"));

            sut.Atualizar(new MakeTipoEvento().GetDataDTO(id: 2, "Updated TIPO 2"));

            Assert.IsTrue(inMemoryTipoEventoRepository.items.Any(x => x.Id == 2 && x.Descricao == "Updated TIPO 2"));
        }

    }

}
