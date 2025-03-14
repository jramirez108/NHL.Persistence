﻿using System.ComponentModel;
using System.Text;

namespace NHL.Persistence.Models
{
    public class NHLPlayerStat
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public DateTime GameDate { get; set; }
        public int PlayerId { get; set; }
        public int Goals { get; set; }
        public int Assists {get; set;}
        public int Points { get; set; }
        public string PlusMinus {get; set;} = string.Empty;
        public int PenaltyMinutes {get; set;}
        public int ShotsTotal {get; set;}
        public float ShootingPct {get; set;}
        public int PowerPlayGoals {get; set;}
        public int PowerPlayAssists {get; set;}
        public int ShortHandedGoals {get; set;}
        public int ShortHandedAssists {get; set;}
        public int GameWinningGoals { get; set; }
        public int BlockedShots { get; set; }
        public int TakeAways { get; set; }
        public int Hits { get; set; }
        public string PowerPlayTimeOnIce { get; set; } = string.Empty;
        public string ShortHandedTimeOneIce { get; set; } = string.Empty;
        public string EventStregthTimeOnIce { get; set; } = string.Empty;
        public int MissedShots { get; set; }
        public int ShootoutGoals { get; set; }
        public int FaceOffsWon { get; set; }
        public int FaceOffLost { get; set; }
        public int GiveAways { get; set; }
        public int NumberOfPenalties { get; set; }
        public string TimeOnIcePerGame { get; set; } = string.Empty;
        public string Production { get; set; } = string.Empty;
        public int GoalsAgainst { get; set; } = 0;
        public int ShotsAgainst { get; set; } = 0;
        public int Saves { get; set; } = 0;
        public bool IsHomeGame { get; set; }
        public bool IsWin { get; set; }
        public string PlayersParticipated { get; set; } = string.Empty;
        public int OpposingTeamId { get; set; }
        public virtual NHLPlayer Player { get; set; }
        public virtual NHLTeam OpposingTeam { get; set; }

        public override string ToString()
        {
            PropertyDescriptorCollection coll = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder();
            foreach (PropertyDescriptor pd in coll)
            {
                if (pd.GetValue(this) != null)
                {
                    builder.Append(string.Format("\n{0} : {1}", pd.Name, pd.GetValue(this).ToString()));
                }
                
            }
            return builder.ToString();
        }
    }
}