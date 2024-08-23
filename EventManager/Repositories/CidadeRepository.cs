using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class CidadeRepository
    {
        private readonly string _connectionString;

        public CidadeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Cidade> BuscarTodos()
        {
            var cidades = new List<Cidade>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT Cidade.id, Cidade.descricao, Cidade.codigo_ibge, uf.id, uf.descricao 
                      FROM Cidade Cidade 
                      JOIN uf uf ON Cidade.uf_id = uf.id 
                      ORDER BY Cidade.id";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var uf = new Uf(
                            reader.GetInt32(3),                
                            reader.GetString(4),              
                            0,                                
                            null                              
                        );
                        var cidade = new Cidade(
                            reader.GetInt32(0),                
                            reader.GetString(1),               
                            reader.GetInt32(2),                
                            uf
                        );
                        cidades.Add(cidade);
                    }
                }
            }

            return cidades;
        }

        public Cidade BuscarPorId(int id)
        {
            Cidade cidade = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT c.id, c.descricao, c.codigo_ibge, uf.id, uf.descricao 
                              FROM cidade c
                              JOIN uf uf ON c.uf_id = uf.id 
                              WHERE c.id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var uf = new Uf(reader.GetInt32(3), reader.GetString(4), 0, null);
                            cidade = new Cidade(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), uf);
                        }
                    }
                }
            }

            return cidade;
        }

        public void Inserir(Cidade cidade)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO cidade (descricao, codigo_ibge, uf_id) VALUES (@descricao, @codigo_ibge, @uf_id)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", cidade.Descricao);
                    command.Parameters.AddWithValue("@codigo_ibge", cidade.CodigoIbge);
                    command.Parameters.AddWithValue("@uf_id", cidade.Uf.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Cidade cidade)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE cidade SET descricao = @descricao, codigo_ibge = @codigo_ibge, uf_id = @uf_id WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", cidade.Descricao);
                    command.Parameters.AddWithValue("@codigo_ibge", cidade.CodigoIbge);
                    command.Parameters.AddWithValue("@uf_id", cidade.Uf.Id);
                    command.Parameters.AddWithValue("@id", cidade.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM cidade WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
