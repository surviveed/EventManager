using EventManager.Entities;

namespace EventManager.DTOs
{
    public class UfDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoIbge { get; set; }
        public int PaisId { get; set; }
        public string PaisDescricao { get; set; }

        public UfDTO() { }

        public UfDTO(int id, string descricao, int codigoIbge, int paisId, string paisDescricao)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            PaisId = paisId;
            PaisDescricao = paisDescricao;
        }

        public UfDTO(Uf uf)
        {
            Id = uf.Id;
            Descricao = uf.Descricao;
            CodigoIbge = uf.CodigoIbge;
            PaisId = uf.Pais.Id;
            PaisDescricao = uf.Pais.Descricao;
        }
    }
}
