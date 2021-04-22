using System;
using System.Collections.Generic;

namespace Core.Models.DTOs
{
    public class MatchDTO : Base
    {
        public DateTime StartDateTime { get; set; }
        //In seconds
        public int MatchLength { get; set; }
        //Winner
        public int UserId { get; set; }

        public UserDTO User { get; set; }

        public List<UserMatchResultDTO> UserMatchResults { get; set; }

        public bool HasPlayed { get; set; }
    }
}
