using System;
using System.Collections.Generic;

namespace Core.Models.Database
{
    public class Match : Base
    {
        public DateTime StartDateTime { get; set; }
        //In seconds
        public int MatchLength { get; set; }


        public List<UserMatchResult> UserMatchResults { get; set; }
    }
}
