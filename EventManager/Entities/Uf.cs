namespace EventManager.Entities
{
    public class Uf
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoIbge { get; set; }
        public Pais Pais { get; set; }

        public Uf() { }

        public Uf(int id, string descricao, int codigoIbge, Pais pais)
        {
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
            Pais = pais;
        }
    }
}
