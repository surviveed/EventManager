using EventManager.Entities;

namespace EventManager.DTOs
{
    public class TipoEventoDTO
    {
        public int Id {  get; set; }
        public string Descricao { get; set; }

        public TipoEventoDTO() { }

        public TipoEventoDTO(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public TipoEventoDTO(TipoEvento entity)
        {
            Id = entity.Id;
            Descricao = entity.Descricao;
        }
    }
}
