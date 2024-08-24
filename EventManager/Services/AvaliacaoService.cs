using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class AvaliacaoService
    {
        private readonly AvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(AvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }

        public List<AvaliacaoDTO> BuscarTodos()
        {
            var avaliacoes = _avaliacaoRepository.BuscarTodos();
            return avaliacoes.Select(avaliacao => new AvaliacaoDTO(avaliacao)).ToList();
        }

        public AvaliacaoDTO BuscarPorId(int id)
        {
            var avaliacao = _avaliacaoRepository.BuscarPorId(id);
            return avaliacao != null ? new AvaliacaoDTO(avaliacao) : null;
        }

        public void Inserir(AvaliacaoDTO avaliacaoDto)
        {
            var avaliacao = new Avaliacao(0, avaliacaoDto.Comentario, avaliacaoDto.Nota, avaliacaoDto.PessoaId, avaliacaoDto.SessaoId);
            _avaliacaoRepository.Inserir(avaliacao);
        }

        public void Atualizar(AvaliacaoDTO avaliacaoDto)
        {
            var avaliacao = new Avaliacao(avaliacaoDto.Id, avaliacaoDto.Comentario, avaliacaoDto.Nota, avaliacaoDto.PessoaId, avaliacaoDto.SessaoId);
            _avaliacaoRepository.Atualizar(avaliacao);
        }

        public void Remover(int id)
        {
            _avaliacaoRepository.Remover(id);
        }
    }
}
