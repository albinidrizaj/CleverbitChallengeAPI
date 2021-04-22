using Core;
using Core.Models.Database;
using Core.Models.DTOs;
using System.Linq;

namespace Services
{
    public class AuthenticationService
    {
        private readonly EntityContext _entityContext;

        public AuthenticationService(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public bool Register(User user)
        {
            var userToAdd = _entityContext.Users.FirstOrDefault(u => u.Username == user.Username);

            _entityContext.Users.Add(userToAdd);
            _entityContext.SaveChanges();

            return true;
        }

        public bool Login(LoginDTO loginDTO)
        {
            var encPassword = loginDTO.Password;
            var user = _entityContext.Users.FirstOrDefault(u => u.Username == loginDTO.Username && u.Password == encPassword);
            if (user == null)
                return false;

            return true;
        }
    }
}
