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
        void Inserir(Cidade avaliacao);
        void Atualizar(Cidade avaliacao);
        void Remover(int id);
    }
}
