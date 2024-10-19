using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryPapelRepository : IPapelRepository
    {
        public List<Papel> items { get; set; } = new List<Papel>();

        public void Atualizar(Papel papel)
        {
            var index = items.FindIndex(x => x.Id == papel.Id);
            items[index] = papel;

        }

        public Papel BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Papel> BuscarTodos()
        {
            return items.ToList();
        }
    }
}
