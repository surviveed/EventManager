using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface ICidadeRepository
    {
        List<Cidade> BuscarTodos();
        Cidade BuscarPorId(int id);
        void Inserir(Cidade cidade);
        void Atualizar(Cidade cidade);
        void Remover(int id);
    }
}
