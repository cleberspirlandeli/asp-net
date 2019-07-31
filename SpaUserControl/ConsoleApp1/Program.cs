
using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Repositories;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(
                "Cleber Rezende",
                "contato.spirlandeli1@gmail.com");

            user.SetPassword("1234567", "1234567");
            user.Validate();

            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            using (IUserRepository userRep = new UserRepository())
            {
                var usr = userRep.Get("contato.spirlandeli@gmail.com");
                Console.WriteLine(usr.Email);
            }
        }
    }
}
