using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers.Helpers
{
    public static class PasswordHelper
    {
        public static string EncryptPassword(string password)
        {
            return password;
        }

        public static bool PasswordMatches(string password)
        {
            var newEncryptedPassword = EncryptPassword(password);
            var currentPassword = EncryptPassword(password);

            return currentPassword.Equals(newEncryptedPassword);
        }
    }
}
