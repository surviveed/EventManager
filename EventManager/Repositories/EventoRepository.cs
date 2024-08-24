﻿using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class EventoRepository
    {
        private readonly AppDbContext _context;

        public EventoRepository()
        {
            _context = new AppDbContext();
        }

        public List<Evento> BuscarTodos()
        {
            return _context.Eventos.Include("TipoEvento").OrderBy(u => u.Id).ToList();
        }

        public Evento BuscarPorId(int id)
        {
            return _context.Eventos.Include("TipoEvento").FirstOrDefault(u => u.Id == id);
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
