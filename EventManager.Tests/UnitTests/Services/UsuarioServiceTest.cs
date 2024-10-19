using BCrypt.Net;
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
    public class UsuarioTest
    {
        private InMemoryUsuarioRepository inMemoryUsuarioRepository;
        private UsuarioService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryUsuarioRepository = new InMemoryUsuarioRepository();
            sut = new UsuarioService(inMemoryUsuarioRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewUsuario()
        {
            var usuarioDto = new MakeUsuario().GetDataDTO();
            sut.Inserir(usuarioDto);

            var inMemoryUsuario = inMemoryUsuarioRepository.items[0];

            Assert.IsNotNull(inMemoryUsuario);
            Assert.AreEqual(inMemoryUsuario.Id, 1);
            Assert.AreEqual(inMemoryUsuario.Nome, usuarioDto.Nome);
            Assert.AreEqual(inMemoryUsuario.Email, usuarioDto.Email);

           bool passVerify = BCrypt.Net.BCrypt.Verify(usuarioDto.Senha, inMemoryUsuario.Senha);

            Assert.IsTrue(passVerify);
        }

        [TestMethod]
        public void ShouldBeFindAllUsuario()
        {

            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 1, nome: "Nome 1"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 2, nome: "Nome 2"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 3, nome: "Nome 3"));

            var result = sut.BuscarTodos();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result.Any(x => x.Id == 1 && x.Nome == "Nome 1"));
            Assert.IsTrue(result.Any(x => x.Id == 2 && x.Nome == "Nome 2"));
            Assert.IsTrue(result.Any(x => x.Id == 3 && x.Nome == "Nome 3"));

        }

        [TestMethod]
        public void ShouldBeFindByIdUsuario()
        {

            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 1, nome: "Nome 1"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 2, nome: "Nome 2"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 3, nome: "Nome 3"));

            var result = sut.BuscarPorId(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == 2 && result.Nome == "Nome 2");

        }

        [TestMethod]
        public void ShouldBeDeleteUsuario()
        {

            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 1, nome: "Nome 1"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 2, nome: "Nome 2"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 3, nome: "Nome 3"));

            sut.Remover(2);

            Assert.IsNotNull(inMemoryUsuarioRepository.items);
            Assert.IsTrue(inMemoryUsuarioRepository.items.Count == 2);
            Assert.IsFalse(inMemoryUsuarioRepository.items.Any(x => x.Id == 2));
        }

        [TestMethod]
        public void ShouldBeUpdateUsuario()
        {

            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 1, nome: "Nome 1"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 2, nome: "Nome 2"));
            inMemoryUsuarioRepository.items.Add(new MakeUsuario().GetData(id: 3, nome: "Nome 3"));

            sut.Atualizar(new MakeUsuario().GetDataDTO(id: 2, "Updated NOME 2"));

            Assert.IsTrue(inMemoryUsuarioRepository.items.Any(x => x.Id == 2 && x.Nome == "Updated NOME 2"));
        }

    }

}
