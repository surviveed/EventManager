using EventManager.Entities;
using Npgsql;
using System.Collections.Generic;

namespace EventManager.Repositories
{
    public class EventoRepository
    {
        private readonly string _connectionString;

        public EventoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Evento> BuscarTodos()
        {
            var eventos = new List<Evento>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT e.id, e.nome, e.descricao, te.id, te.descricao 
                              FROM evento e
                              JOIN tipo_evento te ON e.tipoevento_id = te.id
                              ORDER BY e.id";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoEvento = new TipoEvento(
                            reader.GetInt32(3),   // TipoEventoId
                            reader.GetString(4)    // TipoEventoDescricao
                        );
                        var evento = new Evento(
                            reader.GetInt32(0),   // EventoId
                            reader.GetString(1),   // Nome
                            reader.GetString(2),   // Descrição
                            tipoEvento.Id
                        );
                        eventos.Add(evento);
                    }
                }
            }

            return eventos;
        }

        public Evento BuscarPorId(int id)
        {
            Evento evento = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT e.id, e.nome, e.descricao, te.id, te.descricao 
                              FROM evento e
                              JOIN tipo_evento te ON e.tipoevento_id = te.id
                              WHERE e.id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var tipoEvento = new TipoEvento(
                                reader.GetInt32(3),  // TipoEventoId
                                reader.GetString(4)   // TipoEventoDescricao
                            );
                            evento = new Evento(
                                reader.GetInt32(0),  // EventoId
                                reader.GetString(1),  // Nome
                                reader.GetString(2),  // Descrição
                                tipoEvento.Id
                            );
                        }
                    }
                }
            }

            return evento;
        }

        public void Inserir(Evento evento)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO evento (nome, descricao, tipoevento_id) VALUES (@nome, @descricao, @tipoevento_id)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", evento.Nome);
                    command.Parameters.AddWithValue("@descricao", evento.Descricao);
                    command.Parameters.AddWithValue("@tipoevento_id", evento.TipoEvento.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Evento evento)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE evento SET nome = @nome, descricao = @descricao, tipoevento_id = @tipoevento_id WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", evento.Nome);
                    command.Parameters.AddWithValue("@descricao", evento.Descricao);
                    command.Parameters.AddWithValue("@tipoevento_id", evento.TipoEvento.Id);
                    command.Parameters.AddWithValue("@id", evento.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM evento WHERE id = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
