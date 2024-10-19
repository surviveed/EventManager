using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class CidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public List<CidadeDTO> BuscarTodos()
        {
            var cidades = _cidadeRepository.BuscarTodos();
            return cidades.Select(cidade => new CidadeDTO(cidade)).ToList();
        }

        public CidadeDTO BuscarPorId(int id)
        {
            var cidade = _cidadeRepository.BuscarPorId(id);
            return cidade != null ? new CidadeDTO(cidade) : null;
        }

        public void Inserir(CidadeDTO cidadeDto)
        {
            var cidade = new Cidade
            {
                Id = 0,
                Descricao = cidadeDto.Descricao,
                CodigoIbge = cidadeDto.CodigoIbge,
                UfId = cidadeDto.UfId
            };
            _cidadeRepository.Inserir(cidade);
        }

        public void Atualizar(CidadeDTO cidadeDto)
        {
            var cidade = new Cidade
            {
                Id = cidadeDto.Id,
                Descricao = cidadeDto.Descricao,
                CodigoIbge = cidadeDto.CodigoIbge,
                UfId = cidadeDto.UfId
            };
            _cidadeRepository.Atualizar(cidade);
        }

        public void Remover(int id)
        {
            _cidadeRepository.Remover(id);
        }
    }
}
