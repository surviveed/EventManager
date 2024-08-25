using EventManager.DTOs;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class PapelService
    {
        private readonly PapelRepository _papelRepository;

        public PapelService(PapelRepository paisRepository)
        {
            _papelRepository = paisRepository;
        }

        public List<PapelDTO> BuscarTodos()
        {
            var papeis = _papelRepository.BuscarTodos();
            return papeis.Select(p => new PapelDTO(p)).ToList();
        }

        public PapelDTO BuscarPorId(int id)
        {
            var papel = _papelRepository.BuscarPorId(id);
            return papel != null ? new PapelDTO(papel) : null;
        }
    }
}
