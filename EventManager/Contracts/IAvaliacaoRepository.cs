using EventManager.Entities;
using System.Collections.Generic;

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
