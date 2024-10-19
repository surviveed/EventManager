using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface ITipoEventoRepository
    {
        List<TipoEvento> BuscarTodos();
        TipoEvento BuscarPorId(int id);
        void Inserir(TipoEvento tipoEvento);
        void Atualizar(TipoEvento tipoEvento);
        void Remover(int id);
    }
}
