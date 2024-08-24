using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class EventoService
    {
        private readonly EventoRepository _eventoRepository;

        public EventoService(EventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public List<EventoDTO> BuscarTodos()
        {
            var eventos = _eventoRepository.BuscarTodos();
            return eventos.Select(evento => new EventoDTO(evento)).ToList();
        }

        public EventoDTO BuscarPorId(int id)
        {
            var evento = _eventoRepository.BuscarPorId(id);
            return evento != null ? new EventoDTO(evento) : null;
        }

        public void Inserir(EventoDTO eventoDto)
        {
            var tipoEvento = new TipoEvento(eventoDto.TipoEventoId, eventoDto.TipoEventoDescricao);
            var evento = new Evento(0, eventoDto.Nome, eventoDto.Descricao, tipoEvento);
            _eventoRepository.Inserir(evento);
        }

        public void Atualizar(EventoDTO eventoDto)
        {
            var tipoEvento = new TipoEvento(eventoDto.TipoEventoId, eventoDto.TipoEventoDescricao);
            var evento = new Evento(eventoDto.Id, eventoDto.Nome, eventoDto.Descricao, tipoEvento);
            _eventoRepository.Atualizar(evento);
        }

        public void Remover(int id)
        {
            _eventoRepository.Remover(id);
        }
    }
}
