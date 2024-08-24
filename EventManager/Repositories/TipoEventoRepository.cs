using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class TipoEventoRepository
    {
        private readonly AppDbContext _context;

        public TipoEventoRepository()
        {
            _context = new AppDbContext();
        }

        public List<TipoEvento> BuscarTodos()
        {
            return _context.TiposEvento.OrderBy(u => u.Id).ToList();
        }

        public TipoEvento BuscarPorId(int id)
        {
            return _context.TiposEvento.FirstOrDefault(u => u.Id == id);
        }

        public void Inserir(TipoEvento tipoEvento)
        {
            _context.TiposEvento.Add(tipoEvento);
            _context.SaveChanges();
        }

        public void Atualizar(TipoEvento tipoEvento)
        {
            var tipoEventoExistente = _context.TiposEvento.Find(tipoEvento.Id);
            if (tipoEventoExistente != null)
            {
                tipoEventoExistente.Descricao = tipoEvento.Descricao;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var tipoEvento = _context.TiposEvento.Find(id);
            if (tipoEvento != null)
            {
                _context.TiposEvento.Remove(tipoEvento);
                _context.SaveChanges();
            }
        }
    }
}
