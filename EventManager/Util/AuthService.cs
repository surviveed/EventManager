using EventManager.DTOs;

namespace EventManager.Util
{
    public static class AuthService
    {
        public static bool VerificarAdmin(UsuarioDTO usuario)
        {
            foreach (PapelDTO papel in usuario.Papeis)
            {
                if (papel.Descricao.Equals("Administrador"))
                {
                    return true;
                    
                }
            }

            return false;
        }
    }
}
