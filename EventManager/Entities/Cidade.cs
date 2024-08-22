namespace EventManager.Entities
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoIbge { get; set; }
        public Uf Uf { get; set; }

        public Cidade() { }

        public Cidade(int id, string descricao, string codigoIbge, Uf uf)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            Uf = uf;
        }
    }
}
