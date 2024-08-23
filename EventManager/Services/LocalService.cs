using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class LocalService
    {
        private readonly LocalRepository _localRepository;

        public LocalService(LocalRepository localRepository)
        {
            _localRepository = localRepository;
        }

        public List<LocalDTO> BuscarTodos()
        {
            var locais = _localRepository.BuscarTodos();
            return locais.Select(local => new LocalDTO(local)).ToList();
        }

        public LocalDTO BuscarPorId(int id)
        {
            var local = _localRepository.BuscarPorId(id);
            return local != null ? new LocalDTO(local) : null;
        }

        public void Inserir(LocalDTO localDto)
        {
            var cidade = new Cidade(localDto.CidadeId, localDto.CidadeDescricao, 0, null);
            var local = new Local(0, localDto.Nome, localDto.Capacidade, localDto.Endereco, localDto.Observacoes, cidade);
            _localRepository.Inserir(local);
        }

        public void Atualizar(LocalDTO localDto)
        {
            var cidade = new Cidade(localDto.CidadeId, localDto.CidadeDescricao, 0, null);
            var local = new Local(localDto.Id, localDto.Nome, localDto.Capacidade, localDto.Endereco, localDto.Observacoes, cidade);
            _localRepository.Atualizar(local);
        }

        public void Remover(int id)
        {
            _localRepository.Remover(id);
        }
    }
}
