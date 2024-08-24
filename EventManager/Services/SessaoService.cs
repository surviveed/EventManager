using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class SessaoService
    {
        private readonly SessaoRepository _sessaoRepository;

        public SessaoService(SessaoRepository sessaoRepository)
        {
            _sessaoRepository = sessaoRepository;
        }

        public List<SessaoDTO> BuscarTodos()
        {
            var sessoes = _sessaoRepository.BuscarTodos();
            return sessoes.Select(sessao => new SessaoDTO(sessao)).ToList();
        }

        public SessaoDTO BuscarPorId(int id)
        {
            var sessao = _sessaoRepository.BuscarPorId(id);
            return sessao != null ? new SessaoDTO(sessao) : null;
        }

        public void Inserir(SessaoDTO SessaoDTO)
        {
            var sessao = new Sessao(0, SessaoDTO.DataInicio, SessaoDTO.DataFim, SessaoDTO.EventoId, SessaoDTO.LocalId);
            _sessaoRepository.Inserir(sessao);
        }

        public void Atualizar(SessaoDTO SessaoDTO)
        {
            var sessao = new Sessao(SessaoDTO.Id, SessaoDTO.DataInicio, SessaoDTO.DataFim, SessaoDTO.EventoId, SessaoDTO.LocalId);
            _sessaoRepository.Atualizar(sessao);
        }

        public void Remover(int id)
        {
            _sessaoRepository.Remover(id);
        }
    }
}
