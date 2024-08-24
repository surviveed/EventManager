using EventManager.Entities;
using System.Collections.Generic;

namespace EventManager.DTOs
{
    public class EventoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoEventoId { get; set; }
        public string TipoEventoDescricao { get; set; }

        public double MediaAvaliacoes { get; set; }

        public List<SessaoDTO> Sessoes { get; set; } = new List<SessaoDTO>();

        public EventoDTO() { }

        public EventoDTO(int id, string nome, string descricao, int tipoEventoId, string tipoEventoDescricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            TipoEventoId = tipoEventoId;
            TipoEventoDescricao = tipoEventoDescricao;
        }

        public EventoDTO(Evento entity)
        {
            Id = entity.Id;
            Nome = entity.Nome;
            Descricao = entity.Descricao;
            TipoEventoId = entity.TipoEventoId;
            if(entity.TipoEvento != null) 
            {
                TipoEventoDescricao = entity.TipoEvento.Descricao;
            }

            foreach(Sessao sessao in entity.Sessoes){
                Sessoes.Add(new SessaoDTO(sessao));
            }

            MediaAvaliacoes = entity.CalcularMediaAvaliacoes();
            
        }
    }
}
