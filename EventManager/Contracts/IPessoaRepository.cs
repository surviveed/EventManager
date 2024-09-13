using EventManager.Entities;
using EventManager.Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Contracts
{
    public interface IPessoaRepository
    {
        List<Pessoa> BuscarTodos();
        Pessoa BuscarPorId(int id);
        Pessoa BuscarPorTipoPessoa(TipoPessoa tipoPessoa);
        void Inserir(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Remover(int id);
    }
}
