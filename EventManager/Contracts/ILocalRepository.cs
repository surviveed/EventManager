using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface ILocalRepository
    {
        List<Local> BuscarTodos();
        Local BuscarPorId(int id);
        void Inserir(Local local);
        void Atualizar(Local local);
        void Remover(int id);
    }
}
