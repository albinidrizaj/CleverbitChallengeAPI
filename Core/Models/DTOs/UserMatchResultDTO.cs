using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.DTOs
{
    public class UserMatchResultDTO : Base
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int MatchId { get; set; }
        public int Result { get; set; }
    }
}
