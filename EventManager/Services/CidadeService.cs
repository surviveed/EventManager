using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class CidadeService
    {
        private readonly CidadeRepository _cidadeRepository;

        public CidadeService(CidadeRepository cidadeRepository)
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
            var uf = new Uf(cidadeDto.UfId, cidadeDto.UfDescricao, 0, null);
            var cidade = new Cidade(0, cidadeDto.Descricao, cidadeDto.CodigoIbge, uf);
            _cidadeRepository.Inserir(cidade);
        }

        public void Atualizar(CidadeDTO cidadeDto)
        {
            var uf = new Uf(cidadeDto.UfId, cidadeDto.UfDescricao, 0, null);
            var cidade = new Cidade(cidadeDto.Id, cidadeDto.Descricao, cidadeDto.CodigoIbge, uf);
            _cidadeRepository.Atualizar(cidade);
        }

        public void Remover(int id)
        {
            _cidadeRepository.Remover(id);
        }
    }
}
