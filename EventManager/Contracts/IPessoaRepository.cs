using EventManager.Entities;
using EventManager.Entities.enums;
using System.Collections.Generic;

namespace EventManager.Contracts
{
    public interface IPessoaRepository
    {
        List<Pessoa> BuscarTodos();
        Pessoa BuscarPorId(int id);
        Pessoa BuscarPorCpf(string cpf);
        Pessoa BuscarPorTipoPessoa(TipoPessoa tipoPessoa);
        void Inserir(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Remover(int id);
    }
}
