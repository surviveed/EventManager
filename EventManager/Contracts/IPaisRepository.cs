using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IPaisRepository
    {
        List<Pais> BuscarTodos();
        Pais BuscarPorId(int id);
        void Inserir(Pais pais);
        void Atualizar(Pais pais);
        void Remover(int id);
    }
}
