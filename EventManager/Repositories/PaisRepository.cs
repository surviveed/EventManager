using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class PaisRepository
    {
        private readonly string _connectionString;

        public PaisRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para buscar todos os países
        public IEnumerable<Pais> GetAll()
        {
            var paises = new List<Pais>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, descricao, codigo_ibge FROM pais", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pais = new Pais
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            CodigoIbge = reader.GetInt32(2)
                        };
                        paises.Add(pais);
                    }
                }
            }

            return paises;
        }

        // Método para buscar um país por ID
        public Pais GetById(int id)
        {
            Pais pais = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, descricao, codigo_ibge FROM pais WHERE id = @id", connection);
                command.Parameters.AddWithValue("id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pais = new Pais
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            CodigoIbge = reader.GetInt32(2)
                        };
                    }
                }
            }

            return pais;
        }

        // Método para inserir um novo país
        public void Insert(Pais pais)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("INSERT INTO pais (descricao, codigo_ibge) VALUES (@descricao, @codigoIbge)", connection);
                command.Parameters.AddWithValue("descricao", pais.Descricao);
                command.Parameters.AddWithValue("codigoIbge", pais.CodigoIbge);
                command.ExecuteNonQuery();
            }
        }

        // Método para atualizar um país existente
        public void Update(Pais pais)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("UPDATE pais SET descricao = @descricao, codigo_ibge = @codigoIbge WHERE id = @id", connection);
                command.Parameters.AddWithValue("id", pais.Id);
                command.Parameters.AddWithValue("descricao", pais.Descricao);
                command.Parameters.AddWithValue("codigoIbge", pais.CodigoIbge);
                command.ExecuteNonQuery();
            }
        }

        // Método para deletar um país por ID
        public void Delete(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("DELETE FROM pais WHERE id = @id", connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
