using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IEventoRepository
    {
        List<Evento> BuscarTodos();
        Evento BuscarPorId(int id);
        List<Evento> BuscarComFiltros(string nome = null, int? tipoEventoId = null);
        void Inserir(Evento evento);
        void Atualizar(Evento evento);
        void Remover(int id);
    }
}
