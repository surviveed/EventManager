using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class UfService
    {
        private readonly UfRepository _ufRepository;

        public UfService(UfRepository ufRepository)
        {
            _ufRepository = ufRepository;
        }

        public List<UfDTO> BuscarTodos()
        {
            var ufs = _ufRepository.BuscarTodos();
            return ufs.Select(uf => new UfDTO(uf)).ToList();
        }

        public UfDTO BuscarPorId(int id)
        {
            var uf = _ufRepository.BuscarPorId(id);
            return uf != null ? new UfDTO(uf) : null;
        }

        public void Inserir(UfDTO ufDto)
        {
            var uf = new Uf(0, ufDto.Descricao, ufDto.CodigoIbge, ufDto.PaisId);
            _ufRepository.Inserir(uf);
        }

        public void Atualizar(UfDTO ufDto)
        {
            var uf = new Uf(ufDto.Id, ufDto.Descricao, ufDto.CodigoIbge, ufDto.PaisId);
            _ufRepository.Atualizar(uf);
        }

        public void Remover(int id)
        {
            _ufRepository.Remover(id);
        }
    }
}
