using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class TipoEventoRepository
    {
        private readonly string _connectionString;

        public TipoEventoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<TipoEvento> BuscarTodos()
        {
            var tiposEvento = new List<TipoEvento>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT id, descricao FROM tipo_evento ORDER BY id";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoEvento = new TipoEvento(
                            reader.GetInt32(0),   // Id
                            reader.GetString(1)    // Descrição
                        );
                        tiposEvento.Add(tipoEvento);
                    }
                }
            }

            return tiposEvento;
        }

        public TipoEvento BuscarPorId(int id)
        {
            TipoEvento tipoEvento = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT id, descricao FROM tipo_evento WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipoEvento = new TipoEvento(
                                reader.GetInt32(0),  // Id
                                reader.GetString(1)   // Descrição
                            );
                        }
                    }
                }
            }

            return tipoEvento;
        }

        public void Inserir(TipoEvento tipoEvento)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO tipo_evento (descricao) VALUES (@descricao)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", tipoEvento.Descricao);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(TipoEvento tipoEvento)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE tipo_evento SET descricao = @descricao WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", tipoEvento.Descricao);
                    command.Parameters.AddWithValue("@id", tipoEvento.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM tipo_evento WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
