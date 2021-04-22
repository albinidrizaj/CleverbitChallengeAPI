using AutoMapper;
using Core.Models.Database;
using Core.Models.DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class MatchHandler
    {
        private readonly IMapper _mapper;
        private readonly MatchService _matchService;

        public MatchHandler(MatchService matchService, IMapper mapper)
        {
            _matchService = matchService;
            _mapper = mapper;
        }

        public List<MatchDTO> GetAll()
        {
            return _mapper.Map<List<Match>, List<MatchDTO>>(_matchService.GetAll());
        }

        public UserMatchResultDTO GetMatchResult(int matchId)
        {
            return _mapper.Map<UserMatchResult, UserMatchResultDTO>(_matchService.GetHighestResultOfMatch(matchId));
        }
    }
}
