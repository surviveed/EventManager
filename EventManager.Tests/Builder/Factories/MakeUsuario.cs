using Bogus;
using Bogus.DataSets;
using EventManager.DTOs;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Factories
{
    public class MakeUsuario
    {
        private Faker<Usuario> _fakerUsuario;
        private Faker<UsuarioDTO> _fakerUsuarioDTO;


        public MakeUsuario()
        {
            var pessoaId = new Faker("pt_BR").Random.Number(1, 10000);
            var pessoa = new MakePessoa().GetData(id: pessoaId);
            pessoa.SessaoIntegrantes = new List<SessaoIntegrante>();
            pessoa.EventoOrganizadores = new List<EventoOrganizadores>();

            _fakerUsuario = new Faker<Usuario>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
                .RuleFor(c => c.Nome, f => f.Name.FirstName())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.Senha, f => f.Lorem.Word())
                .RuleFor(c => c.PessoaId, f => pessoaId)
                .RuleFor(c => c.Pessoa, f => pessoa);

            _fakerUsuarioDTO = new Faker<UsuarioDTO>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Int(min: 1, max: 50))
               .RuleFor(c => c.Nome, f => f.Name.FirstName())
               .RuleFor(c => c.Email, f => f.Person.Email)
               .RuleFor(c => c.Senha, f => f.Lorem.Word());
        }

        public Usuario GetData(int? id = null, string nome = null, string email = null, string senha = null, int? pessoaId = null)
        {
            var usuario = _fakerUsuario.Generate();

            usuario.Id = id ?? usuario.Id;
            usuario.Nome = nome ?? usuario.Nome;
            usuario.Email = email ?? usuario.Email;
            usuario.Senha = senha ?? usuario.Senha;
            usuario.PessoaId = pessoaId ?? usuario.PessoaId;

            usuario.Pessoa.Id = pessoaId ?? usuario.PessoaId;

            return usuario;
        }

        public UsuarioDTO GetDataDTO(int? id = null, string nome = null, string email = null, string senha = null)
        {
            var usuario = _fakerUsuarioDTO.Generate();

            usuario.Id = id ?? usuario.Id;
            usuario.Nome = nome ?? usuario.Nome;
            usuario.Email = email ?? usuario.Email;
            usuario.Senha = senha ?? usuario.Senha;

            return usuario;
        }
    }
}
