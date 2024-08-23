using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class UfRepository
    {
        private readonly string _connectionString;

        public UfRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Uf> BuscarTodos()
        {
            var ufs = new List<Uf>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT uf.id, uf.descricao, uf.codigo_ibge, p.id, p.descricao 
                      FROM uf uf 
                      JOIN pais p ON uf.pais_id = p.id 
                      ORDER BY uf.id";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pais = new Pais(
                            reader.GetInt32(3),                // Pais.Id
                            reader.GetString(4),               // Pais.Descricao
                            0                                  // Pais.CodigoIbge
                        );
                        var uf = new Uf(
                            reader.GetInt32(0),                // Uf.Id
                            reader.GetString(1),               // Uf.Descricao
                            reader.GetInt32(2),                // Uf.CodigoIbge 
                            pais
                        );
                        ufs.Add(uf);
                    }
                }
            }

            return ufs;
        }

        public Uf BuscarPorId(int id)
        {
            Uf uf = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT uf.id, uf.descricao, uf.codigo_ibge, p.id, p.descricao 
                              FROM uf uf 
                              JOIN pais p ON uf.pais_id = p.id 
                              WHERE uf.id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var pais = new Pais(reader.GetInt32(3), reader.GetString(4), 0);
                            uf = new Uf(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), pais);
                        }
                    }
                }
            }

            return uf;
        }

        public void Inserir(Uf uf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO uf (descricao, codigo_ibge, pais_id) VALUES (@descricao, @codigo_ibge, @pais_id)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", uf.Descricao);
                    command.Parameters.AddWithValue("@codigo_ibge", uf.CodigoIbge);
                    command.Parameters.AddWithValue("@pais_id", uf.Pais.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Uf uf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE uf SET descricao = @descricao, codigo_ibge = @codigo_ibge, pais_id = @pais_id WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", uf.Descricao);
                    command.Parameters.AddWithValue("@codigo_ibge", uf.CodigoIbge);
                    command.Parameters.AddWithValue("@pais_id", uf.Pais.Id);
                    command.Parameters.AddWithValue("@id", uf.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM uf WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
