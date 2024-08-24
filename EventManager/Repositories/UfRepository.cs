using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class UfRepository
    {
        private readonly AppDbContext _context;

        public UfRepository()
        {
            _context = new AppDbContext();
        }

        public List<Uf> BuscarTodos()
        {
            return _context.Ufs.Include("Pais").OrderBy(u => u.Id).ToList();
        }

        public Uf BuscarPorId(int id)
        {
            return _context.Ufs.Include("Pais").FirstOrDefault(u => u.Id == id);
        }

        public void Inserir(Uf uf)
        {
            _context.Ufs.Add(uf);
            _context.SaveChanges();
        }

        public void Atualizar(Uf uf)
        {
            var ufExistente = _context.Ufs.Find(uf.Id);
            if (ufExistente != null)
            {
                ufExistente.Descricao = uf.Descricao;
                ufExistente.CodigoIbge = uf.CodigoIbge;
                ufExistente.PaisId = uf.PaisId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var uf = _context.Ufs.Find(id);
            if (uf != null)
            {
                _context.Ufs.Remove(uf);
                _context.SaveChanges();
            }
        }
    }
}
