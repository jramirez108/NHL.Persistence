using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Persistence.Models
{
    public class NHLTeamStats
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public float GoalsPG { get; set; }
        public int GoalsPGRank { get; set; }
        public float AssistsPG { get; set; }
        public int AssistsPGRank { get; set; }
        public float FaceoffsWonPG { get; set; }
        public int FaceoffsPGRank { get; set; }
        public float FaceoffsLostPG { get; set; }
        public int FaceoffsLostRank { get; set; }
        public float PointsPG { get; set; }
        public int PointsPGRank { get;set; }
        public float PPG { get; set; }
        public int PPGRank { get; set; }
        public float PPA { get; set; }
        public int PPARank { get; private set; }
        public float SHG { get; set; }
        public int SHGRank { get; set; }
        public float SHA { get; set; }
        public int SHARank { get; set; }
        public float ShotsPG { get; set; }
        public int ShotsRank { get; set; }
        public float ShootingPct { get; set; }
        public int ShootingRank { get; set; }
        public float FaceoffPct { get; set; }
        public int FaceoffRank { get; set; }
        public float GoalsAgainstPG { get; set; }
        public int GoalsAgainstPGRank { get; set; }
        public float GoalsAgainst { get; set; }
        public int GoalsAgainstRank { get; set; }
        public float Saves { get; set; }
        public int SavesRank { get; set; }
        public float SavePct { get; set; }
        public int SavePctRank { get; set; }
        public float ShotsAgainst { get; set; }
        public int ShotsAgainstRank { get;  set; }
        public float PenaltyMinutes { get; set; }
        public float PenaltyMinutesRank { get; set; }
    }
}