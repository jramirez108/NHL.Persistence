using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace NHL.Persistence.Models
{
    public class NHLPlayer
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public virtual NHLTeam Team { get; set; }
        public int JerseyNumber { get; set; }
        public string PositionGroup { get; set; }
        public int PositionId { get; set; }
        public string Hand { get; set; }
        public string PositionAbbreviation { get; set; }
        public string PositionName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int StatusId { get; set; }
        public virtual List<NHLPlayerStat> Stats { get; set; }
        public virtual List<EnhancedNHLPlayerOdds> EnhancedOdds { get; set; }
    }
}