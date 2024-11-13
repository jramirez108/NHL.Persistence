using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Persistence.Models
{
    public class NHLGame
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int VisitorTeamId { get; set; }
        public DateTime GameDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? HomeTeamOdds { get; set; }
        public string? VisitorTeamOdds { get; set; }
        public string? HomeTeamSpreadLine { get; set; }
        public string? HomeTeamSpreadOdds { get; set; }
        public string? VisitorTeamSpreadLine { get; set; }
        public string? VisitorTeamSpreadOdds { get; set; }
        public string? GameOverOdds { get; set; }
        public string? GameUnderOdds { get; set; }
        public float? GameRunLine { get; set; }
        public virtual NHLTeam HomeTeam { get; set; }
        public virtual NHLTeam VisitorTeam { get; set; }
    }
}