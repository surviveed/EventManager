﻿using EventManager.Config;
using EventManager.Contracts;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EventManager.Repositories
{
    public class PaisRepository : IPaisRepository
    {
        private readonly AppDbContext _context;

        public PaisRepository()
        {
            _context = new AppDbContext();
        }

        public List<Pais> BuscarTodos()
        {
            return _context.Paises
                .Include(p => p.Ufs)
                .OrderBy(p => p.Id).ToList();
        }

        public Pais BuscarPorId(int id)
        {
            return _context.Paises
                .Include(p => p.Ufs)
                .FirstOrDefault(p => p.Id == id);
        }

        public void Inserir(Pais pais)
        {
            _context.Paises.Add(pais);
            _context.SaveChanges();
        }

        public void Atualizar(Pais pais)
        {
            var paisExistente = _context.Paises.Find(pais.Id);
            if (paisExistente != null)
            {
                paisExistente.Descricao = pais.Descricao;
                paisExistente.CodigoIbge = pais.CodigoIbge;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var pais = _context.Paises.Find(id);
            if (pais != null)
            {
                _context.Paises.Remove(pais);
                _context.SaveChanges();
            }
        }
    }
}
