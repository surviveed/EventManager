using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryTipoEventoRepository : ITipoEventoRepository
    {
        public List<TipoEvento> items { get; set; } = new List<TipoEvento>();

        public void Atualizar(TipoEvento tipoevento)
        {
            var index = items.FindIndex(x => x.Id == tipoevento.Id);
            items[index] = tipoevento;

        }

        public TipoEvento BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<TipoEvento> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(TipoEvento tipoevento)
        {
            var nextval = this.items.Count() + 1;
            tipoevento.Id = nextval;

            this.items.Add(tipoevento);
        }

        public void Remover(int id)
        {
            var tipoevento = this.items.FirstOrDefault(x => x.Id == id);

            if (tipoevento != null)
                items.Remove(tipoevento);
        }
    }
}
