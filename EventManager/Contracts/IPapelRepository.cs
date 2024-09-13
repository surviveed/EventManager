using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IPapelRepository
    {
        List<Papel> BuscarTodos();
        Papel BuscarPorId(int id);
    }
}
