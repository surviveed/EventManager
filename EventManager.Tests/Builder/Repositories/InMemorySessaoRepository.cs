using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemorySessaoRepository : ISessaoRepository
    {
        public List<Sessao> items { get; set; } = new List<Sessao>();

        public void Atualizar(Sessao sessao)
        {
            var index = items.FindIndex(x => x.Id == sessao.Id);
            items[index] = sessao;

        }

        public void AtualizarIntegrantes(Sessao sessao, List<Pessoa> integrantes)
        {
            var find = this.items.FirstOrDefault(x => x.Id == sessao.Id);
            var index = this.items.FindIndex(x => x.Id == sessao.Id);

            foreach(var pessoa in integrantes)
            {
                find.SessaoIntegrantes.Add(new SessaoIntegrante() {
                    Sessao = sessao,
                    SessaoId = sessao.Id,
                    Pessoa = pessoa,
                    PessoaId = pessoa.Id
                });
            }

            items[index] = find;
        }

        public Sessao BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Sessao> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Sessao sessao)
        {
            var nextval = this.items.Count() + 1;
            sessao.Id = nextval;

            this.items.Add(sessao);
        }

        public void Remover(int id)
        {
            var sessao = this.items.FirstOrDefault(x => x.Id == id);

            if (sessao != null)
                items.Remove(sessao);
        }
    }
}
