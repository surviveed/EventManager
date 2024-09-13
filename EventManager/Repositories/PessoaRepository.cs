using EventManager.Config;
using EventManager.Contracts;
using EventManager.Entities;
using EventManager.Entities.enums;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;

        public PessoaRepository()
        {
            _context = new AppDbContext();
        }

        public List<Pessoa> BuscarTodos()
        {
            return _context.Pessoas
                .Include(p => p.EventoOrganizadores)
                .Include(p => p.Avaliacoes)
                .Include(p => p.SessaoIntegrantes)
                .OrderBy(p => p.Id)
                .ToList();
        }

        public Pessoa BuscarPorId(int id)
        {
            return _context.Pessoas
                .Include(p => p.EventoOrganizadores)
                .Include(p => p.Avaliacoes)
                .Include(p => p.SessaoIntegrantes)
                .FirstOrDefault(p => p.Id == id);
        }

        public Pessoa BuscarPorTipoPessoa(TipoPessoa tipoPessoa)
        {
            return _context.Pessoas
                .Include(p => p.EventoOrganizadores)
                .Include(p => p.Avaliacoes)
                .Include(p => p.SessaoIntegrantes)
                .FirstOrDefault(p => p.TipoPessoa == tipoPessoa);
        }

        public void Inserir(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void Atualizar(Pessoa pessoa)
        {
            var pessoaExistente = _context.Pessoas.Find(pessoa.Id);
            if (pessoaExistente != null)
            {
                pessoaExistente.Nome = pessoa.Nome;
                pessoaExistente.Cpf = pessoa.Cpf;
                pessoaExistente.TipoPessoa = pessoa.TipoPessoa;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if (pessoa != null)
            {
                _context.Pessoas.Remove(pessoa);
                _context.SaveChanges();
            }
        }
    }
}
