using SpaUserControl.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaUserControl.Domain.Models
{
    public class User
    {
        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void SetPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotNull(password, "Senha inválida.");
            AssertionConcern.AssertArgumentNotNull(confirmPassword, "As senhas não coincidem.");
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, "As senhas não coincidem.");
            AssertionConcern.AssertArgumentLength(password, 6, 20, "A senha deve conter de 6 a 20 caracteres.");

            this.Password = PasswordAssertionConcern.Encrypt(password);
        }

        public string ResetPassword()
        {
            string password = Guid
                                .NewGuid()
                                .ToString()
                                .Substring(0, 8);
            this.Password = PasswordAssertionConcern.Encrypt(password);

            return password;
        }


    }
}
