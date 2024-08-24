using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class SessaoRepository
    {
        private readonly AppDbContext _context;

        public SessaoRepository()
        {
            _context = new AppDbContext();
        }

        public List<Sessao> BuscarTodos()
        {
            return _context.Sessoes
                .Include(s => s.Evento)
                .Include(s => s.Local)
                .Include(s => s.Avaliacoes)
                .Include(s => s.SessaoIntegrantes)
                .OrderBy(u => u.Id).ToList();
        }

        public Sessao BuscarPorId(int id)
        {
            return _context.Sessoes
                .Include(s => s.Evento)
                .Include(s => s.Local)
                .Include(s => s.Avaliacoes)
                .Include(s => s.SessaoIntegrantes)
                .FirstOrDefault(s => s.Id == id);
        }

        public void Inserir(Sessao sessao)
        {
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
        }

        public void Atualizar(Sessao sessao)
        {
            var sessaoExistente = _context.Sessoes.Find(sessao.Id);
            if (sessaoExistente != null)
            {
                sessaoExistente.DataInicio = sessao.DataInicio;
                sessaoExistente.DataFim = sessao.DataFim;
                sessaoExistente.LocalId = sessao.LocalId;
                sessaoExistente.EventoId = sessao.EventoId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var sessao = _context.Sessoes.Find(id);
            if (sessao != null)
            {
                _context.Sessoes.Remove(sessao);
                _context.SaveChanges();
            }
        }
    }
}
