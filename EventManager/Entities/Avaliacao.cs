namespace EventManager.Entities
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public int Nota { get; set; }
        public Pessoa Pessoa { get; set;}
        public Sessao Sessao { get; set; }

        public Avaliacao() { }

        public Avaliacao(int id, string comentario, int nota, Pessoa pessoa, Sessao sessao)
        {
            Id = id;
            Comentario = comentario;
            Nota = nota;
            Pessoa = pessoa;
            Sessao = sessao;
        }
    }
}
