using EventManager.Services;
using EventManager.Tests.Builder.Factories;
using EventManager.Tests.Builder.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class EventoServiceTest
    {
        private InMemoryEventoRepository inMemoryEventoRepository;
        private EventoService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryEventoRepository = new InMemoryEventoRepository();
            sut = new EventoService(inMemoryEventoRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewEvento()
        {
            var evento = new MakeEvento().GetDataDto();
            sut.Inserir(evento);

            var inMemoryEvento = inMemoryEventoRepository.items[0];

            Assert.IsNotNull(inMemoryEvento);
            Assert.AreEqual(inMemoryEvento.Id, 1);
            Assert.AreEqual(inMemoryEvento.Descricao, evento.Descricao);
            Assert.AreEqual(inMemoryEvento.Nome, evento.Nome);
            Assert.AreEqual(inMemoryEvento.TipoEventoId, evento.TipoEventoId);
        }

        [TestMethod]
        public void ShouldBeFindAllEvento()
        {

            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 1, nome: "Evento 1"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 2, nome: "Evento 2"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 3, nome: "Evento 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Nome == "Evento 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Nome == "Evento 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Nome == "Evento 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdTipoEvento()
        {

            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 1, nome: "Evento 1"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 2, nome: "Evento 2"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 3, nome: "Evento 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Nome == "Evento 2");

        }

        [TestMethod]
        public void ShouldBeDeleteTipoEvento()
        {

            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 1, nome: "Evento 1"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 2, nome: "Evento 2"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 3, nome: "Evento 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryEventoRepository.items);
            Assert.IsTrue(inMemoryEventoRepository.items.Count == 2);
            Assert.IsFalse(inMemoryEventoRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateTipoEvento()
        {

            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 1, descricao: "Tipo 1"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 2, descricao: "Tipo 2"));
            inMemoryEventoRepository.items.Add(new MakeEvento().GetData(id: 3, descricao: "Tipo 3"));

            sut.Atualizar(new MakeEvento().GetDataDto(id: 2,nome: "Updated Evento 2"));

            Assert.IsTrue(inMemoryEventoRepository.items.Any(x => x.Id == 2 && x.Nome == "Updated Evento 2"));
        }

    }
}
