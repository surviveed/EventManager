using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    internal class InMemoryCidadeRepository : ICidadeRepository
    {
        public List<Cidade> items { get; set; } = new List<Cidade>();

        public void Atualizar(Cidade cidade)
        {
            var index = items.FindIndex(x => x.Id == cidade.Id);
            items[index] = cidade;

        }

        public Cidade BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Cidade> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Cidade cidade)
        {
            var nextval = this.items.Count() + 1;
            cidade.Id = nextval;

            this.items.Add(cidade);
        }

        public void Remover(int id)
        {
            var cidade = this.items.FirstOrDefault(x => x.Id == id);

            if (cidade != null)
                items.Remove(cidade);
        }
    }
}
