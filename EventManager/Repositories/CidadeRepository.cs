using EventManager.Config;
using EventManager.Contracts;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly AppDbContext _context;

        public CidadeRepository()
        {
            _context = new AppDbContext();
        }

        public List<Cidade> BuscarTodos()
        {
            return _context.Cidades
                .Include(c => c.Uf)
                .Include(c => c.Locais)
                .OrderBy(c => c.Id).ToList();
        }

        public Cidade BuscarPorId(int id)
        {
            return _context.Cidades
                .Include(c => c.Uf)
                .Include(c => c.Locais)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Inserir(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            _context.SaveChanges();
        }

        public void Atualizar(Cidade cidade)
        {
            var cidadeExistente = _context.Cidades.Find(cidade.Id);
            if (cidadeExistente != null)
            {
                cidadeExistente.Descricao = cidade.Descricao;
                cidadeExistente.CodigoIbge = cidade.CodigoIbge;
                cidadeExistente.UfId = cidade.UfId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var cidade = _context.Cidades.Find(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
                _context.SaveChanges();
            }
        }
    }
}
