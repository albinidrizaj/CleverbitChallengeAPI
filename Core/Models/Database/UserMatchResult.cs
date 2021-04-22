namespace Core.Models.Database
{
    public class UserMatchResult : Base
    {
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public int Result { get; set; }
        public bool Winner { get; set; }

        public User User { get; set; }
        public Match Match { get; set; }
    }
}
