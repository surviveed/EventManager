using Bogus;
using Bogus.Extensions.Brazil;
using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Factories
{
    public class MakePessoa
    {
        private Faker<Pessoa> _fakerPessoa;
        private Faker<PessoaDTO> _fakerPessoaDTO;

        public MakePessoa()
        {
            _fakerPessoa = new Faker<Pessoa>()
                .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Cpf, f => f.Person.Cpf())
                .RuleFor(c => c.TipoPessoa, f => f.Random.Enum<TipoPessoa>());

            _fakerPessoaDTO = new Faker<PessoaDTO>()
                .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Cpf, f => f.Person.Cpf())
                .RuleFor(c => c.TipoPessoa, f => f.Random.Enum<TipoPessoa>());
        }

        public Pessoa GetData(int? id = null, string nome = null, string cpf = null, TipoPessoa tipoPessoa = TipoPessoa.PARTICIPANTE)
        {
            var pessoa = _fakerPessoa.Generate();

            pessoa.Id = id ?? pessoa.Id;
            pessoa.Nome = nome ?? pessoa.Nome;
            pessoa.Cpf = cpf ?? pessoa.Cpf;
            pessoa.TipoPessoa = tipoPessoa;

            return pessoa;
        }

        public PessoaDTO GetDataDTO(int? id = null, string nome = null, string cpf = null, TipoPessoa tipoPessoa = TipoPessoa.PARTICIPANTE)
        {
            var pessoa = _fakerPessoaDTO.Generate();

            pessoa.Id = id ?? pessoa.Id;
            pessoa.Nome = nome ?? pessoa.Nome;
            pessoa.Cpf = cpf ?? pessoa.Cpf;
            pessoa.TipoPessoa = tipoPessoa;

            return pessoa;
        }

    }
}
