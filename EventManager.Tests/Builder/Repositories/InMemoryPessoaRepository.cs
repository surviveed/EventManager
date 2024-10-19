using EventManager.Contracts;
using EventManager.Entities;
using EventManager.Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryPessoaRepository : IPessoaRepository
    {
        public List<Pessoa> items { get; set; } = new List<Pessoa>();

        public void Atualizar(Pessoa pessoa)
        {
            var index = items.FindIndex(x => x.Id == pessoa.Id);
            items[index] = pessoa;

        }

        public Pessoa BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public Pessoa BuscarPorTipoPessoa(TipoPessoa tipoPessoa)
        {
            return this.items.FirstOrDefault(x => x.TipoPessoa == tipoPessoa);
        }

        public List<Pessoa> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Pessoa pessoa)
        {
            var nextval = this.items.Count() + 1;
            pessoa.Id = nextval;

            this.items.Add(pessoa);
        }

        public void Remover(int id)
        {
            var pessoa = this.items.FirstOrDefault(x => x.Id == id);

            if (pessoa != null)
                items.Remove(pessoa);
        }
    }
}
