using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class AvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public AvaliacaoRepository()
        {
            _context = new AppDbContext();
        }

        public List<Avaliacao> BuscarTodos()
        {
            return _context.Avaliacoes
                .Include(a => a.Pessoa)
                .Include(a => a.Sessao)
                .OrderBy(a => a.Id).ToList();
        }

        public Avaliacao BuscarPorId(int id)
        {
            return _context.Avaliacoes
                .Include(a => a.Pessoa)
                .Include(a => a.Sessao)
                .FirstOrDefault(a => a.Id == id);
        }

        public void Inserir(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            _context.SaveChanges();
        }

        public void Atualizar(Avaliacao avaliacao)
        {
            var avaliacaoExistente = _context.Avaliacoes.Find(avaliacao.Id);
            if (avaliacaoExistente != null)
            {
                avaliacaoExistente.Comentario = avaliacao.Comentario;
                avaliacaoExistente.Nota = avaliacao.Nota;
                avaliacaoExistente.PessoaId = avaliacao.PessoaId;
                avaliacaoExistente.SessaoId = avaliacao.SessaoId;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var avaliacao = _context.Avaliacoes.Find(id);
            if (avaliacao != null)
            {
                _context.Avaliacoes.Remove(avaliacao);
                _context.SaveChanges();
            }
        }
    }
}
