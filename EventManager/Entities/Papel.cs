namespace EventManager.Entities
{
    public class Papel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Papel() { }
        public Papel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
