using EventManager.Entities;

namespace EventManager.DTOs
{
    public class PapelDTO
    {
        public int Id {  get; set; }
        public string Descricao { get; set; }

        public PapelDTO() { }

        public PapelDTO(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public PapelDTO(Papel entity)
        {
            Id = entity.Id;
            Descricao = entity.Descricao;
        }
    }
}
