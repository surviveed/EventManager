using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class EventoService
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public List<EventoDTO> BuscarTodosPorNomeETipoDeEvento(string nome = null, int? tipoEventoId = null)
        {
            var eventos = _eventoRepository.BuscarComFiltros(nome, tipoEventoId);
            return eventos.Select(evento => new EventoDTO(evento)).ToList();
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
            var evento = new Evento(0, eventoDto.Nome, eventoDto.Descricao, eventoDto.TipoEventoId);
            _eventoRepository.Inserir(evento);
        }

        public void Atualizar(EventoDTO eventoDto)
        {
            var evento = new Evento(eventoDto.Id, eventoDto.Nome, eventoDto.Descricao, eventoDto.TipoEventoId);
            _eventoRepository.Atualizar(evento);
        }

        public void Remover(int id)
        {
            _eventoRepository.Remover(id);
        }
    }
}
