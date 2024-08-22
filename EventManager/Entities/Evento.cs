using System.Collections.Generic;

namespace EventManager.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoEvento TipoEvento { get; set; }

        public List<Sessao> Sessoes { get; set; } = new List<Sessao>();
        public List<Pessoa> Organizadores { get; set; } = new List<Pessoa>();

        public Evento() { }

        public Evento(int id, string nome, string descricao, TipoEvento tipoEvento)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            TipoEvento = tipoEvento;
        }

        public double CalcularMediaAvaliacoes() 
        { 
            double soma = 0;
            double quantidade = 0;
            foreach(Sessao sessao in Sessoes)
            {
                foreach(Avaliacao avaliacao in sessao.Avaliacoes)
                {
                    soma += avaliacao.Nota;
                    quantidade++;
                }
            }
            return soma / quantidade;
        }
    }
}
