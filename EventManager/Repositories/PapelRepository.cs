using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class PapelRepository
    {
        private readonly AppDbContext _context;

        public PapelRepository()
        {
            _context = new AppDbContext();
        }

        public List<Papel> BuscarTodos()
        {
            return _context.Papeis
                .OrderBy(p => p.Id).ToList();
        }

        public Papel BuscarPorId(int id)
        {
            return _context.Papeis
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
