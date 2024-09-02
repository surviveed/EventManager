using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    internal class InMemoryAvaliacaoRepository : IAvaliacaoRepository
    {
        public List<Avaliacao> items { get; set; } = new List<Avaliacao>();

        public void Atualizar(Avaliacao avaliacao)
        {
            var index = items.FindIndex(x => x.Id == avaliacao.Id);
            items[index] = avaliacao;

        }

        public Avaliacao BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Avaliacao> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Avaliacao avaliacao)
        {
            var nextval = this.items.Count() + 1;
            avaliacao.Id = nextval;

            this.items.Add(avaliacao);
        }

        public void Remover(int id)
        {
            var avaliacao = this.items.FirstOrDefault(x => x.Id == id);

            if (avaliacao != null)
                items.Remove(avaliacao);
        }
    }
}
