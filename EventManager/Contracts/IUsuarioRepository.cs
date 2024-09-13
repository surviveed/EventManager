using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IUsuarioRepository
    {
        List<Usuario> BuscarTodos();
        Usuario BuscarPorId(int id);
        Usuario BuscarPorEmail(string email);
        void Inserir(Usuario usuario);
        void Atualizar(Usuario usuario);
        Usuario Autenticar(string email, string senha);
        void Remover(int id);
    }
}
