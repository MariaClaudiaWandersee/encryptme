/*using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class UsuarioController 
    {
        public static Usuario InserirUsuario(
            string Nome,
            string Senha
        )
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }

            if (String.IsNullOrEmpty(Senha))
            {
                throw new Exception("Senha inválida");
            }
            else
            {
                Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }
        }

        /*internal static void GetAgendamento(int idAgendamento)
        {
            throw new NotImplementedException();
        }

        public static Usuario AlterarUsuario(
            int Id,
            string Nome,
            string Senha
        )
        {
            Usuario usuario = GetUsuario(Id);

            if (!String.IsNullOrEmpty(Nome))
            {
                usuario.Nome = Nome;
            }

            if (!String.IsNullOrEmpty(Senha))
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }

            return usuario;
        }*/
        
       /* public static List<Usuario> VisualizarUsuario()
        {
            return Usuario.GetUsuario();
        }

        public static Usuario GetUsuario(int Id)
        {
            Usuario usuario = (
                from Usuario in Usuario.GetUsuarios()
                    where Usuario.Id == Id
                    select Usuario
            ).First();

            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            return usuario;
        }
    }
}*/