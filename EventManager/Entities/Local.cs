namespace EventManager.Entities
{
    public class Local
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string Endereco { get; set; }
        public string Observacoes { get; set; }
        public Cidade Cidade { get; set; }

        public Local() { }

        public Local(int id, string nome, int capacidade, string endereco, string observacoes, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Capacidade = capacidade;
            Endereco = endereco;
            Observacoes = observacoes;
            Cidade = cidade;
        }
    }
}
