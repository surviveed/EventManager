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

        public List<PapelDTO> Papeis { get; set; } = new List<PapelDTO>();

        public UsuarioDTO() { }

        public UsuarioDTO(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public UsuarioDTO(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            Senha = usuario.Senha;

            foreach (UsuarioPapel usuarioPapel in usuario.UsuarioPapeis)
            {
                Papeis.Add(new PapelDTO(usuarioPapel.Papel));
            }
        }
    }
}
