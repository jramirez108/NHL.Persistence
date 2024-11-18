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
        public string Category { get; set; }
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
        public float Value { get; set; }
        public float PerGameValue { get; set; }
        public int Rank { get; set; }
        public int TeamId { get; set; }
    }
}