using EventManager.Entities;
using System.Collections.Generic;

namespace EventManager.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public PessoaDTO Pessoa { get; set; }

        public List<PapelDTO> Papeis { get; set; } = new List<PapelDTO>();

        public UsuarioDTO() { }

        public UsuarioDTO(int id, string nome, string email, string senha, PessoaDTO pessoa)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Pessoa = pessoa;
        }

        public UsuarioDTO(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            Senha = usuario.Senha;
            Pessoa = new PessoaDTO(usuario.Pessoa);

            foreach (UsuarioPapel usuarioPapel in usuario.UsuarioPapeis)
            {
                Papeis.Add(new PapelDTO(usuarioPapel.Papel));
            }
        }
    }
}
