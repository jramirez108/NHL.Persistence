using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL.Persistence.Models;

namespace NHL.Persistence.DTO
{
    public class NHLGameDTO
    {
        public int Id { get; set; }
        public NHLTeam HomeTeam { get; set; }
        public NHLTeam VisitorTeam { get; set; }
        public string? PlayersParticipating { get; set; }
        public List<NHLPlayerDTO> HomePlayers { get; set; }
        public List<NHLPlayerDTO> VisitorPlayers { get; set; }
        public string? HomeTeamOdds { get; set; }
        public string? VisitorTeamOdds { get; set; }
        public string? HomeTeamSpreadLine { get; set; }
        public string? HomeTeamSpreadOdds { get; set; }
        public string? VisitorTeamSpreadLine { get; set; }
        public string? VisitorTeamSpreadOdds { get; set; }
        public string? GameOverOdds { get; set; }
        public string? GameUnderOdds { get; set; }
        public float? GameRunLine { get; set; }
        public DateTime GameDate { get; set; }
    }
}