using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IUfRepository
    {
        List<Uf> BuscarTodos();
        Uf BuscarPorId(int id);
        void Inserir(Uf uf);
        void Atualizar(Uf uf);
        void Remover(int id);
    }
}
