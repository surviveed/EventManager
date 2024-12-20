﻿using EventManager.Contracts;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Entities.enums;
using EventManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class PessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public List<PessoaDTO> BuscarTodos()
        {
            var pessoas = _pessoaRepository.BuscarTodos();
            return pessoas.Select(p => new PessoaDTO(p)).ToList();
        }

        public PessoaDTO BuscarPorId(int id)
        {
            var pessoa = _pessoaRepository.BuscarPorId(id);
            return pessoa != null ? new PessoaDTO(pessoa) : null;
        }

        public PessoaDTO BuscarPorCpf(string cpf)
        {
            var pessoa = _pessoaRepository.BuscarPorCpf(cpf);
            return pessoa != null ? new PessoaDTO(pessoa) : null;
        }

        public PessoaDTO BuscarPorTipoPessoa(TipoPessoa tipoPessoa)
        {
            var pessoa = _pessoaRepository.BuscarPorTipoPessoa(tipoPessoa);
            return pessoa != null ? new PessoaDTO(pessoa) : null;
        }

        public void Inserir(PessoaDTO pessoaDto)
        {
            var pessoa = new Pessoa(0, pessoaDto.Nome, pessoaDto.Cpf, pessoaDto.TipoPessoa);
            _pessoaRepository.Inserir(pessoa);
        }

        public void Atualizar(PessoaDTO pessoaDto)
        {
            var pessoa = new Pessoa(pessoaDto.Id, pessoaDto.Nome, pessoaDto.Cpf, pessoaDto.TipoPessoa);
            _pessoaRepository.Atualizar(pessoa);
        }

        public void Remover(int id)
        {
            _pessoaRepository.Remover(id);
        }
    }
}
