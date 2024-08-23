using EventManager.Entities;

namespace EventManager.DTOs
{
    public class PaisDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoIbge { get; set; }

        public PaisDTO() { }

        public PaisDTO(int id, string descricao, int codigoIbge)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
        }

        public PaisDTO(Pais Entity)
        {
            Id = Entity.Id;
            Descricao = Entity.Descricao;
            CodigoIbge = Entity.CodigoIbge;
        }
    }
}
