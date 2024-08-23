using EventManager.Entities;

namespace EventManager.DTOs
{
    public class LocalDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string Endereco { get; set; }
        public string Observacoes { get; set; }
        public int CidadeId { get; set; }
        public string CidadeDescricao { get; set; }

        public LocalDTO() { }

        public LocalDTO(int id, string nome, int capacidade, string endereco, string observacoes, int cidadeId, string cidadeDescricao)
        {
            Id = id;
            Nome = nome;
            Capacidade = capacidade;
            Endereco = endereco;
            Observacoes = observacoes;
            CidadeId = cidadeId;
            CidadeDescricao = cidadeDescricao;
        }

        public LocalDTO(Local entity)
        {
            Id = entity.Id;
            Nome = entity.Nome;
            Capacidade = entity.Capacidade;
            Endereco = entity.Endereco;
            Observacoes = entity.Observacoes;
            CidadeId = entity.Cidade.Id;
            CidadeDescricao = entity.Cidade.Descricao;
        }
    }
}
