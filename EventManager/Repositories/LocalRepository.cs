using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class LocalRepository
    {
        private readonly AppDbContext _context;

        public LocalRepository()
        {
            _context = new AppDbContext();
        }

        public List<Local> BuscarTodos()
        {
            return _context.Locais.Include("Cidade").OrderBy(u => u.Id).ToList();
        }

        public Local BuscarPorId(int id)
        {
            return _context.Locais.Include("Cidade").FirstOrDefault(u => u.Id == id);
        }

        public void Inserir(Local Local)
        {
            _context.Locais.Add(Local);
            _context.SaveChanges();
        }

        public void Atualizar(Local Local)
        {
            var LocalExistente = _context.Locais.Find(Local.Id);
            if (LocalExistente != null)
            {
                LocalExistente.Nome = Local.Nome;
                LocalExistente.Capacidade = Local.Capacidade;
                LocalExistente.Endereco = Local.Endereco;
                LocalExistente.Observacoes = Local.Observacoes;
                LocalExistente.CidadeId = Local.CidadeId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var Local = _context.Locais.Find(id);
            if (Local != null)
            {
                _context.Locais.Remove(Local);
                _context.SaveChanges();
            }
        }
    }
}
