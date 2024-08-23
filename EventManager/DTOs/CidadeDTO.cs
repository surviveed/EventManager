using EventManager.Entities;

namespace EventManager.DTOs
{
    public class CidadeDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoIbge { get; set; }
        public int UfId { get; set; }
        public string UfDescricao { get; set; }

        public CidadeDTO() { }

        public CidadeDTO(int id, string descricao, int codigoIbge, int ufId, string ufDescricao)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            UfId = ufId;
            UfDescricao = ufDescricao;
        }

        public CidadeDTO(Cidade entity)
        {
            Id = entity.Id;
            Descricao = entity.Descricao;
            CodigoIbge = entity.CodigoIbge;
            UfId = entity.Uf.Id;
            UfDescricao = entity.Uf.Descricao;
        }
    }
}
