using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryPaisRepository : IPaisRepository
    {
        public List<Pais> items { get; set; } = new List<Pais>();

        public void Atualizar(Pais pais)
        {
            var index = items.FindIndex(x => x.Id == pais.Id);
            items[index] = pais;

        }

        public Pais BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Pais> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Pais pais)
        {
            var nextval = this.items.Count() + 1;
            pais.Id = nextval;

            this.items.Add(pais);
        }

        public void Remover(int id)
        {
            var pais = this.items.FirstOrDefault(x => x.Id == id);

            if (pais != null)
                items.Remove(pais);
        }
    }
}
