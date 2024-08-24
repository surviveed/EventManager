using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class PaisService
    {
        private readonly PaisRepository _paisRepository;

        public PaisService(PaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public List<PaisDTO> ObterTodos()
        {
            var paises = _paisRepository.BuscarTodos();
            return paises.Select(p => new PaisDTO(p)).ToList();
        }

        public PaisDTO BuscarPorId(int id)
        {
            var pais = _paisRepository.BuscarPorId(id);
            return pais != null ? new PaisDTO(pais) : null;
        }

        public void Inserir(PaisDTO paisDto)
        {
            var pais = new Pais(0, paisDto.Descricao, paisDto.CodigoIbge);
            _paisRepository.Inserir(pais);
        }

        public void Atualizar(PaisDTO paisDto)
        {
            var pais = new Pais(paisDto.Id, paisDto.Descricao, paisDto.CodigoIbge);
            _paisRepository.Atualizar(pais);
        }

        public void Remover(int id)
        {
            _paisRepository.Remover(id);
        }
    }
}
