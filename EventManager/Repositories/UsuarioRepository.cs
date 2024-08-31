using EventManager.Config;
using EventManager.Entities;
using System.Collections.Generic;
using System.Data.Entity;
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
            return _context.Usuarios
                .Include(u => u.UsuarioPapeis)
                .Include(u => u.Pessoa)
                .OrderBy(u => u.Id).ToList();
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios
                .Include(u => u.UsuarioPapeis)
                .Include(u => u.Pessoa)
                .FirstOrDefault(u => u.Id == id);
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuarios
                .Include(u => u.UsuarioPapeis)
                .Include(u => u.Pessoa)
                .FirstOrDefault(u => u.Email == email);
        }

        public Usuario Autenticar(string email, string senha)
        {
            var usuario = _context.Usuarios
                .Include(u => u.UsuarioPapeis)
                .Include(u => u.Pessoa)
                .FirstOrDefault(u => u.Email == email);

            if (usuario != null)
            {
                bool senhaValida = BCrypt.Net.BCrypt.Verify(senha, usuario.Senha);

                if (senhaValida)
                {
                    return usuario;
                }
            }

            return null;
        }

        public void Inserir(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            usuario.UsuarioPapeis.Add(new UsuarioPapel(usuario.Id, 2));
            _context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;

                // Apenas criptografa e atualiza a senha se ela for diferente
                if (usuarioExistente.Senha != usuario.Senha)
                {
                    usuarioExistente.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                }

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
