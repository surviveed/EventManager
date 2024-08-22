namespace EventManager.Entities
{
    public class TipoEvento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public TipoEvento() { }

        public TipoEvento(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
