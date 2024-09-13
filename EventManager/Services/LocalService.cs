using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class LocalService
    {
        private readonly ILocalRepository _localRepository;

        public LocalService(ILocalRepository localRepository)
        {
            _localRepository = localRepository;
        }

        public List<LocalDTO> BuscarTodos()
        {
            var locais = _localRepository.BuscarTodos();
            return locais.Select(Local => new LocalDTO(Local)).ToList();
        }

        public LocalDTO BuscarPorId(int id)
        {
            var local = _localRepository.BuscarPorId(id);
            return local != null ? new LocalDTO(local) : null;
        }

        public void Inserir(LocalDTO localDTO)
        {
            var local = new Local(0, localDTO.Nome, localDTO.Capacidade, localDTO.Endereco, localDTO.Observacoes, localDTO.CidadeId);
            _localRepository.Inserir(local);
        }

        public void Atualizar(LocalDTO localDTO)
        {
            var local = new Local(localDTO.Id, localDTO.Nome, localDTO.Capacidade, localDTO.Endereco, localDTO.Observacoes, localDTO.CidadeId);
            _localRepository.Atualizar(local);
        }

        public void Remover(int id)
        {
            _localRepository.Remover(id);
        }
    }
}
