using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Database
{
    public class User : Base
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public List<UserMatchResult> UserMatchResults { get; set; }
    }
}
