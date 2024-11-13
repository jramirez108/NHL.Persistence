using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Persistence.Models
{
    public class NHLPlayerOdds
    {
        public int Id { get; set; }
        public double Line { get; set; }
        public string Over { get; set; }
        public string Under { get; set; }
        public string Category { get; set; }
        public int? PlayerId { get; set; }
        public string PlayerName { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}