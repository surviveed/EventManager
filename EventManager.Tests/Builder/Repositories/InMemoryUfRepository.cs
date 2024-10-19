using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryUfRepository : IUfRepository
    {
        public List<Uf> items { get; set; } = new List<Uf>();

        public void Atualizar(Uf uf)
        {
            var index = items.FindIndex(x => x.Id == uf.Id);
            items[index] = uf;

        }

        public Uf BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Uf> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Uf uf)
        {
            var nextval = this.items.Count() + 1;
            uf.Id = nextval;

            this.items.Add(uf);
        }

        public void Remover(int id)
        {
            var uf = this.items.FirstOrDefault(x => x.Id == id);

            if (uf != null)
                items.Remove(uf);
        }
    }
}
