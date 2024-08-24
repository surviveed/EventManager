using EventManager.Entities;

namespace EventManager.DTOs
{
    public class EventoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoEventoId { get; set; }
        public string TipoEventoDescricao { get; set; }

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
            TipoEventoId = entity.TipoEvento.Id;
            TipoEventoDescricao = entity.TipoEvento.Descricao;
        }
    }
}
