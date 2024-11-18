using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL.Persistence.Models;

namespace NHL.Persistence.DTO
{
    public class NHLPlayerStatDTO
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public DateTime GameDate { get; set; }
        public int PlayerId { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public string PlusMinus { get; set; } = string.Empty;
        public int PenaltyMinutes { get; set; }
        public int ShotsTotal { get; set; }
        public float ShootingPct { get; set; }
        public int PowerPlayGoals { get; set; }
        public int PowerPlayAssists { get; set; }
        public int ShortHandedGoals { get; set; }
        public int ShortHandedAssists { get; set; }
        public int GameWinningGoals { get; set; }
        public string TimeOnIcePerGame { get; set; } = string.Empty;
        public string Production { get; set; } = string.Empty;
        public int GoalsAgainst { get; set; } = 0;
        public int ShotsAgainst { get; set; } = 0;
        public int Saves { get; set; } = 0;
        public bool IsHomeGame { get; set; }
        public bool IsWin { get; set; }
        public string PlayersParticipated { get; set; } = string.Empty;
        public int OpposingTeamId { get; set; }
        public string OpposingTeamCode { get; set; }
        public string OpposingTeamName { get; set; }
        public string TeamCode { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
    }
}