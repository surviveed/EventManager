using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface ISessaoRepository
    {
        List<Sessao> BuscarTodos();
        Sessao BuscarPorId(int id);
        void Inserir(Sessao sessao);
        void Atualizar(Sessao sessao);
        void AtualizarIntegrantes(Sessao sessao, List<Pessoa> integrantes);
        void Remover(int id);
    }
}
