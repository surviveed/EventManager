using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Services;
using EventManager.Tests.Builder.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EventManager.Tests.UnitTests.Services
{
    [TestClass]
    public class AvaliacaoServiceTest
    {
        private InMemoryAvaliacaoRepository inMemoryAvaliacaoRepository;
        private AvaliacaoService sut;

        [TestInitialize]
        public void Setup()
        {
            inMemoryAvaliacaoRepository = new InMemoryAvaliacaoRepository();
            sut = new AvaliacaoService(inMemoryAvaliacaoRepository);
        }

        [TestMethod]
        public void ShouldBeCreateANewAvaliacao()
        {
            var avalicao = new AvaliacaoDTO
            {
                Comentario = "Example",
                Nota = 1,
                PessoaId = 1,
                PessoaNome = "John Doe",
                SessaoId = 1
            };
            sut.Inserir(avalicao);

            var inMemoryAvaliacao = inMemoryAvaliacaoRepository.items.FirstOrDefault(x => x.Id == 1);

            Assert.IsNotNull(inMemoryAvaliacao);
            Assert.AreEqual(inMemoryAvaliacao.Id, 1);
            Assert.AreEqual(inMemoryAvaliacao.Comentario, avalicao.Comentario);
            Assert.AreEqual(inMemoryAvaliacao.Nota, avalicao.Nota);
            Assert.AreEqual(inMemoryAvaliacao.PessoaId, avalicao.PessoaId);
            Assert.AreEqual(inMemoryAvaliacao.SessaoId, avalicao.SessaoId);

        }

        [TestMethod]
        public void ShouldBeGetAllAvaliacao()
        {
            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 1,
                Comentario = "Example",
                Nota = 1,
                PessoaId = 1,
                Pessoa = new Pessoa
                {
                    Id = 1,
                    Nome = "John Doe"
                },
                SessaoId = 1,
                Sessao = new Sessao
                {
                    Id = 1
                }
            });

            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 2,
                Comentario = "Example 2",
                Nota = 2,
                PessoaId = 2,
                Pessoa = new Pessoa
                {
                    Id = 2,
                    Nome = "John Doe 2"
                },
                SessaoId = 2,
                Sessao = new Sessao
                {
                    Id = 2
                }
            });

            var avaliacoes = sut.BuscarTodos();

            Assert.IsNotNull(avaliacoes);
            Assert.IsTrue(inMemoryAvaliacaoRepository.items.Count == 2);
            Assert.AreEqual(avaliacoes[0].Id, 1);
            Assert.AreEqual(avaliacoes[0].Comentario, "Example");
            Assert.AreEqual(avaliacoes[0].Nota, 1);
            Assert.AreEqual(avaliacoes[0].PessoaId, 1);
            Assert.AreEqual(avaliacoes[0].SessaoId, 1);

        }

        [TestMethod]
        public void ShouldBeAvaliacaoById()
        {
            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 1,
                Comentario = "Example",
                Nota = 1,
                PessoaId = 1,
                Pessoa = new Pessoa
                {
                    Id = 1,
                    Nome = "John Doe"
                },
                SessaoId = 1,
                Sessao = new Sessao
                {
                    Id = 1
                }
            });

            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 2,
                Comentario = "Example 2",
                Nota = 2,
                PessoaId = 2,
                Pessoa = new Pessoa
                {
                    Id = 2,
                    Nome = "John Doe 2"
                },
                SessaoId = 2,
                Sessao = new Sessao
                {
                    Id = 2
                }
            });

            var avaliacoes = sut.BuscarPorId(2);

            Assert.IsNotNull(avaliacoes);
            Assert.AreEqual(avaliacoes.Id, 2);
            Assert.AreEqual(avaliacoes.Comentario, "Example 2");
            Assert.AreEqual(avaliacoes.Nota, 2);
            Assert.AreEqual(avaliacoes.PessoaId, 2);
            Assert.AreEqual(avaliacoes.PessoaNome, "John Doe 2");
            Assert.AreEqual(avaliacoes.SessaoId, 2);

        }

        [TestMethod]
        public void ShouldBeDeleteAvaliacao()
        {
            var avalicao = new AvaliacaoDTO
            {
                Comentario = "Example",
                Nota = 1,
                PessoaId = 1,
                PessoaNome = "John Doe",
                SessaoId = 1
            };

            sut.Inserir(avalicao);
            sut.Remover(1);

            
            Assert.IsTrue(inMemoryAvaliacaoRepository.items.Count == 0);
        }

        [TestMethod]
        public void ShouldBeUpdateAvaliacao()
        {
            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 1,
                Comentario = "Example",
                Nota = 1,
                PessoaId = 1,
                Pessoa = new Pessoa
                {
                    Id = 1,
                    Nome = "John Doe"
                },
                SessaoId = 1,
                Sessao = new Sessao
                {
                    Id = 1
                }
            });

            inMemoryAvaliacaoRepository.items.Add(new Avaliacao
            {
                Id = 2,
                Comentario = "Example 2",
                Nota = 2,
                PessoaId = 2,
                Pessoa = new Pessoa
                {
                    Id = 2,
                    Nome = "John Doe 2"
                },
                SessaoId = 2,
                Sessao = new Sessao
                {
                    Id = 2
                }
            });

            var avalicao = new AvaliacaoDTO
            {
                Id = 2,
                Comentario = "Example UPDATED",
                Nota = 1,
                PessoaId = 1,
                PessoaNome = "John Doe",
                SessaoId = 1
            };

            sut.Atualizar(avalicao);

            var inmemoryResult = inMemoryAvaliacaoRepository.items.FirstOrDefault(x => x.Id == 2);

            Assert.IsNotNull(inmemoryResult);
            Assert.AreEqual(inmemoryResult.Id, avalicao.Id);
            Assert.AreEqual(inmemoryResult.Comentario, avalicao.Comentario);
        }

    }

}
