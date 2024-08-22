using System;
using System.Collections.Generic;

namespace EventManager.Entities
{
    public class Sessao
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Evento Evento { get; set; }
        public Local Local { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        public List<Pessoa> Integrantes { get; set; } = new List<Pessoa>();

        public Sessao() { }

        public Sessao(int id, DateTime dataInicio, DateTime dataFim, Evento evento, Local local)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Evento = evento;
            Local = local;
        }
    }
}
