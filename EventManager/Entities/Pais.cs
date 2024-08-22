namespace EventManager.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoIbge { get; set; }

        public Pais() { }

        public Pais(int id, string descricao, int codigoIbge) 
        { 
            Id = id;
            Descricao = descricao;
            CodigoIbge = codigoIbge;
        }
    }
}
