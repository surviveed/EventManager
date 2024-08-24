using EventManager.DTOs;
using EventManager.Entities;
using EventManager.Repositories;
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

        public void Inserir(UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario(0, usuarioDto.Nome, usuarioDto.Email, usuarioDto.Senha);
            _usuarioRepository.Inserir(usuario);
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
