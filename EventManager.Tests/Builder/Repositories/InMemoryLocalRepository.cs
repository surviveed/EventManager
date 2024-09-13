using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryLocalRepository : ILocalRepository
    {
        public List<Local> items { get; set; } = new List<Local>();

        public void Atualizar(Local local)
        {
            var index = items.FindIndex(x => x.Id == local.Id);
            items[index] = local;

        }

        public Local BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Local> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Local local)
        {
            var nextval = this.items.Count() + 1;
            local.Id = nextval;

            this.items.Add(local);
        }

        public void Remover(int id)
        {
            var local = this.items.FirstOrDefault(x => x.Id == id);

            if (local != null)
                items.Remove(local);
        }
    }
}
