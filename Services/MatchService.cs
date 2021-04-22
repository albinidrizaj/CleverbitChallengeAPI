using Core;
using Core.Models.Database;
using Core.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class MatchService : BaseService
    {
        private readonly EntityContext _entityContext;

        public MatchService(EntityContext entityContext) : base(entityContext)
        {
            _entityContext = entityContext;
        }

        public void AddMatchResultOfUser(UserMatchResult userMatchResult)
        {
            _entityContext.UserMatchResults.Add(userMatchResult);
        }

        public List<Match> GetAll()
        {
            return _entityContext.Matches.Include(m => m.UserMatchResults).ThenInclude(m => m.User).ToList();
        }

        public UserMatchResult GetHighestResultOfMatch(int matchId)
        {
            return new UserMatchResult();
        }
    }
}
