using EventManager.Config;
using EventManager.Contracts;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly AppDbContext _context;

        public EventoRepository()
        {
            _context = new AppDbContext();
        }

        public List<Evento> BuscarTodos()
        {
            return BuscarComFiltros(null, null); 
        }

        public List<Evento> BuscarComFiltros(string nome = null, int? tipoEventoId = null)
        {
            var query = _context.Eventos
                .Include(e => e.TipoEvento)
                .Include(e => e.Sessoes)
                .AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(e => e.Nome.Contains(nome));
            }

            if (tipoEventoId.HasValue)
            {
                query = query.Where(e => e.TipoEventoId == tipoEventoId.Value);
            }

            var eventos = query.OrderBy(u => u.Id).ToList();

            // Carrega avaliações para cada sessão
            foreach (var evento in eventos)
            {
                foreach (var sessao in evento.Sessoes)
                {
                    _context.Entry(sessao).Collection(s => s.Avaliacoes).Load();
                }
            }

            return eventos;
        }

        public Evento BuscarPorId(int id)
        {
            var evento = _context.Eventos
                .Include(e => e.TipoEvento)
                .Include(e => e.Sessoes)
                .FirstOrDefault(u => u.Id == id);

            if (evento != null)
            {
                // Carrega avaliações para cada sessão
                foreach (var sessao in evento.Sessoes)
                {
                    _context.Entry(sessao).Collection(s => s.Avaliacoes).Load();
                }
            }

            return evento;
        }

        public void Inserir(Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
        }

        public void Atualizar(Evento evento)
        {
            var eventoExistente = _context.Eventos.Find(evento.Id);
            if (eventoExistente != null)
            {
                eventoExistente.Nome = evento.Nome;
                eventoExistente.Descricao = evento.Descricao;
                eventoExistente.TipoEventoId = evento.TipoEventoId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var evento = _context.Eventos.Find(id);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
            }
        }
    }
}
