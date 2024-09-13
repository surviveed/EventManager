using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryEventoRepository : IEventoRepository
    {
        public List<Evento> items { get; set; } = new List<Evento>();

        public void Atualizar(Evento evento)
        {
            var index = items.FindIndex(x => x.Id == evento.Id);
            items[index] = evento;

        }

        public List<Evento> BuscarComFiltros(string nome = null, int? tipoEventoId = null)
        {
          return this.items.FindAll(x => x.Nome == nome || x.TipoEventoId == tipoEventoId);
        }

        public Evento BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Evento> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Evento evento)
        {
            var nextval = this.items.Count() + 1;
            evento.Id = nextval;

            this.items.Add(evento);
        }

        public void Remover(int id)
        {
            var evento = this.items.FirstOrDefault(x => x.Id == id);

            if (evento != null)
                items.Remove(evento);
        }
    }
}
