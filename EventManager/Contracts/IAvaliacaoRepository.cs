using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IAvaliacaoRepository
    {
        List<Avaliacao> BuscarTodos();
        Avaliacao BuscarPorId(int id);
        void Inserir(Avaliacao avaliacao);
        void Atualizar(Avaliacao avaliacao);
        void Remover(int id);
    }
}
