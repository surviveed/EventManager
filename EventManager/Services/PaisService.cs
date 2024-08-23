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

        public IEnumerable<PaisDTO> ObterTodos()
        {
            var paises = _paisRepository.GetAll();
            return paises.Select(p => new PaisDTO(p)).ToList();
        }

        public PaisDTO ObterPorId(int id)
        {
            var pais = _paisRepository.GetById(id);
            return pais != null ? new PaisDTO(pais) : null;
        }

        public void Adicionar(PaisDTO paisDto)
        {
            var pais = new Pais(paisDto.Id, paisDto.Descricao, paisDto.CodigoIbge);
            _paisRepository.Insert(pais);
        }

        public void Atualizar(PaisDTO paisDto)
        {
            var pais = new Pais(paisDto.Id, paisDto.Descricao, paisDto.CodigoIbge);
            _paisRepository.Update(pais);
        }

        public void Remover(int id)
        {
            _paisRepository.Delete(id);
        }
    }
}
