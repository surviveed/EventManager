using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventManager.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<UsuarioDTO> BuscarTodos()
        {
            var usuarios = _usuarioRepository.BuscarTodos();
            return usuarios.Select(u => new UsuarioDTO(u)).ToList();
        }

        public UsuarioDTO BuscarPorId(int id)
        {
            var usuario = _usuarioRepository.BuscarPorId(id);
            return usuario != null ? new UsuarioDTO(usuario) : null;
        }

        public UsuarioDTO BuscarPorEmail(string email)
        {
            var usuario = _usuarioRepository.BuscarPorEmail(email);
            return usuario != null ? new UsuarioDTO(usuario) : null;
        }

        public UsuarioDTO Autenticar(string email, string senha)
        {
            var usuario = _usuarioRepository.Autenticar(email, senha);
            return usuario != null ? new UsuarioDTO(usuario) : null;
        }

        public void Inserir(UsuarioDTO usuarioDto)
        {
            try
            {
                // Converta DTO para o modelo de entidade
                var usuario = new Usuario
                {
                    Id = 0,
                    Nome = usuarioDto.Nome,
                    Email = usuarioDto.Email,
                    Senha = BCrypt.Net.BCrypt.HashPassword(usuarioDto.Senha), // Criptografa a senha
                    PessoaId = usuarioDto.Pessoa.Id
                };

                // Insere o usuário no repositório
                _usuarioRepository.Inserir(usuario);

            }
            catch (Exception ex)
            {
                // Log ou tratar o erro
                Console.WriteLine($"Erro ao inserir usuário: {ex.Message}");
                throw; // Re-throw the exception if needed
            }
        }


        public void Atualizar(UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario(usuarioDto.Id, usuarioDto.Nome, usuarioDto.Email, usuarioDto.Senha);
            _usuarioRepository.Atualizar(usuario);
        }

        public void Remover(int id)
        {
            _usuarioRepository.Remover(id);
        }
    }
}
