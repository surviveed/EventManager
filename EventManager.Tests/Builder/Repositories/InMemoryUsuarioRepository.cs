using EventManager.Contracts;
using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Tests.Builder.Repositories
{
    public class InMemoryUsuarioRepository : IUsuarioRepository
    {
        public List<Usuario> items { get; set; } = new List<Usuario>();

        public void Atualizar(Usuario usuario)
        {
            var index = items.FindIndex(x => x.Id == usuario.Id);
            items[index] = usuario;

        }

        public Usuario Autenticar(string email, string senha)
        {
            return this.items.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }

        public Usuario BuscarPorEmail(string email)
        {
            return this.items.FirstOrDefault(x=> x.Email == email);
        }

        public Usuario BuscarPorId(int id)
        {
            return this.items.FirstOrDefault(x => x.Id == id);
        }

        public List<Usuario> BuscarTodos()
        {
            return items.ToList();
        }

        public void Inserir(Usuario usuario)
        {
            var nextval = this.items.Count() + 1;
            usuario.Id = nextval;

            this.items.Add(usuario);
        }

        public void Remover(int id)
        {
            var usuario = this.items.FirstOrDefault(x => x.Id == id);

            if (usuario != null)
                items.Remove(usuario);
        }
    }
}
