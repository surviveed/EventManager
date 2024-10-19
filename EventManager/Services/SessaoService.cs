using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class SessaoService
    {
        private readonly ISessaoRepository _sessaoRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public SessaoService(ISessaoRepository sessaoRepository, IPessoaRepository pessoaRepository)
        {
            _sessaoRepository = sessaoRepository;
            _pessoaRepository = pessoaRepository;
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

        public void AtualizarIntegrantes(SessaoDTO SessaoDTO, List<PessoaDTO> Integrantes)
        {
            var sessao = new Sessao(SessaoDTO.Id, SessaoDTO.DataInicio, SessaoDTO.DataFim, SessaoDTO.EventoId, SessaoDTO.LocalId);
            List<Pessoa> pessoas = new List<Pessoa>();
            foreach(PessoaDTO pessoa in Integrantes)
            {
                pessoas.Add(_pessoaRepository.BuscarPorId(pessoa.Id));
            }
            _sessaoRepository.AtualizarIntegrantes(sessao, pessoas);
        }

        public void Remover(int id)
        {
            _sessaoRepository.Remover(id);
        }
    }
}
