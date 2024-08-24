using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class LocalRepository
    {
        private readonly string _connectionString;

        public LocalRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Local> BuscarTodos()
        {
            var locais = new List<Local>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT l.id, l.nome, l.capacidade, l.endereco, l.observacoes, c.id, c.descricao 
                              FROM local l
                              JOIN cidade c ON l.cidade_id = c.id 
                              ORDER BY l.id";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cidade = new Cidade(
                            reader.GetInt32(5),    // ID da cidade
                            reader.GetString(6),   // Descrição da cidade
                            0,                     // Código IBGE (não utilizado aqui)
                            0                   // Uf (não carregado neste exemplo)
                        );

                        var local = new Local(
                            reader.GetInt32(0),    // ID do local
                            reader.GetString(1),   // Nome do local
                            reader.GetInt32(2),    // Capacidade do local
                            reader.GetString(3),   // Endereço do local
                            reader.GetString(4),   // Observações do local
                            cidade                 // Cidade relacionada
                        );

                        locais.Add(local);
                    }
                }
            }

            return locais;
        }

        public Local BuscarPorId(int id)
        {
            Local local = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT l.id, l.nome, l.capacidade, l.endereco, l.observacoes, c.id, c.descricao 
                              FROM local l
                              JOIN cidade c ON l.cidade_id = c.id 
                              WHERE l.id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var cidade = new Cidade(
                                reader.GetInt32(5),    // ID da cidade
                                reader.GetString(6),   // Descrição da cidade
                                0,                     // Código IBGE (não utilizado aqui)
                                0// Uf (não carregado neste exemplo)
                            );

                            local = new Local(
                                reader.GetInt32(0),    // ID do local
                                reader.GetString(1),   // Nome do local
                                reader.GetInt32(2),    // Capacidade do local
                                reader.GetString(3),   // Endereço do local
                                reader.GetString(4),   // Observações do local
                                cidade                 // Cidade relacionada
                            );
                        }
                    }
                }
            }

            return local;
        }

        public void Inserir(Local local)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO local (nome, capacidade, endereco, observacoes, cidade_id) VALUES (@nome, @capacidade, @endereco, @observacoes, @cidade_id)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", local.Nome);
                    command.Parameters.AddWithValue("@capacidade", local.Capacidade);
                    command.Parameters.AddWithValue("@endereco", local.Endereco);
                    command.Parameters.AddWithValue("@observacoes", local.Observacoes);
                    command.Parameters.AddWithValue("@cidade_id", local.Cidade.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Local local)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE local SET nome = @nome, capacidade = @capacidade, endereco = @endereco, observacoes = @observacoes, cidade_id = @cidade_id WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", local.Nome);
                    command.Parameters.AddWithValue("@capacidade", local.Capacidade);
                    command.Parameters.AddWithValue("@endereco", local.Endereco);
                    command.Parameters.AddWithValue("@observacoes", local.Observacoes);
                    command.Parameters.AddWithValue("@cidade_id", local.Cidade.Id);
                    command.Parameters.AddWithValue("@id", local.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM local WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
