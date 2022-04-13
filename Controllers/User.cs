using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System.Text.RegularExpressions;

namespace Controllers
{
    public class UserController 
    {
        public static User InserirUser(
            string Name,
            string PassWord
        )
        {
            if (String.IsNullOrEmpty(Name))
            {
                throw new Exception("Nome inválido");
            }
            if (String.IsNullOrEmpty(PassWord))
            {
                throw new Exception("Senha inválida");
            }
            return new User(Name, PassWord);
        }

        internal static void GetProcedimento(int idProcedimento)
        {
            throw new NotImplementedException();
        }

        public static  AlterarUser(
            int Id,
            string Name,
            string PassWord
        )

       /* {
            User user = GetUser(Id);

            if (!String.IsNullOrEmpty(Name))
            {
                dentista.Name = Name;
            }

            if (!String.IsNullOrEmpty(PassWord))
            {
                dentista.PassWord = PassWord;
            }

            return user;
        }*/

        public static User ExcluirDentista(
            int Id
        )
        {
            User user = GetDentista(Id);
            user.RemoverDentista(user);
            return user;
        }

        public static List<User> VisualizarUser()
        {
            return User.GetUsers();
        }

        public static User GetUser(int Id)
        {
            User user = (
                from Dentista in User.GetUsers()
                    where User.Id == Id
                    select User
            ).First();

            if (user == null)
            {
                throw new Exception("User não encontrado");
            }

            return user;
        }
    }
}