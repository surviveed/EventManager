using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Repositories
{
    public class UsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository()
        {
            _context = new AppDbContext();
        }

        public List<Usuario> BuscarTodos()
        {
            return _context.Usuarios.OrderBy(u => u.Id).ToList();
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Inserir(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.Senha = usuario.Senha;

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
