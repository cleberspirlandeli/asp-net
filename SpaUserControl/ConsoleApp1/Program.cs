using SpaUserControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(
                "Cle", 
                "test@test.com");

            try
            {
                user.SetPassword("123456", "123456");

                Console.WriteLine(user.Name);
                Console.WriteLine(user.Password);

                var password = user.ResetPassword();

                Console.WriteLine(password);
                Console.WriteLine(user.Password);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }

        }
    }
}
