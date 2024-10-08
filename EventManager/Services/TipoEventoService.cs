﻿using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class TipoEventoService
    {
        private readonly ITipoEventoRepository _tipoEventoRepository;

        public TipoEventoService(ITipoEventoRepository tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }

        public List<TipoEventoDTO> BuscarTodos()
        {
            var tipoEventos = _tipoEventoRepository.BuscarTodos();
            return tipoEventos.Select(tipoEvento => new TipoEventoDTO(tipoEvento)).ToList();
        }

        public TipoEventoDTO BuscarPorId(int id)
        {
            var tipoEvento = _tipoEventoRepository.BuscarPorId(id);
            return tipoEvento != null ? new TipoEventoDTO(tipoEvento) : null;
        }

        public void Inserir(TipoEventoDTO tipoEventoDto)
        {
            var tipoEvento = new TipoEvento(0, tipoEventoDto.Descricao);
            _tipoEventoRepository.Inserir(tipoEvento);
        }

        public void Atualizar(TipoEventoDTO tipoEventoDto)
        {
            var tipoEvento = new TipoEvento(tipoEventoDto.Id, tipoEventoDto.Descricao);
            _tipoEventoRepository.Atualizar(tipoEvento);
        }

        public void Remover(int id)
        {
            _tipoEventoRepository.Remover(id);
        }
    }
}
